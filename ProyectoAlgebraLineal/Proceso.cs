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
        //convertir imagen original a matriz
        float[,] ObtenerMatrizImagen (Bitmap imagen)
        {
            return null;
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

            

            //var data = imagen.LockBits(new Rectangle(Point.Empty, imagen.Size), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            //Marshal.Copy(bytesMatriz, 0, data.Scan0, bytesMatriz.Length);

            //imagenNueva.UnlockBits(data);

            //using (var ms = new MemoryStream(bytesMatriz))
            //{
            //    imagenNueva = new Bitmap(ms);
            //}

            return imagenNueva;
        }
    }
}
