using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eighteenth_lesson.WebDrivers
{
    internal class Driver
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            if(_driver == null)
            {
                return new ChromeDriver(GetOptions());
            }
            return _driver;
        }

        private static ChromeOptions GetOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;
        }
    }
}
