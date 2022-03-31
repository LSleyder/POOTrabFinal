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
    public partial class Cadastro_aluno : Form
    {
        public Cadastro_aluno()
        {
            InitializeComponent();
            tb_Name.Text = "";
            tb_Address.Text = "";
            tb_Phone.Text = "";
            tb_CPF.Text = "";
            cb_Package.Text = "";
            AulasInova aulasInova = new AulasInova();
            DataTable dt = aulasInova.readaula();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dGrid_AulasGeral.Rows[0].Clone();
                row.Cells[0].Value = dt.Rows[i].ItemArray[0];
                row.Cells[1].Value = dt.Rows[i].ItemArray[1];
                dGrid_AulasGeral.Rows.Add(row);
            }
            dGrid_AulasGeral.Columns["id"].Visible = false;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            string id_pack = Guid.NewGuid().ToString();
            string name = tb_Name.Text;
            string birthday = DateTime.Parse(dt_Birthday.Text).ToString("MM/dd/yyyy HH:mm:ss");
            string genre = cb_Genre.Text;
            string address = tb_Address.Text;
            string phone = tb_Phone.Text;
            string CPF = tb_CPF.Text;
            string created_at = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string updated_at = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string package = cb_Package.Text;
            string aula_id = "";
            for(int i = 0; i < dGrid_AulasSelect.Rows.Count - 1; i++)
            {
                aula_id = aula_id + dGrid_AulasSelect.Rows[i].Cells[0].Value.ToString() + ",";
            }
            try
            {
                AlunoInova alunoInova = new AlunoInova();
                PacotesInova pacotesInova = new PacotesInova();
                pacotesInova.create(id_pack, id, package, aula_id);
                alunoInova.create(id, name, birthday, genre, address, phone, CPF, created_at, updated_at);
                tb_Name.Text = "";
                tb_Address.Text = "";
                tb_Phone.Text = "";
                tb_CPF.Text = "";
                cb_Package.Text = "";
                tc_Cadastro.SelectedIndex = 0;
                MessageBox.Show("Usuario criado com sucesso!", "Usuario Criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }

        private void bt_Proximo_Click(object sender, EventArgs e)
        {
            tc_Cadastro.SelectedIndex = 1;
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            Hide();
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            tc_Cadastro.SelectedIndex = 0;
        }

        private void dGrid_AulasGeral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = dGrid_AulasGeral.CurrentCell.RowIndex;
                var id = dGrid_AulasGeral.Rows[index].Cells["id"].Value.ToString();
                dGrid_AulasGeral.Rows.RemoveAt(index);
                AulasInova aulasInova = new AulasInova();
                string aula_nome = aulasInova.aulanome(id);
                dGrid_AulasSelect.Rows.Add(id, aula_nome);

                dGrid_AulasSelect.Columns[0].Visible = false;
            }
            catch
            {

            }
        }

        private void bt_Insere_Click(object sender, EventArgs e)
        {
            try
            {
                var index = dGrid_AulasGeral.CurrentCell.RowIndex;
                var id = dGrid_AulasGeral.Rows[index].Cells["id"].Value.ToString();
                dGrid_AulasGeral.Rows.RemoveAt(index);
                AulasInova aulasInova = new AulasInova();
                string aula_nome = aulasInova.aulanome(id);
                dGrid_AulasSelect.Rows.Add(id, aula_nome);

                dGrid_AulasSelect.Columns[0].Visible = false;
            }
            catch
            {

            }
        }

        private void dGrid_AulasSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dGrid_AulasSelect.CurrentCell.RowIndex;
            var id = dGrid_AulasSelect.Rows[index].Cells[0].Value.ToString();
            dGrid_AulasSelect.Rows.RemoveAt(index);
            AulasInova aulasInova = new AulasInova();
            string aula_nome = aulasInova.aulanome(id);
            dGrid_AulasGeral.Rows.Add(id, aula_nome);

        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            var index = dGrid_AulasSelect.CurrentCell.RowIndex;
            var id = dGrid_AulasSelect.Rows[index].Cells[0].Value.ToString();
            dGrid_AulasSelect.Rows.RemoveAt(index);
            AulasInova aulasInova = new AulasInova();
            string aula_nome = aulasInova.aulanome(id);
            dGrid_AulasGeral.Rows.Add(id, aula_nome);

        }
    }
}
