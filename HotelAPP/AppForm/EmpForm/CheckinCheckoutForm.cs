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
            new CheckIn().checkIn();
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            new CheckOut().checkOut();
        }

        private void CheckinCheckoutForm_Load(object sender, EventArgs e)
        {
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
                shift_lb.Text = "Shift: " + currShift;
            }
        }
    }
}
