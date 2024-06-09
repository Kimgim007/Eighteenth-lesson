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
    internal class AddRemoveElements
    {
 
        private IWebElement addElement = Driver.GetWebDriverWait(60).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='content']/div/button")));
       // private IWebElement delete = Driver.GetWebDriverWait(10).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='elements']/button")));

        public void AddElement()
        {
            addElement.Click();
        }

        //public void DeleteElement()
        //{
        //    delete.Click();
        //}

        public bool IsElementVisible()
        {
            return addElement.Displayed;
        }
    }
}
