using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TiktokVideoDonloader.Services
{
    public static class CaptchaService
    {
        public static bool CaptchaResolve(string html)
        {
            bool isSuccess = false;
            try
            {
                if (html.Contains("captcha-verify-container-main-page"))
                {
                    //Verify to continue
                    //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    //doc.LoadHtml(html);
                    //var node = doc.DocumentNode.SelectSingleNode("//img[@id='captcha-verify-image']");
                    //if (node != null)
                    //{
                    //    HtmlAttribute src = node.Attributes["src"];
                    //    string imageUrl = src.Value;
                    //    SaveImage(imageUrl, "captcha.png", ImageFormat.Png);
                    //}
                }
                else
                {
                    isSuccess = true;
                }
            }
            catch
            {

            }
            return isSuccess;
        }

        public static void SaveImage(string imageUrl, string fileName, ImageFormat format)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap;
            bitmap = new Bitmap(stream);

            if (bitmap != null)
            {
                var bitmapConvert = GrayScaleFilter(bitmap);
                bitmapConvert.Save(fileName, format);
            }

            stream.Flush();
            stream.Close();
            stream.Dispose();
        }

        public static Bitmap GrayScaleFilter(Bitmap bitmap)
        {
            Bitmap grayScale = new Bitmap(bitmap.Width, bitmap.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
            {
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = bitmap.GetPixel(x, y);
                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    grayScale.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            }
            return grayScale;
        }
    }
}
