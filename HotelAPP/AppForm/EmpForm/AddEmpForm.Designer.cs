
namespace HotelAPP.AppForm.EmpForm
{
    partial class AddEmpForm
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
            this.upload_btn = new System.Windows.Forms.Button();
            this.genderBtn_group = new System.Windows.Forms.GroupBox();
            this.female_rbtn = new System.Windows.Forms.RadioButton();
            this.male_rbtn = new System.Windows.Forms.RadioButton();
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
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.username_lb = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.password_lb = new System.Windows.Forms.Label();
            this.reenter_tb = new System.Windows.Forms.TextBox();
            this.reenter_lb = new System.Windows.Forms.Label();
            this.cmnd_tb = new System.Windows.Forms.TextBox();
            this.cmnd_lb = new System.Windows.Forms.Label();
            this.positon_cb = new System.Windows.Forms.ComboBox();
            this.position_lb = new System.Windows.Forms.Label();
            this.checkCMND_btn = new System.Windows.Forms.Button();
            this.checkPhone_btn = new System.Windows.Forms.Button();
            this.checkUserName_btn = new System.Windows.Forms.Button();
            this.salary_lb = new System.Windows.Forms.Label();
            this.salary_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.id_lb = new System.Windows.Forms.Label();
            this.manager_tb = new System.Windows.Forms.TextBox();
            this.manage_lb = new System.Windows.Forms.Label();
            this.idCheck_btn = new System.Windows.Forms.Button();
            this.managerCheck_btn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.genderBtn_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(888, 514);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(302, 35);
            this.upload_btn.TabIndex = 38;
            this.upload_btn.Text = "Upload Image";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // genderBtn_group
            // 
            this.genderBtn_group.Controls.Add(this.female_rbtn);
            this.genderBtn_group.Controls.Add(this.male_rbtn);
            this.genderBtn_group.Location = new System.Drawing.Point(237, 300);
            this.genderBtn_group.Name = "genderBtn_group";
            this.genderBtn_group.Size = new System.Drawing.Size(302, 67);
            this.genderBtn_group.TabIndex = 37;
            this.genderBtn_group.TabStop = false;
            // 
            // female_rbtn
            // 
            this.female_rbtn.AutoSize = true;
            this.female_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_rbtn.Location = new System.Drawing.Point(163, 21);
            this.female_rbtn.Name = "female_rbtn";
            this.female_rbtn.Size = new System.Drawing.Size(120, 33);
            this.female_rbtn.TabIndex = 1;
            this.female_rbtn.Text = "Female";
            this.female_rbtn.UseVisualStyleBackColor = true;
            // 
            // male_rbtn
            // 
            this.male_rbtn.AutoSize = true;
            this.male_rbtn.Checked = true;
            this.male_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rbtn.Location = new System.Drawing.Point(18, 21);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(91, 33);
            this.male_rbtn.TabIndex = 0;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male";
            this.male_rbtn.UseVisualStyleBackColor = true;
            // 
            // address_rtb
            // 
            this.address_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_rtb.Location = new System.Drawing.Point(235, 479);
            this.address_rtb.Name = "address_rtb";
            this.address_rtb.Size = new System.Drawing.Size(301, 134);
            this.address_rtb.TabIndex = 35;
            this.address_rtb.Text = "";
            // 
            // bdate_picker
            // 
            this.bdate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate_picker.Location = new System.Drawing.Point(235, 233);
            this.bdate_picker.Name = "bdate_picker";
            this.bdate_picker.Size = new System.Drawing.Size(302, 39);
            this.bdate_picker.TabIndex = 34;
            // 
            // phone_tb
            // 
            this.phone_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_tb.Location = new System.Drawing.Point(236, 399);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(302, 39);
            this.phone_tb.TabIndex = 33;
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tb.Location = new System.Drawing.Point(235, 162);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(301, 39);
            this.lname_tb.TabIndex = 32;
            // 
            // fname_tx
            // 
            this.fname_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tx.Location = new System.Drawing.Point(236, 97);
            this.fname_tx.Name = "fname_tx";
            this.fname_tx.Size = new System.Drawing.Size(302, 39);
            this.fname_tx.TabIndex = 31;
            // 
            // picture_lb
            // 
            this.picture_lb.AutoSize = true;
            this.picture_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.picture_lb.Location = new System.Drawing.Point(770, 165);
            this.picture_lb.Name = "picture_lb";
            this.picture_lb.Size = new System.Drawing.Size(112, 32);
            this.picture_lb.TabIndex = 27;
            this.picture_lb.Text = "Picture:";
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(96, 482);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(127, 32);
            this.address_lb.TabIndex = 26;
            this.address_lb.Text = "Address:";
            // 
            // phone_lb
            // 
            this.phone_lb.AutoSize = true;
            this.phone_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lb.Location = new System.Drawing.Point(118, 402);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(106, 32);
            this.phone_lb.TabIndex = 25;
            this.phone_lb.Text = "Phone:";
            // 
            // gender_lb
            // 
            this.gender_lb.AutoSize = true;
            this.gender_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lb.Location = new System.Drawing.Point(107, 320);
            this.gender_lb.Name = "gender_lb";
            this.gender_lb.Size = new System.Drawing.Size(118, 32);
            this.gender_lb.TabIndex = 24;
            this.gender_lb.Text = "Gender:";
            // 
            // birthdate_lb
            // 
            this.birthdate_lb.AutoSize = true;
            this.birthdate_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_lb.Location = new System.Drawing.Point(85, 238);
            this.birthdate_lb.Name = "birthdate_lb";
            this.birthdate_lb.Size = new System.Drawing.Size(142, 32);
            this.birthdate_lb.TabIndex = 23;
            this.birthdate_lb.Text = "BirthDate:";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(68, 165);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(159, 32);
            this.lname_lb.TabIndex = 22;
            this.lname_lb.Text = "Last Name:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(68, 100);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(160, 32);
            this.fname_lb.TabIndex = 21;
            this.fname_lb.Text = "First Name:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(481, 803);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.add_btn.Size = new System.Drawing.Size(280, 92);
            this.add_btn.TabIndex = 39;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(868, 803);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(184, 92);
            this.cancel_btn.TabIndex = 40;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.username_lb.Location = new System.Drawing.Point(729, 581);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(153, 32);
            this.username_lb.TabIndex = 41;
            this.username_lb.Text = "Username:";
            // 
            // username_tb
            // 
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(888, 578);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(302, 39);
            this.username_tb.TabIndex = 42;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(888, 650);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(302, 39);
            this.password_tb.TabIndex = 44;
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password_lb.Location = new System.Drawing.Point(729, 653);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(147, 32);
            this.password_lb.TabIndex = 43;
            this.password_lb.Text = "Password:";
            // 
            // reenter_tb
            // 
            this.reenter_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenter_tb.Location = new System.Drawing.Point(888, 722);
            this.reenter_tb.Name = "reenter_tb";
            this.reenter_tb.PasswordChar = '*';
            this.reenter_tb.Size = new System.Drawing.Size(302, 39);
            this.reenter_tb.TabIndex = 46;
            // 
            // reenter_lb
            // 
            this.reenter_lb.AutoSize = true;
            this.reenter_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.reenter_lb.Location = new System.Drawing.Point(743, 725);
            this.reenter_lb.Name = "reenter_lb";
            this.reenter_lb.Size = new System.Drawing.Size(133, 32);
            this.reenter_lb.TabIndex = 45;
            this.reenter_lb.Text = "Re-enter:";
            // 
            // cmnd_tb
            // 
            this.cmnd_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd_tb.Location = new System.Drawing.Point(235, 640);
            this.cmnd_tb.Name = "cmnd_tb";
            this.cmnd_tb.Size = new System.Drawing.Size(302, 39);
            this.cmnd_tb.TabIndex = 48;
            // 
            // cmnd_lb
            // 
            this.cmnd_lb.AutoSize = true;
            this.cmnd_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd_lb.Location = new System.Drawing.Point(117, 643);
            this.cmnd_lb.Name = "cmnd_lb";
            this.cmnd_lb.Size = new System.Drawing.Size(106, 32);
            this.cmnd_lb.TabIndex = 47;
            this.cmnd_lb.Text = "CMND:";
            // 
            // positon_cb
            // 
            this.positon_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.positon_cb.FormattingEnabled = true;
            this.positon_cb.Location = new System.Drawing.Point(236, 725);
            this.positon_cb.Name = "positon_cb";
            this.positon_cb.Size = new System.Drawing.Size(300, 40);
            this.positon_cb.TabIndex = 49;
            // 
            // position_lb
            // 
            this.position_lb.AutoSize = true;
            this.position_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_lb.Location = new System.Drawing.Point(96, 728);
            this.position_lb.Name = "position_lb";
            this.position_lb.Size = new System.Drawing.Size(126, 32);
            this.position_lb.TabIndex = 50;
            this.position_lb.Text = "Position:";
            // 
            // checkCMND_btn
            // 
            this.checkCMND_btn.Location = new System.Drawing.Point(543, 640);
            this.checkCMND_btn.Name = "checkCMND_btn";
            this.checkCMND_btn.Size = new System.Drawing.Size(96, 39);
            this.checkCMND_btn.TabIndex = 51;
            this.checkCMND_btn.Text = "Check";
            this.checkCMND_btn.UseVisualStyleBackColor = true;
            this.checkCMND_btn.Click += new System.EventHandler(this.checkCMND_btn_Click);
            // 
            // checkPhone_btn
            // 
            this.checkPhone_btn.Location = new System.Drawing.Point(543, 399);
            this.checkPhone_btn.Name = "checkPhone_btn";
            this.checkPhone_btn.Size = new System.Drawing.Size(96, 39);
            this.checkPhone_btn.TabIndex = 51;
            this.checkPhone_btn.Text = "Check";
            this.checkPhone_btn.UseVisualStyleBackColor = true;
            this.checkPhone_btn.Click += new System.EventHandler(this.checkPhone_btn_Click);
            // 
            // checkUserName_btn
            // 
            this.checkUserName_btn.Location = new System.Drawing.Point(1196, 579);
            this.checkUserName_btn.Name = "checkUserName_btn";
            this.checkUserName_btn.Size = new System.Drawing.Size(96, 39);
            this.checkUserName_btn.TabIndex = 51;
            this.checkUserName_btn.Text = "Check";
            this.checkUserName_btn.UseVisualStyleBackColor = true;
            this.checkUserName_btn.Click += new System.EventHandler(this.checkUserName_btn_Click);
            // 
            // salary_lb
            // 
            this.salary_lb.AutoSize = true;
            this.salary_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_lb.Location = new System.Drawing.Point(771, 36);
            this.salary_lb.Name = "salary_lb";
            this.salary_lb.Size = new System.Drawing.Size(104, 32);
            this.salary_lb.TabIndex = 50;
            this.salary_lb.Text = "Salary:";
            // 
            // salary_tb
            // 
            this.salary_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_tb.Location = new System.Drawing.Point(888, 33);
            this.salary_tb.Name = "salary_tb";
            this.salary_tb.Size = new System.Drawing.Size(302, 39);
            this.salary_tb.TabIndex = 48;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(237, 36);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(302, 39);
            this.id_tb.TabIndex = 30;
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.Location = new System.Drawing.Point(172, 40);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(50, 32);
            this.id_lb.TabIndex = 50;
            this.id_lb.Text = "ID:";
            // 
            // manager_tb
            // 
            this.manager_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_tb.Location = new System.Drawing.Point(888, 93);
            this.manager_tb.Name = "manager_tb";
            this.manager_tb.Size = new System.Drawing.Size(302, 39);
            this.manager_tb.TabIndex = 49;
            // 
            // manage_lb
            // 
            this.manage_lb.AutoSize = true;
            this.manage_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_lb.Location = new System.Drawing.Point(706, 96);
            this.manage_lb.Name = "manage_lb";
            this.manage_lb.Size = new System.Drawing.Size(169, 32);
            this.manage_lb.TabIndex = 50;
            this.manage_lb.Text = "Manager ID:";
            // 
            // idCheck_btn
            // 
            this.idCheck_btn.Location = new System.Drawing.Point(545, 36);
            this.idCheck_btn.Name = "idCheck_btn";
            this.idCheck_btn.Size = new System.Drawing.Size(96, 39);
            this.idCheck_btn.TabIndex = 51;
            this.idCheck_btn.Text = "Check";
            this.idCheck_btn.UseVisualStyleBackColor = true;
            this.idCheck_btn.Click += new System.EventHandler(this.idCheck_btn_Click);
            // 
            // managerCheck_btn
            // 
            this.managerCheck_btn.Location = new System.Drawing.Point(1196, 93);
            this.managerCheck_btn.Name = "managerCheck_btn";
            this.managerCheck_btn.Size = new System.Drawing.Size(96, 39);
            this.managerCheck_btn.TabIndex = 51;
            this.managerCheck_btn.Text = "Check";
            this.managerCheck_btn.UseVisualStyleBackColor = true;
            this.managerCheck_btn.Click += new System.EventHandler(this.managerCheck_btn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(888, 162);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(590, 346);
            this.pictureBox.TabIndex = 36;
            this.pictureBox.TabStop = false;
            // 
            // AddEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 932);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.checkPhone_btn);
            this.Controls.Add(this.managerCheck_btn);
            this.Controls.Add(this.checkUserName_btn);
            this.Controls.Add(this.idCheck_btn);
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
            this.Name = "AddEmpForm";
            this.Text = "Add an employee";
            this.Load += new System.EventHandler(this.AddEmpForm_Load);
            this.genderBtn_group.ResumeLayout(false);
            this.genderBtn_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.TextBox reenter_tb;
        private System.Windows.Forms.Label reenter_lb;
        private System.Windows.Forms.TextBox cmnd_tb;
        private System.Windows.Forms.Label cmnd_lb;
        private System.Windows.Forms.ComboBox positon_cb;
        private System.Windows.Forms.Label position_lb;
        private System.Windows.Forms.Button checkCMND_btn;
        private System.Windows.Forms.Button checkPhone_btn;
        private System.Windows.Forms.Button checkUserName_btn;
        private System.Windows.Forms.Label salary_lb;
        private System.Windows.Forms.TextBox salary_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.TextBox manager_tb;
        private System.Windows.Forms.Label manage_lb;
        private System.Windows.Forms.Button idCheck_btn;
        private System.Windows.Forms.Button managerCheck_btn;
    }
}