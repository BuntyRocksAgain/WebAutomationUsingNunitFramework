using OpenQA.Selenium;

namespace AutoFramework
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "https://www.saucedemo.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "standard_user";
                public static string Password = "secret_sauce";
            }

            public static class Invalid
            {
                public static string Username = "standard_users";
                public static string Password = "secret_sauces";
            }
        }



        //public static class MenuElements
        //{
        //    public static string Introduction = "Introduction";
        //    public static string Selectors = "Selectors";
        //    public static string SpecialElements = "Special Elements";
        //    public static string TestCases = "Test Cases";
        //    public static string TestScenarios = "Test Scenarios";
        //    public static string About = "About";
        //}

        public static class TestMessages
        {

        }

        //public static class AlertsTexts
        //{
        //    public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
        //    public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
        //    public static string SuccessfulLogin = "Succesful login!";
        //}
    }

}

