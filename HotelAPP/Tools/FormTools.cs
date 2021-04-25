using System.Windows.Forms;

namespace HotelAPP.Tools
{
    class FormTools
    {
        public void ClearForm(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }
                else
                    ClearForm(c);
            }
        }
        public void ClearText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
                else
                    ClearForm(c);
            }
        }
    }
}
