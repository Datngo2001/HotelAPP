
namespace HotelAPP.AppForm
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.title_pn = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.footer_pn = new System.Windows.Forms.Panel();
            this.title_lb = new System.Windows.Forms.Label();
            this.username_pn = new System.Windows.Forms.Panel();
            this.split_pn1 = new System.Windows.Forms.Panel();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_pn = new System.Windows.Forms.Panel();
            this.split_pn2 = new System.Windows.Forms.Panel();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.body_pn = new System.Windows.Forms.Panel();
            this.title_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.footer_pn.SuspendLayout();
            this.username_pn.SuspendLayout();
            this.password_pn.SuspendLayout();
            this.body_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_pn
            // 
            this.title_pn.BackColor = System.Drawing.Color.White;
            this.title_pn.Controls.Add(this.close_btn);
            this.title_pn.Controls.Add(this.logo_pb);
            this.title_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_pn.Location = new System.Drawing.Point(0, 0);
            this.title_pn.Name = "title_pn";
            this.title_pn.Size = new System.Drawing.Size(605, 299);
            this.title_pn.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.AutoSize = true;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.close_btn.Location = new System.Drawing.Point(563, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(39, 35);
            this.close_btn.TabIndex = 100;
            this.close_btn.Text = "O";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // logo_pb
            // 
            this.logo_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo_pb.Image = global::HotelAPP.Properties.Resources.logo_large;
            this.logo_pb.Location = new System.Drawing.Point(0, 0);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(605, 299);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pb.TabIndex = 6;
            this.logo_pb.TabStop = false;
            this.logo_pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_pb_MouseDown);
            // 
            // login_btn
            // 
            this.login_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(178, 14);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(241, 50);
            this.login_btn.TabIndex = 100;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // footer_pn
            // 
            this.footer_pn.Controls.Add(this.login_btn);
            this.footer_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_pn.Location = new System.Drawing.Point(0, 588);
            this.footer_pn.Name = "footer_pn";
            this.footer_pn.Size = new System.Drawing.Size(605, 112);
            this.footer_pn.TabIndex = 2;
            // 
            // title_lb
            // 
            this.title_lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_lb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.title_lb.Location = new System.Drawing.Point(0, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(605, 64);
            this.title_lb.TabIndex = 4;
            this.title_lb.Text = "Log in";
            this.title_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_pn
            // 
            this.username_pn.Controls.Add(this.username_tb);
            this.username_pn.Controls.Add(this.split_pn1);
            this.username_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.username_pn.Location = new System.Drawing.Point(0, 64);
            this.username_pn.Name = "username_pn";
            this.username_pn.Size = new System.Drawing.Size(605, 80);
            this.username_pn.TabIndex = 5;
            // 
            // split_pn1
            // 
            this.split_pn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.split_pn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.split_pn1.Location = new System.Drawing.Point(127, 72);
            this.split_pn1.Name = "split_pn1";
            this.split_pn1.Size = new System.Drawing.Size(352, 2);
            this.split_pn1.TabIndex = 1;
            // 
            // username_tb
            // 
            this.username_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_tb.BackColor = System.Drawing.Color.White;
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(127, 29);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(352, 28);
            this.username_tb.TabIndex = 0;
            this.username_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_pn
            // 
            this.password_pn.Controls.Add(this.password_tb);
            this.password_pn.Controls.Add(this.split_pn2);
            this.password_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.password_pn.Location = new System.Drawing.Point(0, 144);
            this.password_pn.Name = "password_pn";
            this.password_pn.Size = new System.Drawing.Size(605, 80);
            this.password_pn.TabIndex = 5;
            // 
            // split_pn2
            // 
            this.split_pn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.split_pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.split_pn2.Location = new System.Drawing.Point(127, 72);
            this.split_pn2.Name = "split_pn2";
            this.split_pn2.Size = new System.Drawing.Size(352, 2);
            this.split_pn2.TabIndex = 2;
            // 
            // password_tb
            // 
            this.password_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_tb.BackColor = System.Drawing.Color.White;
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(127, 29);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(352, 28);
            this.password_tb.TabIndex = 1;
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // body_pn
            // 
            this.body_pn.Controls.Add(this.password_pn);
            this.body_pn.Controls.Add(this.username_pn);
            this.body_pn.Controls.Add(this.title_lb);
            this.body_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pn.Location = new System.Drawing.Point(0, 299);
            this.body_pn.Name = "body_pn";
            this.body_pn.Size = new System.Drawing.Size(605, 289);
            this.body_pn.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 700);
            this.Controls.Add(this.body_pn);
            this.Controls.Add(this.footer_pn);
            this.Controls.Add(this.title_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(605, 700);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.title_pn.ResumeLayout(false);
            this.title_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.footer_pn.ResumeLayout(false);
            this.username_pn.ResumeLayout(false);
            this.username_pn.PerformLayout();
            this.password_pn.ResumeLayout(false);
            this.password_pn.PerformLayout();
            this.body_pn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_pn;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel footer_pn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Panel username_pn;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Panel split_pn1;
        private System.Windows.Forms.Panel password_pn;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Panel split_pn2;
        private System.Windows.Forms.Panel body_pn;
    }
}