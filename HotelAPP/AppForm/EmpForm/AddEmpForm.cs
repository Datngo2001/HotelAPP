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
    public partial class AddEmpForm : Form
    {
        List<Position> listPos;
        public AddEmpForm()
        {
            InitializeComponent();
        }
        private void upload_btn_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            try
            {
                pictureBox.Image = Image.FromFile(filepath.ToString());
            }
            catch (Exception)
            {
                return;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            if ((checkid() && checkPhone() && checkCMND()) == false) return; 

            Employee employee = new Employee()
            {
                fname = fname_tx.Text,
                lname = lname_tb.Text,
                CMND = cmnd_tb.Text,
                bdate = bdate_picker.Value,
                address = address_rtb.Text
            };

            try
            {
                employee.Id = Convert.ToInt32(id_tb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if(manager_tb.Text == "")
                {
                    employee.manager = null;
                }
                else
                {
                    if (checkManager() == false)
                    {
                        MessageBox.Show("Invalid manager Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        employee.manager = Convert.ToInt32(manager_tb.Text);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid manager Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                employee.salary = Convert.ToDecimal(salary_tb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Salary", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                employee.avatar = new ImageTool(pictureBox.Image).toByteArray();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Avatar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // tim posId theo posName
                int select = (listPos.Find(p => p.posName == positon_cb.Text)).posId;
                if(select > 0)
                {
                    employee.posId = select;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Position", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (female_rbtn.Checked)
            {
                employee.gender = "F";
            }
            else if (male_rbtn.Checked)
            {
                employee.gender = "M";
            }

            employee.addEmp(employee);

            // insert emp account

            if(password_tb.Text != reenter_tb.Text)
            {
                MessageBox.Show("Password not match", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account account = new Account();

            if(account.AddNewAccount(username_tb.Text, password_tb.Text, Convert.ToInt32(id_tb.Text)) == false)
            {
                MessageBox.Show("Username Existed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("OK");
        }

        private void AddEmpForm_Load(object sender, EventArgs e)
        {
            loadPos();
        }
        private void loadPos()
        {
            listPos = new Position().getAllPos();
            foreach (Position pos in listPos)
            {
                positon_cb.Items.Add(pos.posName);
            }
        }
        private void idCheck_btn_Click(object sender, EventArgs e)
        {
            if(checkid() == true)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Id existed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkCMND_btn_Click(object sender, EventArgs e)
        {
            if(checkCMND() == true)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("CMND existed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkPhone_btn_Click(object sender, EventArgs e)
        {
            if(checkPhone() == true)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Phone existed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkUserName_btn_Click(object sender, EventArgs e)
        {
            if(checkUsername() == true)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Username Existed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void managerCheck_btn_Click(object sender, EventArgs e)
        {
            if (checkManager() == true)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("No manager", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkUsername()
        {
            Account account = new Account();
            try
            {
                if(account.ExistUsernamCheck(username_tb.Text) == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool checkid()
        {
            Employee emp = new Employee();
            int id;
            try
            {
                id = Convert.ToInt32(id_tb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                var temp = emp.getByID(id);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
        private bool checkPhone()
        {
            Employee emp = new Employee();
            try
            {
                var temp = emp.getByPhone(phone_tb.Text);
                if (temp.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
            }
        }
        private bool checkCMND()
        {
            Employee emp = new Employee();
            try
            {
                var temp = emp.getByCMND(cmnd_tb.Text);
                if(temp.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
            }
        }
        private bool checkManager()
        {
            Employee emp = new Employee();
            int id;
            try
            {
                id = Convert.ToInt32(manager_tb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid manager Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                var temp = emp.getManager(id);
                if(temp.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
