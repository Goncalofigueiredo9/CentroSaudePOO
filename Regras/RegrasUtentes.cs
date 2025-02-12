using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosdeNegocio;
using Dados;

namespace Regras
{
    public class RegrasUtentes
    {
        public bool ValidarRegistrarUtente(Utente utente)
        {
            if (utente == null || string.IsNullOrEmpty(utente.NumeroUtente))
            {
                return false;
            }

            return Utentes.RegistarUtente(utente);
        }

        public bool ValidarRemoverUtente(string numeroUtente)
        {
            if (string.IsNullOrEmpty(numeroUtente))
            {
                return false;
            }

            return Utentes.RemoverUtente(numeroUtente);
        }

        public bool ValidarGravarUtentes(string nomeFicheiro)
        {
            if (string.IsNullOrEmpty(nomeFicheiro))
            {
                return false;
            }

            return Utentes.GravarUtentes(nomeFicheiro);
        }

        public bool ValidarLerUtentes(string nomeFicheiro)
        {
            if (string.IsNullOrEmpty(nomeFicheiro))
            {
                return false;
            }

            return Utentes.LerUtentes(nomeFicheiro);
        }   

        public Utente ValidarEncontrarUtente(string numeroUtente)
        {
            if (string.IsNullOrEmpty(numeroUtente))
            {
                return null;
            }

            return Utentes.EncontrarUtente(numeroUtente);
        }
    }
}
