using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InovadancaPOO
{
    public partial class Gerencia_aulas : Form
    {

        public Gerencia_aulas()
        {
            InitializeComponent();
            AulasInova aulasInova = new AulasInova();
            db_Grid.DataSource = aulasInova.read();
            db_Grid.Columns["id"].Visible = false;
        }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            Hide();
        }

        private void bt_Inserir_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            string name = tb_NomeAula.Text;
            string professor = tb_Professor.Text;
            string days = "";
            int index = 0;
            for (int x = 0; x < cl_DiasDaSemana.CheckedItems.Count - 1; x++)
            {
                days = days + cl_DiasDaSemana.CheckedItems[x].ToString() + ",";
                index += 1;
            }
            days = days + cl_DiasDaSemana.CheckedItems[index].ToString();
            string modalidade = cb_Modalidades.Text;
            string created_at = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string updated_at = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            try
            {
                AulasInova aulasInova = new AulasInova();
                aulasInova.create(id, name, professor, days, modalidade, created_at, updated_at);
                tb_NomeAula.Text = "";
                tb_Professor.Text = "";
                for (int i = 0; i < cl_DiasDaSemana.Items.Count; i++)
                {
                    cl_DiasDaSemana.SetItemChecked(i, false);
                }
                db_Grid.DataSource = aulasInova.read();
                MessageBox.Show("Aula criada com sucesso!", "Aula Criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void db_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = db_Grid.CurrentCell.RowIndex;
            var id = db_Grid.Rows[index].Cells["id"].Value.ToString();
            bt_Atualiza.Enabled = true;
            bt_Delete.Enabled = true;
            AulasInova aulasInova = new AulasInova();
            var aula = aulasInova.search(id);
            if (aula.HasRows)
            {
                aula.Read();
                tb_NomeAula.Text = aula["name"].ToString();
                tb_Professor.Text = aula["professor"].ToString();
                cb_Modalidades.Text = aula["modalidade"].ToString();
                string days = aula["days"].ToString();
                int count = 0;
                for(int i = 0; i < days.Length; i++)
                {
                    if(days[i] == ',')
                        count += 1;
                }
                count += 1;
                string dayssplit;
                for (int i = 0; i < count; i++)
                {
                    dayssplit = days.Split(',')[i].ToString();
                    for (int x = 0; x < cl_DiasDaSemana.Items.Count; x++)
                    {
                        if (cl_DiasDaSemana.Items[x].ToString() == dayssplit)
                        {
                            cl_DiasDaSemana.SetItemChecked(x, true);
                        }
                    }
                }
            }
            aula.Close();

        }

        private void bt_Atualiza_Click(object sender, EventArgs e)
        {
            var index = db_Grid.CurrentCell.RowIndex;
            var id = db_Grid.Rows[index].Cells["id"].Value.ToString();
            string name = tb_NomeAula.Text;
            string professor = tb_Professor.Text;
            string days = "";
            index = 0;
            for (int x = 0; x < cl_DiasDaSemana.CheckedItems.Count - 1; x++)
            {
                days = days + cl_DiasDaSemana.CheckedItems[x].ToString() + ",";
                index += 1;
            }
            days = days + cl_DiasDaSemana.CheckedItems[index].ToString();
            string modalidade = cb_Modalidades.Text;
            string updated_at = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            try
            {
                AulasInova aulasInova = new AulasInova();
                aulasInova.update(id, name, professor, days, modalidade, updated_at);
                tb_NomeAula.Text = "";
                tb_Professor.Text = "";
                for (int i = 0; i < cl_DiasDaSemana.Items.Count; i++)
                {
                    cl_DiasDaSemana.SetItemChecked(i, false);
                }
                MessageBox.Show("Aula atualizada com sucesso!", "Aula Atualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db_Grid.DataSource = aulasInova.read();
                bt_Delete.Enabled = false;
                bt_Atualiza.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            var index = db_Grid.CurrentCell.RowIndex;
            var id = db_Grid.Rows[index].Cells["id"].Value.ToString();
            AulasInova aulasInova = new AulasInova();
            aulasInova.delete(id);
            db_Grid.DataSource = aulasInova.read();
            tb_NomeAula.Text = "";
            tb_Professor.Text = "";
            for (int i = 0; i < cl_DiasDaSemana.Items.Count; i++)
            {
                cl_DiasDaSemana.SetItemChecked(i, false);
            }
            bt_Delete.Enabled = false;
            bt_Atualiza.Enabled = false;
        }

        private void tb_Procura_TextChanged(object sender, EventArgs e)
        {
            if (tb_Procura.Text != "")
            {
                (db_Grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("name like '%{0}%'", tb_Procura.Text);
            }
            else
            {
                AulasInova aulasInova = new AulasInova();
                db_Grid.DataSource = aulasInova.read();
                db_Grid.Columns["id"].Visible = false;
            }
        }
    }
}
