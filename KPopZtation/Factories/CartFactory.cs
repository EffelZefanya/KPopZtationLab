using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Factories
{
    public class CartFactory
    {
        public static Cart createCart(int customerId, int albumId, int qty)
        {
            Cart cart = new Cart();
            cart.CustomerId = customerId;
            cart.AlbumId = albumId;
            cart.Qty = qty;
            return cart;
        }
    }
}