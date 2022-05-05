using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab006.LabCalculos.Lab007
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        public void MaiorDeTres()
        {



            int Valor1 = Convert.ToInt32(nudValor1.Text);
            int Valor2 = Convert.ToInt32(nudValor2.Text);
            int Valor3 = Convert.ToInt32(nudValor3.Text);

            if (Valor1 > Valor2 && Valor1 > Valor3)
            {
                lblResultado.Text = Valor1.ToString();
            }
            else if (Valor2 > Valor3 && Valor2 > Valor1)
            {
                lblResultado.Text = Valor2.ToString();
            }
            else if (Valor3 > Valor2 && Valor3 > Valor1)
            {
                lblResultado.Text = Valor3.ToString();
            }




        }



        private void btncalcular_Click(object sender, EventArgs e)
        {
            MaiorDeTres();
        }
    }
}
