using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiktokVideoDonloader.Helper
{
    public static class UtilitiesBrowser
    {
        public static IWebDriver OpenBrower(bool hidden = false, int ProfileName = 0)
        {
            IWebDriver _webDriver;
        startChrome:
            try
            {
                string ProfileFolderPath = Path.Combine(Environment.CurrentDirectory, @"Profiles");
                string chromeDriverPath = Environment.CurrentDirectory;
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(chromeDriverPath);
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOptions = new ChromeOptions();
                //chromeOptions.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Geko/20100101")
                if (Directory.Exists(ProfileFolderPath))
                {
                    chromeOptions.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + ProfileName);
                }
                else
                {
                    Directory.CreateDirectory(ProfileFolderPath);
                }
                if (hidden)
                {
                    chromeOptions.AddArguments("--headless"); // chạy ẩn 
                }
                chromeOptions.AddArguments("--disable-images");//Disable images
                chromeOptions.AddArguments("disable-popup-blocking");
                chromeOptions.AddArguments("--disable-extensions");
                chromeOptions.AddArguments("--silent");
                chromeOptions.AddArguments("--log-level=3");
                _webDriver = new ChromeDriver(chromeDriverService, chromeOptions);

            }
            catch (Exception ex)
            {
                //version error
                string error = ex.Message.ToString();
                if(error.IndexOf("This version of ChromeDriver") != 1)
                {
                    Program.HOME_FORM.OutStatus($"ChromeDriver - WebDriver for Chrome. Please update !{ex.Message.ToString()}");
                    Utilities.Delay(10);
                    KillDriver();
                    _webDriver = null;
                }
                else
                {
                    KillDriver();
                    _webDriver = null;
                    //turn off all of running ones
                    goto startChrome;
                }
            }
            return _webDriver;
        }

        public static void KillDriver()
        {
            try
            {
                Process.Start("taskkill", "/F /IM chromedriver.exe /T");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            catch (Exception ex)
            {
                Process.Start("taskkill", "/F /IM chromedriver.exe /T");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }

        public static ChromeOptions CreateOptions(string device)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.EnableMobileEmulation(device);
            return chromeOptions;
        }

        public static void CloseBrowser(IWebDriver _webDriver)
        {
            try
            {
                if(_webDriver != null)
                {
                    _webDriver.Close(); // Close the chrome window
                    _webDriver.Quit(); // Close the console app that was used to kick off the chrome window
                    _webDriver.Dispose(); // Close the chromedriver.exe
                }
            }
            catch
            {

            }
        }
    }
}
