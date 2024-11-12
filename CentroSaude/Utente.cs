using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    public class Utente: Pessoa
    {
        #region Attributes

        string numeroUtente;

        #endregion

        #region Methods

        #region Constructors

        public Utente(int id, string nome, DateTime dataNascimento, string telemovel, string numeroUtente) : base(id, nome, dataNascimento, telemovel)
        {
            this.numeroUtente = numeroUtente;
        }

        #endregion


        #region Properties

        public string NumeroUtente
        {
            get { return numeroUtente; }
            set { numeroUtente = value; }
        }
        #endregion

        #endregion
    }
}
