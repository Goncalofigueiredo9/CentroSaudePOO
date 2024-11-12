using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    public class Agendamento
    {
        #region Attributes

        Utente marcacao;
        DateTime data;
        string tipoAgendamento;
        Staff staff;
        Utente utente;
        string descricao;

        #endregion

        #region Methods

        #region Constructors

        public Agendamento(DateTime data, Staff staff, Utente utente, string descricao)
        {
            this.data = data;
            this.staff = staff;
            this.utente = utente;
            this.descricao = descricao;
        }

        #endregion

        #region Properties
        public Utente Marcacao
        {
            get { return marcacao; }
            set { marcacao = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string TipoAgendamento
        {
            get { return tipoAgendamento; }
            set { tipoAgendamento = value; }
        }
        #endregion


        #endregion
    }
}
