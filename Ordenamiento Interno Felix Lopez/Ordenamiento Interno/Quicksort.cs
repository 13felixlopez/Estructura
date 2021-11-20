using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez
{
    class Quicksort
    {
        public int cantidad, i = 0;

        public string[] Nombre;
        public string[] id;
        public double[] total;
        public int[] plazo;
        public Quicksort(int cantidad)
        {
            this.cantidad = cantidad;
            Nombre = new string[cantidad];
            id = new string[cantidad];
            plazo = new int[cantidad];
            total = new double[cantidad];
        }
        public void Agregar(string nombre, string Id, int Plazo, double Total)
        {
            if (i < cantidad)
            {
                this.Nombre[i] = nombre;
                this.id[i] = Id;
                this.plazo[i] = Plazo;
                this.total[i] = Total;
                i++;
            }
        }
        public void quicksort()
        {
            rapidoRecursivo();

            void rapidoRecursivo()
            {
                int i = 0, f = cantidad - 1;
                reduceRecursivo(i, f);
            }

            void reduceRecursivo(int ini, int fin)
            {

                int izq, der, pos;
                string auxnombre; double auxtotal;
                string auxId;
                int auxplazo;
                bool band = true;

                izq = ini; der = fin; pos = ini;

                while (band == true)
                {
                    band = false;

                    while (total[pos].CompareTo(total[der]) <= 0 && pos != der)
                    {
                        der--;
                    }

                    if (pos != der)
                    {
                        auxnombre = Nombre[pos];
                        Nombre[pos] = Nombre[der];
                        Nombre[der] = auxnombre;

                        auxId = id[pos];
                        id[pos] = id[der];
                        id[der] = auxId;

                        auxplazo = plazo[pos];
                        plazo[pos] = plazo[der];
                        plazo[der] = auxplazo;

                        auxtotal = total[pos];
                        total[pos] = total[der];
                        total[der] = auxtotal;
                        pos = der;

                        while (total[pos].CompareTo(total[izq]) >= 0 && pos != izq)
                        {
                            izq++;
                        }

                        if (pos != izq)
                        {
                            band = true;

                            auxnombre = Nombre[pos];
                            Nombre[pos] = Nombre[izq];
                            Nombre[izq] = auxnombre;

                            auxId = id[pos];
                            id[pos] = id[izq];
                            id[izq] = auxId;

                            auxplazo = plazo[pos];
                            plazo[pos] = plazo[izq];
                            plazo[izq] = auxplazo;

                            auxtotal = total[pos];
                            total[pos] = total[izq];
                            total[izq] = auxtotal;
                            pos = izq;

                        }
                    }
                }

                if ((pos - 1) > ini)
                {
                    reduceRecursivo(ini, pos - 1);
                }
                if (fin > (pos + 1))
                {
                    reduceRecursivo(pos + 1, fin);
                }
            }

        }
        public void Mostrar(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                dataGridView1.Rows.Add(Nombre[i], id[i], plazo[i], total[i]);
            }
        }
    }
}
