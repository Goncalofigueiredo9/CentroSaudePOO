using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosdeNegocio;
using Dados;

namespace Regras
{
    public class RegrasStaffs
    {
        // Método para inserir um novo médico
        public bool ValidarInserirMedico(Medico medico)
        {
            if (medico == null || string.IsNullOrEmpty(medico.IdentificadorProfissional) || Staffs.ExisteMedico(medico.IdentificadorProfissional))
            {
                return false;
            }

            return Staffs.InserirMedico(medico);
        }

        // Método para remover um médico pelo identificador profissional
        public bool ValidarRemoverMedico(string identificadorProfissional)
        {
            if (string.IsNullOrEmpty(identificadorProfissional))
            {
                return false;
            }

            return Staffs.RemoverMedico(identificadorProfissional);
        }

        // Método para gravar médicos em um arquivo
        public bool ValidarGravarMedicos(string nomeFicheiro)
        {
            if (string.IsNullOrEmpty(nomeFicheiro))
            {
                return false;
            }

            return Staffs.GravarMedicos(nomeFicheiro);
        }

        // Método para ler médicos de um arquivo
        public bool ValidarLerMedicos(string nomeFicheiro)
        {
            if (string.IsNullOrEmpty(nomeFicheiro))
            {
                return false;
            }

            return Staffs.LerMedicos(nomeFicheiro);
        }

        // Método para encontrar um médico pelo identificador profissional
        public Medico ValidarExisteMedico(string identificadorProfissional)
        {
            if (string.IsNullOrEmpty(identificadorProfissional))
            {
                return null;
            }

            return Staffs.EncontrarMedico(identificadorProfissional);
        }
    }
}
