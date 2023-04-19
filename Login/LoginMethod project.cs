using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Project_Bata.Login
{
    [TestClass]
    public class LoginMethod : ClassBase

    {
        Login obj = new Login();

        ClassBase obj2 = new ClassBase();
        string actual;
        string expected;

        [TestMethod]
        public void LoginWithValidCredentials()
        {
           
            obj.LoginButton();
            obj.RegisterButton();
            obj.EmailField("ehsaanamjad9@gmail.com");
            obj.mobilenumber("3259427224");
            obj.OTPverificationButton();
           
            Thread.Sleep(5000);
            expected = obj.VerifyExistingUser();
            Console.WriteLine(expected);
      
            obj2.AssertEqual(expected, "You are already registered");
         
            driver.Navigate().Back();
           
            obj.username("ehsaanamjad9@gmail.com");
            obj.password("ContourIsGreat@1");
            Thread.Sleep(5000);
            obj.signButton();
            Thread.Sleep(5000);
            expected = obj.VerifyLoginPage();
            Console.WriteLine(expected);
            Thread.Sleep(5000);
            obj2.AssertEqual(expected, "LOGOUT");
        }
    }
}
