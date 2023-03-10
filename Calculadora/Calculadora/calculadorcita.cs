using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calculadorcita : Form
    {
        private Thread calculationThread;
        public calculadorcita()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void equalsButton_Click(object sender, EventArgs e)
        {
            // Crea el objeto CalculationThread y lo inicia
            calculationThread = new Thread(Calculate);
            calculationThread.Start();
        }

        private void Calculate()
        {
            // Obtiene el valor del inputTextBox y realiza la operación matemática correspondiente
            // Actualiza el resultado en el resultLabel
        }
    }
}
