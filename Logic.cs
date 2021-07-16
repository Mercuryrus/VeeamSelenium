using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Linq;

namespace VeeamSelenium
{
    class Logic
    {
        static public void SelectCheckBox(string text, IWebDriver driver)
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[1]/div/div[3]/div/div/button")).Click();
            driver.FindElement(By.XPath($"//*[@class='custom-control custom-checkbox']//*[text()='{text}']")).Click();
        }
        static public void ClickFindElement(string text, IWebDriver driver)
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[1]/div/div[2]/div/div")).Click();
            var vacanciesList = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[2]/div[1]/div/div[2]"));
            vacanciesList.FindElement(By.PartialLinkText(text)).Click();
        }
        static public int GetCountFindElementsCssSelector(IWebDriver driver)
        {
            return driver.FindElements(By.XPath("//*[@class='card card-no-hover card-sm']")).Count;
        }
    }
}
