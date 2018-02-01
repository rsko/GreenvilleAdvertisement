using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleAdvertisement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maleButton.Checked)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                maleButton.Checked = false;
            }
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleButton.Checked)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                femaleButton.Checked = false;
            }
        }

        private void directionsButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();

        }
    }
}
