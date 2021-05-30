using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAPP.AppForm.CustomerForm
{
    public partial class AddCustomerForm : Form
    {
        Customer customer;
        Room room;

        public AddCustomerForm()
        {
            InitializeComponent();
            customer = new Customer();
            room = new Room();
        }

        private void showDGV(object dataSource, int col)
        {
            show_dgv.DataSource = dataSource;
            show_dgv.AllowUserToAddRows = false;
            show_dgv.RowTemplate.Height = 80;

            if (col != 11)
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)show_dgv.Columns["picture"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            int n = show_dgv.Columns.Count;
            for (int i = col; i < n; i++)
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


        private void clear()
        {
            id_tb.Text = "";
            fname_tb.Text = "";
            lname_tb.Text = "";
            phone_tb.Text = "";
            address_rtb.Text = "";
            roomID_cb.Text = "";
            number_tb.Text = "";
            bdate_picker.Value = DateTime.Today;
            dayIn_picker.Value = DateTime.Today;
            dayOut_picker.Value = DateTime.Today;
            show_dgv.DataSource = null;
        }

        private void loadCombox()
        {
            roomID_cb.DataSource = room.getAllEmptyRoom();
            roomID_cb.ValueMember = "id";
            roomID_cb.DisplayMember = "id";
        }

        private bool roomFull(int roomID)
        {
            string status = room.getByID(roomID).status;
            if (status == "Empty")
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            this.loadCombox();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                fname = fname_tb.Text,
                lname = lname_tb.Text,
                bdate = bdate_picker.Value,
                address = address_rtb.Text,
                dayIn = dayIn_picker.Value,
                dayOut = dayOut_picker.Value
            };

            try
            {
                customer.phone = Convert.ToUInt64(phone_tb.Text).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Phone", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (female_rbtn.Checked)
            {
                customer.gender = "F";
            }
            else if (male_rbtn.Checked)
            {
                customer.gender = "M";
            }

            if (this.roomFull(Convert.ToInt32(roomID_cb.Text)))
            {
                customer.roomID = Convert.ToInt32(roomID_cb.Text);
            }
            else
            {
                MessageBox.Show("Room is full", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(number_tb.Text) > 0)
            {
                customer.number = Convert.ToInt32(number_tb.Text);
            }
            else
            {
                MessageBox.Show("Invalid Number of People", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (customer.addCustomer(customer))
            {
                MessageBox.Show("Add Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                room.fullOrEmpty(Convert.ToInt32(roomID_cb.Text), "Full");
                this.clear();
            }
            else
            {
                MessageBox.Show("Add Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer()
            {
                id = Convert.ToInt32(id_tb.Text),
                fname = fname_tb.Text,
                lname = lname_tb.Text,
                bdate = bdate_picker.Value,
                address = address_rtb.Text,
                roomID = Convert.ToInt32(roomID_cb.Text),
                dayIn = dayIn_picker.Value,
                dayOut = dayOut_picker.Value
            };

            try
            {
                cust.phone = Convert.ToUInt64(phone_tb.Text).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Phone", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (female_rbtn.Checked)
            {
                cust.gender = "F";
            }
            else if (male_rbtn.Checked)
            {
                cust.gender = "M";
            }

            if (Convert.ToInt32(number_tb.Text) > 0)
            {
                cust.number = Convert.ToInt32(number_tb.Text);
            }
            else
            {
                MessageBox.Show("Invalid Number of People", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (customer.editCustomer(cust))
            {
                MessageBox.Show("Edit Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
            else
            {
                MessageBox.Show("Edit Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_tb.Text);
            if (customer.deleteCustomer(id))
            {
                MessageBox.Show("Delete Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
            else
            {
                MessageBox.Show("Delete Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showCust_btn_Click(object sender, EventArgs e)
        {
            this.showDGV(customer.getAllCustomer(), 11);
        }

        private void showRoom_btn_Click(object sender, EventArgs e)
        {
            this.showDGV(room.getAllRoom(), 5);
        }

        private void showEmptyRoom_btn_Click(object sender, EventArgs e)
        {
            this.showDGV(room.getAllEmptyRoom(), 5);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void show_dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id_tb.Text = show_dgv.CurrentRow.Cells[0].Value.ToString().Trim();
                fname_tb.Text = show_dgv.CurrentRow.Cells[1].Value.ToString().Trim();
                lname_tb.Text = show_dgv.CurrentRow.Cells[2].Value.ToString().Trim();
                bdate_picker.Value = (DateTime)show_dgv.CurrentRow.Cells[3].Value;
                phone_tb.Text = show_dgv.CurrentRow.Cells[5].Value.ToString().Trim();
                address_rtb.Text = show_dgv.CurrentRow.Cells[6].Value.ToString().Trim();
                roomID_cb.Text = show_dgv.CurrentRow.Cells[7].Value.ToString().Trim();
                number_tb.Text = show_dgv.CurrentRow.Cells[10].Value.ToString().Trim();

                string gender = show_dgv.CurrentRow.Cells[4].Value.ToString().Trim();
                if (gender == "F")
                {
                    female_rbtn.Checked = true;
                }
                else
                {
                    male_rbtn.Checked = true;
                }

                dayIn_picker.Value = (DateTime)show_dgv.CurrentRow.Cells[8].Value;
                dayOut_picker.Value = (DateTime)show_dgv.CurrentRow.Cells[9].Value;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear();
            }
        }
    }
}
