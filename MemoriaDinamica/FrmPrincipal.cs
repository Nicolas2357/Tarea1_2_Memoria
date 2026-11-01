using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoriaDinamica
{
    /// <summary>
    /// Ventana principal del Programa 2: Memoria dinámica (instancias y referencias en el Heap).
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
            Text = "Programa 2: Memoria dinámica (heap)";
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
