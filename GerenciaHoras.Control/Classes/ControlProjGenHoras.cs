using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciaHoras.Control
{
    public class ControlProjGenHoras
    {
        private string _idProjeto;
        private string _nomeProjeto;
        private string _inicioProjeto;
        private string _finalProjeto;
        private string _horaInicioProjeto;
        private string _idCont;

        public string IdProjeto
        {
            get { return _idProjeto; }
            set { _idProjeto = value; }
        }

        public string NomeProjeto
        {
            get { return _nomeProjeto; }
            set { _nomeProjeto = value; }
        }

        public string InicioProjeto
        {
            get { return _inicioProjeto; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Regex expressao = new Regex(@"^[0-9]{4}/[0-9]{2}/[0-9]{2}$");
                    if (expressao.IsMatch(value))
                    {
                        _inicioProjeto = value;
                    }
                    else
                    {
                        _inicioProjeto = null;
                    }
                }
            }
        }

        public string FinalProjeto
        {
            get { return _finalProjeto; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Regex expressao = new Regex(@"^[0-9]{4}/[0-9]{2}/[0-9]{2}$");
                    if (expressao.IsMatch(value))
                    {
                        _finalProjeto = value;
                    }
                    else
                    {
                        _finalProjeto = null;
                    }
                }
            }
        }

        public string HoraInicioProjeto
        {
            get { return _horaInicioProjeto; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {

                }
            }
        }

        public bool Preenchido()
        {
            if (string.IsNullOrEmpty(NomeProjeto))
            { return false; }
            else { return true; }
        }
    }
}
