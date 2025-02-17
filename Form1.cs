using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9_Tinhdientichchuvihinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double bk, chuvi, dientich;

            bk = Convert.ToDouble(txtBK.Text);
            if (rdbCV.Checked)
            {
                chuvi = 2 * Math.PI * bk;
                txtKQ.Text = chuvi.ToString();
            }
            if (rdbDT.Checked)
            {
                dientich = (Math.PI * (bk * bk));
                txtKQ.Text = dientich.ToString();
            }
        }
    }
}
        