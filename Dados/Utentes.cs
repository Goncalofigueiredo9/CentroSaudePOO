/*
* Author: Gonçalo Figueiredo
* Email: a26747@alunos.ipca.pt
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ObjetosdeNegocio;

namespace Dados
{
    public class Utentes
    {
        #region Attributes

        private static List<Utente> utentes;

        #endregion

        #region Methods

        #region Constructors

        public Utentes()
        {
            utentes = new List<Utente>();  // Inicializa a lista de utentes
        }

        #endregion

        #region Properties

        public List<Utente> UtentesList
        {
            get { return utentes; }
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Regista um novo utente no sistema.
        /// </summary>
        /// <param name="utente">Instância de um objeto Utente a ser registado.</param>
        /// <returns>Retorna true se o utente for registrado com sucesso.</returns>
        public static bool RegistarUtente(Utente utente)
        {
            if (utente == null)
            {
                return false;
            }
               
            // Verifica se o número do utente já existe
            if (ExisteUtente(utente.NumeroUtente))
            {
                return false;
            }

            utentes.Add(utente);
            return true;
        }

        /// <summary>
        /// Remove um utente do sistema baseado no número de utente.
        /// </summary>
        /// <param name="numeroUtente">Número de utente do utente a ser removido.</param>
        /// <returns>Retorna true se o utente for removido com sucesso.</returns>
        public static bool RemoverUtente(string numeroUtente)
        {
            Utente utente = EncontrarUtente(numeroUtente);
            if (utente != null)
            {
                utentes.Remove(utente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica se um utente existe no sistema com base no número de utente.
        /// </summary>
        /// <param name="numeroUtente">Número de utente a ser verificado.</param>
        /// <returns>Retorna true se o utente existe, caso contrário, false.</returns>
        public static bool ExisteUtente(string numeroUtente)
        {
            return utentes.Exists(u => u.NumeroUtente == numeroUtente);
        }

        /// <summary>
        /// Encontra um utente no sistema com base no número de utente.
        /// </summary>
        /// <param name="numeroUtente">Número de utente a ser procurado.</param>
        /// <returns>Retorna o utente encontrado ou null se não houver utente com esse número.</returns>
        public static Utente EncontrarUtente(string numeroUtente)
        {
            return utentes.Find(u => u.NumeroUtente == numeroUtente);
        }

        /// <summary>
        /// Grava os utentes no ficheiro especificado.
        /// </summary>
        /// <param name="nomeFicheiro">Caminho do ficheiro onde os utentes serão gravados.</param>
        /// <returns>Retorna true se a gravação for bem-sucedida.</returns>
        public static bool GravarUtentes(string nomeFicheiro)
        {
            try
            {
                // Cria um BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();

                // Cria ou abre o arquivo de saída para gravar os dados
                using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Create))
                {
                    // Serializa a lista de utentes em formato binário e grava no arquivo
                    formatter.Serialize(fs, utentes);
                }

                return true;
            }
            catch (Exception)
            {
                // Caso ocorra algum erro ao gravar, retorna false
                return false;
            }
        }

        /// <summary>
        /// Lê os utentes do ficheiro especificado.
        /// </summary>
        /// <param name="nomeFicheiro">Caminho do ficheiro de onde os utentes serão lidos.</param>
        /// <returns>Retorna true se a leitura for bem-sucedida.</returns>
        public static bool LerUtentes(string nomeFicheiro)
        {
            try
            {

                // Cria um BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();

                // Abre o arquivo para leitura
                using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Open))
                {
                    // Desserializa os dados binários e atribui à lista de utentes
                    utentes = (List<Utente>)formatter.Deserialize(fs);
                }

                return true;
            }
            catch (Exception)
            {
                // Caso ocorra algum erro ao ler, retorna false
                return false;
            }
        }

        #endregion

        #endregion
    }
}


