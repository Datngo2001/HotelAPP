
namespace HotelAPP.AppForm.EmpForm
{
    partial class ManageStaffForm
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
            this.listEmp_pn = new System.Windows.Forms.Panel();
            this.show_dgv = new System.Windows.Forms.DataGridView();
            this.btn_pn = new System.Windows.Forms.Panel();
            this.check_pn = new System.Windows.Forms.Panel();
            this.check_btn = new System.Windows.Forms.Button();
            this.dateOption_gb = new System.Windows.Forms.GroupBox();
            this.no_rbtn = new System.Windows.Forms.RadioButton();
            this.yes_rbtn = new System.Windows.Forms.RadioButton();
            this.dateEnd2_dtp = new System.Windows.Forms.DateTimePicker();
            this.dateEnd1_dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.female_rBtn = new System.Windows.Forms.RadioButton();
            this.male_rBtn = new System.Windows.Forms.RadioButton();
            this.all_rBtn = new System.Windows.Forms.RadioButton();
            this.print_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.search_pn = new System.Windows.Forms.Panel();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_lb = new System.Windows.Forms.Label();
            this.listEmp_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            this.btn_pn.SuspendLayout();
            this.check_pn.SuspendLayout();
            this.dateOption_gb.SuspendLayout();
            this.search_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEmp_pn
            // 
            this.listEmp_pn.Controls.Add(this.show_dgv);
            this.listEmp_pn.Controls.Add(this.btn_pn);
            this.listEmp_pn.Controls.Add(this.search_pn);
            this.listEmp_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEmp_pn.Location = new System.Drawing.Point(0, 0);
            this.listEmp_pn.Name = "listEmp_pn";
            this.listEmp_pn.Size = new System.Drawing.Size(1585, 932);
            this.listEmp_pn.TabIndex = 2;
            // 
            // show_dgv
            // 
            this.show_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_dgv.Location = new System.Drawing.Point(0, 58);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.ReadOnly = true;
            this.show_dgv.RowHeadersWidth = 62;
            this.show_dgv.RowTemplate.Height = 28;
            this.show_dgv.Size = new System.Drawing.Size(1585, 718);
            this.show_dgv.TabIndex = 8;
            this.show_dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.show_dgv_DataError);
            this.show_dgv.DoubleClick += new System.EventHandler(this.show_dgv_DoubleClick);
            // 
            // btn_pn
            // 
            this.btn_pn.Controls.Add(this.check_pn);
            this.btn_pn.Controls.Add(this.print_btn);
            this.btn_pn.Controls.Add(this.refresh_btn);
            this.btn_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_pn.Location = new System.Drawing.Point(0, 776);
            this.btn_pn.Name = "btn_pn";
            this.btn_pn.Size = new System.Drawing.Size(1585, 156);
            this.btn_pn.TabIndex = 7;
            // 
            // check_pn
            // 
            this.check_pn.Controls.Add(this.check_btn);
            this.check_pn.Controls.Add(this.dateOption_gb);
            this.check_pn.Controls.Add(this.female_rBtn);
            this.check_pn.Controls.Add(this.male_rBtn);
            this.check_pn.Controls.Add(this.all_rBtn);
            this.check_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check_pn.Location = new System.Drawing.Point(211, 0);
            this.check_pn.Name = "check_pn";
            this.check_pn.Size = new System.Drawing.Size(1129, 156);
            this.check_pn.TabIndex = 12;
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.Color.Red;
            this.check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_btn.Location = new System.Drawing.Point(943, 14);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(156, 130);
            this.check_btn.TabIndex = 7;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = false;
            // 
            // dateOption_gb
            // 
            this.dateOption_gb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dateOption_gb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dateOption_gb.Controls.Add(this.no_rbtn);
            this.dateOption_gb.Controls.Add(this.yes_rbtn);
            this.dateOption_gb.Controls.Add(this.dateEnd2_dtp);
            this.dateOption_gb.Controls.Add(this.dateEnd1_dtp);
            this.dateOption_gb.Controls.Add(this.label4);
            this.dateOption_gb.Controls.Add(this.label3);
            this.dateOption_gb.Controls.Add(this.label2);
            this.dateOption_gb.Controls.Add(this.label1);
            this.dateOption_gb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dateOption_gb.Location = new System.Drawing.Point(333, 20);
            this.dateOption_gb.Name = "dateOption_gb";
            this.dateOption_gb.Size = new System.Drawing.Size(604, 124);
            this.dateOption_gb.TabIndex = 6;
            this.dateOption_gb.TabStop = false;
            // 
            // no_rbtn
            // 
            this.no_rbtn.AutoSize = true;
            this.no_rbtn.Checked = true;
            this.no_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_rbtn.Location = new System.Drawing.Point(346, 13);
            this.no_rbtn.Name = "no_rbtn";
            this.no_rbtn.Size = new System.Drawing.Size(70, 33);
            this.no_rbtn.TabIndex = 3;
            this.no_rbtn.TabStop = true;
            this.no_rbtn.Text = "No";
            this.no_rbtn.UseVisualStyleBackColor = true;
            // 
            // yes_rbtn
            // 
            this.yes_rbtn.AutoSize = true;
            this.yes_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_rbtn.Location = new System.Drawing.Point(243, 13);
            this.yes_rbtn.Name = "yes_rbtn";
            this.yes_rbtn.Size = new System.Drawing.Size(80, 33);
            this.yes_rbtn.TabIndex = 3;
            this.yes_rbtn.TabStop = true;
            this.yes_rbtn.Text = "Yes";
            this.yes_rbtn.UseVisualStyleBackColor = true;
            // 
            // dateEnd2_dtp
            // 
            this.dateEnd2_dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd2_dtp.CustomFormat = "dd-MMM-yyyy";
            this.dateEnd2_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd2_dtp.Location = new System.Drawing.Point(460, 78);
            this.dateEnd2_dtp.Name = "dateEnd2_dtp";
            this.dateEnd2_dtp.Size = new System.Drawing.Size(112, 26);
            this.dateEnd2_dtp.TabIndex = 1;
            this.dateEnd2_dtp.Value = new System.DateTime(2021, 3, 11, 0, 0, 0, 0);
            // 
            // dateEnd1_dtp
            // 
            this.dateEnd1_dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd1_dtp.CustomFormat = "dd-MMM-yyyy";
            this.dateEnd1_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd1_dtp.Location = new System.Drawing.Point(262, 78);
            this.dateEnd1_dtp.Name = "dateEnd1_dtp";
            this.dateEnd1_dtp.Size = new System.Drawing.Size(112, 26);
            this.dateEnd1_dtp.TabIndex = 2;
            this.dateEnd1_dtp.Value = new System.DateTime(2021, 3, 12, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "And:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Between:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "BirthDay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Date Range:";
            // 
            // female_rBtn
            // 
            this.female_rBtn.AutoSize = true;
            this.female_rBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_rBtn.Location = new System.Drawing.Point(221, 64);
            this.female_rBtn.Name = "female_rBtn";
            this.female_rBtn.Size = new System.Drawing.Size(106, 33);
            this.female_rBtn.TabIndex = 3;
            this.female_rBtn.TabStop = true;
            this.female_rBtn.Text = "Fmale";
            this.female_rBtn.UseVisualStyleBackColor = true;
            // 
            // male_rBtn
            // 
            this.male_rBtn.AutoSize = true;
            this.male_rBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rBtn.Location = new System.Drawing.Point(124, 64);
            this.male_rBtn.Name = "male_rBtn";
            this.male_rBtn.Size = new System.Drawing.Size(91, 33);
            this.male_rBtn.TabIndex = 4;
            this.male_rBtn.TabStop = true;
            this.male_rBtn.Text = "Male";
            this.male_rBtn.UseVisualStyleBackColor = true;
            // 
            // all_rBtn
            // 
            this.all_rBtn.AutoSize = true;
            this.all_rBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.all_rBtn.Checked = true;
            this.all_rBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_rBtn.Location = new System.Drawing.Point(53, 64);
            this.all_rBtn.Name = "all_rBtn";
            this.all_rBtn.Size = new System.Drawing.Size(65, 33);
            this.all_rBtn.TabIndex = 5;
            this.all_rBtn.TabStop = true;
            this.all_rBtn.Text = "All";
            this.all_rBtn.UseVisualStyleBackColor = false;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.print_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.print_btn.FlatAppearance.BorderSize = 0;
            this.print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(1340, 0);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(245, 156);
            this.print_btn.TabIndex = 11;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Blue;
            this.refresh_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(0, 0);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(211, 156);
            this.refresh_btn.TabIndex = 9;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            // 
            // search_pn
            // 
            this.search_pn.Controls.Add(this.search_tb);
            this.search_pn.Controls.Add(this.search_btn);
            this.search_pn.Controls.Add(this.search_lb);
            this.search_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_pn.Location = new System.Drawing.Point(0, 0);
            this.search_pn.Name = "search_pn";
            this.search_pn.Size = new System.Drawing.Size(1585, 58);
            this.search_pn.TabIndex = 1;
            // 
            // search_tb
            // 
            this.search_tb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.ForeColor = System.Drawing.Color.White;
            this.search_tb.Location = new System.Drawing.Point(153, 0);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(1338, 59);
            this.search_tb.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Image = global::HotelAPP.Properties.Resources.icons8_search_client_48;
            this.search_btn.Location = new System.Drawing.Point(1491, 0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(94, 58);
            this.search_btn.TabIndex = 2;
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // search_lb
            // 
            this.search_lb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.search_lb.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lb.ForeColor = System.Drawing.Color.White;
            this.search_lb.Location = new System.Drawing.Point(0, 0);
            this.search_lb.Name = "search_lb";
            this.search_lb.Size = new System.Drawing.Size(153, 58);
            this.search_lb.TabIndex = 1;
            this.search_lb.Text = "Search:";
            this.search_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 932);
            this.Controls.Add(this.listEmp_pn);
            this.Name = "ManageStaffForm";
            this.Text = "Manage Staffs";
            this.Load += new System.EventHandler(this.ManageStaffForm_Load);
            this.listEmp_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            this.btn_pn.ResumeLayout(false);
            this.check_pn.ResumeLayout(false);
            this.check_pn.PerformLayout();
            this.dateOption_gb.ResumeLayout(false);
            this.dateOption_gb.PerformLayout();
            this.search_pn.ResumeLayout(false);
            this.search_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel listEmp_pn;
        private System.Windows.Forms.Panel search_pn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label search_lb;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.DataGridView show_dgv;
        private System.Windows.Forms.Panel btn_pn;
        private System.Windows.Forms.Panel check_pn;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.GroupBox dateOption_gb;
        private System.Windows.Forms.RadioButton no_rbtn;
        private System.Windows.Forms.RadioButton yes_rbtn;
        private System.Windows.Forms.DateTimePicker dateEnd2_dtp;
        private System.Windows.Forms.DateTimePicker dateEnd1_dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton female_rBtn;
        private System.Windows.Forms.RadioButton male_rBtn;
        private System.Windows.Forms.RadioButton all_rBtn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button refresh_btn;
    }
}