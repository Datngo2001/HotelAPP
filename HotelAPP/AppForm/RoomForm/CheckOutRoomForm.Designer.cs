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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.checkOut_btn = new System.Windows.Forms.Button();
            this.total_lb = new System.Windows.Forms.Label();
            this.surcharge_lb = new System.Windows.Forms.Label();
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
            this.show_dgv.Size = new System.Drawing.Size(1384, 565);
            this.show_dgv.TabIndex = 0;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(558, 670);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.refresh_btn.Size = new System.Drawing.Size(194, 74);
            this.refresh_btn.TabIndex = 97;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(874, 670);
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
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lb.Location = new System.Drawing.Point(1116, 624);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(74, 29);
            this.total_lb.TabIndex = 99;
            this.total_lb.Text = "Total:";
            // 
            // surcharge_lb
            // 
            this.surcharge_lb.AutoSize = true;
            this.surcharge_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surcharge_lb.Location = new System.Drawing.Point(1060, 580);
            this.surcharge_lb.Name = "surcharge_lb";
            this.surcharge_lb.Size = new System.Drawing.Size(130, 29);
            this.surcharge_lb.TabIndex = 100;
            this.surcharge_lb.Text = "Surcharge:";
            // 
            // CheckOutRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 746);
            this.Controls.Add(this.surcharge_lb);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.checkOut_btn);
            this.Controls.Add(this.show_dgv);
            this.Name = "CheckOutRoomForm";
            this.Text = "CheckOutRoomForm";
            this.Load += new System.EventHandler(this.CheckOutRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView show_dgv;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button checkOut_btn;
        private System.Windows.Forms.Label total_lb;
        private System.Windows.Forms.Label surcharge_lb;
    }
}