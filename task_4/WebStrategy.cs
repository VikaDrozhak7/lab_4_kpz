using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

using System.Net;
namespace task_4
{
    public class WebStrategy : IImageLoaderStrategy
    {
        public Image Load(string href)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("https://img.freepik.com/free-photo/bright-petals-gift-love-in-a-bouquet-generated-by-ai_188544-13370.jpg?size=626&ext=jpg&ga=GA1.1.632798143.1713225600&semt=ais");
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            return img;
        }
    }
}