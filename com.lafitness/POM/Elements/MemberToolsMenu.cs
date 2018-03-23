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

namespace POM.Elements
{
    public class MemberToolsMenu
    {
        public IWebDriver driver;
        private static IWebElement element = null;
        public MemberToolsMenu(IWebDriver browser)
        {
            this.driver = browser;
        }

        public static IWebElement MemberTools(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.memberTools));
            return element;
        }
        public static IWebElement CreateOnlineAccount(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsCreateOnlineAccount));
            return element;
        }

        public static IWebElement MyLAFitness(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsMyLAFitness));
            return element;
        }

        public static IWebElement MyZone(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsMyZone));
            return element;
        }
        public static IWebElement MyClub (IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsMyClub));
            return element;
        }
        public static IWebElement MyPersonalTraining(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsMyPersonalTraining));
            return element;
        }
        public static IWebElement AddVIPGuest(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsAddVIPGuest));
            return element;
        }
        public static IWebElement AddFamilyMember(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsAddFamilyMember));
            return element;
        }
        public static IWebElement BillingInformation(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsBillingInformation));
            return element;
        }
        public static IWebElement MembershipQuestions(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsMembershipQuestions));
            return element;
        }
        public static IWebElement MobleApp(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.MemberToolsMobileApp));
            return element;
        }


    }
}
