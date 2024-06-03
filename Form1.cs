using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_TinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtSo1.Text);
               so2 = Convert.ToDouble(txtSo2.Text);
            ketqua = so1 + so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
