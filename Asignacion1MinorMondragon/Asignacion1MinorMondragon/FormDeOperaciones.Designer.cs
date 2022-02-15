
namespace Asignacion1MinorMondragon
{
    partial class FormDeOperaciones
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
            this.labelTipoDeOperacion = new System.Windows.Forms.Label();
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.textBoxValor2 = new System.Windows.Forms.TextBox();
            this.labelValor1 = new System.Windows.Forms.Label();
            this.labelValor2 = new System.Windows.Forms.Label();
            this.buttonRealizarOperacion = new System.Windows.Forms.Button();
            this.buttonCerrarFormulario = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTipoDeOperacion
            // 
            this.labelTipoDeOperacion.AutoSize = true;
            this.labelTipoDeOperacion.Location = new System.Drawing.Point(12, 18);
            this.labelTipoDeOperacion.Name = "labelTipoDeOperacion";
            this.labelTipoDeOperacion.Size = new System.Drawing.Size(0, 25);
            this.labelTipoDeOperacion.TabIndex = 0;
            this.labelTipoDeOperacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxValor1
            // 
            this.textBoxValor1.Location = new System.Drawing.Point(274, 55);
            this.textBoxValor1.Name = "textBoxValor1";
            this.textBoxValor1.Size = new System.Drawing.Size(150, 31);
            this.textBoxValor1.TabIndex = 1;
            // 
            // textBoxValor2
            // 
            this.textBoxValor2.Location = new System.Drawing.Point(274, 124);
            this.textBoxValor2.Name = "textBoxValor2";
            this.textBoxValor2.Size = new System.Drawing.Size(150, 31);
            this.textBoxValor2.TabIndex = 2;
            // 
            // labelValor1
            // 
            this.labelValor1.AutoSize = true;
            this.labelValor1.Location = new System.Drawing.Point(26, 61);
            this.labelValor1.Name = "labelValor1";
            this.labelValor1.Size = new System.Drawing.Size(212, 25);
            this.labelValor1.TabIndex = 3;
            this.labelValor1.Text = "Ingrese el primer numero";
            // 
            // labelValor2
            // 
            this.labelValor2.AutoSize = true;
            this.labelValor2.Location = new System.Drawing.Point(26, 130);
            this.labelValor2.Name = "labelValor2";
            this.labelValor2.Size = new System.Drawing.Size(230, 25);
            this.labelValor2.TabIndex = 4;
            this.labelValor2.Text = "Ingrese el segundo numero";
            // 
            // buttonRealizarOperacion
            // 
            this.buttonRealizarOperacion.Location = new System.Drawing.Point(26, 245);
            this.buttonRealizarOperacion.Name = "buttonRealizarOperacion";
            this.buttonRealizarOperacion.Size = new System.Drawing.Size(185, 34);
            this.buttonRealizarOperacion.TabIndex = 5;
            this.buttonRealizarOperacion.Text = "Realizar Operacion";
            this.buttonRealizarOperacion.UseVisualStyleBackColor = true;
            this.buttonRealizarOperacion.Click += new System.EventHandler(this.buttonRealizarOperacion_Click);
            // 
            // buttonCerrarFormulario
            // 
            this.buttonCerrarFormulario.Location = new System.Drawing.Point(252, 245);
            this.buttonCerrarFormulario.Name = "buttonCerrarFormulario";
            this.buttonCerrarFormulario.Size = new System.Drawing.Size(185, 34);
            this.buttonCerrarFormulario.TabIndex = 6;
            this.buttonCerrarFormulario.Text = "Cerrar";
            this.buttonCerrarFormulario.UseVisualStyleBackColor = true;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(26, 186);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 25);
            this.labelResultado.TabIndex = 7;
            // 
            // FormDeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 322);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCerrarFormulario);
            this.Controls.Add(this.buttonRealizarOperacion);
            this.Controls.Add(this.labelValor2);
            this.Controls.Add(this.labelValor1);
            this.Controls.Add(this.textBoxValor2);
            this.Controls.Add(this.textBoxValor1);
            this.Controls.Add(this.labelTipoDeOperacion);
            this.Name = "FormDeOperaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipoDeOperacion;
        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
        private System.Windows.Forms.Label labelValor1;
        private System.Windows.Forms.Label labelValor2;
        private System.Windows.Forms.Button buttonRealizarOperacion;
        private System.Windows.Forms.Button buttonCerrarFormulario;
        private System.Windows.Forms.Label labelResultado;
    }
}