using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace _08OpenCvSharp
{
    public partial class Form1 : Form
    {
        Timer timer;
        Mat frame;
        VideoCapture capture;
        Bitmap bmp;

        
        public Form1()
        {
            InitializeComponent();
           
        }



        public void button1_Click(Object sender, EventArgs e)
        {

            //カメラ画像取得用のVideoCapture作成
            capture = new VideoCapture(0);

            Paint += new PaintEventHandler(ShoeImage);
            timer = new Timer();
            timer.Interval = 40;
            timer.Tick += new EventHandler(TimerEvent);
            timer.Start();


        }

        public void TimerEvent(object sender, EventArgs e)
        {


            if (capture.IsOpened())
            {
                frame = capture.RetrieveMat();
                if (!frame.Empty())
                {
                    bmp = BitmapConverter.ToBitmap(frame);
                    
                }
                frame.Dispose();
            }
            else
            {
                MessageBox.Show("camera was not found!");
                this.Close();
            }

      
        }

        public void ShoeImage(object sender, PaintEventArgs e)
        {
            pictureBox1.Image= bmp;
        }
    }
}
