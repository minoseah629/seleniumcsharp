using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using By = OpenQA.Selenium.Extensions.By;

namespace SeleniumDemo
{
    public class ElementsRepository
    {
        public string User;
        public IWebDriver Driver { get; set; }
        
        public IWebElement Filter => Driver.FindElement(By.ClassName("k-icon k-filter"));

        public IWebElement Header => Driver.FindElement(By.TagName("h1"));

        public List<IWebElement> Collection => Driver.FindElements(By.Id("tag")).ToList();

        public IWebElement Xpath => Driver.FindElement(By.XPath("//a[contains(@href,\"AddBulletTracker')]"));

        public IWebElement jquery => Driver.FindElement(By.JQuerySelector("#id.chapter"));

        public ElementsRepository(IWebDriver driver)
        {
            Driver = driver;
        }

    }
    
    public class Page
    {
        public IWebDriver Driver { get; set; }

        public Page(IWebDriver driver)
        {
            Driver = driver;
        }

    }
}
