using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoAutomationTesting
{
    class Index
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver(@"D:\\Testing Purpose");
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://demo.automationtesting.in/Index.html";

            driver.FindElement(By.XPath("//input[@type='text'][@id='email']")).SendKeys("test@gmail.com");
            driver.FindElement(By.XPath("//img[@id='enterimg']")).Click();
            driver.Navigate().Back();

            driver.FindElement(By.XPath("//button[text()='Sign In']")).Click();
            driver.Navigate().Back();

            driver.FindElement(By.XPath("//button[text()='Skip Sign In']")).Click();
            driver.Navigate().Back();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
