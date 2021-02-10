using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Internal;

namespace _08OpenCvSharp
{
    public partial class Form1 : Form
    {
        int WIDTH = 640;
        int HEIGHT = 480;
        Mat frame;
        VideoCapture capture;
        Bitmap bmp;
        Graphics graphic;
        DateTime dt = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            //カメラ画像取得用のVideoCapture作成
            capture = new VideoCapture(0);
            if (!capture.IsOpened())
            {
                MessageBox.Show("camera was not found!");
                this.Close();
            }
            capture.FrameWidth = WIDTH;
            capture.FrameHeight = HEIGHT;

            //取得先のMat作成
            frame = new Mat(HEIGHT, WIDTH, MatType.CV_8UC3);

            //表示用のBitmap作成
            bmp = new Bitmap(frame.Cols, frame.Rows, (int)frame.Step(), System.Drawing.Imaging.PixelFormat.Format24bppRgb, frame.Data);

            //PictureBoxを出力サイズに合わせる
            pictureBox1.Width = frame.Cols;
            pictureBox1.Height = frame.Rows;

            //描画用のGraphics作成
            graphic = pictureBox1.CreateGraphics();

            //画像取得スレッド開始
            backgroundWorker1.RunWorkerAsync();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //スレッドの終了を待機
            backgroundWorker1.CancelAsync();
            while (backgroundWorker1.IsBusy)
                Application.DoEvents();
        }

        public void button1_Click(Object sender,EventArgs e)
        {
            capture.Grab();
            NativeMethods.videoio_VideoCapture_operatorRightShift_Mat(capture.CvPtr, frame.CvPtr);


            Timer t = new Timer();
            t.Interval = 40;
            t.Tick += new EventHandler(ShowImage);
            t.Start();
            
        }
        private void ShowImage(Object sender, EventArgs e)
        {
            string filename = dt.ToString("HH:mm:ss");
            using (frame)
            {
                Cv2.ImShow(filename, frame);
            }
        }
    }
}
