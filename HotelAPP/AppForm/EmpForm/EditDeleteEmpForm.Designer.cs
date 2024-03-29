﻿
namespace HotelAPP.AppForm.EmpForm
{
    partial class EditDeleteEmpForm
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.checkPhone_btn = new System.Windows.Forms.Button();
            this.managerCheck_btn = new System.Windows.Forms.Button();
            this.checkUserName_btn = new System.Windows.Forms.Button();
            this.checkCMND_btn = new System.Windows.Forms.Button();
            this.id_lb = new System.Windows.Forms.Label();
            this.manage_lb = new System.Windows.Forms.Label();
            this.salary_lb = new System.Windows.Forms.Label();
            this.position_lb = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.manager_tb = new System.Windows.Forms.TextBox();
            this.positon_cb = new System.Windows.Forms.ComboBox();
            this.salary_tb = new System.Windows.Forms.TextBox();
            this.cmnd_tb = new System.Windows.Forms.TextBox();
            this.cmnd_lb = new System.Windows.Forms.Label();
            this.reenter_tb = new System.Windows.Forms.TextBox();
            this.reenter_lb = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.password_lb = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.username_lb = new System.Windows.Forms.Label();
            this.upload_btn = new System.Windows.Forms.Button();
            this.genderBtn_group = new System.Windows.Forms.GroupBox();
            this.female_rbtn = new System.Windows.Forms.RadioButton();
            this.male_rbtn = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.address_rtb = new System.Windows.Forms.RichTextBox();
            this.bdate_picker = new System.Windows.Forms.DateTimePicker();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.fname_tx = new System.Windows.Forms.TextBox();
            this.picture_lb = new System.Windows.Forms.Label();
            this.address_lb = new System.Windows.Forms.Label();
            this.phone_lb = new System.Windows.Forms.Label();
            this.gender_lb = new System.Windows.Forms.Label();
            this.birthdate_lb = new System.Windows.Forms.Label();
            this.lname_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.findId_btn = new System.Windows.Forms.Button();
            this.findManager_btn = new System.Windows.Forms.Button();
            this.genderBtn_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(697, 527);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(123, 60);
            this.cancel_btn.TabIndex = 69;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(235, 527);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.edit_btn.Size = new System.Drawing.Size(187, 60);
            this.edit_btn.TabIndex = 68;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // checkPhone_btn
            // 
            this.checkPhone_btn.Location = new System.Drawing.Point(349, 254);
            this.checkPhone_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkPhone_btn.Name = "checkPhone_btn";
            this.checkPhone_btn.Size = new System.Drawing.Size(64, 25);
            this.checkPhone_btn.TabIndex = 89;
            this.checkPhone_btn.Text = "Check";
            this.checkPhone_btn.UseVisualStyleBackColor = true;
            this.checkPhone_btn.Click += new System.EventHandler(this.checkPhone_btn_Click);
            // 
            // managerCheck_btn
            // 
            this.managerCheck_btn.Location = new System.Drawing.Point(785, 55);
            this.managerCheck_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managerCheck_btn.Name = "managerCheck_btn";
            this.managerCheck_btn.Size = new System.Drawing.Size(64, 25);
            this.managerCheck_btn.TabIndex = 88;
            this.managerCheck_btn.Text = "Check";
            this.managerCheck_btn.UseVisualStyleBackColor = true;
            this.managerCheck_btn.Click += new System.EventHandler(this.managerCheck_btn_Click);
            // 
            // checkUserName_btn
            // 
            this.checkUserName_btn.Location = new System.Drawing.Point(785, 371);
            this.checkUserName_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkUserName_btn.Name = "checkUserName_btn";
            this.checkUserName_btn.Size = new System.Drawing.Size(64, 25);
            this.checkUserName_btn.TabIndex = 87;
            this.checkUserName_btn.Text = "Check";
            this.checkUserName_btn.UseVisualStyleBackColor = true;
            this.checkUserName_btn.Click += new System.EventHandler(this.checkUserName_btn_Click);
            // 
            // checkCMND_btn
            // 
            this.checkCMND_btn.Location = new System.Drawing.Point(349, 411);
            this.checkCMND_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkCMND_btn.Name = "checkCMND_btn";
            this.checkCMND_btn.Size = new System.Drawing.Size(64, 25);
            this.checkCMND_btn.TabIndex = 85;
            this.checkCMND_btn.Text = "Check";
            this.checkCMND_btn.UseVisualStyleBackColor = true;
            this.checkCMND_btn.Click += new System.EventHandler(this.checkCMND_btn_Click);
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.Location = new System.Drawing.Point(102, 21);
            this.id_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(32, 24);
            this.id_lb.TabIndex = 83;
            this.id_lb.Text = "ID:";
            // 
            // manage_lb
            // 
            this.manage_lb.AutoSize = true;
            this.manage_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_lb.Location = new System.Drawing.Point(458, 57);
            this.manage_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manage_lb.Name = "manage_lb";
            this.manage_lb.Size = new System.Drawing.Size(112, 24);
            this.manage_lb.TabIndex = 82;
            this.manage_lb.Text = "Manager ID:";
            // 
            // salary_lb
            // 
            this.salary_lb.AutoSize = true;
            this.salary_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_lb.Location = new System.Drawing.Point(501, 18);
            this.salary_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salary_lb.Name = "salary_lb";
            this.salary_lb.Size = new System.Drawing.Size(66, 24);
            this.salary_lb.TabIndex = 81;
            this.salary_lb.Text = "Salary:";
            // 
            // position_lb
            // 
            this.position_lb.AutoSize = true;
            this.position_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_lb.Location = new System.Drawing.Point(51, 468);
            this.position_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position_lb.Name = "position_lb";
            this.position_lb.Size = new System.Drawing.Size(81, 24);
            this.position_lb.TabIndex = 84;
            this.position_lb.Text = "Position:";
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(145, 18);
            this.id_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(203, 29);
            this.id_tb.TabIndex = 59;
            // 
            // manager_tb
            // 
            this.manager_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_tb.Location = new System.Drawing.Point(579, 55);
            this.manager_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manager_tb.Name = "manager_tb";
            this.manager_tb.Size = new System.Drawing.Size(203, 29);
            this.manager_tb.TabIndex = 80;
            // 
            // positon_cb
            // 
            this.positon_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.positon_cb.FormattingEnabled = true;
            this.positon_cb.Location = new System.Drawing.Point(145, 466);
            this.positon_cb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.positon_cb.Name = "positon_cb";
            this.positon_cb.Size = new System.Drawing.Size(201, 32);
            this.positon_cb.TabIndex = 79;
            // 
            // salary_tb
            // 
            this.salary_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_tb.Location = new System.Drawing.Point(579, 16);
            this.salary_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salary_tb.Name = "salary_tb";
            this.salary_tb.Size = new System.Drawing.Size(203, 29);
            this.salary_tb.TabIndex = 78;
            // 
            // cmnd_tb
            // 
            this.cmnd_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd_tb.Location = new System.Drawing.Point(144, 411);
            this.cmnd_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmnd_tb.Name = "cmnd_tb";
            this.cmnd_tb.Size = new System.Drawing.Size(203, 29);
            this.cmnd_tb.TabIndex = 77;
            // 
            // cmnd_lb
            // 
            this.cmnd_lb.AutoSize = true;
            this.cmnd_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd_lb.Location = new System.Drawing.Point(65, 413);
            this.cmnd_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cmnd_lb.Name = "cmnd_lb";
            this.cmnd_lb.Size = new System.Drawing.Size(71, 24);
            this.cmnd_lb.TabIndex = 76;
            this.cmnd_lb.Text = "CMND:";
            // 
            // reenter_tb
            // 
            this.reenter_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenter_tb.Location = new System.Drawing.Point(579, 464);
            this.reenter_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reenter_tb.Name = "reenter_tb";
            this.reenter_tb.PasswordChar = '*';
            this.reenter_tb.Size = new System.Drawing.Size(203, 29);
            this.reenter_tb.TabIndex = 75;
            // 
            // reenter_lb
            // 
            this.reenter_lb.AutoSize = true;
            this.reenter_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.reenter_lb.Location = new System.Drawing.Point(483, 466);
            this.reenter_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reenter_lb.Name = "reenter_lb";
            this.reenter_lb.Size = new System.Drawing.Size(88, 24);
            this.reenter_lb.TabIndex = 74;
            this.reenter_lb.Text = "Re-enter:";
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(579, 417);
            this.password_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(203, 29);
            this.password_tb.TabIndex = 73;
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password_lb.Location = new System.Drawing.Point(473, 419);
            this.password_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(97, 24);
            this.password_lb.TabIndex = 72;
            this.password_lb.Text = "Password:";
            // 
            // username_tb
            // 
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(579, 370);
            this.username_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(203, 29);
            this.username_tb.TabIndex = 71;
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.username_lb.Location = new System.Drawing.Point(473, 372);
            this.username_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(102, 24);
            this.username_lb.TabIndex = 70;
            this.username_lb.Text = "Username:";
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(579, 329);
            this.upload_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(201, 23);
            this.upload_btn.TabIndex = 67;
            this.upload_btn.Text = "Upload Image";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // genderBtn_group
            // 
            this.genderBtn_group.Controls.Add(this.female_rbtn);
            this.genderBtn_group.Controls.Add(this.male_rbtn);
            this.genderBtn_group.Location = new System.Drawing.Point(145, 190);
            this.genderBtn_group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderBtn_group.Name = "genderBtn_group";
            this.genderBtn_group.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderBtn_group.Size = new System.Drawing.Size(201, 44);
            this.genderBtn_group.TabIndex = 66;
            this.genderBtn_group.TabStop = false;
            // 
            // female_rbtn
            // 
            this.female_rbtn.AutoSize = true;
            this.female_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_rbtn.Location = new System.Drawing.Point(109, 14);
            this.female_rbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.female_rbtn.Name = "female_rbtn";
            this.female_rbtn.Size = new System.Drawing.Size(80, 24);
            this.female_rbtn.TabIndex = 1;
            this.female_rbtn.Text = "Female";
            this.female_rbtn.UseVisualStyleBackColor = true;
            // 
            // male_rbtn
            // 
            this.male_rbtn.AutoSize = true;
            this.male_rbtn.Checked = true;
            this.male_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rbtn.Location = new System.Drawing.Point(12, 14);
            this.male_rbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(61, 24);
            this.male_rbtn.TabIndex = 0;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male";
            this.male_rbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(579, 100);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(393, 225);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 65;
            this.pictureBox.TabStop = false;
            // 
            // address_rtb
            // 
            this.address_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_rtb.Location = new System.Drawing.Point(144, 306);
            this.address_rtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.address_rtb.Name = "address_rtb";
            this.address_rtb.Size = new System.Drawing.Size(202, 88);
            this.address_rtb.TabIndex = 64;
            this.address_rtb.Text = "";
            // 
            // bdate_picker
            // 
            this.bdate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate_picker.Location = new System.Drawing.Point(144, 146);
            this.bdate_picker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bdate_picker.Name = "bdate_picker";
            this.bdate_picker.Size = new System.Drawing.Size(203, 29);
            this.bdate_picker.TabIndex = 63;
            // 
            // phone_tb
            // 
            this.phone_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_tb.Location = new System.Drawing.Point(145, 254);
            this.phone_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(203, 29);
            this.phone_tb.TabIndex = 62;
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tb.Location = new System.Drawing.Point(144, 100);
            this.lname_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(202, 29);
            this.lname_tb.TabIndex = 61;
            // 
            // fname_tx
            // 
            this.fname_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tx.Location = new System.Drawing.Point(145, 58);
            this.fname_tx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fname_tx.Name = "fname_tx";
            this.fname_tx.Size = new System.Drawing.Size(203, 29);
            this.fname_tx.TabIndex = 60;
            // 
            // picture_lb
            // 
            this.picture_lb.AutoSize = true;
            this.picture_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.picture_lb.Location = new System.Drawing.Point(501, 102);
            this.picture_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.picture_lb.Name = "picture_lb";
            this.picture_lb.Size = new System.Drawing.Size(73, 24);
            this.picture_lb.TabIndex = 58;
            this.picture_lb.Text = "Picture:";
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(51, 308);
            this.address_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(85, 24);
            this.address_lb.TabIndex = 57;
            this.address_lb.Text = "Address:";
            // 
            // phone_lb
            // 
            this.phone_lb.AutoSize = true;
            this.phone_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lb.Location = new System.Drawing.Point(66, 256);
            this.phone_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(71, 24);
            this.phone_lb.TabIndex = 56;
            this.phone_lb.Text = "Phone:";
            // 
            // gender_lb
            // 
            this.gender_lb.AutoSize = true;
            this.gender_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lb.Location = new System.Drawing.Point(59, 203);
            this.gender_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender_lb.Name = "gender_lb";
            this.gender_lb.Size = new System.Drawing.Size(79, 24);
            this.gender_lb.TabIndex = 55;
            this.gender_lb.Text = "Gender:";
            // 
            // birthdate_lb
            // 
            this.birthdate_lb.AutoSize = true;
            this.birthdate_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_lb.Location = new System.Drawing.Point(44, 149);
            this.birthdate_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdate_lb.Name = "birthdate_lb";
            this.birthdate_lb.Size = new System.Drawing.Size(90, 24);
            this.birthdate_lb.TabIndex = 54;
            this.birthdate_lb.Text = "BirthDate:";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(33, 102);
            this.lname_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(104, 24);
            this.lname_lb.TabIndex = 53;
            this.lname_lb.Text = "Last Name:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(33, 60);
            this.fname_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(106, 24);
            this.fname_lb.TabIndex = 52;
            this.fname_lb.Text = "First Name:";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(467, 527);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.delete_btn.Size = new System.Drawing.Size(187, 60);
            this.delete_btn.TabIndex = 68;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // findId_btn
            // 
            this.findId_btn.Location = new System.Drawing.Point(349, 18);
            this.findId_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findId_btn.Name = "findId_btn";
            this.findId_btn.Size = new System.Drawing.Size(64, 25);
            this.findId_btn.TabIndex = 89;
            this.findId_btn.Text = "Find";
            this.findId_btn.UseVisualStyleBackColor = true;
            this.findId_btn.Click += new System.EventHandler(this.findId_btn_Click);
            // 
            // findManager_btn
            // 
            this.findManager_btn.Location = new System.Drawing.Point(853, 55);
            this.findManager_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findManager_btn.Name = "findManager_btn";
            this.findManager_btn.Size = new System.Drawing.Size(64, 25);
            this.findManager_btn.TabIndex = 88;
            this.findManager_btn.Text = "Find";
            this.findManager_btn.UseVisualStyleBackColor = true;
            this.findManager_btn.Click += new System.EventHandler(this.managerCheck_btn_Click);
            // 
            // EditDeleteEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 615);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.findId_btn);
            this.Controls.Add(this.checkPhone_btn);
            this.Controls.Add(this.findManager_btn);
            this.Controls.Add(this.managerCheck_btn);
            this.Controls.Add(this.checkUserName_btn);
            this.Controls.Add(this.checkCMND_btn);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.manage_lb);
            this.Controls.Add(this.salary_lb);
            this.Controls.Add(this.position_lb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.manager_tb);
            this.Controls.Add(this.positon_cb);
            this.Controls.Add(this.salary_tb);
            this.Controls.Add(this.cmnd_tb);
            this.Controls.Add(this.cmnd_lb);
            this.Controls.Add(this.reenter_tb);
            this.Controls.Add(this.reenter_lb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.username_lb);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.genderBtn_group);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.address_rtb);
            this.Controls.Add(this.bdate_picker);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.fname_tx);
            this.Controls.Add(this.picture_lb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.phone_lb);
            this.Controls.Add(this.gender_lb);
            this.Controls.Add(this.birthdate_lb);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.fname_lb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditDeleteEmpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Delete Employee";
            this.Load += new System.EventHandler(this.EditDeleteEmpForm_Load);
            this.genderBtn_group.ResumeLayout(false);
            this.genderBtn_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button checkPhone_btn;
        private System.Windows.Forms.Button managerCheck_btn;
        private System.Windows.Forms.Button checkUserName_btn;
        private System.Windows.Forms.Button checkCMND_btn;
        private System.Windows.Forms.Label manage_lb;
        private System.Windows.Forms.Label salary_lb;
        private System.Windows.Forms.Label position_lb;
        private System.Windows.Forms.TextBox manager_tb;
        private System.Windows.Forms.ComboBox positon_cb;
        private System.Windows.Forms.TextBox salary_tb;
        private System.Windows.Forms.TextBox cmnd_tb;
        private System.Windows.Forms.Label cmnd_lb;
        private System.Windows.Forms.TextBox reenter_tb;
        private System.Windows.Forms.Label reenter_lb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.GroupBox genderBtn_group;
        private System.Windows.Forms.RadioButton female_rbtn;
        private System.Windows.Forms.RadioButton male_rbtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox address_rtb;
        private System.Windows.Forms.DateTimePicker bdate_picker;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.TextBox fname_tx;
        private System.Windows.Forms.Label picture_lb;
        private System.Windows.Forms.Label address_lb;
        private System.Windows.Forms.Label phone_lb;
        private System.Windows.Forms.Label gender_lb;
        private System.Windows.Forms.Label birthdate_lb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Button findManager_btn;
        public System.Windows.Forms.Label id_lb;
        public System.Windows.Forms.TextBox id_tb;
        public System.Windows.Forms.Button delete_btn;
        public System.Windows.Forms.Button findId_btn;
    }
}