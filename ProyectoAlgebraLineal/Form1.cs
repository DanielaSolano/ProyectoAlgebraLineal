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

namespace ProyectoAlgebraLineal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCargarOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files  (*.png;)|*.png;";            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var imagen = new Bitmap(ofd.FileName);

                pictureBox1.Image = imagen;

                pictureBox2.Image = Proceso.DevolverImagenResultante(imagen);

                //cuando son en escala de grises tienen siempre el mismo valor de R,G y B y A 255


            }



            /*
            
            */

            /*
            byte[] imageToByteArray(Image image)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            */


        }
    }
}
