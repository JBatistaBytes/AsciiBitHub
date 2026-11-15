using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeanLuisBatistaACPrCoS1L
{
    public partial class AsciiControl : UserControl
    {
        public AsciiControl()
        {
            InitializeComponent();

            // Asociar eventos de los botones
            btnToChar.Click += btnToChar_Click;
            btnToAscii.Click += btnToAscii_Click;
        }

        // Convertir numero ASCII a caracter
        private void btnToChar_Click(object sender, EventArgs e)
        {
            int asciiCode = (int)numAsciiInput.Value;
            char character = (char)asciiCode;

            if (char.IsControl(character))
            {
                lblCharResult.Text = $"Resultado: '{character}' (Control)";
            }
            else
            {
                lblCharResult.Text = $"Resultado: {character}";
            }
        }

        // Convertir caracter a numero ASCII
        private void btnToAscii_Click(object sender, EventArgs e)
        {
            string input = txtCharInput.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Por favor ingrese un caracter.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char character = input[0];
            int asciiCode = (int)character;

            lblAsciiResult.Text = $"Resultado: {asciiCode}";
        }


        private void gbAsciiToChar_Enter(object sender, EventArgs e)
        {

        }

        private void AsciiControl_Load(object sender, EventArgs e)
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

        private void AsciiControl_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AsciiControl_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void numAsciiInput_KeyDown(object sender, KeyEventArgs e)
        {
            btnToChar.PerformClick();
        }

        private void txtCharInput_TextChanged(object sender, EventArgs e)
        {
            btnToAscii.PerformClick();
        }
    }
}