using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDemo
{
    public class LoginTest : BaseUiTest
    {
        public LoginTest()
        {
            BaseUrl = "";
        }
        
        public void Login(string user)
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public void LoadApp()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }
    }

}
