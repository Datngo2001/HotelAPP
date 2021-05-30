namespace HotelAPP.AppForm.TotalForm
{
    partial class IncomeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.income_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.consume_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.show_dgv = new System.Windows.Forms.DataGridView();
            this.income_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consume_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // income_btn
            // 
            this.income_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.income_btn.FlatAppearance.BorderSize = 0;
            this.income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_btn.ForeColor = System.Drawing.Color.White;
            this.income_btn.Location = new System.Drawing.Point(369, 661);
            this.income_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.income_btn.Name = "income_btn";
            this.income_btn.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.income_btn.Size = new System.Drawing.Size(213, 74);
            this.income_btn.TabIndex = 84;
            this.income_btn.Text = "Total Income";
            this.income_btn.UseVisualStyleBackColor = false;
            this.income_btn.Click += new System.EventHandler(this.income_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(708, 661);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(213, 74);
            this.cancel_btn.TabIndex = 85;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // consume_ch
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.consume_ch.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.consume_ch.Legends.Add(legend1);
            this.consume_ch.Location = new System.Drawing.Point(12, 12);
            this.consume_ch.Name = "consume_ch";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.consume_ch.Series.Add(series1);
            this.consume_ch.Size = new System.Drawing.Size(646, 610);
            this.consume_ch.TabIndex = 86;
            this.consume_ch.Text = "chart";
            // 
            // show_dgv
            // 
            this.show_dgv.AllowUserToAddRows = false;
            this.show_dgv.AllowUserToDeleteRows = false;
            this.show_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Location = new System.Drawing.Point(664, 12);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.ReadOnly = true;
            this.show_dgv.RowHeadersWidth = 51;
            this.show_dgv.RowTemplate.Height = 80;
            this.show_dgv.Size = new System.Drawing.Size(733, 565);
            this.show_dgv.TabIndex = 90;
            // 
            // income_lb
            // 
            this.income_lb.AutoSize = true;
            this.income_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_lb.Location = new System.Drawing.Point(1070, 591);
            this.income_lb.Name = "income_lb";
            this.income_lb.Size = new System.Drawing.Size(192, 31);
            this.income_lb.TabIndex = 91;
            this.income_lb.Text = "Total Income:";
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 746);
            this.Controls.Add(this.income_lb);
            this.Controls.Add(this.show_dgv);
            this.Controls.Add(this.consume_ch);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.income_btn);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.TotalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consume_ch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button income_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart consume_ch;
        private System.Windows.Forms.DataGridView show_dgv;
        private System.Windows.Forms.Label income_lb;
    }
}