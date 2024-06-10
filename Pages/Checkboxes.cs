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
    internal class Checkboxes
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public Checkboxes() { }
        public Checkboxes(IWebDriver driver)
        {
            _driver = driver;
            _wait = Driver.GetWebDriverWait(_driver, 30);
        }

       

        public bool CheckedCheckOrUnCheck(string checkbox)
        {
            IWebElement checboxOne = _wait.Until(ExpectedConditions.ElementExists(By.XPath($"{checkbox}")));
            var answer = checboxOne.Selected;
            return answer;


        }

        public void ClickOnCheckBox(string checkbox)
        {
            IWebElement checbox = _wait.Until(ExpectedConditions.ElementExists(By.XPath($"{checkbox}")));
            checbox.Click();
        }
    }
}
