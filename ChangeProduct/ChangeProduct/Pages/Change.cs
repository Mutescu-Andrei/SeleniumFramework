using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace ChangeProduct.Pages
{
    public class Change
    {
        
        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement Continue { get; set; }





        public Change(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
