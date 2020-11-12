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
            txb_1.Text = "0";
        }

        public double wert1;
        public double wert2;
        public double ergebnis;
        public bool[] rechenZeichenAbfrage = new bool[8];
        //0 = addition, 1 = subtraktion, 2 = multiplikation, 3 = division, 4 = Wurzel, 5 = Potenz, 6 = Prozent, 7 = Wurzel auflösen 1/x
        public bool erstesZeichen = false;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

       

        private void txb_1_TextChanged(object sender, EventArgs e)
        {

        }

        #region ButtonZeichen

        private void btn_1_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "1";
            erstesZeichen = true;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "2";
            erstesZeichen = true;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "3";
            erstesZeichen = true;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "4";
            erstesZeichen = true;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "5";
            erstesZeichen = true;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "6";
            erstesZeichen = true;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "7";
            erstesZeichen = true;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "8";
            erstesZeichen = true;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "9";
            erstesZeichen = true;
        }


        private void btn_0_Click(object sender, EventArgs e)
        {
            txb_1.Text = txb_1.Text + "0";
            erstesZeichen = true;
        }

        private void btn_kommatar_Click(object sender, EventArgs e)
        {
            if(erstesZeichen) //Prüfen, ob bereits ein Zeichen getippt wurde
            {
                txb_1.Text = txb_1.Text + ",";
            }

            else
            {
                txb_1.Text = "0,";
            }

        }

        private void btn_allesloeschen_Click(object sender, EventArgs e)
        {
            txb_1.Text = "0";
            txbAktuelleRechung.ResetText();
            erstesZeichen = false;
        }

        #endregion

        private void txbAktuelleRechung_TextChanged(object sender, EventArgs e)
        {

        }

        #region RechenzeichenMitFunktion
        private void btn_gleichZeichen_Click(object sender, EventArgs e)
        {
            if (rechenZeichenAbfrage[0])
            {
                btn_addition.BackColor = SystemColors.ControlLight;
                wert2 = Convert.ToDouble(txb_1.Text);
                txb_1.ResetText();
                ergebnis = Berechnungen.Addition(wert1, wert2);
            }

            else if (rechenZeichenAbfrage[1])
            {
                btn_subtraktion.BackColor = SystemColors.ControlLight;
                wert2 = Convert.ToDouble(txb_1.Text);
                txb_1.ResetText();             
                ergebnis = Berechnungen.Subtraktion(wert1, wert2);
            }

            else if (rechenZeichenAbfrage[2])
            {
                btn_multiplikation.BackColor = SystemColors.ControlLight;
                wert2 = Convert.ToDouble(txb_1.Text);
                txb_1.ResetText();
                ergebnis = Berechnungen.Multiplikation(wert1, wert2);
            }

            else if (rechenZeichenAbfrage[3])
            {

            }


            else
            {
                txb_1.Text = "0";
            }

            txbAktuelleRechung.AppendText(Convert.ToString(wert2));
            txbAktuelleRechung.AppendText(" = ");
            txb_1.Text = Convert.ToString(ergebnis);
            txbAktuelleRechung.AppendText(" " + Convert.ToString(ergebnis));

            for (int i = 0; i < rechenZeichenAbfrage.Length; i++)
            {
                rechenZeichenAbfrage[i] = false;
            }



        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            btn_addition.BackColor = Color.Green;
            rechenZeichenAbfrage[0] = true;
            wert1 = Convert.ToDouble(txb_1.Text);
            txb_1.ResetText();
            txbAktuelleRechung.Text = Convert.ToString(wert1);
            txbAktuelleRechung.AppendText(" + ");
            

        }

        private void btn_subtraktion_Click(object sender, EventArgs e)
        {
            btn_subtraktion.BackColor = Color.Green;
            rechenZeichenAbfrage[1] = true;
            wert1 = Convert.ToDouble(txb_1.Text);
            txb_1.ResetText();
            txbAktuelleRechung.Text = Convert.ToString(wert1);
            txbAktuelleRechung.AppendText(" - ");
            
        }


        #endregion

        private void btn_letztesZeichenLöschen_Click(object sender, EventArgs e)
        {

            if(txb_1.TextLength != 0 & txb_1.Text != "0")
            {
                string text = txb_1.Text;
                text = text.Substring(0, text.Length - 1);
                txb_1.Text = text;
            }


            else
            {
                txb_1.Text = "0";
            }

        }

        private void btn_multiplikation_Click(object sender, EventArgs e)
        {
            btn_subtraktion.BackColor = Color.Green;
            rechenZeichenAbfrage[2] = true;
            wert1 = Convert.ToDouble(txb_1.Text);
            txb_1.ResetText();
            txbAktuelleRechung.Text = Convert.ToString(wert1);
            txbAktuelleRechung.AppendText(" x ");
        }
    }
}
