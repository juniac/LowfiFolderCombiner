using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WK.Libraries.BetterFolderBrowserNS;

namespace LowfiCombiner {
  public partial class LowfiCombiner : Form {

    private BetterFolderBrowser betterFolderBrowser = new BetterFolderBrowser();
    private string targetFolder;
    private string destinationFolder;
    private int totalFiles = 0;
    private int moveProgress = 0;
    private Random random = new Random();
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
      
      string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
     
      if (Directory.Exists(path)) {
        targetFolderTextBox.Text = path;
        
        this.targetFolder = path;
        this.readTargetFolder();
        
      }
      
    }

    private void LowfiCombiner_DragEnter(object sender, DragEventArgs e) {
      if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
        e.Effect = DragDropEffects.Copy;
      } else {
        e.Effect = DragDropEffects.None;
      }
    }

    private void readTargetFolder() {
      try {
        totalFiles = 0;
        fileCountLabel.Text = totalFiles.ToString();
        folderListView.Items.Clear();
        // 폴더를 추가한다.
        DirectoryInfo dir = new DirectoryInfo(this.targetFolder);
        DirectoryInfo[] folders = dir.GetDirectories();

        foreach (DirectoryInfo folder in folders) {
          int fileCount = folder.GetFiles().Length;
          totalFiles = totalFiles + fileCount;
          ListViewItem item = new ListViewItem(folder.Name);
          item.SubItems.Add(fileCount.ToString()); // 크기, 폴더이므로 없음
          
          item.SubItems.Add(folder.LastWriteTime.ToString()); // 수정한 날짜

          folderListView.Items.Add(item);
        }
        fileCountLabel.Text = totalFiles.ToString();
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
      foreach (DirectoryInfo folder in folders) {
        FileInfo[] files = folder.GetFiles();
        foreach (FileInfo file in files) {
          string fileDestination = destinationFolder + '\\' + file.Name;
          //Debug.WriteLine(fileDestination);

          moveProgress = (int)Math.Round(((double)count / (double)totalFiles) * 1000);
          if (File.Exists(fileDestination)) {
            fileDestination = destinationFolder + '\\' + randomString(5) + '-' + file.Name;
          }
          File.Move(file.FullName, fileDestination);
          statusLabel.Invoke((MethodInvoker)delegate {
            statusLabel.Text = $"{file.Name} 이동중.. {moveProgress.ToString()}% - {count.ToString()} / {totalFiles.ToString()}";
          });
         
          //Debug.WriteLine(((double)count / (double)totalFiles) * 1000);
          fileBackgroundWorker.ReportProgress(moveProgress);
          count++;
        }
      }
    }

    private void fileBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
      fileProgressBar.Value = e.ProgressPercentage;
    }

    private void fileBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
      statusLabel.Text = "완료";
    }
  }
}
