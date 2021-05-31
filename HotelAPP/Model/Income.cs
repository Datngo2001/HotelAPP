using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace HotelAPP
{
    public partial class Income
    {
        HotelDB hotelDB = new HotelDB();

        public static int priceRoom { get; private set; }
        public static void setPriceRoom()
        {
            priceRoom = 0;
        }
        public static void sumPriceRoom(int price)
        {
            priceRoom += price;
        }

        public object statistic()
        {
            try
            {
                var list = (from c in hotelDB.Consumes
                            group c by new { c.productID, c.productName, c.date } into g
                            join p in hotelDB.Products
                            on g.Key.productID equals p.id
                            where g.Key.date == DateTime.Today
                            select new
                            {
                                name = g.Key.productName,
                                p.picture,
                                consume = g.Sum(item => item.consume),
                                p.price,
                                total = g.Sum(item => item.consume) * p.price
                            }).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int total()
        {
            try
            {
                int total = Convert.ToInt32((from c in hotelDB.Consumes
                                             group c by new { c.productID, c.productName, c.date } into g
                                             join p in hotelDB.Products
                                             on g.Key.productID equals p.id
                                             where g.Key.date == DateTime.Today
                                             select new
                                             {
                                                 total = g.Sum(item => item.consume) * p.price
                                             }).Sum(x => x.total));
                return total;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
