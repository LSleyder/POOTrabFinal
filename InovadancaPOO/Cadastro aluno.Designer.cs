namespace InovadancaPOO
{
    partial class Cadastro_aluno
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.label_Birthday = new System.Windows.Forms.Label();
            this.label_Package = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_CPF = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.dt_Birthday = new System.Windows.Forms.DateTimePicker();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.tc_Cadastro = new System.Windows.Forms.TabControl();
            this.tb_Dados = new System.Windows.Forms.TabPage();
            this.bt_Proximo = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.tb_Aulas = new System.Windows.Forms.TabPage();
            this.lb_Escolhidas = new System.Windows.Forms.Label();
            this.lb_Aulas = new System.Windows.Forms.Label();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.dGrid_AulasSelect = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Insere = new System.Windows.Forms.Button();
            this.dGrid_AulasGeral = new System.Windows.Forms.DataGridView();
            this.cb_Package = new System.Windows.Forms.ComboBox();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_Cadastro.SuspendLayout();
            this.tb_Dados.SuspendLayout();
            this.tb_Aulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_AulasSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_AulasGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(11, 17);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(43, 15);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Nome:";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(3, 54);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(54, 15);
            this.label_Phone.TabIndex = 1;
            this.label_Phone.Text = "Telefone:";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Location = new System.Drawing.Point(21, 86);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(31, 15);
            this.label_CPF.TabIndex = 2;
            this.label_CPF.Text = "CPF:";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(177, 54);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(48, 15);
            this.label_Genre.TabIndex = 3;
            this.label_Genre.Text = "Gênero:";
            // 
            // label_Birthday
            // 
            this.label_Birthday.AutoSize = true;
            this.label_Birthday.Location = new System.Drawing.Point(337, 53);
            this.label_Birthday.Name = "label_Birthday";
            this.label_Birthday.Size = new System.Drawing.Size(117, 15);
            this.label_Birthday.TabIndex = 4;
            this.label_Birthday.Text = "Data de Nascimento:";
            // 
            // label_Package
            // 
            this.label_Package.AutoSize = true;
            this.label_Package.Location = new System.Drawing.Point(18, 19);
            this.label_Package.Name = "label_Package";
            this.label_Package.Size = new System.Drawing.Size(46, 15);
            this.label_Package.TabIndex = 6;
            this.label_Package.Text = "Pacote:";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(165, 90);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(59, 15);
            this.label_Address.TabIndex = 7;
            this.label_Address.Text = "Endereço:";
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(458, 323);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(88, 23);
            this.button_Confirm.TabIndex = 8;
            this.button_Confirm.Text = "Confirma";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(58, 17);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(502, 23);
            this.tb_Name.TabIndex = 10;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(58, 49);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(113, 23);
            this.tb_Phone.TabIndex = 12;
            // 
            // tb_CPF
            // 
            this.tb_CPF.Location = new System.Drawing.Point(58, 83);
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(100, 23);
            this.tb_CPF.TabIndex = 13;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(230, 86);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(330, 23);
            this.tb_Address.TabIndex = 16;
            // 
            // dt_Birthday
            // 
            this.dt_Birthday.CustomFormat = "";
            this.dt_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Birthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Birthday.Location = new System.Drawing.Point(460, 49);
            this.dt_Birthday.Name = "dt_Birthday";
            this.dt_Birthday.Size = new System.Drawing.Size(100, 23);
            this.dt_Birthday.TabIndex = 18;
            // 
            // cb_Genre
            // 
            this.cb_Genre.DisplayMember = "Masculino";
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Genre.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_Genre.Location = new System.Drawing.Point(231, 50);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(100, 23);
            this.cb_Genre.TabIndex = 19;
            this.cb_Genre.Text = "Masculino";
            // 
            // tc_Cadastro
            // 
            this.tc_Cadastro.Controls.Add(this.tb_Dados);
            this.tc_Cadastro.Controls.Add(this.tb_Aulas);
            this.tc_Cadastro.Location = new System.Drawing.Point(-1, 2);
            this.tc_Cadastro.Name = "tc_Cadastro";
            this.tc_Cadastro.SelectedIndex = 0;
            this.tc_Cadastro.Size = new System.Drawing.Size(572, 391);
            this.tc_Cadastro.TabIndex = 20;
            // 
            // tb_Dados
            // 
            this.tb_Dados.Controls.Add(this.bt_Proximo);
            this.tb_Dados.Controls.Add(this.bt_Sair);
            this.tb_Dados.Controls.Add(this.label_Name);
            this.tb_Dados.Controls.Add(this.cb_Genre);
            this.tb_Dados.Controls.Add(this.tb_Address);
            this.tb_Dados.Controls.Add(this.label_Phone);
            this.tb_Dados.Controls.Add(this.dt_Birthday);
            this.tb_Dados.Controls.Add(this.label_Address);
            this.tb_Dados.Controls.Add(this.label_CPF);
            this.tb_Dados.Controls.Add(this.label_Genre);
            this.tb_Dados.Controls.Add(this.label_Birthday);
            this.tb_Dados.Controls.Add(this.tb_Name);
            this.tb_Dados.Controls.Add(this.tb_CPF);
            this.tb_Dados.Controls.Add(this.tb_Phone);
            this.tb_Dados.Location = new System.Drawing.Point(4, 24);
            this.tb_Dados.Name = "tb_Dados";
            this.tb_Dados.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Dados.Size = new System.Drawing.Size(564, 363);
            this.tb_Dados.TabIndex = 0;
            this.tb_Dados.Text = "Dados Pessoais";
            this.tb_Dados.UseVisualStyleBackColor = true;
            // 
            // bt_Proximo
            // 
            this.bt_Proximo.Location = new System.Drawing.Point(460, 322);
            this.bt_Proximo.Name = "bt_Proximo";
            this.bt_Proximo.Size = new System.Drawing.Size(75, 23);
            this.bt_Proximo.TabIndex = 21;
            this.bt_Proximo.Text = "Proximo";
            this.bt_Proximo.UseVisualStyleBackColor = true;
            this.bt_Proximo.Click += new System.EventHandler(this.bt_Proximo_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.Location = new System.Drawing.Point(18, 322);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(87, 23);
            this.bt_Sair.TabIndex = 20;
            this.bt_Sair.Text = "Voltar";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // tb_Aulas
            // 
            this.tb_Aulas.Controls.Add(this.lb_Escolhidas);
            this.tb_Aulas.Controls.Add(this.lb_Aulas);
            this.tb_Aulas.Controls.Add(this.bt_Remove);
            this.tb_Aulas.Controls.Add(this.dGrid_AulasSelect);
            this.tb_Aulas.Controls.Add(this.bt_Insere);
            this.tb_Aulas.Controls.Add(this.dGrid_AulasGeral);
            this.tb_Aulas.Controls.Add(this.cb_Package);
            this.tb_Aulas.Controls.Add(this.bt_Voltar);
            this.tb_Aulas.Controls.Add(this.label_Package);
            this.tb_Aulas.Controls.Add(this.button_Confirm);
            this.tb_Aulas.Location = new System.Drawing.Point(4, 24);
            this.tb_Aulas.Name = "tb_Aulas";
            this.tb_Aulas.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Aulas.Size = new System.Drawing.Size(564, 363);
            this.tb_Aulas.TabIndex = 1;
            this.tb_Aulas.Text = "Aulas";
            this.tb_Aulas.UseVisualStyleBackColor = true;
            // 
            // lb_Escolhidas
            // 
            this.lb_Escolhidas.AutoSize = true;
            this.lb_Escolhidas.Location = new System.Drawing.Point(351, 45);
            this.lb_Escolhidas.Name = "lb_Escolhidas";
            this.lb_Escolhidas.Size = new System.Drawing.Size(110, 15);
            this.lb_Escolhidas.TabIndex = 25;
            this.lb_Escolhidas.Text = "Aulas Selecionadas:";
            // 
            // lb_Aulas
            // 
            this.lb_Aulas.AutoSize = true;
            this.lb_Aulas.Location = new System.Drawing.Point(18, 45);
            this.lb_Aulas.Name = "lb_Aulas";
            this.lb_Aulas.Size = new System.Drawing.Size(39, 15);
            this.lb_Aulas.TabIndex = 24;
            this.lb_Aulas.Text = "Aulas:";
            // 
            // bt_Remove
            // 
            this.bt_Remove.Location = new System.Drawing.Point(250, 191);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(62, 23);
            this.bt_Remove.TabIndex = 23;
            this.bt_Remove.Text = "<-";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // dGrid_AulasSelect
            // 
            this.dGrid_AulasSelect.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGrid_AulasSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGrid_AulasSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_AulasSelect.ColumnHeadersVisible = false;
            this.dGrid_AulasSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dGrid_AulasSelect.Location = new System.Drawing.Point(351, 63);
            this.dGrid_AulasSelect.Name = "dGrid_AulasSelect";
            this.dGrid_AulasSelect.ReadOnly = true;
            this.dGrid_AulasSelect.RowHeadersVisible = false;
            this.dGrid_AulasSelect.RowTemplate.Height = 25;
            this.dGrid_AulasSelect.Size = new System.Drawing.Size(195, 242);
            this.dGrid_AulasSelect.TabIndex = 22;
            this.dGrid_AulasSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_AulasSelect_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // bt_Insere
            // 
            this.bt_Insere.Location = new System.Drawing.Point(250, 146);
            this.bt_Insere.Name = "bt_Insere";
            this.bt_Insere.Size = new System.Drawing.Size(62, 23);
            this.bt_Insere.TabIndex = 21;
            this.bt_Insere.Text = "->";
            this.bt_Insere.UseVisualStyleBackColor = true;
            this.bt_Insere.Click += new System.EventHandler(this.bt_Insere_Click);
            // 
            // dGrid_AulasGeral
            // 
            this.dGrid_AulasGeral.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGrid_AulasGeral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGrid_AulasGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_AulasGeral.ColumnHeadersVisible = false;
            this.dGrid_AulasGeral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dGrid_AulasGeral.Location = new System.Drawing.Point(18, 63);
            this.dGrid_AulasGeral.Name = "dGrid_AulasGeral";
            this.dGrid_AulasGeral.ReadOnly = true;
            this.dGrid_AulasGeral.RowHeadersVisible = false;
            this.dGrid_AulasGeral.RowTemplate.Height = 25;
            this.dGrid_AulasGeral.Size = new System.Drawing.Size(195, 242);
            this.dGrid_AulasGeral.TabIndex = 20;
            this.dGrid_AulasGeral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_AulasGeral_CellContentClick);
            // 
            // cb_Package
            // 
            this.cb_Package.FormattingEnabled = true;
            this.cb_Package.Items.AddRange(new object[] {
            "1 hora/semana",
            "2 horas/semana",
            "3 horas/semana",
            "4 horas/semana",
            "Passe Livre"});
            this.cb_Package.Location = new System.Drawing.Point(70, 16);
            this.cb_Package.Name = "cb_Package";
            this.cb_Package.Size = new System.Drawing.Size(143, 23);
            this.cb_Package.TabIndex = 19;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(18, 323);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(86, 23);
            this.bt_Voltar.TabIndex = 18;
            this.bt_Voltar.Text = "Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Cadastro_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 399);
            this.Controls.Add(this.tc_Cadastro);
            this.Name = "Cadastro_aluno";
            this.Text = "Cadastro_aluno";
            this.tc_Cadastro.ResumeLayout(false);
            this.tb_Dados.ResumeLayout(false);
            this.tb_Dados.PerformLayout();
            this.tb_Aulas.ResumeLayout(false);
            this.tb_Aulas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_AulasSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_AulasGeral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_Name;
        private Label label_Phone;
        private Label label_CPF;
        private Label label_Genre;
        private Label label_Birthday;
        private Label label_Package;
        private Label label_Address;
        private Button button_Confirm;
        private TextBox tb_Name;
        private TextBox tb_Phone;
        private TextBox tb_CPF;
        private TextBox tb_Address;
        private DateTimePicker dt_Birthday;
        private ComboBox cb_Genre;
        private TabControl tc_Cadastro;
        private TabPage tb_Dados;
        private TabPage tb_Aulas;
        private Button bt_Proximo;
        private Button bt_Sair;
        private ComboBox cb_Package;
        private Button bt_Voltar;
        private Button bt_Remove;
        private DataGridView dGrid_AulasSelect;
        private Button bt_Insere;
        private DataGridView dGrid_AulasGeral;
        private Label lb_Escolhidas;
        private Label lb_Aulas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
    }
}