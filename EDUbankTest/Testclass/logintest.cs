using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUbankTest.Setup;
using EDUbankTest.Pageclass;
using OpenQA.Selenium.Chrome;
using EDUbankTest.Pageclass;


namespace EDUbankTest.Testclass
{
    internal class logintest :BaseTest
    {
        [Test]
        public void loginbtntest()
        {
            LoginPage page = new LoginPage(driver);
            page.clickLoginbtn();
        }
    }
}
