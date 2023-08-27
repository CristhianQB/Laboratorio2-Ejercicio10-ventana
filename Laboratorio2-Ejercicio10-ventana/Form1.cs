using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2_Ejercicio10_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int consumo = int.Parse(txtb.Text);

            if (consumo <= 100)
            {
                double dsct = consumo * 0.10;
                double subtotal = consumo - dsct;
                double impuesto = subtotal * 0.18;
                double total = subtotal + impuesto;
                lbl6.Text = dsct.ToString();
                lbl7.Text = subtotal.ToString();
                lbl8.Text = impuesto.ToString();
                lbl9.Text = total.ToString();
            }
            else
            {
                double dsct = consumo * 0.20;
                double subtotal = consumo - dsct;
                double impuesto = subtotal * 0.18;
                double total = subtotal + impuesto;
                lbl6.Text = dsct.ToString();
                lbl7.Text = subtotal.ToString();
                lbl8.Text = impuesto.ToString();
                lbl9.Text = total.ToString();
            }

        }
    }
}
