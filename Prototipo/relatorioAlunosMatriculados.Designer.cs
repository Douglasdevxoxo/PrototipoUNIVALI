namespace Protótipo
{
    partial class relatorioAlunosMatriculados
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
            this.gridrelatorioalunosmatriculados = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnfechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridrelatorioalunosmatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridrelatorioalunosmatriculados
            // 
            this.gridrelatorioalunosmatriculados.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.gridrelatorioalunosmatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridrelatorioalunosmatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nome,
            this.curso,
            this.municipio,
            this.UF,
            this.logradouro,
            this.numero});
            this.gridrelatorioalunosmatriculados.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.gridrelatorioalunosmatriculados.Location = new System.Drawing.Point(11, 11);
            this.gridrelatorioalunosmatriculados.Margin = new System.Windows.Forms.Padding(2);
            this.gridrelatorioalunosmatriculados.MaximumSize = new System.Drawing.Size(1160, 600);
            this.gridrelatorioalunosmatriculados.MinimumSize = new System.Drawing.Size(1160, 600);
            this.gridrelatorioalunosmatriculados.Name = "gridrelatorioalunosmatriculados";
            this.gridrelatorioalunosmatriculados.ReadOnly = true;
            this.gridrelatorioalunosmatriculados.RowTemplate.Height = 24;
            this.gridrelatorioalunosmatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridrelatorioalunosmatriculados.Size = new System.Drawing.Size(1160, 600);
            this.gridrelatorioalunosmatriculados.TabIndex = 20;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
            this.matricula.Width = 80;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 250;
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.Width = 200;
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Município";
            this.municipio.Name = "municipio";
            this.municipio.Width = 200;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.Width = 50;
            // 
            // logradouro
            // 
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.Width = 300;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            // 
            // btnfechar
            // 
            this.btnfechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(1100, 620);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(73, 30);
            this.btnfechar.TabIndex = 21;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // relatorioAlunosMatriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.gridrelatorioalunosmatriculados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "relatorioAlunosMatriculados";
            this.Text = "Relatório de alunos matriculados";
            this.Load += new System.EventHandler(this.relatorioAlunosMatriculados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridrelatorioalunosmatriculados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridrelatorioalunosmatriculados;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Button btnfechar;
    }
}