using System;
using System.Data;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class EmpleadoMenu : Form
    {
        private Usuario pUsuario;
        public EmpleadoMenu(Usuario u)
        {
            InitializeComponent();
            pUsuario = u;
            
        }

        private void EmpleadoMenu_Load(object sender, EventArgs e)
        {
            try
            {
                //Se obtiene la tabla de registro para ese usuario
                string sql = $"SELECT idusuario,entrada,fechahora,temperatura " +
                             $"FROM REGISTRO WHERE idusuario='{pUsuario.carne}'";

                DataTable dt = SQL.query(sql);
                
                //Se clona la tabla
                DataTable dtCloned = dt.Clone();
                
                //Se cambia el tipo de booleano a string
                dtCloned.Columns[1].DataType = typeof(string);
                
                //copiamos el contenido a la otra tabla
                foreach (DataRow row in dt.Rows) 
                {
                    dtCloned.ImportRow(row);
                }
                
                //y ahora cambiamos el booleano por un string para que se comprenda mejor la tabla
                foreach (DataRow row in dtCloned.Rows)
                {
                    if (row[1].ToString().Equals("True"))
                    {
                        row[1] = "Entró";
                    }
                    else 
                    {
                        row[1] = "Salió";
                    }
                    
                }
                
                dataGridView1.DataSource = dtCloned;
                
            }
            catch (Exception )
            {
                MessageBox.Show("Ocurrió un error...");
            }            
        }
    }
}