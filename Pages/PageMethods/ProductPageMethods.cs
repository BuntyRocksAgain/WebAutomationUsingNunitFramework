using AutoFramework.Pages.PageElements;
using OpenQA.Selenium;

namespace AutoFramework.Pages.PageMethods
{
    public static class ProductPageMethods
    {
        public static void AddToCart(string Name)
        {
            ProductsElements product = new ProductsElements();
            if (Name == "Sauce Labs Backpack")
            {
                //string Text = product.Backpack.Text;
                product.Backpack_AddToCart!.Click();
            }
            else if (Name == "Sauce Labs Bolt T-Shirt")
            {
                product.TShirt_AddToCart!.Click();
            }
            else if (Name == "Sauce Labs Bike Light")
            {
                product.BikeLight_AddToCart!.Click();
            }
            else if (Name == "Sauce Labs Fleece Jacket")
            {
                product.Jacket_AddToCart!.Click();
            }
            else if (Name == "Sauce Labs Onesie")
            {
                product.Onesie_AddToCart!.Click();
            }
            else if (Name == "Test.allTheThings() T-Shirt (Red)")
            {
                product.TShirt_Red_AddToCart!.Click();
            }

            Driver.driver!.FindElement(By.XPath("//a[@class= 'shopping_cart_link']")).Click();
        }

        public static void RemoveFromCart(string Name)
        {
            try
            {
                CartElements cartElement = new CartElements();
                cartElement.Cart!.Click();
                //ProductsElements product = new ProductsElements();
                string Title = cartElement.Cart_Product_Name!.Text;
                if (Name == Title)
                {
                    cartElement.Cart_Remove_Button!.Click();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Problem in Product Remove");
            }

        }
    }
}

