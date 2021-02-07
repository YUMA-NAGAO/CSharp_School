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
			Size=new Size(800,600);
			ShowDialog();			
}
	protected override void OnPaint(PaintEventArgs e){
			Color red=Color.FromArgb(255,0,0);
			Color green=Color.FromArgb(0,255,0);
			Color blue=Color.FromArgb(0,0,255);

			SolidBrush redBrush=new SolidBrush(red);
			SolidBrush greenBrush=new SolidBrush(green);
			SolidBrush blueBrush=new SolidBrush(blue);


		/*Pen pen=new Pen(col);
			e.Graphics.DrawLine(pen,0,0,800,600);*/

			
//			e.Graphics.FillEllipse(redBrush,0,0,200,100);
			e.Graphics.FillEllipse(greenBrush,200,150,200,200);
			e.Graphics.FillEllipse(blueBrush,200,150,400,400);	
}
}

}
