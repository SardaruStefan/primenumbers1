using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primenumbers1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox("S-a introdu " + numerTextBox.Text);
            int result = 0;
            bool isNumber = Int32.TryParse(TexBox.Text, out result);
            if (isNumber)
            {
                bool isPrim = true;
                for (int i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                    {
                        isPrim = false;
                    }
                }
                if (isPrim)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Nu s-a introdus un numar");
                    this.BackColor = Color.Yellow;
                }
            }
        }

        private void blue(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
}
