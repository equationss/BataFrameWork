using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Edge;

namespace Project_Bata.Login
{
    public class ClassBase
    {
        public static IWebDriver driver;
        private object ExpectedConditions;

        public static IWebDriver SetDriver(string browser)
        {
            if (browser == "Chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-notifications");
                driver = new ChromeDriver(options);
              
                driver.Url = "https://www.bata.com.pk/";
                driver.Manage().Window.Maximize();
            }
            if (browser == "Edge")
            {
                driver = new EdgeDriver();
                driver.Url = "https://www.bata.com.pk/";
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        #region SendKeysMethod
        public void SendKeysMethod(By locator, string text)
        {
            if (driver.FindElement(locator).GetAttribute("value") != " ")
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
            else
            {
                driver.FindElement(locator).SendKeys(text);
            }
        }
        #endregion

        #region clickElement
        public void clickElement(By locator)
        {
            driver.FindElement(locator).Click();
        }
        #endregion

        #region Driver.Close
        public static void Close()
        {

            driver.Close();

        }
        #endregion

        #region Click
        public void clickWebElement(IWebElement element, IWebDriver driver)
        {
            try
            {
                element.Click();
            }
            catch (WebDriverException e)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", element);
            }
        }
        #endregion

        #region FindElement
        public void findElement(By locator, double timeoutInSeconds = 3)
        {
            //if (timeoutInSeconds == 0)
            //{
            driver.FindElement(locator);
            clickElement(locator);
            //}
            //else
            //{

            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            //   wait.Until(Ex);
            //    clickElement(locator);
            //}


        }
        #endregion

        #region DropDown
        public void dropdown(By loc, string type, string value)
        {
            IWebElement element = driver.FindElement(loc);
            SelectElement drpdwn = new SelectElement(element);
            if (type == "value")
            {
                drpdwn.SelectByValue(value);
                element.Click();
            }

            else if (type == "text")
            {
                drpdwn.SelectByText(value);
                element.Click();
            }

            else if (type == "index")
            {
                drpdwn.SelectByIndex(Convert.ToInt32(value));
                element.Click();
            }
        }

        #endregion

        public void AssertEqual(string ex, string actual)
        {
            Assert.AreEqual(ex, actual);
        }

        public string GetAttribute(string type, By loc)
        {
            IWebElement element = driver.FindElement(loc);
            string value = null;
            if (type == "text")
            {
                return value = element.GetAttribute(type).ToString();
            }
            else if (type == "value")
            {
                return value = element.GetAttribute(type).ToString();
            }
            else if (type == "innerHTML")
            {
                return value = element.GetAttribute(type).ToString();
            }
            return value;
        }
        public void Scroll(By loc)
        {
             var e = driver.FindElement(loc);
             ((IJavaScriptExecutor)driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", e);
        }

        public void dealingAlertDismiss()
        {
            driver.SwitchTo().Alert().Dismiss();

        }

        public void dealingAlertAccept()
        {
            driver.SwitchTo().Alert().Accept();

        }

    }
}


