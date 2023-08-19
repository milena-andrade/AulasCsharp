using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaNelsonSabado
{
    
    public partial class Form1 : Form
    {
        Mensalista pMensalista = new Mensalista();
        Aulista pAulista = new Aulista();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSalarioMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcularMensalista_Click(object sender, EventArgs e)
        {
            pMensalista.Nome = txtNome.Text;
            pMensalista.Matricula = txtMatricula.Text;
            pMensalista.CalcularHoraAtividade(Convert.ToDouble(textBoxSalarioMes.Text));
            textBoxHoraAtividade.Text = (pMensalista.HoraAtividade).ToString("N2");
            pMensalista.CalcularSalarioMensalista();
            textBoxSalarioTotalMes.Text = (pMensalista.SalarioTotalMensalista).ToString("N2");
        }

        private void buttonCalcularAulista_Click(object sender, EventArgs e)
        {
            pAulista.Nome = txtNome.Text;
            pAulista.Matricula = txtMatricula.Text;
            pAulista.CalcularSalarioBaseAulista(Convert.ToInt32(textBoxNAulaSemanais.Text),
            Convert.ToDouble(textBoxValorHoraAula.Text));
            textBoxSalarioBase.Text = (pAulista.SalarioProfessorAulista).ToString("N2");
            pAulista.CalcularHoraAtividade(Convert.ToDouble(textBoxSalarioBase.Text));
            textBoxHoraAtividadeAulista.Text = (pAulista.HoraAtividade).ToString("N2");
            pAulista.CalcularDSR();
            textBoxDSR.Text = (pAulista.DSR).ToString("N2");
            pAulista.CalcularSalarioAulista();
            textBoxSalarioTotalAulista.Text = (pAulista.SalarioTotalAulista).ToString("N2");
            MessageBox.Show(pAulista.Matricula + " - " + pAulista.Nome + "\nSalário: " +
           (pAulista.SalarioTotalAulista).ToString("C2"));
        }
    }
}
