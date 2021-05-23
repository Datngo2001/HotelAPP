
namespace HotelAPP.AppForm.EmpForm
{
    partial class ScheduleForm
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
            this.button_pn = new System.Windows.Forms.Panel();
            this.schedule_dgv = new System.Windows.Forms.DataGridView();
            this.begin_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.button_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button_pn
            // 
            this.button_pn.Controls.Add(this.print_btn);
            this.button_pn.Controls.Add(this.begin_btn);
            this.button_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_pn.Location = new System.Drawing.Point(0, 817);
            this.button_pn.Name = "button_pn";
            this.button_pn.Size = new System.Drawing.Size(1585, 115);
            this.button_pn.TabIndex = 0;
            // 
            // schedule_dgv
            // 
            this.schedule_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedule_dgv.Location = new System.Drawing.Point(0, 0);
            this.schedule_dgv.Name = "schedule_dgv";
            this.schedule_dgv.RowHeadersWidth = 62;
            this.schedule_dgv.RowTemplate.Height = 28;
            this.schedule_dgv.Size = new System.Drawing.Size(1585, 817);
            this.schedule_dgv.TabIndex = 1;
            // 
            // begin_btn
            // 
            this.begin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.begin_btn.FlatAppearance.BorderSize = 0;
            this.begin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.begin_btn.ForeColor = System.Drawing.Color.White;
            this.begin_btn.Location = new System.Drawing.Point(424, 11);
            this.begin_btn.Name = "begin_btn";
            this.begin_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.begin_btn.Size = new System.Drawing.Size(353, 92);
            this.begin_btn.TabIndex = 40;
            this.begin_btn.Text = "Begin scheduling";
            this.begin_btn.UseVisualStyleBackColor = false;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.print_btn.FlatAppearance.BorderSize = 0;
            this.print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(897, 11);
            this.print_btn.Name = "print_btn";
            this.print_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.print_btn.Size = new System.Drawing.Size(280, 92);
            this.print_btn.TabIndex = 41;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 932);
            this.Controls.Add(this.schedule_dgv);
            this.Controls.Add(this.button_pn);
            this.Name = "ScheduleForm";
            this.Text = "Employee Schedule";
            this.button_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedule_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel button_pn;
        private System.Windows.Forms.DataGridView schedule_dgv;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button begin_btn;
    }
}