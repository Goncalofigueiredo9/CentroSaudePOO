using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    /// <summary>
    /// Representa uma pessoa genérica no sistema, usada como base para outras classes.
    /// </summary>
    public class Pessoa
    {
        #region Attributes
        /// <summary>
        /// Identificador único da pessoa, Nome da pessoa , Data de Nascimento da pessoa, Numero de telemovel da pessoa. 
        /// </summary>
        int id;
        string nome;
        DateTime dataNascimento;
        string telemovel;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância da classe Pessoa.
        /// </summary>
        /// <param name="id">ID único da pessoa.</param>
        /// <param name="nome">Nome completo da pessoa.</param>
        /// <param name="dataNascimento">Data de nascimento.</param>
        /// <param name="telemovel">Número de telemóvel.</param>
        public Pessoa(int id, string nome, DateTime dataNascimento, string telemovel)
        {
            this.id = id;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.telemovel = telemovel;
        }

        #endregion

        #region Properties
        /// <summary>Obtém ou define o identificador único da pessoa.</summary>
        public int Id     
        {
            get { return Id; }
            set { Id  = value; }
        }
        /// <summary>Obtém ou define o nome completo da pessoa.</summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>Obtém ou define a data de nascimento da pessoa.</summary>
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        /// <summary>Obtém ou define o número de telemóvel da pessoa.</summary>
        public string Telemovel
        {
            get { return telemovel; }
            set { telemovel = value; }
        }

        #endregion

        #endregion
    }
}
