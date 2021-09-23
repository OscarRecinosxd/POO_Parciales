using System;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class Agregar_Usuario : Form
    {
        public Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                string carne = txtCarne.Text;
                int departamento=0;
                string contrasenia = txtNombre.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dui = txtDui.Text;
                DateTime fechanacimiento = dateUsuario.Value;

                if (radioEmpleado.Checked)
                    departamento = 1;
                else if (radioVigilante.Checked)
                    departamento = 2;
                else if (radioAdministracion.Checked)
                    departamento = 3;

                string sql = $"INSERT INTO USUARIO VALUES('{carne}',{departamento},'{contrasenia}'," +
                             $"'{nombre}','{apellido}','{dui}','{fechanacimiento}') ";

                SQL.nonquery(sql);
                MessageBox.Show("Usuario agregado conrrectamente!");
            }
            catch (Exception )
            {
                MessageBox.Show("Error!");
            }
            
        }
    }
}