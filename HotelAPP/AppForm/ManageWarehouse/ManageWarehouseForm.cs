using HotelAPP.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAPP.AppForm.ManageWarehouse
{
    public partial class ManageWarehouseForm : Form
    {
        Product product;

        public ManageWarehouseForm()
        {
            InitializeComponent();
            product = new Product();
        }

        private void showDGV(object dataSource, int col)
        {
            show_dgv.DataSource = dataSource;
            show_dgv.AllowUserToAddRows = false;
            show_dgv.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)show_dgv.Columns["picture"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            int n = show_dgv.Columns.Count;
            for (int i = col; i < n; i++)
            {
                try
                {
                    show_dgv.Columns[i].Visible = false;
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        private void clear()
        {
            id_tb.Text = "";
            name_tb.Text = "";
            quantity_tb.Text = "";
            price_tb.Text = "";
            pictureBox.Image = null;
            show_dgv.DataSource = null;
        }

        private void ManageWarehouseForm_Load(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            try
            {
                pictureBox.Image = Image.FromFile(filepath.ToString());
            }
            catch (Exception)
            {
                return;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void showProduct_btn_Click(object sender, EventArgs e)
        {
            this.showDGV(product.getAllProduct(), 5);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                id = Convert.ToInt32(id_tb.Text),
                name = name_tb.Text,
                quantity = Convert.ToInt32(quantity_tb.Text),
                price = Convert.ToInt32(price_tb.Text)
            };

            try
            {
                product.picture = new ImageTool(pictureBox.Image).toByteArray();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Picture", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (product.addProduct(product))
            {
                MessageBox.Show("Add Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
            else
            {
                MessageBox.Show("Add Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Product eProduct = new Product()
            {
                id = Convert.ToInt32(id_tb.Text),
                name = name_tb.Text,
                quantity = Convert.ToInt32(quantity_tb.Text),
                price = Convert.ToInt32(price_tb.Text)
            };

            try
            {
                eProduct.picture = new ImageTool(pictureBox.Image).toByteArray();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Picture", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (product.editProduct(eProduct))
            {
                MessageBox.Show("Edit Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
            else
            {
                MessageBox.Show("Edit Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_tb.Text);
            if (product.deleteProduct(id))
            {
                MessageBox.Show("Delete Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
            else
            {
                MessageBox.Show("Delete Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showConsume_btn_Click(object sender, EventArgs e)
        {

        }

        private void show_dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id_tb.Text = show_dgv.CurrentRow.Cells[0].Value.ToString().Trim();
                name_tb.Text = show_dgv.CurrentRow.Cells[1].Value.ToString().Trim();
                quantity_tb.Text = show_dgv.CurrentRow.Cells[2].Value.ToString().Trim();
                price_tb.Text = show_dgv.CurrentRow.Cells[3].Value.ToString().Trim();
                pictureBox.Image = new ImageTool().ByteArrToImage((byte[])show_dgv.CurrentRow.Cells[4].Value);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear();
            }
        }
    }
}
