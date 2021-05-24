using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelAPP
{
    public partial class Room
    {
        HotelDB hotelDB = new HotelDB();

        public Room getByID(int id)
        {
            hotelDB = new HotelDB();
            try
            {
                Room room = (from r in hotelDB.Rooms
                                     where r.id == id
                                     select r).First();
                return room;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Room> getAllRoom()
        {
            try
            {
                var list = (from room in hotelDB.Rooms
                            select room).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Room> getAllEmptyRoom()
        {
            try
            {
                var list = (from room in hotelDB.Rooms
                            where room.status == "Empty"
                            select room).ToList();
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool addRoom(Room room)
        {
            try
            {
                hotelDB.Rooms.Add(room);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool deleteRoom(int id)
        {
            try
            {
                Room room = (from r in hotelDB.Rooms
                                     where r.id == id
                                     select r).First();
                hotelDB.Rooms.Remove(room);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool editRoom(Room room)
        {
            try
            {
                var newRoom = hotelDB.Rooms.Single(r => r.id == room.id);
                newRoom.name = room.name;
                newRoom.status = room.status;
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void fullOrEmpty(int id, string status)
        {
            try
            {
                var room = hotelDB.Rooms.Single(r => r.id == id);
                room.status = status;
                hotelDB.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
