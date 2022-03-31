namespace InovadancaPOO
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_Cadastra = new System.Windows.Forms.Button();
            this.bt_Gerencia = new System.Windows.Forms.Button();
            this.bt_Aulas = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cadastra
            // 
            this.button_Cadastra.Location = new System.Drawing.Point(156, 125);
            this.button_Cadastra.Name = "button_Cadastra";
            this.button_Cadastra.Size = new System.Drawing.Size(147, 51);
            this.button_Cadastra.TabIndex = 0;
            this.button_Cadastra.Text = "Cadastrar Alunos";
            this.button_Cadastra.UseVisualStyleBackColor = true;
            this.button_Cadastra.Click += new System.EventHandler(this.button_Cadastra_Click);
            // 
            // bt_Gerencia
            // 
            this.bt_Gerencia.Location = new System.Drawing.Point(156, 182);
            this.bt_Gerencia.Name = "bt_Gerencia";
            this.bt_Gerencia.Size = new System.Drawing.Size(147, 51);
            this.bt_Gerencia.TabIndex = 1;
            this.bt_Gerencia.Text = "Gerenciar Alunos";
            this.bt_Gerencia.UseVisualStyleBackColor = true;
            this.bt_Gerencia.Click += new System.EventHandler(this.bt_Gerencia_Click);
            // 
            // bt_Aulas
            // 
            this.bt_Aulas.Location = new System.Drawing.Point(156, 239);
            this.bt_Aulas.Name = "bt_Aulas";
            this.bt_Aulas.Size = new System.Drawing.Size(147, 51);
            this.bt_Aulas.TabIndex = 2;
            this.bt_Aulas.Text = "Gerenciar Aulas";
            this.bt_Aulas.UseVisualStyleBackColor = true;
            this.bt_Aulas.Click += new System.EventHandler(this.bt_Aulas_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.Location = new System.Drawing.Point(156, 296);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(147, 51);
            this.bt_Sair.TabIndex = 3;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Cadastro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Aulas);
            this.Controls.Add(this.bt_Gerencia);
            this.Controls.Add(this.button_Cadastra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Sistema de Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Cadastra;
        private Button bt_Gerencia;
        private Button bt_Aulas;
        private Button bt_Sair;
        private Label label1;
        private PictureBox pictureBox1;
    }
}