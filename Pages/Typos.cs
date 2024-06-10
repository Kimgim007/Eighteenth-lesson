using Eighteenth_lesson.WebDrivers;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NHunspell;
namespace Eighteenth_lesson.Pages
{
    internal class Typos
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public Typos() { }
        public Typos(IWebDriver driver)
        {
            _driver = driver;
            _wait = Driver.GetWebDriverWait(_driver, 10);
        }

        public bool Spellchecking()
        {
            IWebElement spellchecking = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='content']/div")));
            string text = spellchecking.Text;

            Hunspell hunspell = new Hunspell("en_US.aff", "en_US.dic");

            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (!hunspell.Spell(word))
                {

                    return false;
                }
            }

            return true;
        }
    }
}
