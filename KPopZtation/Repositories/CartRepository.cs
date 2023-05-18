using KPopZtation.Factories;
using KPopZtation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KPopZtation.Repositories
{
    public class CartRepository
    {
        static Database1Entities db = Database.GetInstance();

        public static List<Cart> getAllCart(int customerId)
        {
            List<Cart> cart = (from x in db.Carts where x.CustomerId == customerId select x).ToList();
            return cart;
        }

        public static Cart getCart(int customerId, int albumId)
        {
            Cart cart = (from x in db.Carts where x.CustomerId == customerId && x.AlbumId == albumId select x).FirstOrDefault();
            return cart;
        }

        public static void addCart(int customerId, int albumId, int qty)
        {
            Cart cart = CartFactory.createCart(customerId, albumId, qty);
            db.Carts.Add(cart);
            db.SaveChanges();
            return;
        }

        public static void removeCart(int customerId, int albumId)
        {
            Cart cart = getCart(customerId, albumId);
            db.Carts.Remove(cart);
            db.SaveChanges();
            return;
        }

        public static void CheckOut(int customerId)
        {
            List<Cart> cart = (from x in db.Carts where x.CustomerId == customerId select x).ToList();
            db.Carts.RemoveRange(cart);
            db.SaveChanges();
            return;
        }
    }
}