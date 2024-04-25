namespace AutoFramework.Pages.PageElements
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class ProductsElements
    {
        public ProductsElements()
        {
            PageFactory.InitElements(Driver.driver!, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sauce Labs Backpack']")]
        public IWebElement? Backpack { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id= 'add-to-cart-sauce-labs-backpack']")]
        public IWebElement? Backpack_AddToCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sauce Labs Bike Light']")]
        public IWebElement? BikeLight { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id= 'add-to-cart-sauce-labs-bike-light']")]
        public IWebElement? BikeLight_AddToCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sauce Labs Bolt T-Shirt']")]
        public IWebElement? TShirt { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id= 'add-to-cart-sauce-labs-bolt-t-shirt']")]
        public IWebElement? TShirt_AddToCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sauce Labs Fleece Jacket']")]
        public IWebElement? Jacket { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id= 'add-to-cart-sauce-labs-fleece-jacket']")]
        public IWebElement? Jacket_AddToCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sauce Labs Onesie']")]
        public IWebElement? Onesie { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id= 'add-to-cart-sauce-labs-onesie']")]
        public IWebElement? Onesie_AddToCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Test.allTheThings() T-Shirt (Red)']")]
        public IWebElement? TShirt_Red { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id= 'add-to-cart-test.allthethings()-t-shirt-(red)']")]
        public IWebElement? TShirt_Red_AddToCart { get; set; }

    }
}
