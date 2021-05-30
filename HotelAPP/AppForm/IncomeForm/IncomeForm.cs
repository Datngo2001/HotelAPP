using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAPP.AppForm.TotalForm
{
    public partial class IncomeForm : Form
    {
        Income income;

        public IncomeForm()
        {
            InitializeComponent();
            income = new Income();
        }

        private void showDGV()
        {
            show_dgv.DataSource = income.statistic();
            show_dgv.AllowUserToAddRows = false;
            show_dgv.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)show_dgv.Columns["picture"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void showChart()
        {
            consume_ch.DataSource = income.statistic();
            consume_ch.Series[0].LegendText = "Consumption";
            consume_ch.Series[0].XValueMember = "name";
            consume_ch.Series[0].YValueMembers = "consume";
            consume_ch.Series[0].IsValueShownAsLabel = true;
            consume_ch.Titles.Add("Number of consumption by day");
        }

        private void TotalForm_Load(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            this.showDGV();
            this.showChart();

            income_lb.Text = $"Total Income: {income.total()}";
        }
    }
}
