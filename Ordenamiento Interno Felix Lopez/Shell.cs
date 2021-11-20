using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez
{
    class Shell
    {
        public int cantidad, i = 0;

        public string[] Nombre;
        public string[] id;
        public int[] plazo;
        public double[] total;

        public Shell(int cantidad)
        {
            this.cantidad = cantidad;
            Nombre = new string[cantidad];
            id = new string[cantidad];
            plazo = new int[cantidad];
            total = new double[cantidad];
        }

        public void Agregar(string nombre, string Id, double Total, int Plazo)
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

        public void shell()
        {
            string auxnombre; double auxtotal;
            string auxId; int auxplazo;
            int inter, k, j;
            inter = cantidad / 2;
            while (inter > 0)
            {
                for(int i = inter; i < cantidad; i++)
                {
                    j = i - inter;
                    while (j >= 0)
                    {
                        k = j + inter;
                        if (id[j].CompareTo(id[k]) <= 0)
                        {
                            j = -1;
                        }
                        else
                        {
                            auxId = id[j];
                            id[j] = id[k];
                            id[k] = auxId;

                            auxnombre = Nombre[j];
                            Nombre[j] = Nombre[k];
                            Nombre[k] = auxnombre;

                            auxplazo = plazo[j];
                            plazo[j] = plazo[k];
                            plazo[k] = auxplazo;

                            auxtotal = total[j];
                            total[j] = total[k];
                            total[k] = auxtotal;

                            j -= inter;
                        }
                    }
                }
                inter = inter / 2;
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
