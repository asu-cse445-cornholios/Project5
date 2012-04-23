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
        private readonly string _username;

        public ShoppingCartContext(string username)
        {
            _username = username;
        }
        public IEnumerable<ShoppingCart> ShoppingCarts
        {
            get
            {
                var proxy = new ShoppingCartProxy.ShoppingCartServiceClient();
                var carts = proxy.GetAllCarts();
                proxy.Close();
                if (carts != null)
                {
                    return carts;
                }
                else
                {
                    return new List<ShoppingCart>();
                }
            }
        }

        public IEnumerable<CartItem> CartItems
        {
            get
            {
                var proxy = new ShoppingCartProxy.ShoppingCartServiceClient();
                var cartItems = proxy.GetCartItems(_username);
                proxy.Close();
                if (cartItems != null)
                {
                    return cartItems;
                }
                else
                {
                    return new List<CartItem>();
                }
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
            var cartItems = proxy.GetCartItems(username);
            bool success = false;
            if (cartItems != null && cartItems.Length > 0)
            using (var db = new OrderSystemEntities())
            {
                var order = new Order {placed_at = DateTime.Now, userName = username};
                db.AddToOrders(order);
                foreach (var cartItem in cartItems)
                {
                    var orderItem = new OrderItem();
                    orderItem.Created = cartItem.Created;
                    orderItem.ItemName = cartItem.Item;
                    orderItem.Modified = cartItem.Modified;
                    orderItem.Price = cartItem.Price;
                    orderItem.Quantity = cartItem.Quantity;
                    orderItem.Order = order;
                    order.OrderItems.Add(orderItem);
                    db.AddToOrderItems(orderItem);
                }
                success = db.SaveChanges() > 0;
            }
            if(success)
            {
                proxy.RemoveCartByUsername(username);
            }
            proxy.Close();
            return success;
        }
    }
}
