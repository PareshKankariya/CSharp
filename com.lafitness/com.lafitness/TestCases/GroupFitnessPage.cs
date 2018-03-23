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
    class GroupFitnessPage
    {
        public static readonly ILog logger = LogManager.GetLogger(typeof(GroupFitnessPage));
        public IWebDriver driver;
        IWebElement element = null;
        public GroupFitnessPage(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void ClickGroupFitnessPage()
        {
            try
            {
                element = driver.FindElement(By.XPath(UIElements.FindUIElements.GroupFitness));
                element.Click();
                Assert.AreEqual(UIElements.FindUIElements.GroupFitnessPageTitle, driver.Title);
                if (driver.Title == UIElements.FindUIElements.GroupFitnessPageTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MediaRelationsTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }             
                     
        }
        public void grp()
        {
            element = driver.FindElement(By.XPath(UIElements.FindUIElements.GroupFitness));
            element.Click();
            Boolean assertFail = false;
            
            if (driver.Title != UIElements.FindUIElements.GroupFitnessPageTitle)
                assertFail = true;
          if(assertFail==true)
            {            
                logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.GroupFitnessPageTitle);                
            }
                
          else
            {            
                logger.Info("Test PASSED");
            }               
            
        }




        public void grpAssert()
        {

            try
            {
                element = driver.FindElement(By.XPath(UIElements.FindUIElements.GroupFitness));
                element.Click();

                string pageTitle = driver.Title;

                Assert.IsTrue(pageTitle.Equals(UIElements.FindUIElements.GroupFitnessPageTitle), pageTitle + "Incorrect Title");
                
            }

            catch (AssertFailedException a)
            {
              
                logger.Error(a.ToString());
                throw;

            }
            catch (Exception e)
            {
                logger.Error("Exception occured " + e);

                throw;
            }
          
            
           // logger.Error("Test Failed");
                    

        }





        public void GroupFitnessPageLocateClass()
        {
            logger.Info("Search for Yoga class within 20 miles of DiamondBar");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(UIElements.FindUIElements.SelectClassDropdown)));

            element = driver.FindElement(By.XPath(UIElements.FindUIElements.SelectClassDropdown));
            SelectElement selectClass = new SelectElement(element);

            selectClass.SelectByValue("28"); //Select Yoga class from dropdown
            //Thread.Sleep(2000);

            driver.FindElement(By.Id(UIElements.FindUIElements.ZipCodeTxt)).SendKeys(UIElements.FindUIElements.ZipCode);

            IWebElement radius = driver.FindElement(By.Id(UIElements.FindUIElements.RadiusDropdown));
            SelectElement selectRadius = new SelectElement(radius);
            selectRadius.SelectByValue("20");

            driver.FindElement(By.Id(UIElements.FindUIElements.LocateAClassBtn)).Click();
            //Thread.Sleep(4000);
            logger.Info("Search Completed");
            logger.Info("Select DB club from search");

            //ClubView
            driver.FindElement(By.XPath(UIElements.FindUIElements.DBYogaSchedule)).Click();

            logger.Info("Click on DB Home Page");
            //Go to DB Club home Page. Will open in new window

           // Thread.Sleep(3000);
            IWebElement DBHomePageLink = driver.FindElement(By.XPath(UIElements.FindUIElements.DBClubHomePage));

            Actions action = new Actions(driver);
            action.MoveToElement(DBHomePageLink).Click().Perform();
            //DBHomePageLink.Click();
            //action.Perform();
            Thread.Sleep(2000);
            logger.Info("Back to Group Fitness Page");
            element = driver.FindElement(By.XPath(UIElements.FindUIElements.GroupFitness));
            element.Click();

            //driver.FindElement(By.Id(UIElements.FindUIElements.BackToGroupFitnessBtn)).Click(); //Back to Group Fitness Page






        }


    }
}
