namespace InovadancaPOO
{
    partial class Gerencia_aluno
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
            this.db_Grid = new System.Windows.Forms.DataGridView();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.tb_Procura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // db_Grid
            // 
            this.db_Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.db_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_Grid.Location = new System.Drawing.Point(12, 76);
            this.db_Grid.Name = "db_Grid";
            this.db_Grid.ReadOnly = true;
            this.db_Grid.RowTemplate.Height = 25;
            this.db_Grid.Size = new System.Drawing.Size(551, 282);
            this.db_Grid.TabIndex = 0;
            this.db_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_Grid_CellContentClick);
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(488, 376);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(75, 23);
            this.bt_Voltar.TabIndex = 1;
            this.bt_Voltar.Text = "Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // tb_Procura
            // 
            this.tb_Procura.Location = new System.Drawing.Point(113, 26);
            this.tb_Procura.Name = "tb_Procura";
            this.tb_Procura.Size = new System.Drawing.Size(450, 23);
            this.tb_Procura.TabIndex = 2;
            this.tb_Procura.TextChanged += new System.EventHandler(this.tb_Procura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procurar Alunos:";
            // 
            // Gerencia_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Procura);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.db_Grid);
            this.Name = "Gerencia_aluno";
            this.Text = "Gerencia_aluno";
            ((System.ComponentModel.ISupportInitialize)(this.db_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView db_Grid;
        private Button bt_Voltar;
        private TextBox tb_Procura;
        private Label label1;
    }
}