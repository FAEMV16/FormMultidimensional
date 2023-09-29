using System;
using System.Windows.Forms;


namespace FormMultidimensional
{
    public partial class Form1 : Form
    {
        private bool Intro = true;
        private Multidim m1;
        private Multidim m2;
        private Multidim m3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Intro)
            {
                m1=Multidim.Leer(txtbDisplay.Text);
                lbMatriz1.Text = m1.ToString();
                Intro = false;

            }
            else
            {
                m2 = Multidim.Leer(txtbDisplay.Text);
                lbMatriz2.Text = m2.ToString();
                Intro = true;
            }
            txtbDisplay.Clear();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            m3 = m1 + m2;
            lbResultado.Text = m3.ToString();
            lbOp.Text = "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            m3 = m1 - m2;
            lbResultado.Text = m3.ToString();
            lbOp.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            m3 = m1 * m2;
            lbResultado.Text = m3.ToString();
            lbOp.Text = "x";
        }
    }
}
