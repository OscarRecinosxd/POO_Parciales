using System.ComponentModel;

namespace ParcialFinal
{
    partial class AdministradorMenu
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
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.ReActual = new System.Windows.Forms.Button();
            this.ReHistorico = new System.Windows.Forms.Button();
            this.btnTopDepartamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(76, 42);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(150, 76);
            this.btnAgregarUsuarios.TabIndex = 0;
            this.btnAgregarUsuarios.Text = "Agregar Usuarios";
            this.btnAgregarUsuarios.UseVisualStyleBackColor = true;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(76, 186);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 76);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Usuarios";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ReActual
            // 
            this.ReActual.Location = new System.Drawing.Point(332, 42);
            this.ReActual.Name = "ReActual";
            this.ReActual.Size = new System.Drawing.Size(150, 76);
            this.ReActual.TabIndex = 2;
            this.ReActual.Text = "Registro actual";
            this.ReActual.UseVisualStyleBackColor = true;
            this.ReActual.Click += new System.EventHandler(this.ReActual_Click);
            // 
            // ReHistorico
            // 
            this.ReHistorico.Location = new System.Drawing.Point(332, 186);
            this.ReHistorico.Name = "ReHistorico";
            this.ReHistorico.Size = new System.Drawing.Size(150, 76);
            this.ReHistorico.TabIndex = 3;
            this.ReHistorico.Text = "Registro Historico";
            this.ReHistorico.UseVisualStyleBackColor = true;
            this.ReHistorico.Click += new System.EventHandler(this.ReHistorico_Click);
            // 
            // btnTopDepartamento
            // 
            this.btnTopDepartamento.Location = new System.Drawing.Point(201, 294);
            this.btnTopDepartamento.Name = "btnTopDepartamento";
            this.btnTopDepartamento.Size = new System.Drawing.Size(170, 73);
            this.btnTopDepartamento.TabIndex = 4;
            this.btnTopDepartamento.Text = "Departamento mas concurrido";
            this.btnTopDepartamento.UseVisualStyleBackColor = true;
            this.btnTopDepartamento.Click += new System.EventHandler(this.btnTopDepartamento_Click);
            // 
            // AdministradorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(583, 403);
            this.Controls.Add(this.btnTopDepartamento);
            this.Controls.Add(this.ReHistorico);
            this.Controls.Add(this.ReActual);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministradorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministradorMenu";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button ReActual;
        private System.Windows.Forms.Button ReHistorico;
        private System.Windows.Forms.Button btnTopDepartamento;
    }
}