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
    public class Staffs
    {
        #region Attributes

        private static List<Medico> medicos;

        #endregion

        #region Methods

        #region Constructors

        public Staffs()
        {
            medicos = new List<Medico>(); // Inicializa a lista de médicos
        }

        #endregion

        #region Properties

        public List<Medico> MedicosList
        {
            get { return medicos; }
        }


        #endregion

        #region OtherMethods

        /// <summary>
        /// Adiciona um médico à lista de médicos.
        /// </summary>
        /// <param name="medico">Objeto Medico a ser inserido.</param>
        /// <returns>Retorna true se o médico for inserido com sucesso, caso contrário, false.</returns>
        public static bool InserirMedico(Medico medico)
        {
            try
            {
                medicos.Add(medico);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se um médico já existe na lista com base no identificador profissional.
        /// </summary>
        /// <param name="identificadorProfissional">Identificador do médico a ser verificado.</param>
        /// <returns>Retorna true se o médico existir, caso contrário, false.</returns>
        public static bool ExisteMedico(string identificadorProfissional)
        {
            return medicos.Exists(m => m.IdentificadorProfissional == identificadorProfissional);
        }

        /// <summary>
        /// Remove um médico da lista com base no identificador profissional.
        /// </summary>
        /// <param name="identificadorProfissional">Identificador do médico a ser removido.</param>
        /// <returns>Retorna true se o médico for removido com sucesso, caso contrário, false.</returns>
        public static bool RemoverMedico(string identificadorProfissional)
        {
            try
            {
                Medico medico = EncontrarMedico(identificadorProfissional);
                medicos.Remove(medico);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Encontra um médico na lista com base no identificador profissional.
        /// </summary>
        /// <param name="identificadorProfissional">Identificador do médico a ser encontrado.</param>
        /// <returns>Retorna o médico encontrado ou null se não houver médico com esse identificador.</returns>
        public static Medico EncontrarMedico(string identificadorProfissional)
        {
            return medicos.Find(m => m.IdentificadorProfissional == identificadorProfissional);
        }

        /// <summary>
        /// Grava os médicos (staffs) em um arquivo JSON.
        /// </summary>
        /// <param name="nomeFicheiro">Caminho do ficheiro onde os médicos serão gravados.</param>
        /// <returns>Retorna true se a gravação for bem-sucedida, caso contrário, false.</returns>
        public static bool GravarMedicos(string nomeFicheiro)
        {
            try
            {
                // Cria um BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();

                // Cria um arquivo de saída para gravar os dados
                using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Create))
                {
                    // Serializa a lista de médicos em formato binário e grava no arquivo
                    formatter.Serialize(fs, medicos);
                }

                return true;
            }
            catch
            {
                // Caso ocorra algum erro ao gravar, retorna false
                return false;
            }
        }
        public static bool LerMedicos(string nomeFicheiro)
        {
            try
            {
                // Cria um BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();

                // Abre o arquivo para leitura
                using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Open))
                {
                    // Desserializa os dados binários e atribui à lista de médicos
                    medicos = (List<Medico>)formatter.Deserialize(fs);
                }

                return true;
            }
            catch
            {
                // Caso ocorra algum erro ao ler, retorna false
                return false;
            }
        }

        #endregion

        #endregion
    }
}
