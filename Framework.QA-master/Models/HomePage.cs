using OpenQA.Selenium;
using Framework.QA.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;

namespace Framework.QA.Models
{
    [Binding]
    public class HomePage
    {
        IWebDriver _driver;
        public HomePage()
        {
            _driver = Hooks.driver;
        }

        IWebElement ReadyToHelpClosePopUpButton
        {
            get
            {
                return _driver.FindElement(By.Id("lightbox-close"));
            }
        }

        IWebElement SignUpNowButton
        {
            get
            {
                return _driver.FindElement(By.XPath("//*[@href='https://mannisland.co.uk/newsletter-sign-up/']"));
            }
        }

        public void NavigateToMannIsland(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickSignUpNowButton()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(SignUpNowButton);
            actions.Perform();
            WebDriverExtensions.WaitUntilElementIsClickable(_driver, SignUpNowButton);
            SignUpNowButton.Click();
        }

        public void ClickReadyToHelpClosePopUpButton()
        {
            WebDriverExtensions.WaitUntilElementIsClickable(_driver, ReadyToHelpClosePopUpButton);
            ReadyToHelpClosePopUpButton.Click();
        }
    }
}
