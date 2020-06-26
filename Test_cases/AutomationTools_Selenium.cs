using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace FrameworkTest
{
    class AutomationTools_Selenium
    {
        public static void SeleniumWebDriverVerification()
        {
            Selenium.NavigationElements();
            Selenium.AutomationSubmenu("Selenium");
            Selenium.SeleniumSubmenuNavigation("Selenium WebDriver");
            Assert.IsTrue(Selenium.VerifyResults("Selenium WebDriver"),"Header is invalid");
            
        }

        public static void SeleniumRcVerification()
        {
            Selenium.NavigationElements();
            Selenium.AutomationSubmenu("Selenium");
            Selenium.SeleniumSubmenuNavigation("Selenium RC");
            Assert.IsTrue(Selenium.VerifyResults("Selenium RC"), "Header is invalid");

        }

        public static void SeleniumIDEVerification()
        {
            Selenium.NavigationElements();
            Selenium.AutomationSubmenu("Selenium");
            Selenium.SeleniumSubmenuNavigation("Selenium IDE");
            Assert.IsTrue(Selenium.VerifyResults("Selenium IDE"), "Header is invalid");

        }


    }
}
