using System;


namespace ClinicaLosacco.Core.Entities
{
    public class Consulta
    {
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime Data { get; set; } 

        public Consulta(Medico medico, Paciente paciente, DateTime data)
        {
            validarCampos(medico, paciente, data);
            Medico = medico;
            Paciente = paciente;
            Data = data;
        }
        public void validarCampos(Medico medico, Paciente paciente, DateTime data)
        {
            if(medico == null)
            {
                throw new ArgumentNullException("Campo " + nameof(medico) + " deve ser informado");
            }
            if (paciente == null)
            {
                throw new ArgumentNullException("Campo " + nameof(paciente) + " deve ser informado");
            }
            if (data == null)
            {
                throw new ArgumentNullException("Campo " + nameof(data) + " deve ser informado");
            }
        }
    }
}
