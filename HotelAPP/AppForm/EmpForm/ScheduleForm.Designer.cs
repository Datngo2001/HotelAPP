
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
            this.print_btn = new System.Windows.Forms.Button();
            this.begin_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shit1_lb = new System.Windows.Forms.Label();
            this.schedule_dgv = new System.Windows.Forms.DataGridView();
            this.shift3_lb = new System.Windows.Forms.Label();
            this.shift2_lb = new System.Windows.Forms.Label();
            this.swap_btn = new System.Windows.Forms.Button();
            this.button_pn.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button_pn
            // 
            this.button_pn.Controls.Add(this.swap_btn);
            this.button_pn.Controls.Add(this.print_btn);
            this.button_pn.Controls.Add(this.begin_btn);
            this.button_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_pn.Location = new System.Drawing.Point(0, 817);
            this.button_pn.Name = "button_pn";
            this.button_pn.Size = new System.Drawing.Size(1585, 115);
            this.button_pn.TabIndex = 0;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.print_btn.FlatAppearance.BorderSize = 0;
            this.print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(366, 11);
            this.print_btn.Name = "print_btn";
            this.print_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.print_btn.Size = new System.Drawing.Size(280, 92);
            this.print_btn.TabIndex = 41;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // begin_btn
            // 
            this.begin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.begin_btn.FlatAppearance.BorderSize = 0;
            this.begin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.begin_btn.ForeColor = System.Drawing.Color.White;
            this.begin_btn.Location = new System.Drawing.Point(7, 11);
            this.begin_btn.Name = "begin_btn";
            this.begin_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.begin_btn.Size = new System.Drawing.Size(353, 92);
            this.begin_btn.TabIndex = 40;
            this.begin_btn.Text = "Begin scheduling";
            this.begin_btn.UseVisualStyleBackColor = false;
            this.begin_btn.Click += new System.EventHandler(this.begin_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shift2_lb);
            this.panel1.Controls.Add(this.shift3_lb);
            this.panel1.Controls.Add(this.shit1_lb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 71);
            this.panel1.TabIndex = 2;
            // 
            // shit1_lb
            // 
            this.shit1_lb.Dock = System.Windows.Forms.DockStyle.Left;
            this.shit1_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shit1_lb.Location = new System.Drawing.Point(0, 0);
            this.shit1_lb.Name = "shit1_lb";
            this.shit1_lb.Size = new System.Drawing.Size(526, 71);
            this.shit1_lb.TabIndex = 0;
            this.shit1_lb.Text = "Shift 1: 7h - 15h";
            this.shit1_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schedule_dgv
            // 
            this.schedule_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.schedule_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedule_dgv.Location = new System.Drawing.Point(0, 71);
            this.schedule_dgv.Name = "schedule_dgv";
            this.schedule_dgv.ReadOnly = true;
            this.schedule_dgv.RowHeadersWidth = 62;
            this.schedule_dgv.RowTemplate.Height = 28;
            this.schedule_dgv.Size = new System.Drawing.Size(1585, 746);
            this.schedule_dgv.TabIndex = 3;
            // 
            // shift3_lb
            // 
            this.shift3_lb.Dock = System.Windows.Forms.DockStyle.Right;
            this.shift3_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.shift3_lb.Location = new System.Drawing.Point(1034, 0);
            this.shift3_lb.Name = "shift3_lb";
            this.shift3_lb.Size = new System.Drawing.Size(551, 71);
            this.shift3_lb.TabIndex = 1;
            this.shift3_lb.Text = "Shift 3: 23h - 6h";
            this.shift3_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shift2_lb
            // 
            this.shift2_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shift2_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift2_lb.Location = new System.Drawing.Point(526, 0);
            this.shift2_lb.Name = "shift2_lb";
            this.shift2_lb.Size = new System.Drawing.Size(508, 71);
            this.shift2_lb.TabIndex = 2;
            this.shift2_lb.Text = "Shift 2: 15h - 23h";
            this.shift2_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // swap_btn
            // 
            this.swap_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.swap_btn.FlatAppearance.BorderSize = 0;
            this.swap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swap_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swap_btn.ForeColor = System.Drawing.Color.White;
            this.swap_btn.Location = new System.Drawing.Point(754, 11);
            this.swap_btn.Name = "swap_btn";
            this.swap_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.swap_btn.Size = new System.Drawing.Size(199, 92);
            this.swap_btn.TabIndex = 41;
            this.swap_btn.Text = "Swap";
            this.swap_btn.UseVisualStyleBackColor = false;
            this.swap_btn.Click += new System.EventHandler(this.swap_btn_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 932);
            this.Controls.Add(this.schedule_dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_pn);
            this.Name = "ScheduleForm";
            this.Text = "Employee Schedule";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.button_pn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedule_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel button_pn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button begin_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shit1_lb;
        private System.Windows.Forms.DataGridView schedule_dgv;
        private System.Windows.Forms.Label shift2_lb;
        private System.Windows.Forms.Label shift3_lb;
        private System.Windows.Forms.Button swap_btn;
    }
}