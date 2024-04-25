namespace AutoFramework
{
    using OpenQA.Selenium.Chrome;
    using System;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Window.Maximize();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); - Implicit Wait
            //Driver.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(1);   - Explicit Wait

        }
    }
}
