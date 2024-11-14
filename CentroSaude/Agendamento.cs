using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    // <summary>
    /// Representa um agendamento de consulta no sistema do Centro de Saúde.
    /// </summary>
    public class Agendamento
    {
        #region Attributes

        /// <summary>Utente associado ao agendamento, 
        /// Data e hora do agendamento da consulta, 
        /// Descrição da consulta agendada, 
        /// Staff responsável pelo agendamento, 
        /// O utente para o qual o agendamento foi feito.
        /// Descrição da consulta agendada, que pode incluir detalhes adicionais ou notas.</summary>
        Utente agendamento;
        DateTime data;
        Staff staff;
        Utente utente;
        string tipoAgendamento;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Agendamento"/> com a data, o staff,
        /// o utente e uma descrição da consulta agendada.
        /// </summary>
        /// <param name="data">A data e hora do agendamento.</param>
        /// <param name="staff">O membro da equipa responsável pelo agendamento.</param>
        /// <param name="utente">O utente para quem a consulta está agendada.</param>
        /// <param name="descricao">Descrição detalhada da consulta agendada.</param>
        public Agendamento(DateTime data, Staff staff, Utente utente, string tipoAgendamento)
        {
            this.data = data;
            this.staff = staff;
            this.utente = utente;
            this.tipoAgendamento = tipoAgendamento;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Obtém ou define o utente associado ao agendamento.
        /// </summary>
        public Utente Marcacao
        {
            get { return agendamento; }
            set { agendamento = value; }
        }
        /// <summary>
        /// Obtém ou define a data e hora do agendamento.
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        /// <summary>
        /// Obtém ou define o tipo de agendamento.
        /// </summary>
        public string TipoAgendamento
        {
            get { return tipoAgendamento; }
            set { tipoAgendamento = value; }
        }
        #endregion


        #endregion
    }
}
