using System;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class Eliminar_Usuario : Form
    {
        public Eliminar_Usuario()
        {
            InitializeComponent();
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                string usuario = ctEmpleado.Text;
                SQL.nonquery($"DELETE FROM USUARIO WHERE idUsuario = '{usuario}'");
                MessageBox.Show("Hecho!");
                poblar();
                
            }
            catch (Exception )
            {
                MessageBox.Show("Hubo un error...");
            }
        }

        private void Eliminar_Usuario_Load(object sender, EventArgs e)
        {
            poblar();   
        }

        private void poblar()
        {
            ctEmpleado.DataSource = null;
            ctEmpleado.ValueMember = "carne";
            ctEmpleado.DisplayMember = "carne";
            ctEmpleado.DataSource = UsuarioDAO.getLista();
        }
    }
}