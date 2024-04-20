using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_4
{
    public class ImageElement
    {
        private string href;
        private IImageLoaderStrategy strategy;

        public ImageElement(string href, IImageLoaderStrategy strategy)
        {
            this.href = href;
            this.strategy = strategy;
        }

        public Image Load()
        {
            return this.strategy.Load(this.href);
        }
    }
}
