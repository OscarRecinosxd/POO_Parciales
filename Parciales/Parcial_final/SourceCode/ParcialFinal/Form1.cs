using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class Form1 : Form
    {
        private Usuario u;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }
        
        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasenia";
            cmbUsuario.DisplayMember = "carne";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textcontrasenia.Text.Equals(cmbUsuario.SelectedValue))
            {
                u = (Usuario) cmbUsuario.SelectedItem;

                switch (u.Departamento)
                {
                    case 1:
                        MessageBox.Show("Bienvenido empleado!");
                        
                        EmpleadoMenu a = new EmpleadoMenu(u);
                        
                        a.Show();
                        break;
                    
                    case 2:
                        MessageBox.Show("Bienvenido vigilante!");

                        VigilanteMenu n = new VigilanteMenu();
                        
                        n.Show();
                        
                        break;
                    
                    case 3:
                        MessageBox.Show("Bienvenido administrador!");
                        AdministradorMenu b = new AdministradorMenu();
                        b.Show();
                        break;
                    
                    default:
                        MessageBox.Show("ERROR");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
        
    }
}