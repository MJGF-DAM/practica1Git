using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbOrdinario.Checked = true; // Establece ordinario como opción predeterminada al arrancar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o'; // Solucionado por usuario 2
            int numPalabras = 0;
            double coste;

            //Leo el telegrama 
            textoTelegrama = txtTelegrama.Text;

            // Determinar tipo de telegrama mediante RadioButtons (Punto 19)
            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else if (rbOrdinario.Checked)
            {
                tipoTelegrama = 'o';
            }

            //Obtengo el número de palabras que forma el telegrama
            char[] chars = {' ', '.', ',', ';', ':', '?', '\n', '\r'}; // Solucionador por usuario 2
            numPalabras = textoTelegrama.Split(chars).Count();
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5; // Corregido por usuario 2
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10); // Corregido por usuario 2
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
