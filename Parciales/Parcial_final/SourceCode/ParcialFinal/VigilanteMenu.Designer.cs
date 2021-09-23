using System.ComponentModel;

namespace ParcialFinal
{
    partial class VigilanteMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownTemperatura = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPasarLista = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.numUpDownTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(227, 92);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(172, 23);
            this.cmbEmpleados.TabIndex = 0;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // numUpDownTemperatura
            // 
            this.numUpDownTemperatura.DecimalPlaces = 1;
            this.numUpDownTemperatura.Location = new System.Drawing.Point(227, 142);
            this.numUpDownTemperatura.Maximum = new decimal(new int[] {50, 0, 0, 0});
            this.numUpDownTemperatura.Name = "numUpDownTemperatura";
            this.numUpDownTemperatura.Size = new System.Drawing.Size(136, 23);
            this.numUpDownTemperatura.TabIndex = 2;
            this.numUpDownTemperatura.Value = new decimal(new int[] {15, 0, 0, 0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura";
            // 
            // btnPasarLista
            // 
            this.btnPasarLista.Location = new System.Drawing.Point(296, 216);
            this.btnPasarLista.Name = "btnPasarLista";
            this.btnPasarLista.Size = new System.Drawing.Size(103, 65);
            this.btnPasarLista.TabIndex = 4;
            this.btnPasarLista.Text = "Pasar lista";
            this.btnPasarLista.UseVisualStyleBackColor = true;
            this.btnPasarLista.Click += new System.EventHandler(this.btnPasarLista_Click);
            // 
            // lblEntrada
            // 
            this.lblEntrada.Location = new System.Drawing.Point(45, 238);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(134, 43);
            this.lblEntrada.TabIndex = 5;
            this.lblEntrada.Text = "Estado :";
            // 
            // VigilanteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(481, 381);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.btnPasarLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpDownTemperatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VigilanteMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VigilanteMenu";
            this.Load += new System.EventHandler(this.VigilanteMenu_Load);
            ((System.ComponentModel.ISupportInitialize) (this.numUpDownTemperatura)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnPasarLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.NumericUpDown numUpDownTemperatura;
        private System.Windows.Forms.Label lblEntrada;
    }
}