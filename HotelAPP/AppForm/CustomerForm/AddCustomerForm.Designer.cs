namespace HotelAPP.AppForm.CustomerForm
{
    partial class AddCustomerForm
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
            this.id_lb = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.genderBtn_group = new System.Windows.Forms.GroupBox();
            this.female_rbtn = new System.Windows.Forms.RadioButton();
            this.male_rbtn = new System.Windows.Forms.RadioButton();
            this.address_rtb = new System.Windows.Forms.RichTextBox();
            this.bdate_picker = new System.Windows.Forms.DateTimePicker();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.address_lb = new System.Windows.Forms.Label();
            this.phone_lb = new System.Windows.Forms.Label();
            this.gender_lb = new System.Windows.Forms.Label();
            this.birthdate_lb = new System.Windows.Forms.Label();
            this.lname_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dayOut_lb = new System.Windows.Forms.Label();
            this.dayIn_lb = new System.Windows.Forms.Label();
            this.roomID_cb = new System.Windows.Forms.ComboBox();
            this.roomID_lb = new System.Windows.Forms.Label();
            this.show_dgv = new System.Windows.Forms.DataGridView();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dayIn_picker = new System.Windows.Forms.DateTimePicker();
            this.dayOut_picker = new System.Windows.Forms.DateTimePicker();
            this.showCustomer_btn = new System.Windows.Forms.Button();
            this.showRoom_btn = new System.Windows.Forms.Button();
            this.genderBtn_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.Location = new System.Drawing.Point(113, 24);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(42, 29);
            this.id_lb.TabIndex = 65;
            this.id_lb.Text = "ID:";
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(169, 19);
            this.id_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(270, 34);
            this.id_tb.TabIndex = 58;
            // 
            // genderBtn_group
            // 
            this.genderBtn_group.Controls.Add(this.female_rbtn);
            this.genderBtn_group.Controls.Add(this.male_rbtn);
            this.genderBtn_group.Location = new System.Drawing.Point(171, 232);
            this.genderBtn_group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderBtn_group.Name = "genderBtn_group";
            this.genderBtn_group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderBtn_group.Size = new System.Drawing.Size(268, 54);
            this.genderBtn_group.TabIndex = 64;
            this.genderBtn_group.TabStop = false;
            // 
            // female_rbtn
            // 
            this.female_rbtn.AutoSize = true;
            this.female_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_rbtn.Location = new System.Drawing.Point(145, 17);
            this.female_rbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.female_rbtn.Name = "female_rbtn";
            this.female_rbtn.Size = new System.Drawing.Size(98, 29);
            this.female_rbtn.TabIndex = 1;
            this.female_rbtn.Text = "Female";
            this.female_rbtn.UseVisualStyleBackColor = true;
            // 
            // male_rbtn
            // 
            this.male_rbtn.AutoSize = true;
            this.male_rbtn.Checked = true;
            this.male_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rbtn.Location = new System.Drawing.Point(16, 17);
            this.male_rbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(76, 29);
            this.male_rbtn.TabIndex = 0;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male";
            this.male_rbtn.UseVisualStyleBackColor = true;
            // 
            // address_rtb
            // 
            this.address_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_rtb.Location = new System.Drawing.Point(169, 375);
            this.address_rtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_rtb.Name = "address_rtb";
            this.address_rtb.Size = new System.Drawing.Size(268, 108);
            this.address_rtb.TabIndex = 63;
            this.address_rtb.Text = "";
            // 
            // bdate_picker
            // 
            this.bdate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate_picker.Location = new System.Drawing.Point(169, 178);
            this.bdate_picker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bdate_picker.Name = "bdate_picker";
            this.bdate_picker.Size = new System.Drawing.Size(269, 34);
            this.bdate_picker.TabIndex = 62;
            // 
            // phone_tb
            // 
            this.phone_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_tb.Location = new System.Drawing.Point(170, 311);
            this.phone_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(269, 34);
            this.phone_tb.TabIndex = 61;
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tb.Location = new System.Drawing.Point(169, 122);
            this.lname_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(268, 34);
            this.lname_tb.TabIndex = 60;
            // 
            // fname_tb
            // 
            this.fname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tb.Location = new System.Drawing.Point(170, 70);
            this.fname_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.Size = new System.Drawing.Size(269, 34);
            this.fname_tb.TabIndex = 59;
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(45, 378);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(108, 29);
            this.address_lb.TabIndex = 57;
            this.address_lb.Text = "Address:";
            // 
            // phone_lb
            // 
            this.phone_lb.AutoSize = true;
            this.phone_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lb.Location = new System.Drawing.Point(65, 314);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(89, 29);
            this.phone_lb.TabIndex = 56;
            this.phone_lb.Text = "Phone:";
            // 
            // gender_lb
            // 
            this.gender_lb.AutoSize = true;
            this.gender_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lb.Location = new System.Drawing.Point(55, 248);
            this.gender_lb.Name = "gender_lb";
            this.gender_lb.Size = new System.Drawing.Size(100, 29);
            this.gender_lb.TabIndex = 55;
            this.gender_lb.Text = "Gender:";
            // 
            // birthdate_lb
            // 
            this.birthdate_lb.AutoSize = true;
            this.birthdate_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_lb.Location = new System.Drawing.Point(36, 182);
            this.birthdate_lb.Name = "birthdate_lb";
            this.birthdate_lb.Size = new System.Drawing.Size(118, 29);
            this.birthdate_lb.TabIndex = 54;
            this.birthdate_lb.Text = "BirthDate:";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(20, 124);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(134, 29);
            this.lname_lb.TabIndex = 53;
            this.lname_lb.Text = "Last Name:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(20, 72);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(137, 29);
            this.fname_lb.TabIndex = 52;
            this.fname_lb.Text = "First Name:";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(894, 654);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(193, 74);
            this.cancel_btn.TabIndex = 69;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(118, 654);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.add_btn.Size = new System.Drawing.Size(188, 74);
            this.add_btn.TabIndex = 68;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dayOut_lb
            // 
            this.dayOut_lb.AutoSize = true;
            this.dayOut_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dayOut_lb.Location = new System.Drawing.Point(622, 560);
            this.dayOut_lb.Name = "dayOut_lb";
            this.dayOut_lb.Size = new System.Drawing.Size(104, 29);
            this.dayOut_lb.TabIndex = 72;
            this.dayOut_lb.Text = "Day Out:";
            // 
            // dayIn_lb
            // 
            this.dayIn_lb.AutoSize = true;
            this.dayIn_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dayIn_lb.Location = new System.Drawing.Point(622, 505);
            this.dayIn_lb.Name = "dayIn_lb";
            this.dayIn_lb.Size = new System.Drawing.Size(85, 29);
            this.dayIn_lb.TabIndex = 70;
            this.dayIn_lb.Text = "Day In:";
            // 
            // roomID_cb
            // 
            this.roomID_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.roomID_cb.FormattingEnabled = true;
            this.roomID_cb.Location = new System.Drawing.Point(171, 502);
            this.roomID_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomID_cb.Name = "roomID_cb";
            this.roomID_cb.Size = new System.Drawing.Size(267, 37);
            this.roomID_cb.TabIndex = 76;
            // 
            // roomID_lb
            // 
            this.roomID_lb.AutoSize = true;
            this.roomID_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomID_lb.Location = new System.Drawing.Point(45, 502);
            this.roomID_lb.Name = "roomID_lb";
            this.roomID_lb.Size = new System.Drawing.Size(113, 29);
            this.roomID_lb.TabIndex = 77;
            this.roomID_lb.Text = "Room ID:";
            // 
            // show_dgv
            // 
            this.show_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Location = new System.Drawing.Point(627, 70);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.RowHeadersWidth = 51;
            this.show_dgv.RowTemplate.Height = 24;
            this.show_dgv.Size = new System.Drawing.Size(770, 413);
            this.show_dgv.TabIndex = 78;
            this.show_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_dgv_CellDoubleClick);
            this.show_dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.listCustomerRoom_dgv_DataError);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(376, 654);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.edit_btn.Size = new System.Drawing.Size(189, 74);
            this.edit_btn.TabIndex = 79;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(627, 654);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.delete_btn.Size = new System.Drawing.Size(194, 74);
            this.delete_btn.TabIndex = 80;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dayIn_picker
            // 
            this.dayIn_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayIn_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayIn_picker.Location = new System.Drawing.Point(741, 505);
            this.dayIn_picker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayIn_picker.Name = "dayIn_picker";
            this.dayIn_picker.Size = new System.Drawing.Size(269, 34);
            this.dayIn_picker.TabIndex = 81;
            // 
            // dayOut_picker
            // 
            this.dayOut_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOut_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayOut_picker.Location = new System.Drawing.Point(741, 555);
            this.dayOut_picker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayOut_picker.Name = "dayOut_picker";
            this.dayOut_picker.Size = new System.Drawing.Size(269, 34);
            this.dayOut_picker.TabIndex = 82;
            // 
            // showCustomer_btn
            // 
            this.showCustomer_btn.Location = new System.Drawing.Point(627, 19);
            this.showCustomer_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showCustomer_btn.Name = "showCustomer_btn";
            this.showCustomer_btn.Size = new System.Drawing.Size(174, 32);
            this.showCustomer_btn.TabIndex = 83;
            this.showCustomer_btn.Text = "Show All Customers";
            this.showCustomer_btn.UseVisualStyleBackColor = true;
            this.showCustomer_btn.Click += new System.EventHandler(this.showCust_btn_Click);
            // 
            // showRoom_btn
            // 
            this.showRoom_btn.Location = new System.Drawing.Point(876, 19);
            this.showRoom_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showRoom_btn.Name = "showRoom_btn";
            this.showRoom_btn.Size = new System.Drawing.Size(174, 32);
            this.showRoom_btn.TabIndex = 84;
            this.showRoom_btn.Text = "Show All Rooms";
            this.showRoom_btn.UseVisualStyleBackColor = true;
            this.showRoom_btn.Click += new System.EventHandler(this.showRoom_btn_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 746);
            this.Controls.Add(this.showRoom_btn);
            this.Controls.Add(this.showCustomer_btn);
            this.Controls.Add(this.dayOut_picker);
            this.Controls.Add(this.dayIn_picker);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.show_dgv);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.roomID_lb);
            this.Controls.Add(this.roomID_cb);
            this.Controls.Add(this.dayOut_lb);
            this.Controls.Add(this.dayIn_lb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.genderBtn_group);
            this.Controls.Add(this.address_rtb);
            this.Controls.Add(this.bdate_picker);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.fname_tb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.phone_lb);
            this.Controls.Add(this.gender_lb);
            this.Controls.Add(this.birthdate_lb);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.fname_lb);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.genderBtn_group.ResumeLayout(false);
            this.genderBtn_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.GroupBox genderBtn_group;
        private System.Windows.Forms.RadioButton female_rbtn;
        private System.Windows.Forms.RadioButton male_rbtn;
        private System.Windows.Forms.RichTextBox address_rtb;
        private System.Windows.Forms.DateTimePicker bdate_picker;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.Label address_lb;
        private System.Windows.Forms.Label phone_lb;
        private System.Windows.Forms.Label gender_lb;
        private System.Windows.Forms.Label birthdate_lb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label dayOut_lb;
        private System.Windows.Forms.Label dayIn_lb;
        private System.Windows.Forms.ComboBox roomID_cb;
        private System.Windows.Forms.Label roomID_lb;
        private System.Windows.Forms.DataGridView show_dgv;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DateTimePicker dayIn_picker;
        private System.Windows.Forms.DateTimePicker dayOut_picker;
        private System.Windows.Forms.Button showCustomer_btn;
        private System.Windows.Forms.Button showRoom_btn;
    }
}