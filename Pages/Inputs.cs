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
    internal class Inputs
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public Inputs() { }
        public Inputs(IWebDriver driver)
        {
            _driver = driver;
            _wait = Driver.GetWebDriverWait(_driver, 30);
        }

        public bool InputField(string field)
        {
            IWebElement inputField = _wait.Until(ExpectedConditions.ElementExists(By.XPath($"{field}")));

            var answer = true;

            inputField.Clear();

            inputField.SendKeys("12345");

            inputField.SendKeys(Keys.ArrowUp);
            inputField.SendKeys(Keys.ArrowDown);

            
            if(inputField.GetAttribute("value") != "12345")
            {
                answer = false;   
            }

            inputField.Clear();

            inputField.SendKeys("asd");

            if(inputField.GetAttribute("value").Length == 0)
            {
                answer = false;
            }

            return answer;
        }
    }
}
