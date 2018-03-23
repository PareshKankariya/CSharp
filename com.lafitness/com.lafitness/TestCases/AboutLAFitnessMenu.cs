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
    public class AboutLAFitnessMenu
    {
        public static readonly ILog logger = LogManager.GetLogger(typeof(AboutLAFitnessMenu));
        public IWebDriver driver;
      //  private static IWebElement element = null;
        
        public AboutLAFitnessMenu(IWebDriver browser)
        {
            this.driver = browser;

        }

        public void WhyJoinPage(IWebDriver driver)
        {

            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.WhyJoinPage(driver)).Click().Perform();
                if (driver.Title == FindUIElements.AboutLAWhyJoinTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : "+ FindUIElements.AboutLAWhyJoinTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
                 
        }

        public void History(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.History(driver)).Click().Perform();
                if (driver.Title == FindUIElements.AboutLAFHistoryTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.AboutLAFHistoryTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }

        public void CareerOpportunities(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.CareerOpportunities(driver)).Click().Perform();
                if (driver.Title == FindUIElements.CareerOpportunityTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.CareerOpportunityTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }

        }
        public void EventsNews(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.EventsNews(driver)).Click().Perform();
                if (driver.Title == FindUIElements.EventsNewTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.EventsNewTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }

        }

        public void MediaRelations(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.MediaRelations(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MediaRelationsTitle)
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

        public void Leagues(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.Leagues(driver)).Click().Perform();
                if (driver.Title == FindUIElements.LeaguesTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title: " + FindUIElements.LeaguesTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }

        }

        public void ContactUs(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.ContactUs(driver)).Click().Perform();
                if (driver.Title == FindUIElements.ContactUsTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.ContactUsTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }

        }

        public void PrivacyPolicy(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.PrivacyPolicy(driver)).Click().Perform();
                if (driver.Title == FindUIElements.PrivacyPolicyTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.PrivacyPolicyTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }

        }

        public void CorporatePrograms(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(AboutLAFitness.AboutUs(driver)).Perform();
                action.MoveToElement(AboutLAFitness.CorporatePrograms(driver)).Click().Perform();
                if (driver.Title == FindUIElements.CorporateProgramsTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.CorporateProgramsTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }

        }

    }
}
