﻿namespace HotelAPP.AppForm.RoomForm
{
    partial class ManageRoomForm
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
            this.name_tb = new System.Windows.Forms.TextBox();
            this.status_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.status_cb = new System.Windows.Forms.ComboBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.picture_label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.upload_btn = new System.Windows.Forms.Button();
            this.show_dgv = new System.Windows.Forms.DataGridView();
            this.showRoom_btn = new System.Windows.Forms.Button();
            this.showProduct_btn = new System.Windows.Forms.Button();
            this.Order_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.quantity_lb = new System.Windows.Forms.Label();
            this.quantity_tb = new System.Windows.Forms.TextBox();
            this.price_lb = new System.Windows.Forms.Label();
            this.price_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.Location = new System.Drawing.Point(58, 23);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(42, 29);
            this.id_lb.TabIndex = 71;
            this.id_lb.Text = "ID:";
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(116, 23);
            this.id_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(327, 34);
            this.id_tb.TabIndex = 68;
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tb.Location = new System.Drawing.Point(116, 74);
            this.name_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(327, 34);
            this.name_tb.TabIndex = 69;
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lb.Location = new System.Drawing.Point(15, 180);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(85, 29);
            this.status_lb.TabIndex = 67;
            this.status_lb.Text = "Status:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(16, 74);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(84, 29);
            this.fname_lb.TabIndex = 66;
            this.fname_lb.Text = "Name:";
            // 
            // status_cb
            // 
            this.status_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.status_cb.FormattingEnabled = true;
            this.status_cb.Location = new System.Drawing.Point(116, 172);
            this.status_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.status_cb.Name = "status_cb";
            this.status_cb.Size = new System.Drawing.Size(327, 37);
            this.status_cb.TabIndex = 77;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(564, 630);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.delete_btn.Size = new System.Drawing.Size(194, 74);
            this.delete_btn.TabIndex = 84;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(336, 630);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.edit_btn.Size = new System.Drawing.Size(189, 74);
            this.edit_btn.TabIndex = 83;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(1014, 630);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(193, 74);
            this.cancel_btn.TabIndex = 82;
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
            this.add_btn.Location = new System.Drawing.Point(116, 630);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.add_btn.Size = new System.Drawing.Size(188, 74);
            this.add_btn.TabIndex = 81;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // picture_label
            // 
            this.picture_label.AutoSize = true;
            this.picture_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture_label.Location = new System.Drawing.Point(12, 230);
            this.picture_label.Name = "picture_label";
            this.picture_label.Size = new System.Drawing.Size(88, 29);
            this.picture_label.TabIndex = 85;
            this.picture_label.Text = "Picture";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(116, 230);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(327, 315);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 86;
            this.pictureBox.TabStop = false;
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(116, 550);
            this.upload_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(327, 28);
            this.upload_btn.TabIndex = 87;
            this.upload_btn.Text = "Upload Image";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // show_dgv
            // 
            this.show_dgv.AllowUserToAddRows = false;
            this.show_dgv.AllowUserToDeleteRows = false;
            this.show_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Location = new System.Drawing.Point(564, 74);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.ReadOnly = true;
            this.show_dgv.RowHeadersWidth = 51;
            this.show_dgv.RowTemplate.Height = 80;
            this.show_dgv.Size = new System.Drawing.Size(774, 423);
            this.show_dgv.TabIndex = 89;
            this.show_dgv.DoubleClick += new System.EventHandler(this.show_dgv_DoubleClick);
            // 
            // showRoom_btn
            // 
            this.showRoom_btn.Location = new System.Drawing.Point(564, 21);
            this.showRoom_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showRoom_btn.Name = "showRoom_btn";
            this.showRoom_btn.Size = new System.Drawing.Size(182, 36);
            this.showRoom_btn.TabIndex = 90;
            this.showRoom_btn.Text = "Show All Rooms";
            this.showRoom_btn.UseVisualStyleBackColor = true;
            this.showRoom_btn.Click += new System.EventHandler(this.showRoom_btn_Click);
            // 
            // showProduct_btn
            // 
            this.showProduct_btn.Location = new System.Drawing.Point(797, 23);
            this.showProduct_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showProduct_btn.Name = "showProduct_btn";
            this.showProduct_btn.Size = new System.Drawing.Size(184, 34);
            this.showProduct_btn.TabIndex = 91;
            this.showProduct_btn.Text = "Show All Products";
            this.showProduct_btn.UseVisualStyleBackColor = true;
            this.showProduct_btn.Click += new System.EventHandler(this.showProduct_btn_Click);
            // 
            // Order_btn
            // 
            this.Order_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Order_btn.FlatAppearance.BorderSize = 0;
            this.Order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_btn.ForeColor = System.Drawing.Color.White;
            this.Order_btn.Location = new System.Drawing.Point(787, 506);
            this.Order_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Order_btn.Size = new System.Drawing.Size(194, 39);
            this.Order_btn.TabIndex = 92;
            this.Order_btn.Text = "Order";
            this.Order_btn.UseVisualStyleBackColor = false;
            this.Order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.HotPink;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(788, 630);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(193, 74);
            this.clear_btn.TabIndex = 93;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // quantity_lb
            // 
            this.quantity_lb.AutoSize = true;
            this.quantity_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_lb.Location = new System.Drawing.Point(559, 506);
            this.quantity_lb.Name = "quantity_lb";
            this.quantity_lb.Size = new System.Drawing.Size(106, 29);
            this.quantity_lb.TabIndex = 94;
            this.quantity_lb.Text = "Quantity:";
            // 
            // quantity_tb
            // 
            this.quantity_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_tb.Location = new System.Drawing.Point(671, 506);
            this.quantity_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantity_tb.Name = "quantity_tb";
            this.quantity_tb.Size = new System.Drawing.Size(101, 34);
            this.quantity_tb.TabIndex = 95;
            // 
            // price_lb
            // 
            this.price_lb.AutoSize = true;
            this.price_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lb.Location = new System.Drawing.Point(15, 128);
            this.price_lb.Name = "price_lb";
            this.price_lb.Size = new System.Drawing.Size(75, 29);
            this.price_lb.TabIndex = 96;
            this.price_lb.Text = "Price:";
            // 
            // price_tb
            // 
            this.price_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_tb.Location = new System.Drawing.Point(116, 123);
            this.price_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price_tb.Name = "price_tb";
            this.price_tb.Size = new System.Drawing.Size(327, 34);
            this.price_tb.TabIndex = 97;
            // 
            // ManageRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 746);
            this.Controls.Add(this.price_tb);
            this.Controls.Add(this.price_lb);
            this.Controls.Add(this.quantity_tb);
            this.Controls.Add(this.quantity_lb);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.Order_btn);
            this.Controls.Add(this.showProduct_btn);
            this.Controls.Add(this.showRoom_btn);
            this.Controls.Add(this.show_dgv);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.picture_label);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.status_cb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.fname_lb);
            this.Name = "ManageRoomForm";
            this.Text = "ManageRoomForm";
            this.Load += new System.EventHandler(this.ManageRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.ComboBox status_cb;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label picture_label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.DataGridView show_dgv;
        private System.Windows.Forms.Button showRoom_btn;
        private System.Windows.Forms.Button showProduct_btn;
        private System.Windows.Forms.Button Order_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label quantity_lb;
        private System.Windows.Forms.TextBox quantity_tb;
        private System.Windows.Forms.Label price_lb;
        private System.Windows.Forms.TextBox price_tb;
    }
}