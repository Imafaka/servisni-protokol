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

namespace prokotol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZakladniInformace zi = new ZakladniInformace();

            if (zi.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zakaznik zakaznik = new zakaznik();

            if (zakaznik.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Zarizeni zarizeni = new Zarizeni();

            if (zarizeni.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nahled nahled = new Nahled();

            if (nahled.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = null;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }

            StreamWriter sw = new StreamWriter(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }

            StreamReader sr = new StreamReader(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = null;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }

            StreamWriter sw = new StreamWriter(path);
        }
    }
}
