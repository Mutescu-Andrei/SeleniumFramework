using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using CompletarePartner.Framework;
using CompletarePartner.Pages;
namespace CompletarePartner
{
    [TestClass]
    public class PartnerTest : TestBase
    {
        [TestMethod]
        [TestCategory("ThirdTest")]
        public void TestMethod1()
        {

            Partner Redirects = new Partner(browser);

            IWebElement dismiss = browser.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-info.cc-theme-block.cc-bottom.cc-color-override-1827372716 > div > a"));
            dismiss.Click();

            // IWebElement alegere = browser.FindElement(By.Id(""));
            //alegere.Click();


            IWebElement Market = browser.FindElement(By.CssSelector("#Pagelet_19MKKgAHpJUAAAFmiq0Nuosl > ul > li:nth-child(7) > a"));
            Market.Click();


            IWebElement Partner = browser.FindElement(By.CssSelector("#lp-pom-button-119 > span > strong"));
            Partner.Click();


            //IWebElement Cart = browser.FindElement(By.XPath(""));
            // Cart.Click();



            // Assert.IsTrue(browser.FindElement(By.ClassName("plus")).Enabled);
            // Assert.IsTrue(browser.FindElement(By.XPath("/html/body/div[3]/div/div[7]/div/div[2]/form/div/div[2]/div[4]/button")).Enabled);


            //  IWebElement Plus = browser.FindElement(By.ClassName("plus"));
            //  Plus.Click();


            // Assert.IsTrue(browser.FindElement(By.XPath("/html/body/div[3]/div/div[6]/a")).Enabled);












            //  IWebElement detailFrame = browser.FindElement(By.XPath("//iframe[@CssSelector='#lp-code-110 > iframe']"));
            // browser.SwitchTo().Frame(detailFrame);
            browser.SwitchTo().Frame(0);



            // browser.SwitchTo().Frame("iframe1");
            IWebElement email = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(1) > div > div:nth-child(1) > div.quantumWizTextinputPaperinputEl.freebirdFormviewerComponentsQuestionTextShort.freebirdFormviewerComponentsQuestionTextTextInput.freebirdThemedInput.modeLight > div.quantumWizTextinputPaperinputMainContent.exportContent > div > div.quantumWizTextinputPaperinputInputArea > input"));
            //IWebElement LastName = browser.FindElement(By.Id("shipping_LastName"));
            //IWebElement FirstName = browser.FindElement(By.Id("shipping_FirstName"));
            //IWebElement Phone = browser.FindElement(By.Id("shipping_PhoneHome"));
            //IWebElement Adress = browser.FindElement(By.Id("shipping_Address1"));
            IWebElement company = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(2) > div > div > div.freebirdFormviewerComponentsQuestionTextRoot > div > div.quantumWizTextinputPaperinputMainContent.exportContent > div > div.quantumWizTextinputPaperinputInputArea > input"));
            IWebElement firstname = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(3) > div > div > div.freebirdFormviewerComponentsQuestionTextRoot > div > div.quantumWizTextinputPaperinputMainContent.exportContent > div > div.quantumWizTextinputPaperinputInputArea > input"));
            IWebElement lastname = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(4) > div > div > div.freebirdFormviewerComponentsQuestionTextRoot > div > div.quantumWizTextinputPaperinputMainContent.exportContent > div > div.quantumWizTextinputPaperinputInputArea > input"));
            IWebElement function = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(5) > div > div > div.freebirdFormviewerComponentsQuestionTextRoot > div > div.quantumWizTextinputPaperinputMainContent.exportContent > div > div.quantumWizTextinputPaperinputInputArea > input"));
            IWebElement phone = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(6) > div > div > div.freebirdFormviewerComponentsQuestionTextRoot > div > div.quantumWizTextinputPaperinputMainContent.exportContent > div > div.quantumWizTextinputPaperinputInputArea > input"));
            // IWebElement a1 = browser.FindElement(By.CssSelector(""));
            // IWebElement a2 = browser.FindElement(By.CssSelector(""));
            company.SendKeys("Testetet");
            email.SendKeys("test@yahoo.com");
            lastname.SendKeys("Tester");
            firstname.SendKeys("Testing");
            function.SendKeys("Testinging");
            phone.SendKeys("0777777777");


            System.Threading.Thread.Sleep(400);
            IWebElement Forward1 = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewNavigationNavControls > div.freebirdFormviewerViewNavigationButtonsAndProgress > div.freebirdFormviewerViewNavigationLeftButtons > div > span"));
            Forward1.Click();

            IWebElement Button = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(3) > div > div > div.freebirdFormviewerComponentsQuestionGridRoot > div > div.freebirdFormviewerComponentsQuestionGridScrollContainer > div > div.appsMaterialWizToggleRadiogroupGroupContainer.exportGroupContainer.freebirdFormviewerComponentsQuestionGridRowGroup > span > div:nth-child(2) > div > div > div.appsMaterialWizToggleRadiogroupRadioButtonContainer"));
            Button.Click();
            IWebElement Button2 = browser.FindElement(By.CssSelector("#i14 > div.quantumWizTogglePapercheckboxInnerBox.exportInnerBox"));
            Button2.Click();

            System.Threading.Thread.Sleep(400);
            //IWebElement Forward2 = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewNavigationNavControls > div.freebirdFormviewerViewNavigationButtonsAndProgress > div.freebirdFormviewerViewNavigationLeftButtons > div.appsMaterialWizButtonEl.appsMaterialWizButtonPaperbuttonEl.appsMaterialWizButtonPaperbuttonProtected.freebirdFormviewerViewNavigationNoSubmitButton.freebirdThemedProtectedButtonM2.isUndragged > span"));
            //Forward2.Click();
            browser.FindElement(By.XPath("//button[@class ='appsMaterialWizToggleRadiogroupElContainer exportContainerEl  freebirdThemedRadio freebirdThemedRadioDarkerDisabled']/a[2]")).Click();

            IWebElement Website = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(3) > div > div > div.freebirdFormviewerComponentsQuestionTextRoot > div > div.quantumWizTextinputPaperinputMainContent.exportContent > div > div.quantumWizTextinputPaperinputInputArea > input"));
            Website.SendKeys("Tester.com");

            IWebElement Button3 = browser.FindElement(By.CssSelector("#i16 > div.appsMaterialWizToggleRadiogroupRadioButtonContainer > div"));
            Button3.Click();
            IWebElement Button4 = browser.FindElement(By.CssSelector("#i39 > div.quantumWizTogglePapercheckboxInnerBox.exportInnerBox"));
            Button4.Click();

            IWebElement Comer = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(3) > div > div > div.freebirdFormviewerComponentsQuestionTextRoot > div > div.quantumWizTextinputPaperinputMainContent.exportContent > div > div.quantumWizTextinputPaperinputInputArea > input"));
            Comer.SendKeys("Teste");

            IWebElement Button5radio = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewItemList > div:nth-child(3) > div > div > div.freebirdFormviewerComponentsQuestionGridRoot > div > div.freebirdFormviewerComponentsQuestionGridScrollContainer > div > div.appsMaterialWizToggleRadiogroupGroupContainer.exportGroupContainer.freebirdFormviewerComponentsQuestionGridRowGroup > span > div:nth-child(4) > div > div > div.appsMaterialWizToggleRadiogroupRadioButtonContainer > div"));
            Button5radio.Click();

            IWebElement Button6 = browser.FindElement(By.CssSelector("#i76 > div.quantumWizTogglePapercheckboxInnerBox.exportInnerBox"));
            Button6.Click();
            IWebElement Forward3 = browser.FindElement(By.CssSelector("#mG61Hd > div.freebirdFormviewerViewFormCard.exportFormCard > div.freebirdFormviewerViewFormContent > div.freebirdFormviewerViewNavigationNavControls > div.freebirdFormviewerViewNavigationButtonsAndProgress > div.freebirdFormviewerViewNavigationLeftButtons > div.appsMaterialWizButtonEl.appsMaterialWizButtonPaperbuttonEl.appsMaterialWizButtonPaperbuttonFilled.freebirdFormviewerViewNavigationSubmitButton.freebirdThemedFilledButtonM2.isUndragged > span > span"));
            Forward3.Click();
            //adress.SendKeys("Str. TestTest");

            //Assert.IsTrue(browser.FindElement(By.CssSelector("#continue-checkout > button")).Enabled);

            //IWebElement Cont = browser.FindElement(By.CssSelector("#continue-checkout > button"));
            //Cont.Click();



            //IWebElement Credit = browser.FindElement(By.Id("creditcard_number"));
            //IWebElement Security = browser.FindElement(By.Id("credit_card_cvv"));
            //IWebElement Expire = browser.FindElement(By.Id("expiration_date"));
            //IWebElement Card = browser.FindElement(By.Id("cardholder_name"));

            //Credit.SendKeys("1111 1111 1111 1111");
            //Security.SendKeys("111");
            //Expire.SendKeys("Str. TestTest");
            //Card.SendKeys("Tester");


            //IWebElement Terms = browser.FindElement(By.XPath("/html/body/div[3]/div/div[11]/div[1]/div[4]/form/div[1]/div/div"));
            //Terms.Click();

            //IWebElement Final = browser.FindElement(By.Id("finalSubmitOrder"));
            //Final.Click();


            //Assert.IsFalse(browser.FindElement(By.Id("finalSubmitOrder")).Enabled);


            System.Threading.Thread.Sleep(6000);



        }
    }
}
