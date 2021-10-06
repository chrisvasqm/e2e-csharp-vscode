using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;

namespace tests
{
    public class Tests
    {
        private IWebDriver driver;
        private DEVPage devPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            devPage = new DEVPage(driver);
            devPage.open();
        }

        [Test]
        public void Test_CanNavigateToDEV()
        {
            const string expected = "https://dev.to/";
            string actual = driver.Url;

            actual.Should().Be(expected);
        }

        [Test]
        public void Test_IsPageLoaded() 
        {
            devPage.isLoaded().Should().BeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}