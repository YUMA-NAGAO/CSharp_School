using System;
using System.Windows.Forms;
using System.Drawing;

namespace Downloads
{

	static class Program
    {
        static void Main()
        {
		MyForm mf =new MyForm();
        }
    }
	
	public class MyForm :Form{
		public MyForm(){

            Size = new Size(800, 600);
            ShowDialog();
        }
	protected override void OnPaint(PaintEventArgs e){
			Color red=Color.FromArgb(255,0,0);
			Color green=Color.FromArgb(0,255,0);
			Color blue=Color.FromArgb(0,0,255);

			SolidBrush redBrush=new SolidBrush(red);
			SolidBrush greenBrush=new SolidBrush(green);
			SolidBrush blueBrush=new SolidBrush(blue);

            Pen greenPen = new Pen(greenBrush,10.0F);

            int x=300;
            int y=200;
            int width;
            int height;

            width = height = 200;

            e.Graphics.FillEllipse(blueBrush, x,y, width, height);
            //e.Graphics.FillEllipse(greenBrush, 230, 130, 300, 300);
            e.Graphics.DrawEllipse(greenPen, x, y, width, height);
        }
	}

}
