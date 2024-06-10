using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eighteenth_lesson.WebDrivers
{
    internal class Driver
    {
        private static IWebDriver? _driver;

        private static WebDriverWait? _wait;

        public static WebDriverWait GetWebDriverWait(IWebDriver driver,double wait)
        {
            if (_wait == null)
            {
                return new(driver, TimeSpan.FromSeconds(wait));
            }
            return _wait;
        }

        public static IWebDriver GetDriver()
        {
            if (_driver == null)
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

        public static void QuitDriver(IWebDriver _driver)
        {
            _driver?.Quit();
            _driver = null;
            _wait = null;
        }

        public static void GoToUrlThat(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
