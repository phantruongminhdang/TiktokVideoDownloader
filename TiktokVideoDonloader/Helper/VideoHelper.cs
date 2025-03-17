using HtmlAgilityPack;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TiktokVideoDonloader.Extensions;
using TiktokVideoDonloader.Models;

namespace TiktokVideoDonloader.Helper
{
    public static class VideoHelper
    {
        public static async Task<string> GetNoWatermarkUrl(string tiktokUrl)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

            var apiUrl = "https://www.tikwm.com/api/";
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("url", tiktokUrl)
            });

            var response = await client.PostAsync(apiUrl, content);
            Utilities.Delay(1);
            var json = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            if (root.GetProperty("code").GetInt32() != 0)
                throw new Exception(root.GetProperty("msg").GetString());

            return root.GetProperty("data").GetProperty("play").GetString();
        }

        public static async Task DownloadVideo(string videoUrl)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(videoUrl);

            var fileName = $"tiktok_{DateTime.Now:yyyyMMddHHmmss}.mp4";
            using var stream = await response.Content.ReadAsStreamAsync();
            using var fileStream = File.Create(fileName);
            await stream.CopyToAsync(fileStream);
        }

        public static string LinkVideoOneVideoMP4(string url, IWebDriver _webDriverMp4)
        { 
            if (_webDriverMp4 == null) _webDriverMp4 = UtilitiesBrowser.OpenBrower(true, 1);
            string urlVideoDownload = string.Empty;
            int timeLoop = 2;
        GetLinkLoop:
            try
            {
                _webDriverMp4.Navigate().GoToUrl("https://snaptik.app/vn");
                Utilities.Delay(2);
                OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(_webDriverMp4, TimeSpan.FromSeconds(30));
                wait.Until((x) =>
                {
                    return ((IJavaScriptExecutor)_webDriverMp4).ExecuteScript("return document.readyState").Equals("complete");
                });
                Utilities.Delay(1);
                IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriverMp4;
                _webDriverMp4.Scripts().ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

                var inputUrl = _webDriverMp4.FindElement(By.Id("url"));
                Program.HOME_FORM.OutStatus($"Send URL: {url}");
                inputUrl.SendKeys(url);
                Utilities.Delay(1);
                Program.HOME_FORM.OutStatus($"Click Download");
                _webDriverMp4.FindElement(By.Id("submiturl")).Click();
                var pageHtml = _webDriverMp4.PageSource;
            //Wait to get link
            GetLinkLoopx2:
                Utilities.Delay(timeLoop);
                wait = new OpenQA.Selenium.Support.UI.WebDriverWait(_webDriverMp4, TimeSpan.FromSeconds(3600));
                wait.Until((x) =>
                {
                    return ((IJavaScriptExecutor)_webDriverMp4).ExecuteScript("return document.readyState").Equals("complete");
                });
                Program.HOME_FORM.OutStatus($"Finding links ...");
                var tagA = _webDriverMp4.FindElement(By.XPath("//*[contains(text(),'Download Server 01 (SnapTik)')]"), 60);
                if (tagA == null)
                {
                    UtilitiesBrowser.CloseBrowser(_webDriverMp4);
                    Utilities.Delay(1);
                    _webDriverMp4 = UtilitiesBrowser.OpenBrower(true, 1);
                    Utilities.Delay(1);
                    goto GetLinkLoop;
                }

                pageHtml = _webDriverMp4.PageSource;
                Program.HOME_FORM.OutStatus($"Finding links ...");
                var links = GetLinkFileMP4(pageHtml);
                string _linkdown = "";
                if (links == null || links.Count < 1)
                {
                    timeLoop = timeLoop + 2;

                    if (timeLoop > 30)
                    {
                        UtilitiesBrowser.CloseBrowser(_webDriverMp4);
                        _webDriverMp4 = UtilitiesBrowser.OpenBrower(true, 1);
                        goto GetLinkLoop;
                    }
                    goto GetLinkLoopx2;
                }
                else
                {
                    _linkdown = links.FirstOrDefault();
                    if (_linkdown.Contains("/file/") && _linkdown.Contains(".mp4"))
                    {
                        if (_linkdown.Contains("http"))
                        {
                            urlVideoDownload = _linkdown;
                        }
                        else
                        {
                            urlVideoDownload = "https://snaptik.app/vn" + _linkdown;
                        }
                        return urlVideoDownload;
                    }
                }

                //Clear
                UtilitiesBrowser.CloseBrowser(_webDriverMp4);
                _webDriverMp4 = UtilitiesBrowser.OpenBrower(true, 1);
                goto GetLinkLoop;
            }
            catch
            {
                UtilitiesBrowser.CloseBrowser(_webDriverMp4);
                _webDriverMp4 = UtilitiesBrowser.OpenBrower(true, 1);
                goto GetLinkLoop;
            }
        }

        public static ReturnValueThread LinkVideoOneVideoMP4V2(string url, IWebDriver _webDriverMp4, int threadmax = 1)
        {
            Program.HOME_FORM.OutStatus("");
            ReturnValueThread model = new ReturnValueThread();
            model.ThreadMax = threadmax;
            if (_webDriverMp4 == null) _webDriverMp4 = UtilitiesBrowser.OpenBrower(true, 1);
            string urlVideoDownload = string.Empty;
            int timeLoop = 2;
        GetLinkLoop:
            try
            {
                _webDriverMp4.Navigate().GoToUrl("https://snaptik.app/vn");
                Utilities.Delay(2);
                OpenQA.Selenium.Support.UI.WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(_webDriverMp4, TimeSpan.FromSeconds(30));
                wait.Until((x) =>
                {
                    return ((IJavaScriptExecutor)_webDriverMp4).ExecuteScript("return document.readyState").Equals("complete");
                });
                Utilities.Delay(1);
                IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriverMp4;
                _webDriverMp4.Scripts().ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

                var inputUrl = _webDriverMp4.FindElement(By.Id("url"));
                Program.HOME_FORM.OutStatus($"Send URL: {url}");
                inputUrl.SendKeys(url);
                Utilities.Delay(1);
                Program.HOME_FORM.OutStatus($"Click Download");
                _webDriverMp4.FindElement(By.Id("submiturl")).Click();

                //Wait to get link
                Utilities.Delay(timeLoop);

                Program.HOME_FORM.OutStatus($"Finding links ...");
                var tagA = _webDriverMp4.FindElement(By.XPath("//*[contains(text(),'Download Server 01 (SnapTik)')]"), 10);
                if (tagA == null)
                {
                    goto GetLinkLoop;
                }

                var pageHtml = _webDriverMp4.PageSource;
                Program.HOME_FORM.OutStatus($"Finding links ...");
                var links = GetLinkFileMP4(pageHtml);
                string _linkdown = "";
                if (links == null || links.Count < 1)
                {
                    timeLoop = timeLoop + 2;
                    goto GetLinkLoop;
                }
                else
                {
                    _linkdown = links.FirstOrDefault();
                    if (_linkdown.Contains("/file/") && _linkdown.Contains(".mp4"))
                    {
                        if (_linkdown.Contains("http"))
                        {
                            urlVideoDownload = _linkdown;
                        }
                        else
                        {
                            urlVideoDownload = "https://snaptik.app/vn" + _linkdown;
                        }
                        Program.HOME_FORM.OutStatus(urlVideoDownload);
                        model.UrlLinkMP4 = urlVideoDownload;
                        return model;
                    }
                }
                goto GetLinkLoop;
            }
            catch
            {
                UtilitiesBrowser.CloseBrowser(_webDriverMp4);
                _webDriverMp4 = UtilitiesBrowser.OpenBrower(true, threadmax);
                model.ThreadMax = threadmax + 1;
                goto GetLinkLoop;
            }
        }

        public static List<string> GetLinkFileMP4(string html)
        {
            List<string> result = new List<string>();
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                var nodes = doc.DocumentNode.SelectNodes("//div[@id='snaptik-video']//div[@class='snaptik-right']//div//a[@href]").ToList();
                foreach (var node in nodes)
                {
                    HtmlAttribute link = node.Attributes["href"];
                    string urlLinkFile = link.Value;
                    Program.HOME_FORM.OutStatus($"Find: {urlLinkFile} ....");
                    result.Add(urlLinkFile);
                }
            }
            catch
            {
                result = null;
            }
            return result;
        }
    }

}
