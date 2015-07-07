using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carro
{
    public partial class FormCarro : Form
    {
        List<Carro> cadastro;
        public FormCarro()
        {
            InitializeComponent();
            cadastro = new List<Carro>();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();

            carro.placa = txtPlaca.Text;
            carro.modelo = txtModelo.Text;
            carro.consumoKmL = double.Parse(txtConsumo.Text);

            cadastro.Add(carro);
          
            

            txtPlaca.Clear();
            txtModelo.Clear();
            txtConsumo.Clear();
            

        }
    }
}
