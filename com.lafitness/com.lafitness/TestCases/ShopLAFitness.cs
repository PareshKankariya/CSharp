using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using log4net;


namespace com.lafitness.TestCases
{
    class ShopLAFitness
    {
        public static ILog logger = LogManager.GetLogger(typeof(ShopLAFitness));
        IWebDriver driver;
        IWebElement element = null;
        public ShopLAFitness(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void shopPage(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(UIElements.FindUIElements.shopLAFitness));
            element.Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            logger.Info("Shopping page title is : " + driver.Title);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());

        }
    }
}
