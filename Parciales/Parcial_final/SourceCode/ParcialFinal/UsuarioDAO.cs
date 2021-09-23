using System;
using System.Collections.Generic;
using System.Data;

namespace ParcialFinal
{
    public static class UsuarioDAO
    {
        
        public static List<Usuario> getLista()
            {
                string sql = "SELECT *FROM USUARIO";

                DataTable dt = SQL.query(sql);

                List<Usuario> lista = new List<Usuario>();
                
                foreach (DataRow fila in dt.Rows)
                {
                    Usuario u = new Usuario();
                   
                    u.carne = fila[0].ToString();
                    
                    u.Departamento = Convert.ToInt32(fila[1].ToString());
                    
                    u.contrasenia = fila[2].ToString();
                    
                    u.nombre = fila[3].ToString();
                    
                    u.apellido = fila[4].ToString();
                    
                    u.dui =fila[5].ToString();
                    
                    u.FechaNacimiento = Convert.ToDateTime(fila[6].ToString());
                    lista.Add(u);
                }
                return lista;
            }
        
            public static List<Usuario> GetEmpleados()
            {
                string sql = "SELECT *FROM USUARIO ";

                DataTable dt = SQL.query(sql);

                List<Usuario> lista = new List<Usuario>();
                
                foreach (DataRow fila in dt.Rows)
                {
                    
                    Usuario u = new Usuario();
                    int aux = Convert.ToInt32(fila[1].ToString());
                    if (aux == 1)
                    {
                        u.carne = fila[0].ToString();

                        u.Departamento = Convert.ToInt32(fila[1].ToString());

                        u.contrasenia = fila[2].ToString();

                        u.nombre = fila[3].ToString();

                        u.apellido = fila[4].ToString();

                        u.dui = fila[5].ToString();

                        u.FechaNacimiento = Convert.ToDateTime(fila[6].ToString());
                        lista.Add(u);
                    }
                }
                return lista;
            }

        }
}