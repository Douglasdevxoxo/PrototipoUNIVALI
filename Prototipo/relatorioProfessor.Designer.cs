namespace Protótipo
{
    partial class relatorioProfessor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnfecharrelatorioprofessores = new System.Windows.Forms.Button();
            this.btnexcluirprofessor = new System.Windows.Forms.Button();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.matricula,
            this.nome,
            this.curso,
            this.municipio,
            this.UF,
            this.logradouro});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1256, 700);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1255, 680);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 680);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnfecharrelatorioprofessores
            // 
            this.btnfecharrelatorioprofessores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharrelatorioprofessores.Location = new System.Drawing.Point(1173, 704);
            this.btnfecharrelatorioprofessores.Name = "btnfecharrelatorioprofessores";
            this.btnfecharrelatorioprofessores.Size = new System.Drawing.Size(97, 37);
            this.btnfecharrelatorioprofessores.TabIndex = 21;
            this.btnfecharrelatorioprofessores.Text = "Fechar";
            this.btnfecharrelatorioprofessores.UseVisualStyleBackColor = true;
            this.btnfecharrelatorioprofessores.Click += new System.EventHandler(this.btnfecharrelatorioprofessores_Click);
            // 
            // btnexcluirprofessor
            // 
            this.btnexcluirprofessor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluirprofessor.Location = new System.Drawing.Point(1070, 704);
            this.btnexcluirprofessor.Name = "btnexcluirprofessor";
            this.btnexcluirprofessor.Size = new System.Drawing.Size(97, 37);
            this.btnexcluirprofessor.TabIndex = 20;
            this.btnexcluirprofessor.Text = "Excluir";
            this.btnexcluirprofessor.UseVisualStyleBackColor = true;
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "";
            this.checkbox.Name = "checkbox";
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Id";
            this.matricula.Name = "matricula";
            this.matricula.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 300;
            // 
            // curso
            // 
            this.curso.HeaderText = "Formação";
            this.curso.Name = "curso";
            this.curso.Width = 200;
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Município";
            this.municipio.Name = "municipio";
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.Width = 70;
            // 
            // logradouro
            // 
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.Width = 300;
            // 
            // relatorioProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.btnfecharrelatorioprofessores);
            this.Controls.Add(this.btnexcluirprofessor);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(2000, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "relatorioProfessor";
            this.Text = "Relatório de professores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfecharrelatorioprofessores;
        private System.Windows.Forms.Button btnexcluirprofessor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
    }
}