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

        public void CadastrarNovoProjeto(ControlProjGenHoras _contProj) // Parei neessa parte do sistema. preciso fazer o insert
        {
            SqlConnection conn = new SqlConnection(_chave.chaveConexao);

            try
            {
                string query = "INSERT INTO Projeto (nomeProj, inicioProj, finalProj, idControle) " +
                                "VALUES (@nomeProjeto, @inicioProjeto, @finalProjeto)";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                var pmtNomeProjeto = cmd.CreateParameter();
                pmtNomeProjeto.ParameterName = "@";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
