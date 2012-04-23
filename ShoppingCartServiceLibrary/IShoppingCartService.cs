using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShoppingCartServiceLibrary
{
    [ServiceContract]
    public interface IShoppingCartService
    {
        [OperationContract]
        bool AddItemToCart(int shoppingCartId, string item, int quantity);
        [OperationContract]
        bool AddItemToCartByUsername(string username, string item, int quantity);
        [OperationContract]
        bool ClearCart(int shoppingCartId);
        [OperationContract]
        int CreateCart(string username);
        [OperationContract]
        ShoppingCart GetCart(int shoppingCartId);
        [OperationContract]
        ShoppingCart GetCartByUsername(string username);
        [OperationContract]
        IEnumerable<ShoppingCart> GetAllCarts();
        [OperationContract]
        IEnumerable<CartItem> GetAllCartItems();
        [OperationContract]
        bool ModifyItemInCart(int shoppingCartId, int cartItemId, int quantity);
        [OperationContract]
        bool DeleteItemFromCart(int shoppingCartId, int cartItemId);
        [OperationContract]
        bool RemoveCart(int shoppingCartId);
    }
}
