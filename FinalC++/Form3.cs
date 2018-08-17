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
    public partial class Form3 : Form
    {

        public string articulo, msg;
        public int cantidad;
        public float precio, totalventas;

        void FuntionCalular()
        {
            try
            {
                cantidad = int.Parse(texcantidad.Text);
                precio = float.Parse(textprecio.Text);
                articulo = textarticulo.Text;

            }
            catch (Exception)
            {
                labelmensajes.Text = "Error";
                return;
            }

            totalventas = precio * cantidad;

            if (cantidad > 5 && cantidad < 10)
            {
                msg = "Se vendieron pocas";
            
            }
            else if (cantidad > 10 && cantidad < 20)
            {

                msg = "Se vendieron algo";
            }

            else if (cantidad > 20)
            {
                msg = "Se vendieron una buena cantidad";
            }

            else
            {

                msg = "No se vendio nada practicamente";
            }

            info.Text = "El articulo " + articulo +", se obtuvo una ganacia de " +totalventas +" y en relacion a las ventas " + msg;

            
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuntionCalular();
        }
    }
}
