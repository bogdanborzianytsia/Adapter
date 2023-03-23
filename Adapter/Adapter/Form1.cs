using gonki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Photo car = new Photo();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Photo PNGphoto = new PNGAdapter(car);
            PNGphoto.print();
            richTextBox1.Text += PNGphoto.prin + "\f";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Photo BitmapPhoto = new BitmapAdapter(car);
            BitmapPhoto.print();
            richTextBox1.Text += BitmapPhoto.prin + "\f"; ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Photo JPEGphoto = new JPEGAdapter(car);
            JPEGphoto.print();
            richTextBox1.Text += JPEGphoto.prin + "\f";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Photo VectorPhoto = new VectorAdapter(car);
            VectorPhoto.print();
            richTextBox1.Text += VectorPhoto.prin + "\f";
        }
    }
}
