using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace task_4
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;

        public Form1()
        {
            InitializeComponent();
            this.pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
            };
            this.Controls.Add(this.pictureBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImage("https://img.freepik.com/free-photo/bright-petals-gift-love-in-a-bouquet-generated-by-ai_188544-13370.jpg?size=626&ext=jpg&ga=GA1.1.632798143.1713225600&semt=ais");
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