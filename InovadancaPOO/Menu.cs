using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace InovadancaPOO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=inovadanca;User Id=postgres;Password=docker;");
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "CREATE TABLE alunos(id UUID NOT NULL PRIMARY KEY,name VARCHAR(50),birthday TIMESTAMP,genre VARCHAR(10),CPF VARCHAR(15),address VARCHAR(70),phone VARCHAR(15),created_at TIMESTAMP,updated_at TIMESTAMP)";
                cmd.ExecuteReader();

                cmd.Dispose();
                conn.Close();
            }
            catch(NpgsqlException e)
            {
                if (e.GetType() == typeof(NpgsqlException))
                {
                    MessageBox.Show("Não foi possivel conectar ao banco de dados!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=inovadanca;User Id=postgres;Password=docker;");
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "CREATE TABLE aulas(id UUID NOT NULL PRIMARY KEY,name VARCHAR(50),professor VARCHAR(50),days VARCHAR(70),modalidade VARCHAR(20),created_at TIMESTAMP,updated_at TIMESTAMP)";
                cmd.ExecuteReader();

                cmd.Dispose();
                conn.Close();
            }
            catch
            {

            }
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=inovadanca;User Id=postgres;Password=docker;");
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "CREATE TABLE pacotes(id UUID NOT NULL PRIMARY KEY,user_id VARCHAR(50),package VARCHAR(20),aula_id VARCHAR(250),mensalidade VARCHAR(15),atraso VARCHAR(15))";
                cmd.ExecuteReader();

                cmd.Dispose();
                conn.Close();
            }
            catch
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Cadastra_Click(object sender, EventArgs e)
        {
            Cadastro_aluno form = new Cadastro_aluno();
            form.Show();
            Hide();           
        }
        private void bt_Gerencia_Click(object sender, EventArgs e)
        {
            Gerencia_aluno form = new Gerencia_aluno();
            form.Show();
            Hide();
        }

        private void bt_Aulas_Click(object sender, EventArgs e)
        {
            Gerencia_aulas form = new Gerencia_aulas();
            form.Show();
            Hide();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
