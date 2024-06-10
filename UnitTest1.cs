using Eighteenth_lesson.Pages;
using Eighteenth_lesson.WebDrivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Eighteenth_lesson
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = Driver.GetDriver();

        }

        [Test]
        public void AddRemoveElementsTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
            var addRemoveElements = new AddRemoveElements(driver);
            addRemoveElements.AddElement();
            addRemoveElements.DeleteElement();
            var isElementVisible = addRemoveElements.IsElementVisible();
            Assert.That(isElementVisible, Is.True);
        }

        [Test]
        public void CheckedCheckOrUnCheckTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

            var checkbox = new Checkboxes(driver);

            // Первый checkBox
            var checkboxOneUncheck = checkbox.CheckedCheckOrUnCheck("//*[@id='checkboxes']/input[1]");
            if (checkboxOneUncheck != false)
            {
                Assert.Fail();
            }

            checkbox.ClickOnCheckBox("//*[@id='checkboxes']/input[1]");

            var checkboxOneCheck = checkbox.CheckedCheckOrUnCheck("//*[@id='checkboxes']/input[1]");
            if (checkboxOneCheck == false)
            {
                Assert.Fail();
            }

            //Второй checkBox

            var checkboxTwoUncheck = checkbox.CheckedCheckOrUnCheck("//*[@id='checkboxes']/input[2]");
            if (checkboxTwoUncheck == false)
            {
                Assert.Fail();
            }

            checkbox.ClickOnCheckBox("//*[@id='checkboxes']/input[2]");

            var checkboxTwoCheck = checkbox.CheckedCheckOrUnCheck("//*[@id='checkboxes']/input[2]");
            if (checkboxTwoCheck != false)
            {
                Assert.Fail();
            }
            Assert.That(true, Is.True);

        }

        [Test]
        public void DropdownTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
            var dropdown = new Dropdown(driver);
            if (dropdown.AllElementsDropdown() == null)
            {
                Assert.Fail();
            }

            Assert.That(dropdown.SelectElementDropdown(1), Is.True);
            Assert.That(dropdown.SelectElementDropdown(2), Is.True);
        }

        [Test]
        public void InputsTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/inputs");
            var inpuntField = new Inputs(driver);
            var answer = inpuntField.InputField("//*[@id='content']/div/div/div/input");
            Assert.That(answer, Is.False);
        }

        [Test]
        public void SortableDataTables()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            var table = new SortableDataTables(driver);

            var answer = true;

            answer = table.GetTableInfo("//*[@id='table2']/tbody/tr[1]/td[1]");
            answer = table.GetTableInfo("//*[@id='table2']/tbody/tr[2]/td[1]");
            answer = table.GetTableInfo("//*[@id='table2']/tbody/tr[3]/td[1]");

            Assert.That(answer, Is.True);
        }

        [Test]
        public void TyposTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");
            var typos = new Typos(driver);
            Assert.That(typos.Spellchecking(), Is.True);
        }

        [Test]
        public void HoversTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
            Actions actions = new Actions(driver);
            var hovers = new Hovers(driver);
            var answer = hovers.Profile(actions);

            Assert.That(answer, Is.True);
        }

        [Test]
        public void NotificationMessagesTest()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/notification_message_rendered");
            var notificationMessages = new NotificationMessages(driver);
            Assert.That(notificationMessages.NotificationMessagess(), Is.True);
        
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver(driver);
        }
    }
}