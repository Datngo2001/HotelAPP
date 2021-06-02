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
    public partial class DailyReportForm : Form
    {
        public DailyReportForm()
        {
            InitializeComponent();
        }

        private void DailyReportForm_Load(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToLongDateString();
            time_lb.Text = DateTime.Now.ToString("T");
            timer.Start();

            var exportDay = DateTime.Now.AddDays(1).ToString("D");
            exportTime_lb.Text += exportDay;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time_lb.Text = DateTime.Now.ToString("T");
        }

        private void export_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
