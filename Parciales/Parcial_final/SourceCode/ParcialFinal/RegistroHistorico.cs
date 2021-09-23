using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class RegistroHistorico : Form
    {
        public RegistroHistorico()
        {
            InitializeComponent();
            cargar();
        }
        private void cargar()
        {
            try
            {

                var dt = SQL.query($"SELECT idusuario,iddepartamento,nombre,apellido," +
                               $"dui,fechanacimiento FROM USUARIO");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error....");
            }
        }
        
    }
}