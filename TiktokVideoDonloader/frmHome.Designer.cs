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
            btnOpenImport = new Button();
            txtAccountImport = new TextBox();
            label1 = new Label();
            txtVideoIdImport = new TextBox();
            label2 = new Label();
            txtUrlVideoImport = new TextBox();
            label3 = new Label();
            btnSelectFolderImport = new Button();
            txtPathSaveImport = new TextBox();
            label5 = new Label();
            btnSelectFile = new Button();
            txtFileImport = new TextBox();
            lblListUsers = new Label();
            grbDownloader = new GroupBox();
            numericThread = new NumericUpDown();
            btnOpen = new Button();
            txtAccount = new TextBox();
            lblAccount = new Label();
            txtVideoId = new TextBox();
            lblId = new Label();
            txtUrlVideo = new TextBox();
            lblUrl = new Label();
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
            btnDownload = new Button();
            dgvVideoList = new DataGridView();
            lblProgress = new Label();
            pbDownload = new ProgressBar();
            tabLog = new TabPage();
            txtStatus = new TextBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl3 = new TabControl();
            tabPage3 = new TabPage();
            lbDownloadImport = new Label();
            pbDownloadImport = new ProgressBar();
            btnDownloadImport = new Button();
            dgvImportFile = new DataGridView();
            tabPage4 = new TabPage();
            txtStatusImport = new TextBox();
            grpDownloadList.SuspendLayout();
            grbDownloader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericThread).BeginInit();
            tabControl1.SuspendLayout();
            tabVideoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVideoList).BeginInit();
            tabLog.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportFile).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // grpDownloadList
            // 
            grpDownloadList.Controls.Add(btnOpenImport);
            grpDownloadList.Controls.Add(txtAccountImport);
            grpDownloadList.Controls.Add(label1);
            grpDownloadList.Controls.Add(txtVideoIdImport);
            grpDownloadList.Controls.Add(label2);
            grpDownloadList.Controls.Add(txtUrlVideoImport);
            grpDownloadList.Controls.Add(label3);
            grpDownloadList.Controls.Add(btnSelectFolderImport);
            grpDownloadList.Controls.Add(txtPathSaveImport);
            grpDownloadList.Controls.Add(label5);
            grpDownloadList.Controls.Add(btnSelectFile);
            grpDownloadList.Controls.Add(txtFileImport);
            grpDownloadList.Controls.Add(lblListUsers);
            grpDownloadList.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDownloadList.Location = new Point(6, 7);
            grpDownloadList.Margin = new Padding(3, 4, 3, 4);
            grpDownloadList.Name = "grpDownloadList";
            grpDownloadList.Padding = new Padding(3, 4, 3, 4);
            grpDownloadList.Size = new Size(638, 280);
            grpDownloadList.TabIndex = 23;
            grpDownloadList.TabStop = false;
            grpDownloadList.Text = "Download List from txt File";
            // 
            // btnOpenImport
            // 
            btnOpenImport.Font = new Font("Segoe UI", 7.8F);
            btnOpenImport.Location = new Point(508, 198);
            btnOpenImport.Margin = new Padding(3, 4, 3, 4);
            btnOpenImport.Name = "btnOpenImport";
            btnOpenImport.Size = new Size(120, 31);
            btnOpenImport.TabIndex = 59;
            btnOpenImport.Text = "Open";
            btnOpenImport.UseVisualStyleBackColor = true;
            btnOpenImport.Click += btnOpenImport_Click;
            // 
            // txtAccountImport
            // 
            txtAccountImport.Font = new Font("Segoe UI", 7.20000029F);
            txtAccountImport.Location = new Point(400, 151);
            txtAccountImport.Margin = new Padding(3, 4, 3, 4);
            txtAccountImport.Name = "txtAccountImport";
            txtAccountImport.ReadOnly = true;
            txtAccountImport.Size = new Size(228, 23);
            txtAccountImport.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F);
            label1.Location = new Point(333, 152);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 57;
            label1.Text = "Account :";
            // 
            // txtVideoIdImport
            // 
            txtVideoIdImport.Font = new Font("Segoe UI", 7.20000029F);
            txtVideoIdImport.Location = new Point(85, 151);
            txtVideoIdImport.Margin = new Padding(3, 4, 3, 4);
            txtVideoIdImport.Name = "txtVideoIdImport";
            txtVideoIdImport.ReadOnly = true;
            txtVideoIdImport.Size = new Size(228, 23);
            txtVideoIdImport.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F);
            label2.Location = new Point(54, 151);
            label2.Name = "label2";
            label2.Size = new Size(27, 17);
            label2.TabIndex = 55;
            label2.Text = "ID :";
            // 
            // txtUrlVideoImport
            // 
            txtUrlVideoImport.Font = new Font("Segoe UI", 7.20000029F);
            txtUrlVideoImport.Location = new Point(85, 120);
            txtUrlVideoImport.Margin = new Padding(3, 4, 3, 4);
            txtUrlVideoImport.Name = "txtUrlVideoImport";
            txtUrlVideoImport.ReadOnly = true;
            txtUrlVideoImport.Size = new Size(543, 23);
            txtUrlVideoImport.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F);
            label3.Location = new Point(49, 120);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 53;
            label3.Text = "Url :";
            // 
            // btnSelectFolderImport
            // 
            btnSelectFolderImport.Font = new Font("Segoe UI", 7.8F);
            btnSelectFolderImport.Location = new Point(478, 30);
            btnSelectFolderImport.Margin = new Padding(3, 4, 3, 4);
            btnSelectFolderImport.Name = "btnSelectFolderImport";
            btnSelectFolderImport.Size = new Size(150, 25);
            btnSelectFolderImport.TabIndex = 50;
            btnSelectFolderImport.Text = "Select Folder";
            btnSelectFolderImport.UseVisualStyleBackColor = true;
            btnSelectFolderImport.Click += btnSelectFolderImport_Click;
            // 
            // txtPathSaveImport
            // 
            txtPathSaveImport.Font = new Font("Segoe UI", 7.20000029F);
            txtPathSaveImport.Location = new Point(85, 30);
            txtPathSaveImport.Margin = new Padding(3, 4, 3, 4);
            txtPathSaveImport.Name = "txtPathSaveImport";
            txtPathSaveImport.Size = new Size(387, 23);
            txtPathSaveImport.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F);
            label5.Location = new Point(10, 31);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 48;
            label5.Text = "Path Save :";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Font = new Font("Segoe UI", 7.8F);
            btnSelectFile.Location = new Point(479, 62);
            btnSelectFile.Margin = new Padding(3, 4, 3, 4);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(149, 25);
            btnSelectFile.TabIndex = 2;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFileImport
            // 
            txtFileImport.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileImport.Location = new Point(85, 61);
            txtFileImport.Margin = new Padding(3, 4, 3, 4);
            txtFileImport.Name = "txtFileImport";
            txtFileImport.Size = new Size(387, 25);
            txtFileImport.TabIndex = 1;
            // 
            // lblListUsers
            // 
            lblListUsers.AutoSize = true;
            lblListUsers.Font = new Font("Segoe UI", 7.8F);
            lblListUsers.Location = new Point(4, 62);
            lblListUsers.Name = "lblListUsers";
            lblListUsers.Size = new Size(77, 17);
            lblListUsers.TabIndex = 0;
            lblListUsers.Text = "Import File :";
            // 
            // grbDownloader
            // 
            grbDownloader.Controls.Add(numericThread);
            grbDownloader.Controls.Add(btnOpen);
            grbDownloader.Controls.Add(txtAccount);
            grbDownloader.Controls.Add(lblAccount);
            grbDownloader.Controls.Add(txtVideoId);
            grbDownloader.Controls.Add(lblId);
            grbDownloader.Controls.Add(txtUrlVideo);
            grbDownloader.Controls.Add(lblUrl);
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
            grbDownloader.Location = new Point(7, 6);
            grbDownloader.Name = "grbDownloader";
            grbDownloader.Size = new Size(638, 288);
            grbDownloader.TabIndex = 4;
            grbDownloader.TabStop = false;
            // 
            // numericThread
            // 
            numericThread.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericThread.Location = new Point(243, 89);
            numericThread.Margin = new Padding(3, 4, 3, 4);
            numericThread.Name = "numericThread";
            numericThread.Size = new Size(122, 25);
            numericThread.TabIndex = 48;
            numericThread.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 7.8F);
            btnOpen.Location = new Point(503, 231);
            btnOpen.Margin = new Padding(3, 4, 3, 4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(120, 31);
            btnOpen.TabIndex = 47;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Segoe UI", 7.20000029F);
            txtAccount.Location = new Point(395, 190);
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
            lblAccount.Location = new Point(328, 191);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(61, 17);
            lblAccount.TabIndex = 43;
            lblAccount.Text = "Account :";
            // 
            // txtVideoId
            // 
            txtVideoId.Font = new Font("Segoe UI", 7.20000029F);
            txtVideoId.Location = new Point(80, 190);
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
            lblId.Location = new Point(49, 190);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 17);
            lblId.TabIndex = 41;
            lblId.Text = "ID :";
            // 
            // txtUrlVideo
            // 
            txtUrlVideo.Font = new Font("Segoe UI", 7.20000029F);
            txtUrlVideo.Location = new Point(80, 159);
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
            lblUrl.Location = new Point(44, 159);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(32, 17);
            lblUrl.TabIndex = 39;
            lblUrl.Text = "Url :";
            // 
            // txtThongKe
            // 
            txtThongKe.Font = new Font("Segoe UI", 7.20000029F);
            txtThongKe.Location = new Point(474, 90);
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
            lblThongKe.Location = new Point(400, 94);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(71, 17);
            lblThongKe.TabIndex = 35;
            lblThongKe.Text = "Thống Kê :";
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Segoe UI", 7.8F);
            lblThread.Location = new Point(181, 94);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(56, 17);
            lblThread.TabIndex = 34;
            lblThread.Text = "Thread :";
            // 
            // chkChayAn
            // 
            chkChayAn.AutoSize = true;
            chkChayAn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkChayAn.Location = new Point(79, 93);
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
            btnStop.Location = new Point(551, 58);
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
            btnStart.Location = new Point(473, 58);
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
            txtUrlUser.Location = new Point(80, 58);
            txtUrlUser.Margin = new Padding(3, 4, 3, 4);
            txtUrlUser.Name = "txtUrlUser";
            txtUrlUser.Size = new Size(387, 23);
            txtUrlUser.TabIndex = 30;
            // 
            // lblUrlUser
            // 
            lblUrlUser.AutoSize = true;
            lblUrlUser.Font = new Font("Segoe UI", 7.8F);
            lblUrlUser.Location = new Point(13, 61);
            lblUrlUser.Name = "lblUrlUser";
            lblUrlUser.Size = new Size(63, 17);
            lblUrlUser.TabIndex = 29;
            lblUrlUser.Text = "Url User :";
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Segoe UI", 7.8F);
            btnSelectFolder.Location = new Point(473, 25);
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
            txtPathSave.Location = new Point(80, 25);
            txtPathSave.Margin = new Padding(3, 4, 3, 4);
            txtPathSave.Name = "txtPathSave";
            txtPathSave.Size = new Size(387, 23);
            txtPathSave.TabIndex = 27;
            // 
            // lblPathSave
            // 
            lblPathSave.AutoSize = true;
            lblPathSave.Font = new Font("Segoe UI", 7.8F);
            lblPathSave.Location = new Point(5, 26);
            lblPathSave.Name = "lblPathSave";
            lblPathSave.Size = new Size(71, 17);
            lblPathSave.TabIndex = 26;
            lblPathSave.Text = "Path Save :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabVideoList);
            tabControl1.Controls.Add(tabLog);
            tabControl1.Location = new Point(7, 300);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(638, 464);
            tabControl1.TabIndex = 24;
            // 
            // tabVideoList
            // 
            tabVideoList.Controls.Add(btnDownload);
            tabVideoList.Controls.Add(dgvVideoList);
            tabVideoList.Controls.Add(lblProgress);
            tabVideoList.Controls.Add(pbDownload);
            tabVideoList.Location = new Point(4, 29);
            tabVideoList.Name = "tabVideoList";
            tabVideoList.Padding = new Padding(3);
            tabVideoList.Size = new Size(630, 431);
            tabVideoList.TabIndex = 0;
            tabVideoList.Text = "Result";
            tabVideoList.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            btnDownload.Font = new Font("Segoe UI", 7.8F);
            btnDownload.Location = new Point(525, 7);
            btnDownload.Margin = new Padding(3, 4, 3, 4);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(103, 30);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // dgvVideoList
            // 
            dgvVideoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVideoList.Location = new Point(9, 44);
            dgvVideoList.Name = "dgvVideoList";
            dgvVideoList.RowHeadersWidth = 51;
            dgvVideoList.Size = new Size(630, 391);
            dgvVideoList.TabIndex = 0;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.Location = new Point(302, 14);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(123, 17);
            lblProgress.TabIndex = 38;
            lblProgress.Text = "Download Progress";
            // 
            // pbDownload
            // 
            pbDownload.Location = new Point(9, 9);
            pbDownload.Margin = new Padding(3, 4, 3, 4);
            pbDownload.Name = "pbDownload";
            pbDownload.Size = new Size(287, 22);
            pbDownload.TabIndex = 37;
            // 
            // tabLog
            // 
            tabLog.Controls.Add(txtStatus);
            tabLog.Location = new Point(4, 29);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(3);
            tabLog.Size = new Size(630, 431);
            tabLog.TabIndex = 1;
            tabLog.Text = "Log";
            tabLog.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Segoe UI", 7.20000029F);
            txtStatus.Location = new Point(9, 7);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(621, 424);
            txtStatus.TabIndex = 47;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(10, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(660, 803);
            tabControl.TabIndex = 49;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(grbDownloader);
            tabPage1.Controls.Add(tabControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(652, 770);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabControl3);
            tabPage2.Controls.Add(grpDownloadList);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(652, 770);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Import";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage3);
            tabControl3.Controls.Add(tabPage4);
            tabControl3.Location = new Point(6, 310);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(638, 464);
            tabControl3.TabIndex = 25;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lbDownloadImport);
            tabPage3.Controls.Add(pbDownloadImport);
            tabPage3.Controls.Add(btnDownloadImport);
            tabPage3.Controls.Add(dgvImportFile);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(630, 431);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Result";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbDownloadImport
            // 
            lbDownloadImport.AutoSize = true;
            lbDownloadImport.BackColor = Color.Transparent;
            lbDownloadImport.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDownloadImport.Location = new Point(302, 19);
            lbDownloadImport.Name = "lbDownloadImport";
            lbDownloadImport.Size = new Size(123, 17);
            lbDownloadImport.TabIndex = 44;
            lbDownloadImport.Text = "Download Progress";
            // 
            // pbDownloadImport
            // 
            pbDownloadImport.Location = new Point(9, 14);
            pbDownloadImport.Margin = new Padding(3, 4, 3, 4);
            pbDownloadImport.Name = "pbDownloadImport";
            pbDownloadImport.Size = new Size(287, 22);
            pbDownloadImport.TabIndex = 43;
            // 
            // btnDownloadImport
            // 
            btnDownloadImport.Font = new Font("Segoe UI", 7.8F);
            btnDownloadImport.Location = new Point(525, 12);
            btnDownloadImport.Margin = new Padding(3, 4, 3, 4);
            btnDownloadImport.Name = "btnDownloadImport";
            btnDownloadImport.Size = new Size(103, 30);
            btnDownloadImport.TabIndex = 42;
            btnDownloadImport.Text = "Download";
            btnDownloadImport.UseVisualStyleBackColor = true;
            btnDownloadImport.Click += btnDownloadImport_Click;
            // 
            // dgvImportFile
            // 
            dgvImportFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportFile.Location = new Point(9, 49);
            dgvImportFile.Name = "dgvImportFile";
            dgvImportFile.RowHeadersWidth = 51;
            dgvImportFile.Size = new Size(625, 386);
            dgvImportFile.TabIndex = 41;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtStatusImport);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(630, 431);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Log";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtStatusImport
            // 
            txtStatusImport.Enabled = false;
            txtStatusImport.Font = new Font("Segoe UI", 7.20000029F);
            txtStatusImport.Location = new Point(9, 7);
            txtStatusImport.Margin = new Padding(3, 4, 3, 4);
            txtStatusImport.Multiline = true;
            txtStatusImport.Name = "txtStatusImport";
            txtStatusImport.ScrollBars = ScrollBars.Vertical;
            txtStatusImport.Size = new Size(625, 427);
            txtStatusImport.TabIndex = 48;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 827);
            Controls.Add(tabControl);
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
            tabVideoList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVideoList).EndInit();
            tabLog.ResumeLayout(false);
            tabLog.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportFile).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox grpDownloadList;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileImport;
        private System.Windows.Forms.Label lblListUsers;
        private GroupBox grbDownloader;
        private NumericUpDown numericThread;
        private Button btnOpen;
        private TextBox txtAccount;
        private Label lblAccount;
        private TextBox txtVideoId;
        private Label lblId;
        private TextBox txtUrlVideo;
        private Label lblUrl;
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
        private TabPage tabLog;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnDownload;
        private DataGridView dgvVideoList;
        private Label lblProgress;
        private ProgressBar pbDownload;
        private TabControl tabControl3;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label lbDownloadImport;
        private ProgressBar pbDownloadImport;
        private Button btnDownloadImport;
        private DataGridView dgvImportFile;
        private TextBox txtStatus;
        private TextBox txtStatusImport;
        private Button btnOpenImport;
        private TextBox txtAccountImport;
        private Label label1;
        private TextBox txtVideoIdImport;
        private Label label2;
        private TextBox txtUrlVideoImport;
        private Label label3;
        private Button btnSelectFolderImport;
        private TextBox txtPathSaveImport;
        private Label label5;
    }
}
