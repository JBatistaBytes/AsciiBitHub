using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeanLuisBatistaACPrCoS1L
{
    public partial class baseControl : UserControl
    {
        public baseControl()
        {
            InitializeComponent();

            // Asociar eventos de los botones
            btnToDecimal.Click += btnToDecimal_Click;
            btnToBinary.Click += btnToBinary_Click;
        }

        // Convertir  binario a Decimal
        private void btnToDecimal_Click(object sender, EventArgs e)
        {
            string binaryInput = textBox1.Text.Trim();

            // Validar que solo contenga ceros y unos
            if (!Regex.IsMatch(binaryInput, "^[01]+$"))
            {
                MessageBox.Show("Por favor, ingrese un numero binario válido (solo 0 y 1).",
                                "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int decimalValue = Convert.ToInt32(binaryInput, 2);
                lblDecResult.Text = $"Resultado: {decimalValue}";
            }
            catch (OverflowException)
            {
                MessageBox.Show("El valor binario ingresado es demasiado grande.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Convertir decimal a binario
        private void btnToBinary_Click(object sender, EventArgs e)
        {
            int decimalInput = (int)numDecInput.Value;

            // Convertir a cadena binaria rellenando con ceros a la izquierda
            string binaryValue = Convert.ToString(decimalInput, 2);

            lblBinResult.Text = $"Resultado: {binaryValue}";
        }

        private void baseControl_Load(object sender, EventArgs e)
        {

        }

        private void linkAsciiReference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Abre la página web en el navegador predeterminado del sistema operativo
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.ascii-code.com/",
                    UseShellExecute = true // Requerido para .NET moderno y .NET Framework actual
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el navegador: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
