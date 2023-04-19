using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using Project_Bata.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Reflection;
using System.Drawing;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Project_Bata.Filter
{
    public class FilterLoc : ClassBase
    {

        #region Search

        By HoverLink = By.XPath("//nav[@class='gridlock-fluid']/div/div/ul/li[2]");
        By ClickSneaker = By.XPath("//ul[@class='mega-stack']//a[@href = '/collections/men-sneakers']");
        By move = By.XPath("//*[@id=\"boost-pfs-filter-tree2\"]/div/div[3]/div[5]/div[1]");

        public void MoveToElement()
        {
        
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(HoverLink)).Build().Perform();
            Thread.Sleep(5000);
            clickElement(ClickSneaker);
           
            clickElement(By.XPath("//*[@id=\"boost-pfs-filter-tree2-pf-pt-gender\"]/div/ul/li[2]/button"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@class=\"boost-pfs-filter-option-range-amount-min\"]")).Click();
            Thread.Sleep(3000);
            Actions actions = new Actions(driver);
            actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@class=\"boost-pfs-filter-option-range-amount-min\"]")).SendKeys("3000");
            driver.FindElement(By.XPath("//*[@class=\"boost-pfs-filter-option-range-amount-min\"]")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//*[@class=\"boost-pfs-filter-option-range-amount-max\"]")).SendKeys("6000" + Keys.Enter);
        
            clickElement(By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[5]/div[1]/div[1]/div/div/div/div[3]/div[4]/div[2]/div/ul/li[3]"));
            Thread.Sleep(3000);
            Scroll(move);
            clickElement(By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[5]/div[1]/div[1]/div/div/div/div[3]/div[5]/div[2]/div/ul/li[1]"));
        
            clickElement(By.XPath("//*[@id='shopify-section-collection-template-boost-pfs-filter']/div[5]/div[1]/div[2]/div[2]/div[1]/div/div[2]/div/a"));
          
             driver.Navigate().Back();
            

        }

      

        #endregion




    }
}
