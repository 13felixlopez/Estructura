using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ordenamiento_Interno_Felix_Lopez
{
    public partial class Form1 : Form
    {
        public int cant, i = 0;
        public struct clientes
        {
            public string Nombre, id;
            public int plazo;
            public double saldo, cuota, total;
        }
        clientes[] datos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcant.Text) || int.Parse(txtcant.Text) <= 0)
            {
                MessageBox.Show("Ingrese un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcant.Clear();
                txtcant.Focus();
            }
            else
            {
                cant = int.Parse(txtcant.Text);
                datos = new clientes[cant];
                txtcant.Enabled = false;
                btncontinuar.Enabled = false;
                groupBox1.Enabled = true;
                btnCalcular.Enabled = true;
                txtId.Focus();
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (i < cant)
                {
                    datos[i].Nombre = txtnombre.Text;
                    datos[i].plazo = Convert.ToInt32(cbplazo.Text);
                    datos[i].id = txtId.Text;
                    datos[i].saldo = Convert.ToDouble(txtsaldopre.Text);
                    datos[i].total = (datos[i].saldo * 0.15) + datos[i].saldo;
                    datos[i].cuota = datos[i].total / datos[i].plazo;
                    lblMensualidad.Text = datos[i].cuota.ToString();
                    btnguardar.Enabled = true;
                    btnCalcular.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ha llegado al limite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    groupBox1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            txtcant.Text = (Convert.ToInt32(txtcant.Text) - 1).ToString();
            datos[i].cuota = Math.Round(datos[i].cuota, 2);
            dataGridView1.Rows.Add(datos[i].id, datos[i].Nombre, datos[i].plazo, datos[i].cuota, datos[i].total);
            MessageBox.Show("Se agrego un dato", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            panelOrdenamiento.Enabled = true;
            panelBusqueda.Enabled = true;
            i++;
            btnguardar.Enabled = false;
            btnCalcular.Enabled = true;
            txtId.Focus();
            if (i == cant)
            {
                MessageBox.Show("Ha llegado al limite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBox1.Enabled = false;
                btnCalcular.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            #region Burbuja
            if (comboBox1.Text == "Método Burbuja")
            {
                Burbuja burb = new Burbuja(cant);

                for (int i = 0; i < cant; i++)
                {
                    burb.Agregar(datos[i].id, datos[i].Nombre, datos[i].plazo, datos[i].total);
                }

                burb.burbuja();
                burb.Mostrar(dataGridView1);
            }
            #endregion

            #region QuickSort
            if (comboBox1.Text == "QuickSort")
            {
                Quicksort quick = new Quicksort(cant);

                for (int i = 0; i < cant; i++)
                {
                    quick.Agregar(datos[i].id, datos[i].Nombre, datos[i].plazo, datos[i].total);
                }

                quick.quicksort();
                quick.Mostrar(dataGridView1);
            }
            #endregion

            #region Insercion Directa
            if (comboBox1.Text == "Inserción Directa")
            {
                Insercion_Directa direc = new Insercion_Directa(cant);
                {
                    for (int i = 0; i < cant; i++)
                    {
                        direc.Agregar(datos[i].id, datos[i].Nombre, datos[i].total, datos[i].plazo);
                    }
                    direc.Insercion();
                    direc.Mostrar(dataGridView1);
                }
            }
            #endregion

            #region Heap Sort
            if(comboBox1.Text== "Heap Sort")
            {
                HeapSort he = new HeapSort(cant);
                for(int i = 0; i < cant; i++)
                {
                    he.Agregar(datos[i].id, datos[i].Nombre, datos[i].plazo, datos[i].total);
                }
                he.Heap_Sort();
                he.Mostrar(dataGridView1);
            }
            #endregion

            #region Seleccion Directa
            if (comboBox1.Text== "Seleccion Directa")
            {
                Seleccion_Directa selec = new Seleccion_Directa(cant);
                for (int i = 0; i < cant; i++)
                {
                    selec.Agregar(datos[i].id, datos[i].Nombre, datos[i].total, datos[i].plazo);
                }

                selec.Selec();
                selec.Mostrar(dataGridView1);
            }
            #endregion

            #region MShell
            if (comboBox1.Text == "Shell")
            {
                Shell shell = new Shell(cant);

                for (int i = 0; i < cant; i++)
                {
                    shell.Agregar(datos[i].id, datos[i].Nombre, datos[i].total, datos[i].plazo);
                }

                shell.shell();
                shell.Mostrar(dataGridView1);
            }
            #endregion
        }

        private bool validar()
        {
            double entero;
            if (!double.TryParse(txtsaldopre.Text, out entero) || !double.TryParse(cbplazo.Text, out entero))
            {
                return false;
            }
            return !(txtnombre.Text == "" || txtId.Text == "" || txtsaldopre.Text == "" ||
             cbplazo.Text == "");

        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            try
            {
                string x = Convert.ToString(txtBuscar.Text);
                i = 0;
                while(i<=cant -1 && datos[i].id.CompareTo(x) != 0)
                {
                    i++;
                }
                if(i>cant - 1)
                {
                    MessageBox.Show("No se encuentra lo que esta buscando", "ERRR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(string.Format("\n Informacion:\n \n- ID:{0} \n- Nombre: {1} \n- Plazo: {2} \n- Total: {3}",
                        datos[i].id, datos[i].Nombre, datos[i].plazo, datos[i].total), "Busqueda Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se puede realizar la operacion");
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtBHash.Text);
            Hash hash = new Hash(cant);
            for (int i = 0; i < cant; i++)
            {
                hash.entra(datos[i].id, datos[i].Nombre, datos[i].plazo, datos[i].total);
            }
            hash.Prueva_Lineal(x);
        }

        private void btnIntercalacion_Click(object sender, EventArgs e)
        {
            Intercalacion_de_Archivos inter = new Intercalacion_de_Archivos();
            inter.Show();
            this.Hide();
        }

        private void btnMDirec_Click(object sender, EventArgs e)
        {
            Mezcla_Directa MDirec = new Mezcla_Directa();
            MDirec.Show();
            this.Hide();
        }

        private void btnMEqui_Click(object sender, EventArgs e)
        {
            Mezcla_Equilibrada MEqui = new Mezcla_Equilibrada();
            MEqui.Show();
            this.Hide();
        }

        private void interOrdenamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (interOrdenamiento.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void TbBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            if (TbBusqueda.Checked)
            {
                gbBusqueda.Enabled = true;
            }
            else
            {
                gbBusqueda.Enabled = false;
            }
        }

        private void TbExterno_CheckedChanged(object sender, EventArgs e)
        {
            if (TbExterno.Checked)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            Arboles_Binarios.Arboles_Binarios BI = new Arboles_Binarios.Arboles_Binarios();
            BI.Show();
            this.Hide();
        }

        private void TbArboles_CheckedChanged(object sender, EventArgs e)
        {
            if (TbArboles.Checked)
            {
                gbArboles.Enabled = true;
            }
            else
            {
                gbArboles.Enabled = false;
            }
        }

        private void btnBalanceado_Click(object sender, EventArgs e)
        {
            Arboles_Balanceado.Arboles_Balanceado BA = new Arboles_Balanceado.Arboles_Balanceado();
            BA.Show();
            this.Hide();
        }

        private void btnGrafos_Click(object sender, EventArgs e)
        {
            Grafos.Grafos GF = new Grafos.Grafos();
            GF.Show();
            this.Hide();
        }

        private void limpiar()
        {
            
            //txtcant.Clear();
            cbplazo.Text = "";
            txtId.Clear();
            txtsaldopre.Clear();
            lblMensualidad.Text = "___________";
            txtnombre.Clear();
        }
    }
}
