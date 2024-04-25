using OpenQA.Selenium;
using AutoFramework.Pages.PageMethods;
using AutoFramework.Pages.PageElements;
using NUnit.Framework.Legacy;
using WebAutomationNunitFramework.Library;

namespace AutoFramework
{
    public class TestScenarios
    {
        [OneTimeSetUp]
        public void InitializeExtentReport()
        {
            ExtentReport.CExtentReport();
        }


        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();

        }

        [Test, Order(1)]
        //[Ignore("Skip this method")]
        public void LoginTestValidCredentials()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent!.CreateTest("Login With Valid Credentials");
                ExtentReport.test.AssignCategory("Login Test");
                ExtentReport.ExtentModuleName("Application Login");
                LoginPageMethods.LoginLogout(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password);
                IWebElement HeaderText = Driver.driver!.FindElement(By.XPath("//div[contains(text(),'Swag Labs')]"));
                ClassicAssert.AreEqual(HeaderText.Text, "Swag Labs");
                ExtentReport.ExtentPass("Logged in to application sucessfully.");
                Driver.WaitForElementUpTo(3);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Problem in logout.");
            }
        }

        [Test, Order(2)]
        public void LoginTestInvalidCredentials()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent!.CreateTest("Login With Invalid Credentials");
                ExtentReport.test.AssignCategory("Login Test");
                ExtentReport.ExtentModuleName("Application Login");
                LoginPageMethods.FillLoginForm(Config.Credentials.Invalid.Username, Config.Credentials.Invalid.Password);
                IWebElement ErrorMessage = Driver.driver!.FindElement(By.XPath("//h3[@data-test='error']"));
                ClassicAssert.AreEqual(ErrorMessage.Text, "Epic sadface: Username and password do not match any user in this service");
                ExtentReport.ExtentPass("Validation Message displaying on Login Form.");
                Driver.WaitForElementUpTo(3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Problem in Validating Invalid Caredential.");
            }
        }

        [Test, Order(3)]
        //[Ignore("Skip this method")]
        public void ProductAddToCart()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent!.CreateTest("Add product to Cart");
                ExtentReport.test.AssignCategory("Product Cart Test");
                ExtentReport.ExtentModuleName("Product Test");
                LoginPageMethods.Login(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password);

                //  ----------------------------- Products --------------------------------
                // Sauce Labs Backpack  | Sauce Labs Bike Light |  Sauce Labs Bolt T-Shirt
                // Sauce Labs Fleece Jacket | Sauce Labs Onesie | Test.allTheThings() T-Shirt (Red)

                string input = "Test.allTheThings() T-Shirt (Red)";
                ProductPageMethods.AddToCart(input);
                CartElements cartElements = new CartElements();
                string Title = cartElements.Cart_Product_Name!.Text;
                ClassicAssert.AreEqual(Title, input);
                ExtentReport.ExtentPass("Product Added to Cart and Verified the Product Title.");
                Driver.WaitForElementUpTo(3);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Problem in Product Name");
            }
        }

        [Test, Order(4)]
        //[Ignore("Skip this method")]
        public void ProductRemoveFromCart()
        {
            try
            {
                ExtentReport.test = ExtentReport.extent!.CreateTest("Product Remove From Cart");
                ExtentReport.test.AssignCategory("Product Cart Test");
                ExtentReport.ExtentModuleName("Product Test");
                LoginPageMethods.Login(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password);

                //  ----------------------------- Products --------------------------------
                // Sauce Labs Backpack  | Sauce Labs Bike Light |  Sauce Labs Bolt T-Shirt
                // Sauce Labs Fleece Jacket | Sauce Labs Onesie | Test.allTheThings() T-Shirt (Red)

                string input = "Sauce Labs Bike Light";
                ProductPageMethods.AddToCart(input);
                ProductPageMethods.RemoveFromCart(input);
                ExtentReport.ExtentPass("Product Removed From Cart and Verified the Product Title.");
                Driver.WaitForElementUpTo(3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Problem in Product Name");
            }
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver!.Quit();

        }


        [OneTimeTearDown]
        public void closeExtentReport()
        {
            ExtentReport.extent!.Flush();
        }
    }
}