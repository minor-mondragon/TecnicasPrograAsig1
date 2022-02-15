
namespace Asignacion1MinorMondragon
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMainTittle = new System.Windows.Forms.Label();
            this.radioButtonSuma = new System.Windows.Forms.RadioButton();
            this.RadioButtonResta = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplicacion = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonNumeroPrimo = new System.Windows.Forms.RadioButton();
            this.radioButtonNumeroPalindromo = new System.Windows.Forms.RadioButton();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMainTittle
            // 
            this.labelMainTittle.AutoSize = true;
            this.labelMainTittle.Location = new System.Drawing.Point(12, 18);
            this.labelMainTittle.Name = "labelMainTittle";
            this.labelMainTittle.Size = new System.Drawing.Size(342, 25);
            this.labelMainTittle.TabIndex = 0;
            this.labelMainTittle.Text = "Seleccione la operacion que desea realizar";
            this.labelMainTittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonSuma
            // 
            this.radioButtonSuma.AutoSize = true;
            this.radioButtonSuma.Location = new System.Drawing.Point(12, 55);
            this.radioButtonSuma.Name = "radioButtonSuma";
            this.radioButtonSuma.Size = new System.Drawing.Size(82, 29);
            this.radioButtonSuma.TabIndex = 1;
            this.radioButtonSuma.TabStop = true;
            this.radioButtonSuma.Text = "Suma";
            this.radioButtonSuma.UseVisualStyleBackColor = true;
            this.radioButtonSuma.CheckedChanged += new System.EventHandler(this.radioButtonSuma_CheckedChanged);
            // 
            // RadioButtonResta
            // 
            this.RadioButtonResta.AutoSize = true;
            this.RadioButtonResta.Location = new System.Drawing.Point(12, 90);
            this.RadioButtonResta.Name = "RadioButtonResta";
            this.RadioButtonResta.Size = new System.Drawing.Size(79, 29);
            this.RadioButtonResta.TabIndex = 2;
            this.RadioButtonResta.TabStop = true;
            this.RadioButtonResta.Text = "Resta";
            this.RadioButtonResta.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiplicacion
            // 
            this.radioButtonMultiplicacion.AutoSize = true;
            this.radioButtonMultiplicacion.Location = new System.Drawing.Point(12, 125);
            this.radioButtonMultiplicacion.Name = "radioButtonMultiplicacion";
            this.radioButtonMultiplicacion.Size = new System.Drawing.Size(146, 29);
            this.radioButtonMultiplicacion.TabIndex = 3;
            this.radioButtonMultiplicacion.TabStop = true;
            this.radioButtonMultiplicacion.Text = "Multiplicacion";
            this.radioButtonMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(12, 160);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(100, 29);
            this.radioButtonDivision.TabIndex = 4;
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.Text = "Division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumeroPrimo
            // 
            this.radioButtonNumeroPrimo.AutoSize = true;
            this.radioButtonNumeroPrimo.Location = new System.Drawing.Point(12, 195);
            this.radioButtonNumeroPrimo.Name = "radioButtonNumeroPrimo";
            this.radioButtonNumeroPrimo.Size = new System.Drawing.Size(273, 29);
            this.radioButtonNumeroPrimo.TabIndex = 5;
            this.radioButtonNumeroPrimo.TabStop = true;
            this.radioButtonNumeroPrimo.Text = "Verificacion de Numero Primo";
            this.radioButtonNumeroPrimo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumeroPalindromo
            // 
            this.radioButtonNumeroPalindromo.AutoSize = true;
            this.radioButtonNumeroPalindromo.Location = new System.Drawing.Point(12, 230);
            this.radioButtonNumeroPalindromo.Name = "radioButtonNumeroPalindromo";
            this.radioButtonNumeroPalindromo.Size = new System.Drawing.Size(317, 29);
            this.radioButtonNumeroPalindromo.TabIndex = 6;
            this.radioButtonNumeroPalindromo.TabStop = true;
            this.radioButtonNumeroPalindromo.Text = "Verificacion de Numero Palindromo";
            this.radioButtonNumeroPalindromo.UseVisualStyleBackColor = true;
            this.radioButtonNumeroPalindromo.CheckedChanged += new System.EventHandler(this.rbNumPalindromo_CheckedChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAceptar.Location = new System.Drawing.Point(28, 296);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(112, 34);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalir.Location = new System.Drawing.Point(217, 296);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(112, 34);
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // MainMenu
            // 
            this.AcceptButton = this.buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(383, 356);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.radioButtonNumeroPalindromo);
            this.Controls.Add(this.radioButtonNumeroPrimo);
            this.Controls.Add(this.radioButtonDivision);
            this.Controls.Add(this.radioButtonMultiplicacion);
            this.Controls.Add(this.RadioButtonResta);
            this.Controls.Add(this.radioButtonSuma);
            this.Controls.Add(this.labelMainTittle);
            this.Name = "MainMenu";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTittle;
        private System.Windows.Forms.RadioButton radioButtonSuma;
        private System.Windows.Forms.RadioButton RadioButtonResta;
        private System.Windows.Forms.RadioButton radioButtonMultiplicacion;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonNumeroPrimo;
        private System.Windows.Forms.RadioButton radioButtonNumeroPalindromo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonSalir;
    }
}

