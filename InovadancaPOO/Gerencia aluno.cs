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
    public partial class Gerencia_aluno : Form
    {
        public Gerencia_aluno()
        {
            InitializeComponent();
            AlunoInova alunoInova = new AlunoInova();
            db_Grid.DataSource = alunoInova.read();
            db_Grid.Columns["id"].Visible = false;
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            Hide();
        }

        private void db_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = db_Grid.CurrentCell.RowIndex;
            var id = db_Grid.Rows[index].Cells["id"].Value.ToString();
            Perfil_Usuario open = new Perfil_Usuario(id);
            open.ShowDialog();
            try
            {
                AlunoInova alunoInova = new AlunoInova();
                db_Grid.DataSource = alunoInova.read();
                db_Grid.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_Procura_TextChanged(object sender, EventArgs e)
        {
            if (tb_Procura.Text != "")
            {
                (db_Grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("name like '%{0}%'", tb_Procura.Text);
            }
            else
            {
                AlunoInova alunoInova = new AlunoInova();
                db_Grid.DataSource = alunoInova.read();
                db_Grid.Columns["id"].Visible = false;
            }
        }
    }
}
