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
    public partial class Form1 : Form
    {

        public float precio, ITBIS, Descuento, valordes,  Total;
        public bool preciocorrecto;

        public void FunctionCaular()
        {
            try
            {
                precio = float.Parse(textprecio.Text);
                preciocorrecto = true;
                Descuento = float.Parse(textdescuento.Text);
            }
            catch (Exception)
            {
                lblmensajes.Text = "Debes ingresar un valor flotante";
                preciocorrecto = false;
                return;
                
            }


            if (checkBox1.Checked == true)
            {
               

                valordes =   Descuento /100;
                valordes = precio * valordes;

              //  Total = precio - valordes;

            }

            if (preciocorrecto == true)
            {
                ITBIS = precio * 0.18f;

                precio += ITBIS;
                

                if (checkBox1.Checked == true)
                {
                    precio = precio - Descuento;  
                }
                Total = precio;
            }


            if (checkBox1.Checked == true)
            {
                labelInformacion.Text = "Precio total Con ITBIS y descuento" + Total.ToString();
            }
            else
            {
                labelInformacion.Text = "Precio total Con ITBIS " + Total.ToString();
            }
            

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionCaular();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fmr = new  Form2();
            fmr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3();
            fmr.Show();
        }
    }
}
