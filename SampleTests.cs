using NUnit.Framework;
using System;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using System.IO;
using System.Reflection;
using System.Threading;

namespace FrameworkTest
{
    [TestFixture]
    public class SampleTests
    {
        //public static IWebDriver driver;
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            LoginPage.Login();

        }
        [SetUp]
        public void Initialize()
        {
            //driver = new ChromeDriver();
           if(PropertiesDr.driver == null)
           {
                LoginPage.Login();
                
           }
           
            
        }

        [Test]
        public void Verification()
        {
            UserForm_TestCases.UserFormValidation();
           
        }
        [Author("saurabh")]
        [Test]
        public void NavigationToolsSW()
        {
            AutomationTools_Selenium.SeleniumWebDriverVerification();
        }

        [Test]
        public void NavigationToolsSRC()
        {
            AutomationTools_Selenium.SeleniumRcVerification();
        }
        [Test]

        public void NavigationToolsSIDE()
        {
            AutomationTools_Selenium.SeleniumIDEVerification();
        }
        

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            if(PropertiesDr.driver !=null)
            {
                PropertiesDr.driver.Quit();
            }
        }

        [TearDown]
        public void CleanUp()
        {
            if (TestContext.CurrentContext.Result.Outcome.ToString().Equals("Failed"))
            {
                PropertiesDr.driver.Quit();
                PropertiesDr.driver = null;
            }
        }

    }
}