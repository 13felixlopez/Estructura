using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez
{
    class Insercion_Directa
    {
        public int cantidad, i = 0;

        public string[] Nombre;
        public string[] id;
        public int[] plazo;
        public double[] total;

        public Insercion_Directa(int cantidad)
        {
            this.cantidad = cantidad;
            Nombre = new string[cantidad];
            id = new string[cantidad];
            plazo = new int[cantidad];
            total = new double[cantidad];
        }

        public void Agregar(string nombre, string Id,double Total,int Plazo)
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

        public void Insercion()
        {
            for(int i = 0; i < cantidad; i++)
            {
                string nombre = Nombre[i];
                string Id = id[i];
                int Plazo = plazo[i];
                double Total = total[i];

                int j = i - 1;
                while((j>=0)&& id[j].CompareTo(id[i]) < 0)
                {
                    id[j + 1] = id[j];
                    Nombre[j + 1] = Nombre[j];
                    plazo[j + 1] = plazo[j];
                    total[j + 1] = total[j];
                    j--;
                }
                id[j + 1] = Id;
                Nombre[j + 1] = nombre;
                plazo[j + 1] = Plazo;
                total[j + 1] = Total;
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
