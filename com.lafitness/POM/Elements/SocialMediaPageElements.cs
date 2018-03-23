using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using POM.Elements;
using com.lafitness.UIElements;

namespace POM.Elements
{
   
    public class SocialMediaPageElements
    {
        IWebDriver driver;
        IWebElement element = null;

        public SocialMediaPageElements()
        {
                
        }
        public SocialMediaPageElements(IWebDriver browser)
        {
            this.driver = browser;
        }
        public IWebElement SocialMedia(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.SocialMediaMenu));
            return element;
        }

        public IWebElement SocialMediaOverview(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.SocialMediaMenuOverview));
            return element;
        }

        public IWebElement SocialMediaLivingHealthy(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.SocialMediaMenuLivingHealthy));
            return element;
        }

        public IWebElement SocialMediaFacebook(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.SocialMediaMenuFacebook));
            return element;
        }

        public IWebElement SocialMediaTwitter (IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.SocialMediaMenuTwitter));
            return element;
        }
        public IWebElement SocialMediaYouTube(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.SocialMediaMenuYouTube));
            return element;
        }

        public IWebElement SocialMediaGoolePlus(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.SocialMediaMenuGooglePlus));
            return element;
        }
        public IWebElement SocialMediaInstagram(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(FindUIElements.SocialMediaMenuInstagram));
            return element;
        }











    }
}
