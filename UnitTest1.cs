using NUnit.Framework;
using OpenQA.Selenium;

namespace VeeamSelenium
{
    public class Tests
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://careers.veeam.ru/vacancies");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void CountVacancies()
        {
            Logic.SelectCheckBox("Английский", driver);
            Logic.ClickFindElement("Разработка продуктов", driver);

            Assert.AreEqual(6, Logic.GetCountFindElementsCssSelector(driver));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();

        }
    }
}