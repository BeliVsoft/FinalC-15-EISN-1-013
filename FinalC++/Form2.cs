/*
 Cesar Enrique Beltran Feliz 15 - EISN - 1 -013
 *PROGRAMA BAJO LICENCIA MIT
 *
 * YO LIBERO EL USO DE ESTE CODIGO
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalC__
{
    public partial class Form2 : Form
    {
        public float nota1, nota2, nota3, nota4, sumatoria;


        public void FunctionCacular()
        {
            try
            {
                nota1 = float.Parse(textBox1.Text);
                nota2 = float.Parse(textBox2.Text);
                nota3 = float.Parse(textBox3.Text);
                nota4 = float.Parse(textBox4.Text);
            }
            catch (Exception)
            {

                labelmensajes.Text = "Hay valores no validos";
                return;
            }

            sumatoria = nota1 + nota2 + nota3 + nota4;
            sumatoria = sumatoria / 4;

            label5.Text = sumatoria.ToString();

        }
        public Form2()
        {
            InitializeComponent();
        }

        #region Botton de calculo
        private void button1_Click(object sender, EventArgs e)
        {
            FunctionCacular();
            for (int i = 0; i < 4; i++)
            {
                if (i == 1)
                {
                    if (nota1 > 90)
                    {
                        label6.Text = "A";
                    }
                    if (nota1 > 80 && nota1 < 90)
                    {
                        label6.Text = "B";
                    }
                    if (nota1 > 70 && nota1 < 80)
                    {
                        label6.Text = "C";
                    }
                    if (nota1 < 70)
                    {
                        label6.Text = "F";
                    }
                }
                if (i == 2)
                {
                    if (nota2 > 90)
                    {
                        label7.Text = "A";
                    }
                    if (nota2 > 80 && nota1 < 90)
                    {
                        label7.Text = "B";
                    }
                    if (nota2 > 70 && nota1 < 80)
                    {
                        label7.Text = "C";
                    }
                    if (nota2 < 70)
                    {
                        label7.Text = "F";
                    }
                }
            }
        }

        #endregion Boton de calculo 
        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
