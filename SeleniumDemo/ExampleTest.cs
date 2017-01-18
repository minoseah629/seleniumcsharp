using System;
using System.Linq;
using Xunit;

namespace SeleniumDemo
{
    public class ExampleTest : LoginTest
    {
        [Fact]
        public void TestMethod1()
        {
            Login("");
            Repo.Example.ExampleElement.Click();
        }
    }
}
