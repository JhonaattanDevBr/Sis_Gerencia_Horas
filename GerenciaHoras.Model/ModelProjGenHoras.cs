using System;
using System.Collections.Generic;
using System.Data;
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

        public bool CadastrarNovoProjeto(ControlProjGenHoras _ctlProjeto)
        {
            SqlConnection conn = new SqlConnection(_chave.chaveConexao);

            try
            {
                string query = "INSERT INTO Projetos (nomeProj, inicioProj, idControle) " +
                                "VALUES (@nomeProjeto, @inicioProjeto, IDENT_CURRENT('Controle'))";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                var pmtNomeProjeto = cmd.CreateParameter();
                pmtNomeProjeto.ParameterName = "@nomeProjeto";
                pmtNomeProjeto.SqlDbType = SqlDbType.VarChar;
                pmtNomeProjeto.Value = _ctlProjeto.NomeProjeto;
                cmd.Parameters.Add(pmtNomeProjeto);

                var pmtInicioProjeto = cmd.CreateParameter();
                pmtInicioProjeto.ParameterName = "@inicioProjeto";
                pmtInicioProjeto.SqlDbType = SqlDbType.Date;
                pmtInicioProjeto.Value = _ctlProjeto.InicioProjeto;
                cmd.Parameters.Add(pmtInicioProjeto);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        // Preciso fazer a implementação da tabela agora para ser exibida no forms.
    }
}
