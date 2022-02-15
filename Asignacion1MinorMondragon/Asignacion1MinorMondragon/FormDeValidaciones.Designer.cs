
namespace Asignacion1MinorMondragon
{
    partial class FormDeValidaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.buttonRealizarOperacion = new System.Windows.Forms.Button();
            this.buttonCerrarFormulario = new System.Windows.Forms.Button();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRealizarOperacion
            // 
            this.buttonRealizarOperacion.Location = new System.Drawing.Point(26, 245);
            this.buttonRealizarOperacion.Name = "buttonRealizarOperacion";
            this.buttonRealizarOperacion.Size = new System.Drawing.Size(185, 34);
            this.buttonRealizarOperacion.TabIndex = 6;
            this.buttonRealizarOperacion.Text = "Realizar Operacion";
            this.buttonRealizarOperacion.UseVisualStyleBackColor = true;
            this.buttonRealizarOperacion.Click += new System.EventHandler(this.buttonRealizarOperacion_Click);
            // 
            // buttonCerrarFormulario
            // 
            this.buttonCerrarFormulario.Location = new System.Drawing.Point(252, 245);
            this.buttonCerrarFormulario.Name = "buttonCerrarFormulario";
            this.buttonCerrarFormulario.Size = new System.Drawing.Size(185, 34);
            this.buttonCerrarFormulario.TabIndex = 7;
            this.buttonCerrarFormulario.Text = "Cerrar";
            this.buttonCerrarFormulario.UseVisualStyleBackColor = true;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(26, 113);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(226, 25);
            this.labelValor.TabIndex = 9;
            this.labelValor.Text = "Ingrese el numero a validar";
            // 
            // textBoxValor1
            // 
            this.textBoxValor1.Location = new System.Drawing.Point(274, 107);
            this.textBoxValor1.Name = "textBoxValor1";
            this.textBoxValor1.Size = new System.Drawing.Size(150, 31);
            this.textBoxValor1.TabIndex = 8;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(26, 179);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 25);
            this.labelResultado.TabIndex = 10;
            // 
            // FormDeValidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 322);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxValor1);
            this.Controls.Add(this.buttonCerrarFormulario);
            this.Controls.Add(this.buttonRealizarOperacion);
            this.Name = "FormDeValidaciones";
            this.Text = "FormDeValidaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRealizarOperacion;
        private System.Windows.Forms.Button buttonCerrarFormulario;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.Label labelResultado;
    }
}