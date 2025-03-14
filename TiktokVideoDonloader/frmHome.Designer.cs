namespace TiktokVideoDonloader
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDownloadList = new GroupBox();
            btnDownload = new Button();
            btnSelectFile = new Button();
            txtFileImport = new TextBox();
            lblListUsers = new Label();
            grbDownloader = new GroupBox();
            numericThread = new NumericUpDown();
            btnOpen = new Button();
            txtStatus = new TextBox();
            lblStatus = new Label();
            txtAccount = new TextBox();
            lblAccount = new Label();
            txtVideoId = new TextBox();
            lblId = new Label();
            txtUrlVideo = new TextBox();
            lblUrl = new Label();
            lblProgress = new Label();
            progressBar = new ProgressBar();
            txtThongKe = new TextBox();
            lblThongKe = new Label();
            lblThread = new Label();
            chkChayAn = new CheckBox();
            btnStop = new Button();
            btnStart = new Button();
            txtUrlUser = new TextBox();
            lblUrlUser = new Label();
            btnSelectFolder = new Button();
            txtPathSave = new TextBox();
            lblPathSave = new Label();
            tabControl1 = new TabControl();
            tabVideoList = new TabPage();
            dgvVideoList = new DataGridView();
            tabImportFile = new TabPage();
            dgvImportFile = new DataGridView();
            grpDownloadList.SuspendLayout();
            grbDownloader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericThread).BeginInit();
            tabControl1.SuspendLayout();
            tabVideoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVideoList).BeginInit();
            tabImportFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportFile).BeginInit();
            SuspendLayout();
            // 
            // grpDownloadList
            // 
            grpDownloadList.Controls.Add(btnDownload);
            grpDownloadList.Controls.Add(btnSelectFile);
            grpDownloadList.Controls.Add(txtFileImport);
            grpDownloadList.Controls.Add(lblListUsers);
            grpDownloadList.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDownloadList.Location = new Point(23, 307);
            grpDownloadList.Margin = new Padding(3, 4, 3, 4);
            grpDownloadList.Name = "grpDownloadList";
            grpDownloadList.Padding = new Padding(3, 4, 3, 4);
            grpDownloadList.Size = new Size(638, 99);
            grpDownloadList.TabIndex = 23;
            grpDownloadList.TabStop = false;
            grpDownloadList.Text = "Download List from txt File";
            // 
            // btnDownload
            // 
            btnDownload.Font = new Font("Segoe UI", 7.8F);
            btnDownload.Location = new Point(520, 61);
            btnDownload.Margin = new Padding(3, 4, 3, 4);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(103, 30);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Font = new Font("Segoe UI", 7.8F);
            btnSelectFile.Location = new Point(520, 28);
            btnSelectFile.Margin = new Padding(3, 4, 3, 4);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(103, 25);
            btnSelectFile.TabIndex = 2;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFileImport
            // 
            txtFileImport.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileImport.Location = new Point(80, 28);
            txtFileImport.Margin = new Padding(3, 4, 3, 4);
            txtFileImport.Name = "txtFileImport";
            txtFileImport.Size = new Size(434, 25);
            txtFileImport.TabIndex = 1;
            // 
            // lblListUsers
            // 
            lblListUsers.AutoSize = true;
            lblListUsers.Font = new Font("Segoe UI", 7.8F);
            lblListUsers.Location = new Point(5, 28);
            lblListUsers.Name = "lblListUsers";
            lblListUsers.Size = new Size(77, 17);
            lblListUsers.TabIndex = 0;
            lblListUsers.Text = "Import File :";
            // 
            // grbDownloader
            // 
            grbDownloader.Controls.Add(numericThread);
            grbDownloader.Controls.Add(btnOpen);
            grbDownloader.Controls.Add(txtStatus);
            grbDownloader.Controls.Add(lblStatus);
            grbDownloader.Controls.Add(txtAccount);
            grbDownloader.Controls.Add(lblAccount);
            grbDownloader.Controls.Add(txtVideoId);
            grbDownloader.Controls.Add(lblId);
            grbDownloader.Controls.Add(txtUrlVideo);
            grbDownloader.Controls.Add(lblUrl);
            grbDownloader.Controls.Add(lblProgress);
            grbDownloader.Controls.Add(progressBar);
            grbDownloader.Controls.Add(txtThongKe);
            grbDownloader.Controls.Add(lblThongKe);
            grbDownloader.Controls.Add(lblThread);
            grbDownloader.Controls.Add(chkChayAn);
            grbDownloader.Controls.Add(btnStop);
            grbDownloader.Controls.Add(btnStart);
            grbDownloader.Controls.Add(txtUrlUser);
            grbDownloader.Controls.Add(lblUrlUser);
            grbDownloader.Controls.Add(btnSelectFolder);
            grbDownloader.Controls.Add(txtPathSave);
            grbDownloader.Controls.Add(lblPathSave);
            grbDownloader.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDownloader.Location = new Point(23, 12);
            grbDownloader.Name = "grbDownloader";
            grbDownloader.Size = new Size(638, 288);
            grbDownloader.TabIndex = 4;
            grbDownloader.TabStop = false;
            // 
            // numericThread
            // 
            numericThread.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericThread.Location = new Point(243, 79);
            numericThread.Margin = new Padding(3, 4, 3, 4);
            numericThread.Name = "numericThread";
            numericThread.Size = new Size(122, 25);
            numericThread.TabIndex = 48;
            numericThread.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 7.8F);
            btnOpen.Location = new Point(503, 250);
            btnOpen.Margin = new Padding(3, 4, 3, 4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(120, 31);
            btnOpen.TabIndex = 47;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 7.20000029F);
            txtStatus.Location = new Point(80, 219);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(543, 23);
            txtStatus.TabIndex = 46;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 7.8F);
            lblStatus.Location = new Point(26, 219);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 17);
            lblStatus.TabIndex = 45;
            lblStatus.Text = "Status :";
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Segoe UI", 7.20000029F);
            txtAccount.Location = new Point(395, 188);
            txtAccount.Margin = new Padding(3, 4, 3, 4);
            txtAccount.Name = "txtAccount";
            txtAccount.ReadOnly = true;
            txtAccount.Size = new Size(228, 23);
            txtAccount.TabIndex = 44;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 7.8F);
            lblAccount.Location = new Point(328, 189);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(61, 17);
            lblAccount.TabIndex = 43;
            lblAccount.Text = "Account :";
            // 
            // txtVideoId
            // 
            txtVideoId.Font = new Font("Segoe UI", 7.20000029F);
            txtVideoId.Location = new Point(80, 188);
            txtVideoId.Margin = new Padding(3, 4, 3, 4);
            txtVideoId.Name = "txtVideoId";
            txtVideoId.ReadOnly = true;
            txtVideoId.Size = new Size(228, 23);
            txtVideoId.TabIndex = 42;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 7.8F);
            lblId.Location = new Point(49, 188);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 17);
            lblId.TabIndex = 41;
            lblId.Text = "ID :";
            // 
            // txtUrlVideo
            // 
            txtUrlVideo.Font = new Font("Segoe UI", 7.20000029F);
            txtUrlVideo.Location = new Point(80, 157);
            txtUrlVideo.Margin = new Padding(3, 4, 3, 4);
            txtUrlVideo.Name = "txtUrlVideo";
            txtUrlVideo.ReadOnly = true;
            txtUrlVideo.Size = new Size(543, 23);
            txtUrlVideo.TabIndex = 40;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Font = new Font("Segoe UI", 7.8F);
            lblUrl.Location = new Point(44, 157);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(32, 17);
            lblUrl.TabIndex = 39;
            lblUrl.Text = "Url :";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Location = new Point(373, 129);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(123, 17);
            lblProgress.TabIndex = 38;
            lblProgress.Text = "Download Progress";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(80, 124);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(287, 22);
            progressBar.TabIndex = 37;
            // 
            // txtThongKe
            // 
            txtThongKe.Font = new Font("Segoe UI", 7.20000029F);
            txtThongKe.Location = new Point(474, 80);
            txtThongKe.Margin = new Padding(3, 4, 3, 4);
            txtThongKe.Name = "txtThongKe";
            txtThongKe.ReadOnly = true;
            txtThongKe.Size = new Size(149, 23);
            txtThongKe.TabIndex = 36;
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Font = new Font("Segoe UI", 7.8F);
            lblThongKe.Location = new Point(400, 84);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(71, 17);
            lblThongKe.TabIndex = 35;
            lblThongKe.Text = "Thống Kê :";
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Segoe UI", 7.8F);
            lblThread.Location = new Point(181, 84);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(56, 17);
            lblThread.TabIndex = 34;
            lblThread.Text = "Thread :";
            // 
            // chkChayAn
            // 
            chkChayAn.AutoSize = true;
            chkChayAn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkChayAn.Location = new Point(79, 83);
            chkChayAn.Margin = new Padding(3, 4, 3, 4);
            chkChayAn.Name = "chkChayAn";
            chkChayAn.Size = new Size(77, 21);
            chkChayAn.TabIndex = 33;
            chkChayAn.Text = "Chạy Ẩn";
            chkChayAn.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 7.8F);
            btnStop.Location = new Point(551, 48);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(72, 24);
            btnStop.TabIndex = 32;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 7.8F);
            btnStart.Location = new Point(473, 48);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(72, 24);
            btnStart.TabIndex = 31;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtUrlUser
            // 
            txtUrlUser.Font = new Font("Segoe UI", 7.20000029F);
            txtUrlUser.Location = new Point(80, 48);
            txtUrlUser.Margin = new Padding(3, 4, 3, 4);
            txtUrlUser.Name = "txtUrlUser";
            txtUrlUser.Size = new Size(387, 23);
            txtUrlUser.TabIndex = 30;
            // 
            // lblUrlUser
            // 
            lblUrlUser.AutoSize = true;
            lblUrlUser.Font = new Font("Segoe UI", 7.8F);
            lblUrlUser.Location = new Point(13, 51);
            lblUrlUser.Name = "lblUrlUser";
            lblUrlUser.Size = new Size(63, 17);
            lblUrlUser.TabIndex = 29;
            lblUrlUser.Text = "Url User :";
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Segoe UI", 7.8F);
            btnSelectFolder.Location = new Point(473, 15);
            btnSelectFolder.Margin = new Padding(3, 4, 3, 4);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(150, 25);
            btnSelectFolder.TabIndex = 28;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // txtPathSave
            // 
            txtPathSave.Font = new Font("Segoe UI", 7.20000029F);
            txtPathSave.Location = new Point(80, 15);
            txtPathSave.Margin = new Padding(3, 4, 3, 4);
            txtPathSave.Name = "txtPathSave";
            txtPathSave.Size = new Size(387, 23);
            txtPathSave.TabIndex = 27;
            // 
            // lblPathSave
            // 
            lblPathSave.AutoSize = true;
            lblPathSave.Font = new Font("Segoe UI", 7.8F);
            lblPathSave.Location = new Point(5, 16);
            lblPathSave.Name = "lblPathSave";
            lblPathSave.Size = new Size(71, 17);
            lblPathSave.TabIndex = 26;
            lblPathSave.Text = "Path Save :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabVideoList);
            tabControl1.Controls.Add(tabImportFile);
            tabControl1.Location = new Point(23, 423);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(642, 392);
            tabControl1.TabIndex = 24;
            // 
            // tabVideoList
            // 
            tabVideoList.Controls.Add(dgvVideoList);
            tabVideoList.Location = new Point(4, 29);
            tabVideoList.Name = "tabVideoList";
            tabVideoList.Padding = new Padding(3);
            tabVideoList.Size = new Size(634, 359);
            tabVideoList.TabIndex = 0;
            tabVideoList.Text = "Video List";
            tabVideoList.UseVisualStyleBackColor = true;
            // 
            // dgvVideoList
            // 
            dgvVideoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVideoList.Location = new Point(9, 6);
            dgvVideoList.Name = "dgvVideoList";
            dgvVideoList.RowHeadersWidth = 51;
            dgvVideoList.Size = new Size(625, 347);
            dgvVideoList.TabIndex = 0;
            // 
            // tabImportFile
            // 
            tabImportFile.Controls.Add(dgvImportFile);
            tabImportFile.Location = new Point(4, 29);
            tabImportFile.Name = "tabImportFile";
            tabImportFile.Padding = new Padding(3);
            tabImportFile.Size = new Size(634, 359);
            tabImportFile.TabIndex = 1;
            tabImportFile.Text = "Import File";
            tabImportFile.UseVisualStyleBackColor = true;
            // 
            // dgvImportFile
            // 
            dgvImportFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportFile.Location = new Point(9, 6);
            dgvImportFile.Name = "dgvImportFile";
            dgvImportFile.RowHeadersWidth = 51;
            dgvImportFile.Size = new Size(625, 353);
            dgvImportFile.TabIndex = 0;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 827);
            Controls.Add(tabControl1);
            Controls.Add(grbDownloader);
            Controls.Add(grpDownloadList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tik Tok Downloader";
            grpDownloadList.ResumeLayout(false);
            grpDownloadList.PerformLayout();
            grbDownloader.ResumeLayout(false);
            grbDownloader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericThread).EndInit();
            tabControl1.ResumeLayout(false);
            tabVideoList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVideoList).EndInit();
            tabImportFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImportFile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox grpDownloadList;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileImport;
        private System.Windows.Forms.Label lblListUsers;
        private GroupBox grbDownloader;
        private NumericUpDown numericThread;
        private Button btnOpen;
        private TextBox txtStatus;
        private Label lblStatus;
        private TextBox txtAccount;
        private Label lblAccount;
        private TextBox txtVideoId;
        private Label lblId;
        private TextBox txtUrlVideo;
        private Label lblUrl;
        private Label lblProgress;
        private ProgressBar progressBar;
        private TextBox txtThongKe;
        private Label lblThongKe;
        private Label lblThread;
        private CheckBox chkChayAn;
        private Button btnStop;
        private Button btnStart;
        private TextBox txtUrlUser;
        private Label lblUrlUser;
        private Button btnSelectFolder;
        private TextBox txtPathSave;
        private Label lblPathSave;
        private TabControl tabControl1;
        private TabPage tabVideoList;
        private DataGridView dgvVideoList;
        private TabPage tabImportFile;
        private DataGridView dgvImportFile;
    }
}
