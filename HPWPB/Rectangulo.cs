using System;
using System.Drawing;

namespace HPWPB
{

    public class Rectangulo : Figura
    {
        private static int contador = 0;
        public static int Contador => contador;

        public Rectangulo(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
            contador++;
        }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, 50, 30);
            }
        }
    }
}