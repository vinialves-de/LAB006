using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab006.LabCalculos.Lab008;

namespace Lab006
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }

        private void Calculo()
        {
            decimal valor = 0;
            decimal porcento = 0;

            valor = Convert.ToDecimal(tbxValor.Text);
            porcento = Convert.ToDecimal(tbxFrete.Text);

            switch(cbxUf.SelectedIndex.ToString())
            {
                case "AM":
                    porcento = 0.6m;
                    break;

                case "MG":
                    porcento = 0.35m;
                    break;

                case "RJ":

                case "SP":
                    porcento = 0.75m;
                    break;
            }
            tbxFrete.Text = porcento.ToString();
            lblResultado = valor * (1 + porcento);

            lblResultado.Text = lblResultado.ToString();
        }
    }
}
