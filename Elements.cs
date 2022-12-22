using OpenQA.Selenium;
using Applitools.Drivers;
using SeleniumExtras.PageObjects;
using System.ComponentModel;

namespace Applitools.POM
{
    public class Elements : webdriver
    {  
        public Elements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "login-item")]
        public IWebElement loginbtn;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"inner-form-container\"]/form/div/div[4]/button")]
        public IWebElement signinbtn;

        [FindsBy(How = How.Id, Using = "google-signin")]
        public IWebElement google;

    }


}
