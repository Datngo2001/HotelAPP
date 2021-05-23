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
    public partial class ManageStaffForm : Form
    {
        Employee employee;
        public ManageStaffForm()
        {
            InitializeComponent();
        }

        private void ManageStaffForm_Load(object sender, EventArgs e)
        {
            employee = new Employee();
            show_dgv.DataSource = employee.getAllEmp();
            loadData();
        }

        private void show_dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void show_dgv_DoubleClick(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            Account account = new Account();
            employee.Id = Convert.ToInt32(show_dgv.CurrentRow.Cells[0].Value);
            account.userID = Convert.ToInt32(show_dgv.CurrentRow.Cells[0].Value);

            EditDeleteEmpForm editDeleteEmp = new EditDeleteEmpForm();
            editDeleteEmp.employee = employee;
            editDeleteEmp.account = account;
            editDeleteEmp.Show();

            // refresh
            employee = new Employee();
            show_dgv.DataSource = employee.getAllEmp();
            loadData();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            employee = new Employee();
            show_dgv.DataSource = employee.getAllEmp();
            loadData();
        }
        private void loadData()
        {
            show_dgv.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)show_dgv.Columns["avatar"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            show_dgv.AllowUserToAddRows = false;

            int n = show_dgv.Columns.Count;
            for (int i = 12; i < n; i++)
            {
                try
                {
                    show_dgv.Columns[i].Visible = false;
                }
                catch (Exception)
                {
                    break;
                }
            }

        }
    }
}
