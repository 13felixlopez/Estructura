using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez.Arboles_Balanceado
{
    class Arbol
    {
        public Nodo raiz;

        Graphics nodo;
        Font font;

        int coorX = 740;
        int coorY = 45;
        bool dup = false;
        bool existe = false;

        public Arbol()
        {

        }

        public Arbol(Nodo nuevo)
        {
            raiz = nuevo;
        }

        public Arbol(Graphics nodo,Font font)
        {
            this.nodo = nodo;
            this.font = font;
        }

        private int FactorEquilibrio(Nodo x)
        {
            if (x == null)
            {
                return -1;
            }
            else
            {
                return x.fe;
            }
        }

        private Nodo RotacionIZ(Nodo x)
        {
            Nodo aux = x.izquierdo;
            x.izquierdo = aux.derecho;
            x.fe = Math.Max(FactorEquilibrio(x.izquierdo), FactorEquilibrio(x.derecho)) + 1;
            aux.fe = x.fe = Math.Max(FactorEquilibrio(x.izquierdo), FactorEquilibrio(x.derecho)) + 1;
            return aux;
        }

        private Nodo RotacionDere(Nodo x)
        {
            Nodo aux = x.derecho;
            x.derecho = aux.izquierdo;
            aux.izquierdo = x;
            x.fe = Math.Max(FactorEquilibrio(x.izquierdo), FactorEquilibrio(x.derecho)) + 1;
            aux.fe = Math.Max(FactorEquilibrio(x.izquierdo), FactorEquilibrio(x.derecho)) + 1;
            return aux;
        }

        private Nodo DereDere(Nodo x)
        {
            Nodo temp;
            x.derecho = RotacionIZ(x.derecho);
            temp = RotacionDere(x);
            return temp;
        }

        private Nodo IzquiIzqui(Nodo x)
        {
            Nodo temp;
            x.izquierdo = RotacionDere(x.izquierdo);
            temp = RotacionIZ(x);
            return temp;
        }
        public bool InsertarDatos(double total)
        {
            Nodo nuevo = new Nodo(total);

            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                raiz = Insertar(nuevo, raiz);
            }
            return dup;
        }
        private Nodo Insertar(Nodo nuevo, Nodo subArb)
        {
            Nodo nuevoPadre = subArb;

            if (nuevo.total < subArb.total)
            {
                if (subArb.izquierdo == null)
                {
                    subArb.izquierdo = nuevo;
                }
                else
                {
                    subArb.izquierdo = Insertar(nuevo, subArb.izquierdo);
                    if (FactorEquilibrio(subArb.izquierdo) - FactorEquilibrio(subArb.derecho) == 2)
                    {
                        if (nuevo.total < subArb.izquierdo.total)
                        {
                            nuevoPadre = RotacionIZ(subArb);
                        }
                        else
                        {
                            nuevoPadre = IzquiIzqui(subArb);
                        }
                    }
                }

                dup = false;
            }
            else if (nuevo.total > subArb.total)
            {
                if (subArb.derecho == null)
                {
                    subArb.derecho = nuevo;
                }
                else
                {
                    subArb.derecho = Insertar(nuevo, subArb.derecho);
                    if (FactorEquilibrio(subArb.derecho) - FactorEquilibrio(subArb.izquierdo) == 2)
                    {
                        if (nuevo.total > subArb.derecho.total)
                        {
                            nuevoPadre = RotacionDere(subArb);
                        }
                        else
                        {
                            nuevoPadre = DereDere(subArb);
                        }
                    }
                }
                dup = false;
            }
            else
            {
                dup = true;
            }

            if ((subArb.izquierdo == null) && (subArb.derecho != null))
            {
                subArb.fe = subArb.derecho.fe + 1;
            }
            else if ((subArb.derecho == null) && (subArb.izquierdo != null))
            {
                subArb.fe = subArb.izquierdo.fe + 1;
            }
            else
            {
                subArb.fe = Math.Max(FactorEquilibrio(subArb.izquierdo), FactorEquilibrio(subArb.derecho)) + 1;
            }
            return nuevoPadre;
        }

        private Nodo EliminarNodo(Nodo Raiz,double total)
        {
            if (Raiz == null)
            {
                existe = false;
            }
            else if (total < Raiz.total)
            {
                Nodo izq = EliminarNodo(Raiz.izquierdo, total);
                Raiz.izquierdo = izq;
            }
            else if (total > Raiz.total)
            {
                Nodo der = EliminarNodo(Raiz.derecho, total);
                Raiz.derecho = der;
            }
            else
            {
                Nodo axu = Raiz;

                if (axu.derecho == null)
                {
                    Raiz = axu.izquierdo;
                }
                else if (axu.izquierdo == null)
                {
                    Raiz = axu.derecho;
                }
                else
                {
                    axu = Cambiar(axu);
                }
                axu = null;
                existe = true;
            }
            return Raiz;
        }

        public bool Eliminar(double total)
        {
            raiz = EliminarNodo(raiz, total);
            return existe;
        }

        private Nodo Cambiar(Nodo aux)
        {
            Nodo temp = aux, temp2 = aux.izquierdo;
            while (temp2.derecho != null)
            {
                temp = temp2;
                temp2 = temp2.derecho;
            }
            aux.total = temp2.total;
            if (temp == aux)
            {
                temp.izquierdo = temp2.izquierdo;
            }
            else
            {
                temp.derecho = temp2.izquierdo;
            }
            return temp2;
        }

        public void MostrarArbol(PaintEventArgs e, Color c)
        {
            e.Graphics.Clear(c);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            nodo = e.Graphics;
            DibujarArbol(nodo, font, Brushes.White, Brushes.Black, Pens.White, Brushes.Black);
        }

        private void DibujarArbol(Graphics grafico, Font fuente, Brush colorRelleno, Brush colorFuente, Pen relacion, Brush borde)
        {
            if (raiz == null)
            {
                return;
            }
            raiz.UbicacionNodo(coorX, coorY);
            raiz.DibujarRamas(grafico, relacion);
            raiz.DibujarNodo(grafico, fuente, colorRelleno, colorFuente, relacion, borde);
        }
        public void InOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            InOrden(raiz, lst, lbl);
        }
        public void InOrden(Nodo temp, ListBox lst, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido InOrden";
                InOrden(temp.izquierdo, lst, lbl);
                lst.Items.Add(temp.total.ToString());
                InOrden(temp.derecho, lst, lbl);
            }
        }

        public void PosOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            PosOrden(raiz, lst, lbl);
        }
        public void PosOrden(Nodo temp, ListBox lst, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido PosOrden";
                PosOrden(temp.izquierdo, lst, lbl);
                PosOrden(temp.derecho, lst, lbl);
                lst.Items.Add(temp.total.ToString());
            }
        }

        public void PreOrden(ListBox lst, Label lbl)
        {
            lst.Items.Clear();
            PreOrden(raiz, lst, lbl);
        }
        public void PreOrden(Nodo temp, ListBox lst, Label lbl)
        {
            if (temp != null)
            {
                lbl.Text = "Recorrido PreOrden";
                lst.Items.Add(temp.total.ToString());
                PreOrden(temp.izquierdo, lst, lbl);
                PreOrden(temp.derecho, lst, lbl);
            }
        }
    }
}
