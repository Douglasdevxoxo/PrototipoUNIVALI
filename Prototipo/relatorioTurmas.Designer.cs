namespace Protótipo
{
    partial class relatorioTurmas
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
            this.gridalunosmatriculados = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnfecharraletorioturmas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridalunosmatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridalunosmatriculados
            // 
            this.gridalunosmatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridalunosmatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nome,
            this.curso,
            this.municipio,
            this.UF});
            this.gridalunosmatriculados.Location = new System.Drawing.Point(12, 12);
            this.gridalunosmatriculados.MaximumSize = new System.Drawing.Size(1256, 700);
            this.gridalunosmatriculados.MinimumSize = new System.Drawing.Size(1255, 680);
            this.gridalunosmatriculados.Name = "gridalunosmatriculados";
            this.gridalunosmatriculados.RowTemplate.Height = 24;
            this.gridalunosmatriculados.Size = new System.Drawing.Size(1255, 680);
            this.gridalunosmatriculados.TabIndex = 22;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula aluno";
            this.matricula.Name = "matricula";
            this.matricula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.matricula.Width = 135;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome aluno";
            this.nome.Name = "nome";
            this.nome.Width = 250;
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.Width = 250;
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Professor";
            this.municipio.Name = "municipio";
            this.municipio.Width = 250;
            // 
            // UF
            // 
            this.UF.HeaderText = "Pólo";
            this.UF.Name = "UF";
            this.UF.Width = 150;
            // 
            // btnfecharraletorioturmas
            // 
            this.btnfecharraletorioturmas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharraletorioturmas.Location = new System.Drawing.Point(1173, 704);
            this.btnfecharraletorioturmas.Name = "btnfecharraletorioturmas";
            this.btnfecharraletorioturmas.Size = new System.Drawing.Size(97, 37);
            this.btnfecharraletorioturmas.TabIndex = 24;
            this.btnfecharraletorioturmas.Text = "Fechar";
            this.btnfecharraletorioturmas.UseVisualStyleBackColor = true;
            this.btnfecharraletorioturmas.Click += new System.EventHandler(this.btnfecharraletorioturma_Click);
            // 
            // relatorioTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.btnfecharraletorioturmas);
            this.Controls.Add(this.gridalunosmatriculados);
            this.MaximumSize = new System.Drawing.Size(2000, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "relatorioTurmas";
            this.Text = "Relatório de turmas";
            ((System.ComponentModel.ISupportInitialize)(this.gridalunosmatriculados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridalunosmatriculados;
        private System.Windows.Forms.Button btnfecharraletorioturmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
    }
}