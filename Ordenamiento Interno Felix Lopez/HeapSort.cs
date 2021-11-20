using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez
{
    class HeapSort
    {
        public int cantidad, i = 0;

        public string[] Nombre;
        public string[] id;
        public double[] total;
        public int[] plazo;
        public HeapSort(int cantidad)
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

        public void Heap_Sort()
        {
            int dat = cantidad - 1;
            string auxnombre, auxid;
            double auxtotal;
            int auxplazo;

            for(int i=(dat - 1) / 2; i >= 0; i--)
            {
                sort(i, dat);
            }
            for(int i = dat; i >= 1; i--)
            {
                auxnombre = Nombre[0];
                Nombre[0] = Nombre[i];
                Nombre[i] = auxnombre;

                auxid = id[0];
                id[0] = id[i];
                id[i] = auxid;

                auxplazo = plazo[0];
                plazo[0] = plazo[i];
                plazo[i] = auxplazo;

                auxtotal = total[0];
                total[0] = total[i];
                total[i] = auxtotal;

                sort(0, i - 1);
            }
        }

        public void sort(int inicio, int n)
        {
            int f, k;
            bool BAND = false;
            string auxnombre, auxid;
            double auxtotal;
            int auxplazo;
            f = inicio;
            k = 2 * f + 1;

            auxnombre = Nombre[f];
            auxid = id[f];
            auxplazo = plazo[f];
            auxtotal = total[f];

            while(k<=n && (!BAND))
            {
                if (k < n)
                {
                    if (total[k] < total[k + 1])
                    {
                        k++;
                    }
                }
                if (auxtotal >= total[k])
                {
                    BAND = true;
                }
                else
                {
                    Nombre[f] = Nombre[k];
                    id[f] = id[k];
                    plazo[f] = plazo[k];
                    total[f] = total[k];
                    f = k;
                    k = 2 * f + 1;
                }
            }
            Nombre[f] = auxnombre;
            id[f] = auxid;
            plazo[f] = auxplazo;
            total[f] = auxtotal;
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
