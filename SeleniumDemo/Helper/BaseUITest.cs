using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;


namespace SeleniumDemo
{
    public class BaseUiTest: IDisposable
    {
        public ElementsRepository Repo { get; set; }
        public IWebDriver Driver;
        public WebDriverWait Wait { get; set; }
        //private StringBuilder verificationErrors;
        public string BaseUrl;

        public BaseUiTest()
        {
            Driver = new FirefoxDriver();
            Repo = new ElementsRepository(Driver);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(10));
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
