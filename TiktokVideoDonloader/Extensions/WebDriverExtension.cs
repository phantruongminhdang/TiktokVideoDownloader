using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiktokVideoDonloader.Extensions
{
    public static class WebDriverExtension
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                try
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                    try
                    {
                        bool isElementFound = IsElementFound(driver, by);
                        if (isElementFound)
                        {
                            IWebElement elementToInteract = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
                            //var _wait = wait.Until(drv => drv.FindElement(by));
                            if (elementToInteract != null) return elementToInteract;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (NoSuchElementException ex)
                    {
                        Program.HOME_FORM.OutStatus($"Waiting for getting link {ex.Message}");
                    }

                    //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("customer_file")));
                }
                catch
                {

                }
            }
            return driver.FindElement(by);
        }

        public static bool IsElementFound(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException ex)
            {
                Program.HOME_FORM.OutStatus($"IsElementFound: {ex.Message.ToString()}");
                return false;
            }
        }
    }
}
