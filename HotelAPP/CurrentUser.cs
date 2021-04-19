using System.Drawing;

namespace HotelAPP
{
    static class CurrentUser
    {
        public static string UserName { get; set; }
        public static int PositionNum { get; set; }
        public static string PositionName { get; set; }
        public static Image Avatar { get; set; }
    }
}
