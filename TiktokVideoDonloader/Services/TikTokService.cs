using OpenQA.Selenium;
using System.Diagnostics;
using TiktokVideoDonloader.Helper;
using TiktokVideoDonloader.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TiktokVideoDonloader.Services
{
    public static class TikTokService
    {
        //public static List<TikTokModel> GetVideo(string url, IWebDriver _webDriver, string PathSave)
        //{
        //    List<TikTokModel> tikTokModelList = new List<TikTokModel>();
        //    try
        //    {
        //        string userName = url.Split('@').Last().Split('?').FirstOrDefault();
        //        tikTokModelList = null;
        //        List<TikTokModel> temp = new List<TikTokModel>();
        //        List<Task> taskList = new List<Task>();
        //        Task<List<TikTokModel>> task = Task<List<TikTokModel>>.Factory.StartNew(() =>
        //        {
        //            return GetListVideo(url, _webDriver, PathSave);
        //        });
        //        taskList.Add(task);
        //        Task taskwait = Task.WhenAll(taskList);
        //        Task.WaitAll(taskwait);
        //        try
        //        {
        //            taskwait.Wait();
        //        }
        //        catch
        //        {

        //        }
        //        var collection = task.Result;
        //        tikTokModelList = collection;
        //        if (collection != null && collection.Count > 0)
        //        {
        //            //write list video 
        //            List<string> listLinkUrl = new List<string>();
        //            foreach (var item in collection)
        //            {
        //                listLinkUrl.Add(item.UrlLink.Trim());
        //            }

        //            //check path
        //            string pathSaveTxt = $"{PathSave}//FolderUsers";
        //            Utilities.CreateIfMissing(pathSaveTxt);
        //            UtilitiesFile.WriteLine(listLinkUrl, $"{PathSave}//FolderUsers//{userName}.txt");

        //            //DownloadVideoListTiktok(collection);

        //            Utilities.Delay(2);
        //            Program.HOME_FORM.OutStatus($"Completed Download {userName} - Total of video: {collection.Count}");
        //        }

        //        //_webDriver.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        Program.HOME_FORM.OutStatus($"Get Video {ex.Message}");
        //    }

        //    return tikTokModelList;
        //}

        public static List<TikTokModel> GetListVideo(string url, IWebDriver _webDriver, string PathSave)
        {
            bool flagStop = false;
            List<TikTokModel> tikTokModelList = new List<TikTokModel>();
            double lastLocation = 0;
            int total = 0;
            List<TikTokModel> listTiktok = new List<TikTokModel>();
            Program.HOME_FORM.OutStatus("Processing to get list video of tiktok account....");
            string? username = url.Split('@').Last().Split('?').FirstOrDefault();
            //string pathSaved = PathSave + '\\' + username + '\\';
            try
            {
                //Utilities.CreateIfMissing(pathSaved);
                if (_webDriver == null)
                {
                    Program.HOME_FORM.OutStatus("Cannot initialize browser!");
                    return null;
                }
                _webDriver.Navigate().GoToUrl(url);
                Utilities.Delay(2);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                int page = 1;
                while (true)
                {
                    Program.HOME_FORM.OutStatus($"Retrieving Page: {page}");
                    //Utilities.Delay(2);
                    OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
                    wait.Until((x) =>
                    {
                        return ((IJavaScriptExecutor)_webDriver).ExecuteScript("return document.readyState").Equals("complete");

                    });
                    Utilities.Delay(3);

                    //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                    //_webDriver.Scripts().ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                    //_webDriver.Scripts().ExecuteScript("window.scrollTo(0, 1000");
                    var html = _webDriver.PageSource;

                    //check captcha
                    while (true)
                    {
                        html = _webDriver.PageSource;
                        bool decryption = CaptchaService.CaptchaResolve(html);
                        if (decryption == true)
                        {
                            Utilities.Delay(3);
                            break;
                        }
                        Program.HOME_FORM.OutStatus($"Please resolve captcha by yourself .... {wait}");
                        Utilities.Delay(3);
                    }

                    IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;

                    _webDriver.Scripts().ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                    var valueLocation = double.Parse(_webDriver.Scripts().ExecuteScript("return window.pageYOffset").ToString());

                    string _key = $"@{username}/video";
                    //Example @vdfbdfbf/dvdsb
                    var list = Utilities.ExtractLink(html).Where(x => x.Contains(_key));
                    List<TikTokModel> listResult = new List<TikTokModel>();
                    foreach (var item in list)
                    {
                        TikTokModel model = new TikTokModel();
                        model.UrlLink = item.Trim();
                        Program.HOME_FORM.OutUrlVideo(model.UrlLink);
                        var items = item.Split('/').ToList();
                        model.ID = items.LastOrDefault();
                        model.isDownload = false;
                        model.User = items.Where(x => x.Contains("@")).FirstOrDefault();
                        listResult.Add(model);
                        var finalResult = listResult.DistinctBy(i => i.ID).ToList();
                        Program.HOME_FORM.OutThongKe(finalResult.Count.ToString());
                    }

                    var listModelDistinct = listResult.DistinctBy(i => i.ID).ToList();

                    listTiktok.AddRange(listModelDistinct);
                    Program.HOME_FORM.OutVideo(listResult);
                    Utilities.Delay(5);
                    if (watch.Elapsed.TotalMinutes >= 5) break;

                    if (flagStop)
                    {
                        tikTokModelList = listTiktok.DistinctBy(i => i.ID).ToList();
                        break;
                    }
                    if (lastLocation == valueLocation) break;
                    page++;
                    lastLocation = valueLocation;
                }

                tikTokModelList = listTiktok.DistinctBy(i => i.ID).ToList();

                total = tikTokModelList.Count;
                Program.HOME_FORM.OutThongKe(total.ToString());
                //return tikTokModelList;
            }
            catch (Exception ex)
            {
                string text = url;
                var err = ex.ToString();
                Program.HOME_FORM.OutStatus($"Func: GetListVideo - {err}");
            }

            /////check path
            string pathSaveTxt = $"{PathSave}//FolderUsers";
            Utilities.CreateIfMissing(pathSaveTxt);

            var listUrl = tikTokModelList.Select(x => x.UrlLink).ToList();
            UtilitiesFile.WriteLine(listUrl, $"{PathSave}//FolderUsers//{username}.txt");
            return tikTokModelList;
        }
    }
}
