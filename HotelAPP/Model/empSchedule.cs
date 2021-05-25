using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPP
{
    public partial class empSchedule
    {
        HotelDB hotelDB = new HotelDB();
        public void Scheduling()
        {
            var empQ = getEmpQueue();

            if (empQ == null) return;

            // xep lich cho thu 2 tới thu 6
            for (int i = 1; i < 7; i++)
            {
                int managerSlotDay = 1;
                int receptSlotDay = 2;
                int laborSlotDay = 4;
                int managerOrReceptSlotNight = 1;
                int laborSlotNight = 1;

                // ca sang
                int checkedEmp = 0;
                while ((managerSlotDay + receptSlotDay + laborSlotDay) > 0 && checkedEmp <= empQ.Count)
                {
                    Employee temp = empQ.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, i) != null)
                    {
                        empQ.Enqueue(temp);
                        continue;
                    }

                    //manager
                    if (temp.posId == 1 && managerSlotDay > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 1
                        });
                        managerSlotDay--;
                    }
                    //reception
                    if (temp.posId == 2 && receptSlotDay > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 1
                        });
                        receptSlotDay--;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlotDay > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 1
                        });
                        laborSlotDay--;
                    }

                    empQ.Enqueue(temp);
                }

                //ca toi
                checkedEmp = 0;
                while ((managerOrReceptSlotNight + laborSlotNight) > 0 && checkedEmp <= empQ.Count)
                {
                    Employee temp = empQ.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, i) != null)
                    {
                        empQ.Enqueue(temp);
                        continue;
                    }

                    //manager or reception
                    if ((temp.posId == 1 || temp.posId == 2) && managerOrReceptSlotNight > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 2
                        });
                        managerOrReceptSlotNight--;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlotNight > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 2
                        });
                        laborSlotNight--;
                    }

                    empQ.Enqueue(temp);
                }
            }

            // xep lich cho thu 7 CN
            for (int i = 0; i < 2; i++)
            {
                int day;
                if(i == 0)
                {
                    day = (int)DayOfWeek.Sunday;
                }
                else
                {
                    day = (int)DayOfWeek.Saturday;
                }

                int managerOrReceptSlotDay = 1;
                int laborSlotDay = 3;
                int managerOrReceptSlotNight = 1;
                int laborSlotNight = 3;

                // ca sang
                int checkedEmp = 0;
                while ((managerOrReceptSlotDay + laborSlotDay) > 0 && checkedEmp <= empQ.Count)
                {
                    Employee temp = empQ.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, day) != null)
                    {
                        empQ.Enqueue(temp);
                        continue;
                    }

                    //manager or reception
                    if ((temp.posId == 1 || temp.posId == 2) && managerOrReceptSlotDay > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 1
                        });
                        managerOrReceptSlotDay--;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlotDay > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 1
                        });
                        laborSlotDay--;
                    }

                    empQ.Enqueue(temp);
                }

                //ca toi
                checkedEmp = 0;
                while ((managerOrReceptSlotNight + laborSlotNight) > 0 && checkedEmp <= empQ.Count)
                {
                    Employee temp = empQ.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, day) != null)
                    {
                        empQ.Enqueue(temp);
                        continue;
                    }

                    //manager or reception
                    if ((temp.posId == 1 || temp.posId == 2) && managerOrReceptSlotNight > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 2
                        });
                        managerOrReceptSlotNight--;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlotNight > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 2
                        });
                        laborSlotNight--;
                    }

                    empQ.Enqueue(temp);
                }
            }

            hotelDB.SaveChanges();
        }
        private Queue<Employee> getEmpQueue()
        {
            Queue<Employee> empQ = new Queue<Employee>();

            var empList = new Employee().getAllEmp();

            if (empList.Count == 0) return null;

            foreach (Employee emp in empList)
            {
                empQ.Enqueue(emp);
            }

            Employee last = new Employee(); //người dc chia cuối cùng tuần trước
            try
            {
                var lastID = (from e in hotelDB.empSchedules
                              where e.shift == 2 && e.weekDay == (int)DayOfWeek.Sunday
                              select e.empID).Last();
                last = last.getByID(lastID);
            }
            catch (Exception)
            {
                last = new Employee().getAllEmp().Last();
            }

            // xu lý sao cho nguoi dung dau Queue la người kế tiep cua người da dc xếp luan truoc
            for (int i = 0; i < empQ.Count; i++)
            {
                var temp = empQ.Dequeue();
                if (temp.Id == last.Id)
                {
                    empQ.Enqueue(temp);
                    break;
                }
                else
                {
                    empQ.Enqueue(temp);
                }
            }
            return empQ;
        }
        public DataTable MakeTimeTable()
        {
            DataTable timeTable = new DataTable();
            timeTable.Columns.Add().ColumnName = "ID";
            timeTable.Columns.Add().ColumnName = "First Name";
            timeTable.Columns.Add().ColumnName = "Last Name";
            timeTable.Columns.Add().ColumnName = "Sunday";
            timeTable.Columns.Add().ColumnName = "Monday";
            timeTable.Columns.Add().ColumnName = "Tuesday";
            timeTable.Columns.Add().ColumnName = "Wednesday";
            timeTable.Columns.Add().ColumnName = "Thursday";
            timeTable.Columns.Add().ColumnName = "Friday";
            timeTable.Columns.Add().ColumnName = "Saturday";

            var schedules = (from s in hotelDB.empSchedules
                            join e in hotelDB.Employees on s.empID equals e.Id
                            orderby s.empID select new
                            {
                                id = e.Id,
                                fname = e.fname,
                                lname = e.lname,
                                weekDay = s.weekDay,
                                shift = (int)s.shift
                            }).ToList();

            foreach (var schedule in schedules)
            {
                var newRow = timeTable.Rows.Add();

                newRow["ID"] = schedule.id.ToString();
                newRow["First Name"] = schedule.fname;
                newRow["Last Name"] = schedule.lname;
                newRow[schedule.weekDay + 3] = schedule.shift.ToString();
            }

            return timeTable;
        }
        public void ResetSchedule()
        {
            var temp = (from s in hotelDB.empSchedules select s).ToList();

            foreach (var item in temp)
            {
                hotelDB.empSchedules.Remove(item);
            }

            hotelDB.SaveChanges();
        }
    }
}
