using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
//            double pi = 3.141592653589793;
            double c = 299792458;
//            richTextBox1.AppendText(pi.ToString("N3") + "\n");
//            richTextBox1.AppendText(pi.ToString("N5") + "\n");
//            richTextBox1.AppendText(pi.ToString("N15") + "\n");
            richTextBox1.AppendText(c.ToString("0.0000000000000000") + "\n");
            richTextBox1.AppendText(c.ToString("0.000") + "\n");
            string s = "3";
            string pi = "3.14159265";
            int i = int.Parse(s);
            double d = double.Parse(pi);
            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integer");
            } 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
