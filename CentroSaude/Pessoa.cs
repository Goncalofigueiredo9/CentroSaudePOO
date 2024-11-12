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

        public int Id     
        {
            get { return Id; }
            set { Id  = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public string Telemovel
        {
            get { return telemovel; }
            set { telemovel = value; }
        }

        #endregion

        #endregion
    }
}
