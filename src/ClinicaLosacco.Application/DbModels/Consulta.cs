using System;


namespace ClinicaLosacco.Application.DbModels
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime Data { get; set; } 

        public Consulta(Medico medico, Paciente paciente, DateTime data)
        {
            Medico = medico;
            Paciente = paciente;
            Data = data;
        }
    }

}
