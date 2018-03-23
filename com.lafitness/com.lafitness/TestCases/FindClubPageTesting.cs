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

namespace com.lafitness.TestCases
{
    public class FindClubPageTesting
    {
        public IWebDriver driver;
        IWebElement element = null;
        public FindClubPageTesting(IWebDriver browser)
        {
            this.driver = browser;

        }

        public void searchClubByZipCode()
        {
            
            FindClub.findClubByZipTxt(driver).Click();
            FindClub.findClubByZipTxt(driver).SendKeys(FindUIElements.FindClubByZip);
            FindClub.findClubByZipBtn(driver).Click();
            Thread.Sleep(3000);
        }

        public void searchClubByZipHome()
        {
            element = driver.FindElement(By.Id(FindUIElements.SearchClubByZip));
            element.Click();
            element.SendKeys(FindUIElements.ZipCode);
            element.SendKeys(Keys.Enter);
        }
        public void searchResultSortByCity()
        {
            FindClub.findClubSearchResultByZipSortByCity(driver).Click();
            Console.WriteLine(driver.Title);
            Thread.Sleep(3000);
        }

        public void clickClubPage()
        {
            FindClub.clickOnClubPage(driver).Click();
        }
      

    }
}
