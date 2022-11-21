using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDemoWithHooks.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver;
        public LoginPage(IWebDriver dr)
        {
            WebDriver = dr;
        }

        //Page Elements
        IWebElement Txtbx_UserName => WebDriver.FindElement(By.XPath("//input[@name='userName']"));
        IWebElement Txtbx_UserPwd => WebDriver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement Btn_Login => WebDriver.FindElement(By.XPath("//input[@type='submit']"));
        IWebElement Lnk_Logout => WebDriver.FindElement(By.LinkText("SIGN-OFF"));

        IWebElement pop_up_CloseBtn => WebDriver.FindElement(By.XPath("//div[contains(@id,'dismiss-button')]"));


        //Page Actions
        public void EnterUserName(string uName)
        {
            Txtbx_UserName.SendKeys(uName);
        }
        public void EnterUserPassword(string uPass)
        {
            Txtbx_UserPwd.SendKeys(uPass);
        }

        public void ClickLoginBtn() => Btn_Login.Click();

        public bool IsExistLogout() => Lnk_Logout.Displayed;

        public void ClickLogOutLink() => Lnk_Logout.Click();

        public void ClickOnPopup()
        {
            if (pop_up_CloseBtn.Displayed == true)
            {
                pop_up_CloseBtn.Click();
            }

        }


    }
}
