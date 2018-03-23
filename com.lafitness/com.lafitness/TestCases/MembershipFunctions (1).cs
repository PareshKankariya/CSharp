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
    
    class MembershipFunctions
    {
        IWebDriver driver;
        IWebElement element = null;

        public MembershipFunctions(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void AccountInformationProfile()
        {
            element = driver.FindElement(By.XPath(UIElements.FindUIElements.AccountInformationProfile));
            element.Click();
        }

        public void AccountInformationFacebook()
        {
            IWebElement facebbookElement = driver.FindElement(By.XPath(FindUIElements.AccountInformationFacebook));
            facebbookElement.Click();
        }
        public void AccountInformationNotifications()
        {
            IWebElement facebbookElement = driver.FindElement(By.XPath(FindUIElements.AccountInformationNotifications));
            facebbookElement.Click();
        }

        public void MyHome()
        {
            IWebElement myHomeElement = driver.FindElement(By.XPath(FindUIElements.MyHome));
            myHomeElement.Click();
        }

        public void Calender()
        {
            IWebElement calendarElement = driver.FindElement(By.XPath(FindUIElements.Calendar));
            calendarElement.Click();
        }

        public void FitnessFriends()
        {
            IWebElement fitnessFriendsElement = driver.FindElement(By.XPath(FindUIElements.FitnessFriends));
            fitnessFriendsElement.Click();
        }

        public void LeaguesAndActivities()
        {
            IWebElement leaguesAndActivitiesElement = driver.FindElement(By.XPath(FindUIElements.LeaguesAndActivities));
            leaguesAndActivitiesElement.Click();
        }
        
        public void ArticlesAndVideos()
        {
            IWebElement articlesAndVideosElement = driver.FindElement(By.XPath(FindUIElements.ArticlesAndVideos));
            articlesAndVideosElement.Click();
        }

        public void MembershipFunctionAccountInformation()
        {
          
            AccountInformationProfile();
            AccountInformationFacebook();
            AccountInformationNotifications();
        }

        public void MembershipFunctionTestCases()
        {
            MyHome();
            Calender();
            FitnessFriends();
            LeaguesAndActivities();
            ArticlesAndVideos();


        }









    }
}
