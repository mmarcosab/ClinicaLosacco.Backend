using System;


namespace ClinicaLosacco.Application.DbModels
{
    public class ConsultaDb
    {
        public int ConsultaId { get; set; }
        public MedicoDb Medico { get; set; }
        public PacienteDb Paciente { get; set; }
        public DateTime Data { get; set; } 

        public ConsultaDb(MedicoDb medico, PacienteDb paciente, DateTime data)
        {
            Medico = medico;
            Paciente = paciente;
            Data = data;
        }
    }

}
