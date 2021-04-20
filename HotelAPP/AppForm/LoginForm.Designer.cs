
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
            this.title_pn = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.footer_pn = new System.Windows.Forms.Panel();
            this.body_pn = new System.Windows.Forms.Panel();
            this.password_pn = new System.Windows.Forms.Panel();
            this.username_pn = new System.Windows.Forms.Panel();
            this.title_lb = new System.Windows.Forms.Label();
            this.foget_pn = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.Button();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.split_pn1 = new System.Windows.Forms.Panel();
            this.split_pn2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.title_pn.SuspendLayout();
            this.footer_pn.SuspendLayout();
            this.body_pn.SuspendLayout();
            this.password_pn.SuspendLayout();
            this.username_pn.SuspendLayout();
            this.foget_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
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
            this.title_pn.Size = new System.Drawing.Size(583, 299);
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
            this.close_btn.Location = new System.Drawing.Point(541, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(39, 35);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "O";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // footer_pn
            // 
            this.footer_pn.Controls.Add(this.button1);
            this.footer_pn.Controls.Add(this.login_btn);
            this.footer_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_pn.Location = new System.Drawing.Point(0, 587);
            this.footer_pn.Name = "footer_pn";
            this.footer_pn.Size = new System.Drawing.Size(583, 161);
            this.footer_pn.TabIndex = 2;
            // 
            // body_pn
            // 
            this.body_pn.Controls.Add(this.foget_pn);
            this.body_pn.Controls.Add(this.password_pn);
            this.body_pn.Controls.Add(this.username_pn);
            this.body_pn.Controls.Add(this.title_lb);
            this.body_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_pn.Location = new System.Drawing.Point(0, 299);
            this.body_pn.Name = "body_pn";
            this.body_pn.Size = new System.Drawing.Size(583, 288);
            this.body_pn.TabIndex = 3;
            // 
            // password_pn
            // 
            this.password_pn.Controls.Add(this.textBox2);
            this.password_pn.Controls.Add(this.split_pn2);
            this.password_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.password_pn.Location = new System.Drawing.Point(0, 144);
            this.password_pn.Name = "password_pn";
            this.password_pn.Size = new System.Drawing.Size(583, 80);
            this.password_pn.TabIndex = 5;
            this.password_pn.Paint += new System.Windows.Forms.PaintEventHandler(this.password_pn_Paint);
            // 
            // username_pn
            // 
            this.username_pn.Controls.Add(this.textBox1);
            this.username_pn.Controls.Add(this.split_pn1);
            this.username_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.username_pn.Location = new System.Drawing.Point(0, 64);
            this.username_pn.Name = "username_pn";
            this.username_pn.Size = new System.Drawing.Size(583, 80);
            this.username_pn.TabIndex = 5;
            // 
            // title_lb
            // 
            this.title_lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_lb.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.title_lb.Location = new System.Drawing.Point(0, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(583, 64);
            this.title_lb.TabIndex = 4;
            this.title_lb.Text = "Log in";
            this.title_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foget_pn
            // 
            this.foget_pn.Controls.Add(this.linkLabel1);
            this.foget_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foget_pn.Location = new System.Drawing.Point(0, 224);
            this.foget_pn.Name = "foget_pn";
            this.foget_pn.Size = new System.Drawing.Size(583, 64);
            this.foget_pn.TabIndex = 6;
            // 
            // login_btn
            // 
            this.login_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(171, 20);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(241, 50);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = false;
            // 
            // logo_pb
            // 
            this.logo_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo_pb.Image = global::HotelAPP.Properties.Resources.logo_large;
            this.logo_pb.Location = new System.Drawing.Point(0, 0);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(583, 299);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pb.TabIndex = 6;
            this.logo_pb.TabStop = false;
            this.logo_pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_pb_MouseDown);
            // 
            // split_pn1
            // 
            this.split_pn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.split_pn1.Location = new System.Drawing.Point(116, 72);
            this.split_pn1.Name = "split_pn1";
            this.split_pn1.Size = new System.Drawing.Size(352, 2);
            this.split_pn1.TabIndex = 1;
            // 
            // split_pn2
            // 
            this.split_pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.split_pn2.Location = new System.Drawing.Point(116, 72);
            this.split_pn2.Name = "split_pn2";
            this.split_pn2.Size = new System.Drawing.Size(352, 2);
            this.split_pn2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(116, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(116, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(352, 28);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(583, 64);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot your password?";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.Location = new System.Drawing.Point(171, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 748);
            this.Controls.Add(this.body_pn);
            this.Controls.Add(this.footer_pn);
            this.Controls.Add(this.title_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.title_pn.ResumeLayout(false);
            this.title_pn.PerformLayout();
            this.footer_pn.ResumeLayout(false);
            this.body_pn.ResumeLayout(false);
            this.password_pn.ResumeLayout(false);
            this.password_pn.PerformLayout();
            this.username_pn.ResumeLayout(false);
            this.username_pn.PerformLayout();
            this.foget_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_pn;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel footer_pn;
        private System.Windows.Forms.Panel body_pn;
        private System.Windows.Forms.Panel password_pn;
        private System.Windows.Forms.Panel username_pn;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel foget_pn;
        private System.Windows.Forms.Panel split_pn1;
        private System.Windows.Forms.Panel split_pn2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}