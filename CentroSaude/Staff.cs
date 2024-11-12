using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    public enum CategoriaEnum
    {
        Medico,
        Enfermeiro,
        Administrativo
    }
    public enum EspecialidadeEnum
    {
        Cardiologia,
        Dermatologia,
        Neurologia,
        Pediatria
    }
    
    public class Staff : Pessoa
    {
    #region Attributes
        
        CategoriaEnum categoria;
        EspecialidadeEnum especialidade;

    #endregion

    #region Methods

    #region Constructors
    public Staff(int id, string nome, DateTime dataNascimento, string telemovel, CategoriaEnum categoria, EspecialidadeEnum especialidade) : base(id, nome, dataNascimento, telemovel)
    {
        this.categoria = categoria;
        this.especialidade = especialidade;
    }

    #endregion

    #region Properties

    public CategoriaEnum Categoria
    {
        get { return categoria; } 
        set { categoria = value; }
    }

    public EspecialidadeEnum Especialidade
    {
        get { return especialidade; }
        set { especialidade = value; }
    }

    #endregion

    #endregion
    }
}
