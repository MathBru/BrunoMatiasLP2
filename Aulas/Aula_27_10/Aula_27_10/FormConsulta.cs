using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aula_27_10
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cozao");
            var connection = new MySqlConnection("Server=localhost;Database=test;User=root;PWS=");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM livro WHERE Isbn=" + TxtIsbn.Text+";", connection);
            connection.Open();
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show(reader.GetString("Titulo"));
            }
        }
    }
}
