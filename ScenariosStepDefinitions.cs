using Applitools.Drivers;
using Applitools.POM;
using OpenQA.Selenium.Chrome;

namespace Applitools.StepDefinitions
{
    [Binding]
    public class ScenariosStepDefinitions : webdriver
    {
        [Given(@"Navigate to URL")]
        public void GivenNavigateToUrl()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://applitools.com/");
        }

        [When(@"Click on Login button")]
        public void WhenClickOnAboutLink()
        {
            Elements a = new Elements(driver);
            a.loginbtn.Click();
        }

        [Then(@"Login Page is displayed")]
        public void ThenAboutLinkPageShouldOpen()
        {
            Thread.Sleep(3000);
            closedriver();
        }

        [Given(@"Navigate to Login Page")]
        public void GivenNavigateToLoginPage()
        {
            setup();
        }

        [When(@"Click on Sign In button")]
        public void WhenClickOnSignInButton()
        {
            Elements a = new Elements(driver);
            a.signinbtn.Click();
        }

        [Then(@"Error messaged displayed saying Email and Password required")]
        public void ThenErrorMessagedDisplayedSayingEmailAndPasswordRequired()
        {
            Thread.Sleep(3000);
            closedriver();
        }

        [When(@"Enter Valid Email and Valid Password and click on Sign in button")]
        public void WhenEnterValidEmailAndValidPasswordAndClickOnSignInButton()
        {
            Elements a = new Elements(driver);
            a.email.SendKeys("mdrumaiz789@gmail.com");
            a.password.SendKeys("Rum@#$123789");
            a.signinbtn.Click();
        }

        [Then(@"Successfully logged in")]
        public void ThenSuccessfullyLoggedIn()
        {
            Thread.Sleep(10000);
            closedriver();
        }

        [When(@"Enter Invalid Email and Valid Password and click on Sign in button")]
        public void WhenEnterInvalidEmailAndValidPasswordAndClickOnSignInButton()
        {
            Elements a = new Elements(driver);
            a.email.SendKeys("mdrumaiz");
            a.password.SendKeys("Rum@#$123789");
            a.signinbtn.Click();
        }

        [Then(@"Error message displayed saying to enter valid Email")]
        public void ThenErrorMessageDisplayedSayingToEnterValidEmail()
        {
            Thread.Sleep(3000);
            closedriver();
        }

        [When(@"Enter Valid Email and Invalid Password and click on Sign in button")]
        public void WhenEnterValidEmailAndInvalidPasswordAndClickOnSignInButton()
        {
            Elements a = new Elements(driver);
            a.email.SendKeys("mdrumaiz789@gmail.com");
            a.password.SendKeys("Ru");
            a.signinbtn.Click();
        }

        [Then(@"Error message displayed saying Incorrect Password")]
        public void ThenErrorMessageDisplayedSayingIncorrectPassword()
        {
            Thread.Sleep(3000);
            closedriver();
        }

        [When(@"Click on Google Sign In button")]
        public void WhenClickOnGoogleSignInButton()
        {
            Elements a = new Elements(driver);
            a.google.Click();
        }

        [Then(@"Google Account Window is displayed")]
        public void ThenGoogleAccountWindowIsDisplayed()
        {
            Thread.Sleep(3000);
            closedriver();
        }
    }
}
