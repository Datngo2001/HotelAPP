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
        public List<Employee> getByPhone(string phone)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.phone.Trim().Contains(phone)
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getByAddress(string address)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.address.Trim().Contains(address)
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getByCMND(string cmnd)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.CMND.Trim().Contains(cmnd)
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getByFname(string fname)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.fname.Trim().Contains(fname)
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getByLname(string lname)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.lname.Trim().Contains(lname)
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getByBirthDate(DateTime bdate)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.bdate == bdate
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getBySalary(decimal salary)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.salary == salary
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getByPositionId(int posId)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.posId == posId
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Employee> getByPosition(string posname)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            join p in hotelDB.Positions on emps.posId equals p.posId
                            where p.posName == posname
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
