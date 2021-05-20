using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPP
{
    public partial class Position
    {
        HotelDB hotelDB = new HotelDB();
        public List<Position> getAllPos()
        {
            var positions = (from p in hotelDB.Positions select p).ToList();
            return positions;
        }
    }
}
