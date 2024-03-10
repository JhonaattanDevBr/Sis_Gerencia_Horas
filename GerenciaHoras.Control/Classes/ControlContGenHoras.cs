using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciaHoras.Control
{
    public class ControlContGenHoras
    {
        private string _idControle;
        private string _diaTrabalhado;
        private string _horaInicial;
        private string _horaFinal;
        private string _totalHoras;

        public string DiaTrabalhado
        {
            get { return _diaTrabalhado; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Regex expressao = new Regex(@"^([0-9]{4}/[0-9]{2}/[0-9]{2})$");
                    if (expressao.IsMatch(value))
                    {
                        _diaTrabalhado = value;
                    }
                    else
                    {
                        _diaTrabalhado = null;
                    }
                }
            }
        }

        public string HoraInicial
        {
            get { return _horaInicial; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Regex expressao = new Regex(@"^([0-9]{2}:[0-9]{2}:[0-9]{2})$");
                    if (expressao.IsMatch(value))
                    {
                        _horaInicial = value;
                    }
                    else
                    {
                        _horaInicial = null;
                    }
                }
            }
        }

        public string InverterData(string data)
        {
            string[] divisorDeData = data.Split('/');
            string dataFormatada = $"{divisorDeData[2]}/{divisorDeData[1]}/{divisorDeData[0]}";
            return dataFormatada;
        }
    }
}
