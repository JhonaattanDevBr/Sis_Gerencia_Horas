using GerenciaHoras.View.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciaHoras.View
{
    public partial class Fml_SisGenHoras : Form
    {
        public Fml_SisGenHoras()
        {
            InitializeComponent();
        }

        private void BtnNovoProjeto_Click(object sender, EventArgs e)
        {
            Fm_Cadastro formCadastro = new Fm_Cadastro();
            formCadastro.ShowDialog();
        }

        private void DgvTabelaProjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView tabela = new DataGridView();
            // tabela.DataSource = 
        }
    }
}
