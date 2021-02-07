﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07RamdomPicture
{


    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string NumImage;
        string ImageName;
        

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            NumImage = rnd.Next(1,11).ToString();
            ImageName = "Back" + NumImage;
            pictureBox1.Image = Image.FromFile($"../../01Image/{ImageName}.jpg");
        }
    }
}
