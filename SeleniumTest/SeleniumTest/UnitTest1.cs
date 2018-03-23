using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();


        [TestMethod]
        [Priority(1)]

        public void SetUp()
        {
            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-switch-windows/");
        }

        [TestMethod]
        [Priority(2)]
        public void TestCases()
        {
            driver.FindElement(By.Id("colorVar"));

        }

        [TestMethod]
        [Priority(3)]

        public void TearDown()
        {
            driver.Close();
        }

    }
}
