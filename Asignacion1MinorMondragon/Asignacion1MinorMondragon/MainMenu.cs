using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignacion1MinorMondragon
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        Operaciones operaciones = new Operaciones();
        Form formularioOperaciones = new FormDeOperaciones();
        Form formularioValidaciones = new FormDeValidaciones();
        

        public void AbrirFormularioOpeariones(string tipoDeOperacion)
        {            
            formularioOperaciones.Show();
            formularioOperaciones.Text = tipoDeOperacion;
            
        }

        public void AbrirFormularioValidaciones(string tipoDeOperacion)
        {
            formularioValidaciones.Show();
            formularioValidaciones.Text = tipoDeOperacion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbNumPalindromo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSuma_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        //verifica la opcion que se encuentra seleccionada y abre un formulario con las opciones necesarias
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (radioButtonSuma.Checked == true)
            {
                AbrirFormularioOpeariones("Suma");
                Operaciones.OperacionSeleccionada = "Suma";
                
            }
            else
                if(RadioButtonResta.Checked == true)
            {
                AbrirFormularioOpeariones("Resta");
                Operaciones.OperacionSeleccionada = "Resta";
            }
            else
                if(radioButtonMultiplicacion.Checked == true)
            {
                AbrirFormularioOpeariones("Multiplicacion");
                Operaciones.OperacionSeleccionada = "Multiplicacion";
            }
            else
                if(radioButtonDivision.Checked == true)
            {
                AbrirFormularioOpeariones("Division");
                Operaciones.OperacionSeleccionada = "Division";
            }
            else
                if (radioButtonNumeroPrimo.Checked == true)
            {
                AbrirFormularioValidaciones("Verificar Numero Primo");
                Operaciones.OperacionSeleccionada = "Verificar Numero Primo";
            }
            else
                if (radioButtonNumeroPalindromo.Checked == true)
            {
                AbrirFormularioValidaciones("Verificar si Numero es Palindromo");
                Operaciones.OperacionSeleccionada = "Verificar si Numero es Palindromo";
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
