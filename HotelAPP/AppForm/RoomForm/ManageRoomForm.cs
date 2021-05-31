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

namespace HotelAPP.AppForm.RoomForm
{
    public partial class ManageRoomForm : Form
    {
        Room room;
        Product product;
        Consume consume;
        int consume_id = 0;

        public ManageRoomForm()
        {
            InitializeComponent();
            room = new Room();
            product = new Product();
            consume = new Consume();
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
            status_cb.Text = "";
            price_tb.Text = "";
            pictureBox.Image = null;
            show_dgv.DataSource = null;
        }

        private void ManageRoomForm_Load(object sender, EventArgs e)
        {
            status_cb.Items.Add("Empty");
            status_cb.Items.Add("Full");
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            Room room = new Room()
            {
                id = Convert.ToInt32(id_tb.Text),
                name = name_tb.Text,
                status = status_cb.Text
            };

            try
            {
                room.picture = new ImageTool(pictureBox.Image).toByteArray();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Picture", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt64(price_tb.Text) > 0)
            {
                room.price = Convert.ToInt64(price_tb.Text);
            }
            else
            {
                MessageBox.Show("Invalid Price", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (room.addRoom(room))
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
            Room eRoom = new Room()
            {
                id = Convert.ToInt32(id_tb.Text),
                name = name_tb.Text,
                status = status_cb.Text,
                price = Convert.ToDecimal(price_tb.Text)
            };

            try
            {
                eRoom.picture = new ImageTool(pictureBox.Image).toByteArray();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Picture", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (room.editRoom(eRoom))
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
            if (room.deleteRoom(id))
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

        private void order_btn_Click(object sender, EventArgs e)
        {
            Consume consume = new Consume()
            {
                id = consume_id,
                roomID = Convert.ToInt32(id_tb.Text),
                roomName = name_tb.Text,
                productID = Convert.ToInt32(show_dgv.CurrentRow.Cells[0].Value),
                productName = show_dgv.CurrentRow.Cells[1].Value.ToString().Trim(),
                date = DateTime.Now.Date
            };

            if (Convert.ToInt32(quantity_tb.Text) > 0)
            {
                consume.consume = Convert.ToInt32(quantity_tb.Text);
            }
            else
            {
                MessageBox.Show("Invalid Quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (consume.addConsume(consume))
            {
                MessageBox.Show("Add Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Add Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void showRoom_btn_Click(object sender, EventArgs e)
        {
            this.showDGV(room.getAllRoom(), 5);
        }

        private void showProduct_btn_Click(object sender, EventArgs e)
        {
            this.showDGV(product.getAllProduct(), 5);
        }

        private void show_dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id_tb.Text = show_dgv.CurrentRow.Cells[0].Value.ToString().Trim();
                name_tb.Text = show_dgv.CurrentRow.Cells[1].Value.ToString().Trim();
                status_cb.Text = show_dgv.CurrentRow.Cells[2].Value.ToString().Trim();
                price_tb.Text = show_dgv.CurrentRow.Cells[4].Value.ToString().Trim();
                pictureBox.Image = new ImageTool().ByteArrToImage((byte[])show_dgv.CurrentRow.Cells[3].Value);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear();
            }
        }
    }
}
