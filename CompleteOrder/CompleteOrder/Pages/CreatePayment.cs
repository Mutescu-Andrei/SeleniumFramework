using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CompleteOrder.Pages
{
    public class CreatePayment.Pages
    {


        //add everything you have on the create account page UI
        [FindsBy(How = How.Id, Using = "ap_customer_name")]
        public IWebElement NameInput { get; set; }

        [FindsBy(How = How.Id, Using = "ap_email")]
        public IWebElement EmailInput { get; set; }

        [FindsBy(How = How.Id, Using = "ap_password")]
        public IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "ap_password_check")]
        public IWebElement ConfirmPasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement CreateImdbAccountBtn { get; set; }

        //create method to insert email in the email field
        public void FillInEmail(string email)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(email);
        }

        public CreateAccount(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
