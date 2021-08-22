using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using ChangeProduct.Framework;
using ChangeProduct.Pages;
namespace ChangeProduct
{
    [TestClass]
    public class TestChange:Base
    {
        [TestMethod]
        [TestCategory("SecondTest")]
        public void TestMethod1()
        {

            Change Payments = new Change(browser);

            IWebElement alegere = browser.FindElement(By.Id("mobileCat-CarteStraina"));
            alegere.Click();


            IWebElement produs = browser.FindElement(By.CssSelector("#family-page > div > div.row > div.col-md-9.col-xs-12 > div.product-list.row > div:nth-child(1) > div > div.product-image-container"));


            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            produs.Click();


            IWebElement dismiss = browser.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override-1827372716 > div > a"));
            dismiss.Click();


            IWebElement addCart = browser.FindElement(By.Id("productDetailForm_c354e0e5-ebf7-46bd-827d-9eefafdb3935"));
            addCart.Click();

            IWebElement Cart = browser.FindElement(By.XPath("/html/body/header/div[1]/nav/div/div[4]/div/ul/li[3]/div/a/i"));
            Cart.Click();

            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement CartView = browser.FindElement(By.XPath("/html/body/header/div[1]/nav/div/div[4]/div/ul/li[3]/div/div[2]/div[3]/a"));
            CartView.Click();

            Assert.IsTrue(browser.FindElement(By.ClassName("plus")).Enabled);
            Assert.IsTrue(browser.FindElement(By.XPath("/html/body/div[3]/div/div[7]/div/div[2]/form/div/div[2]/div[4]/button")).Enabled);


            IWebElement Plus = browser.FindElement(By.ClassName("plus"));
            Plus.Click();

            IWebElement Delete = browser.FindElement(By.XPath("/html/body/div[3]/div/div[7]/div/div[2]/form/div/div[1]/div/div/a/i"));
            Delete.Click();

            Assert.IsTrue(browser.FindElement(By.XPath("/html/body/div[3]/div/div[6]/a")).Enabled);

            System.Threading.Thread.Sleep(6000);



        }
    }
}
