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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numberTextBox = new System.Windows.Forms.TextBox();
      this.countTextBox = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.destinationTextBox = new System.Windows.Forms.TextBox();
      this.combineButton = new System.Windows.Forms.Button();
      this.targetGroupBox.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
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
      this.selectTargetFolderButton.BackColor = System.Drawing.Color.Coral;
      this.selectTargetFolderButton.Location = new System.Drawing.Point(7, 21);
      this.selectTargetFolderButton.Name = "selectTargetFolderButton";
      this.selectTargetFolderButton.Size = new System.Drawing.Size(136, 25);
      this.selectTargetFolderButton.TabIndex = 0;
      this.selectTargetFolderButton.Text = "대상 폴더 선택";
      this.selectTargetFolderButton.UseVisualStyleBackColor = false;
      this.selectTargetFolderButton.Click += new System.EventHandler(this.selectTargetFolderButton_Click);
      // 
      // folderListView
      // 
      this.folderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 527);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(81, 12);
      this.label1.TabIndex = 2;
      this.label1.Text = "총 파일 개수 :";
      // 
      // fileCountLabel
      // 
      this.fileCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.fileCountLabel.AutoSize = true;
      this.fileCountLabel.Location = new System.Drawing.Point(108, 527);
      this.fileCountLabel.Name = "fileCountLabel";
      this.fileCountLabel.Size = new System.Drawing.Size(27, 12);
      this.fileCountLabel.TabIndex = 3;
      this.fileCountLabel.Text = "0 개";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.groupBox1.Controls.Add(this.countTextBox);
      this.groupBox1.Controls.Add(this.numberTextBox);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(22, 556);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(251, 82);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "폴더 이름 설정";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(61, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 12);
      this.label2.TabIndex = 0;
      this.label2.Text = "폴더번호:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(17, 50);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 12);
      this.label3.TabIndex = 1;
      this.label3.Text = "최종 이미지 번호:";
      // 
      // numberTextBox
      // 
      this.numberTextBox.Location = new System.Drawing.Point(124, 24);
      this.numberTextBox.Name = "numberTextBox";
      this.numberTextBox.Size = new System.Drawing.Size(111, 21);
      this.numberTextBox.TabIndex = 0;
      this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
      // 
      // countTextBox
      // 
      this.countTextBox.Location = new System.Drawing.Point(124, 47);
      this.countTextBox.Name = "countTextBox";
      this.countTextBox.Size = new System.Drawing.Size(111, 21);
      this.countTextBox.TabIndex = 1;
      this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.destinationTextBox);
      this.groupBox2.Location = new System.Drawing.Point(280, 556);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(502, 82);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "생성폴더명";
      // 
      // destinationTextBox
      // 
      this.destinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.destinationTextBox.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.destinationTextBox.Location = new System.Drawing.Point(6, 23);
      this.destinationTextBox.Name = "destinationTextBox";
      this.destinationTextBox.ReadOnly = true;
      this.destinationTextBox.Size = new System.Drawing.Size(490, 43);
      this.destinationTextBox.TabIndex = 0;
      this.destinationTextBox.Text = "폴더번호-총파일개수-최종이미지번호";
      // 
      // combineButton
      // 
      this.combineButton.BackColor = System.Drawing.SystemColors.Highlight;
      this.combineButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.combineButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.combineButton.Location = new System.Drawing.Point(671, 644);
      this.combineButton.Name = "combineButton";
      this.combineButton.Size = new System.Drawing.Size(111, 70);
      this.combineButton.TabIndex = 6;
      this.combineButton.Text = "합치기";
      this.combineButton.UseVisualStyleBackColor = false;
      // 
      // LowfiCombiner
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 726);
      this.Controls.Add(this.combineButton);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
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
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
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
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox countTextBox;
    private System.Windows.Forms.TextBox numberTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox destinationTextBox;
    private System.Windows.Forms.Button combineButton;
  }
}

