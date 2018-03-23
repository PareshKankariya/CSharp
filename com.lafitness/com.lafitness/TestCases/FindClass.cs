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
using System.IO;

namespace com.lafitness.TestCases
{
    class FindClass
    {
        public static ILog logger = LogManager.GetLogger(typeof(FindClass));
        IWebDriver driver;
        IWebElement element;
        public FindClass(IWebDriver browser)
        {
            this.driver = browser;
        }

        public void findClassPage(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath(UIElements.FindUIElements.findClassPage));
            element.Click();
            logger.Info(driver.Title);

            IWebElement findClassClassName = driver.FindElement(By.Id(FindUIElements.findClassDropDown));
            IWebElement findClassZipCode = driver.FindElement(By.Id(FindUIElements.findClassZipCodeTxtBox));
            IWebElement findClassZipRadius = driver.FindElement(By.Id(FindUIElements.findClassRadiusDropDown));

            //Select Yoga class within 20 miles of Diamomd Bar
            SelectElement className = new SelectElement(findClassClassName);
            className.SelectByValue("28");

            findClassZipCode.SendKeys(FindUIElements.FindClubByZip);

            SelectElement classRadius = new SelectElement(findClassZipRadius);
            classRadius.SelectByValue("20");

            IWebElement findBtn = driver.FindElement(By.Id(UIElements.FindUIElements.findBtn));
            findBtn.Click();

            logger.Info("Find Class Page " + driver.Title);

            driver.FindElement(By.XPath(FindUIElements.DBClubClassLink)).Click();

            //Find the number of rows and columns

            IList<IWebElement> columns = driver.FindElements(By.XPath("//div[@id='collapse0']//tbody[@id='tbBodySchedule']/tr[1]/td"));
            IList<IWebElement> rows = driver.FindElements(By.XPath("//div[@id='collapse0']//tbody[@id='tbBodySchedule']/tr/td[1]"));

            int rowCount = rows.Count;
            int columnCount = columns.Count;

            string firstPart = "//div[@id='collapse0']//tbody[@id='tbBodySchedule']/tr[";
            string secondPart = "]//td[";
            string thirdPart = "]";
            string path = "c:\\Atest.csv";

            for (int i = 1; i <= rowCount; i++) 
            {               
                    for (int j = 1; j <= columnCount; j++)
                { 
                    string finalXPath = firstPart + i + secondPart + j + thirdPart;
                    string tableData = driver.FindElement(By.XPath(finalXPath)).Text;
                    StreamWriter sw = File.AppendText(path);
                    {
                        sw.Write(tableData + ",");
                    }
                                                 
                }              

            }















            //for (int j = 1; j <= rowCount; j++)
            //{
            //    for (int i = 1; i <= columnCount; i++)
            //    {
            //        //Prepared final xpath of specific cell as per values of i and j.
            //        String finalXpath = firstPart + j + secondPart + i + thirdPart;
            //        //Will retrieve value from located cell and print It.
            //        String tableData = driver.FindElement(By.XPath(finalXpath)).Text;
            //        using (StreamWriter sw = File.AppendText(path))
            //        {                                             
            //           sw.WriteLine(tableData);
            //        }
            //    }
            //}







            ////    ICollection<IWebElement> rowElement = driver.FindElements(By.XPath("//div[@id='collapse0']//tbody[@id='tbBodySchedule']/tr/td[1]"));

            ////    ICollection<IWebElement> colElement = driver.FindElements(By.XPath("//div[@id='collapse0']//tbody[@id='tbBodySchedule']/tr[1]/td"));

            ////    //foreach(IWebElement cols in col)
            ////    //{
            ////    //    string celldata = cols.Text;
            ////    //    logger.Info("Column data - " + celldata);
            ////    //}

            ////    foreach (IWebElement rows in row)
            ////    {
            ////        string celldata = rows.Text;
            ////        logger.Info(celldata);
            ////        File.WriteAllText("c:\\test.csv", celldata.ToString());
            ////    }



            ////    logger.Info("Total # of Rows = " + row.Count);
            ////    logger.Info("Total # of Columns = " + col.Count);


            ////}

            //int rcount = driver.FindElements(By.XPath("//div//tbody[@id='tbBodySchedule']/tr")).Count;

            //logger.Info("Total Rows " + rcount);

        }
    }
}
