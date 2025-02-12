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
    /// Enumeração que representa as especialidades do Medico.
    /// </summary>
    public enum EspecialidadeEnum
    {
        Cardiologia,
        Dermatologia,
        Neurologia,
        Pediatria
    }
    /// <summary>
    /// Representa um médico do sistema, que herda as características de um membro da equipe (Staff).
    /// </summary>
    public class Medico : Staff
    {
        #region Attributes

        /// <summary>Número de registo profissional do médico.</summary>
        private string identificadorProfissional;

        /// <summary>Pacientes atribuídos ao médico.</summary>
        private Utente[] pacientes;

        /// <summary>Contador que acompanha o número de pacientes associados.</summary>
        private int pacienteCount;

        /// <summary>A especialidade do Medico</summary>
        EspecialidadeEnum especialidade;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Inicializa uma nova instância da classe Medico.
        /// </summary>
        /// <param name="id">ID único do médico.</param>
        /// <param name="nome">Nome completo do médico.</param>
        /// <param name="dataNascimento">Data de nascimento do médico.</param>
        /// <param name="telemovel">Número de telemóvel do médico.</param>
        /// <param name="categoria">Categoria profissional do médico (ex.: Médico).</param>
        /// <param name="especialidade">Especialidade médica do médico.</param>
        /// <param name="identificadorProfissional">Número de registro profissional do médico.</param>
        /// <param name="maxPacientes">Número máximo de pacientes que o médico pode atender.</param>
        public Medico(int id, string nome, DateTime dataNascimento, string telemovel, CategoriaEnum categoria, 
            EspecialidadeEnum especialidade, string identificadorProfissional, int maxPacientes): base(id, nome, dataNascimento, telemovel, categoria)
        {
            this.especialidade = especialidade;
            this.identificadorProfissional = identificadorProfissional;
            this.pacientes = new Utente[maxPacientes];
            this.pacienteCount = 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Obtém ou define o número de registo profissional do médico.
        /// </summary>
        
        public string IdentificadorProfissional
        {
            get { return identificadorProfissional; }
            set { identificadorProfissional = value; }
        }
        /// <summary>
        /// Obtém ou define a especialidade do membro da equipa.
        /// </summary>
        public EspecialidadeEnum Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }

        /// <summary>
        /// Obtém os pacientes atribuídos ao médico.
        /// </summary>
        public Utente[] Pacientes
        {
            get { return pacientes; }
        }

        /// <summary>
        /// Obtém o número atual de pacientes associados ao médico.
        /// </summary>
        public int PacienteCount
        {
            get { return pacienteCount; }
        }

        #endregion

        #endregion
    }
}