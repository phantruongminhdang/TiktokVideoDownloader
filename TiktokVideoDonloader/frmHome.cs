using OpenQA.Selenium;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;
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
                    txtStatus.AppendText(status + "\r\n");
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

        public void OutStatusImport(string status)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtStatusImport.AppendText(status + "\r\n");
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtStatusImport.AppendText(ex.Message.ToString() + "\r\n");
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
            catch
            {
            }
        }

        public void OutUrlVideoImport(string urlVideo)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    var videoId = urlVideo.Split('/').LastOrDefault();
                    var account = urlVideo.Split('/').Where(x => x.Contains("@")).FirstOrDefault();
                    txtAccountImport.Text = account;
                    txtUrlVideoImport.Text = urlVideo;
                    txtVideoIdImport.Text = videoId;
                }));
            }
            catch
            {

            }
        }

        public void UpdateUIDGVVideo(List<TikTokModel> tikTokModels)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    dgvVideoList.Refresh();
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

        public void UpdateUIDGVVideoImport(List<TikTokModel> tikTokModels)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    dgvImportFile.Refresh();
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


        public void OutTiktokModelImport(TikTokModel tikTokModel)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlVideoImport.Text = tikTokModel.UrlLink;
                    txtVideoIdImport.Text = tikTokModel.ID;
                    txtAccountImport.Text = tikTokModel.User;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlVideoImport.Text = ex.Message.ToString();
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

        public void ClearTiktokModelImport()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlVideoImport.Text = string.Empty;
                    txtVideoIdImport.Text = string.Empty;
                    txtAccountImport.Text = string.Empty;
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    txtUrlVideoImport.Text = ex.Message.ToString();
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
                    btnSelectFolder.Enabled = true;
                    btnOpen.Enabled = true;
                    btnStart.Enabled = true;

                    //txt input
                    txtPathSave.ReadOnly = false;
                    txtUrlUser.ReadOnly = false;

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
                    btnSelectFolder.Enabled = false;
                    btnOpen.Enabled = false;
                    btnStart.Enabled = false;

                    //txt input
                    txtPathSave.ReadOnly = true;
                    txtUrlUser.ReadOnly = true;

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

        public void EnableWhenLoadFileDoneImport()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    //button
                    btnDownloadImport.Enabled = true;
                    btnSelectFile.Enabled = true;
                    btnSelectFolderImport.Enabled = true;
                    btnOpenImport.Enabled = true;

                    //txt input
                    txtPathSaveImport.ReadOnly = false;
                    txtFileImport.ReadOnly = false;
                }));
            }
            catch
            {

            }
        }
        public void DisableWhenLoadFileImport()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {

                    //button
                    btnDownloadImport.Enabled = false;
                    btnSelectFile.Enabled = false;
                    btnSelectFolderImport.Enabled = false;
                    btnOpenImport.Enabled = false;

                    //txt input
                    txtPathSaveImport.ReadOnly = true;
                    txtFileImport.ReadOnly = true;
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
        string DEFAULT_FOLDER_PATH_IMPORT = Path.Combine(Environment.CurrentDirectory, @"DataTiktok\");
        public string PathSave = string.Empty;

        List<TikTokModel> ListVideo = new List<TikTokModel>();
        List<TikTokModel> ListVideoImport = new List<TikTokModel>();

        bool isDownloadContinue = false;
        bool isStop = false;
        bool isHidden = true;

        private CancellationTokenSource _cancellationTokenSource;
        private CancellationTokenSource _cancellationTokenSourceDownload;
        private CancellationTokenSource _cancellationTokenSourceDownloadImport;

        private readonly TikTokDownloadService _downloadService = new();

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

        private void btnSelectFolderImport_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPathSaveImport.Text = fbd.SelectedPath;
                    DEFAULT_FOLDER_PATH_IMPORT = fbd.SelectedPath;
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
                OutStatusImport("Import list video url successfully!!");
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

        private void btnOpenImport_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", txtPathSaveImport.Text);
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
                    UpdateUIDGVVideo(ListVideo);
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
                _cancellationTokenSourceDownload = new CancellationTokenSource();
                var progress = new Progress<(int percentage, long received, long total)>(p =>
                {
                    UIHelpers.UpdateProgress(pbDownload, lblProgress, p.percentage, p.received, p.total);
                });
                int iDownload = 1;
                List<Task> taskList = new List<Task>();
                foreach (var tiktokModel in ListVideo)
                {
                    _cancellationTokenSourceDownload.Token.ThrowIfCancellationRequested();

                    try
                    {
                        OutTiktokModel(tiktokModel);
                        OutStatus($"Start download video: {tiktokModel.ID}");
                        OutStatus($"Starting ... download video: {tiktokModel.UrlLink}");
                        //OutStatusWithUrl($"Get Link MP4 ... Download Video: {urlTiktok}");
                        OutStatus($"Get Link MP4 ... Download Video: {tiktokModel.UrlLink}");
                        await _downloadService.DownloadVideoAsync(
                            tiktokModel,
                            DEFAULT_FOLDER_PATH,
                            progress,
                            _cancellationTokenSourceDownload.Token
                            );
                        OutStatus($"Download video successfully: {tiktokModel.ID}");
                        OutStatus($"Downloaded: {iDownload} - {ListVideo.Count} videos");
                        iDownload++;
                        tiktokModel.isDownload = true;
                        UpdateUIDGVVideo(ListVideo);
                    }
                    catch (Exception ex)
                    {
                        // Handle specific exceptions
                        OutStatus(ex.Message);
                        MessageBox.Show("Stopped Download Process!!");
                    }
                }
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
                _cancellationTokenSourceDownloadImport = new CancellationTokenSource();
                var progress = new Progress<(int percentage, long received, long total)>(p =>
                {
                    UIHelpers.UpdateProgress(pbDownloadImport, lbDownloadImport, p.percentage, p.received, p.total);
                });
                int iDownload = 1;
                List<Task> taskList = new List<Task>();
                foreach (var tiktokModel in ListVideoImport)
                {
                    _cancellationTokenSourceDownloadImport.Token.ThrowIfCancellationRequested();

                    try
                    {
                        OutTiktokModelImport(tiktokModel);
                        OutStatusImport($"Start download video: {tiktokModel.ID}");
                        OutStatusImport($"Starting ... download video: {tiktokModel.UrlLink}");
                        //OutStatusWithUrl($"Get Link MP4 ... Download Video: {urlTiktok}");
                        OutStatusImport($"Get Link MP4 ... Download Video: {tiktokModel.UrlLink}");
                        await _downloadService.DownloadVideoAsync(
                            tiktokModel,
                            DEFAULT_FOLDER_PATH_IMPORT,
                            progress,
                            _cancellationTokenSourceDownloadImport.Token
                            );
                        OutStatusImport($"Download video successfully: {tiktokModel.ID}");
                        OutStatusImport($"Downloaded: {iDownload} - {ListVideoImport.Count} videos");
                        iDownload++;
                        tiktokModel.isDownload = true;
                        UpdateUIDGVVideoImport(ListVideoImport);
                    }
                    catch (Exception ex)
                    {
                        // Handle specific exceptions
                        OutStatusImport(ex.Message);
                        MessageBox.Show("Stopped Download Process!!");
                    }

                }
                OutStatusImport($"All Downloads Completed!");
            }
            else
            {
                MessageBox.Show("Don't have any video to download!!");
            }
        }

        private async void btnDownloadImport_Click(object sender, EventArgs e)
        {
            try
            {
                DisableWhenLoadFileImport();
                await DownloadVideoListTiktokImport();
                EnableWhenLoadFileDoneImport();
            }
            catch (OperationCanceledException)
            {
                OutStatusImport("Download canceled");
            }
            catch (Exception ex)
            {
                OutStatusImport($"Error: {ex.Message}");
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                DisableWhenLoadFile();
                await DownloadVideoListTiktok();
                EnableWhenLoadFileDone();
            }
            catch (OperationCanceledException)
            {
                OutStatusImport("Download canceled");
            }
            catch (Exception ex)
            {
                OutStatusImport($"Error: {ex.Message}");
            }
        }

        private void btnStopDownloadImport_Click(object sender, EventArgs e)
        {
            CancelOperations(_cancellationTokenSourceDownloadImport);
        }
        
        private void btnStopDownload_Click(object sender, EventArgs e)
        {
            CancelOperations(_cancellationTokenSourceDownload);
        }

        private void CancelOperations(CancellationTokenSource _cts)
        {
            _cts?.Cancel();
            _cts?.Dispose();
            _cts = new CancellationTokenSource();
        }

        
    }
}
