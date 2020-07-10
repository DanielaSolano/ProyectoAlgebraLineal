using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;



namespace ProyectoAlgebraLineal
{
    public class Proceso
    {
        static string FiltrosPath = Path.Combine(Directory.GetCurrentDirectory(), "Filtros.txt");
        static string PesonalizadoPath = Path.Combine(Directory.GetCurrentDirectory(), "FiltroPersonalizado.txt");
        public static List<string> ObtenerFiltrosLista()
        {
            var filtros = new List<string>();
            

            using (var reader = new StreamReader(FiltrosPath))
            {
                while(!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    var nombre = linea.Split(',')[0]; //nombre en la poscicion 0 de cada linea en el archivo
                    filtros.Add(nombre);
                }
            }
            filtros.Add("Personalizado");

            return filtros;
        }

        public static Bitmap ObtenerImagenResultante(Bitmap imagen, string filtro)
        {
            var alto = imagen.Height;
            var ancho = imagen.Width;

            var matrizImagen = new double[alto, ancho];

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    matrizImagen[i, j] = Convert.ToDouble(imagen.GetPixel(j, i).R); 
                }
            }

            var matrizFiltro = ObtenerMatrizFiltro(filtro);
            var matrizNuevaImagen = Aplicacion.ObtenerMatrizFitroAplicado(matrizImagen, matrizFiltro, alto, ancho);

            var imagenNueva = new Bitmap(imagen.Width, imagen.Height); 

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    var valor = Convert.ToInt32(matrizNuevaImagen[i, j]);
                    var colorPixel = Color.FromArgb(valor, valor, valor);
                    imagenNueva.SetPixel(j, i, colorPixel); 
                }
            }
            return imagenNueva;
        }

        
        static double[,] ObtenerMatrizFiltro(string filtro)
        {
            var matrizFiltro = new double[3,3];
            var valores = new string[10];

            if (filtro == "Personalizado")
            {
                using (var reader = new StreamReader(PesonalizadoPath))
                {
                    while (!reader.EndOfStream)
                    {
                        valores = reader.ReadLine().Split(',');
                    }
                }

                var cont = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrizFiltro[i, j] = Convert.ToDouble(valores[cont]);
                        cont++;
                    }
                }

                return matrizFiltro;
            }
            else
            {
                using (var reader = new StreamReader(FiltrosPath))
                {
                    
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine();
                        if (linea.Split(',')[0] == filtro)
                        {
                            valores = linea.Split(',');
                        }
                    }
                }

                var cont = 1;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrizFiltro[i, j] = Convert.ToDouble(valores[cont]);
                        cont++;
                    }
                }
                return matrizFiltro;
            }
        }

        public static void DefinirPersonalizado(string entrada)
        {
            using (var writer = new StreamWriter(PesonalizadoPath))
            {
                writer.WriteLine(entrada);
            }

        }

    }
}
