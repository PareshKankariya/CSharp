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
    class LaunchAndExit
    {
         IWebDriver driver;
        public static readonly ILog logger = LogManager.GetLogger(typeof(Main));

        public LaunchAndExit(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void launchURL()
        {
            try
            {
                String baseURL = FindUIElements.BaseURL;
                driver.Navigate().GoToUrl(baseURL);
                String title = driver.Title;
                Console.WriteLine("Page title is: " + title);
                driver.Manage().Window.Maximize();
                //Implicit Wait
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                
                if (driver.Title.Contains(FindUIElements.MainSiteTitle))         
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                else
                    logger.Error("Test FAILED - Incorrect Title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MainSiteTitle);

            }
            catch (Exception e)
            {
                logger.Error("Exception occured : " + e);                
            }                 
        }

        public void exitBrowser()
        {
            logger.Info("Testing completed. Closing the browser");
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
