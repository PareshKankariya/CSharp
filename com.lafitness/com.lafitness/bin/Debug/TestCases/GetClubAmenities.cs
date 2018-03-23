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
    class GetClubAmenities
    {
        public IWebDriver driver;
        public GetClubAmenities(IWebDriver browser)
        {
            this.driver = browser;
        }
        public void getAmenitiesForClub(IWebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            IList<IWebElement> amenities = driver.FindElements(By.XPath(UIElements.FindUIElements.listOfAmenities));
            Console.WriteLine("Total Club Amenities for Club: "+amenities.Count);
            Console.WriteLine("Club amenities available at the club : " );
            foreach (IWebElement amenity in amenities)
            {
                Console.WriteLine(amenity.Text);
            }
            driver.Close();
        }
    }
}
