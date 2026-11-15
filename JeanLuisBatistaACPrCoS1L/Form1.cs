using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeanLuisBatistaACPrCoS1L
{
    public partial class MainForm : Form
    {
        private AsciiControl asciiControl; // parte codificacion ascii
        private baseControl baseControl;  // parte codificacion sistema numerico

        public MainForm()
        {
            InitializeComponent();

            // llamar los controles de usuario
            asciiControl = new AsciiControl { Dock = DockStyle.Fill };
            baseControl = new baseControl { Dock = DockStyle.Fill };

            // Mostrar la vista de ASCII al iniciar
            ShowControl(asciiControl);

            // Suscribir los eventos de clic de los botones del menú lateral
            btnNavAscii.Click += btnNavAscii_Click;
            btnNavBase.Click += btnNavBase_Click;
        }
        private void ShowControl(UserControl control)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
            control.BringToFront();
        }

        private void btnNavAscii_Click(object sender, EventArgs e)
        {
            ShowControl(asciiControl);
            SetActiveButton(btnNavAscii);
        }

        private void btnNavBase_Click(object sender, EventArgs e)
        {
            ShowControl(baseControl);
            SetActiveButton(btnNavBase);
        }

        private void SetActiveButton(Button activeBtn)
        {
            // Restablecer colores de ambos botones
            btnNavAscii.BackColor = Color.FromArgb(52, 73, 94);
            btnNavBase.BackColor = Color.FromArgb(52, 73, 94);

            // Resaltar el botón activo
            activeBtn.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNavBase_Click_1(object sender, EventArgs e)
        {

        }
    }
}
