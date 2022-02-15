using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asignacion1MinorMondragon
{
    public partial class FormDeOperaciones : Form
    {
        public FormDeOperaciones()
        {
            InitializeComponent();
        }

        Operaciones operaciones = new Operaciones();
        
        public void LimpiarTextbox()
        {
            textBoxValor1.Text = "";
            textBoxValor2.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonRealizarOperacion_Click(object sender, EventArgs e)
        {
            //verificamos que los textbox no esten vacios
            if(String.IsNullOrEmpty(textBoxValor1.Text) || String.IsNullOrEmpty(textBoxValor2.Text))
            {
                labelResultado.Text = "Por favor ingrese un numero en todos los espacios";
            }
            else
                if(Operaciones.OperacionSeleccionada == "Suma")
            {
                
                labelResultado.Text = operaciones.Sumar(double.Parse(textBoxValor1.Text), double.Parse(textBoxValor2.Text));
                LimpiarTextbox();
            }
            else
                if (Operaciones.OperacionSeleccionada == "Resta")
            {
                
                labelResultado.Text = operaciones.Restar(double.Parse(textBoxValor1.Text), double.Parse(textBoxValor2.Text));
                LimpiarTextbox();
            }
            else
                if (Operaciones.OperacionSeleccionada == "Multiplicacion")
            {
                
                labelResultado.Text = operaciones.Multiplicar(double.Parse(textBoxValor1.Text), double.Parse(textBoxValor2.Text));
                LimpiarTextbox();
            }
            else
                if (Operaciones.OperacionSeleccionada == "Division")
            {
                
                labelResultado.Text = operaciones.Dividir(double.Parse(textBoxValor1.Text), double.Parse(textBoxValor2.Text));
                LimpiarTextbox();
            }


        }
    }
}
