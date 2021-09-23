using System.ComponentModel;

namespace ParcialFinal
{
    partial class Agregar_Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioEmpleado = new System.Windows.Forms.RadioButton();
            this.radioVigilante = new System.Windows.Forms.RadioButton();
            this.radioAdministracion = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.dateUsuario = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carne";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(86, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dui";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(86, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(86, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(77, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha nacimiento";
            // 
            // radioEmpleado
            // 
            this.radioEmpleado.Location = new System.Drawing.Point(77, 348);
            this.radioEmpleado.Name = "radioEmpleado";
            this.radioEmpleado.Size = new System.Drawing.Size(388, 62);
            this.radioEmpleado.TabIndex = 5;
            this.radioEmpleado.TabStop = true;
            this.radioEmpleado.Text = "Empleado";
            this.radioEmpleado.UseVisualStyleBackColor = true;
            // 
            // radioVigilante
            // 
            this.radioVigilante.Location = new System.Drawing.Point(188, 367);
            this.radioVigilante.Name = "radioVigilante";
            this.radioVigilante.Size = new System.Drawing.Size(99, 24);
            this.radioVigilante.TabIndex = 6;
            this.radioVigilante.TabStop = true;
            this.radioVigilante.Text = "Vigilante";
            this.radioVigilante.UseVisualStyleBackColor = true;
            // 
            // radioAdministracion
            // 
            this.radioAdministracion.Location = new System.Drawing.Point(293, 369);
            this.radioAdministracion.Name = "radioAdministracion";
            this.radioAdministracion.Size = new System.Drawing.Size(119, 20);
            this.radioAdministracion.TabIndex = 7;
            this.radioAdministracion.TabStop = true;
            this.radioAdministracion.Text = "Administracion";
            this.radioAdministracion.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(199, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 51);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(278, 68);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(186, 23);
            this.txtCarne.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(278, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 23);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(278, 182);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(186, 23);
            this.txtApellido.TabIndex = 11;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(278, 240);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(186, 23);
            this.txtDui.TabIndex = 12;
            // 
            // dateUsuario
            // 
            this.dateUsuario.Location = new System.Drawing.Point(255, 297);
            this.dateUsuario.Name = "dateUsuario";
            this.dateUsuario.Size = new System.Drawing.Size(226, 23);
            this.dateUsuario.TabIndex = 13;
            // 
            // Agregar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(556, 519);
            this.Controls.Add(this.dateUsuario);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.radioAdministracion);
            this.Controls.Add(this.radioVigilante);
            this.Controls.Add(this.radioEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioEmpleado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton radioAdministracion;
        private System.Windows.Forms.RadioButton radioVigilante;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.DateTimePicker dateUsuario;
    }
}