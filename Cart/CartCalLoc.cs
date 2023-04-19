using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using Project_Bata.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Bata.Cart
{

    public class CartCalLoc : ClassBase
    {
        By menMenuItem = By.XPath("//*[@id='nav']/li[2]/a");
        By comfortMenuItem = By.XPath("//*[@id='nav']/li[2]/ul/div/span/li[1]/ul/li[4]/a");
        By eid2023Item = By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[5]/div[1]/div[1]/div/div/div/div[3]/div[2]/div[2]/div/ul/li[6]/a/span[2]");
        By firstItem = By.XPath("//*[@id='shopify-section-collection-template-boost-pfs-filter']/div[5]/div[1]/div[2]/div[2]/div[1]/div/div[2]/div/a");
        By sizeSelect = By.XPath("/html/body/div[3]/div[1]/div[5]/div[1]/div/div[3]/div/div[1]/form/div[4]/div[3]/label");
        By addToCartButton = By.XPath("//*[@id='product-add']/input");
        By close = By.XPath("/html/body/div[1]/div[1]/div[2]/span");

        public void hoverlink()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(menMenuItem)).Build().Perform();
            Thread.Sleep(3000);
            clickElement(comfortMenuItem);
            Thread.Sleep(3000);
        }

        public void SelectEidSubType()
        {
            clickElement(eid2023Item);
            Thread.Sleep(3000);
        }

        public void SelectFirstItem()
        {
            clickElement(firstItem);
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
    }
}

