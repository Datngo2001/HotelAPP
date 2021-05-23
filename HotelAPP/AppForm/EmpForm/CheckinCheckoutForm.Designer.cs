
namespace HotelAPP.AppForm.EmpForm
{
    partial class CheckinCheckoutForm
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
            this.assig_lb = new System.Windows.Forms.Label();
            this.shift_lb = new System.Windows.Forms.Label();
            this.checkin_btn = new System.Windows.Forms.Button();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assig_lb
            // 
            this.assig_lb.AutoSize = true;
            this.assig_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assig_lb.Location = new System.Drawing.Point(130, 96);
            this.assig_lb.Name = "assig_lb";
            this.assig_lb.Size = new System.Drawing.Size(385, 46);
            this.assig_lb.TabIndex = 24;
            this.assig_lb.Text = "You are assigned to:";
            // 
            // shift_lb
            // 
            this.shift_lb.AutoSize = true;
            this.shift_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift_lb.Location = new System.Drawing.Point(492, 176);
            this.shift_lb.Name = "shift_lb";
            this.shift_lb.Size = new System.Drawing.Size(106, 59);
            this.shift_lb.TabIndex = 24;
            this.shift_lb.Text = "Ca ";
            // 
            // checkin_btn
            // 
            this.checkin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.checkin_btn.FlatAppearance.BorderSize = 0;
            this.checkin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkin_btn.ForeColor = System.Drawing.Color.White;
            this.checkin_btn.Location = new System.Drawing.Point(582, 340);
            this.checkin_btn.Name = "checkin_btn";
            this.checkin_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.checkin_btn.Size = new System.Drawing.Size(422, 92);
            this.checkin_btn.TabIndex = 40;
            this.checkin_btn.Text = "Check in";
            this.checkin_btn.UseVisualStyleBackColor = false;
            // 
            // checkout_btn
            // 
            this.checkout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.checkout_btn.FlatAppearance.BorderSize = 0;
            this.checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_btn.ForeColor = System.Drawing.Color.White;
            this.checkout_btn.Location = new System.Drawing.Point(582, 623);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.checkout_btn.Size = new System.Drawing.Size(422, 92);
            this.checkout_btn.TabIndex = 40;
            this.checkout_btn.Text = "Check out";
            this.checkout_btn.UseVisualStyleBackColor = false;
            // 
            // CheckinCheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 932);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.checkin_btn);
            this.Controls.Add(this.shift_lb);
            this.Controls.Add(this.assig_lb);
            this.Name = "CheckinCheckoutForm";
            this.Text = "Check in and Check out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assig_lb;
        private System.Windows.Forms.Label shift_lb;
        private System.Windows.Forms.Button checkin_btn;
        private System.Windows.Forms.Button checkout_btn;
    }
}