using System;
using System.Windows.Forms;

namespace ParcialFinal
{
    public partial class RegistroActual : Form
    {
        public RegistroActual()
        {
            InitializeComponent();
            Top1();
        }

        private void Top1()
        {
            try
            {
                var dt = SQL.query($"SELECT  DISTINCT idusuario," +
                                   $" entrada from REGISTRO where entrada = true");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            
            }
            catch (Exception )
            {
                MessageBox.Show("Error...");
            }
        }
    }
}