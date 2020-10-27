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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowfiCombiner));
      this.targetGroupBox = new System.Windows.Forms.GroupBox();
      this.targetFolderTextBox = new System.Windows.Forms.TextBox();
      this.selectTargetFolderButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.fileCountLabel = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.countTextBox = new System.Windows.Forms.TextBox();
      this.numberTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.destinationFolderTextbox = new System.Windows.Forms.TextBox();
      this.destinationFolderButton = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.destinationTextBox = new System.Windows.Forms.TextBox();
      this.combineButton = new System.Windows.Forms.Button();
      this.totalFolderCountLabel = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.fileProgressBar = new System.Windows.Forms.ProgressBar();
      this.statusLabel = new System.Windows.Forms.Label();
      this.fileBackgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.tanosButton = new System.Windows.Forms.Button();
      this.deleteBackgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.resizeButton = new System.Windows.Forms.Button();
      this.resizeBackgroundWorker = new System.ComponentModel.BackgroundWorker();
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
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.ForeColor = System.Drawing.Color.Purple;
      this.label1.Location = new System.Drawing.Point(558, 114);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(142, 21);
      this.label1.TabIndex = 2;
      this.label1.Text = "총 jpg 파일 개수 :";
      // 
      // fileCountLabel
      // 
      this.fileCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.fileCountLabel.AutoSize = true;
      this.fileCountLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.fileCountLabel.ForeColor = System.Drawing.Color.Purple;
      this.fileCountLabel.Location = new System.Drawing.Point(741, 114);
      this.fileCountLabel.Name = "fileCountLabel";
      this.fileCountLabel.Size = new System.Drawing.Size(41, 21);
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
      this.groupBox1.Location = new System.Drawing.Point(34, 173);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(251, 127);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "폴더 이름 설정";
      // 
      // countTextBox
      // 
      this.countTextBox.Location = new System.Drawing.Point(124, 47);
      this.countTextBox.Name = "countTextBox";
      this.countTextBox.Size = new System.Drawing.Size(111, 21);
      this.countTextBox.TabIndex = 1;
      this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
      this.countTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countTextBox_KeyPress);
      // 
      // numberTextBox
      // 
      this.numberTextBox.Location = new System.Drawing.Point(124, 24);
      this.numberTextBox.Name = "numberTextBox";
      this.numberTextBox.Size = new System.Drawing.Size(111, 21);
      this.numberTextBox.TabIndex = 0;
      this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.Blue;
      this.label3.Location = new System.Drawing.Point(17, 50);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 12);
      this.label3.TabIndex = 1;
      this.label3.Text = "최종 이미지 번호:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(61, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 12);
      this.label2.TabIndex = 0;
      this.label2.Text = "폴더번호:";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.destinationFolderTextbox);
      this.groupBox2.Controls.Add(this.destinationFolderButton);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.destinationTextBox);
      this.groupBox2.Location = new System.Drawing.Point(292, 173);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(502, 127);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "생성폴더명";
      // 
      // destinationFolderTextbox
      // 
      this.destinationFolderTextbox.Location = new System.Drawing.Point(88, 27);
      this.destinationFolderTextbox.Name = "destinationFolderTextbox";
      this.destinationFolderTextbox.ReadOnly = true;
      this.destinationFolderTextbox.Size = new System.Drawing.Size(402, 21);
      this.destinationFolderTextbox.TabIndex = 3;
      // 
      // destinationFolderButton
      // 
      this.destinationFolderButton.Location = new System.Drawing.Point(6, 27);
      this.destinationFolderButton.Name = "destinationFolderButton";
      this.destinationFolderButton.Size = new System.Drawing.Size(75, 23);
      this.destinationFolderButton.TabIndex = 2;
      this.destinationFolderButton.Text = "저장폴더";
      this.destinationFolderButton.UseVisualStyleBackColor = true;
      this.destinationFolderButton.Click += new System.EventHandler(this.destinationFolderButton_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 66);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(285, 12);
      this.label4.TabIndex = 1;
      this.label4.Text = "폴더번호-총파일개수-(최종이미지번호+총파일개수)";
      // 
      // destinationTextBox
      // 
      this.destinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.destinationTextBox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.destinationTextBox.Location = new System.Drawing.Point(6, 83);
      this.destinationTextBox.Name = "destinationTextBox";
      this.destinationTextBox.ReadOnly = true;
      this.destinationTextBox.Size = new System.Drawing.Size(490, 33);
      this.destinationTextBox.TabIndex = 0;
      this.destinationTextBox.Text = "폴더번호-총파일개수-(최종이미지번호+총파일개수)";
      this.destinationTextBox.TextChanged += new System.EventHandler(this.destinationTextBox_TextChanged);
      // 
      // combineButton
      // 
      this.combineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.combineButton.BackColor = System.Drawing.SystemColors.Highlight;
      this.combineButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.combineButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.combineButton.Location = new System.Drawing.Point(671, 306);
      this.combineButton.Name = "combineButton";
      this.combineButton.Size = new System.Drawing.Size(123, 71);
      this.combineButton.TabIndex = 6;
      this.combineButton.Text = "합치기";
      this.combineButton.UseVisualStyleBackColor = false;
      this.combineButton.Click += new System.EventHandler(this.combineButton_Click);
      // 
      // totalFolderCountLabel
      // 
      this.totalFolderCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.totalFolderCountLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.totalFolderCountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.totalFolderCountLabel.Location = new System.Drawing.Point(422, 114);
      this.totalFolderCountLabel.Name = "totalFolderCountLabel";
      this.totalFolderCountLabel.Size = new System.Drawing.Size(74, 21);
      this.totalFolderCountLabel.TabIndex = 8;
      this.totalFolderCountLabel.Text = "0 개";
      // 
      // label6
      // 
      this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label6.Location = new System.Drawing.Point(304, 114);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(112, 21);
      this.label6.TabIndex = 7;
      this.label6.Text = "총 폴더 개수 :";
      // 
      // fileProgressBar
      // 
      this.fileProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fileProgressBar.Location = new System.Drawing.Point(34, 315);
      this.fileProgressBar.Maximum = 1000;
      this.fileProgressBar.Name = "fileProgressBar";
      this.fileProgressBar.Size = new System.Drawing.Size(303, 23);
      this.fileProgressBar.TabIndex = 9;
      // 
      // statusLabel
      // 
      this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.statusLabel.Location = new System.Drawing.Point(32, 341);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(305, 23);
      this.statusLabel.TabIndex = 10;
      this.statusLabel.Text = "대기중";
      this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // fileBackgroundWorker
      // 
      this.fileBackgroundWorker.WorkerReportsProgress = true;
      this.fileBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fileBackgroundWorker_DoWork);
      this.fileBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.fileBackgroundWorker_ProgressChanged);
      this.fileBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fileBackgroundWorker_RunWorkerCompleted);
      // 
      // tanosButton
      // 
      this.tanosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.tanosButton.BackColor = System.Drawing.Color.BlueViolet;
      this.tanosButton.ForeColor = System.Drawing.Color.White;
      this.tanosButton.Location = new System.Drawing.Point(533, 306);
      this.tanosButton.Name = "tanosButton";
      this.tanosButton.Size = new System.Drawing.Size(132, 71);
      this.tanosButton.TabIndex = 11;
      this.tanosButton.Text = "반 삭제";
      this.tanosButton.UseVisualStyleBackColor = false;
      this.tanosButton.Click += new System.EventHandler(this.tanosButton_Click);
      // 
      // deleteBackgroundWorker
      // 
      this.deleteBackgroundWorker.WorkerReportsProgress = true;
      this.deleteBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.deleteBackgroundWorker_DoWork);
      this.deleteBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.deleteBackgroundWorker_ProgressChanged_1);
      this.deleteBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.deleteBackgroundWorker_RunWorkerCompleted);
      // 
      // resizeButton
      // 
      this.resizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.resizeButton.BackColor = System.Drawing.Color.Salmon;
      this.resizeButton.ForeColor = System.Drawing.Color.White;
      this.resizeButton.Location = new System.Drawing.Point(395, 306);
      this.resizeButton.Name = "resizeButton";
      this.resizeButton.Size = new System.Drawing.Size(132, 71);
      this.resizeButton.TabIndex = 12;
      this.resizeButton.Text = "이미지크기줄이기";
      this.resizeButton.UseVisualStyleBackColor = false;
      this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
      // 
      // resizeBackgroundWorker
      // 
      this.resizeBackgroundWorker.WorkerReportsProgress = true;
      this.resizeBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.resizeBackgroundWorker_DoWork);
      this.resizeBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.resizeBackgroundWorker_ProgressChanged);
      this.resizeBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.resizeBackgroundWorker_RunWorkerCompleted);
      // 
      // LowfiCombiner
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 389);
      this.Controls.Add(this.resizeButton);
      this.Controls.Add(this.tanosButton);
      this.Controls.Add(this.statusLabel);
      this.Controls.Add(this.fileProgressBar);
      this.Controls.Add(this.totalFolderCountLabel);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.combineButton);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.fileCountLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.targetGroupBox);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label totalFolderCountLabel;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ProgressBar fileProgressBar;
    private System.Windows.Forms.Label statusLabel;
    private System.ComponentModel.BackgroundWorker fileBackgroundWorker;
    private System.Windows.Forms.TextBox destinationFolderTextbox;
    private System.Windows.Forms.Button destinationFolderButton;
    private System.Windows.Forms.Button tanosButton;
    private System.ComponentModel.BackgroundWorker deleteBackgroundWorker;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button resizeButton;
    private System.ComponentModel.BackgroundWorker resizeBackgroundWorker;
  }
}

