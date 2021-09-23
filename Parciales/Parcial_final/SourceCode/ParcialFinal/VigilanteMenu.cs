using System;
using System.Data;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class VigilanteMenu : Form
    {
        private Usuario u;
        private bool entrada;
        public VigilanteMenu()
        {
            InitializeComponent();
        }

        private void btnPasarLista_Click(object sender, EventArgs e)
        {
            try
            {
                entrada = false;
                
                string carne = cmbEmpleados.SelectedValue.ToString();
                string FechaHora = DateTime.Now.ToString();
                
                
                entrada = entradaYSalida();
                
                
                if (entrada)
                {
                    entrada = false;
                }
                else
                {
                    entrada = true;
                }

                float temperatura = Convert.ToSingle(numUpDownTemperatura.Text);
                

                string sql = $"INSERT INTO REGISTRO(idusuario,entrada,fechahora,temperatura) " +
                             $" VALUES('{carne}',{entrada},'{FechaHora}',{temperatura})";
                
                SQL.nonquery(sql);
                entradaYSalida();
                MessageBox.Show("Lista pasada correctamente!");
               

            }
            catch (Exception )
            {
                MessageBox.Show("Hubo un error...");
            }
            
            
        }

        private void VigilanteMenu_Load(object sender, EventArgs e)
        {
            Poblar();
            entradaYSalida();
        }

        private void Poblar()
        {
            cmbEmpleados.DataSource = null;
            cmbEmpleados.ValueMember = "carne";
            cmbEmpleados.DisplayMember = "carne";
            cmbEmpleados.DataSource = UsuarioDAO.getLista();
            
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            entradaYSalida();
        }

        private bool entradaYSalida()
        {
            
            DataTable dta = SQL.query($"SELECT idusuario, entrada FROM REGISTRO WHERE idusuario = '{cmbEmpleados.Text}' ");
            
            foreach (DataRow fila in dta.Rows)
            {
                if (cmbEmpleados.Text.Equals(fila[0].ToString()))
                {
                    entrada = Convert.ToBoolean(fila[1]);
                }
            }
            
            if (entrada)
            {
                lblEntrada.Text = "Estado : Adentro ";
            }
            else
            {
                lblEntrada.Text = "Estado : afuera ";
            }
            
            return entrada;
        }
    }
}