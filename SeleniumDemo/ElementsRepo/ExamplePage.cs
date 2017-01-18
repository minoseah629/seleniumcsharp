using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumDemo.ElementsRepo
{
    public class ExamplePage: Page
    {
        public IWebElement ExampleElement => Driver.FindElement(By.Id("testId"));
        public ExamplePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
    }
}
