using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace tests
{
    public class Tests
    {
        private IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver = null;
        }
    }
}