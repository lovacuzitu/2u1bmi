using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tezina = Double.Parse(textBox1.Text);
            double visina = Double.Parse(textBox2.Text);

            double rezultat = Biblioteka.BMIKalkulator.IzracunajBMI(visina,tezina);

            textBox3.Text = Biblioteka.BMIKalkulator.ispisiKategoriju(rezultat).ToString();

            if (rezultat <= 15 && rezultat >= 0)
            {
                textBox3.Text += " ---> vi pripadate grupi: ANOREKSICNI.";
            }

            if (rezultat > 15 && rezultat <= 18.5)
            {
                textBox3.Text += " ---> vi pripadate grupi: MRSAVI.";
            }

            if (rezultat > 18.5 && rezultat <=25)
            {
                textBox3.Text += " ---> vi pripadate grupi: NORMALNI.";
            }

            if (rezultat > 25 && rezultat <= 30)
            {
                textBox3.Text += " ---> vi pripadate grupi: POPUNJENI.";
            }

            if (rezultat > 30 && rezultat <=40)
            {
                textBox3.Text += " ---> vi pripadate grupi: DEBELI.";
            }

            if (rezultat >40)
            {
                textBox3.Text += " ---> vi pripadate grupi: GOJAZNI.";
            }
        }
    }
}
