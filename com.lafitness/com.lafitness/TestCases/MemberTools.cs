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
using POM.Elements;

namespace com.lafitness.TestCases
{
    class MemberTools
    {
        public static readonly ILog logger = LogManager.GetLogger(typeof(MemberTools));

        public IWebDriver driver;
        
        public MemberTools(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void MemberToolsCreateOnlineAccount(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.CreateOnlineAccount(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MemberToolsCreateOnlineAccountTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsCreateOnlineAccountTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }


        }

        public void MemberToolsMyLAFitness(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.MyLAFitness(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MemberToolsMyLAFitnessTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsCreateOnlineAccountTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }

        public void MemberToolsMyZone(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.MyZone(driver)).Click().Perform();
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                if (driver.Title == FindUIElements.MemberToolsMyZoneTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsMyZoneTitle);
                }
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }

        public void MemberToolsMyClub(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.MyClub(driver)).Click().Perform();           
                if (driver.Title == FindUIElements.MemberToolsMyClubTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsMyClubTitle);
                }               
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }
        public void MemberToolsMyPersonalTraining(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.MyPersonalTraining(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MemberToolsMyPersonalTrainingTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsMyPersonalTrainingTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }

        public void MemberToolsAddVIPGuest(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.AddVIPGuest(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MemberToolsAddVIPGuestTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsAddVIPGuestTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }

        public void MemberToolsAddFamilyMember(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.AddFamilyMember(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MemberToolsAddFamilyMemberTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsAddFamilyMemberTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }
        public void MemberToolsBillingInformation(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.BillingInformation(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MemberToolsBillingInformationTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsBillingInformationTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }
        public void MemberToolsMembershipQuestions(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.MembershipQuestions(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MemberToolsMembershipQuestionsTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsMembershipQuestionsTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }
        public void MemberToolsMobileApp(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(MemberToolsMenu.MemberTools(driver)).Perform();
                action.MoveToElement(MemberToolsMenu.MobleApp(driver)).Click().Perform();
                if (driver.Title == FindUIElements.MemberToolsMobileAppTitle)
                {
                    logger.Info("Test Passed. Current Method : " + this.GetType().FullName);
                }
                else
                {
                    logger.Error("Test FAILED - Incorrect title. Current Title :" + this.driver.Title + " Expected Title : " + FindUIElements.MemberToolsMobileAppTitle);
                }
            }
            catch (Exception e)
            {

                logger.Error("Exception occured : " + e);
            }
        }



    }
}
