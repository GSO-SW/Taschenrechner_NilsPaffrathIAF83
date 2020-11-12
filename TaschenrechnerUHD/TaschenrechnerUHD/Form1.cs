using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenrechnerUHD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double wert1;
        public double wert2;
        public double ergebnis;
        public bool addition;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            addition = true;
            wert1 = Convert.ToDouble(txb_1.Text);
        }

        private void txb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gleichZeichen_Click(object sender, EventArgs e)
        {
            if(addition == true)
            {
                ergebnis = Berechnungen.Addition(wert1, wert2);
                txb_1.Text = Convert.ToString(ergebnis);
            }
        }
    }
}
