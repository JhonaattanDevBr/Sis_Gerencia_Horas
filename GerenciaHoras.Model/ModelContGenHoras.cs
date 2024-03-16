using GerenciaHoras.Control;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciaHoras.Model
{
    public class ModelContGenHoras
    {
        BancoDeDados _chave = new BancoDeDados();

        public bool GerarControleInicial(ControlContGenHoras _ctlControle)
        {
            SqlConnection conn = new SqlConnection(_chave.chaveConexao);

            try
            {
                string query = "INSERT INTO Controle (dia, horaIni) VALUES (@dia, @horaInicial)";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                var pmtDia = cmd.CreateParameter();
                pmtDia.ParameterName = "@dia";
                pmtDia.SqlDbType = SqlDbType.Date;
                pmtDia.Value = _ctlControle.DiaTrabalhado;
                cmd.Parameters.Add(pmtDia);

                var pmtHora = cmd.CreateParameter();
                pmtHora.ParameterName = "@horaInicial";
                pmtHora.SqlDbType = SqlDbType.Time;
                pmtHora.Value = _ctlControle.HoraInicial;
                cmd.Parameters.Add(pmtHora);

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
    }
}
