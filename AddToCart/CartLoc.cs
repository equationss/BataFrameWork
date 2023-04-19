using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Firefox;
using Project_Bata.Login;
using Project_Bata.Login;



namespace Project_Bata.AddToCart
{
        public class CartLoc : ClassBase
        {

            By HoverLink = By.XPath("//nav[@class='gridlock-fluid']/div/div/ul/li[2]");
            By ClickSneaker = By.XPath("//ul[@class='mega-stack']//a[@href = '/collections/men-sneakers']");
            By oneSneakers = By.XPath("//*[@id='shopify-section-collection-template-boost-pfs-filter']/div[5]/div[1]/div[2]/div[2]/div[3]/div/div[2]/div/a");
            By sizeSelect = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[4]/div[3]/label");
            By addToCartButton = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[7]/input");
            By close = By.XPath("//*[@id='CartDrawer']/div[3]/a");
            By secondmenclick = By.XPath("//nav[@class='gridlock-fluid']/div/div/ul/li[2]");
            By MenSandal = By.XPath("//*[@id='nav']/li[2]/ul/div/span/li[1]/ul/li[5]/a");
            By ClickOnSandal = By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[5]/div[1]/div[2]/div[2]/div[1]/div/div[2]/div/a");
            By sizeSelect1 = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[4]/div[3]/label");
            By addToCartButton1 = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[7]/input");
            By continueToShopping = By.XPath("//*[@id='CartDrawer']/div[3]/a");
            By womenMenuItem1 = By.XPath("//*[@id='nav']/li[3]/a");
            By partywearItem = By.XPath("//*[@id='nav']/li[3]/ul/div/span/li[1]/ul/li[3]/a");
            By womenPartyWear = By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[5]/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/a");
            By sizeSelect2 = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[4]/div[3]/label");
            By addToCartButton2 = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[7]/input");
            By continueToShoppin2 = By.XPath("//*[@id='CartDrawer']/div[3]/a");
            By womenMenuItem2 = By.XPath("//*[@id='nav']/li[3]/a");
            By womenPumps = By.XPath("//*[@id='nav']/li[3]/ul/div/span/li[1]/ul/li[5]/a");
            By onewomenPumps = By.XPath("//*[@id='shopify-section-collection-template-boost-pfs-filter']/div[5]/div[1]/div[2]/div[2]/div[2]/div/div[2]/div/a");
            By sizeSelect3 = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[4]/div[3]/label");
            By addToCartButton3 = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[7]/input");
            By continueToShoppin3 = By.XPath("//*[@id='CartDrawer']/div[3]/a");
            By womenMenuItem3 = By.XPath("//*[@id='nav']/li[3]/a");
            By sock = By.XPath("//*[@id='nav']/li[3]/ul/div/span/li[2]/ul/li[2]/a");
            By onesock = By.XPath("//*[@id='shopify-section-collection-template-boost-pfs-filter']/div[5]/div[1]/div[2]/div[2]/div[1]/div/div[2]/div/a");
            By addToCartButton4 = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[7]/input");
            By continueToShoppin4 = By.XPath("//*[@id='CartDrawer']/div[3]/a");



            public void hoverlink()
            {

                Actions action = new Actions(driver);
                action.MoveToElement(driver.FindElement(HoverLink)).Build().Perform();
                Thread.Sleep(3000);
                clickElement(ClickSneaker);
            }

            public void SecondMenClick()
            {
                Actions action = new Actions(driver);
                action.MoveToElement(driver.FindElement(secondmenclick)).Build().Perform();
            Thread.Sleep(3000);
            clickElement(MenSandal);
            }
            public void Womenhoverlink()
            {

                Actions action = new Actions(driver);
                action.MoveToElement(driver.FindElement(womenMenuItem1)).Build().Perform();
            Thread.Sleep(3000);
            clickElement(partywearItem);
            }

            public void SecondMenClick2()
            {
                Actions action = new Actions(driver);
                action.MoveToElement(driver.FindElement(womenMenuItem2)).Build().Perform();
            Thread.Sleep(3000);
            clickElement(womenPumps);
            }

            public void womenClick3()
            {
                Actions action = new Actions(driver);
                action.MoveToElement(driver.FindElement(womenMenuItem3)).Build().Perform();
            Thread.Sleep(3000);
            clickElement(sock);
            }

            public void sneaker()
            {
                clickElement(oneSneakers);
            Thread.Sleep(3000);
        }

            public void Selectsize()
            {
                clickElement(sizeSelect);
            Thread.Sleep(3000);
        }

            public void addtocart()
            {
                clickElement(addToCartButton);
            Thread.Sleep(3000);
        }

            public void cartclose()
            {
                clickElement(close);
            Thread.Sleep(3000);
        }

            public void selectSandal()
            {
                clickElement(ClickOnSandal);
            Thread.Sleep(3000);
        }

            public void Selectsize1()
            {
                clickElement(sizeSelect1);
            Thread.Sleep(3000);
        }

            public void addtocart1()
            {
                clickElement(addToCartButton1);
            Thread.Sleep(3000);

        }

            public void closeshopping()
            {
                clickElement(continueToShopping);
            Thread.Sleep(3000);
        }

            public void WomenPartyShoes()
            {
                clickElement(womenPartyWear);
            Thread.Sleep(3000);
        }

            public void Selectsize2()
            {
                clickElement(sizeSelect2);
            Thread.Sleep(3000);
        }

            public void addtocart2()
            {
                clickElement(addToCartButton2);
            Thread.Sleep(3000);

        }

            public void closeshopping1()
            {
                clickElement(continueToShoppin2);
            Thread.Sleep(3000);
        }

            public void WomenPump()
            {
                clickElement(onewomenPumps);
            Thread.Sleep(3000);
        }

            public void Selectsize3()
            {
                clickElement(sizeSelect3);
            Thread.Sleep(3000);
        }

            public void addtocart3()
            {
                clickElement(addToCartButton3);
            Thread.Sleep(3000);
        }

            public void closeshopping3()
            {
                clickElement(continueToShoppin3);
            Thread.Sleep(3000);
        }

            public void clickSock()
            {
                clickElement(onesock);
            Thread.Sleep(3000);
        }

            public void addtocart4()
            {
                clickElement(addToCartButton4);
            Thread.Sleep(3000);

        }
            public void closeshopping4()
            {
            clickElement(continueToShoppin4);
            Thread.Sleep(3000);
            }
        }
}
