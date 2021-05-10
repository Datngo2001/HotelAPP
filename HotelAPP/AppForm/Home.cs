using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HotelAPP.AppForm.EmpForm;
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
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    titleBar_pn.BackColor = color;
                    User_pn.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
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
            if(activeForm != null)
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

        private void Home_Load(object sender, EventArgs e)
        {
            username_lb.Text = CurrentUser.UserName;
            position_lb.Text = CurrentUser.PositionName;
            if(CurrentUser.Avatar != null)
            {
                avatar_pb.Image = new ImageTool().ClipToCircle(CurrentUser.Avatar);
            }
        }
    }
}
