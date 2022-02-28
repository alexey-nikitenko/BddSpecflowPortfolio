using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowNetCore.Pages
{
    public class HomePage
    {
        private const string HomePageUrl = "http://eaapp.somee.com/";
        private readonly IWebDriver _webDriver;

        public HomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement LnkLogin => _webDriver.FindElement(By.LinkText("Login"));

        public void ClickLogin() => LnkLogin.Click();

        public void GoToHomePage() => _webDriver.Navigate().GoToUrl(HomePageUrl);
    }
}
