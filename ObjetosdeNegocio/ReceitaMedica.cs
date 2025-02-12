/*
 * Author: Gonçalo Figueiredo
 * Email: a26747@alunos.ipca.pt
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosdeNegocio
{
    /// <summary>
    /// Representa uma receita médica associada a um paciente e prescrita por um médico.
    /// </summary>
    public class ReceitaMedica
    {
        #region Attributes

        /// <summary>ID único da receita médica.</summary>
        private int id;

        /// <summary>Descrição dos medicamentos ou recomendações incluídas na receita.</summary>
        private string descricao;

        /// <summary>Médico responsável por prescrever a receita.</summary>
        private Medico medico;

        /// <summary>Paciente (Utente) para quem a receita foi prescrita.</summary>
        private Utente utente;

        /// <summary>Data de emissão da receita médica.</summary>
        private DateTime dataEmissao;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Inicializa uma nova instância da classe ReceitaMedica.
        /// </summary>
        /// <param name="id">ID único da receita médica.</param>
        /// <param name="descricao">Descrição dos medicamentos ou recomendações.</param>
        /// <param name="medico">Médico responsável pela receita.</param>
        /// <param name="utente">Utente para quem a receita foi emitida.</param>
        /// <param name="dataEmissao">Data de emissão da receita.</param>
        public ReceitaMedica(int id, string descricao, Medico medico, Utente utente, DateTime dataEmissao)
        {
            this.id = id;
            this.descricao = descricao;
            this.medico = medico;
            this.utente = utente;
            this.dataEmissao = dataEmissao;
        }

        #endregion

        #region Properties

        /// <summary>Obtém ou define o ID único da receita médica.</summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>Obtém ou define a descrição da receita médica.</summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>Obtém ou define o médico responsável pela receita.</summary>
        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        /// <summary>Obtém ou define o utente (paciente) associado à receita.</summary>
        public Utente Utente
        {
            get { return utente; }
            set { utente = value; }
        }

        /// <summary>Obtém ou define a data de emissão da receita.</summary>
        public DateTime DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        #endregion

        #endregion
    }
}
