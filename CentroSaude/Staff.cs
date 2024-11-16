using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    /// <summary>
    /// Enumeração que representa as diferentes categorias de membros da equipa.
    /// </summary>
    public enum CategoriaEnum
    {
        Medico,
        Enfermeiro,
        Administrativo
    }
    /// <summary>
    /// Enumeração que representa as diferentes especialidades médicas.
    /// </summary>
    public enum EspecialidadeEnum
    {
        Cardiologia,
        Dermatologia,
        Neurologia,
        Pediatria
    }
    /// <summary>j
    /// Representa um membro da equipa no centro de saúde, incluindo informações pessoais, categoria profissional e especialidade.
    /// </summary>
    public class Staff : Pessoa
    {
        #region Attributes

        /// <summary>
        /// A categoria profissional do membro da equipa, indicando a sua função no centro de saúde
        /// (por exemplo, Médico, Enfermeiro, Administrativo).A especialidade do membro da equipa, caso se aplique (por exemplo, Cardiologia, Neurologia).
        /// </summary>
        CategoriaEnum categoria;
        EspecialidadeEnum especialidade;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Staff"/> com os atributos especificados.
        /// </summary>
        /// <param name="id">O identificador único do membro da equipa.</param>
        /// <param name="nome">O nome do membro da equipa.</param>
        /// <param name="dataNascimento">A data de nascimento do membro da equipa.</param>
        /// <param name="telemovel">O número de contacto telefónico do membro da equipa.</param>
        /// <param name="categoria">A categoria profissional do membro da equipa (por exemplo, Médico, Enfermeiro).</param>
        /// <param name="especialidade">A especialidade do membro da equipa (por exemplo, Cardiologia, Pediatria).</param>
        public Staff(int id, string nome, DateTime dataNascimento, string telemovel, CategoriaEnum categoria, EspecialidadeEnum especialidade) : base(id, nome, dataNascimento, telemovel)
        {
            this.categoria = categoria;
            this.especialidade = especialidade;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Obtém ou define a categoria profissional do membro da equipa.
        /// </summary>
        public CategoriaEnum Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        /// <summary>
        /// Obtém ou define a especialidade do membro da equipa.
        /// </summary>
        public EspecialidadeEnum Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }

        #endregion

        #endregion
    }
}
