using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaNelsonSabado2
{
    public partial class Form1 : Form
    {
        Quadrado q = new Quadrado();
        Triangulo t = new Triangulo();
        Retangulo r = new Retangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            q.Lado = Convert.ToInt32(txtMetros.Text);
            q.CalcularArea();
            q.CalcularPerimetro();
            txtArea.Text = "A área do quadrado é " + q.Area + " metro(s) quadrado(s)";
            txtPerimetro.Text = "O perímetro do quadrado é " + q.Perimetro + " metro(s)"; 


        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            t.Ladoc = Convert.ToInt32(txtMetros.Text);
            t.Altura = Convert.ToInt32(txtAltura.Text);
            t.Base = Convert.ToInt32(txtBase.Text);


            t.CalcularArea();
            t.CalcularPerimetro();
            txtArea.Text = "A área do triangulo é " + t.Area + " metro(s) quadrado(s)";
            txtPerimetro.Text = "O perímetro do triangulo é " + t.Perimetro + " metro(s)";

        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {

            
            r.AlturaRetangulo = Convert.ToInt32(txtAltura.Text);
            r.BaseRetangulo = Convert.ToInt32(txtBase.Text);


            r.CalcularArea();
            r.CalcularPerimetro();
            txtArea.Text = "A área do retangulo é " + r.Area + " metro(s) quadrado(s)";
            txtPerimetro.Text = "O perímetro do retangulo é " + r.Perimetro + " metro(s)";

        }
    }
}
