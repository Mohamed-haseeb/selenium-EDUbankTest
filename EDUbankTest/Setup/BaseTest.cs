using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EDUbankTest.Setup
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;
        public string url = "https://edubank.co/";

        [OneTimeSetUp]
        public void Start()
        {
            driver = new ChromeDriver(@"C:\Users\moham\Downloads\chromedriver_win32\chromedriver.exe");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        [OneTimeTearDown]

        public void Stop() 
        {
            driver.Quit();
        }
    }
}
