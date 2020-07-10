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
            var opcionesFiltros = Proceso.ObtenerFiltrosLista();
            foreach (var item in opcionesFiltros)
            {
                comboBoxFiltros.Items.Add(item);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCargarOriginal_Click(object sender, EventArgs e)
        {
            if(comboBoxFiltros.SelectedItem != null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files  (*.png;)|*.png;";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var imagen = new Bitmap(ofd.FileName);

                    pictureBox1.Image = imagen;

                    pictureBox2.Image = Proceso.ObtenerImagenResultante(imagen, (string)comboBoxFiltros.SelectedItem);

                }
            }
            else
            {
                MessageBox.Show("Debe tener un filtro seleccionado");
            }

            

        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
