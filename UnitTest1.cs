using NUnit.Framework;
using OpenQA.Selenium;

namespace VeeamSelenium
{
    public class Tests
    {
        private readonly string lang = TestContext.Parameters.Get("language");
        private readonly string vacancy = TestContext.Parameters.Get("vacancy");
        private readonly int count = int.Parse(TestContext.Parameters.Get("expectedResult"));
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
             
            Logic.SelectCheckBox(lang, driver);
            Logic.ClickFindElement(vacancy, driver); 

            TestContext.Out.WriteLine($"Количество вакансий: {Logic.GetCountFindElementsCssSelector(driver)}");
            Assert.AreEqual(count, Logic.GetCountFindElementsCssSelector(driver));
            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();

        }
    }
}