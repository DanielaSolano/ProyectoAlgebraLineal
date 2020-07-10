using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAlgebraLineal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" 
                && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                var entrada = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," 
                    + textBox5.Text + "," + textBox6.Text + "," + textBox7.Text + "," + textBox8.Text + "," + textBox9.Text;

                Proceso.DefinirPersonalizado(entrada);
            }
            else
            {
                MessageBox.Show("No todas las posiciones de la matriz están definidas");
            }
            
        }
    }
}
