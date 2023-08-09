using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUbankTest.Setup;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace EDUbankTest.Pageclass
{

    public class LoginPage 
    {
        private IWebDriver driver;

        public IWebElement loginbtn => driver.FindElement(By.XPath("//span[contains (text(),'Login')]"));
        public IWebElement Signupbtn => driver.FindElement(By.XPath("//span[contains (text(),'Signup')]"));

        public IWebElement Email => driver.FindElement(By.XPath("//input[@aria-label=\"Email address\"]"));
        public IWebElement Password => driver.FindElement(By.XPath("//input[@aria-label=\"Password\"]"));
        public IWebElement Fname => driver.FindElement(By.XPath("//input[@placeholder=\"Jane\"]"));
        public IWebElement Lname => driver.FindElement(By.XPath("/input[@placeholder=\"Ms. Smith\"]"));
        public IWebElement School => driver.FindElement(By.XPath("input[@placeholder=\"PPS\"]"));



        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }



        public void clickLoginbtn()
        {
            try
            { 
            Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(loginbtn)).Click();
            Thread.Sleep(3000);
            // loginbtn.Click();
        }
            catch (Exception ex)
            {
                Console.WriteLine("unbale to click element loginbtn"+ex.Message);
            }


        }

    }
}