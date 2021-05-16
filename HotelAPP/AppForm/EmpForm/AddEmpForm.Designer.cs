
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.address_rtb = new System.Windows.Forms.RichTextBox();
            this.bdate_picker = new System.Windows.Forms.DateTimePicker();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.fname_tx = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.picture_lb = new System.Windows.Forms.Label();
            this.address_lb = new System.Windows.Forms.Label();
            this.phone_lb = new System.Windows.Forms.Label();
            this.gender_lb = new System.Windows.Forms.Label();
            this.birthdate_lb = new System.Windows.Forms.Label();
            this.lname_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.empId_lb = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.genderBtn_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(894, 392);
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
            this.genderBtn_group.Location = new System.Drawing.Point(242, 297);
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
            this.female_rbtn.TabStop = true;
            this.female_rbtn.Text = "Female";
            this.female_rbtn.UseVisualStyleBackColor = true;
            // 
            // male_rbtn
            // 
            this.male_rbtn.AutoSize = true;
            this.male_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rbtn.Location = new System.Drawing.Point(18, 21);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(91, 33);
            this.male_rbtn.TabIndex = 0;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male";
            this.male_rbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(894, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(590, 346);
            this.pictureBox.TabIndex = 36;
            this.pictureBox.TabStop = false;
            // 
            // address_rtb
            // 
            this.address_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_rtb.Location = new System.Drawing.Point(240, 476);
            this.address_rtb.Name = "address_rtb";
            this.address_rtb.Size = new System.Drawing.Size(301, 96);
            this.address_rtb.TabIndex = 35;
            this.address_rtb.Text = "";
            // 
            // bdate_picker
            // 
            this.bdate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate_picker.Location = new System.Drawing.Point(240, 230);
            this.bdate_picker.Name = "bdate_picker";
            this.bdate_picker.Size = new System.Drawing.Size(302, 39);
            this.bdate_picker.TabIndex = 34;
            // 
            // phone_tb
            // 
            this.phone_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_tb.Location = new System.Drawing.Point(241, 396);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(302, 39);
            this.phone_tb.TabIndex = 33;
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tb.Location = new System.Drawing.Point(240, 159);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(301, 39);
            this.lname_tb.TabIndex = 32;
            // 
            // fname_tx
            // 
            this.fname_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tx.Location = new System.Drawing.Point(241, 94);
            this.fname_tx.Name = "fname_tx";
            this.fname_tx.Size = new System.Drawing.Size(302, 39);
            this.fname_tx.TabIndex = 31;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(240, 26);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(302, 39);
            this.id_tb.TabIndex = 30;
            this.id_tb.Text = " ";
            // 
            // picture_lb
            // 
            this.picture_lb.AutoSize = true;
            this.picture_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.picture_lb.Location = new System.Drawing.Point(776, 43);
            this.picture_lb.Name = "picture_lb";
            this.picture_lb.Size = new System.Drawing.Size(112, 32);
            this.picture_lb.TabIndex = 27;
            this.picture_lb.Text = "Picture:";
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(101, 479);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(127, 32);
            this.address_lb.TabIndex = 26;
            this.address_lb.Text = "Address:";
            // 
            // phone_lb
            // 
            this.phone_lb.AutoSize = true;
            this.phone_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lb.Location = new System.Drawing.Point(123, 399);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(106, 32);
            this.phone_lb.TabIndex = 25;
            this.phone_lb.Text = "Phone:";
            // 
            // gender_lb
            // 
            this.gender_lb.AutoSize = true;
            this.gender_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lb.Location = new System.Drawing.Point(112, 317);
            this.gender_lb.Name = "gender_lb";
            this.gender_lb.Size = new System.Drawing.Size(118, 32);
            this.gender_lb.TabIndex = 24;
            this.gender_lb.Text = "Gender:";
            // 
            // birthdate_lb
            // 
            this.birthdate_lb.AutoSize = true;
            this.birthdate_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_lb.Location = new System.Drawing.Point(90, 235);
            this.birthdate_lb.Name = "birthdate_lb";
            this.birthdate_lb.Size = new System.Drawing.Size(142, 32);
            this.birthdate_lb.TabIndex = 23;
            this.birthdate_lb.Text = "BirthDate:";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(73, 162);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(159, 32);
            this.lname_lb.TabIndex = 22;
            this.lname_lb.Text = "Last Name:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(73, 97);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(160, 32);
            this.fname_lb.TabIndex = 21;
            this.fname_lb.Text = "First Name:";
            // 
            // empId_lb
            // 
            this.empId_lb.AutoSize = true;
            this.empId_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId_lb.Location = new System.Drawing.Point(44, 29);
            this.empId_lb.Name = "empId_lb";
            this.empId_lb.Size = new System.Drawing.Size(184, 32);
            this.empId_lb.TabIndex = 20;
            this.empId_lb.Text = "Employee ID:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(0, 0);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.add_btn.Size = new System.Drawing.Size(280, 92);
            this.add_btn.TabIndex = 39;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 840);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 92);
            this.panel1.TabIndex = 40;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.cancel_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(280, 0);
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
            this.username_lb.Location = new System.Drawing.Point(735, 478);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(153, 32);
            this.username_lb.TabIndex = 41;
            this.username_lb.Text = "Username:";
            // 
            // username_tb
            // 
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(894, 475);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(302, 39);
            this.username_tb.TabIndex = 42;
            this.username_tb.Text = " ";
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(894, 547);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(302, 39);
            this.password_tb.TabIndex = 44;
            this.password_tb.Text = " ";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password_lb.Location = new System.Drawing.Point(735, 550);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(147, 32);
            this.password_lb.TabIndex = 43;
            this.password_lb.Text = "Password:";
            // 
            // reenter_tb
            // 
            this.reenter_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenter_tb.Location = new System.Drawing.Point(894, 619);
            this.reenter_tb.Name = "reenter_tb";
            this.reenter_tb.Size = new System.Drawing.Size(302, 39);
            this.reenter_tb.TabIndex = 46;
            this.reenter_tb.Text = " ";
            // 
            // reenter_lb
            // 
            this.reenter_lb.AutoSize = true;
            this.reenter_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.reenter_lb.Location = new System.Drawing.Point(749, 622);
            this.reenter_lb.Name = "reenter_lb";
            this.reenter_lb.Size = new System.Drawing.Size(133, 32);
            this.reenter_lb.TabIndex = 45;
            this.reenter_lb.Text = "Re-enter:";
            // 
            // cmnd_tb
            // 
            this.cmnd_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd_tb.Location = new System.Drawing.Point(240, 609);
            this.cmnd_tb.Name = "cmnd_tb";
            this.cmnd_tb.Size = new System.Drawing.Size(302, 39);
            this.cmnd_tb.TabIndex = 48;
            // 
            // cmnd_lb
            // 
            this.cmnd_lb.AutoSize = true;
            this.cmnd_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd_lb.Location = new System.Drawing.Point(122, 612);
            this.cmnd_lb.Name = "cmnd_lb";
            this.cmnd_lb.Size = new System.Drawing.Size(106, 32);
            this.cmnd_lb.TabIndex = 47;
            this.cmnd_lb.Text = "CMND:";
            // 
            // positon_cb
            // 
            this.positon_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.positon_cb.FormattingEnabled = true;
            this.positon_cb.Location = new System.Drawing.Point(241, 694);
            this.positon_cb.Name = "positon_cb";
            this.positon_cb.Size = new System.Drawing.Size(300, 40);
            this.positon_cb.TabIndex = 49;
            // 
            // position_lb
            // 
            this.position_lb.AutoSize = true;
            this.position_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_lb.Location = new System.Drawing.Point(101, 697);
            this.position_lb.Name = "position_lb";
            this.position_lb.Size = new System.Drawing.Size(126, 32);
            this.position_lb.TabIndex = 50;
            this.position_lb.Text = "Position:";
            // 
            // checkCMND_btn
            // 
            this.checkCMND_btn.Location = new System.Drawing.Point(548, 609);
            this.checkCMND_btn.Name = "checkCMND_btn";
            this.checkCMND_btn.Size = new System.Drawing.Size(96, 39);
            this.checkCMND_btn.TabIndex = 51;
            this.checkCMND_btn.Text = "Check";
            this.checkCMND_btn.UseVisualStyleBackColor = true;
            // 
            // checkPhone_btn
            // 
            this.checkPhone_btn.Location = new System.Drawing.Point(548, 694);
            this.checkPhone_btn.Name = "checkPhone_btn";
            this.checkPhone_btn.Size = new System.Drawing.Size(96, 39);
            this.checkPhone_btn.TabIndex = 51;
            this.checkPhone_btn.Text = "Check";
            this.checkPhone_btn.UseVisualStyleBackColor = true;
            // 
            // checkUserName_btn
            // 
            this.checkUserName_btn.Location = new System.Drawing.Point(1202, 476);
            this.checkUserName_btn.Name = "checkUserName_btn";
            this.checkUserName_btn.Size = new System.Drawing.Size(96, 39);
            this.checkUserName_btn.TabIndex = 51;
            this.checkUserName_btn.Text = "Check";
            this.checkUserName_btn.UseVisualStyleBackColor = true;
            // 
            // AddEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 932);
            this.Controls.Add(this.checkPhone_btn);
            this.Controls.Add(this.checkUserName_btn);
            this.Controls.Add(this.checkCMND_btn);
            this.Controls.Add(this.position_lb);
            this.Controls.Add(this.positon_cb);
            this.Controls.Add(this.cmnd_tb);
            this.Controls.Add(this.cmnd_lb);
            this.Controls.Add(this.reenter_tb);
            this.Controls.Add(this.reenter_lb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.username_lb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.genderBtn_group);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.address_rtb);
            this.Controls.Add(this.bdate_picker);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.fname_tx);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.picture_lb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.phone_lb);
            this.Controls.Add(this.gender_lb);
            this.Controls.Add(this.birthdate_lb);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.fname_lb);
            this.Controls.Add(this.empId_lb);
            this.Name = "AddEmpForm";
            this.Text = "Add an employee";
            this.genderBtn_group.ResumeLayout(false);
            this.genderBtn_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label picture_lb;
        private System.Windows.Forms.Label address_lb;
        private System.Windows.Forms.Label phone_lb;
        private System.Windows.Forms.Label gender_lb;
        private System.Windows.Forms.Label birthdate_lb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Label empId_lb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel1;
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
    }
}