using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            Triangulo t = new Triangulo(double.Parse(tx1.Text), double.Parse(tx2.Text), double.Parse(tx3.Text));
            txResult.Text = t.Tipo;

        }
    }
}
