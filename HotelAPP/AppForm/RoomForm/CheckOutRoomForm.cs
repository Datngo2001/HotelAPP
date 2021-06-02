using HotelAPP.AppForm.TotalForm;
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
    public partial class CheckOutRoomForm : Form
    {
        Room room;
        Customer customer;
        Consume consume;
        public CheckOutRoomForm()
        {
            InitializeComponent();
            room = new Room();
            customer = new Customer();
            consume = new Consume();
        }

        private void CheckOutRoomForm_Load(object sender, EventArgs e)
        {
            show_dgv.DataSource = room.listRoom();
        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            int id = (int)show_dgv.CurrentRow.Cells[0].Value;
            int cID = customer.getByRoomID(id).id;

            show_dgv.DataSource = room.checkOutRoom(id);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)show_dgv.Columns["picture"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            surcharge_lb.Text = $"Surcharge: {room.surcharge(id)}";
            total_lb.Text = $"Total: {room.getByID(id).price + room.surcharge(id)}";

            if (customer.deleteCustomer(cID) && consume.deleteConsumeByRoomID(id))
            {
                room.fullOrEmpty(id, "Empty");
                MessageBox.Show("Check Out!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Check Out Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Income.sumPriceRoom((int)room.getByID(id).price);
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
