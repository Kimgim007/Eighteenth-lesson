using Eighteenth_lesson.WebDrivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eighteenth_lesson.Pages
{
    public class AddRemoveElements
    {
        private IWebDriver _driver;
        private  WebDriverWait _wait;
        public AddRemoveElements() { }
        public AddRemoveElements(IWebDriver driver)
        {
            _driver = driver;
            _wait = Driver.GetWebDriverWait(_driver, 30);
        }

        public void AddElement()
        {
            IWebElement addElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='content']/div/button")));
            addElement.Click();
            addElement.Click();
        }

        public void DeleteElement()
        {
            IWebElement delete = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='elements']/button")));
            delete.Click();
            
        }

        public bool IsElementVisible()
        {
            IWebElement addElement = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='elements']/button")));
            return addElement.Displayed;
        }
    }
}
