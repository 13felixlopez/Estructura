using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez
{
    class Hash
    {
        public int i, cant;
        public string[] Id;
        public string[] nombre;
        public double[] Total;
        public int[] Plazo;
        public Hash(int n)
        {
            cant = n;
            Id = new string[cant];
            nombre = new string[cant];
            Total = new double[cant];
            Plazo = new int[cant];
        }
        public void entra(string id, string nombre, int plazo, double total)
        {
            if (i < cant)
            {
                this.Id[i] = id;
                this.nombre[i] = nombre;
                this.Plazo[i] = plazo;
                this.Total[i] = total;
                i++;
            }
        }
        public int H(int k)
        {
            int tamaño = cant - 1;
            int au = 0;
            au = (k % tamaño);
            return au;
        }
        public void Prueva_Lineal(int k)
        {
            int res = H(k);
            int X = 0;
            if (X != -1 && Plazo[res] == k)
            {
                //MessageBox.Show("el dato esta en la pocicion " + (res + 1) +" Y sus datos son: " + Id[res]+" Nombre: "+ nombre[res]);
                MessageBox.Show(string.Format("\n Informacion:\n \n- ID:{0} \n- Nombre: {1} \n- Plazo: {2} \n- Total: {3}",
                        Id[res], nombre[res], Plazo[res],Total[res]), "Busqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                X = res + 1;
                while (X <= cant - 1 && Total[X] != -1 && Total[X] != k && X != res)
                {
                    X = X + 1;
                    if (X == cant)
                    {
                        X = 0;
                    }
                }
                if (Total[X] == -1 || (X == res))
                {
                    MessageBox.Show("el elemento no se encuentra");
                }
                else
                {
                    MessageBox.Show("el elemento esta en la posicion " + (X + 1));
                }
            }
        }
    }
}
