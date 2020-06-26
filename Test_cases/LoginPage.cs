using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace FrameworkTest
{
    class LoginPage
    {
        public static void Login()
        {
            
            
            PropertiesDr.driver.Url = "http://www.executeautomation.com/demosite/Login.html";
            PropertiesDr.driver.Manage().Window.Maximize();
            //SampleTests.driver = PropertiesDr.driver;
            IWebElement username = PropertiesDr.driver.FindElement(By.Name("UserName"));
            IWebElement password = PropertiesDr.driver.FindElement(By.Name("Password"));
            IWebElement login = PropertiesDr.driver.FindElement(By.XPath(".//input[contains(@type, 'submit')]"));
            username.SendKeys("admin");
            password.SendKeys("admin");
            login.Click();
        }

        
    }
}
