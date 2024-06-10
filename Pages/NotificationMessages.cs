using Eighteenth_lesson.WebDrivers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
namespace Eighteenth_lesson.Pages
{
    internal class NotificationMessages
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public NotificationMessages() { }
        public NotificationMessages(IWebDriver driver)
        {
            _driver = driver;
            _wait = Driver.GetWebDriverWait(_driver, 10);
        }

        public bool NotificationMessagess()
        {
            IWebElement clickHere = _wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='content']/div/p/a")));
            clickHere.Click();

            IWebElement actionAnswer = _wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='flash']")));
            var message = actionAnswer.Text;
            if (message != "Action successful\r\n×")
            {
                return false;
            }
            return true;
        }
    }
}
