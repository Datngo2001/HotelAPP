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
    public partial class EditDeleteEmpForm : Form
    {
        List<Position> listPos;
        public Employee employee;
        public Account account;
        public EditDeleteEmpForm()
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
            try
            {
                pictureBox.Image = Image.FromFile(filepath.ToString());
            }
            catch (Exception)
            {
                return;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            employee.avatar = new ImageTool(pictureBox.Image).toByteArray();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if ((checkid() && checkPhone() && checkCMND()) == false) return;

            Employee emp = new Employee()
            {
                fname = fname_tx.Text,
                lname = lname_tb.Text,
                CMND = cmnd_tb.Text,
                bdate = bdate_picker.Value,
                address = address_rtb.Text
            };

            try
            {
                emp.Id = Convert.ToInt32(id_tb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (manager_tb.Text == "")
                {
                    emp.manager = null;
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
                        emp.manager = Convert.ToInt32(manager_tb.Text);
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
                emp.salary = Convert.ToDecimal(salary_tb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Salary", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                emp.avatar = new ImageTool(pictureBox.Image).toByteArray();
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
                if (select > 0)
                {
                    emp.posId = select;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Position", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (female_rbtn.Checked)
            {
                emp.gender = "F";
            }
            else if (male_rbtn.Checked)
            {
                emp.gender = "M";
            }

            emp.updateEmp(employee);

            MessageBox.Show("Employee updated");

            // update emp account

            if (password_tb.Text != reenter_tb.Text)
            {
                MessageBox.Show("Password not match", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account acc = new Account();

            if(password_tb.Text == "")
            {
                if (acc.updateAccount(username_tb.Text, Convert.ToInt32(id_tb.Text)) == false)
                {
                    MessageBox.Show("Username Existed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (acc.updateAccount(username_tb.Text, password_tb.Text, Convert.ToInt32(id_tb.Text)) == false)
                {
                    MessageBox.Show("Username Existed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Account updated");
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            Account acc = new Account();
            try
            {
                emp.Id = Convert.ToInt32(id_tb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (acc.deleteAcc(Convert.ToInt32(id_tb.Text)) == false){
            //    MessageBox.Show("Failse", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (emp.deleteEmp(Convert.ToInt32(id_tb.Text)) == false)
            {
                MessageBox.Show("Failse", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("OK");
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
            if (checkid() == true)
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
            if (checkCMND() == true)
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
            if (checkPhone() == true)
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
            if (checkUsername() == true)
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
            if (account.username == username_tb.Text) return true;

            Account acc = new Account();
            try
            {
                if (acc.ExistUsernamCheck(username_tb.Text) == false)
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
            if (employee.Id == id) return true;
            try
            {
                var temp = employee.getByID(id);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
        private bool checkPhone()
        {
            
            if (employee.phone == phone_tb.Text) return true;
            try
            {
                var temp = employee.getByPhone(phone_tb.Text);
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
            if (employee.CMND == cmnd_tb.Text) return true;
            try
            {
                var temp = employee.getByCMND(cmnd_tb.Text);
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
        private bool checkManager()
        {
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
            if (employee.manager == id) return true;
            try
            {
                var temp = employee.getManager(id);
                if (temp.Count == 0)
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
        private void findId_btn_Click(object sender, EventArgs e)
        {
            if (employee == null) employee = new Employee();
            if (account == null) account = new Account();
            try
            {
                employee = employee.getByID(Convert.ToInt32(id_tb.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                account = account.getByID(Convert.ToInt32(id_tb.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Id", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadToForm();
        }
        private void loadToForm()
        {
            if (employee == null) return;
            id_tb.Text = employee.Id.ToString();
            fname_tx.Text = employee.fname;
            lname_tb.Text = employee.lname;
            if(employee.gender == "F")
            {
                female_rbtn.Checked = true;
            }
            else
            {
                male_rbtn.Checked = true;
            }
            phone_tb.Text = employee.phone;
            address_rtb.Text = employee.address;
            cmnd_tb.Text = employee.CMND;
            salary_tb.Text = employee.salary.ToString();
            manager_tb.Text = employee.manager.ToString();
            if (account != null) username_tb.Text = account.username;
            try
            {
                bdate_picker.Value = (DateTime)employee.bdate;
                positon_cb.Text = (listPos.Find(p => p.posId == employee.posId)).posName;
                pictureBox.Image = new ImageTool().ByteArrToImage(employee.avatar);
            }
            catch (Exception)
            {
                return;
            }
        }
        private void EditDeleteEmpForm_Load(object sender, EventArgs e)
        {
            loadPos();
            if (employee != null && account != null)
            {
                employee = employee.getByID(employee.Id);
                account = account.getByID((int)account.userID);
                loadToForm();
            }
        }
    }
}
