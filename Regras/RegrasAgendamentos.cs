/*
* Author: Gonçalo Figueiredo
* Email: a26747@alunos.ipca.pt
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using ObjetosdeNegocio;

namespace Regras
{
    /// <summary>
    /// Classe responsável pelas regras de negócio relacionadas a agendamentos.
    /// </summary>
    public class RegrasAgendamentos
    {
        /// <summary>
        /// Faz um agendamento.
        /// </summary>
        /// <param name="agendamento">O objeto Agendamento a ser agendado.</param>
        /// <returns>Retorna true se o agendamento for realizado com sucesso;</returns>
        /// <exception cref="ArgumentNullException">Lançado quando o agendamento é nulo.</exception>
        public bool ValidarFazerAgendamento(Agendamento agendamento)
        {
            if (agendamento == null || agendamento.Data <= DateTime.Now || string.IsNullOrEmpty(agendamento.TipoAgendamento))
            {
                return false;
            }

            return Agendamentos.FazerAgendamento(agendamento);
        }

        /// <summary>
        /// Remove um agendamento.
        /// </summary>
        /// <param name="agendamento">O objeto Agendamento a ser removido.</param>
        /// <returns>Retorna true se o agendamento for removido com sucesso; caso contrário, false.</returns>
        /// <exception cref="ArgumentNullException">Lançado quando o agendamento é nulo.</exception>
        public bool ValidarRemoverAgendamento(Agendamento agendamento)
        {
            if (agendamento == null)
            {
                return false;
            }

            if (agendamento.Data.Date != DateTime.Today)
            {
                return Agendamentos.RemoverAgendamento(agendamento);
            }

            return Agendamentos.RemoverAgendamento(agendamento);
        }

        /// <summary>
        /// Grava os agendamentos em um arquivo.
        /// </summary>
        /// <param name="nomeFicheiro">O nome do arquivo onde os agendamentos serão gravados.</param>
        /// <returns>Retorna true se os agendamentos forem gravados com sucesso; caso contrário, false.</returns>
        /// <exception cref="ArgumentException">Lançado quando o nome do arquivo é nulo ou vazio.</exception>
        public bool ValidarGravarAgendamentos(string nomeFicheiro, Agendamentos agendamentos)
        {
            if (string.IsNullOrEmpty(nomeFicheiro))
            {
                return false;
            }

            return Agendamentos.GravarAgendamentos(nomeFicheiro);
        }

        /// <summary>
        /// Lê os agendamentos de um arquivo.
        /// </summary>
        /// <param name="nomeFicheiro">O nome do arquivo de onde os agendamentos serão lidos.</param>
        /// <returns>Retorna true se os agendamentos forem lidos com sucesso; caso contrário, false.</returns>
        /// <exception cref="ArgumentException">Lançado quando o nome do arquivo é nulo ou vazio.</exception>
        public bool ValidarLerAgendamentos(string nomeFicheiro)
        {
            if (string.IsNullOrEmpty(nomeFicheiro) || !File.Exists(nomeFicheiro))
            {
                return false;
            }

            return Agendamentos.LerAgendamentos(nomeFicheiro);
        }

        public Agendamento ValidarProximoAgendamento()
        {
            try
            {
                // Regra adicional: só retorna o próximo agendamento se for dentro dos próximos 30 dias
                Agendamento proximo = Agendamentos.ProximoAgendamento();

                if (proximo != null && proximo.Data <= DateTime.Now.AddDays(30))
                {
                    return proximo;
                }

                // Se não houver agendamento no prazo, retorna null
                return null;
            }
            catch (Exception)
            {
                return null; // Trata exceções que possam ocorrer
            }
        }
    }
}