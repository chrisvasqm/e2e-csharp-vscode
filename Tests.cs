using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;

namespace e2e_csharp
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
        public void DEVPage_WhenOpeningHomePage_ShouldHaveTheRightURL()
        {
            const string expected = "https://dev.to/";
            string actual = driver.Url;

            actual.Should().Be(expected);
        }

        [Test]
        public void DEVPage_WhenOpeningHomePage_ShouldLoadTheUI() 
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