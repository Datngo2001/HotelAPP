using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public Image ClipToCircle(Image srcImage)
        {
            float radius = srcImage.Width / 2;
            PointF center = new PointF(srcImage.Width / 2, srcImage.Height / 2);
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);

            using (Graphics g = Graphics.FromImage(dstImage))
            {
                RectangleF r = new RectangleF(center.X - radius, center.Y - radius,
                                                         radius * 2, radius * 2);

                // enables smoothing of the edge of the circle (less pixelated)
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // adds the new ellipse & draws the image again 
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(r);
                g.SetClip(path);
                g.DrawImage(srcImage, 0, 0);

                return dstImage;
            }
        }
    }
}
