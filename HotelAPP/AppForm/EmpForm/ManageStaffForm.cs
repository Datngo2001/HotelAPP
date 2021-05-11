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
            //listEmp_dgv.DataSource = employee.getAllEmp();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
