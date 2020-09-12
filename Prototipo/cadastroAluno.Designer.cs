namespace Protótipo
{
    partial class cadastroAluno
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtnomealuno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxcursoaluno = new System.Windows.Forms.ComboBox();
            this.cbxmunicipioaluno = new System.Windows.Forms.ComboBox();
            this.txtlogradouroaluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxufaluno = new System.Windows.Forms.ComboBox();
            this.btnfecharaluno = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnalteraraluno = new System.Windows.Forms.Button();
            this.btninseriraluno = new System.Windows.Forms.Button();
            this.txtmatriculaaluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumeroenderecoaluno = new System.Windows.Forms.TextBox();
            this.gridrelatorioalunosmatriculados = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridrelatorioalunosmatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtnomealuno
            // 
            this.txtnomealuno.Location = new System.Drawing.Point(89, 24);
            this.txtnomealuno.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomealuno.MaximumSize = new System.Drawing.Size(451, 25);
            this.txtnomealuno.MinimumSize = new System.Drawing.Size(451, 25);
            this.txtnomealuno.Name = "txtnomealuno";
            this.txtnomealuno.Size = new System.Drawing.Size(451, 20);
            this.txtnomealuno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logradouro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Município";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Curso";
            // 
            // cbxcursoaluno
            // 
            this.cbxcursoaluno.FormattingEnabled = true;
            this.cbxcursoaluno.Location = new System.Drawing.Point(544, 69);
            this.cbxcursoaluno.Margin = new System.Windows.Forms.Padding(2);
            this.cbxcursoaluno.MaximumSize = new System.Drawing.Size(268, 0);
            this.cbxcursoaluno.MinimumSize = new System.Drawing.Size(268, 0);
            this.cbxcursoaluno.Name = "cbxcursoaluno";
            this.cbxcursoaluno.Size = new System.Drawing.Size(268, 21);
            this.cbxcursoaluno.TabIndex = 9;
            this.cbxcursoaluno.Text = "                                     ";
            // 
            // cbxmunicipioaluno
            // 
            this.cbxmunicipioaluno.FormattingEnabled = true;
            this.cbxmunicipioaluno.Location = new System.Drawing.Point(544, 24);
            this.cbxmunicipioaluno.Margin = new System.Windows.Forms.Padding(2);
            this.cbxmunicipioaluno.MaximumSize = new System.Drawing.Size(226, 0);
            this.cbxmunicipioaluno.MinimumSize = new System.Drawing.Size(226, 0);
            this.cbxmunicipioaluno.Name = "cbxmunicipioaluno";
            this.cbxmunicipioaluno.Size = new System.Drawing.Size(226, 21);
            this.cbxmunicipioaluno.TabIndex = 10;
            this.cbxmunicipioaluno.Text = "                                                            ";
            // 
            // txtlogradouroaluno
            // 
            this.txtlogradouroaluno.Location = new System.Drawing.Point(8, 69);
            this.txtlogradouroaluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtlogradouroaluno.MaximumSize = new System.Drawing.Size(451, 25);
            this.txtlogradouroaluno.MinimumSize = new System.Drawing.Size(451, 25);
            this.txtlogradouroaluno.Name = "txtlogradouroaluno";
            this.txtlogradouroaluno.Size = new System.Drawing.Size(451, 20);
            this.txtlogradouroaluno.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "UF";
            // 
            // cbxufaluno
            // 
            this.cbxufaluno.FormattingEnabled = true;
            this.cbxufaluno.Items.AddRange(new object[] {
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxufaluno.Location = new System.Drawing.Point(774, 24);
            this.cbxufaluno.Margin = new System.Windows.Forms.Padding(2);
            this.cbxufaluno.MaximumSize = new System.Drawing.Size(38, 0);
            this.cbxufaluno.MinimumSize = new System.Drawing.Size(38, 0);
            this.cbxufaluno.Name = "cbxufaluno";
            this.cbxufaluno.Size = new System.Drawing.Size(38, 21);
            this.cbxufaluno.TabIndex = 13;
            // 
            // btnfecharaluno
            // 
            this.btnfecharaluno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharaluno.Location = new System.Drawing.Point(740, 94);
            this.btnfecharaluno.Margin = new System.Windows.Forms.Padding(2);
            this.btnfecharaluno.Name = "btnfecharaluno";
            this.btnfecharaluno.Size = new System.Drawing.Size(73, 30);
            this.btnfecharaluno.TabIndex = 15;
            this.btnfecharaluno.Text = "Fechar";
            this.btnfecharaluno.UseVisualStyleBackColor = true;
            this.btnfecharaluno.Click += new System.EventHandler(this.btnfecharaluno_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Matrícula";
            // 
            // btnalteraraluno
            // 
            this.btnalteraraluno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalteraraluno.Location = new System.Drawing.Point(586, 94);
            this.btnalteraraluno.Margin = new System.Windows.Forms.Padding(2);
            this.btnalteraraluno.Name = "btnalteraraluno";
            this.btnalteraraluno.Size = new System.Drawing.Size(73, 30);
            this.btnalteraraluno.TabIndex = 18;
            this.btnalteraraluno.Text = "Alterar";
            this.btnalteraraluno.UseVisualStyleBackColor = true;
            this.btnalteraraluno.Click += new System.EventHandler(this.btnalteraraluno_Click);
            // 
            // btninseriraluno
            // 
            this.btninseriraluno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninseriraluno.Location = new System.Drawing.Point(663, 94);
            this.btninseriraluno.Margin = new System.Windows.Forms.Padding(2);
            this.btninseriraluno.Name = "btninseriraluno";
            this.btninseriraluno.Size = new System.Drawing.Size(73, 30);
            this.btninseriraluno.TabIndex = 19;
            this.btninseriraluno.Text = "Inserir";
            this.btninseriraluno.UseVisualStyleBackColor = true;
            this.btninseriraluno.Click += new System.EventHandler(this.btninseriraluno_Click_1);
            // 
            // txtmatriculaaluno
            // 
            this.txtmatriculaaluno.Enabled = false;
            this.txtmatriculaaluno.Location = new System.Drawing.Point(9, 24);
            this.txtmatriculaaluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtmatriculaaluno.MaximumSize = new System.Drawing.Size(76, 25);
            this.txtmatriculaaluno.MinimumSize = new System.Drawing.Size(76, 25);
            this.txtmatriculaaluno.Name = "txtmatriculaaluno";
            this.txtmatriculaaluno.ReadOnly = true;
            this.txtmatriculaaluno.Size = new System.Drawing.Size(76, 20);
            this.txtmatriculaaluno.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Número";
            // 
            // txtnumeroenderecoaluno
            // 
            this.txtnumeroenderecoaluno.Location = new System.Drawing.Point(463, 69);
            this.txtnumeroenderecoaluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumeroenderecoaluno.MaximumSize = new System.Drawing.Size(76, 21);
            this.txtnumeroenderecoaluno.MinimumSize = new System.Drawing.Size(76, 21);
            this.txtnumeroenderecoaluno.Name = "txtnumeroenderecoaluno";
            this.txtnumeroenderecoaluno.Size = new System.Drawing.Size(76, 20);
            this.txtnumeroenderecoaluno.TabIndex = 22;
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
            this.gridrelatorioalunosmatriculados.Location = new System.Drawing.Point(8, 128);
            this.gridrelatorioalunosmatriculados.Margin = new System.Windows.Forms.Padding(2);
            this.gridrelatorioalunosmatriculados.MaximumSize = new System.Drawing.Size(800, 569);
            this.gridrelatorioalunosmatriculados.MinimumSize = new System.Drawing.Size(800, 552);
            this.gridrelatorioalunosmatriculados.Name = "gridrelatorioalunosmatriculados";
            this.gridrelatorioalunosmatriculados.ReadOnly = true;
            this.gridrelatorioalunosmatriculados.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.gridrelatorioalunosmatriculados.RowTemplate.Height = 24;
            this.gridrelatorioalunosmatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridrelatorioalunosmatriculados.Size = new System.Drawing.Size(800, 552);
            this.gridrelatorioalunosmatriculados.TabIndex = 24;
            this.gridrelatorioalunosmatriculados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridrelatorioalunosmatriculados_CellContentDoubleClick);
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            this.matricula.Width = 80;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Width = 200;
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Município";
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            this.municipio.Width = 200;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            this.UF.Width = 50;
            // 
            // logradouro
            // 
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            this.logradouro.Width = 300;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(509, 94);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(73, 30);
            this.btnexcluir.TabIndex = 25;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // cadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 690);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.gridrelatorioalunosmatriculados);
            this.Controls.Add(this.txtnumeroenderecoaluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmatriculaaluno);
            this.Controls.Add(this.btninseriraluno);
            this.Controls.Add(this.btnalteraraluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnfecharaluno);
            this.Controls.Add(this.cbxufaluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlogradouroaluno);
            this.Controls.Add(this.cbxmunicipioaluno);
            this.Controls.Add(this.cbxcursoaluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomealuno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cadastroAluno";
            this.Text = "Cadastro de aluno";
            this.Load += new System.EventHandler(this.cadastroAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridrelatorioalunosmatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtnomealuno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxcursoaluno;
        private System.Windows.Forms.ComboBox cbxmunicipioaluno;
        private System.Windows.Forms.TextBox txtlogradouroaluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxufaluno;
        private System.Windows.Forms.Button btnfecharaluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnalteraraluno;
        private System.Windows.Forms.Button btninseriraluno;
        private System.Windows.Forms.TextBox txtmatriculaaluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnumeroenderecoaluno;
        private System.Windows.Forms.DataGridView gridrelatorioalunosmatriculados;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Button btnexcluir;
    }
}