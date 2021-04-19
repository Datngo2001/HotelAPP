using System;
using System.Drawing;
using System.IO;

namespace HotelAPP.Tools
{
    class ImageTool
    {
        public Image Content { get; set; }

        public ImageTool()
        {

        }
        public ImageTool(Image content)
        {
            try
            {
                Content = content;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public byte[] toByteArray()
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(Content, typeof(byte[]));
                return image;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Image ByteArrToImage(byte[] arr)
        {
            try
            {
                MemoryStream stream = new MemoryStream(arr);
                Image image = Image.FromStream(stream);
                return image;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
