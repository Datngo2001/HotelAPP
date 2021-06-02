using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPP
{
    public partial class CheckOut
    {
        HotelDB hotelDB = new HotelDB();
        public bool checkOut()
        {
            var date = DateTime.Now;
            hotelDB.CheckOuts.Add(new CheckOut()
            {
                empId = CurrentUser.Id,
                checkOutDate = date
            });
            hotelDB.SaveChanges();
            return true;
        }
        public void reset()
        {
            var temp = (from c in hotelDB.CheckOuts select c).ToList();

            foreach (var item in temp)
            {
                hotelDB.CheckOuts.Remove(item);
            }

            hotelDB.SaveChanges();
        }
        public List<CheckOut> GetCheckOuts(DateTime date)
        {
            List<CheckOut> list = new List<CheckOut>();
            try
            {
                list.AddRange(hotelDB.CheckOuts.Where(i => EntityFunctions.TruncateTime(i.checkOutDate) <= EntityFunctions.TruncateTime(date)));
                return list;
            }
            catch (Exception)
            {
                return list;
            }
        }
    }
}
