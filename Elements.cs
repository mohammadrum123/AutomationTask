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

        [FindsBy(How = How.Id, Using = "inner-form-container")]
        public IWebElement github;

        [FindsBy(How = How.Id, Using = "register-link-container")]
        public IWebElement signup;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"inner - form - container\"]/form/div/div[2]/a")]
        public IWebElement forgot;

        [FindsBy(How = How.CssSelector, Using = "body > div > div.sidebar-inner > a")] 
        public IWebElement learnmorebtn;


    }


}
