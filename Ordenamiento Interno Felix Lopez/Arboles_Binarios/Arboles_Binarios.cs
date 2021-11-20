using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez.Arboles_Binarios
{
    public partial class Arboles_Binarios : Form
    {
        public int cant { get; set; }

        int axu,
            i = 0;

        Arbol arbol;
        Graphics nodo;

        public struct clientes
        {
            public string Nombre { get; set; }
            public string id { get; set; }
            public int plazo { get; set; }
            public double saldo { get; set; }
            public double cuota { get; set; }
            public double total { get; set; }
        }
        clientes[] datos;

        public Arboles_Binarios()
        {
            InitializeComponent();
            nodo = CreateGraphics();
            arbol = new Arbol(nodo, Font);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Arboles_Binarios_Paint(object sender, PaintEventArgs e)
        {
            arbol.MostrarArbol(e, this.BackColor);
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            if (cbRecorrido.Text == "posOrden")
            {
                arbol.PosOrden(lstRecorridos, lblRecorridos);
            }
            if (cbRecorrido.Text == "preOrden")
            {
                arbol.PreOrden(lstRecorridos, lblRecorridos);
            }
            if (cbRecorrido.Text == "InOrden")
            {
                arbol.InOrden(lstRecorridos, lblRecorridos);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Estas Seguro de eliminar este Dato?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                double x = double.Parse(txtEliminar.Text);

                if (arbol.Eliminar(x))
                {
                    Refresh();
                    Eliminar(x);
                }
            }
               
            else
            {
                MessageBox.Show("No se ha encontrado el nodo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar(double x)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i].total == x)
                {
                    for (int j = i; j < datos.Length - 1; j++)
                    {
                        datos[j].id = datos[j + 1].id;
                        datos[j].Nombre = datos[j + 1].Nombre;
                        datos[j].plazo = datos[j + 1].plazo;
                        datos[j].cuota = datos[j + 1].cuota;
                        datos[j].total = datos[j + 1].total;

                        if (j == datos.Length)
                        {
                            datos[j].id = null;
                            datos[j].Nombre = null;
                            datos[j].plazo = Convert.ToInt32(null);
                            datos[j].cuota = Convert.ToDouble("");
                            datos[j].total = Convert.ToDouble("");
                        }
                    }
                }
            }

            axu--;
            dataGridView1.Rows.Clear();

            for (int i = 0; i < axu; i++)
            {
                dataGridView1.Rows.Add(datos[i].id, datos[i].Nombre, datos[i].plazo, datos[i].cuota, datos[i].total);
            }
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            try
            {
                cant = Convert.ToInt32(txtcant.Text);
                axu = cant;

                if (string.IsNullOrWhiteSpace(txtcant.Text) || int.Parse(txtcant.Text) <= 0)
                {
                    MessageBox.Show("Ingrese un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    datos = new clientes[cant];
                    MessageBox.Show($"Se podran ingresar {cant} clientes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gbDatos.Enabled = true;
                    txtcant.Enabled = false;
                    btncontinuar.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Cantidad ingresada no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (i == cant)
            {
                MessageBox.Show("Ya no puede ingresar mas elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(validar())
                {
                    datos[i].Nombre = txtnombre.Text;
                    datos[i].plazo = Convert.ToInt32(cbplazo.Text);
                    datos[i].id = txtId.Text;
                    datos[i].saldo = Convert.ToDouble(txtsaldopre.Text);
                    datos[i].total = (datos[i].saldo * 0.15) + datos[i].saldo;
                    datos[i].cuota = datos[i].total / datos[i].plazo;
                    lblMensualidad.Text = datos[i].cuota.ToString();
                    btnguardar.Enabled = true;
                    txtcant.Text = (Convert.ToInt32(txtcant.Text) - 1).ToString();
                    datos[i].cuota = Math.Round(datos[i].cuota, 2);
                    if (arbol.InsertarDatos(datos[i].total))
                    {
                        dataGridView1.Rows.Add(datos[i].id, datos[i].Nombre, datos[i].plazo, datos[i].cuota, datos[i].total);
                        MessageBox.Show("Se agrego un dato", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                        limpiar();
                        txtId.Focus();
                        i++;
                    }
                    if (i == cant)
                    {
                        MessageBox.Show("Ha llegado al limite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gbDatos.Enabled = false;
                    }

                    if (i > 0)
                    {
                        gbRecorrido.Enabled = true;
                    }
                    if (i == cant)
                    {
                        gbEliminar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Existen campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiar()
        {
            cbplazo.Text = "";
            txtId.Clear();
            txtsaldopre.Clear();
            lblMensualidad.Text = "___________";
            txtnombre.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
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
    }
}
