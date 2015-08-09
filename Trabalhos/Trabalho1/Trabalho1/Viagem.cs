using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho1
{
    public partial class Viagem : Form
    {
        List<Carro> Carros;
        public Viagem()
        {
            InitializeComponent();
            Carros = new List<Carro>();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = int.Parse(id_text.Text);
            }
            catch
            {
                MessageBox.Show("ID deve ser um número inteiro");
                return;
            }

            for (int i = 0; i < Carros.Count; i++)
            {
                Carro carro = Carros[i];
                if (id == carro.id)
                {   
                    if (carro.capacidade > carro.passageiros)
                    {
                        carro.passageiros++;
                        int espacoRestante = carro.capacidade - carro.passageiros;
                        MessageBox.Show("Passageiro adicionado.\n"+espacoRestante+" vagas restantes.");                    
                    }
                    else
                    {
                        MessageBox.Show("Carro lotado!!!");
                    }

                    return;
                }
            }

            MessageBox.Show("ID inválido, carro não encontrado!!!");
        }

        private void Cadastrar_Click_1(object sender, EventArgs e)
        {
            string modelo = modelo_txt.Text;
            string marca = marca_txt.Text;
            string placa = placa_txt.Text;
            int capPassageiros = int.Parse(capPassageiros_txt.Text);

            Carro carro = new Carro();

            carro.id = Carros.Count + 1;
            carro.placa = placa;
            carro.modelo = modelo;
            carro.capacidade = capPassageiros;
            carro.passageiros = 0;
            carro.marca = marca;

            Carros.Add(carro);

            placa_txt.Clear();
            marca_txt.Clear();
            modelo_txt.Clear();
            capPassageiros_txt.Clear();
        }

        private void Relatorio_btn_Click(object sender, EventArgs e)
        {
            if (Carros.Count == 0)
            {
                MessageBox.Show("Não há nenhum carro cadastrado para mostrar o relatório");
                return;
            }

            string relatorio = "";

            for (int i = 0; i < Carros.Count; i++)
            {
                Carro carro = Carros[i];

                relatorio += "Carro " + carro.id + "\n";
                relatorio += "   Placa : " + carro.placa + "\n";
                relatorio += "   Marca : " + carro.marca + "\n";
                relatorio += "   Modelo: " + carro.modelo + "\n";

                string vagas = "";
                if (carro.capacidade > carro.passageiros)
                {
                    vagas = "   Vagas: " + (carro.capacidade - carro.passageiros).ToString();
                }
                else
                {
                    vagas = "   Carro lotado!";
                }

                relatorio += vagas;
                relatorio += "\n\n";
            }

            MessageBox.Show(relatorio, "Relatório");
        }
    }
}
