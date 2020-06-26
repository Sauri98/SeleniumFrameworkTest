using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace FrameworkTest
{
    public class Selenium
    {
        private static By automationTools = By.Id("Automation Tools");
        private static By selenium = By.Id("Selenium");
        IWebElement seleniumwebdriver = PropertiesDr.driver.FindElement(By.Id("Selenium WebDriver"));
        IWebElement seleniumRc = PropertiesDr.driver.FindElement(By.Id("Selenium RC"));
        IWebElement SeleniumIDE = PropertiesDr.driver.FindElement(By.Id("Selenium IDE"));

        public static void NavigationElements()
        {
            //PropertiesDr.driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(5));
            Thread.Sleep(3000);

            IWebElement automationtools = PropertiesDr.driver.FindElement(automationTools);
            automationtools.Click();
            Thread.Sleep(3000);
            
        }

        public static void AutomationSubmenu(string submenu)
        {
            IWebElement seleniumMenu = PropertiesDr.driver.FindElement(By.Id(submenu));
            seleniumMenu.Click();
            Thread.Sleep(3000);

        }

        public static void SeleniumSubmenuNavigation(string submenu)
        {
            
            IWebElement submenuNav = PropertiesDr.driver.FindElement(By.Id(submenu));
            submenuNav.Click();
        }

    

        public static bool VerifyResults(string header)
        {
            IWebElement result = PropertiesDr.driver.FindElement(By.TagName("h2"));
            if(result.Text.Equals(header))
            {
                return true;
            }

            return false;

        }
    }
}
 