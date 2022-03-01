using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;

namespace SpecflowNetCore.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


        public IWebElement TxtUserName => _webDriver.FindElement(By.Name("UserName"));
        public IWebElement TxtPassword => _webDriver.FindElement(By.Name("Password"));
        public IWebElement BtnLogin => _webDriver.FindElement(By.CssSelector("input[type='submit']"));
        public IWebElement LnkEmloyeeDetails => _webDriver.FindElement(By.LinkText("Employee Details"));

        public void ClickLoginButton()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            IWebElement btnLoginExisted = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("input[type='submit']")));

            btnLoginExisted.Click();
        }

        public void Login(string userName, string password)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(password);
        }

        public bool IsEmployeeDetailsExist() => LnkEmloyeeDetails.Displayed;


    }
}
