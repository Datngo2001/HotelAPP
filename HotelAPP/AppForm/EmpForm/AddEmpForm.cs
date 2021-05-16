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
    public partial class AddEmpForm : Form
    {
        Employee employee;
        public AddEmpForm()
        {
            InitializeComponent();
            employee = new Employee();
        }
        private void upload_btn_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            pictureBox.Image = Image.FromFile(filepath.ToString());
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            employee.Id = Convert.ToInt32(id_tb.Text);
        }
    }
}
