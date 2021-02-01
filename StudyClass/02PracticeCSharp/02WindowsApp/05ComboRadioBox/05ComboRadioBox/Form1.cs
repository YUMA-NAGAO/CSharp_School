using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05ComboRadioBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Radio1.Checked == true)
            {
                comboBox1.Visible = false;
            }
            else if (radioButton2.Checked == true)
            {
                comboBox1.Visible = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Radio1.Checked == true)
            {
                label1.Text = "ラジオ１";
            }
            else if (radioButton2.Checked == true)
            {
                label1.Text = "radio2";
            }
        }



    }
}
