using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insurance.Hooks;
using OpenQA.Selenium;
using System.Threading;

namespace Insurance.Pages
{
    public class RegistrationPage
    {
       private Context context;

        public RegistrationPage(Context _context)
        {
            context = _context;
        }

        private By signIn = By.CssSelector("a[href=\"/account/authentication?ref=1\"]");
        private By signTab = By.Id("nav-signin-tab");
        private By emailAddress = By.Id("user_email");
        private By passWord = By.Id("user_password");
        private By signInButton = By.Id("btn_signin");
        private By login = By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div/div/div[2]/h2/span");

        public void ClickSignInLink()
        {
            context.driver.FindElement(signIn).Click();
            Thread.Sleep(1000);
        }

        public void ClickSignTab()
        {
            context.driver.FindElement(signTab).Click();
        }

        public void EnterEmailAddress(string emailData)
        {
            IWebElement emailTxtAddress = context.driver.FindElement(emailAddress);
            emailTxtAddress.Clear();
            emailTxtAddress.SendKeys(emailData);
        }

        public void EnterPassWord(string passwordData)
        {
            IWebElement passWordTxt = context.driver.FindElement(passWord);
            passWordTxt.Clear();
            passWordTxt.SendKeys(passwordData);
        }

        public void ClickSignInButton()
        {
            context.driver.FindElement(signInButton).Click();
            Thread.Sleep(3000);
        }

        public string VerifyLoginName()
        {
            return context.driver.FindElement(login).Text.Trim();
        }
    }
}
