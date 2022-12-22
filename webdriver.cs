using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Applitools.Drivers
{
    public class webdriver
    {
        public IWebDriver driver;   

        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://auth.applitools.com/users/login");
        }
        public void closedriver()
        {
            driver.Quit();
        }
    }
}
