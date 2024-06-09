using Eighteenth_lesson.Pages;
using Eighteenth_lesson.WebDrivers;

namespace Eighteenth_lesson
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");
        }

        [Test]
        public void Test1()
        {
           
     var addRemoveElements = new AddRemoveElements();
            addRemoveElements.AddElement();
            var isElementVisible = addRemoveElements.IsElementVisible();
            Assert.That(isElementVisible, Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();

        }
    }
}