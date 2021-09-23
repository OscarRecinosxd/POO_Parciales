using System;

namespace ParcialFinal
{
    public class Registro
    {
        public Usuario u;

        public bool Entrada;

        public float temperatura;

        public DateTime EntradaHora;

        
        
        public Registro(Usuario u, bool entrada, float temperatura, DateTime entradaHora)
        {
            this.u = u;
            Entrada = entrada;
            this.temperatura = temperatura;
            EntradaHora = entradaHora;
        }
        
        
    }
}