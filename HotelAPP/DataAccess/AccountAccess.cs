using System;
using System.Linq;

namespace HotelAPP.DataAccess
{
    class AccountAccess
    {
        HotelDB hotelDB;
        public AccountAccess()
        {
            hotelDB = new HotelDB();
        }
        public bool getCurrentUser(string username, string password)
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
                                }).ToArray();
                if(accounts.Length < 0)
                {
                    return false;
                }
                else
                {
                    CurrentUser.UserName = accounts[0].Username;
                    CurrentUser.Id = accounts[0].Id;
                    CurrentUser.PositionNum = accounts[0].PosId.Value;
                    CurrentUser.PositionName = accounts[0].PosName;
                    if(accounts[0].Avatar != null)
                    {
                        CurrentUser.Avatar = new HotelAPP.Tools.ImageTool().ByteArrToImage(accounts[0].Avatar);
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ExistUsernamCheck(string username)
        {
            try
            {
                var listUsername = (from a in hotelDB.Accounts
                                    where a.username == username
                                    select a.username).ToArray();
                if(listUsername.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        //public bool AddNewGuestAccount(string username, string password)
        //{
        //    try
        //    {
        //        if (ExistUsernamCheck(username) == false) return false;

        //        Account account = new Account()
        //        {
        //            username = username,
        //            password = password
        //        };
        //        hotelDB.Accounts.Add(account);
        //        hotelDB.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}
