using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Firefox;

namespace Project_Bata.Login
{
    public class Login : ClassBase
    {
        
        #region Locators

        By LoginBTN = By.XPath("//img[@src='https://cdn.shopify.com/s/files/1/0143/1552/0054/files/eterywr1.png']");
        By RegisterBTN = By.XPath("//a[@href=\"/account/register\"]");
        By Email = By.XPath("//*[@id=\"easy-rewards-register\"]/div[1]/input");
        By MobileNumber = By.XPath("//*[@id=\"registration-form-phone\"]");
        By OTPverificationBTN = By.XPath("//*[@id=\"easy-rewards-register\"]/div[2]/div[2]/a");
        By Label = By.XPath("//span[text()='You are already registered']");
        By UserName = By.XPath("//*[@id=\"easy-rewards-login\"]/div[1]/input");
        By Password = By.XPath("//input[@name='password']");
        By SignBTN = By.XPath("//input[@value='SIGN IN']");
        By MENN = By.XPath("//nav[@class='gridlock-fluid']/div/div/ul/li[2]");
        By MENSS = By.XPath("//ul[@class='mega-stack']//a[@href = '/collections/men-sneakers']");

        #endregion
        #region Assertion Loc
        By asserttUser = By.XPath("//span[text()='You are already registered']");
        By assertLogin = By.XPath("//a[text()='LOGOUT']");
        #endregion

        #region Login Methods
        
        public void LoginButton()
        {
            clickElement(LoginBTN);
        }
        public void RegisterButton()
        {
            clickElement(RegisterBTN);
        }
        #endregion

        #region Exesting User Methods
        public void EmailField(string EMAIL)
        {
            SendKeysMethod(Email, EMAIL);
        }
        public void mobilenumber(string NUMBER)
        {
            SendKeysMethod(MobileNumber, NUMBER);
        }
        public void OTPverificationButton()
        {
            clickElement(OTPverificationBTN);
        }
       
       
        #endregion
        public void username(string USERNAME)
        {
            SendKeysMethod(UserName, USERNAME);
        }
        public void password(string PASSWORD)
        {
            SendKeysMethod(Password, PASSWORD);
        }     

        public void signButton()
        {
            Thread.Sleep(5000);
            clickElement(SignBTN);
        }       

        public void MoveToElement()
        {
            Thread.Sleep(5000);
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(MENN)).Build().Perform();
            Thread.Sleep(50000);
            clickElement(MENSS);
        }
       
        #region Assertion

      public string VerifyExistingUser()
        {
            return GetAttribute("innerHTML", asserttUser);
        }
      public string VerifyLoginPage()
        {
            return GetAttribute("innerHTML", assertLogin);
        }

        #endregion

    }

}
