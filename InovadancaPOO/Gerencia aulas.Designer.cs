namespace InovadancaPOO
{
    partial class Gerencia_aulas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_NomeAula = new System.Windows.Forms.Label();
            this.lb_Professor = new System.Windows.Forms.Label();
            this.lb_AulaDia = new System.Windows.Forms.Label();
            this.tb_NomeAula = new System.Windows.Forms.TextBox();
            this.tb_Professor = new System.Windows.Forms.TextBox();
            this.cl_DiasDaSemana = new System.Windows.Forms.CheckedListBox();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.bt_Inserir = new System.Windows.Forms.Button();
            this.db_Grid = new System.Windows.Forms.DataGridView();
            this.lb_Modalidade = new System.Windows.Forms.Label();
            this.cb_Modalidades = new System.Windows.Forms.ComboBox();
            this.bt_Atualiza = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Procura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_NomeAula
            // 
            this.lb_NomeAula.AutoSize = true;
            this.lb_NomeAula.Location = new System.Drawing.Point(46, 21);
            this.lb_NomeAula.Name = "lb_NomeAula";
            this.lb_NomeAula.Size = new System.Drawing.Size(65, 15);
            this.lb_NomeAula.TabIndex = 0;
            this.lb_NomeAula.Text = "Nova Aula:";
            // 
            // lb_Professor
            // 
            this.lb_Professor.AutoSize = true;
            this.lb_Professor.Location = new System.Drawing.Point(403, 21);
            this.lb_Professor.Name = "lb_Professor";
            this.lb_Professor.Size = new System.Drawing.Size(59, 15);
            this.lb_Professor.TabIndex = 1;
            this.lb_Professor.Text = "Professor:";
            // 
            // lb_AulaDia
            // 
            this.lb_AulaDia.AutoSize = true;
            this.lb_AulaDia.Location = new System.Drawing.Point(18, 59);
            this.lb_AulaDia.Name = "lb_AulaDia";
            this.lb_AulaDia.Size = new System.Drawing.Size(93, 15);
            this.lb_AulaDia.TabIndex = 2;
            this.lb_AulaDia.Text = "Dias da Semana:";
            // 
            // tb_NomeAula
            // 
            this.tb_NomeAula.Location = new System.Drawing.Point(115, 19);
            this.tb_NomeAula.Name = "tb_NomeAula";
            this.tb_NomeAula.Size = new System.Drawing.Size(268, 23);
            this.tb_NomeAula.TabIndex = 3;
            // 
            // tb_Professor
            // 
            this.tb_Professor.Location = new System.Drawing.Point(468, 18);
            this.tb_Professor.Name = "tb_Professor";
            this.tb_Professor.Size = new System.Drawing.Size(254, 23);
            this.tb_Professor.TabIndex = 4;
            // 
            // cl_DiasDaSemana
            // 
            this.cl_DiasDaSemana.FormattingEnabled = true;
            this.cl_DiasDaSemana.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sábado"});
            this.cl_DiasDaSemana.Location = new System.Drawing.Point(117, 59);
            this.cl_DiasDaSemana.Name = "cl_DiasDaSemana";
            this.cl_DiasDaSemana.Size = new System.Drawing.Size(266, 94);
            this.cl_DiasDaSemana.TabIndex = 5;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(634, 427);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(88, 23);
            this.bt_Voltar.TabIndex = 6;
            this.bt_Voltar.Text = "Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // bt_Inserir
            // 
            this.bt_Inserir.Location = new System.Drawing.Point(634, 165);
            this.bt_Inserir.Name = "bt_Inserir";
            this.bt_Inserir.Size = new System.Drawing.Size(88, 23);
            this.bt_Inserir.TabIndex = 7;
            this.bt_Inserir.Text = "Inserir Aula";
            this.bt_Inserir.UseVisualStyleBackColor = true;
            this.bt_Inserir.Click += new System.EventHandler(this.bt_Inserir_Click);
            // 
            // db_Grid
            // 
            this.db_Grid.AllowUserToAddRows = false;
            this.db_Grid.AllowUserToDeleteRows = false;
            this.db_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_Grid.Location = new System.Drawing.Point(18, 195);
            this.db_Grid.Name = "db_Grid";
            this.db_Grid.ReadOnly = true;
            this.db_Grid.RowTemplate.Height = 25;
            this.db_Grid.Size = new System.Drawing.Size(704, 226);
            this.db_Grid.TabIndex = 8;
            this.db_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_Grid_CellContentClick);
            // 
            // lb_Modalidade
            // 
            this.lb_Modalidade.AutoSize = true;
            this.lb_Modalidade.Location = new System.Drawing.Point(389, 59);
            this.lb_Modalidade.Name = "lb_Modalidade";
            this.lb_Modalidade.Size = new System.Drawing.Size(73, 15);
            this.lb_Modalidade.TabIndex = 9;
            this.lb_Modalidade.Text = "Modalidade:";
            // 
            // cb_Modalidades
            // 
            this.cb_Modalidades.FormattingEnabled = true;
            this.cb_Modalidades.Items.AddRange(new object[] {
            "Dança a dois",
            "Individual"});
            this.cb_Modalidades.Location = new System.Drawing.Point(468, 56);
            this.cb_Modalidades.Name = "cb_Modalidades";
            this.cb_Modalidades.Size = new System.Drawing.Size(254, 23);
            this.cb_Modalidades.TabIndex = 10;
            this.cb_Modalidades.Text = "Dança a dois";
            // 
            // bt_Atualiza
            // 
            this.bt_Atualiza.Enabled = false;
            this.bt_Atualiza.Location = new System.Drawing.Point(534, 165);
            this.bt_Atualiza.Name = "bt_Atualiza";
            this.bt_Atualiza.Size = new System.Drawing.Size(94, 23);
            this.bt_Atualiza.TabIndex = 11;
            this.bt_Atualiza.Text = "Atualizar Aula";
            this.bt_Atualiza.UseVisualStyleBackColor = true;
            this.bt_Atualiza.Click += new System.EventHandler(this.bt_Atualiza_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Enabled = false;
            this.bt_Delete.Location = new System.Drawing.Point(443, 165);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(85, 23);
            this.bt_Delete.TabIndex = 12;
            this.bt_Delete.Text = "Deletar Aula";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Procurar Alunos:";
            // 
            // tb_Procura
            // 
            this.tb_Procura.Location = new System.Drawing.Point(117, 166);
            this.tb_Procura.Name = "tb_Procura";
            this.tb_Procura.Size = new System.Drawing.Size(320, 23);
            this.tb_Procura.TabIndex = 13;
            this.tb_Procura.TextChanged += new System.EventHandler(this.tb_Procura_TextChanged);
            // 
            // Gerencia_aulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Procura);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Atualiza);
            this.Controls.Add(this.cb_Modalidades);
            this.Controls.Add(this.lb_Modalidade);
            this.Controls.Add(this.db_Grid);
            this.Controls.Add(this.bt_Inserir);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.cl_DiasDaSemana);
            this.Controls.Add(this.tb_Professor);
            this.Controls.Add(this.tb_NomeAula);
            this.Controls.Add(this.lb_AulaDia);
            this.Controls.Add(this.lb_Professor);
            this.Controls.Add(this.lb_NomeAula);
            this.Name = "Gerencia_aulas";
            this.Text = "Gerencia_aulas";
            ((System.ComponentModel.ISupportInitialize)(this.db_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_NomeAula;
        private Label lb_Professor;
        private Label lb_AulaDia;
        private TextBox tb_NomeAula;
        private TextBox tb_Professor;
        private CheckedListBox cl_DiasDaSemana;
        private Button bt_Voltar;
        private Button bt_Inserir;
        private DataGridView db_Grid;
        private Label lb_Modalidade;
        private ComboBox cb_Modalidades;
        private Button bt_Atualiza;
        private Button bt_Delete;
        private Label label1;
        private TextBox tb_Procura;
    }
}