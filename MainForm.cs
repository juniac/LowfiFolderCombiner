using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WK.Libraries.BetterFolderBrowserNS;

namespace LowfiCombiner {
  public partial class LowfiCombiner : Form {

    private BetterFolderBrowser betterFolderBrowser = new BetterFolderBrowser();
    private string targetFolder;
    private string[] targetFolders;
    private string destinationFolder;
    private string unionFolder;
    private int totalFiles = 0;
    private int moveProgress = 0;
    private Random random = new Random();
    private FileInfo[] files;
    public LowfiCombiner() {
      InitializeComponent();
      betterFolderBrowser.Title = "폴더 선택하기...";
      betterFolderBrowser.Multiselect = false;
      fileProgressBar.Value = 0;
      

    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void selectTargetFolderButton_Click(object sender, EventArgs e) {
      this.selectTargetFolder();
    }

    private void selectTargetFolder() {
      if (betterFolderBrowser.ShowDialog() == DialogResult.OK) {
        string selectedFolder = betterFolderBrowser.SelectedFolder;
        targetFolderTextBox.Text = selectedFolder;
        this.targetFolder = selectedFolder;
        this.readTargetFolder();
        

      }
    }

    private void getDirectoryInfo(String path) {
      if (System.IO.Directory.Exists(path)) {
        System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(path);
        foreach(var item in directoryInfo.GetDirectories()) {

        }
      }
    }



    private void LowfiCombiner_DragDrop(object sender, DragEventArgs e) {
      string[] paths = ((string[])e.Data.GetData(DataFormats.FileDrop));

      
      if (paths.Length > 1) {
        Debug.WriteLine(paths.Length);
        this.targetFolders = paths;
        this.readTargetFolders();
      } else {
        string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

        if (Directory.Exists(path)) {
          targetFolderTextBox.Text = path;

          this.targetFolder = path;
          this.readTargetFolder();

        }
      }
      
      
    }

    private void LowfiCombiner_DragEnter(object sender, DragEventArgs e) {
      if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
        e.Effect = DragDropEffects.Copy;
      } else {
        e.Effect = DragDropEffects.None;
      }
    }

    private void readTargetFolders() {
      targetFoldersCountLabel.Text = $"{targetFolders.Length.ToString()} 개";
      foreach(var sub in targetFolders) {
        Debug.WriteLine(sub);
      }
    }
    private void readTargetFolder() {
      try {
        totalFiles = 0;
        fileCountLabel.Text = totalFiles.ToString();
        files = new FileInfo[] { };
        // 폴더를 추가한다.
        DirectoryInfo dir = new DirectoryInfo(this.targetFolder);
        DirectoryInfo[] folders = dir.GetDirectories("*", SearchOption.AllDirectories);
        totalFolderCountLabel.Text = $"{folders.Length.ToString()} 개";

        files = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
        FileInfo[] jpegFiles = dir.GetFiles("*.jpeg", SearchOption.AllDirectories);
        files = files.Concat(jpegFiles).ToArray();

        totalFiles = files.Length;
        fileCountLabel.Text = files.Length.ToString();
        makeDestinationFolderName();
        ////파일을 추가한다.
        //FileInfo[] files = dir.GetFiles();

        //foreach (FileInfo file in files) {
        //  ListViewItem item = new ListViewItem(file.Name);

        //  if (file.Length > 1024 * 1024 * 1024) {
        //    //지정된 문자열의 형식 항목을 해당 개체의 문자열 표현으로 바꿉니다. 
        //    //매개 변수는 문화권 별 서식 지정 정보를 제공합니다.
        //    item.SubItems.Add(String.Format("{0}GB", file.Length / 1024 / 1024 / 1024));
        //  } else if (file.Length > 1024 * 1024) {
        //    item.SubItems.Add
        //        (String.Format("{0}MB", file.Length / 1024 / 1024));
        //  } else if (file.Length > 1024) {
        //    item.SubItems.Add
        //        (String.Format("{0}KB", file.Length / 1024));
        //  } else {
        //    item.SubItems.Add
        //        (String.Format("{0}KB", 1));
        //  }
        //  item.SubItems.Add(String.Format("{0}", file.Extension));
        //  item.ImageIndex = 2;
        //  item.SubItems.Add(file.LastWriteTime.ToString()); //수정한날짜
        //  listView1.Items.Add(item);
        //}

      } catch (Exception ex) {
        MessageBox.Show(ex.ToString());
      }
    }

    private void numberTextBox_TextChanged(object sender, EventArgs e) {
      makeDestinationFolderName();
    }

    private void countTextBox_TextChanged(object sender, EventArgs e) {
      makeDestinationFolderName();
    }

    private void makeDestinationFolderName() {
      string numberText = "없음";
      string countText = "없음";
      int lastCount = 0;
      int total = 0;
      if (String.IsNullOrEmpty(numberTextBox.Text) == false) {
        numberText = numberTextBox.Text;
      }
      if (String.IsNullOrEmpty(countTextBox.Text) == false) {
        countText = countTextBox.Text;
        lastCount = Convert.ToInt32(countText);
        
      }
      total = lastCount + totalFiles;

      destinationTextBox.Text = $"{numberText}-{totalFiles.ToString()}-{total.ToString()}";
    }

    private void countTextBox_KeyPress(object sender, KeyPressEventArgs e) {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
        e.Handled = true;
      }

      // only allow one decimal point
      if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
        e.Handled = true;
      }
    }

    private void destinationTextBox_TextChanged(object sender, EventArgs e) {

    }

    private void combineButton_Click(object sender, EventArgs e) {
      if (String.IsNullOrEmpty(this.targetFolder)) {
        this.selectTargetFolder();
        return;
      }
      DirectoryInfo dir = Directory.GetParent(this.targetFolder);
      destinationFolder = dir.FullName + '\\' + destinationTextBox.Text;

      if (System.IO.Directory.Exists(destinationFolder)) {
        var confirmResult = MessageBox.Show("폴더가 이미 존재합니다. 덮어쓰시겠습니까?", "덮어쓰기", MessageBoxButtons.YesNo); 
        if (confirmResult == DialogResult.Yes) {
          Directory.CreateDirectory(destinationFolder);
          moveFiles();
        }
      } else {
        Directory.CreateDirectory(destinationFolder);
        moveFiles();
      }

    }

    private void moveFiles() {
      moveProgress = 0;
      statusLabel.Text = "폴더 합치는 중...";
      fileBackgroundWorker.RunWorkerAsync();

    }

    public string randomString(int length) {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
      return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    private void fileBackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
      DirectoryInfo dir = new DirectoryInfo(this.targetFolder);
      DirectoryInfo[] folders = dir.GetDirectories();

      int count = 0;
      
      foreach (FileInfo file in files) {
        string fileDestination = destinationFolder + '\\' + file.Name;
        //Debug.WriteLine(fileDestination);

        moveProgress = (int)Math.Round(((double)count / (double)totalFiles) * 1000);
        string extension = Path.GetExtension(file.FullName).ToUpper();
        //string lastFolder = Path.GetFileName(file.FullName.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
        string folderPath = Path.GetDirectoryName(file.FullName);

        folderPath = folderPath.Replace(this.targetFolder, "");

        if ((folderPath.IndexOf(":") == 1) || (folderPath.IndexOf("\\\\") == 0)) {
          folderPath = folderPath.Substring(2);
        }
        if (folderPath.IndexOf("\\") > 0) {
          folderPath = folderPath.Substring(folderPath.IndexOf("\\"));
        }
        folderPath = folderPath.Substring(1);
        string[] subFolders = folderPath.Split(Path.DirectorySeparatorChar);

        if (folderPath.Length > 200) {
          int index = 0;
          foreach (string sub in subFolders) {
            //Console.WriteLine(dir);
            if (sub.Length > 10) {
              subFolders[index] = sub.Substring(0, 5);
            }
            index++;
          }
        }
        

        //string[] subFolders = folderPath.Split(Path.DirectorySeparatorChar);
        string folderName = string.Join("-", subFolders);
        
        //if ((folderName.IndexOf(":") == 1) || (folderName.IndexOf("\\\\") == 0)) {
        //  folderName = folderName.Substring(2); 
        //}
        //if (folderName.IndexOf("\\") > 0) { 
        //  folderName = folderName.Substring(folderName.IndexOf("\\"));
        //}
        //folderName = folderName.Substring(1);

        //folderName = folderName.Replace("\\", "-");
        //Debug.WriteLine(folderName);

        //string folderName = "";

        if (extension == ".JPEG" || extension == ".JPG") {
          //if (File.Exists(fileDestination)) {
          //  fileDestination = destinationFolder + '\\' + randomString(5) + '-' + file.Name;
          //}
          folderName.Replace("^", "");
          folderName.Replace("?", "");
          folderName.Replace("|", "");
          folderName.Replace("[", "");
          folderName.Replace("]", "");
          folderName.Replace("`", "");
          folderName.Replace("\\", "");


          fileDestination = destinationFolder + '\\' + folderName + '-' + file.Name;
          
          //Debug.WriteLine(fileDestination);
          //File.Copy(file.FullName, fileDestination);
          File.Move(file.FullName, fileDestination);

        } else {
          //File.Delete(file.FullName);
        }
          
        statusLabel.Invoke((MethodInvoker)delegate {
          statusLabel.Text = $"{file.Name} 이동중.. {(moveProgress / 10).ToString()}% - {count.ToString()} / {totalFiles.ToString()}";
        });
         
        //Debug.WriteLine(((double)count / (double)totalFiles) * 1000);
        fileBackgroundWorker.ReportProgress(moveProgress);
        count++;
      }
      
    }

    private void fileBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
      fileProgressBar.Value = e.ProgressPercentage;
    }

    private void fileBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
      statusLabel.Text = "완료";
      fileProgressBar.Value = 0;
      MessageBox.Show("폴더 합치기가 완료되었습니다.");
    }

    private void destinationFolderButton_Click(object sender, EventArgs e) {
      if (betterFolderBrowser.ShowDialog() == DialogResult.OK) {
        string selectedFolder = betterFolderBrowser.SelectedFolder;
        destinationFolderTextbox.Text = selectedFolder;
      }
    }

    private void tanosButton_Click(object sender, EventArgs e) {
      if (String.IsNullOrEmpty(this.targetFolder)) {
        this.selectTargetFolder();
        return;
      }
      moveProgress = 0;
      statusLabel.Text = "파일 반 삭제중...";
      deleteBackgroundWorker.RunWorkerAsync();
    }

    private void deleteBackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
      DirectoryInfo dir = new DirectoryInfo(this.targetFolder);
      DirectoryInfo[] folders = dir.GetDirectories();

      int count = 0;

      //Parallel.ForEach(files, file => {
      foreach (FileInfo file in files) {
        string fileDestination = destinationFolder + '\\' + file.Name;
        //Debug.WriteLine(fileDestination);

        moveProgress = (int)Math.Round(((double)count / (double)totalFiles) * 1000);
        string extension = Path.GetExtension(file.FullName).ToUpper();
        if (extension == ".JPEG" || extension == ".JPG") {
          if (File.Exists(fileDestination)) {
            fileDestination = destinationFolder + '\\' + randomString(5) + '-' + file.Name;
          }
          Debug.WriteLine(file.FullName);
          //File.Copy(file.FullName, fileDestination);
          if (count % 2 == 0) {
            File.Delete(file.FullName);
          }


        } else {
          //File.Delete(file.FullName);
        }

        statusLabel.Invoke((MethodInvoker)delegate {
          statusLabel.Text = $"{file.Name} 삭제중.. {(moveProgress / 10).ToString()}% - {count.ToString()} / {totalFiles.ToString()}";
        });

        //Debug.WriteLine(((double)count / (double)totalFiles) * 1000);
        deleteBackgroundWorker.ReportProgress(moveProgress);
        count++;
      //});
      }

    }

    private void deleteBackgroundWorker_ProgressChanged_1(object sender, ProgressChangedEventArgs e) {
      fileProgressBar.Value = e.ProgressPercentage;
    }

    private void deleteBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
      statusLabel.Text = "완료";
      fileProgressBar.Value = 0;
      readTargetFolder();
      MessageBox.Show("이미지 삭제가 완료되었습니다");
    }


    private void resizeButton_Click(object sender, EventArgs e) {
      moveProgress = 0;
      statusLabel.Text = "이미지 리사이즈중...";
      resizeBackgroundWorker.RunWorkerAsync();
    }

    private void resizeBackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
      if (String.IsNullOrEmpty(this.targetFolder)) {
        this.selectTargetFolder();
        return;
      }
      DirectoryInfo dir = new DirectoryInfo(this.targetFolder);
      DirectoryInfo[] folders = dir.GetDirectories();

      int count = 0;
      Parallel.ForEach(files, file => {
        moveProgress = (int)Math.Round(((double)count / (double)totalFiles) * 1000);
        string extension = Path.GetExtension(file.FullName).ToUpper();
        if (extension == ".JPEG" || extension == ".JPG") {
          SaveScaleImage(file.FullName);
        }

        statusLabel.Invoke((MethodInvoker)delegate {
          statusLabel.Text = $"{file.Name} 리사이즈중.. {(moveProgress / 10).ToString()}% - {count.ToString()} / {totalFiles.ToString()}";
        });

        //Debug.WriteLine(((double)count / (double)totalFiles) * 1000);
        resizeBackgroundWorker.ReportProgress(moveProgress);
        count++;
      });
      //foreach (FileInfo file in files) {
      //  moveProgress = (int)Math.Round(((double)count / (double)totalFiles) * 1000);
      //  string extension = Path.GetExtension(file.FullName).ToUpper();
      //  if (extension == ".JPEG" || extension == ".JPG") {
      //    SaveScaleImage(file.FullName);
      //  }

      //  statusLabel.Invoke((MethodInvoker)delegate {
      //    statusLabel.Text = $"{file.Name} 리사이즈중.. {(moveProgress / 10).ToString()}% - {count.ToString()} / {totalFiles.ToString()}";
      //  });

      //  //Debug.WriteLine(((double)count / (double)totalFiles) * 1000);
      //  resizeBackgroundWorker.ReportProgress(moveProgress);
      //  count++;

      //}
    }

    private void resizeBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
      fileProgressBar.Value = e.ProgressPercentage;
    }

    private void resizeBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
      statusLabel.Text = "완료";
      fileProgressBar.Value = 0;
      readTargetFolder();
      MessageBox.Show("이미지 리사이즈가 완료되었습니다");
    }

    public void SaveScaleImage(string filePath) {

      var image = Bitmap.FromFile(filePath);
      int maxSize = 1500;
      if (image.Width < maxSize && image.Height < maxSize) {
        return;
      }
      foreach (var prop in image.PropertyItems) {
        if ((prop.Id == 0x0112 || prop.Id == 5029 || prop.Id == 274)) {
          var value = (int)prop.Value[0];
          if (value == 6) {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            break;
          } else if (value == 8) {
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            break;
          } else if (value == 3) {
            image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            break;
          }
        }
      }
        

      var ratioX = (double)maxSize / image.Width;
      var ratioY = (double)maxSize / image.Height;
      var ratio = Math.Min(ratioX, ratioY);

      var newWidth = (int)(image.Width * ratio);
      var newHeight = (int)(image.Height * ratio);

      using (var newImage = new Bitmap(newWidth, newHeight))
      using (var graphics = Graphics.FromImage(newImage)) {
        graphics.CompositingMode = CompositingMode.SourceCopy;
        graphics.CompositingQuality = CompositingQuality.HighSpeed;
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        graphics.DrawImage(image, 0, 0, newWidth, newHeight);
        image.Dispose();
        newImage.Save(filePath, ImageFormat.Jpeg);
      }
      System.GC.Collect(0, GCCollectionMode.Forced);
      System.GC.WaitForFullGCComplete();
    }
    



    private void makeNameButton_Click(object sender, EventArgs e) {
      string now = DateTime.Now.ToString("yyyy-MM-dd HH시mm분ss초");
      unionFolderName.Text = now;
    }

    private void unionButton_Click(object sender, EventArgs e) {
      moveProgress = 0;
     
      if (targetFolders.Length > 1 && !String.IsNullOrEmpty(targetFolders[0])) {
        statusLabel.Text = "폴더 합치는 중...";
        Debug.WriteLine(targetFolders);
        Debug.WriteLine(targetFolders.Length);
        DirectoryInfo dir = Directory.GetParent(targetFolders[0]);
        if (String.IsNullOrEmpty(unionFolderName.Text)) {
          string now = DateTime.Now.ToString("yyyy-MM-dd HH시mm분ss초");
          unionFolderName.Text = now;
        }
        unionFolder = dir.FullName + '\\' + unionFolderName.Text + "-(" + targetFolders.Length.ToString() + ")";
        if (System.IO.Directory.Exists(unionFolder)) {
          var confirmResult = MessageBox.Show("폴더가 이미 존재합니다. 덮어쓰시겠습니까?", "덮어쓰기", MessageBoxButtons.YesNo);
          if (confirmResult == DialogResult.Yes) {
            Directory.CreateDirectory(unionFolder);
            unionBackgroundWorker.RunWorkerAsync();
          }
        } else {
          Directory.CreateDirectory(unionFolder);
          unionBackgroundWorker.RunWorkerAsync();

        }
       
      } else {
        MessageBox.Show("합칠 폴더가 없습니다.");
      }
      
    }

    private void unionBackgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
      //Debug.WriteLine(unionFolder);
      foreach(string dir in targetFolders) {
        string lastPath = Path.GetFileName(dir);
        string destination = unionFolder + '\\' + lastPath;
        Directory.Move(dir, destination);

      }
    }

    private void unionBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
      fileProgressBar.Value = e.ProgressPercentage;
    }

    private void unionBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
      statusLabel.Text = "완료";
      fileProgressBar.Value = 0;
      Array.Clear(this.targetFolders, 0, this.targetFolders.Length);
      //if (Directory.Exists(path)) {
      //  Process.Start(path);
      //}
      targetFoldersCountLabel.Text = "0 개";
      MessageBox.Show("폴더 합치기가 완료되었습니다");

    }
  }
}
