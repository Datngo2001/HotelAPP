using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAPP.AppForm.EmpForm
{
    public partial class CheckinCheckoutForm : Form
    {
        public CheckinCheckoutForm()
        {
            InitializeComponent();
        }

        private void checkin_btn_Click(object sender, EventArgs e)
        {
            if(new CheckIn().checkIn() == true)
            {
                checkin_btn.Enabled = false;
                checkout_btn.Enabled = true;
            }
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            if(new CheckOut().checkOut() == true)
            {
                checkin_btn.Enabled = true;
                checkout_btn.Enabled = false;
            }
        }

        private void CheckinCheckoutForm_Load(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToLongDateString();
            time_lb.Text = DateTime.Now.ToString("T");
            timer.Start();

            Employee currEmp = new Employee().getByID(CurrentUser.Id);
            if (currEmp.isWorking())
            {
                checkin_btn.Enabled = false;
            }
            else
            {
                checkout_btn.Enabled = false;
            }
            string currShift = currEmp.getShift();
            if (currShift == "0")
            {
                shift_lb.Text = "You are free today";
                checkin_btn.Enabled = false;
                checkout_btn.Enabled = false;
            }
            else
            {
                shift_lb.Text = currShift;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time_lb.Text = DateTime.Now.ToString("T");
        }
    }
}
