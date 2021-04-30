using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelAPP.DataAccess
{
    class EmpAccess
    {
        HotelDB hotelDB;
        public EmpAccess()
        {
            hotelDB = new HotelDB();
        }
        public Employee getByID(int id)
        {
            try
            {
                Employee employee = (from e in hotelDB.Employees
                                     where e.Id == id
                                     select e).First();
                return employee;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getAllEmp()
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public List<Employee> getByPhone()
        //{
        //    try
        //    {
        //        var list = (from emps in hotelDB.Employees
        //                    where emps.p
        //                    select emps).ToList();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
