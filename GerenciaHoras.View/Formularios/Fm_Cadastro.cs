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
using GerenciaHoras.Model;

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
        ControlContGenHoras _contCont = new ControlContGenHoras();

        private void BtnAdicionarProjeto_Click(object sender, EventArgs e)
        {
            
            bool estaPreenchido = _contProj.Preenchido();
            if (estaPreenchido)
            {
                string dataFormatada = _contCont.InverterData(TxtDataInicio.Text);
                _contCont.HoraInicial = TxtHoraInicio.Text;
                _contCont.DiaTrabalhado = dataFormatada;

                _contProj.HoraInicioProjeto = TxtHoraInicio.Text;
                _contProj.NomeProjeto = TxtNomeProjeto.Text;
                _contProj.InicioProjeto = dataFormatada;

                ModelContGenHoras _modControle = new ModelContGenHoras();
                bool[] cadastro = new bool[2];
                cadastro[0] = _modControle.GerarControleInicial(_contCont);
                if (cadastro[0])
                {
                    MessageBox.Show("Cadastro concluido", "Parabéns");
                    Close();
                }
                else
                {
                    MessageBox.Show("Algo deu errado!", "Erro");
                }
                

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
