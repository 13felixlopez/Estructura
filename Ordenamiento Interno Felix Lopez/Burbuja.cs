using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez
{
    class Burbuja
    {
        public int cantidad, i = 0;

        public string[] Nombre;
        public string[] id;
        public double[] total;
        public int[] plazo;
        public Burbuja(int cantidad)
        {
            this.cantidad = cantidad;
            Nombre = new string[cantidad];
            id = new string[cantidad];
            total = new double[cantidad];
            plazo = new int[cantidad];
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
        public void burbuja()
        {
            string auxnombre; double auxtotal;
            string auxId; int auxplazo;
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (total[i].CompareTo(total[j]) <= 0)
                    {
                        auxnombre = Nombre[i];
                        Nombre[i] = Nombre[j];
                        Nombre[j] = auxnombre;

                        auxId = id[i];
                        id[i] = id[j];
                        id[j] = auxId;

                        auxplazo = plazo[i];
                        plazo[i] = plazo[j];
                        plazo[j] = auxplazo;

                        auxtotal = total[i];
                        total[i] = total[j];
                        total[j] = auxtotal;
                    }
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
