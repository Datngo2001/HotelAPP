
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
            this.button_pn = new System.Windows.Forms.Panel();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.listEmp_pn = new System.Windows.Forms.Panel();
            this.show_dgv = new System.Windows.Forms.DataGridView();
            this.listEmp_dgv = new System.Windows.Forms.DataGridView();
            this.search_pn = new System.Windows.Forms.Panel();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_lb = new System.Windows.Forms.Label();
            this.button_pn.SuspendLayout();
            this.listEmp_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEmp_dgv)).BeginInit();
            this.search_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_pn
            // 
            this.button_pn.Controls.Add(this.delete_btn);
            this.button_pn.Controls.Add(this.edit_btn);
            this.button_pn.Controls.Add(this.add_btn);
            this.button_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_pn.Location = new System.Drawing.Point(0, 843);
            this.button_pn.Name = "button_pn";
            this.button_pn.Size = new System.Drawing.Size(1585, 89);
            this.button_pn.TabIndex = 1;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.delete_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(491, 0);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(211, 89);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.edit_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(280, 0);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(211, 89);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
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
            this.add_btn.Size = new System.Drawing.Size(280, 89);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // listEmp_pn
            // 
            this.listEmp_pn.Controls.Add(this.show_dgv);
            this.listEmp_pn.Controls.Add(this.listEmp_dgv);
            this.listEmp_pn.Controls.Add(this.search_pn);
            this.listEmp_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listEmp_pn.Location = new System.Drawing.Point(0, 0);
            this.listEmp_pn.Name = "listEmp_pn";
            this.listEmp_pn.Size = new System.Drawing.Size(1585, 843);
            this.listEmp_pn.TabIndex = 2;
            // 
            // show_dgv
            // 
            this.show_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_dgv.Location = new System.Drawing.Point(0, 58);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.RowHeadersWidth = 62;
            this.show_dgv.RowTemplate.Height = 28;
            this.show_dgv.Size = new System.Drawing.Size(1585, 785);
            this.show_dgv.TabIndex = 3;
            this.show_dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.show_dgv_DataError);
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
            this.listEmp_dgv.Size = new System.Drawing.Size(1585, 785);
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
            this.Controls.Add(this.button_pn);
            this.Name = "ManageStaffForm";
            this.Text = "Manage Staffs";
            this.Load += new System.EventHandler(this.ManageStaffForm_Load);
            this.button_pn.ResumeLayout(false);
            this.listEmp_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEmp_dgv)).EndInit();
            this.search_pn.ResumeLayout(false);
            this.search_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel button_pn;
        private System.Windows.Forms.Panel listEmp_pn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView listEmp_dgv;
        private System.Windows.Forms.Panel search_pn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label search_lb;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.DataGridView show_dgv;
    }
}