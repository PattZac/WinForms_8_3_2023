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

namespace WinForms_8_3_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (!File.Exists(@"C:\winforms\datoteka.txt"))
            {
                if (!Directory.Exists(@"C:\winforms\"))
                {
                    Directory.CreateDirectory(@"C:\winforms\");
                }
                File.CreateText(@"C:\winforms\datoteka.txt");
                textBox1.Text = "Try again...";
            }
            else {
                File.WriteAllText(@"C:\winforms\datoteka.txt", text);
                textBox1.Text = "Done";
            }
        }
    }
}
