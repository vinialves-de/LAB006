using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab006.LabCalculos;


namespace Lab006.LabCalculos
{
    public partial class btnMaior : Form
    {
        public btnMaior()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal maior = new Lab006.TelaPrincipal();
            TelaPrincipal frete = new Lab006.TelaPrincipal();
            maior.Show();
        }

        private void btnFrete_Click(object sender, EventArgs e)
        {
            Lab007.TelaPrincipal frete = new Lab007.TelaPrincipal();
            frete.ShowDialog();
            
        }
    }
}
