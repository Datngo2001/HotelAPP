using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPP
{
    public partial class CheckIn
    {
        HotelDB hotelDB = new HotelDB();
        public bool checkIn()
        {
            var date = DateTime.Now;
            hotelDB.CheckIns.Add(new CheckIn()
            {
                empId = CurrentUser.Id,
                checkInDate = date
            });
            hotelDB.SaveChanges();
            return true;
        }
        public void reset()
        {
            var temp = (from c in hotelDB.CheckIns select c).ToList();

            foreach (var item in temp)
            {
                hotelDB.CheckIns.Remove(item);
            }

            hotelDB.SaveChanges();
        }
    }
}
