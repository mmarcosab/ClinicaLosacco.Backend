

namespace ClinicaLosacco.Core.DbModels
{
    public class PlanoSaudeDb
    {
        public int PlanoSaudeId { get; set; }
        public string Nome { get; set; }
        public string NumeroRegistro { get; set; }
        public string Tipo { get; set;}

        public PlanoSaudeDb(string nome, string numeroRegistro, string tipo)
        {
            Nome = nome;
            NumeroRegistro = numeroRegistro;
            Tipo = tipo;
        }

    }
}
