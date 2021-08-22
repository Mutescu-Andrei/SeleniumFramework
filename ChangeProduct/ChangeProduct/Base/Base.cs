using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace ChangeProduct.Framework
{
    [TestClass]

    public class Base
    {
        public ChromeDriver browser;
        public string baseURL;

        [TestInitialize]

        public virtual void Setup()
        {
            browser = new ChromeDriver();

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--window-size=1920,1080");
            browser.Manage().Window.Maximize();


            baseURL = "https://www.elefant.ro/";

            browser.Navigate().GoToUrl(baseURL + "/");

            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TestCleanup]
        public virtual void Cleanup()
        {

            browser.Close();
        }

    }
}
