using HPWPB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RectanglesApp
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura>(); // Lista de figuras dibujadas
        private Color colorSeleccionado = Color.Black; // Color por defecto
        private FiguraFactory figuraFactory = new FiguraFactory(); // Instancia de la fábrica

        public Form1()
        {
            InitializeComponent();
            txtContador.ReadOnly = true; // Asegurar que el contador es solo lectura
            pictureBoxColor.BackColor = colorSeleccionado; // Inicializar el color
        }

     



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujar cada figura almacenada
            foreach (var figura in figuras)
            {
                figura.Dibujar(e.Graphics);
            }
        }

        private void btnSeleccionarColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorSeleccionado = colorDialog.Color;
                    pictureBoxColor.BackColor = colorSeleccionado; // Actualizar el PictureBox
                }
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los valores sean numéricos
                if (!int.TryParse(txtX.Text, out int x) || !int.TryParse(txtY.Text, out int y))
                {
                    MessageBox.Show("Ingrese valores numéricos válidos en las coordenadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear rectángulo usando la fábrica
                Figura rectangulo = figuraFactory.CrearRectangulo(x, y, colorSeleccionado);
                figuras.Add(rectangulo);

                // Actualizar contador de rectángulos
                txtContador.Text = Rectangulo.Contador.ToString();

                // Redibujar el formulario
                this.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el rectángulo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
