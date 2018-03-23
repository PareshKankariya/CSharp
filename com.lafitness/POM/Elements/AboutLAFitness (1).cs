using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using OpenQA.Selenium.Support.PageObjects;
using com.lafitness.UIElements;

namespace com.lafitness.PageObjects
{
    public class AboutLAFitness
    {
        public IWebDriver driver;
        private static IWebElement element = null;
        public AboutLAFitness(IWebDriver browser)
        {
            this.driver = browser;
        }

        public static IWebElement AboutUs(IWebDriver driver)
        {
            element = driver.FindElement(By.LinkText(FindUIElements.AboutLAFit));
            return element;
        }

        public static IWebElement WhyJoinPage(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.AboutLAFWhyJoin));
            return element;
        }

        public static IWebElement History(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.AboutLAFHistory));
            return element;
        }

        public static IWebElement CareerOpportunities(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.CareerOpportunity));
            return element;
        }

        public static IWebElement EventsNews(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.EventsNews));
            return element;
        }

        public static IWebElement MediaRelations(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MediaRelations));
            return element;
        }

        public static IWebElement Leagues(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.Leagues));
            return element;
        }

        public static IWebElement ContactUs(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.ContactUs));
            return element;
        }

        public static IWebElement PrivacyPolicy(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.PrivacyPolicy));
            return element;
        }

        public static IWebElement CorporatePrograms(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.CorporatePrograms));
            return element;
        }
        
    }
}




            //{
            //    try
            //    {

            //        IWebElement aboutLAFit = driver.FindElement(By.LinkText(FindUIElements.AboutLAFit));
            //        Thread.Sleep(5000);

            //        //Click on About LA Fitness                
            //        IWebElement menuWhyJoin = driver.FindElement(By.XPath(FindUIElements.AboutLAFWhyJoin));
            //        //Use JavaScriptExecutioner to click on About LAFitness menu so the sub menus are displayed
            //        ////IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            //        ////executor.ExecuteScript("arguments[0].click();", menuWhyJoin);
            //        ////Console.WriteLine(driver.Title);
            //        //Click Why join
            //        IWebElement menuHistory = driver.FindElement(By.XPath(FindUIElements.AboutLAFHistory));
            //        ////IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
            //        ////executor1.ExecuteScript("argument[0].click();",menuHistory);

            //        //Actions can be used instead of JavaScriptExecutioner            
            //        Actions action = new Actions(driver);
            //        action.MoveToElement(aboutLAFit).Perform();
            //        Thread.Sleep(2000);
            //   action.MoveToElement(menuWhyJoin).Click().Perform();

            //        Console.WriteLine(driver.Title);

            //        //driver.Navigate().Back();
            //        //Console.WriteLine(driver.Title);

            //        //driver.Navigate().Back();
            //        //Console.WriteLine(driver.Title);
            //    }
            //    catch (Exception ex)
            //    {
            //        String ss = ex.ToString();
            //        Console.WriteLine(ss);
            //    }

            //}

