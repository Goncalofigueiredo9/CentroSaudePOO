using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    public class Utente: Pessoa
    {
        /// <summary>
        /// Representa um utente (paciente) do sistema, com dados específicos do paciente.
        /// </summary>
        #region Attributes

        /// <summary>Número de identificação do utente.</summary>
        string numeroUtente;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância da classe Utente.
        /// </summary>
        /// <param name="id">ID único do utente.</param>
        /// <param name="nome">Nome do utente.</param>
        /// <param name="dataNascimento">Data de nascimento.</param>
        /// <param name="telemovel">Número de telemóvel.</param>
        /// <param name="numeroUtente">Número de utente único.</param>
        public Utente(int id, string nome, DateTime dataNascimento, string telemovel, string numeroUtente) : base(id, nome, dataNascimento, telemovel)
        {
            this.numeroUtente = numeroUtente;
        }

        #endregion


        #region Properties
        /// <summary>Obtém ou define o número único do utente.</summary>
        public string NumeroUtente
        {
            get { return numeroUtente; }
            set { numeroUtente = value; }
        }
        #endregion

        #endregion
    }
}
