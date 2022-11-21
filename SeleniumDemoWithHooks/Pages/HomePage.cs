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
        IWebElement Lnk_SignOn => _driver.FindElement(By.LinkText("SIGN-ON"));


        //Page Actions
        public void ClickSingOnLink()
        {
            Lnk_SignOn.Click();
        }

        public bool IsExistSingInLink() => Lnk_SignOn.Displayed;

    }
}

