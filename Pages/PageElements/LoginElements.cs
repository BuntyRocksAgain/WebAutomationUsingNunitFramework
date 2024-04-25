namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class LoginElements
    {
        public LoginElements()
        {
            PageFactory.InitElements(Driver.driver!, this);
        }

        [FindsBy(How = How.Id, Using = "user-name")]
        public IWebElement? UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement? Password { get; set; }

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement? LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='react-burger-menu-btn']")]
        public IWebElement? ThreeDotMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='logout_sidebar_link']")]
        public IWebElement? LogOutLink { get; set; }

    }
}
