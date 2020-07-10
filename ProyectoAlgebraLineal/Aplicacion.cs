using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ProyectoAlgebraLineal
{
    public static class Aplicacion
    {
        public static double[,] ObtenerMatrizFitroAplicado(double[,] original, double[,] filtro, int alto, int ancho)
        {
            var matrizOperada = new double[alto, ancho];
            var valoresPixeles = new List<double>();

            for (int i = 1; i < (alto - 1); i++)
            {
                for (int j = 1; j < (ancho - 1); j++)
                {
                    var a = original[(i - 1), (j - 1)] * filtro[0, 0];
                    var b = original[(i - 1), j] * filtro[0, 1];
                    var c = original[(i - 1), (j + 1)] * filtro[0, 2];
                    var d = original[i, (j - 1)] * filtro[1, 0];
                    var e = original[i, j] * filtro[1, 1];
                    var f = original[i, (j + 1)] * filtro[1, 2];
                    var g = original[(i + 1), (j - 1)] * filtro[2, 0];
                    var h = original[i, (j + 1)] * filtro[2, 1];
                    var ii = original[(i + 1), (j + 1)] * filtro[2, 2];

                    var sum = a + b + c + d + e + f + g + h + ii;

                    matrizOperada[i, j] = sum;
                    valoresPixeles.Add(sum);

                    //correccion de bordes
                    if (i == 1)
                    {
                        matrizOperada[0, j] = sum;
                    }
                    else if (i == alto - 2)
                    {
                        matrizOperada[(alto - 1), j] = sum;
                    }
                    else if (j == 1)
                    {
                        matrizOperada[i, 0] = sum;
                    }
                    else if (j == ancho - 2)
                    {
                        matrizOperada[i, (ancho - 1)] = sum;
                    }
                }
            }

            //correccion esquinas
            matrizOperada[0, 0] = matrizOperada[1, 1];
            matrizOperada[0, ancho - 1] = matrizOperada[1, ancho - 2];
            matrizOperada[alto - 1, 0] = matrizOperada[alto - 2, 1];
            matrizOperada[alto - 1, ancho - 1] = matrizOperada[alto - 2, ancho - 2];


            double max = 0;
            double min = 0;

            foreach (var item in valoresPixeles)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    matrizOperada[i, j] = (matrizOperada[i, j] - min) / (max - min) * 255;
                }
            }

            return matrizOperada;
        }
        
    }
    
}
