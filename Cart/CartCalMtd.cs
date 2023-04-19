using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project_Bata.Cart
{
    [TestClass]
    public class CartCalMtd
    {
        CartCalLoc obj = new CartCalLoc();

        [TestMethod]

        public void CheckAddTOCart()
        {
            //ClassBase.SetDriver("Edge");
            obj.hoverlink();
            obj.SelectEidSubType();
            obj.SelectFirstItem();
            obj.Selectsize();
            obj.addtocart();
            obj.cartclose();
        }
    }
}