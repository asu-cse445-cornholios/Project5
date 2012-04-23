using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using OrderSystemLibrary.ShoppingCartProxy;

namespace OrderSystemLibrary
{
    public class ShoppingCartContext
    {
        public IEnumerable<ShoppingCart> ShoppingCarts
        {
            get
            {
                var proxy = new ShoppingCartProxy.ShoppingCartServiceClient();
                var carts = proxy.GetAllCarts();
                proxy.Close();
                return carts;
            }
        }

        public IEnumerable<CartItem> CartItems
        {
            get
            {
                var proxy = new ShoppingCartProxy.ShoppingCartServiceClient();
                var cartItems = proxy.GetAllCartItems();
                proxy.Close();
                return cartItems;
            }
        }

        public static void CreateCart(string username)
        {
            var proxy = new ShoppingCartProxy.ShoppingCartServiceClient();
            proxy.CreateCart(username);
            proxy.Close();
        }

        public static void AddNewItem(string username, string item, int quantity)
        {
            var proxy = new ShoppingCartProxy.ShoppingCartServiceClient();
            proxy.AddItemToCartByUsername(username, item, quantity);
            proxy.Close();
        }

        public static bool SubmitOrder(string username)
        {
            var proxy = new ShoppingCartProxy.ShoppingCartServiceClient();
            var cart = proxy.GetCartByUsername(username);
            bool success;
            using (var db = new OrderSystemEntities())
            {
                var order = new Order {placed_at = DateTime.Now, userName = username};
                foreach (var cartItem in cart.CartItems)
                {
                    var orderItem = new OrderItem();
                    orderItem.ItemName = cartItem.Item;
                    orderItem.Modified = cartItem.Modified;
                    orderItem.Price = cartItem.Price;
                    orderItem.Quantity = cartItem.Quantity;
                    order.OrderItems.Add(orderItem);
                }
                success = db.SaveChanges() > 0;
            }
            proxy.Close();
            return success;
        }
    }
}
