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
            txbAktuelleRechung.ResetText();
            txb_1.ResetText();
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
            txb_1.ResetText();
            txbAktuelleRechung.Text = Convert.ToString(wert1);
            txbAktuelleRechung.AppendText(" +");
            txb_1.Text = "+";
          
        }

        private void txb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gleichZeichen_Click(object sender, EventArgs e)
        {
            if(addition == true)
            {
                
                wert2 = Convert.ToDouble(txb_1.Text);
                txb_1.ResetText();
                txbAktuelleRechung.AppendText(Convert.ToString(wert2));
                txbAktuelleRechung.AppendText(" = ");
                ergebnis = Berechnungen.Addition(wert1, wert2);
                txb_1.Text = Convert.ToString(ergebnis);
                txbAktuelleRechung.AppendText(" "+ Convert.ToString(ergebnis));
            }

            addition = false;
            
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "9";
        }

        private void btn_allesloeschen_Click(object sender, EventArgs e)
        {
            txb_1.ResetText();
            txbAktuelleRechung.ResetText()
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "0";
        }

        private void btn_kommatar_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + ",";
        }

        private void txbAktuelleRechung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
