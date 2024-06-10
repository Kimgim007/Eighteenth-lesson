using Eighteenth_lesson.WebDrivers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
namespace Eighteenth_lesson.Pages
{
    internal class Hovers
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public Hovers() { }
        public Hovers(IWebDriver driver)
        {
            _driver = driver;
            _wait = Driver.GetWebDriverWait(_driver, 10);
        }

        public bool Profile(Actions actions)
        {

            IWebElement firstProfile = _wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='content']/div/div[1]")));
            IWebElement secondProfile = _wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='content']/div/div[2]")));
            IWebElement thirdprofile = _wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='content']/div/div[3]")));

            IList<IWebElement> profiles = new List<IWebElement>();

            profiles.Add(firstProfile);
            profiles.Add(secondProfile);
            profiles.Add(thirdprofile);

            int count = 1;

            foreach (IWebElement profile in profiles)
            {
                actions.MoveToElement(profile).Perform();

                string profileName = _wait.Until(ExpectedConditions.ElementExists(By.XPath($"//*[@id='content']/div/div[{count}]/div/h5"))).Text;
                if (profileName.Length == null)
                {
                    return false;
                }

                IWebElement viewProfile = _wait.Until(ExpectedConditions.ElementExists(By.XPath($"//*[@id='content']/div/div[{count}]/div/a")));
                actions.MoveToElement(viewProfile).Click().Perform();

                if (_driver.FindElements(By.XPath("/html/body/h1")).Count > 0 == false)
                {
                    return false;
                }
                _driver.Navigate().Back();
                count++;
            }

            return true;
        }
    }
}
