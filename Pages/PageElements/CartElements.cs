namespace AutoFramework.Pages.PageElements
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    
    public class CartElements
    {
        public CartElements()
        {
            PageFactory.InitElements(Driver.driver!, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class= 'shopping_cart_link']")]
        public IWebElement? Cart { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn_secondary btn_small cart_button']")]
        public IWebElement? Cart_Remove_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class= 'inventory_item_name']")]
        public IWebElement? Cart_Product_Name { get; set; }
    }
}
