using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Project_Bata.Login;

namespace Project_Bata.AddToCart
{
    [TestClass]
    public class CartMtd : ClassBase
    {
        CartLoc obj = new CartLoc();

        [TestMethod]

        public void filterSneakers()
        {
         //   ClassBase.SetDriver("Edge");

            obj.hoverlink();
            obj.sneaker();
            obj.Selectsize();
            obj.addtocart();
            obj.cartclose();
            obj.SecondMenClick();
            obj.selectSandal();
            obj.Selectsize1();
            obj.addtocart1();
            obj.closeshopping();
            obj.Womenhoverlink();
            obj.WomenPartyShoes();
            obj.Selectsize2();
            obj.addtocart2();
            obj.closeshopping1();
            obj.SecondMenClick2();
            obj.WomenPump();
            obj.Selectsize3();
            obj.addtocart3();
            obj.closeshopping3();
            obj.womenClick3();
            obj.clickSock();
            obj.addtocart4();
            obj.closeshopping4();
        }

    }
}