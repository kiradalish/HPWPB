using System;
using System.Drawing;

namespace HPWPB
{
    // Clase Factory
    public class FiguraFactory
    {
        public Figura CrearRectangulo(int x, int y, Color color)
        {
            return new Rectangulo(x, y, color);
        }
    }
}
