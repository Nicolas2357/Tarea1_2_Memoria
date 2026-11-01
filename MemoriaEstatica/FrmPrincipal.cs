using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoriaEstatica
{
    /// <summary>
    /// Ventana principal del Programa 1: Memoria estática (arreglos).
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            ConfigurarVentana();
        }

        private void ConfigurarVentana()
        {
            Text = "Programa 1: Memoria estática (arreglos)";
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;

            var lblEstado = new Label
            {
                Text = "Proyecto inicializado correctamente.",
                AutoSize = true,
                Location = new Point(20, 20),
                Font = new Font("Segoe UI", 11F)
            };
            Controls.Add(lblEstado);
        }
    }
}