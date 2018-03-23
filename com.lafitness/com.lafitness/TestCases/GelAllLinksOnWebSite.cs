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
using com.lafitness.TestCases;


namespace com.lafitness.TestCases
{
   public class GelAllLinksOnWebSite
    {
        IWebDriver driver;

        public GelAllLinksOnWebSite(IWebDriver browser)
        {
            this.driver = browser;
        }
        public void getAllLinksOnthePage()
        {
            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            foreach (IWebElement link in links)
            {
                Console.WriteLine(link.GetAttribute("href"));

            }
            Console.WriteLine("Total number of links :" + links.Count);
        }

    }
}
