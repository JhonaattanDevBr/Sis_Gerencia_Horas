using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciaHoras.Control;

namespace GerenciaHoras.Model
{
    public class ModelProjGenHoras
    {
        BancoDeDados _chave = new BancoDeDados();

        public void CadastrarNovoProjeto(ControlProjGenHoras _contProj) // Parei neessa parte do sistema.
        {
            SqlConnection con = new SqlConnection(_chave.chaveConexao);

            try
            {
                string query = "INSERT INTO Projeto (nome) VALUES (@nomeDoProjeto)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
