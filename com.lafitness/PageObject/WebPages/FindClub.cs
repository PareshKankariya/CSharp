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


namespace com.lafitness.PageObjects
{
    public class FindClub
    {
        public IWebDriver driver;
        private static IWebElement element = null;
        public FindClub(IWebDriver browser)
        {
            this.driver = browser;
        }
        
        public void launchFindClub()
        {

            IWebElement findClub = driver.FindElement(By.XPath(UIElements.FindUIElements.FindClub));
            findClub.Click();
        }

        public static IWebElement findClubByZipTxt(IWebDriver driver)
        {
            element = driver.FindElement(By.Id(UIElements.FindUIElements.FindClubByZipCode));
            return element;
        }

        public static IWebElement findClubByZipBtn(IWebDriver driver)
        {
            element = driver.FindElement(By.Id(FindUIElements.clubByZipFindBtn));
            return element;
        }

        public static IWebElement findClubSearchResultByZipSortByCity(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.clubSortByCity));           
            //SelectElement oSelectElement = new SelectElement(element);            
            //oSelectElement.SelectByText(FindUIElements.clubSortByCity);
            return element;
        }

    }     
            


}
