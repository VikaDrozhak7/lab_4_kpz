using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace task_4
{
    public class MainForm : Form
    {
        private PictureBox pictureBox;

        public MainForm()
        {
            this.pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
            };
            this.Controls.Add(this.pictureBox);
        }

        public void LoadImage(string href)
        {
            IImageLoaderStrategy strategy;

            if (File.Exists(href))
            {
                strategy = new FileSystemStrategy();
            }
            else
            {
                strategy = new WebStrategy();
            }

            ImageElement image = new ImageElement(href, strategy);
            Image img = image.Load();
            this.pictureBox.Image = img;
        }
    }
}
