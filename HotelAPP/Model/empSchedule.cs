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

        int maxWork;
        public void Scheduling()
        {
            maxWork = 7;

            var empQ = getEmpQueue();

            ResetSchedule();

            Queue<int> workday = new Queue<int>();
            for (int i = 0; i < empQ.Count; i++)
            {
                workday.Enqueue(0);
            }

            if (empQ == null) return;

            // xep lich cho thu 2 tới thu 6
            for (int i = 1; i < 6; i++)
            {
                // ca 1
                int managerSlot1 = 1;
                int receptSlot1 = 2;
                int laborSlot1 = 2;

                // ca 2
                int managerSlot2 = 1;
                int receptSlot2 = 1;
                int laborSlot2 = 2;

                // ca 3
                int receptSlot3 = 1;
                int laborSlot3 = 1;

                // ca 1
                int checkedEmp = 0;
                while ((managerSlot1 + receptSlot1 + laborSlot1) > 0 && (checkedEmp <= empQ.Count))
                {
                    Employee temp = empQ.Dequeue();
                    int worked = workday.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, i) != null)
                    {
                        empQ.Enqueue(temp);
                        workday.Enqueue(worked);
                        continue;
                    }

                    //manager
                    if (temp.posId == 1 && managerSlot1 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 1
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        managerSlot1--;
                        continue;
                    }
                    //reception
                    if (temp.posId == 2 && receptSlot1 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 1
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        receptSlot1--;
                        continue;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlot1 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 1
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        laborSlot1--;
                        continue;
                    }

                    workday.Enqueue(worked);
                    empQ.Enqueue(temp);
                }

                // ca 2
                checkedEmp = 0;
                while ((managerSlot2 + receptSlot2 + laborSlot2) > 0 && (checkedEmp <= empQ.Count))
                {
                    Employee temp = empQ.Dequeue();
                    int worked = workday.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, i) != null)
                    {
                        empQ.Enqueue(temp);
                        workday.Enqueue(worked);
                        continue;
                    }

                    //manager
                    if (temp.posId == 1 && managerSlot2 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 2
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        managerSlot2--;
                        continue;
                    }
                    //reception
                    if (temp.posId == 2 && receptSlot2 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 2
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        receptSlot2--;
                        continue;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlot2 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 2
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        laborSlot2--;
                        continue;
                    }

                    workday.Enqueue(worked);
                    empQ.Enqueue(temp);
                }

                //ca 3
                checkedEmp = 0;
                while ((receptSlot3 + laborSlot3) > 0 && (checkedEmp <= empQ.Count))
                {
                    Employee temp = empQ.Dequeue();
                    int worked = workday.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, i) != null)
                    {
                        empQ.Enqueue(temp);
                        workday.Enqueue(worked);
                        continue;
                    }

                    //manager or reception
                    if (temp.posId == 2 && receptSlot3 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 3
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        receptSlot3--;
                        continue;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlot3 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = 3
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        laborSlot3--;
                        continue;
                    }

                    workday.Enqueue(worked);
                    empQ.Enqueue(temp);
                }
            }

            // xep lich cho thu 7 CN
            for (int i = 0; i < 2; i++)
            {
                int day;
                if (i == 0)
                {
                    day = (int)DayOfWeek.Saturday;
                }
                else
                {
                    day = (int)DayOfWeek.Sunday;
                }

                // ca 1
                int receptSlot1 = 1;
                int laborSlot1 = 1;

                // ca 2
                int receptSlot2 = 1;
                int laborSlot2 = 1;

                // ca 3
                int receptSlot3 = 1;
                int laborSlot3 = 1;

                //ca 1
                int checkedEmp = 0;
                while ((receptSlot1 + laborSlot1) > 0 && (checkedEmp <= empQ.Count))
                {
                    Employee temp = empQ.Dequeue();
                    int worked = workday.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, day) != null)
                    {
                        empQ.Enqueue(temp);
                        workday.Enqueue(worked);
                        continue;
                    }

                    //reception
                    if (temp.posId == 2 && receptSlot1 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 1
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        receptSlot1--;
                        continue;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlot1 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 1
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        laborSlot1--;
                        continue;
                    }

                    workday.Enqueue(worked);
                    empQ.Enqueue(temp);
                }

                //ca 2
                checkedEmp = 0;
                while ((receptSlot2 + laborSlot2) > 0 && (checkedEmp <= empQ.Count))
                {
                    Employee temp = empQ.Dequeue();
                    int worked = workday.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, day) != null)
                    {
                        empQ.Enqueue(temp);
                        workday.Enqueue(worked);
                        continue;
                    }

                    //reception
                    if (temp.posId == 2 && receptSlot2 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 2
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        receptSlot2--;
                        continue;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlot2 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 2
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        laborSlot2--;
                        continue;
                    }

                    workday.Enqueue(worked);
                    empQ.Enqueue(temp);
                }

                //ca 3
                checkedEmp = 0;
                while ((receptSlot3 + laborSlot3) > 0 && (checkedEmp <= empQ.Count))
                {
                    Employee temp = empQ.Dequeue();
                    int worked = workday.Dequeue();
                    checkedEmp++;

                    if (hotelDB.empSchedules.Find(temp.Id, day) != null)
                    {
                        empQ.Enqueue(temp);
                        workday.Enqueue(worked);
                        continue;
                    }

                    //reception
                    if (temp.posId == 2 && receptSlot3 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 3
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        receptSlot3--;
                        continue;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlot3 > 0 && worked < maxWork)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = day,
                            shift = 3
                        });
                        workday.Enqueue(worked + 1);
                        empQ.Enqueue(temp);
                        laborSlot3--;
                        continue;
                    }

                    workday.Enqueue(worked);
                    empQ.Enqueue(temp);
                }
            }

            try
            {
                hotelDB.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private Queue<Employee> getEmpQueue()
        {
            Queue<Employee> empQ = new Queue<Employee>();

            var empList = (from e in hotelDB.Employees orderby e.posId select e).ToList();

            if (empList.Count == 0) return null;

            List<Employee> newlist = new List<Employee>();

            foreach (Employee emp in empList)
            {
                empQ.Enqueue(emp);
            }

            return empQ;
        }
        public DataTable MakeTimeTable()
        {
            DataTable timeTable = new DataTable();
            timeTable.Columns.Add().ColumnName = "ID";
            timeTable.Columns.Add().ColumnName = "First Name";
            timeTable.Columns.Add().ColumnName = "Last Name";
            timeTable.Columns.Add().ColumnName = "Position";
            timeTable.Columns.Add().ColumnName = "Monday";
            timeTable.Columns.Add().ColumnName = "Tuesday";
            timeTable.Columns.Add().ColumnName = "Wednesday";
            timeTable.Columns.Add().ColumnName = "Thursday";
            timeTable.Columns.Add().ColumnName = "Friday";
            timeTable.Columns.Add().ColumnName = "Saturday";
            timeTable.Columns.Add().ColumnName = "Sunday";

            var schedules = (from s in hotelDB.empSchedules
                             join e in hotelDB.Employees on s.empID equals e.Id
                             join p in hotelDB.Positions on e.posId equals p.posId
                             orderby s.empID
                             select new
                             {
                                 id = e.Id,
                                 fname = e.fname,
                                 lname = e.lname,
                                 pos = p.posName,
                                 weekDay = s.weekDay,
                                 shift = (int)s.shift
                             }).ToList();

            for (int i = 0; i < schedules.Count; i++)
            {
                var newRow = timeTable.Rows.Add();

                newRow["ID"] = schedules[i].id.ToString();
                newRow["First Name"] = schedules[i].fname;
                newRow["Last Name"] = schedules[i].lname;
                newRow["Position"] = schedules[i].pos;
                Enum day = (DayOfWeek)(schedules[i].weekDay);
                newRow[day.ToString()] = schedules[i].shift.ToString();
                try
                {
                    while (schedules[i].id == schedules[i + 1].id)
                    {
                        i++;
                        day = (DayOfWeek)(schedules[i].weekDay);
                        if(schedules[i].shift != 0)
                            newRow[day.ToString()] = schedules[i].shift.ToString();
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }

            foreach (var schedule in schedules)
            {

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
        public bool switchShift(int id1, int day1, int id2, int day2)
        {
            try
            {
                var schedule1 = hotelDB.empSchedules.Find(id1, day1);
                if(schedule1 == null)
                {
                    var temp = hotelDB.Employees.Find(id1);
                    schedule1 = hotelDB.empSchedules.Add(new empSchedule()
                    {
                        empID = id1,
                        shift = 0,
                        weekDay = day1
                    });
                }

                var schedule2 = hotelDB.empSchedules.Find(id2, day2);
                if (schedule2 == null)
                {
                    var temp = hotelDB.Employees.Find(id2);
                    schedule2 = hotelDB.empSchedules.Add(new empSchedule()
                    {
                        empID = id2,
                        shift = 0,
                        weekDay = day2
                    });
                }

                if ((int)schedule1.Employee.posId == (int)schedule2.Employee.posId)
                {
                    int temp = (int)schedule1.shift;
                    schedule1.shift = schedule2.shift;
                    schedule2.shift = temp;
                    hotelDB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
                return false;
            }
        }
    }
}
