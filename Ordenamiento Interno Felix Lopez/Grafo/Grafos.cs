using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Interno_Felix_Lopez.Grafos
{
    public partial class Grafos : Form
    {
        public long[,] MATRIZ_PESOS;
        public int CONTADOR1 = 0, CONTADOR2 = 1;
        public int Numero;
        CAMINO_CORTO CAMINO = new CAMINO_CORTO();
        public Grafos()
        {
            InitializeComponent();
        }


        private void BTNINGRESAR_VERTICES_Click(object sender, EventArgs e)
        {
            Numero = int.Parse(TXTNUMERO_VERTICES.Text);
            MATRIZ_PESOS = new long[int.Parse(TXTNUMERO_VERTICES.Text), int.Parse(TXTNUMERO_VERTICES.Text)];
            MessageBox.Show("PROSIGA A INGRESAR LAS DISTANCIAS DE LOS VERTICES");
            label4.Text = Convert.ToString(CONTADOR1 + 1); label6.Text = Convert.ToString(CONTADOR2 + 1);
            BTNCONFIRMACION.Enabled = true;
            comboBox1.Enabled = true;
            TXTNUMERO_VERTICES.Enabled = false;
            BTNINGRESAR_VERTICES.Enabled = false;
        }

        private void BTNCONFIRMACION_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "NO")
            {
                MessageBox.Show("NO EXISTE UNA DISTANCIA ENTRE LOS VERTICES" + (CONTADOR1 + 1) + " Y" + (CONTADOR2 + 1));
                comboBox1.Text = "";
                MATRIZ_PESOS[CONTADOR1, CONTADOR2] = 999999999;
                CONTADOR2++;
                if (CONTADOR1 == CONTADOR2)
                {
                    MATRIZ_PESOS[CONTADOR1, CONTADOR2] = 0;
                    CONTADOR2++;
                }
                if (CONTADOR2 != Numero)
                    label7.Text = Convert.ToString(CONTADOR2 + 1);
                else
                {
                    CONTADOR2 = 0;
                    MessageBox.Show("SE HAN COMPLETADO LAS DISTANCIAS DEL VERTICE" + (CONTADOR1 + 1) + " PROSIGA CON EL SIGUIENTE VERTICE");
                    label7.Text = Convert.ToString(CONTADOR2 + 1);
                    CONTADOR1++;
                    if (CONTADOR1 == Numero)
                    {
                        label5.Visible = false;
                        label7.Visible = false;
                        comboBox1.Enabled = false;
                        INGRESAR_DISTANCIA.Enabled = false;
                        BTNCONFIRMACION.Enabled = false;
                        CONTADOR1 = 0;
                        MessageBox.Show("SE HA COMPLETADO LA MATRIZ DE DISTACIA");
                        BTNVER_CAMINOS.Enabled = true;
                        comboBox1.Enabled = false;
                        BTNCONFIRMACION.Enabled = false;
                    }
                    else
                    {
                        label5.Text = Convert.ToString(CONTADOR1 + 1);
                    }
                }
            }
            else
            {
                comboBox1.Text = "";
                INGRESAR_DISTANCIA.Enabled = true;
                textBox2.Enabled = true;
                MessageBox.Show("SI EXISTE DISTANCIA DEL VERTICE " + (CONTADOR1 + 1) + " AL VERTICE " + (CONTADOR2 + 1) +
                    " , PROSIGA A INGRESAR LA DISTACIA");
                comboBox1.Enabled = false;
                BTNCONFIRMACION.Enabled = false;
            }
        }

        private void INGRESAR_DISTANCIA_Click(object sender, EventArgs e)
        {
            MATRIZ_PESOS[CONTADOR1, CONTADOR2] = int.Parse(textBox2.Text);
            textBox2.Clear();
            INGRESAR_DISTANCIA.Enabled = false;
            MessageBox.Show("DISTANCIA INGRESADA");
            INGRESAR_DISTANCIA.Enabled = false;
            comboBox1.Enabled = true;
            BTNCONFIRMACION.Enabled = true;
            textBox2.Enabled = false;
            CONTADOR2++;
            if (CONTADOR1 == CONTADOR2)
            {
                MATRIZ_PESOS[CONTADOR1, CONTADOR2] = 0;
                CONTADOR2++;
            }
            if (CONTADOR2 != Numero)
                label7.Text = Convert.ToString(CONTADOR2 + 1);
            else
            {
                CONTADOR2 = 0;
                MessageBox.Show("SE HAN COMPLETADO LAS DISTANCIAS DEL VERTICE " + (CONTADOR1 + 1) + " PROSIGA CON EL SIGUIENTE VERTICE ");
                label7.Text = Convert.ToString(CONTADOR2 + 1);
                CONTADOR1++;
                if (CONTADOR1 == Numero)
                {
                    label5.Visible = false;
                    label7.Visible = false;
                    INGRESAR_DISTANCIA.Enabled = false;
                    comboBox1.Enabled = false;
                    textBox2.Enabled = false;
                    CONTADOR1 = 0;
                    MessageBox.Show("SE HA COMPLETADO LA MATRIZ DE DISTANCIA");
                    INGRESAR_DISTANCIA.Visible = true;
                    BTNVER_CAMINOS.Enabled = true;
                    textBox2.Enabled = false;
                    BTNCONFIRMACION.Enabled = false;
                }
                else
                {
                    label5.Text = Convert.ToString(CONTADOR1 + 1);
                }
            }
        }

        private void BTNVER_CAMINOS_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = CAMINO.ALGORITMO_FLOYD(MATRIZ_PESOS, Numero);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
