using System;
using System.Drawing;

namespace _13Sepiar
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmp = new Bitmap(@"../../../01Image\hogehoge.jpg");
            int width = bmp.Width;
            int height = bmp.Height;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color colin = bmp.GetPixel(j, i);
                    double red1 = colin.R * 0.42;
                    double green1 = colin.G * 0.29;
                    double blue1 = colin.B * 0.169;

                    int red = (int)red1;
                    int green = (int)green1;
                    int blue = (int)blue1;


                    Color colout = Color.FromArgb(red, green, blue);
                    bmp.SetPixel(j, i, colout);
                }
            }
            bmp.Save(@"../../../01Image\hogehogeout.png");
        }
    }
}
