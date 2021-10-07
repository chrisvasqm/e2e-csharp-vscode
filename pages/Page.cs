using OpenQA.Selenium;

namespace e2e_csharp
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