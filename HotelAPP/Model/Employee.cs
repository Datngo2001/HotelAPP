using System;
using System.Collections.Generic;
using System.Data;
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
                                     orderby e.Id
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
        public List<Employee> getByGender(string gender)
        {
            try
            {
                var list = (from emps in hotelDB.Employees
                            where emps.gender == gender
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
        public bool isWorking()
        {
            CheckIn checkedIn;
            CheckOut checkedOut;
            
            try
            {
                checkedIn = (from i in hotelDB.CheckIns orderby i.checkInDate select i).ToList().Last();
            }
            catch (Exception)
            {
                return false;
            }

            try
            {
                checkedOut = (from i in hotelDB.CheckOuts orderby i.checkOutDate select i).ToList().Last();
            }
            catch (Exception)
            {
                return true;
            }

            if(checkedIn.checkInDate > checkedOut.checkOutDate)
            {
                // dang lam 
                return true;
            }
            if (checkedIn.checkInDate < checkedOut.checkOutDate)
            {
                return false;
            }
            return true;
        }
        public string getShift()
        {
            try
            {
                int dayOfWeek = (int)DateTime.Now.DayOfWeek;
                empSchedule schedules = (from s in hotelDB.empSchedules
                                         where s.empID == this.Id && s.weekDay == dayOfWeek
                                         select s).First();
                return schedules.Shift1.time;
            }
            catch (Exception)
            {
                return "0";
            }
        }
        public List<Employee> search(string hint)
        {
            List<Employee> list = new List<Employee>();
            try
            {
                list.AddRange((from e in hotelDB.Employees
                               where hint.Contains(e.Id.ToString())
                               select e).ToList());
                list.AddRange((from e in hotelDB.Employees
                               where hint.Contains(e.fname)
                               select e).ToList());
                list.AddRange((from e in hotelDB.Employees
                               where hint.Contains(e.lname)
                               select e).ToList());
                list.AddRange((from e in hotelDB.Employees
                               where hint.Contains(e.phone)
                               select e).ToList());
                list.AddRange((from e in hotelDB.Employees
                               where hint.Contains(e.CMND)
                               select e).ToList());
                return list;
            }
            catch (Exception)
            {
                return list;
            }
        }
        public bool deleteEmp(int id)
        {
            try
            {
                var dEmp = hotelDB.Employees.Single(e => e.Id == id);
                hotelDB.Employees.Remove(dEmp);
                hotelDB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable dailyReport()
        {
            var now = DateTime.Now;
            DataTable table = new DataTable();
            table.Columns.Add().ColumnName = "Id";
            table.Columns.Add().ColumnName = "First Name";
            table.Columns.Add().ColumnName = "Last Name";
            table.Columns.Add().ColumnName = "Detail";
            table.Columns.Add().ColumnName = "Salary";

            var emps = new Employee().getAllEmp();
            var checkIns = new CheckIn().GetCheckIns(now);
            var checkOuts = new CheckOut().GetCheckOuts(now);

            try
            {
                foreach (Employee emp in emps)
                {
                    DataRow row = table.NewRow();
                    row[0] = emp.Id;
                    row[1] = emp.fname;
                    row[2] = emp.lname;

                    var ins = (from i in checkIns
                               where i.empId == emp.Id
                               orderby i.checkInDate
                               select i).ToList();
                    var outs = (from i in checkOuts
                               where i.empId == emp.Id
                               orderby i.checkOutDate
                               select i).ToList();

                    double timeOn = 0;
                    for (int i = 0; i < outs.Count; i++)
                    {
                        try
                        {
                            TimeSpan value = ins[i].checkInDate.Subtract(outs[i].checkOutDate);
                            timeOn += value.TotalHours;
                            row[3] += ins[i].checkInDate.ToString("t") + " - " + outs[i].checkOutDate.ToString("t") + ", ";
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    timeOn = Math.Round(timeOn, 1);

                    decimal salary = (decimal)emp.salary * 8;

                    if (timeOn < 8)
                    {
                        if(emp.posId == 2)
                        {
                            salary -= 120000 * (8 - (decimal)timeOn);
                        }
                        else if(emp.posId == 3)
                        {
                            salary -= 60000 * (8 - (decimal)timeOn);
                        }
                    }

                    if (salary < 0) salary = 0;

                    row[4] = Math.Round(salary, 1);

                    table.Rows.Add(row);
                }

                return table;
            }
            catch (Exception)
            {
                return table;
            }
        }
    }
}
