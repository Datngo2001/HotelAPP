
namespace HotelAPP.AppForm
{
    partial class Home
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
            this.menu_pn = new System.Windows.Forms.Panel();
            this.ManageEmp_btn = new System.Windows.Forms.Button();
            this.User_pn = new System.Windows.Forms.Panel();
            this.position_lb = new System.Windows.Forms.Label();
            this.username_lb = new System.Windows.Forms.Label();
            this.avatar_pn = new System.Windows.Forms.Panel();
            this.titleBar_pn = new System.Windows.Forms.Panel();
            this.maximize_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.title_lb = new System.Windows.Forms.Label();
            this.desktop_pn = new System.Windows.Forms.Panel();
            this.addForm_btn = new System.Windows.Forms.Button();
            this.editForm_btn = new System.Windows.Forms.Button();
            this.deleteForm_btn = new System.Windows.Forms.Button();
            this.checkInOut_btn = new System.Windows.Forms.Button();
            this.timeTable_btn = new System.Windows.Forms.Button();
            this.hotelLogo_pb = new System.Windows.Forms.PictureBox();
            this.closeChildForm_btn = new System.Windows.Forms.Button();
            this.avatar_pb = new System.Windows.Forms.PictureBox();
            this.menu_pn.SuspendLayout();
            this.User_pn.SuspendLayout();
            this.avatar_pn.SuspendLayout();
            this.titleBar_pn.SuspendLayout();
            this.desktop_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelLogo_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_pn
            // 
            this.menu_pn.AutoScroll = true;
            this.menu_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menu_pn.Controls.Add(this.checkInOut_btn);
            this.menu_pn.Controls.Add(this.timeTable_btn);
            this.menu_pn.Controls.Add(this.deleteForm_btn);
            this.menu_pn.Controls.Add(this.editForm_btn);
            this.menu_pn.Controls.Add(this.addForm_btn);
            this.menu_pn.Controls.Add(this.ManageEmp_btn);
            this.menu_pn.Controls.Add(this.User_pn);
            this.menu_pn.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_pn.Location = new System.Drawing.Point(0, 0);
            this.menu_pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menu_pn.Name = "menu_pn";
            this.menu_pn.Size = new System.Drawing.Size(313, 1080);
            this.menu_pn.TabIndex = 0;
            // 
            // ManageEmp_btn
            // 
            this.ManageEmp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ManageEmp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageEmp_btn.FlatAppearance.BorderSize = 0;
            this.ManageEmp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageEmp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmp_btn.ForeColor = System.Drawing.Color.White;
            this.ManageEmp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageEmp_btn.Location = new System.Drawing.Point(0, 92);
            this.ManageEmp_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.ManageEmp_btn.Name = "ManageEmp_btn";
            this.ManageEmp_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ManageEmp_btn.Size = new System.Drawing.Size(313, 65);
            this.ManageEmp_btn.TabIndex = 2;
            this.ManageEmp_btn.Text = "Employee";
            this.ManageEmp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageEmp_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageEmp_btn.UseVisualStyleBackColor = true;
            this.ManageEmp_btn.Click += new System.EventHandler(this.addEmp_btn_Click);
            // 
            // User_pn
            // 
            this.User_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.User_pn.Controls.Add(this.position_lb);
            this.User_pn.Controls.Add(this.username_lb);
            this.User_pn.Controls.Add(this.avatar_pn);
            this.User_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.User_pn.Location = new System.Drawing.Point(0, 0);
            this.User_pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User_pn.Name = "User_pn";
            this.User_pn.Size = new System.Drawing.Size(313, 92);
            this.User_pn.TabIndex = 1;
            // 
            // position_lb
            // 
            this.position_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.position_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.position_lb.Location = new System.Drawing.Point(93, 53);
            this.position_lb.Name = "position_lb";
            this.position_lb.Size = new System.Drawing.Size(220, 39);
            this.position_lb.TabIndex = 3;
            this.position_lb.Text = "label1";
            // 
            // username_lb
            // 
            this.username_lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lb.ForeColor = System.Drawing.Color.White;
            this.username_lb.Location = new System.Drawing.Point(93, 0);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(220, 53);
            this.username_lb.TabIndex = 4;
            this.username_lb.Text = "label1";
            this.username_lb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // avatar_pn
            // 
            this.avatar_pn.Controls.Add(this.avatar_pb);
            this.avatar_pn.Dock = System.Windows.Forms.DockStyle.Left;
            this.avatar_pn.Location = new System.Drawing.Point(0, 0);
            this.avatar_pn.Name = "avatar_pn";
            this.avatar_pn.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.avatar_pn.Size = new System.Drawing.Size(93, 92);
            this.avatar_pn.TabIndex = 2;
            // 
            // titleBar_pn
            // 
            this.titleBar_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.titleBar_pn.Controls.Add(this.maximize_btn);
            this.titleBar_pn.Controls.Add(this.minimize_btn);
            this.titleBar_pn.Controls.Add(this.close_btn);
            this.titleBar_pn.Controls.Add(this.closeChildForm_btn);
            this.titleBar_pn.Controls.Add(this.title_lb);
            this.titleBar_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar_pn.Location = new System.Drawing.Point(313, 0);
            this.titleBar_pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleBar_pn.Name = "titleBar_pn";
            this.titleBar_pn.Size = new System.Drawing.Size(1607, 92);
            this.titleBar_pn.TabIndex = 1;
            // 
            // maximize_btn
            // 
            this.maximize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_btn.AutoSize = true;
            this.maximize_btn.FlatAppearance.BorderSize = 0;
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_btn.ForeColor = System.Drawing.Color.White;
            this.maximize_btn.Location = new System.Drawing.Point(1520, 0);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(39, 35);
            this.maximize_btn.TabIndex = 2;
            this.maximize_btn.Text = "O";
            this.maximize_btn.UseVisualStyleBackColor = true;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(1475, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(39, 35);
            this.minimize_btn.TabIndex = 2;
            this.minimize_btn.Text = "O";
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.AutoSize = true;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(1565, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(39, 35);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "O";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click_1);
            // 
            // title_lb
            // 
            this.title_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(0, 0);
            this.title_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(1607, 92);
            this.title_lb.TabIndex = 0;
            this.title_lb.Text = "Home";
            this.title_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_lb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_lb_MouseDown);
            // 
            // desktop_pn
            // 
            this.desktop_pn.Controls.Add(this.hotelLogo_pb);
            this.desktop_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktop_pn.Location = new System.Drawing.Point(313, 92);
            this.desktop_pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.desktop_pn.Name = "desktop_pn";
            this.desktop_pn.Size = new System.Drawing.Size(1607, 988);
            this.desktop_pn.TabIndex = 2;
            // 
            // addForm_btn
            // 
            this.addForm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.addForm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addForm_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addForm_btn.FlatAppearance.BorderSize = 0;
            this.addForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addForm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addForm_btn.ForeColor = System.Drawing.Color.White;
            this.addForm_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addForm_btn.Location = new System.Drawing.Point(0, 157);
            this.addForm_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.addForm_btn.Name = "addForm_btn";
            this.addForm_btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.addForm_btn.Size = new System.Drawing.Size(313, 47);
            this.addForm_btn.TabIndex = 5;
            this.addForm_btn.Text = "Add";
            this.addForm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addForm_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addForm_btn.UseVisualStyleBackColor = false;
            this.addForm_btn.Click += new System.EventHandler(this.addForm_btn_Click);
            // 
            // editForm_btn
            // 
            this.editForm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.editForm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editForm_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editForm_btn.FlatAppearance.BorderSize = 0;
            this.editForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editForm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editForm_btn.ForeColor = System.Drawing.Color.White;
            this.editForm_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editForm_btn.Location = new System.Drawing.Point(0, 204);
            this.editForm_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.editForm_btn.Name = "editForm_btn";
            this.editForm_btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.editForm_btn.Size = new System.Drawing.Size(313, 47);
            this.editForm_btn.TabIndex = 8;
            this.editForm_btn.Text = "Edit";
            this.editForm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editForm_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editForm_btn.UseVisualStyleBackColor = false;
            this.editForm_btn.Click += new System.EventHandler(this.editForm_btn_Click);
            // 
            // deleteForm_btn
            // 
            this.deleteForm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteForm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteForm_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteForm_btn.FlatAppearance.BorderSize = 0;
            this.deleteForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteForm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteForm_btn.ForeColor = System.Drawing.Color.White;
            this.deleteForm_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteForm_btn.Location = new System.Drawing.Point(0, 251);
            this.deleteForm_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.deleteForm_btn.Name = "deleteForm_btn";
            this.deleteForm_btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.deleteForm_btn.Size = new System.Drawing.Size(313, 47);
            this.deleteForm_btn.TabIndex = 9;
            this.deleteForm_btn.Text = "Delete";
            this.deleteForm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteForm_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteForm_btn.UseVisualStyleBackColor = false;
            this.deleteForm_btn.Click += new System.EventHandler(this.deleteForm_btn_Click);
            // 
            // checkInOut_btn
            // 
            this.checkInOut_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkInOut_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkInOut_btn.FlatAppearance.BorderSize = 0;
            this.checkInOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInOut_btn.ForeColor = System.Drawing.Color.White;
            this.checkInOut_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkInOut_btn.Location = new System.Drawing.Point(0, 363);
            this.checkInOut_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.checkInOut_btn.Name = "checkInOut_btn";
            this.checkInOut_btn.Size = new System.Drawing.Size(313, 65);
            this.checkInOut_btn.TabIndex = 11;
            this.checkInOut_btn.Text = "   Check in, Check out";
            this.checkInOut_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkInOut_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkInOut_btn.UseVisualStyleBackColor = true;
            // 
            // timeTable_btn
            // 
            this.timeTable_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.timeTable_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeTable_btn.FlatAppearance.BorderSize = 0;
            this.timeTable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeTable_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTable_btn.ForeColor = System.Drawing.Color.White;
            this.timeTable_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeTable_btn.Location = new System.Drawing.Point(0, 298);
            this.timeTable_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.timeTable_btn.Name = "timeTable_btn";
            this.timeTable_btn.Size = new System.Drawing.Size(313, 65);
            this.timeTable_btn.TabIndex = 10;
            this.timeTable_btn.Text = "   Shift";
            this.timeTable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeTable_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timeTable_btn.UseVisualStyleBackColor = true;
            // 
            // hotelLogo_pb
            // 
            this.hotelLogo_pb.BackColor = System.Drawing.Color.White;
            this.hotelLogo_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hotelLogo_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelLogo_pb.Image = global::HotelAPP.Properties.Resources.hotelLogo;
            this.hotelLogo_pb.Location = new System.Drawing.Point(0, 0);
            this.hotelLogo_pb.Name = "hotelLogo_pb";
            this.hotelLogo_pb.Size = new System.Drawing.Size(1607, 988);
            this.hotelLogo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hotelLogo_pb.TabIndex = 0;
            this.hotelLogo_pb.TabStop = false;
            // 
            // closeChildForm_btn
            // 
            this.closeChildForm_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeChildForm_btn.FlatAppearance.BorderSize = 0;
            this.closeChildForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeChildForm_btn.Image = global::HotelAPP.Properties.Resources.cross_out__2_;
            this.closeChildForm_btn.Location = new System.Drawing.Point(0, 0);
            this.closeChildForm_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeChildForm_btn.Name = "closeChildForm_btn";
            this.closeChildForm_btn.Size = new System.Drawing.Size(112, 92);
            this.closeChildForm_btn.TabIndex = 1;
            this.closeChildForm_btn.UseVisualStyleBackColor = true;
            this.closeChildForm_btn.Visible = false;
            this.closeChildForm_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // avatar_pb
            // 
            this.avatar_pb.Dock = System.Windows.Forms.DockStyle.Right;
            this.avatar_pb.Image = global::HotelAPP.Properties.Resources.user_icon1;
            this.avatar_pb.Location = new System.Drawing.Point(21, 10);
            this.avatar_pb.Margin = new System.Windows.Forms.Padding(0);
            this.avatar_pb.Name = "avatar_pb";
            this.avatar_pb.Size = new System.Drawing.Size(72, 72);
            this.avatar_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar_pb.TabIndex = 5;
            this.avatar_pb.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.desktop_pn);
            this.Controls.Add(this.titleBar_pn);
            this.Controls.Add(this.menu_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu_pn.ResumeLayout(false);
            this.User_pn.ResumeLayout(false);
            this.avatar_pn.ResumeLayout(false);
            this.titleBar_pn.ResumeLayout(false);
            this.titleBar_pn.PerformLayout();
            this.desktop_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelLogo_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_pn;
        private System.Windows.Forms.Panel User_pn;
        private System.Windows.Forms.Button ManageEmp_btn;
        private System.Windows.Forms.Panel titleBar_pn;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Panel desktop_pn;
        private System.Windows.Forms.Button closeChildForm_btn;
        private System.Windows.Forms.PictureBox hotelLogo_pb;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button maximize_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Label position_lb;
        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.Panel avatar_pn;
        private System.Windows.Forms.PictureBox avatar_pb;
        private System.Windows.Forms.Button addForm_btn;
        private System.Windows.Forms.Button checkInOut_btn;
        private System.Windows.Forms.Button timeTable_btn;
        private System.Windows.Forms.Button deleteForm_btn;
        private System.Windows.Forms.Button editForm_btn;
    }
}