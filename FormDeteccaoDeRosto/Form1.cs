using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FormDeteccaoDeRosto
{
    public partial class Form1 : Form
    {
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        VideoCapture videoCapture;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false , Filter = "JPEG|*.jpg"})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(ofd.FileName);
                    processarImagem(bitmap);
                 
                }
            }
        }

        private void iniciarWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(videoCapture != null) 
            {
                MessageBox.Show("A webcam ja está iniciada !");
                return;
            }
            videoCapture = new VideoCapture(0);
            videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
            videoCapture.Start();

        }

        private void VideoCapture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                videoCapture.Retrieve(m);
                processarImagem(m.Bitmap);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void paraWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoCapture == null) {
                MessageBox.Show("A webcam já está parada");
                    return;
                }
            videoCapture.ImageGrabbed -= VideoCapture_ImageGrabbed;
            videoCapture.Stop();
            videoCapture.Dispose();
            videoCapture = null;
            pictureBox1 = null;
            }

        private void processarImagem(Bitmap bitmap) {
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 4);
            foreach (var rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Blue, 4))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
            pictureBox1.Image = bitmap;
        }
    }
}
