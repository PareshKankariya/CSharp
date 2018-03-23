using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace com.lafitness.TestCases
{
    class MemberToolsGymSessions
    {
        public IWebDriver driver;
        public IWebElement element;
        public MemberToolsGymSessions(IWebDriver browser)
        {
            this.driver = browser;                
        }

        public void ViewMyCalendar()
        {
            IWebElement viewMyCalendarElement = driver.FindElement(By.XPath(UIElements.FindUIElements.ViewMyCalendar));
            viewMyCalendarElement.Click();
        }

        public void AddWorkout()
        {

        }

    }
}
