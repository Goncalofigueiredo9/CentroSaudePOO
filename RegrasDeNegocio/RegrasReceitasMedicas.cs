using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using ObjetosdeNegocio;

namespace Regras
{
    public class RegrasReceitasMedicas
    {
        // Método para registar uma nova receita médica
        public bool ValidarRegistarReceita(ReceitaMedica receita)
        {
            if (receita == null || receita.Medico == null || receita.Utente == null || receita.DataEmissao > DateTime.Now || string.IsNullOrEmpty(receita.Descricao))
            {
                return false;
            }

            return ReceitasMedicas.RegistarReceita(receita);
        }

        // Método para remover uma receita médica
        public bool ValidarRemoverReceita(ReceitaMedica receita)
        {
            if (receita == null)
            {
                return false;
            }

            return ReceitasMedicas.RemoverReceita(receita);
        }

        // Método para gravar as receitas em um arquivo
        public bool ValidarGravarReceitas(string nomeFicheiro)
        {
            if (string.IsNullOrEmpty(nomeFicheiro))
            {
                return false;
            }

            return ReceitasMedicas.GravarReceitas(nomeFicheiro);
        }

        // Método para ler as receitas de um arquivo
        public bool ValidarLerReceitas(string nomeFicheiro)
        {
            if (string.IsNullOrEmpty(nomeFicheiro))
            {
                return false;
            }

            return ReceitasMedicas.LerReceitas(nomeFicheiro);
        }
    }
}