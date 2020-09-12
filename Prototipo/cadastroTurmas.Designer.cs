namespace Protótipo
{
    partial class cadastroTurmas
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
            this.btnnovoturma = new System.Windows.Forms.Button();
            this.txtidturma = new System.Windows.Forms.TextBox();
            this.btninserirturma = new System.Windows.Forms.Button();
            this.btnalterarturma = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnfecharturma = new System.Windows.Forms.Button();
            this.cbxcursoturma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxprofessorturma = new System.Windows.Forms.ComboBox();
            this.cbxalunoturma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnnovoturma
            // 
            this.btnnovoturma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovoturma.Location = new System.Drawing.Point(238, 95);
            this.btnnovoturma.Margin = new System.Windows.Forms.Padding(2);
            this.btnnovoturma.Name = "btnnovoturma";
            this.btnnovoturma.Size = new System.Drawing.Size(73, 30);
            this.btnnovoturma.TabIndex = 41;
            this.btnnovoturma.Text = "Novo";
            this.btnnovoturma.UseVisualStyleBackColor = true;
            // 
            // txtidturma
            // 
            this.txtidturma.Enabled = false;
            this.txtidturma.Location = new System.Drawing.Point(465, 27);
            this.txtidturma.Margin = new System.Windows.Forms.Padding(2);
            this.txtidturma.MaximumSize = new System.Drawing.Size(76, 21);
            this.txtidturma.MinimumSize = new System.Drawing.Size(76, 21);
            this.txtidturma.Name = "txtidturma";
            this.txtidturma.ReadOnly = true;
            this.txtidturma.Size = new System.Drawing.Size(76, 20);
            this.txtidturma.TabIndex = 38;
            // 
            // btninserirturma
            // 
            this.btninserirturma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserirturma.Location = new System.Drawing.Point(392, 95);
            this.btninserirturma.Margin = new System.Windows.Forms.Padding(2);
            this.btninserirturma.Name = "btninserirturma";
            this.btninserirturma.Size = new System.Drawing.Size(73, 30);
            this.btninserirturma.TabIndex = 37;
            this.btninserirturma.Text = "Inserir";
            this.btninserirturma.UseVisualStyleBackColor = true;
            // 
            // btnalterarturma
            // 
            this.btnalterarturma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterarturma.Location = new System.Drawing.Point(315, 95);
            this.btnalterarturma.Margin = new System.Windows.Forms.Padding(2);
            this.btnalterarturma.Name = "btnalterarturma";
            this.btnalterarturma.Size = new System.Drawing.Size(73, 30);
            this.btnalterarturma.TabIndex = 36;
            this.btnalterarturma.Text = "Alterar";
            this.btnalterarturma.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Id";
            // 
            // btnfecharturma
            // 
            this.btnfecharturma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharturma.Location = new System.Drawing.Point(469, 95);
            this.btnfecharturma.Margin = new System.Windows.Forms.Padding(2);
            this.btnfecharturma.Name = "btnfecharturma";
            this.btnfecharturma.Size = new System.Drawing.Size(73, 30);
            this.btnfecharturma.TabIndex = 34;
            this.btnfecharturma.Text = "Fechar";
            this.btnfecharturma.UseVisualStyleBackColor = true;
            this.btnfecharturma.Click += new System.EventHandler(this.btnfecharturma_Click);
            // 
            // cbxcursoturma
            // 
            this.cbxcursoturma.FormattingEnabled = true;
            this.cbxcursoturma.Items.AddRange(new object[] {
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
            this.cbxcursoturma.Location = new System.Drawing.Point(365, 70);
            this.cbxcursoturma.Margin = new System.Windows.Forms.Padding(2);
            this.cbxcursoturma.MaximumSize = new System.Drawing.Size(175, 0);
            this.cbxcursoturma.MinimumSize = new System.Drawing.Size(175, 0);
            this.cbxcursoturma.Name = "cbxcursoturma";
            this.cbxcursoturma.Size = new System.Drawing.Size(175, 21);
            this.cbxcursoturma.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Curso";
            // 
            // cbxprofessorturma
            // 
            this.cbxprofessorturma.FormattingEnabled = true;
            this.cbxprofessorturma.Location = new System.Drawing.Point(11, 70);
            this.cbxprofessorturma.Margin = new System.Windows.Forms.Padding(2);
            this.cbxprofessorturma.MaximumSize = new System.Drawing.Size(350, 0);
            this.cbxprofessorturma.MinimumSize = new System.Drawing.Size(350, 0);
            this.cbxprofessorturma.Name = "cbxprofessorturma";
            this.cbxprofessorturma.Size = new System.Drawing.Size(350, 21);
            this.cbxprofessorturma.TabIndex = 30;
            this.cbxprofessorturma.Text = "                                                            ";
            // 
            // cbxalunoturma
            // 
            this.cbxalunoturma.FormattingEnabled = true;
            this.cbxalunoturma.Location = new System.Drawing.Point(11, 27);
            this.cbxalunoturma.Margin = new System.Windows.Forms.Padding(2);
            this.cbxalunoturma.MaximumSize = new System.Drawing.Size(450, 0);
            this.cbxalunoturma.MinimumSize = new System.Drawing.Size(450, 0);
            this.cbxalunoturma.Name = "cbxalunoturma";
            this.cbxalunoturma.Size = new System.Drawing.Size(450, 21);
            this.cbxalunoturma.TabIndex = 29;
            this.cbxalunoturma.Text = "                                     ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Aluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Professor";
            // 
            // cadastroTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 136);
            this.Controls.Add(this.btnnovoturma);
            this.Controls.Add(this.txtidturma);
            this.Controls.Add(this.btninserirturma);
            this.Controls.Add(this.btnalterarturma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnfecharturma);
            this.Controls.Add(this.cbxcursoturma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxprofessorturma);
            this.Controls.Add(this.cbxalunoturma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "cadastroTurmas";
            this.Text = "Cadastro de turmas";
            this.Load += new System.EventHandler(this.cadastroTurmas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnovoturma;
        private System.Windows.Forms.TextBox txtidturma;
        private System.Windows.Forms.Button btninserirturma;
        private System.Windows.Forms.Button btnalterarturma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnfecharturma;
        private System.Windows.Forms.ComboBox cbxcursoturma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxprofessorturma;
        private System.Windows.Forms.ComboBox cbxalunoturma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}