using OpenQA.Selenium;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using TiktokVideoDonloader.Helper;
using TiktokVideoDonloader.Models;
using TiktokVideoDonloader.Services;

namespace TiktokVideoDonloader
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }


        #region ==== Import Data

        public void OutStatus(string status)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtStatus.Text = status;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtStatus.Text = ex.Message.ToString();
                }));
            }
        }

        public void OutThongKe(string thongKe)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtThongKe.Text = thongKe;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtThongKe.Text = ex.Message.ToString();
                }));
            }
        }

        public void OutUrlVideo(string urlVideo)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    var videoId = urlVideo.Split('/').LastOrDefault();
                    var account = urlVideo.Split('/').Where(x => x.Contains("@")).FirstOrDefault();
                    txtAccount.Text = account;
                    txtUrlVideo.Text = urlVideo;
                    txtVideoId.Text = videoId;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlUser.Text = ex.Message.ToString();
                }));
            }
        }

        public void OutVideo(List<TikTokModel> tikTokModels)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    dgvVideoList.DataSource = null;
                    dgvVideoList.DataSource = tikTokModels.OrderBy(x => x.isDownload).ToList();
                    dgvVideoList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvVideoList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    foreach (DataGridViewRow row in dgvVideoList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["isDownload"].Value))
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                        {
                            //txtStatus.Text = "Error while processing color for DataGridView!";
                        }
                    }
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    OutStatus("Error while getting data to view!!");
                }));
            }
        }

        public void OutTiktokModel(TikTokModel tikTokModel)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlVideo.Text = tikTokModel.UrlLink;
                    txtVideoId.Text = tikTokModel.ID;
                    txtAccount.Text = tikTokModel.User;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlVideo.Text = ex.Message.ToString();
                }));
            }
        }

        public void OutImportFile(List<TikTokModel> tikTokModels)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    dgvImportFile.DataSource = null;
                    dgvImportFile.DataSource = tikTokModels.OrderBy(x => x.isDownload).ToList();
                    dgvImportFile.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvImportFile.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    foreach (DataGridViewRow row in dgvVideoList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["isDownload"].Value))
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                        {
                            //txtStatus.Text = "Error while processing color for DataGridView!";
                        }
                    }
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    MessageBox.Show(ex.Message);
                }));
            }
        }

        public void ClearDGV(List<string> list)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    dgvVideoList.DataSource = null;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    MessageBox.Show(ex.Message);
                }));
            }
        }

        public void ClearTiktokModel()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlVideo.Text = string.Empty;
                    txtVideoId.Text = string.Empty;
                    txtAccount.Text = string.Empty;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlVideo.Text = ex.Message.ToString();
                }));
            }
        }

        public void ClearThongKe()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtThongKe.Text = string.Empty;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtThongKe.Text = ex.Message.ToString();
                }));
            }
        }
        #endregion====


        #region ===== Initialize variable

        public IWebDriver _webDriver;
        string DEFAULT_FOLDER_PATH = Path.Combine(Environment.CurrentDirectory, @"DataTiktok\");
        public string PathSave = string.Empty;

        List<TikTokModel> ListVideo = new List<TikTokModel>();
        List<TikTokModel> ListVideoImport = new List<TikTokModel>();

        bool isDownloadContinue = false;
        bool isStop = false;
        bool isHidden = true;


        #endregion
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPathSave.Text = fbd.SelectedPath;
                    DEFAULT_FOLDER_PATH = fbd.SelectedPath;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ClearThongKe();
            ClearTiktokModel();
            Thread thread1 = new Thread(() =>
            {
                _main();
            });
            thread1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt file (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.Multiselect = false;
            //ListVideoUrlImportByTxtFile = null;
            DialogResult dlgResult = ofd.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                txtFileImport.Text = ofd.FileName;
                if (txtFileImport.Text.Equals(""))
                {
                    txtStatus.Text = "Please load file first!";
                    return;
                }
                if (!File.Exists(txtFileImport.Text))
                {
                    txtStatus.Text = "File Not Exist!";
                    return;
                }

                string filePath = txtFileImport.Text;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string temp = string.Empty;
                    while ((temp = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(temp))
                        {
                            var tiktokModel = new TikTokModel();
                            tiktokModel.ID = temp.Split('/').LastOrDefault();
                            tiktokModel.User = temp.Split("/").Where(x => x.Contains("@")).FirstOrDefault();
                            tiktokModel.isDownload = false;
                            tiktokModel.UrlLink = temp;
                            ListVideoImport.Add(tiktokModel);
                        }
                    }
                }

                ListVideoImport = ListVideoImport.Distinct().ToList();
                OutStatus("Import list video url successfully!!");
                OutImportFile(ListVideoImport);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", txtPathSave.Text);
            }
            catch (Win32Exception win32Exception)
            {
                MessageBox.Show(win32Exception.Message);
            }
        }

        private void _main()
        {

            // isDownloadContinue = false;
            // isStop = false;
            isHidden = true;
            string url = txtUrlUser.Text;
            if (!string.IsNullOrEmpty(url))
            {
                GetListUserVideoTiktok(url);
            }
        }

        private void GetListUserVideoTiktok(string url)
        {
            isHidden = chkChayAn.Checked == true ? true : false;
            //_webDriver = _webDriver != null ? _webDriver : UtilitiesBrowser.OpenBrower(isHidden, 0);
            _webDriver = UtilitiesBrowser.OpenBrower(isHidden, 0);
            OutStatus($"Start Download All Video: {url}");

            //Get Video List 
            ListVideo = TikTokService.GetListVideo(url, _webDriver, DEFAULT_FOLDER_PATH);
            if (ListVideo != null && ListVideo.Count > 0)
            {
                ////Download  
                //DownloadVideoListTiktok();
                OutVideo(ListVideo);
                OutStatus("Task Success!");
            }

            UtilitiesBrowser.KillDriver();
        }
        private void DownloadVideoListTiktok()
        {
            int iDownload = 1;
            List<Task> taskList = new List<Task>();
            foreach (var tiktokModel in ListVideo)
            {
                Task task = Task.Factory.StartNew(() =>
                {
                    //OutTiktokModel(tiktokModel);
                    //OutStatus($"Start download video: {tiktokModel.ID}");
                    //OutStatus($"Starting ... download video: {tiktokModel.UrlLink}");

                    //DownloadVideoTiktok(tiktokModel.UrlLink);

                    //OutStatus($"Download video successfully: {tiktokModel.ID}");
                    //allTiktokModel.Where(x => x.ID == tiktokModel.ID)
                    //.Select(x => { x.isDownload = true; return x; }).ToList();
                    OutVideo(ListVideo);

                    OutThongKe($"{iDownload} - {ListVideo.Count}");
                    iDownload++;
                });
                task.Wait();
                taskList.Add(task);

                //OutThongKe($"{iDownload} - {allTiktokModel.Count}");
                //iDownload++;
            }
            var taskwait = Task.WhenAll(taskList);
            Task.WaitAll(taskwait);

            ListVideo.Clear();
            OutStatus($"Task Successfully!");
        }

        private void DownloadVideoTiktok(string urlTiktok)
        {
            //string id = urlTiktok.Split('/').LastOrDefault();
            _webDriver = _webDriver != null ? _webDriver : UtilitiesBrowser.OpenBrower(isHidden, 0);

            //https:www.tiktok.com/@chinafactorystyle/video/332546565765568
            try
            {
                //OutStatusWithUrl($"Get Link MP4 ... Download Video: {urlTiktok}");
                OutStatus($"Get Link MP4 ... Download Video: {urlTiktok}");
                string urlLink = VideoHelper.LinkVideoOneVideoMP4(urlTiktok, _webDriver);

                //Get UserName . Ex: @fbdfbfd
                var lines = urlTiktok.Split('/').ToList();
                string input = lines.SingleOrDefault(x => x.Contains("@"));
                var userName = input.Replace("@", "");

                string idVideo = lines.LastOrDefault();

                string pathSaveFile = DEFAULT_FOLDER_PATH + userName;
                Utilities.CreateIfMissing(pathSaveFile);

                string nameFileVideo = idVideo + ".mp4";
                string fullPathVideo = pathSaveFile + "\\" + nameFileVideo;
                //OutStatusWithUrl($"Save File {nameFileVideo}");
                if (string.IsNullOrEmpty(pathSaveFile))
                {
                    pathSaveFile = DEFAULT_FOLDER_PATH;
                }

                OutStatus($"Start Download file MP4: {idVideo}");
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
                webClient.DownloadFileAsync(new Uri($"{urlLink}"), fullPathVideo);
                this.Invoke(new MethodInvoker(delegate
                {
                    if (!this.IsDisposed)
                    {
                        txtStatus.Text = $"Downloaded.... ";
                        txtStatus.Refresh();
                    }
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    if (!this.IsDisposed)
                    {
                        txtStatus.Text = ex.ToString();
                    }
                }));
            }
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (!this.IsDisposed)
                {
                    progressBar.Value = e.ProgressPercentage;
                    lblProgress.Text = e.ProgressPercentage + "% complete... (" + e.BytesReceived + "/" + e.TotalBytesToReceive + ")"; ;
                }
            }));
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (!this.IsDisposed)
                {
                    txtStatus.Text = $"Downloading.......";
                    txtStatus.Refresh();
                    progressBar.Value = e.ProgressPercentage;
                    lblProgress.Text = e.ProgressPercentage + "% complete... (" + e.BytesReceived + "/" + e.TotalBytesToReceive + ")"; ;
                }
            }));
        }

        private void Completed(object? sender, AsyncCompletedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (!this.IsDisposed)
                {
                    txtStatus.Text = $"Download Completed!";
                    txtStatus.Refresh();
                    isDownloadContinue = true;
                }
            }));
        }


    }
}
