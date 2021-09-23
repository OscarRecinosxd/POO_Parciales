using System;

namespace ParcialFinal
{
    public class Usuario
    {
        
        public int Departamento { get; set; }
        
        public string carne { get; set; }

        public string nombre { get; set; }
        
        public bool entrada { get; set; }
        public string apellido { get; set; }

        public string contrasenia { get; set; }
        
        public string dui { get; set; }
        public DateTime FechaNacimiento { get; set; } 


        /*public Usuario(int tipoUsuario, string carne, string nombre, string apellido, string contrasenia, DateTime fechaNacimiento)
        {
            TipoUsuario = tipoUsuario;
            this.carne = carne;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contrasenia = contrasenia;
            FechaNacimiento = fechaNacimiento;
        }*/
        
        public Usuario()
        {
            Departamento = 0;
            carne = "00000000";
            nombre = "";
            apellido = "";
            contrasenia = "";
            FechaNacimiento = DateTime.Today;
            dui = "";
            entrada = false;
        }
    }
}