using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteOrder.Framework
{   [TestClass]
    public class TestBase
    {

        public ChromeDriver browser;
        public string baseURL;

        [TestInitialize]
        public virtual void Setup()
        {
            //create instance of browser
            browser = new ChromeDriver();

            //set resolution
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("window-size=1280,960");

            //open application
            baseURL = "http://www.imdb.com/";
            browser.Navigate().GoToUrl(baseURL + "/");

            // Implicit wait
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [TestCleanup]
        public virtual void Cleanup()
        {
            //close browser
            browser.Close();
        }


    }
}
