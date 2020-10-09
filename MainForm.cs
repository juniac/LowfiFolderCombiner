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

    public LowfiCombiner() {
      InitializeComponent();
      betterFolderBrowser.Title = "폴더 선택하기...";
      betterFolderBrowser.Multiselect = false;

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
  }
}
