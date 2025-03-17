using OpenQA.Selenium;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading;
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
                    txtStatus.Refresh();
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

        public void OutVideoImport(List<TikTokModel> tikTokModels)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    dgvImportFile.DataSource = null;
                    dgvImportFile.DataSource = tikTokModels.OrderBy(x => x.isDownload).ToList();
                    dgvImportFile.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvImportFile.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    foreach (DataGridViewRow row in dgvImportFile.Rows)
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

        public void EnableWhenLoadFileDone()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    //button
                    btnDownload.Enabled = true;
                    btnDownloadImport.Enabled = true;
                    btnSelectFile.Enabled = true;
                    btnSelectFolder.Enabled = true;
                    btnOpen.Enabled = true;
                    btnStart.Enabled = true;

                    //txt input
                    txtPathSave.ReadOnly = false;
                    txtUrlUser.ReadOnly = false;
                    txtFileImport.ReadOnly = false;

                    //checkbox
                    chkChayAn.Enabled = true;

                    //numeric
                    numericThread.Enabled = true;
                }));
            }
            catch
            {

            }
        }
        public void DisableWhenLoadFile()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    //button
                    btnDownload.Enabled = false;
                    btnDownloadImport.Enabled = false;
                    btnSelectFile.Enabled = false;
                    btnSelectFolder.Enabled = false;
                    btnOpen.Enabled = false;
                    btnStart.Enabled = false;

                    //txt input
                    txtPathSave.ReadOnly = true;
                    txtUrlUser.ReadOnly = true;
                    txtFileImport.ReadOnly = true;

                    //checkbox
                    chkChayAn.Enabled = false;

                    //numeric
                    numericThread.Enabled = false;
                }));
            }
            catch
            {

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

        private CancellationTokenSource _cancellationTokenSource;

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

            // Initialize cancellation token
            _cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _cancellationTokenSource.Token;

            //Thread thread1 = new Thread(() =>
            //{
            //    _main(cancellationToken);
            //});
            //thread1.Start();

            DisableWhenLoadFile();
            Task.Run(() =>
            {
                _main(cancellationToken);
            }, cancellationToken);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();

            //    // Cleanup WebDriver
            //    UtilitiesBrowser.KillDriver();
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

        private void _main(CancellationToken cancellationToken)
        {

            // isDownloadContinue = false;
            // isStop = false;
            string url = txtUrlUser.Text;
            if (!string.IsNullOrEmpty(url))
            {
                GetListUserVideoTiktok(url, cancellationToken);
            }
            else
            {
                MessageBox.Show("You haven't setup user path yet!", "Inform", MessageBoxButtons.OK);
                EnableWhenLoadFileDone();
            }
        }

        private void GetListUserVideoTiktok(string url, CancellationToken cancellationToken)
        {
            try
            {
                isHidden = chkChayAn.Checked == true ? true : false;
                //_webDriver = _webDriver != null ? _webDriver : UtilitiesBrowser.OpenBrower(isHidden, 0);
                _webDriver = UtilitiesBrowser.OpenBrower(isHidden, 0);
                OutStatus($"Start Download All Video: {url}");

                //Get Video List 
                ListVideo = TikTokService.GetListVideo(url, _webDriver, DEFAULT_FOLDER_PATH, cancellationToken);
                if (ListVideo != null && ListVideo.Count > 0)
                {
                    ////Download  
                    //DownloadVideoListTiktok();
                    OutVideo(ListVideo);
                    if (cancellationToken.IsCancellationRequested)
                    {
                        OutStatus("Task Stopped!");
                    }
                    else
                    {
                        OutStatus("Task Success!");
                    }

                }
                else
                {
                    OutStatus("Cannot get any link!");
                }
            }
            catch (OperationCanceledException)
            {
                OutStatus("Process stopped by user.");
            }
            catch (Exception ex)
            {
                OutStatus($"Error: {ex.Message}");
            }
            finally
            {
                UtilitiesBrowser.KillDriver();
                EnableWhenLoadFileDone();
            }
        }
        private async Task DownloadVideoListTiktok()
        {
            if (ListVideo != null && ListVideo.Count > 0)
            {
                int iDownload = 1;
                List<Task> taskList = new List<Task>();
                foreach (var tiktokModel in ListVideo)
                {
                    //Task task = Task.Factory.StartNew(() =>
                    //{


                    //    OutThongKe($"{iDownload} - {ListVideo.Count}");
                    //    iDownload++;
                    //});
                    await DownloadVideoTiktok(tiktokModel);
                    //taskList.Add(DownloadVideoTiktok(tiktokModel));
                    //DownloadVideoTiktok(tiktokModel).Wait();
                    //await Task.WhenAll(taskList);

                    OutThongKe($"{iDownload} - {ListVideo.Count}");
                    iDownload++;
                    //if (iDownload % 5 == 0)
                    //{
                    //    await Task.WhenAll(taskList);
                    //}
                }
                // await Task.WhenAll(taskList);
                //Task.WaitAll(taskwait);

                //ListVideo.Clear();
                OutStatus($"All Downloads Completed!");
            }
            else
            {
                MessageBox.Show("Don't have any video to download!!");
            }
        }

        private async Task DownloadVideoListTiktokImport()
        {
            if (ListVideoImport != null && ListVideoImport.Count > 0)
            {
                int iDownload = 1;
                List<Task> taskList = new List<Task>();
                foreach (var tiktokModel in ListVideoImport)
                {
                    //Task task = Task.Factory.StartNew(() =>
                    //{


                    //    OutThongKe($"{iDownload} - {ListVideo.Count}");
                    //    iDownload++;
                    //});
                    await DownloadVideoTiktokImport(tiktokModel);
                    //taskList.Add(DownloadVideoTiktokImport(tiktokModel));
                    //DownloadVideoTiktokImport(tiktokModel).Wait();
                    //await Task.WhenAll(taskList);

                    OutThongKe($"{iDownload} - {ListVideoImport.Count}");
                    iDownload++;
                    //if (iDownload % 5 == 0)
                    //{
                    //    await Task.WhenAll(taskList);
                    //}
                }
                // await Task.WhenAll(taskList);
                //Task.WaitAll(taskwait);

                //ListVideo.Clear();
                OutStatus($"All Downloads Completed!");
            }
            else
            {
                MessageBox.Show("Don't have any video to download!!");
            }
        }

        private async Task DownloadVideoTiktok(TikTokModel tiktokModel)
        {

            //https:www.tiktok.com/@chinafactorystyle/video/332546565765568
            try
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    if (!this.IsDisposed)
                    {
                        OutTiktokModel(tiktokModel);
                        OutStatus($"Start download video: {tiktokModel.ID}");
                        OutStatus($"Starting ... download video: {tiktokModel.UrlLink}");
                        //OutStatusWithUrl($"Get Link MP4 ... Download Video: {urlTiktok}");
                        OutStatus($"Get Link MP4 ... Download Video: {tiktokModel.UrlLink}");
                    }
                }));

                await DownloadVideoTiktokAsync(tiktokModel);

                this.Invoke(new MethodInvoker(delegate
                {
                    if (!this.IsDisposed)
                    {
                        txtStatus.Text = $"Downloaded.... ";
                        txtStatus.Refresh();
                        OutStatus($"Download video successfully: {tiktokModel.ID}");
                        ListVideo.Where(x => x.ID == tiktokModel.ID)
                        .Select(x => { x.isDownload = true; return x; }).ToList();
                        OutVideo(ListVideo);
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

        private async Task DownloadVideoTiktokImport(TikTokModel tiktokModel)
        {

            //https:www.tiktok.com/@chinafactorystyle/video/332546565765568
            try
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    if (!this.IsDisposed)
                    {
                        OutTiktokModel(tiktokModel);
                        OutStatus($"Start download video: {tiktokModel.ID}");
                        OutStatus($"Starting ... download video: {tiktokModel.UrlLink}");
                        //OutStatusWithUrl($"Get Link MP4 ... Download Video: {urlTiktok}");
                        OutStatus($"Get Link MP4 ... Download Video: {tiktokModel.UrlLink}");
                    }
                }));

                await DownloadVideoTiktokImportAsync(tiktokModel);

                this.Invoke(new MethodInvoker(delegate
                {
                    if (!this.IsDisposed)
                    {
                        txtStatus.Text = $"Downloaded.... ";
                        txtStatus.Refresh();
                        OutStatus($"Download video successfully: {tiktokModel.ID}");
                        ListVideoImport.Where(x => x.ID == tiktokModel.ID)
                        .Select(x => { x.isDownload = true; return x; }).ToList();
                        OutVideoImport(ListVideoImport);
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

        private async Task DownloadVideoTiktokAsync(TikTokModel tiktokModel)
        {
            try
            {
                string urlLink = await VideoHelper.GetNoWatermarkUrl(tiktokModel.UrlLink);

                //Get UserName . Ex: @fbdfbfd
                var lines = tiktokModel.UrlLink.Split('/').ToList();
                string input = lines.SingleOrDefault(x => x.Contains("@"));
                var userName = input.Replace("@", "");

                string idVideo = lines.LastOrDefault();

                string pathSaveFile = DEFAULT_FOLDER_PATH + "\\" + userName;
                Utilities.CreateIfMissing(pathSaveFile);

                string nameFileVideo = idVideo + ".mp4";
                string fullPathVideo = pathSaveFile + "\\" + nameFileVideo;
                //OutStatusWithUrl($"Save File {nameFileVideo}");
                if (string.IsNullOrEmpty(pathSaveFile))
                {
                    pathSaveFile = DEFAULT_FOLDER_PATH;
                }

                OutStatus($"Start Download file MP4: {idVideo}");
                using (var webClient = new WebClient())
                {
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
                    try
                    {
                        await webClient.DownloadFileTaskAsync(new Uri($"{urlLink}"), fullPathVideo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("err");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private async Task DownloadVideoTiktokImportAsync(TikTokModel tiktokModel)
        {
            try
            {
                string urlLink = await VideoHelper.GetNoWatermarkUrl(tiktokModel.UrlLink);

                //Get UserName . Ex: @fbdfbfd
                var lines = tiktokModel.UrlLink.Split('/').ToList();
                string input = lines.SingleOrDefault(x => x.Contains("@"));
                var userName = input.Replace("@", "");

                string idVideo = lines.LastOrDefault();

                string pathSaveFile = DEFAULT_FOLDER_PATH + "\\" + userName;
                Utilities.CreateIfMissing(pathSaveFile);

                string nameFileVideo = idVideo + ".mp4";
                string fullPathVideo = pathSaveFile + "\\" + nameFileVideo;
                //OutStatusWithUrl($"Save File {nameFileVideo}");
                if (string.IsNullOrEmpty(pathSaveFile))
                {
                    pathSaveFile = DEFAULT_FOLDER_PATH;
                }

                OutStatus($"Start Download file MP4: {idVideo}");
                using (var webClient = new WebClient())
                {
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedImport);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChangedImport);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallbackImport);
                    try
                    {
                        await webClient.DownloadFileTaskAsync(new Uri($"{urlLink}"), fullPathVideo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("err");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (!this.IsDisposed)
                {
                    pbDownload.Value = e.ProgressPercentage;
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
                    pbDownload.Value = e.ProgressPercentage;
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
                }
            }));
        }

        private void DownloadProgressCallbackImport(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (!this.IsDisposed)
                {
                    pbDownloadImport.Value = e.ProgressPercentage;
                    lbDownloadImport.Text = e.ProgressPercentage + "% complete... (" + e.BytesReceived + "/" + e.TotalBytesToReceive + ")"; ;
                }
            }));
        }

        private void ProgressChangedImport(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (!this.IsDisposed)
                {
                    txtStatus.Text = $"Downloading.......";
                    txtStatus.Refresh();
                    pbDownloadImport.Value = e.ProgressPercentage;
                    lbDownloadImport.Text = e.ProgressPercentage + "% complete... (" + e.BytesReceived + "/" + e.TotalBytesToReceive + ")"; ;
                }
            }));
        }

        private void CompletedImport(object? sender, AsyncCompletedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (!this.IsDisposed)
                {
                    txtStatus.Text = $"Download Completed!";
                    txtStatus.Refresh();
                }
            }));
        }

        private async void btnDownloadImport_Click(object sender, EventArgs e)
        {
            DisableWhenLoadFile();
            await DownloadVideoListTiktokImport();
            EnableWhenLoadFileDone();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            DisableWhenLoadFile();
            await DownloadVideoListTiktok();
            EnableWhenLoadFileDone();
        }
    }
}
