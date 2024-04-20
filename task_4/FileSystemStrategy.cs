using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace task_4
{


    public class FileSystemStrategy : IImageLoaderStrategy
    {
        public Image Load(string href)
        {
            return Image.FromFile(href);
        }
    }
}