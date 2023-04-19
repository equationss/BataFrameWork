using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_Bata.Login
{
    [TestClass]
    public class LoginMethod : ClassBase

    {
          Login obj = new Login();

        [TestMethod]
        public void LoginWithValidCredentials()
        {
            //ClassBase.SetDriver("Chrome");
            obj.LoginButton();
            obj.RegisterButton();
            obj.EmailField("ehsaanamjad.fnt@gmail.com");
            obj.mobilenumber("3259427224");
            obj.OTPverificationButton();
            obj.ValidateRegisteredUser();
            //obj.popupmessage();
            driver.Navigate().Back();
            //driver.Navigate().Forward();
            //obj.LoginButton();
            obj.username("ehsaanamjad.fnt@gmail.com");
            obj.password("ContourIsGreat@1");
            obj.signButton();
            obj.HomeBata();
         
            //obj.SneakersCat();
        }
    }
}
