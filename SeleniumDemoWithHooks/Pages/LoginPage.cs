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
        IWebElement Txtbx_UserName => WebDriver.FindElement(By.Id("email"));
        IWebElement Txtbx_UserPwd => WebDriver.FindElement(By.Id("passwd"));
        IWebElement Btn_Login => WebDriver.FindElement(By.Id("SubmitLogin"));
        IWebElement Lnk_Logout => WebDriver.FindElement(By.LinkText("Sign out"));


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
    }
}
