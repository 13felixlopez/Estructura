using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento_Interno_Felix_Lopez
{
    public class CAMINO_CORTO
    {
        public string ALGORITMO_FLOYD(long[,] AMY, int numero)
        {
            int VERTICES = numero;
            long[,] MATRIZ_ABYASENCIA = AMY;
            string[,] CAMINOS = new string[VERTICES, VERTICES];
            string[,] CAMINOS_AUXILIARES = new string[VERTICES, VERTICES];
            string CAMINO_RECORRIDO = "", CADENA = "", CAMINITOS = "";
            int I, J, K;
            float TEMPORAL1, TEMPORAL2, TEMPORAL3, TEMPORAL4, MINIMO;
            //INICAILIZAMOS LAS MATRICES CAMINOS Y CAMINOS AUXILIARES

            for (I = 0; I < VERTICES; I++)
            {
                for (J = 0; J < VERTICES; J++)
                {
                    CAMINOS[I, J] = "";
                    CAMINOS_AUXILIARES[I, J] = "";
                }
            }

            for (K = 0; K < VERTICES; K++)
            {
                for (I = 0; I < VERTICES; I++)
                {
                    for (J = 0; J < VERTICES; J++)
                    {
                        TEMPORAL1 = MATRIZ_ABYASENCIA[I, J];
                        TEMPORAL2 = MATRIZ_ABYASENCIA[I, K];
                        TEMPORAL3 = MATRIZ_ABYASENCIA[K, J];
                        TEMPORAL4 = TEMPORAL2 + TEMPORAL3;
                        //ENCONTRAR AL MINIMO

                        MINIMO = Math.Min(TEMPORAL1, TEMPORAL4);

                        if (TEMPORAL1 != TEMPORAL4)
                        {
                            if (MINIMO == TEMPORAL4)
                            {
                                CAMINO_RECORRIDO = "";
                                CAMINOS_AUXILIARES[I, J] = K + "";
                                CAMINOS[I, J] = CAMINO_R(I, K, CAMINOS_AUXILIARES, CAMINO_RECORRIDO) + (K + 1);
                            }
                        }
                        MATRIZ_ABYASENCIA[I, J] = (long)MINIMO;
                    }
                }
            }

            //AGREGAR EL CAMINO A CADENA
            for (I = 0; I < VERTICES; I++)
            {
                for (J = 0; J < VERTICES; J++)
                {
                    CADENA = CADENA + "[" + MATRIZ_ABYASENCIA[I, J] + "]";
                }
                CADENA = CADENA + "\n";
            }

            for (I = 0; I < VERTICES; I++)
            {
                for (J = 0; J < VERTICES; J++)
                {
                    if (MATRIZ_ABYASENCIA[I, J] != 1000000000)
                    {
                        if (I != J)
                        {
                            if (CAMINOS[I, J].Equals(""))
                            {
                                CAMINITOS += "DE (" + (I + 1) + "------>" + (J + 1) + ")" +
                                    "IRSE POR (" + (I + 1) + ",   " + (J + 1) + ")\n";
                            }
                            else
                            {
                                CAMINITOS += "DE (" + (I + 1) + "------>" + (J + 1) + ")" +
                                    "IRSE POR (" + (I + 1) + ",   " + CAMINOS[I, J] + ",  " + (J + 1) + "\n";
                            }
                        }
                    }
                }
            }
            return "LA MATRIZ DE CAMINOS MAS CORTOS ENTRE LO DIFERENTE VERTICES ES : \n"
                + CADENA + "\nLOS DIFERENTE CAMINOS MAS CORTOS ENTRE VERTICES SON:\n" + CAMINITOS;
        }

        public string CAMINO_R(int I, int K, string[,] CAMINOS_AUXILIARES, string CAMINO_RECORRIDO)
        {
            if (CAMINOS_AUXILIARES[I, K].Equals(""))
            {
                return "";
            }
            else
            {
                CAMINO_RECORRIDO += CAMINO_R(I, int.Parse(CAMINOS_AUXILIARES[I, K]), CAMINOS_AUXILIARES, CAMINO_RECORRIDO) +
                    (int.Parse(CAMINOS_AUXILIARES[I, K]) + 1) + ",   ";
                return CAMINO_RECORRIDO;
            }
        }
    }
}
