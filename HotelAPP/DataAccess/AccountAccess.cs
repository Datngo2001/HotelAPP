using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPP.DataAccess
{
    class AccountAccess
    {
        HotelDB hotelDB;
        public AccountAccess()
        {
            hotelDB = new HotelDB();
        }
        bool getCurrentUser(string username, string password)
        {
            try
            {
                var accounts = (from a in hotelDB.Accounts
                                join e in hotelDB.Employees on a.userID equals e.Id
                                join p in hotelDB.Positions on e.posId equals p.posId
                                where a.username == username && a.password == password
                                select new
                                {
                                    Username = a.username,
                                    Id = e.Id,
                                    PosId = e.posId,
                                    PosName = p.posName,
                                    Avatar = e.avatar
                                }).ToList();
                if(accounts.Count < 0)
                {
                    return false;
                }
                else
                {
                    CurrentUser.UserName = accounts[0].Username;
                    CurrentUser.Id = accounts[0].Id;
                    CurrentUser.PositionNum = accounts[0].PosId.Value;
                    CurrentUser.PositionName = accounts[0].PosName;
                    CurrentUser.Avatar = new HotelAPP.Tools.ImageTool().ByteArrToImage(accounts[0].Avatar);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
