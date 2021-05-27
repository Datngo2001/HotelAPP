using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelAPP
{
    public partial class Consume
    {
        HotelDB hotelDB = new HotelDB();

        public Consume getByID(int id)
        {
            hotelDB = new HotelDB();
            try
            {
                Consume consume = (from c in hotelDB.Consumes
                                 where c.id == id
                             select c).First();
                return consume;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Consume> getAllConsume()
        {
            try
            {
                var list = (from consume in hotelDB.Consumes
                            select consume).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool addConsume(Consume consume)
        {
            try
            {
                hotelDB.Consumes.Add(consume);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool deleteConsume(int id)
        {
            try
            {
                Consume consume = (from c in hotelDB.Consumes
                                where c.id == id
                             select c).First();
                hotelDB.Consumes.Remove(consume);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool editConsume(Consume consume)
        {
            try
            {
                var newRoom = hotelDB.Consumes.Single(r => r.id == consume.id);
                newRoom.roomID = consume.roomID;
                newRoom.roomName = consume.roomName;
                newRoom.productID = consume.productID;
                newRoom.productName = consume.productName;
                newRoom.consume = consume.consume;
                newRoom.date = consume.date;
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
