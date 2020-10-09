namespace LowfiCombiner {
  partial class LowfiCombiner {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent() {
      this.targetGroupBox = new System.Windows.Forms.GroupBox();
      this.targetFolderTextBox = new System.Windows.Forms.TextBox();
      this.selectTargetFolderButton = new System.Windows.Forms.Button();
      this.folderListView = new System.Windows.Forms.ListView();
      this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colModigy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label1 = new System.Windows.Forms.Label();
      this.fileCountLabel = new System.Windows.Forms.Label();
      this.targetGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // targetGroupBox
      // 
      this.targetGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.targetGroupBox.Controls.Add(this.targetFolderTextBox);
      this.targetGroupBox.Controls.Add(this.selectTargetFolderButton);
      this.targetGroupBox.Location = new System.Drawing.Point(13, 13);
      this.targetGroupBox.Name = "targetGroupBox";
      this.targetGroupBox.Size = new System.Drawing.Size(775, 63);
      this.targetGroupBox.TabIndex = 0;
      this.targetGroupBox.TabStop = false;
      this.targetGroupBox.Text = "대상 폴더";
      // 
      // targetFolderTextBox
      // 
      this.targetFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.targetFolderTextBox.Location = new System.Drawing.Point(149, 21);
      this.targetFolderTextBox.Multiline = true;
      this.targetFolderTextBox.Name = "targetFolderTextBox";
      this.targetFolderTextBox.ReadOnly = true;
      this.targetFolderTextBox.Size = new System.Drawing.Size(620, 25);
      this.targetFolderTextBox.TabIndex = 1;
      this.targetFolderTextBox.Text = "...";
      // 
      // selectTargetFolderButton
      // 
      this.selectTargetFolderButton.Location = new System.Drawing.Point(7, 21);
      this.selectTargetFolderButton.Name = "selectTargetFolderButton";
      this.selectTargetFolderButton.Size = new System.Drawing.Size(136, 25);
      this.selectTargetFolderButton.TabIndex = 0;
      this.selectTargetFolderButton.Text = "대상 폴더 선택";
      this.selectTargetFolderButton.UseVisualStyleBackColor = true;
      this.selectTargetFolderButton.Click += new System.EventHandler(this.selectTargetFolderButton_Click);
      // 
      // folderListView
      // 
      this.folderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCount,
            this.colModigy});
      this.folderListView.HideSelection = false;
      this.folderListView.Location = new System.Drawing.Point(20, 83);
      this.folderListView.Name = "folderListView";
      this.folderListView.Size = new System.Drawing.Size(762, 437);
      this.folderListView.TabIndex = 1;
      this.folderListView.UseCompatibleStateImageBehavior = false;
      this.folderListView.View = System.Windows.Forms.View.Details;
      // 
      // colName
      // 
      this.colName.Text = "폴더명";
      this.colName.Width = 401;
      // 
      // colCount
      // 
      this.colCount.Text = "파일개수";
      this.colCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.colCount.Width = 150;
      // 
      // colModigy
      // 
      this.colModigy.Text = "수정한날짜";
      this.colModigy.Width = 200;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 527);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(81, 12);
      this.label1.TabIndex = 2;
      this.label1.Text = "총 파일 개수 :";
      // 
      // fileCountLabel
      // 
      this.fileCountLabel.AutoSize = true;
      this.fileCountLabel.Location = new System.Drawing.Point(108, 527);
      this.fileCountLabel.Name = "fileCountLabel";
      this.fileCountLabel.Size = new System.Drawing.Size(27, 12);
      this.fileCountLabel.TabIndex = 3;
      this.fileCountLabel.Text = "0 개";
      // 
      // LowfiCombiner
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 672);
      this.Controls.Add(this.fileCountLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.folderListView);
      this.Controls.Add(this.targetGroupBox);
      this.Name = "LowfiCombiner";
      this.Text = "LOWFI 폴더 합치기";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.LowfiCombiner_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.LowfiCombiner_DragEnter);
      this.targetGroupBox.ResumeLayout(false);
      this.targetGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.GroupBox targetGroupBox;
    private System.Windows.Forms.TextBox targetFolderTextBox;
    private System.Windows.Forms.Button selectTargetFolderButton;
    private System.Windows.Forms.ListView folderListView;
    private System.Windows.Forms.ColumnHeader colName;
    private System.Windows.Forms.ColumnHeader colCount;
    private System.Windows.Forms.ColumnHeader colModigy;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label fileCountLabel;
  }
}

