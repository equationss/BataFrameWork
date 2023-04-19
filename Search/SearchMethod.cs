using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium;
using System.Threading;
using Project_Bata.Login;

namespace Project_Bata.SearchLoc
{
    [TestClass]
    public class SearchMethod : ClassBase
    {
        SearchLoc obj = new SearchLoc();

        [TestMethod]

        public void KeyToBeSearch()
        {
         //   ClassBase.SetDriver("Edge");
            obj.SearchBar("search1");
            Thread.Sleep(20000);
            obj.enter();
            Thread.Sleep(20000);
            obj.Asserrtt();
        }
    }
}

