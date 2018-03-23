using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using com.lafitness.UIElements;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using com.lafitness.PageObjects;
using log4net;
using log4net.Config;

namespace com.lafitness.TestCases
{
    class PersonalTrainingPage
    {
        public static readonly ILog logger = LogManager.GetLogger(typeof(PersonalTrainingPage));
        private IWebDriver driver;
        public IWebElement element = null;
        public PersonalTrainingPage(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void ClickPersonalTrainingPage()
        {
            try
            {
                element = driver.FindElement(By.XPath(UIElements.FindUIElements.PersonalTraining));
                element.Click();
                if(driver.Title == UIElements.FindUIElements.PersonalTrainingPageTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.PersonalTrainingPageTitle);
                }
            }
            catch (Exception e)
            {
                logger.Error("Exception occured : " + e);
            }
        }

    }
}
