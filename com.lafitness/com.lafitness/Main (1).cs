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
using com.lafitness.TestCases;
using com.lafitness.PageObjects;
using NUnit.Framework;
using log4net;
using log4net.Config;


namespace com.lafitness
{
    [TestClass]
    public class Main
    {
        public static readonly ILog logger = LogManager.GetLogger(typeof(Main));
    //    BasicConfigurator.Configure();
        static IWebDriver driver = new ChromeDriver();
       LaunchAndExit setUp = new LaunchAndExit(driver);      
       FindClub findClub = new FindClub(driver);

        //GelAllLinksOnWebSite getLinks = new GelAllLinksOnWebSite(driver);
        FindClubPageTesting clubPageTest = new FindClubPageTesting(driver);
        GetClubAmenities clubAmenities = new GetClubAmenities(driver);
        AboutLAFitnessMenu aboutMenu = new AboutLAFitnessMenu(driver);
        GroupFitnessPage groupFitnessPage = new GroupFitnessPage(driver);
        PersonalTrainingPage personalTrainingPage = new PersonalTrainingPage(driver);
        SocialMedia socialMediaMenu = new SocialMedia(driver);
        ShopLAFitness shop = new ShopLAFitness(driver);
        FindClass findClass = new FindClass(driver);
        MemberTools memberTools = new MemberTools(driver);
        //SearchClubByZip searchClubByZip = new SearchClubByZip(driver);
        MemberLogin memberLogin = new MemberLogin(driver);
        MembershipFunctions membershipFunctions = new MembershipFunctions(driver);

        
        [Test Order(1)]
        
        public void Launch()
        {         
             setUp.launchURL();         
        }

        [Test, Order(2)]
        public void AboutUsLinks()
        {
            #region
            //Click on all the links from About Us top menu
            aboutMenu.WhyJoinPage(driver);                      
            aboutMenu.History(driver);
           aboutMenu.CareerOpportunities(driver);
           aboutMenu.EventsNews(driver);
           aboutMenu.MediaRelations(driver);
           aboutMenu.Leagues(driver);
           aboutMenu.ContactUs(driver);
           aboutMenu.PrivacyPolicy(driver);
           aboutMenu.CorporatePrograms(driver);           
            #endregion
        }

        [Test, Order(3)]

        public void GroupFitness()
        {
            //  groupFitnessPage.grp();
            //  groupFitnessPage.GroupFitnessPageLocateClass();
            groupFitnessPage.grpAssert();

        }

        [Test, Order(4)]
        public void PersonalTraining()
        {
            personalTrainingPage.ClickPersonalTrainingPage();
        }
         
        [Test, Order(5)]     
        public void SocialMediaMenu()
        {
            socialMediaMenu.SocialMediaOverview(driver);
            socialMediaMenu.SocialMediaLivingHealthy(driver);
            socialMediaMenu.SocialMediaFacebook(driver);
            socialMediaMenu.SocialMediaTwitter(driver);
            socialMediaMenu.SocialMediaYouTube(driver);
            socialMediaMenu.SocialMediaGooglePlus(driver);
            socialMediaMenu.SocialMediaInstagram(driver);
        }

        [Test, Order(6)]

        public void shopLAFitness()
        {
            shop.shopPage(driver);
        }
        
        [Test, Order(7)]

        public void findClassPage()
        {
            findClass.findClassPage(driver);
        }
        

        [Test, Order(8)]
        public void memberToolsPage()
        {
            memberTools.MemberToolsCreateOnlineAccount(driver);
            memberTools.MemberToolsMyClub(driver);
            memberTools.MemberToolsMyZone(driver);           
            memberTools.MemberToolsMyLAFitness(driver);
            memberTools.MemberToolsMyPersonalTraining(driver);
            memberTools.MemberToolsAddVIPGuest(driver);
            memberTools.MemberToolsAddFamilyMember(driver);
            memberTools.MemberToolsBillingInformation(driver);
            memberTools.MemberToolsMembershipQuestions(driver);
            Thread.Sleep(2000);
            memberTools.MemberToolsMobileApp(driver);
        }

       [Test, Order(9)]
      
        public void searchZip()
        {
            clubPageTest.searchClubByZipHome();
            clubPageTest.clickClubPage();

        }

        [Test, Order(10)]

        public void MemberLogin()
        {
            memberLogin.Login();
            membershipFunctions.MembershipFunctionAccountInformation();      
            membershipFunctions.MembershipFunctionTestCases();
        }  
        
        [Test, Order(11)]
        public void exit()
        {
            setUp.exitBrowser();

            logger.Info("\r\n=====================================\r\n");
        }

        }

      

        //public void getAllLinksOnthePage()
        //{
        //    IList<IWebElement> links = driver.FindElements(By.TagName("a"));
        //    foreach (IWebElement link in links)
        //    {
        //        Console.WriteLine(link.GetAttribute("href"));

        //    }
        //    Console.WriteLine("Total number of links :" + links.Count);
        //}

    

        //public void findClub()
        //{
        //    //Click on Find Club Link
        //    IWebElement findClub = driver.FindElement(By.XPath(UIElements.FindUIElements.FindClub));
        //    findClub.Click();

        //    //Search for club in 91765 zip code
        //    IWebElement findClubByZipCode = driver.FindElement(By.Id(UIElements.FindUIElements.FindClubByZipCode));
        //    findClubByZipCode.Click();
        //    findClubByZipCode.SendKeys(FindUIElements.FindClubByZip);
        //    IWebElement clubByZipFindBtn = driver.FindElement(By.Id(FindUIElements.clubByZipFindBtn));
        //    clubByZipFindBtn.Click();
        //    Thread.Sleep(3000);


        //    //Sort by 
        //    IWebElement sortBy = driver.FindElement(By.XPath(UIElements.FindUIElements.clubSortBy));
        //    SelectElement oSelect = new SelectElement(sortBy);
        //    oSelect.SelectByText(UIElements.FindUIElements.clubSortByCity);
        //    Thread.Sleep(3000);

        //    ////Click on Diamond Bar club
        //    IWebElement diamondBarClub = driver.FindElement(By.LinkText(UIElements.FindUIElements.DiamondBarClubLinkText));
        //    diamondBarClub.Click();
        //    Console.WriteLine("Page Title for Db club is : " + driver.Title);
        //    Thread.Sleep(5000);
        //    //Get Club Amenities

        //    //Switch to new tab
        //    driver.SwitchTo().Window(driver.WindowHandles.Last());
        //    IList<IWebElement> amenities = driver.FindElements(By.XPath(UIElements.FindUIElements.listOfAmenities));
        //    Console.WriteLine(amenities.Count);
        //    foreach (IWebElement amenity in amenities)
        //    {
        //        Console.WriteLine(amenity.Text);
        //    }
        //    //div//[@id='amenities']

        //    //driver.Close();
        //    driver.SwitchTo().Window(driver.WindowHandles.First());
        //    Console.WriteLine(driver.Title);

        //    Thread.Sleep(3000);

        //    IWebElement findClub2 = driver.FindElement(By.XPath(UIElements.FindUIElements.FindClub));

        //    findClub2.Click();

        //}


        //public void findClass()
        //{
        //    IWebElement findClass = driver.FindElement(By.XPath(""));
        //}


      

    }





