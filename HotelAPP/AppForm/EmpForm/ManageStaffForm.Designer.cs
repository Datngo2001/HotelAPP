
namespace HotelAPP.AppForm.EmpForm
{
    partial class ManageStaffForm
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
            this.listEmp_pn = new System.Windows.Forms.Panel();
            this.show_dgv = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.listEmp_dgv = new System.Windows.Forms.DataGridView();
            this.search_pn = new System.Windows.Forms.Panel();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_lb = new System.Windows.Forms.Label();
            this.listEmp_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEmp_dgv)).BeginInit();
            this.search_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEmp_pn
            // 
            this.listEmp_pn.Controls.Add(this.show_dgv);
            this.listEmp_pn.Controls.Add(this.refresh_btn);
            this.listEmp_pn.Controls.Add(this.listEmp_dgv);
            this.listEmp_pn.Controls.Add(this.search_pn);
            this.listEmp_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEmp_pn.Location = new System.Drawing.Point(0, 0);
            this.listEmp_pn.Name = "listEmp_pn";
            this.listEmp_pn.Size = new System.Drawing.Size(1585, 932);
            this.listEmp_pn.TabIndex = 2;
            // 
            // show_dgv
            // 
            this.show_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_dgv.Location = new System.Drawing.Point(0, 58);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.ReadOnly = true;
            this.show_dgv.RowHeadersWidth = 62;
            this.show_dgv.RowTemplate.Height = 28;
            this.show_dgv.Size = new System.Drawing.Size(1585, 817);
            this.show_dgv.TabIndex = 5;
            this.show_dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.show_dgv_DataError);
            this.show_dgv.DoubleClick += new System.EventHandler(this.show_dgv_DoubleClick);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Blue;
            this.refresh_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(0, 875);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(1585, 57);
            this.refresh_btn.TabIndex = 4;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // listEmp_dgv
            // 
            this.listEmp_dgv.BackgroundColor = System.Drawing.Color.White;
            this.listEmp_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEmp_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEmp_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEmp_dgv.Location = new System.Drawing.Point(0, 58);
            this.listEmp_dgv.Name = "listEmp_dgv";
            this.listEmp_dgv.RowHeadersWidth = 62;
            this.listEmp_dgv.RowTemplate.Height = 28;
            this.listEmp_dgv.Size = new System.Drawing.Size(1585, 874);
            this.listEmp_dgv.TabIndex = 2;
            // 
            // search_pn
            // 
            this.search_pn.Controls.Add(this.search_tb);
            this.search_pn.Controls.Add(this.search_btn);
            this.search_pn.Controls.Add(this.search_lb);
            this.search_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_pn.Location = new System.Drawing.Point(0, 0);
            this.search_pn.Name = "search_pn";
            this.search_pn.Size = new System.Drawing.Size(1585, 58);
            this.search_pn.TabIndex = 1;
            // 
            // search_tb
            // 
            this.search_tb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.ForeColor = System.Drawing.Color.White;
            this.search_tb.Location = new System.Drawing.Point(153, 0);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(1338, 59);
            this.search_tb.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Image = global::HotelAPP.Properties.Resources.icons8_search_client_48;
            this.search_btn.Location = new System.Drawing.Point(1491, 0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(94, 58);
            this.search_btn.TabIndex = 2;
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // search_lb
            // 
            this.search_lb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.search_lb.Dock = System.Windows.Forms.DockStyle.Left;
            this.search_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lb.ForeColor = System.Drawing.Color.White;
            this.search_lb.Location = new System.Drawing.Point(0, 0);
            this.search_lb.Name = "search_lb";
            this.search_lb.Size = new System.Drawing.Size(153, 58);
            this.search_lb.TabIndex = 1;
            this.search_lb.Text = "Search:";
            this.search_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 932);
            this.Controls.Add(this.listEmp_pn);
            this.Name = "ManageStaffForm";
            this.Text = "Manage Staffs";
            this.Load += new System.EventHandler(this.ManageStaffForm_Load);
            this.listEmp_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEmp_dgv)).EndInit();
            this.search_pn.ResumeLayout(false);
            this.search_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel listEmp_pn;
        private System.Windows.Forms.DataGridView listEmp_dgv;
        private System.Windows.Forms.Panel search_pn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label search_lb;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.DataGridView show_dgv;
        private System.Windows.Forms.Button refresh_btn;
    }
}