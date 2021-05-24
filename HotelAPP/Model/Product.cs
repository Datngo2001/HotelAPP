using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelAPP
{
    public partial class Product
    {
        HotelDB hotelDB = new HotelDB();

        public Product getByID(int id)
        {
            hotelDB = new HotelDB();
            try
            {
                Product prod = (from p in hotelDB.Products
                                where p.id == id
                                select p).First();
                return prod;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> getAllProduct()
        {
            try
            {
                var list = (from prod in hotelDB.Products
                            select prod).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool addProduct(Product product)
        {
            try
            {
                hotelDB.Products.Add(product);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool deleteProduct(int id)
        {
            try
            {
                Product product = (from r in hotelDB.Products
                                   where r.id == id
                                   select r).First();
                hotelDB.Products.Remove(product);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool editProduct(Product product)
        {
            try
            {
                var newProduct = hotelDB.Products.Single(p => p.id == product.id);
                newProduct.name = product.name;
                newProduct.quantity = product.quantity;
                newProduct.price = product.price;
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}