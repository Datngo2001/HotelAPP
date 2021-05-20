using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelAPP
{
    public partial class Employee
    {
        HotelDB hotelDB = new HotelDB();

        public Employee getByID(int id)
        {
            hotelDB = new HotelDB();
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
            hotelDB.Configuration.LazyLoadingEnabled = false;
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
            phone = phone.Trim();
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
            address = address.Trim();
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
            cmnd = cmnd.Trim();
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
            fname = fname.Trim();
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
            lname = lname.Trim();
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
            posname = posname.Trim();
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
        public List<Employee> getManager(int id)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.Id == id && emps.posId == 1
                            select emps).ToList();
                return list;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool addEmp(Employee emp)
        {
            try
            {
                hotelDB.Employees.Add(emp);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool updateEmp(Employee emp)
        {
            try
            {
                var uEmp = hotelDB.Employees.Single(e => e.Id == emp.Id);
                uEmp.fname = emp.fname;
                uEmp.lname = emp.lname;
                uEmp.CMND = emp.CMND;
                uEmp.bdate = emp.bdate;
                uEmp.salary = emp.salary;
                uEmp.avatar = emp.avatar;
                uEmp.posId = emp.posId;
                uEmp.phone = emp.phone;
                uEmp.address = emp.address;
                uEmp.gender = emp.gender;
                uEmp.manager = emp.manager;
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool deleteEmp(int id)
        {
            try
            {
                var dEmp = hotelDB.Employees.Single(e => e.Id == id);
                hotelDB.Employees.Remove(dEmp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
