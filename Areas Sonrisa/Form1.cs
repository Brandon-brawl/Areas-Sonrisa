using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas_Sonrisa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAreaCuadrado_Click(object sender, EventArgs e)
        {
            //CAreas a = new CAreas();
            decimal resulado = CAreas.Cuadrado(NumCuadrado.Value);
            lblCuadrado.Text = resulado + "";
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            //CAreas a = new CAreas();
            decimal resulado = CAreas.Triangulo(NumTrianguloB.Value, NumTrianguloh.Value);
            lblTriangulo.Text = resulado + "";
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            //CAreas a = new CAreas();
            decimal resulado = CAreas.Rectanguo(NumRectanguloB.Value, NumRectanguloh.Value);
            lblRectangulo.Text = resulado + "";
        }

        private void btnTrapecio_Click(object sender, EventArgs e)
        {
            //CAreas a = new CAreas();
            decimal resulado = CAreas.Trapecio(NumTrapecioh.Value, NumTrapecioB.Value, Trapeciob.Value);
            lblTrapecio.Text = resulado + "";
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            //CAreas a = new CAreas();
            decimal resulado = CAreas.Circulo(NumCirculoR.Value);
            lblCirculo.Text = resulado + "";
        }

        private void btnRombo_Click(object sender, EventArgs e)
        {
            //CAreas a = new CAreas();
            decimal resulado = CAreas.Rombo(NumRomboD.Value, NumRd.Value);
            lblRombo.Text = resulado + "";
        }

        private void btnRomboide_Click(object sender, EventArgs e)
        {
            //CAreas a = new CAreas();
            decimal resulado = CAreas.Romboide(NumRomboideb.Value, NumRomboideh.Value);
            lblRomboide.Text = resulado + "";

        }

        private void btnPentagono_Click(object sender, EventArgs e)
        {
            //CAreas a = new CAreas();
            decimal resulado = CAreas.Pentagono(NumPentagonop.Value, NumPentagonoa.Value);
            lblpentagono.Text = resulado + "";
        }

    }
}
