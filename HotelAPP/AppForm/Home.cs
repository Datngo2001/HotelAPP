﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HotelAPP.AppForm.CustomerForm;
using HotelAPP.AppForm.EmpForm;
using HotelAPP.AppForm.ManageWarehouse;
using HotelAPP.AppForm.RoomForm;
using HotelAPP.AppForm.TotalForm;
using HotelAPP.Tools;

namespace HotelAPP.AppForm
{
    public partial class Home : Form
    {
        // Data Fields


        //UI Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Home()
        {
            InitializeComponent();
            random = new Random();
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            Income.setPriceRoom();
            username_lb.Text = CurrentUser.UserName;
            position_lb.Text = CurrentUser.PositionName;
            if (CurrentUser.Avatar != null)
            {
                avatar_pb.Image = new ImageTool().ClipToCircle(CurrentUser.Avatar);
            }

            // Code Phan Quyen
            if(CurrentUser.PositionName != "Manager")
            {
                ManageEmp_btn.Enabled = false;
                addForm_btn.Enabled = false;
                editForm_btn.Enabled = false;
                empReport_btn.Enabled = false;
            }
            if(CurrentUser.PositionName == "Labor")
            {
                customer_btn.Enabled = false;
                product_btn.Enabled = false;
                income_btn.Enabled = false;
                checkOutRoom_btn.Enabled = false;
                room_btn.Enabled = false;
            }
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 150, 136);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //titleBar_pn.BackColor = color;
                    //User_pn.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in menu_pn.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktop_pn.Controls.Add(childForm);
            this.desktop_pn.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            title_lb.Text = childForm.Text;
            closeChildForm_btn.Visible = true;
        }
        private void Reset()
        {
            DisableButton();
            title_lb.Text = "HOME";
            titleBar_pn.BackColor = Color.FromArgb(0, 150, 136);
            User_pn.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            closeChildForm_btn.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void addEmp_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageStaffForm(), sender);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Income.setPriceRoom();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void title_lb_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addForm_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddEmpForm(), sender);
        }

        private void editForm_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditDeleteEmpForm(), sender);
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCustomerForm(), sender);
        }
        private void deleteForm_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCustomerForm(), sender);
        }

        private void timeTable_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ScheduleForm(), sender);
        }

        private void checkInOut_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckinCheckoutForm(), sender);
        }

        private void empReport_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DailyReportForm(), sender);
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageRoomForm(), sender);
        }

        private void checkOutRoom_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckOutRoomForm(), sender);
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageWarehouseForm(), sender);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Program.logout();
        }

        private void avatar_pb_Click(object sender, EventArgs e)
        {
            var edit = new HotelAPP.AppForm.EmpForm.EditDeleteEmpForm();
            edit.employee = new Employee()
            {
                Id = CurrentUser.Id
            };
            edit.account = new Account()
            {
                userID = CurrentUser.Id
            };
            edit.Text = "Edit Your Profile";
            edit.id_lb.Visible = false;
            edit.id_tb.Visible = false;
            edit.findId_btn.Visible = false;
            edit.delete_btn.Visible = false;
            edit.Show();
        }
        private void income_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IncomeForm(), sender);
        }
    }
}
