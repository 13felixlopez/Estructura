using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez
{
    class Seleccion_Directa
    {
        public int cantidad, i = 0;

        public string[] Nombre;
        public string[] id;
        public int[] plazo;
        public double[] total;

        public Seleccion_Directa(int cantidad)
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

        public void Selec()
        {
            string auxnombre, auxid;
            double auxtotal;
            int auxplazo;
            for(int i = 0; i < cantidad - 1; i++)
            {
                int Min = i;
                for(int j = 0; j < cantidad; j++)
                {
                    if (id[j].CompareTo(id[i]) <= 0)
                    {
                        Min = j;
                    }
                }
                if(i!= Min)
                {
                    auxnombre = Nombre[i];
                    Nombre[i] = Nombre[Min];
                    Nombre[Min] = auxnombre;

                    auxid = id[i];
                    id[i] = id[Min];
                    id[Min] = auxid;

                    auxplazo = plazo[i];
                    plazo[i] = plazo[Min];
                    plazo[Min] = auxplazo;

                    auxtotal = total[i];
                    total[i] = total[Min];
                    total[Min] = auxtotal;
                }
            }
        }

        public void Mostrar(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            for(int i = 0; i < cantidad; i++)
            {
                dataGridView1.Rows.Add(Nombre[i], id[i], plazo[i], total[i]);
            }
        }
    }
}
