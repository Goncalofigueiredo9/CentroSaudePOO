using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaude
{
    public class Gestao
    {
        #region Attributes

        Staff[] staffs;
        Utente[] utentes;
        Agendamento[] agendamentos;
        int staffCount = 0;
        int utenteCount = 0;
        int agendamentoCount = 0;

        #endregion

        #region Methods

        #region Constructors

        public Gestao(int maxStaff, int maxUtentes, int maxAgendamentos)
        {
            staffs = new Staff[maxStaff];
            utentes = new Utente[maxUtentes];
            agendamentos = new Agendamento[maxAgendamentos];
        }

        #endregion

        #region Properties

        public Staff[] Staffs
        {
            get { return staffs; }
            set { staffs = value; }
        }

  
        public Utente[] Utentes
        {
            get { return utentes; }
            set { utentes = value; }
        }

        public Agendamento[] Agendamentos
        {
            get { return agendamentos; }
            set { agendamentos = value; }
        }

        public int StaffCount
        {
            get { return staffCount; }
        }

        public int UtenteCount
        {
            get { return utenteCount; }
        }

        public int AgendamentoCount
        {
            get { return agendamentoCount; }
        }

        #endregion

        #region OtherMethods

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

