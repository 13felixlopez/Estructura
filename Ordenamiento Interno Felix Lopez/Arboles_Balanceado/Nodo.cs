using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez.Arboles_Balanceado
{
    class Nodo
    {
        public Nodo izquierdo { get; set; }
        public Nodo derecho { get; set; }

        public int fe;
        public double total;

        int coordenadasX = 130,
            coordenadasY = 10,
            coordenadasXderecho,
            coordenadasYderecho,
            elipse = 35;
        public int nivel { get; set; }

        public Nodo(double dt)
        {
            total = dt;
            fe = 0;
            izquierdo = null;
            derecho = null;
        }
        public Nodo(double dato, Nodo izquierdo, Nodo derecho, Nodo Padre)
        {
            total = dato;
            this.izquierdo = izquierdo;
            this.derecho = derecho;
        }
        public void UbicacionNodo(int posX, int posY)
        {
            int auxiliar1,
                auxiliar2;

            coordenadasYderecho = Convert.ToInt32(posY + elipse / 2);

            if (izquierdo != null)
            {
                izquierdo.UbicacionNodo(posX, posY + elipse + coordenadasY);
            }

            if ((izquierdo != null) && (derecho != null))
            {
                posX += coordenadasX;
            }

            if (derecho != null)
            {
                derecho.UbicacionNodo(posX, posY + elipse + coordenadasY);

            }

            if (izquierdo != null && derecho != null)
            {
                coordenadasXderecho = Convert.ToInt32((izquierdo.coordenadasXderecho + derecho.coordenadasXderecho) / 2);

            }
            else if (izquierdo != null)
            {
                auxiliar1 = izquierdo.coordenadasXderecho;
                izquierdo.coordenadasXderecho = coordenadasXderecho - 80;
                coordenadasXderecho = auxiliar1;
            }
            else if (derecho != null)
            {
                auxiliar2 = derecho.coordenadasXderecho;
                derecho.coordenadasXderecho = coordenadasXderecho + 80;
                coordenadasXderecho = auxiliar2;

            }
            else
            {
                coordenadasXderecho = Convert.ToInt32(posX + elipse / 2);
                posX += elipse;
            }
        }
        public void DibujarRamas(Graphics grafico, Pen relacion)
        {
            if (izquierdo != null)
            {
                grafico.DrawLine(relacion, coordenadasXderecho, coordenadasYderecho, izquierdo.coordenadasXderecho, izquierdo.coordenadasYderecho);
                izquierdo.DibujarRamas(grafico, relacion);
            }

            if (derecho != null)
            {
                grafico.DrawLine(relacion, coordenadasXderecho, coordenadasYderecho, derecho.coordenadasXderecho, derecho.coordenadasYderecho);
                derecho.DibujarRamas(grafico, relacion);
            }
        }
        public void DibujarNodo(Graphics grafico, Font fuente, Brush color, Brush colorFuente, Pen relacion, Brush B)
        {
            Rectangle temp = new Rectangle(Convert.ToInt32(coordenadasXderecho - elipse / 2), Convert.ToInt32(coordenadasYderecho - elipse / 2), elipse, elipse);

            grafico.FillEllipse(B, temp);
            grafico.FillEllipse(color, temp);
            grafico.DrawEllipse(relacion, temp);
            grafico.FillEllipse(color, temp);
            grafico.DrawEllipse(relacion, temp);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            grafico.DrawString(total.ToString(), fuente, colorFuente, coordenadasXderecho, coordenadasYderecho, formato);

            if (izquierdo != null)
            {
                izquierdo.DibujarNodo(grafico, fuente, color, colorFuente, relacion, B);

            }
            if (derecho != null)
            {
                derecho.DibujarNodo(grafico, fuente, color, colorFuente, relacion, B);
            }
        }
    }
}
