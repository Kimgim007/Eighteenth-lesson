using Eighteenth_lesson.WebDrivers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using SeleniumExtras.WaitHelpers;
namespace Eighteenth_lesson.Pages
{
    internal class SortableDataTables
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public SortableDataTables() { }
        public SortableDataTables(IWebDriver driver)
        {
            _driver = driver;
            _wait = Driver.GetWebDriverWait(_driver, 10);
        }

        public bool GetTableInfo(string path)
        {

            IWebElement cellInTable = _wait.Until(ExpectedConditions.ElementExists(By.XPath($"{path}"))) ;
            var str = cellInTable.Text ;
            if (str == null)
            {
                return false;
            }
            return true;
        }
    }
}
