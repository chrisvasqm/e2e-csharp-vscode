using OpenQA.Selenium;

namespace tests
{
    public class DEVPage : Page
    {
              
        public DEVPage(IWebDriver driver) : base(driver)
        {
            
        }

        public void open()
        {
            base.driver.Navigate().GoToUrl("https://dev.to/");
        }
    }
}