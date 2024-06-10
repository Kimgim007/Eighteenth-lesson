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
    internal class Dropdown
    {

        private IWebDriver _driver;
        private WebDriverWait _wait;
        public Dropdown() { }
        public Dropdown(IWebDriver driver)
        {
            _driver = driver;
            _wait = Driver.GetWebDriverWait(_driver, 30);
        }

        public bool AllElementsDropdown()
        {
            IWebElement dropdown = _wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='dropdown']")));
            IList<IWebElement> elements = dropdown.FindElements(By.XPath("./*"));

            if (elements.Count > 0)
            { return true; }
            else
            { return false; }


        }

        public bool SelectElementDropdown(int number)
        {
            IWebElement dropdown = _wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='dropdown']")));
            IList<IWebElement> elements = dropdown.FindElements(By.XPath("./*"));
            elements[number].Click();
         
            string selectedValue = elements[number].GetAttribute("selected");

            return selectedValue != null;           
        }

       
    }
}
