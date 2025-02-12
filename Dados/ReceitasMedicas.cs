using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ObjetosdeNegocio;

namespace Dados
{
    public class ReceitasMedicas
    {
        #region Attributes

        private static List<ReceitaMedica> receitas;

        #endregion

        #region Methods

        #region Constructors
        // Construtor estático para inicializar a lista de receitas
        static ReceitasMedicas()
        {
            receitas = new List<ReceitaMedica>();
        }

        #endregion

        #region Properties
        // Propriedade para acessar a lista de receitas
        public static List<ReceitaMedica> ListaReceitas
        {
            get { return receitas; }
        }

        #endregion

        #region OtherMethods

        // Método para registrar uma nova receita médica
        public static bool RegistarReceita(ReceitaMedica receita)
        {
            try
            {
                receitas.Add(receita);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Método para remover uma receita pela instância do objeto
        public static bool RemoverReceita(ReceitaMedica receita)
        {
            try
            {
                receitas.Remove(receita);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Método para gravar as receitas em um arquivo JSON
    public static bool GravarReceitas(string nomeFicheiro)
    {
        try
        {
            using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, receitas);
            }
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

        /// <summary>
        /// Lê as receitas médicas de um arquivo binário.
        /// </summary>
        /// <param name="nomeFicheiro">Nome do arquivo a ser lido.</param>
        /// <returns>Retorna true se as receitas forem lidas com sucesso.</returns>
        public static bool LerReceitas(string nomeFicheiro)
        {
            try
            {
                using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    List<ReceitaMedica> receitasLidas = (List<ReceitaMedica>)formatter.Deserialize(fs);
                    receitas.AddRange(receitasLidas); // Adiciona as receitas lidas à lista existente
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #endregion
    }
}