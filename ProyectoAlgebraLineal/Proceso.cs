using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;



namespace ProyectoAlgebraLineal
{
    public class Proceso
    {
        public static List<string> ObtenerFiltrosLista()
        {
            var filtros = new List<string>();
            var filtrosPath = Path.Combine(Directory.GetCurrentDirectory(), "filtros.txt");

            using (var reader = new StreamReader(filtrosPath))
            {
                while(!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    var nombre = linea.Split(',')[0]; //nombre en la poscicion 0 de cada linea en el archivo
                    filtros.Add(nombre);
                }
            }

            return filtros;
        }

        public static void ProcesarImagen(Bitmap imagen)
        {

            var matrizImagen = new float[imagen.Height, imagen.Width];

            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    var pixel = imagen.GetPixel(i, j);

                    if (pixel == null)
                    {
                        matrizImagen[i, j] = imagen.GetPixel(i, j).R;
                    }
                }
            }
        }


        public static Bitmap DevolverImagenResultante(Bitmap imagen)
        {
            var alto = imagen.Height;
            var ancho = imagen.Width;

            var matrizImagen = new double[ancho, alto];

            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                {
                    matrizImagen[i, j] = Convert.ToDouble( imagen.GetPixel(i, j).R);
                }
            }

            var imagenNueva = new Bitmap(imagen.Width, imagen.Height);

            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                {
                    var valor = Convert.ToInt32(matrizImagen[i, j]);
                    var colorPixel = Color.FromArgb(valor, valor, valor);
                    imagenNueva.SetPixel(i, j, colorPixel);
                }
            }
            return imagenNueva;
        }
    }
}
