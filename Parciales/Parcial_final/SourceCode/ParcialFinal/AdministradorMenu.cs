using System;
using System.Data;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class AdministradorMenu : Form
    {
        public AdministradorMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            Agregar_Usuario a = new Agregar_Usuario();
            a.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Usuario b = new Eliminar_Usuario();
            b.Show();
        }

        private void ReActual_Click(object sender, EventArgs e)
        {
            RegistroActual c = new RegistroActual();
            c.Show();
        }

        private void ReHistorico_Click(object sender, EventArgs e)
        {
            RegistroHistorico d = new RegistroHistorico();
            d.Show();
        }

        private void btnTopDepartamento_Click(object sender, EventArgs e)
        {

            string sql =
                $"SELECT d.nombre, count(u.idDepartamento) as frecuencia FROM REGISTRO r," +
                $" DEPARTAMENTO d, USUARIO u WHERE r.idUsuario = u.idUsuario" +
                $" AND d.idDepartamento = u.idDepartamento GROUP BY d.idDepartamento" +
                $" ORDER BY frecuencia DESC LIMIT 1;";
            
            DataTable dt = SQL.query(sql);
            
            DataRow row = dt.Rows[0];
            
            string aux = dt.Rows[0].ToString();
            
            aux = row[0].ToString();
            
            MessageBox.Show("El departamento mas concurrido es :" + aux);

        }
    }
}