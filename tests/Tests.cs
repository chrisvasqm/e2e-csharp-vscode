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

            devPage = new DEVPage(driver);
        }

        [Test]
        public void Test_CanNavigateToDEV()
        {
            devPage.open();

            const string expected = "https://dev.to/";
            string actual = driver.Url;

            actual.Should()
                .Be(expected);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver = null;
        }
    }
}