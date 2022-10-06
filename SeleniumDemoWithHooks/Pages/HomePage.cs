using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDemoWithHooks.Pages
{
    class HomePage
    {
        public IWebDriver _driver;
        public HomePage(IWebDriver dr)
        {
            _driver = dr;
        }


        //Page Elements
        IWebElement Lnk_SignIn => _driver.FindElement(By.LinkText("Sign in"));


        //Page Actions
        public void ClickSingInLink()
        {
            Lnk_SignIn.Click();
        }

        public bool IsExistSingInLink() => Lnk_SignIn.Displayed;

    }
}

