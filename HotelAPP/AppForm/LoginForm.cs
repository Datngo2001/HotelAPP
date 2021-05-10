using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HotelAPP.DataAccess;

namespace HotelAPP.AppForm
{
    public partial class LoginForm : Form
    {
        AccountAccess accountAccess;
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            SendMessage(username_tb.Handle, EM_SETCUEBANNER, 0, "username");
            SendMessage(password_tb.Handle, EM_SETCUEBANNER, 0, "password");

            accountAccess = new AccountAccess();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void logo_pb_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void forgot_llb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (accountAccess.getLogin(username_tb.Text, password_tb.Text) == true)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Incorrect password or username!");
                this.DialogResult = DialogResult.No;
            }

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
