
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
            this.removeEmp_btn = new System.Windows.Forms.Button();
            this.editEmp_btn = new System.Windows.Forms.Button();
            this.addEmp_btn = new System.Windows.Forms.Button();
            this.logo_pn = new System.Windows.Forms.Panel();
            this.titleBar_pn = new System.Windows.Forms.Panel();
            this.closeChildForm_btn = new System.Windows.Forms.Button();
            this.title_lb = new System.Windows.Forms.Label();
            this.desktop_pn = new System.Windows.Forms.Panel();
            this.hotelLogo_pb = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.maximize_btn = new System.Windows.Forms.Button();
            this.menu_pn.SuspendLayout();
            this.titleBar_pn.SuspendLayout();
            this.desktop_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelLogo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_pn
            // 
            this.menu_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menu_pn.Controls.Add(this.removeEmp_btn);
            this.menu_pn.Controls.Add(this.editEmp_btn);
            this.menu_pn.Controls.Add(this.addEmp_btn);
            this.menu_pn.Controls.Add(this.logo_pn);
            this.menu_pn.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_pn.Location = new System.Drawing.Point(0, 0);
            this.menu_pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menu_pn.Name = "menu_pn";
            this.menu_pn.Size = new System.Drawing.Size(313, 708);
            this.menu_pn.TabIndex = 0;
            // 
            // removeEmp_btn
            // 
            this.removeEmp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeEmp_btn.FlatAppearance.BorderSize = 0;
            this.removeEmp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEmp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmp_btn.ForeColor = System.Drawing.Color.White;
            this.removeEmp_btn.Image = global::HotelAPP.Properties.Resources.edit;
            this.removeEmp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeEmp_btn.Location = new System.Drawing.Point(0, 246);
            this.removeEmp_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.removeEmp_btn.Name = "removeEmp_btn";
            this.removeEmp_btn.Size = new System.Drawing.Size(313, 77);
            this.removeEmp_btn.TabIndex = 4;
            this.removeEmp_btn.Text = "    Remove Employee";
            this.removeEmp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeEmp_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeEmp_btn.UseVisualStyleBackColor = true;
            this.removeEmp_btn.Click += new System.EventHandler(this.removeEmp_btn_Click);
            // 
            // editEmp_btn
            // 
            this.editEmp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editEmp_btn.FlatAppearance.BorderSize = 0;
            this.editEmp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEmp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmp_btn.ForeColor = System.Drawing.Color.White;
            this.editEmp_btn.Image = global::HotelAPP.Properties.Resources.edit;
            this.editEmp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editEmp_btn.Location = new System.Drawing.Point(0, 169);
            this.editEmp_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.editEmp_btn.Name = "editEmp_btn";
            this.editEmp_btn.Size = new System.Drawing.Size(313, 77);
            this.editEmp_btn.TabIndex = 3;
            this.editEmp_btn.Text = "    Edit Employee";
            this.editEmp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editEmp_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editEmp_btn.UseVisualStyleBackColor = true;
            this.editEmp_btn.Click += new System.EventHandler(this.editEmp_btn_Click);
            // 
            // addEmp_btn
            // 
            this.addEmp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addEmp_btn.FlatAppearance.BorderSize = 0;
            this.addEmp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp_btn.ForeColor = System.Drawing.Color.White;
            this.addEmp_btn.Image = global::HotelAPP.Properties.Resources.edit;
            this.addEmp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmp_btn.Location = new System.Drawing.Point(0, 92);
            this.addEmp_btn.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.addEmp_btn.Name = "addEmp_btn";
            this.addEmp_btn.Size = new System.Drawing.Size(313, 77);
            this.addEmp_btn.TabIndex = 2;
            this.addEmp_btn.Text = "    Add Employee";
            this.addEmp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmp_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addEmp_btn.UseVisualStyleBackColor = true;
            this.addEmp_btn.Click += new System.EventHandler(this.addEmp_btn_Click);
            // 
            // logo_pn
            // 
            this.logo_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logo_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_pn.Location = new System.Drawing.Point(0, 0);
            this.logo_pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logo_pn.Name = "logo_pn";
            this.logo_pn.Size = new System.Drawing.Size(313, 92);
            this.logo_pn.TabIndex = 1;
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
            this.titleBar_pn.Size = new System.Drawing.Size(883, 92);
            this.titleBar_pn.TabIndex = 1;
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
            // title_lb
            // 
            this.title_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(0, 0);
            this.title_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(883, 92);
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
            this.desktop_pn.Size = new System.Drawing.Size(883, 616);
            this.desktop_pn.TabIndex = 2;
            // 
            // hotelLogo_pb
            // 
            this.hotelLogo_pb.BackColor = System.Drawing.Color.White;
            this.hotelLogo_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hotelLogo_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelLogo_pb.Image = global::HotelAPP.Properties.Resources.hotelLogo;
            this.hotelLogo_pb.Location = new System.Drawing.Point(0, 0);
            this.hotelLogo_pb.Name = "hotelLogo_pb";
            this.hotelLogo_pb.Size = new System.Drawing.Size(883, 616);
            this.hotelLogo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hotelLogo_pb.TabIndex = 0;
            this.hotelLogo_pb.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.AutoSize = true;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(841, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(39, 35);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "O";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click_1);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(751, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(39, 35);
            this.minimize_btn.TabIndex = 2;
            this.minimize_btn.Text = "O";
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // maximize_btn
            // 
            this.maximize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_btn.AutoSize = true;
            this.maximize_btn.FlatAppearance.BorderSize = 0;
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_btn.ForeColor = System.Drawing.Color.White;
            this.maximize_btn.Location = new System.Drawing.Point(796, 0);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Size = new System.Drawing.Size(39, 35);
            this.maximize_btn.TabIndex = 2;
            this.maximize_btn.Text = "O";
            this.maximize_btn.UseVisualStyleBackColor = true;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 708);
            this.Controls.Add(this.desktop_pn);
            this.Controls.Add(this.titleBar_pn);
            this.Controls.Add(this.menu_pn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menu_pn.ResumeLayout(false);
            this.titleBar_pn.ResumeLayout(false);
            this.titleBar_pn.PerformLayout();
            this.desktop_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelLogo_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_pn;
        private System.Windows.Forms.Panel logo_pn;
        private System.Windows.Forms.Button addEmp_btn;
        private System.Windows.Forms.Button removeEmp_btn;
        private System.Windows.Forms.Button editEmp_btn;
        private System.Windows.Forms.Panel titleBar_pn;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Panel desktop_pn;
        private System.Windows.Forms.Button closeChildForm_btn;
        private System.Windows.Forms.PictureBox hotelLogo_pb;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button maximize_btn;
        private System.Windows.Forms.Button minimize_btn;
    }
}