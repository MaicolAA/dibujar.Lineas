using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Autor: Maicol Arroyave Alvarez
/// fecha: 07/03/2022
/// Descripción: Dibujar lineas 
/// </summary>
namespace wLineas
{
    public partial class Form1 : Form
    {
        Graphics graficos;
        public Form1()
        {
            InitializeComponent();
            graficos = CreateGraphics();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btndibujarLineas_Click(object sender, EventArgs e)
        {
            try
            {
                double xInicio = double.Parse(txtxInicial.Text);
                double yInicio = double.Parse(txtyInicial.Text);
                double xFinal = double.Parse(txtxFinal.Text);
                double yFinal = double.Parse(txtyFinal.Text);

                clsLineas wLineas = new clsLineas(xInicio, yInicio, xFinal, yFinal);

                Pen blackPen = new Pen(Color.Black, 3);

                PointF point1 = new PointF(wLineas.obtenXInicio(), wLineas.obtenYInicio());
                PointF point2 = new PointF(wLineas.obtenXFinal(), wLineas.obtenYFinal());

                graficos.DrawLine(blackPen, point1, point2);

                txtcantidadLineas.Text = Convert.ToString(clsLineas.obtenCuenta());

            }
            catch (Exception)
            {

                MessageBox.Show("Digite caracteres validos");
            }
        }
    }
}
