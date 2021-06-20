

namespace ClinicaLosacco.Application.DbModels
{
    public class PlanoSaude
    {
        public int PlanoSaudeId { get; set; }
        public string Nome { get; set; }
        public string NumeroRegistro { get; set; }
        public string Tipo { get; set;}

        public PlanoSaude(string nome, string numeroRegistro, string tipo)
        {
            Nome = nome;
            NumeroRegistro = numeroRegistro;
            Tipo = tipo;
        }

    }
}
