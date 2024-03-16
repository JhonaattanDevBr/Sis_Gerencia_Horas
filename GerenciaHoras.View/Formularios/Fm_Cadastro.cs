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

        ControlProjGenHoras _ctlProjeto = new ControlProjGenHoras();
        ControlContGenHoras _ctlControle = new ControlContGenHoras();

        private void BtnAdicionarProjeto_Click(object sender, EventArgs e)
        {
            bool campoPreenchido = _ctlProjeto.Preenchido();
            if (campoPreenchido)
            {
                string dataFormatada = _ctlControle.InverterData(TxtDataInicio.Text);

                _ctlControle.DiaTrabalhado = dataFormatada;
                _ctlControle.HoraInicial = TxtHoraInicio.Text;

                _ctlProjeto.NomeProjeto = TxtNomeProjeto.Text;
                _ctlProjeto.InicioProjeto = dataFormatada;

                ModelContGenHoras _mdlControle = new ModelContGenHoras();
                ModelProjGenHoras _mdlProjeto = new ModelProjGenHoras();

                bool[] etapasCad = new bool[2];
                etapasCad[0] = _mdlControle.GerarControleInicial(_ctlControle);
                etapasCad[1] = _mdlProjeto.CadastrarNovoProjeto(_ctlProjeto);
                if (etapasCad[0] && etapasCad[1])
                {
                    MessageBox.Show("Cadastro concluido.", "Operação realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar o cadastro.", "Operação não realizada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Informe o nome do projeto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNomeProjeto.Focus();
            }
        }

        private void TxtNomeProjeto_TextChanged(object sender, EventArgs e)
        {
            _ctlProjeto.NomeProjeto = TxtNomeProjeto.Text;
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
            else if(e.KeyChar == 13)
            {
                this.BtnAdicionarProjeto_Click(sender, e);
            }
        }

        private void Fm_Cadastro_Enter(object sender, EventArgs e)
        {
            this.BtnAdicionarProjeto_Click(sender, e);
        }
    }
}
