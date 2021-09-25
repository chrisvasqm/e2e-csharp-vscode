using OpenQA.Selenium;

namespace tests
{
    public class Page
    {
        protected readonly IWebDriver driver;

        public Page(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}