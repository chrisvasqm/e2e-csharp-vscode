using OpenQA.Selenium;

namespace tests
{
    public class DEVPage : Page
    {
        private IWebElement ButtonLogin => driver.FindElement(By.XPath("(//a[contains(text(), 'Log in')])[1]"));
        public DEVPage(IWebDriver driver) : base(driver)
        {
                 
        }

        public void open()
        {
            driver.Navigate().GoToUrl("https://dev.to/");
        }

        public bool isLoaded() {
            return ButtonLogin.Displayed;
        }
    }
}