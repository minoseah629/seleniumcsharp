using OpenQA.Selenium;
using SeleniumDemo;

namespace MyVector.UI.ElementsRepo
{
    public class SharedElements : Page
    {
        public IWebElement Header => Driver.FindElement(By.TagName("h1"));

        public IWebElement H2Text => Driver.FindElement(By.TagName("h2"));

        public IWebElement NarrativeText => Driver.FindElement(By.ClassName("lead"));

        public IWebElement H3Element => Driver.FindElement(By.TagName("h3"));

        public IWebElement H4Element => Driver.FindElement(By.TagName("h4"));

        public SharedElements(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
    }
}