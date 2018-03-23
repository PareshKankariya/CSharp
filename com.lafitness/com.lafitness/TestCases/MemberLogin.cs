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
    class MemberLogin
    {
        IWebDriver driver;
        IWebElement element = null;
        public MemberLogin(IWebDriver browser)
        {
            this.driver = browser;
        }
          public void Login()
        {
            //Thread.Sleep(5000);
            String logIn = FindUIElements.MemberLoginBtn;
            IWebElement memberLoginPage = driver.FindElement(By.XPath(logIn));
            memberLoginPage.Click();
            String userName = FindUIElements.UserName;
            String password = FindUIElements.Password;
            Thread.Sleep(5000);
            IWebElement userNameField = driver.FindElement(By.Id(FindUIElements.UserNameField));
            IWebElement passwordField = driver.FindElement(By.Id(FindUIElements.PasswordField));
            IWebElement signInButton = driver.FindElement(By.Id(FindUIElements.SignInBtn));
            userNameField.SendKeys(userName);
            passwordField.SendKeys(password);
            signInButton.Click();
        }
    }
  }
