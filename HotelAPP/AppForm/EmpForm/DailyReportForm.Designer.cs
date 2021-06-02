
namespace HotelAPP.AppForm.EmpForm
{
    partial class DailyReportForm
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
            this.components = new System.ComponentModel.Container();
            this.time_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.eport_lb = new System.Windows.Forms.Label();
            this.exportTime_lb = new System.Windows.Forms.Label();
            this.split_pn = new System.Windows.Forms.Panel();
            this.title_lb = new System.Windows.Forms.Label();
            this.button_pn = new System.Windows.Forms.Panel();
            this.report_dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.export_btn = new System.Windows.Forms.Button();
            this.button_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_lb
            // 
            this.time_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lb.ForeColor = System.Drawing.Color.Blue;
            this.time_lb.Location = new System.Drawing.Point(921, 90);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(652, 64);
            this.time_lb.TabIndex = 43;
            this.time_lb.Text = "label1";
            // 
            // date_lb
            // 
            this.date_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.date_lb.Location = new System.Drawing.Point(921, 9);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(652, 66);
            this.date_lb.TabIndex = 44;
            this.date_lb.Text = "label1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // eport_lb
            // 
            this.eport_lb.AutoSize = true;
            this.eport_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eport_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.eport_lb.Location = new System.Drawing.Point(12, 9);
            this.eport_lb.Name = "eport_lb";
            this.eport_lb.Size = new System.Drawing.Size(586, 52);
            this.eport_lb.TabIndex = 44;
            this.eport_lb.Text = "Report will automatic print at:";
            // 
            // exportTime_lb
            // 
            this.exportTime_lb.AutoSize = true;
            this.exportTime_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportTime_lb.ForeColor = System.Drawing.Color.Blue;
            this.exportTime_lb.Location = new System.Drawing.Point(12, 88);
            this.exportTime_lb.Name = "exportTime_lb";
            this.exportTime_lb.Size = new System.Drawing.Size(197, 52);
            this.exportTime_lb.TabIndex = 44;
            this.exportTime_lb.Text = "6:30 AM ";
            // 
            // split_pn
            // 
            this.split_pn.BackColor = System.Drawing.Color.Gray;
            this.split_pn.Location = new System.Drawing.Point(789, 9);
            this.split_pn.Name = "split_pn";
            this.split_pn.Size = new System.Drawing.Size(10, 130);
            this.split_pn.TabIndex = 45;
            // 
            // title_lb
            // 
            this.title_lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.title_lb.Location = new System.Drawing.Point(0, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(1585, 76);
            this.title_lb.TabIndex = 46;
            this.title_lb.Text = "Daily Report";
            this.title_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_pn
            // 
            this.button_pn.Controls.Add(this.report_dgv);
            this.button_pn.Controls.Add(this.panel1);
            this.button_pn.Controls.Add(this.title_lb);
            this.button_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_pn.Location = new System.Drawing.Point(0, 157);
            this.button_pn.Name = "button_pn";
            this.button_pn.Size = new System.Drawing.Size(1585, 775);
            this.button_pn.TabIndex = 47;
            // 
            // report_dgv
            // 
            this.report_dgv.AllowUserToAddRows = false;
            this.report_dgv.AllowUserToDeleteRows = false;
            this.report_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.report_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_dgv.Location = new System.Drawing.Point(0, 76);
            this.report_dgv.Name = "report_dgv";
            this.report_dgv.RowHeadersWidth = 62;
            this.report_dgv.RowTemplate.Height = 28;
            this.report_dgv.Size = new System.Drawing.Size(1585, 599);
            this.report_dgv.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.export_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 675);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 100);
            this.panel1.TabIndex = 48;
            // 
            // export_btn
            // 
            this.export_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.export_btn.FlatAppearance.BorderSize = 0;
            this.export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_btn.ForeColor = System.Drawing.Color.White;
            this.export_btn.Location = new System.Drawing.Point(621, 7);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(340, 81);
            this.export_btn.TabIndex = 0;
            this.export_btn.Text = "Export Now";
            this.export_btn.UseVisualStyleBackColor = false;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // DailyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 932);
            this.Controls.Add(this.button_pn);
            this.Controls.Add(this.split_pn);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.exportTime_lb);
            this.Controls.Add(this.eport_lb);
            this.Controls.Add(this.date_lb);
            this.Name = "DailyReportForm";
            this.Text = "Employee Report";
            this.Load += new System.EventHandler(this.DailyReportForm_Load);
            this.button_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.report_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label eport_lb;
        private System.Windows.Forms.Label exportTime_lb;
        private System.Windows.Forms.Panel split_pn;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Panel button_pn;
        private System.Windows.Forms.DataGridView report_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button export_btn;
    }
}