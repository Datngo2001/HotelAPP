using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPP.Model
{
    public partial class empSchedule
    {
        HotelDB hotelDB = new HotelDB();
        public void Scheduling()
        {
            var empQ = getEmpQueue();

            // xep lich cho thu 2 tới thu 6
            for (int i = 1; i < 7; i++)
            {
                int managerSlotDay = 1;
                int receptSlotDay = 2;
                int laborSlotDay = 4;
                int managerOrReceptSlotNight = 1;
                int laborSlotNight = 1;

                // ca sang
                while ((managerSlotDay + receptSlotDay + laborSlotDay) > 0)
                {
                    Employee temp = empQ.Dequeue();

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
                while ((managerOrReceptSlotNight + laborSlotNight) > 0)
                {
                    Employee temp = empQ.Dequeue();

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
                while ((managerOrReceptSlotDay + laborSlotDay) > 0)
                {
                    Employee temp = empQ.Dequeue();

                    //manager or reception
                    if ((temp.posId == 1 || temp.posId == 2) && managerOrReceptSlotDay > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = day
                        });
                        managerOrReceptSlotDay--;
                    }
                    //labor
                    if (temp.posId == 3 && laborSlotDay > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = day
                        });
                        laborSlotDay--;
                    }

                    empQ.Enqueue(temp);
                }

                //ca toi
                while ((managerOrReceptSlotNight + laborSlotNight) > 0)
                {
                    Employee temp = empQ.Dequeue();

                    //manager or reception
                    if ((temp.posId == 1 || temp.posId == 2) && managerOrReceptSlotNight > 0)
                    {
                        hotelDB.empSchedules.Add(new HotelAPP.empSchedule
                        {
                            empID = temp.Id,
                            weekDay = i,
                            shift = day
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
                            shift = day
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
    }
}
