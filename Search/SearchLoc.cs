using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using Project_Bata.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Bata.SearchLoc
{
    public class SearchLoc : ClassBase
    {

        By Search = By.XPath("//*[@id='boost-pfs-search-box-2']");
        By Enter = By.XPath("/html/body/div[3]/div[1]/div[1]/div/nav/div/div/ul/li[10]/form/button");
        By productname = By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[6]/div/div[2]/div[2]/div[1]/div/div[2]/div/a");





       
        public void SearchBar(string search1)
        {
            driver.FindElement(Search).SendKeys("Mocassino");
            Thread.Sleep(3000);
        }
        public void enter()
        {
            clickElement(Enter);
        }
        public void Asserrtt()
        {
            string ProductName = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[6]/div/div[2]/div[2]/div[1]/div/div[2]/div/a")).Text;
            Assert.AreEqual("Mocassino", ProductName);
            Console.WriteLine("Selected Item contains 'Mocassino'");
        }

    }
}
