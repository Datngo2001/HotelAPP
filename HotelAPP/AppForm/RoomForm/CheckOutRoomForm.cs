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
    public partial class CheckOutRoomForm : Form
    {
        Room room;

        public CheckOutRoomForm()
        {
            InitializeComponent();
            room = new Room();
        }

        private void CheckOutRoomForm_Load(object sender, EventArgs e)
        {
            show_dgv.DataSource = room.listRoom();
        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            show_dgv.DataSource = room.checkOutRoom((int)show_dgv.CurrentRow.Cells[0].Value);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)show_dgv.Columns["picture"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void print_btn_Click(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            room = new Room();
            show_dgv.DataSource = room.listRoom();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
