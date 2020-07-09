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
            var nueva = new double[ancho,alto];

            for (int i = 1; i < (ancho - 2); i++)
            {
                for (int j = 1; j < (alto - 2); j++)
                {
                    var a = original[(i - 1), (j - 1)] * filtro[0,0];
                    var b = original[(i - 1), j] * filtro[0, 1];
                    var c = original[(i - 1), (j + 1)] * filtro[0, 2];
                    var d = original[i, (j - 1)] * filtro[1, 0];
                    var e = original[i, j] * filtro[1, 1];
                    var f = original[i, (j + 1)] * filtro[1, 2];
                    var g = original[(i + 1), (j - 1)] * filtro[2, 0];
                    var h = original[i, (j + 1)] * filtro[2, 1];
                    var ii = original[(i + 1), (j + 1)] * filtro[2, 2];

                    var sum = a + b + c + d + e + f + g + h + ii;

                    nueva[i, j] = sum;
                }
            }

            return nueva;
        }
    }
    
}
