
namespace AutoFramework.Pages.PageMethods
{
    public static class LoginPageMethods
    {
        public static void LoginLogout(string username, string password)
        {
            LoginElements loginScenario = new LoginElements();

            loginScenario.UserName!.Clear();
            loginScenario.UserName.SendKeys(username);
            loginScenario.Password!.Clear();
            loginScenario.Password.SendKeys(password);
            loginScenario.LoginButton!.Click();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
            loginScenario.ThreeDotMenu!.Click();
            loginScenario.LogOutLink!.Click();

        }

        public static void Login(string username, string password)
        {
            LoginElements loginScenario = new LoginElements();

            loginScenario.UserName!.Clear();
            loginScenario.UserName.SendKeys(username);
            loginScenario.Password!.Clear();
            loginScenario.Password.SendKeys(password);
            loginScenario.LoginButton!.Click();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);

        }

        public static void FillLoginForm(string username, string password)
        {
            LoginElements loginScenario = new LoginElements();

            loginScenario.UserName!.Clear();
            loginScenario.UserName.SendKeys(username);
            loginScenario.Password!.Clear();
            loginScenario.Password.SendKeys(password);
            loginScenario.LoginButton!.Click();
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);

        }
    }
}
