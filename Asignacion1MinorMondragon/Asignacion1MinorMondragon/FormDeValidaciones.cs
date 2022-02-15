using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asignacion1MinorMondragon
{
    public partial class FormDeValidaciones : Form
    {
        public FormDeValidaciones()
        {
            InitializeComponent();
        }
        Operaciones operaciones = new Operaciones();
        
        public void LimpiarTextbox()
        {
            textBoxValor1.Text = "";

        }
        private void buttonRealizarOperacion_Click(object sender, EventArgs e)
        {
            //verificamos que el textbox no este vacio
            if (String.IsNullOrEmpty(textBoxValor1.Text))
            {
                labelResultado.Text = "Por favor ingrese un numero en todos los espacios";
            }
            else
                if (Operaciones.OperacionSeleccionada == "Verificar Numero Primo")
            {
                
                labelResultado.Text = operaciones.VerificarNumeroPrimo(int.Parse(textBoxValor1.Text));
                LimpiarTextbox();
            }
            else
                if (Operaciones.OperacionSeleccionada == "Verificar si Numero es Palindromo")
            {
                labelResultado.Text = operaciones.VerificarNumeroPalindromo(int.Parse(textBoxValor1.Text));
                LimpiarTextbox();
            }
        }
    }
}
