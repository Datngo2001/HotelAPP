namespace HotelAPP.AppForm.RoomForm
{
    partial class CheckOutRoomForm
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
            this.show_dgv = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.checkOut_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // show_dgv
            // 
            this.show_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Location = new System.Drawing.Point(13, 12);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.RowHeadersWidth = 51;
            this.show_dgv.RowTemplate.Height = 80;
            this.show_dgv.Size = new System.Drawing.Size(1384, 638);
            this.show_dgv.TabIndex = 0;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(706, 670);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.refresh_btn.Size = new System.Drawing.Size(194, 74);
            this.refresh_btn.TabIndex = 97;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.print_btn.FlatAppearance.BorderSize = 0;
            this.print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(478, 670);
            this.print_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.print_btn.Name = "print_btn";
            this.print_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.print_btn.Size = new System.Drawing.Size(189, 74);
            this.print_btn.TabIndex = 96;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(938, 670);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(193, 74);
            this.cancel_btn.TabIndex = 95;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // checkOut_btn
            // 
            this.checkOut_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.checkOut_btn.FlatAppearance.BorderSize = 0;
            this.checkOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut_btn.ForeColor = System.Drawing.Color.White;
            this.checkOut_btn.Location = new System.Drawing.Point(258, 670);
            this.checkOut_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkOut_btn.Name = "checkOut_btn";
            this.checkOut_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.checkOut_btn.Size = new System.Drawing.Size(188, 74);
            this.checkOut_btn.TabIndex = 94;
            this.checkOut_btn.Text = "Checkout";
            this.checkOut_btn.UseVisualStyleBackColor = false;
            this.checkOut_btn.Click += new System.EventHandler(this.checkOut_btn_Click);
            // 
            // CheckOutRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 746);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.checkOut_btn);
            this.Controls.Add(this.show_dgv);
            this.Name = "CheckOutRoomForm";
            this.Text = "CheckOutRoomForm";
            this.Load += new System.EventHandler(this.CheckOutRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView show_dgv;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button checkOut_btn;
    }
}