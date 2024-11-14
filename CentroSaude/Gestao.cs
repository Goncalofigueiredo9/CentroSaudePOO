using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    /// <summary>
    /// Classe que gerencia a lista de staff, utentes e agendamentos no sistema do Centro de Saúde.
    /// </summary>
    public class Gestao
    {
        #region Attributes

        /// <summary>Array de staff registado no sistema.
        /// Array de utentes registados no sistema.
        /// Array de agendamentos realizados.</summary>
        Staff[] staffs;
        Utente[] utentes;
        Agendamento[] agendamentos;
        /// <summary>
        /// Contador que mantém o número atual de staff registado.
        /// Contador que mantém o número atual de utentes registados.
        /// Contador que mantém o número atual de agendamentos realizados.
        /// </summary>
        int staffCount = 0;
        int utenteCount = 0;
        int agendamentoCount = 0;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Gestao"/> com limites máximos para
        /// staff, utentes e agendamentos.
        /// </summary>
        /// <param name="maxStaff">Número máximo de staff permitidos.</param>
        /// <param name="maxUtentes">Número máximo de utentes permitidos.</param>
        /// <param name="maxAgendamentos">Número máximo de agendamentos permitidos.</param>
        public Gestao(int maxStaff, int maxUtentes, int maxAgendamentos)
        {
            staffs = new Staff[maxStaff];
            utentes = new Utente[maxUtentes];
            agendamentos = new Agendamento[maxAgendamentos];
        }

        #endregion

        #region Properties
        /// <summary>
        /// Obtém ou define o array de staff registado.
        /// </summary>
        public Staff[] Staffs
        {
            get { return staffs; }
            set { staffs = value; }
        }
        /// <summary>
        /// Obtém ou define o array de utentes registados.
        /// </summary>
        public Utente[] Utentes
        {
            get { return utentes; }
            set { utentes = value; }
        }
        /// <summary>
        /// Obtém ou define o array de agendamentos realizados.
        /// </summary>
        public Agendamento[] Agendamentos
        {
            get { return agendamentos; }
            set { agendamentos = value; }
        }
        /// <summary>
        /// Obtém o número atual de staff registado.
        /// </summary>
        public int StaffCount
        {
            get { return staffCount; }
        }
        /// <summary>
        /// Obtém o número atual de utentes registados.
        /// </summary>
        public int UtenteCount
        {
            get { return utenteCount; }
        }
        /// <summary>
        /// Obtém o número atual de agendamentos realizados.
        /// </summary>
        public int AgendamentoCount
        {
            get { return agendamentoCount; }
        }

        #endregion

        #region OtherMethods
        /// <summary>
        /// Adiciona um novo membro de staff ao sistema, se o limite de staff não for atingido.
        /// </summary>
        /// <param name="staff">O membro de staff a ser adicionado.</param>
        public void AdicionarStaff(Staff staff)
        {
            if (staffCount < staffs.Length)
            {
                staffs[staffCount] = staff;
                staffCount++;
                Console.WriteLine("Staff adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Não é possível adicionar mais staff. Limite atingido.");
            }
        }
        /// <summary>
        /// Regista um novo utente no sistema, se o limite de utentes não for atingido.
        /// </summary>
        /// <param name="utente">O utente a ser registado.</param>
        public void RegistrarPaciente(Utente utente)
        {
            if (utenteCount < utentes.Length)
            {
                utentes[utenteCount] = utente;
                utenteCount++;
                Console.WriteLine("Paciente registrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Não é possível registrar mais pacientes. Limite atingido.");
            }
        }
        /// <summary>
        /// Cria um novo agendamento de consulta para o utente especificado, se o limite de agendamentos não for atingido.
        /// </summary>
        /// <param name="data">Data e hora da consulta.</param>
        /// <param name="staff">Staff responsável pela consulta.</param>
        /// <param name="utente">Utente para quem a consulta está agendada.</param>
        /// <param name="descricao">Descrição ou detalhes adicionais sobre a consulta.</param>
        public void FazerAgendamento(DateTime data, Staff staff, Utente utente, string descricao)
        {
            if (agendamentoCount < agendamentos.Length)
            {
                Agendamento agendamento = new Agendamento(data, staff, utente, descricao);
                agendamentos[agendamentoCount] = agendamento;
                agendamentoCount++;
                Console.WriteLine("Consulta agendada com sucesso!");
            }
            else
            {
                Console.WriteLine("Não é possível agendar mais consultas. Limite atingido.");
            }
        }

        #endregion

        #endregion
    }
}

