namespace TopIndicators
{
    internal class ParadaLinha
    {
        public string Tempo { get; set; }
        public string Tipo { get; set; }

        public ParadaLinha(string tempo, string tipo)
        {
            Tempo = tempo;
            Tipo = tipo;
        }
    }
}