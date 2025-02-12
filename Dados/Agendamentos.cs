/*
* Author: Gonçalo Figueiredo
* Email: a26747@alunos.ipca.pt
*/
using System;
using System.Collections.Generic;
using System.IO;
using ObjetosdeNegocio;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    public class Agendamentos
    {
        #region Attributes

        private static List<Agendamento> agendamentos;

        #endregion

        #region Methods

        #region Constructors
        static Agendamentos()
        {
            agendamentos = new List<Agendamento>();
        }

        #endregion

        #region Properties

        public static List<Agendamento> ListaAgendamentos
        {
            get { return agendamentos; }
        }


        #endregion

        #region OtherMethods

        /// <summary>
        /// Registra um novo agendamento no sistema.
        /// </summary>
        /// <param name="agendamento">Instância do agendamento a ser registrado.</param>
        /// <returns>Retorna true se o agendamento for registrado com sucesso.</returns>
        public static bool FazerAgendamento(Agendamento agendamento)
        {
            try
            {
                agendamentos.Add(agendamento);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Remove um agendamento do sistema baseado na instância do objeto.
        /// </summary>
        /// <param name="agendamento">Instância do agendamento a ser removido.</param>
        /// <returns>Retorna true se o agendamento for removido com sucesso.</returns>
        public static bool RemoverAgendamento(Agendamento agendamento)
        {
            try
            {
                agendamentos.Remove(agendamento);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        /// <summary>
        /// Grava os agendamentos em um arquivo JSON.
        /// </summary>
        /// <param name="nomeFicheiro">Nome do arquivo onde os agendamentos serão salvos.</param>
        /// <returns>Retorna true se os agendamentos forem gravados com sucesso.</returns>
        public static bool GravarAgendamentos(string nomeFicheiro)
        {
            try
            {
                using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, agendamentos);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Lê os agendamentos de um arquivo binário.
        /// </summary>
        /// <param name="nomeFicheiro">Nome do ficheiro a ser lido.</param>
        /// <returns>Retorna true se os agendamentos forem lidos com sucesso.</returns>
        public static bool LerAgendamentos(string nomeFicheiro)
        {
            try
            {
                using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    agendamentos = (List<Agendamento>)formatter.Deserialize(fs);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna o próximo agendamento baseado na data.
        /// </summary>
        /// <returns>Retorna o próximo agendamento ou null se não houver agendamentos futuros.</returns>
        public static Agendamento ProximoAgendamento()
        {
            DateTime dataAtual = DateTime.Now;

            try
            {
                return agendamentos
                    .Where(a => a.Data > dataAtual)
                    .OrderBy(a => a.Data)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #endregion
    }
}