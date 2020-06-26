using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections;
using FrameworkTest.Locators;

namespace FrameworkTest
{
    class UserForm_TestCases
    {
        public static void UserFormValidation()
        {
            UserForm.userForm();

            //title
            UserForm.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            //Initial
            UserForm.EnterText("Initial", "Saurabh", PropertyType.Name);
            //Click
            UserForm.Click("Save", PropertyType.Name);

        }

    }
}
