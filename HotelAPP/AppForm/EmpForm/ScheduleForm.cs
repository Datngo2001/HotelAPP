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
    public partial class ScheduleForm : Form
    {
        empSchedule schedule = new empSchedule();
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            schedule_dgv.DataSource = schedule.MakeTimeTable();
        }

        private void begin_btn_Click(object sender, EventArgs e)
        {
            schedule.Scheduling();
            schedule_dgv.DataSource = schedule.MakeTimeTable();
            MessageBox.Show("OK");
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            ReportTool report = new ReportTool()
            {
                Title = "Schedule",
                Table = (System.Data.DataTable)schedule_dgv.DataSource
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

        private void swap_btn_Click(object sender, EventArgs e)
        {
            var row1 = schedule_dgv.Rows[schedule_dgv.SelectedCells[0].RowIndex];
            var row2 = schedule_dgv.Rows[schedule_dgv.SelectedCells[1].RowIndex];
            int id1;
            int id2;

            try
            {
                id1 = Convert.ToInt32(row1.Cells["ID"].Value);
                id2 = Convert.ToInt32(row2.Cells["ID"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid ID!");
                return;
            }

            var col1 = schedule_dgv.Columns[schedule_dgv.SelectedCells[0].ColumnIndex];
            var col2 = schedule_dgv.Columns[schedule_dgv.SelectedCells[1].ColumnIndex];
            DayOfWeek day1;
            DayOfWeek day2;
            try
            {
                Enum.TryParse(col1.Name, out day1);
                Enum.TryParse(col2.Name, out day2);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid cell!");
                return;
            }

            if (schedule.switchShift(id1, (int)day1, id2, (int)day2) == true)
            {
                MessageBox.Show("OK!");
                schedule_dgv.DataSource = schedule.MakeTimeTable();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
