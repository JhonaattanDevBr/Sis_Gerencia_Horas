using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciaHoras.Control;

namespace GerenciaHoras.View.Formularios
{
    public partial class Fm_Cadastro : Form
    {
        public Fm_Cadastro()
        {
            InitializeComponent();
            DateTime dataAtual = DateTime.Now;
            string diaHora = dataAtual.ToString();

            string[] formatar = diaHora.Split(' ');
            string data = formatar[0];
            string hora = formatar[1];

            TxtDataInicio.Text = data;
            TxtHoraInicio.Text = hora;
        }

        ControlProjGenHoras _contProj = new ControlProjGenHoras();

        private void BtnAdicionarProjeto_Click(object sender, EventArgs e)
        {
            
            bool estaPreenchido = _contProj.Preenchido();
            if (estaPreenchido)
            {
                MessageBox.Show("Campo preenchido", "Parabéns");

            }
            else
            {
                MessageBox.Show("É necessário que o campo nome seja preenchido para incluir um novo projeto.", "ATENÇÃO");
                TxtNomeProjeto.Focus();
            }
        }

        private void TxtNomeProjeto_TextChanged(object sender, EventArgs e)
        {
            _contProj.NomeProjeto = TxtNomeProjeto.Text;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNomeProjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 95)
            {
                e.Handled = true;
            }
        }
    }
}
