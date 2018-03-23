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
    public class SocialMedia
    {
        public static ILog logger = LogManager.GetLogger(typeof(SocialMedia));
        IWebDriver driver;
        SocialMediaPageElements smElements = new SocialMediaPageElements();
        public SocialMedia(IWebDriver browser)
        {
            this.driver = browser;                
        }

        public void SocialMediaOverview(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(smElements.SocialMedia(driver)).Perform();
                action.MoveToElement(smElements.SocialMediaOverview(driver)).Click().Perform();
                String pageTitle = driver.Title;

                Assert.IsTrue(pageTitle.Equals("LA Fitness | Reviews | Social Media | Welcome"), pageTitle);
                logger.Info("Social Media Menu Overview " + driver.Title);
            }
            catch (AssertFailedException ae)
            {
                logger.Error("Assert Fail Exception " + ae);
                throw ae;
            }

            catch (Exception e)
            {
                logger.Error("Other exceptions " + e);
                throw e;
            }                   
        }

        public void SocialMediaLivingHealthy(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(smElements.SocialMedia(driver)).Perform();
                action.MoveToElement(smElements.SocialMediaLivingHealthy(driver)).Click().Perform();
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                String pageTitle = driver.Title;

                Assert.IsTrue(pageTitle.Equals("LA Fitness | Living Healthy | Official LA Fitness Blog"), pageTitle);
                logger.Info("Social Media Menu Living Healthy" + driver.Title);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());
            }
            catch (AssertFailedException ae)
            {
                logger.Error("Assert Fail Exception " + ae);
                throw ae;
            }

            catch (Exception e)
            {
                logger.Error("Other exceptions " + e);
                throw e;
            }
        }

        public void SocialMediaFacebook(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(smElements.SocialMedia(driver)).Perform();
                action.MoveToElement(smElements.SocialMediaFacebook(driver)).Click().Perform();
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                String pageTitle = driver.Title;

                Assert.IsTrue(pageTitle.Equals("LA Fitness - Home | Facebook"), pageTitle);
                logger.Info("Social Media Menu Facebook" + driver.Title);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());
            }
            catch (AssertFailedException ae)
            {
                logger.Error("Assert Fail Exception " + ae);
                throw ae;
            }

            catch (Exception e)
            {
                logger.Error("Other exceptions " + e);
                throw e;
            }
        }

        public void SocialMediaTwitter(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(smElements.SocialMedia(driver)).Perform();
                action.MoveToElement(smElements.SocialMediaTwitter(driver)).Click().Perform();
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                String pageTitle = driver.Title;

                Assert.IsTrue(pageTitle.Equals("LA Fitness (@LAFitness) | Twitter"), pageTitle);
                logger.Info("Social Media Menu Twitter" + driver.Title);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());
            }
            catch (AssertFailedException ae)
            {
                logger.Error("Assert Fail Exception " + ae);
                throw ae;
            }

            catch (Exception e)
            {
                logger.Error("Other exceptions " + e);
                throw e;
            }
        }

        public void SocialMediaYouTube(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(smElements.SocialMedia(driver)).Perform();
                action.MoveToElement(smElements.SocialMediaYouTube(driver)).Click().Perform();
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                String pageTitle = driver.Title;

                Assert.IsTrue(pageTitle.Equals("LA Fitness - YouTube"), pageTitle);
                logger.Info("Social Media Menu YouTube" + driver.Title);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());
            }
            catch (AssertFailedException ae)
            {
                logger.Error("Assert Fail Exception " + ae);
                throw ae;
            }

            catch (Exception e)
            {
                logger.Error("Other exceptions " + e);
                throw e;
            }
        }

        public void SocialMediaGooglePlus(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(smElements.SocialMedia(driver)).Perform();
                action.MoveToElement(smElements.SocialMediaGoolePlus(driver)).Click().Perform();
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                String pageTitle = driver.Title;

                Assert.IsTrue(pageTitle.Contains("LA Fitness - Google+"), pageTitle);
                logger.Info("Social Media Menu Google Plus" + driver.Title);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());
            }
            catch (AssertFailedException ae)
            {
                logger.Error("Assert Fail Exception " + ae);
                throw ae;
            }

            catch (Exception e)
            {
                logger.Error("Other exceptions " + e);
                throw e;
            }
        }

        public void SocialMediaInstagram(IWebDriver driver)
        {
            try
            {
                Actions action = new Actions(driver);
                action.MoveToElement(smElements.SocialMedia(driver)).Perform();
                action.MoveToElement(smElements.SocialMediaInstagram(driver)).Click().Perform();
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                String pageTitle = driver.Title;

                Assert.IsTrue(pageTitle.Contains("LAFitness (@lafitness)"), pageTitle);
                logger.Info("Social Media Menu Instagram" + driver.Title);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles.First());
            }
            catch (AssertFailedException ae)
            {
                logger.Error("Assert Fail Exception " + ae);
                throw ae;
            }

            catch (Exception e)
            {
                logger.Error("Other exceptions " + e);
                throw e;
            }
        }








    }
}
