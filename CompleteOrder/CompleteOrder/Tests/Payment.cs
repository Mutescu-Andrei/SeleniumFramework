using CompleteOrder.Framework;
using CompleteOrder.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace CompleteOrder.Tests
{
    class Payment
    {
        [TestMethod]
        [TestCategory("Accounts")]
        public void CreateAccountAlreadyExistingTest()
        {

            ////open browser
            //IWebDriver browser = new ChromeDriver(); --- it was moved on TestBase.cs
            CreateAccount createAccount = new CreateAccount(browser);

            ////open web application
            //browser.Navigate().GoToUrl("https://www.imdb.com/"); --- it was moved on TestBase.cs

            //locate other sign in button
            IWebElement signInBtn = browser.FindElement(By.CssSelector("[class='ipc-button ipc-button--single-padding ipc-button--default-height ipc-button--core-baseAlt ipc-button--theme-baseAlt ipc-button--on-textPrimary ipc-text-button imdb-header__signin-text']"));

            //click sign in button
            signInBtn.Click();

            //locate create account button
            IWebElement createAccountBtn =
                browser.FindElement(By.CssSelector("[class = 'list-group-item create-account ']"));

            //click create account button
            createAccountBtn.Click();

            //locate username and password fields
            //IWebElement username = browser.FindElement(By.Id("ap_customer_name")); --- it was moved on CreateAccount.cs
            IWebElement email = browser.FindElement(By.Id("ap_email"));
            IWebElement password = browser.FindElement(By.Id("ap_password"));
            IWebElement passwordCheck = browser.FindElement(By.Id("ap_password_check"));

            //fill data
            createAccount.NameInput.SendKeys("abc");
            //email.SendKeys("abc@gmail.com"); --- it was moved on CreateAccount.cs and replaced with method FillInEmail
            createAccount.FillInEmail("abc@gmail.com");
            password.SendKeys("abc");
            passwordCheck.SendKeys("abc");
            browser.FindElement(By.Id("continue")).Click();

            //check validation message and existence of capcha
            string alreadyExistingAccountValidation = browser.FindElement(By.Id("auth-warning-message-box")).Text;
            Assert.IsTrue(alreadyExistingAccountValidation.Contains("You indicated you are a new customer, but an account already exists with the e-mail abc@gmail.com"));
            Assert.IsTrue(browser.FindElement(By.Id("auth-captcha-image-container")).Displayed);

            //browser.Close(); --- it was moved on TestBase.cs
        }
    }
}
