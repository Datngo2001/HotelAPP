using HotelAPP.Tools;
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
        DateTime exportDay;

        public DailyReportForm()
        {
            InitializeComponent();
        }

        private void DailyReportForm_Load(object sender, EventArgs e)
        {
            var date = DateTime.Now.AddDays(1);
            exportDay = new DateTime(date.Year, date.Month, date.Day, 6, 30, 00, 00);

            date_lb.Text = DateTime.Now.ToLongDateString();
            time_lb.Text = DateTime.Now.ToString("T");
            timer.Start();
            
            exportTime_lb.Text += date.ToLongDateString();
            report_dgv.DataSource = new Employee().dailyReport();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            time_lb.Text = now.ToString("T");

            if (now > exportDay)
            {
                print();
            }
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            print();
        }

        private void print()
        {
            ReportTool report = new ReportTool()
            {
                Title = "Daily Report",
                Table = (DataTable)report_dgv.DataSource
            };

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx|Excel files(.xlsx) |*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                if (savefile.FileName.EndsWith("docx") == true)
                {
                    report.toWordReport(savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (savefile.FileName.EndsWith("xlsx") == true)
                {
                    report.ToExcelReport(savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
