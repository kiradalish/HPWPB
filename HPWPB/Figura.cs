using System;
using System.Drawing;

namespace HPWPB
{
    // Clase abstracta Figura
    public abstract class Figura
    {
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public abstract void Dibujar(Graphics g);
    }
}