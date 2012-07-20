using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Biblioteka;

namespace APLIKACIJA
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

            double rezultat=Biblioteka.BMIKalkulator.IzracunajBMI(tezina, visina);
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    

        
       

        
    }
}
