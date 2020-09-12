namespace Protótipo
{
    partial class cadastroMunicipio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomemunicipio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoibgemunicipio = new System.Windows.Forms.TextBox();
            this.btnfecharmunicipio = new System.Windows.Forms.Button();
            this.txtidmunicipio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btninserirmunicipio = new System.Windows.Forms.Button();
            this.btnalterarmunicipio = new System.Windows.Forms.Button();
            this.cbxufmunicipio = new System.Windows.Forms.ComboBox();
            this.btnexcluirmunicipio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoibge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // txtnomemunicipio
            // 
            this.txtnomemunicipio.Location = new System.Drawing.Point(91, 32);
            this.txtnomemunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomemunicipio.MaximumSize = new System.Drawing.Size(451, 21);
            this.txtnomemunicipio.MinimumSize = new System.Drawing.Size(451, 21);
            this.txtnomemunicipio.Name = "txtnomemunicipio";
            this.txtnomemunicipio.Size = new System.Drawing.Size(451, 21);
            this.txtnomemunicipio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Código IBGE";
            // 
            // txtcodigoibgemunicipio
            // 
            this.txtcodigoibgemunicipio.Location = new System.Drawing.Point(625, 32);
            this.txtcodigoibgemunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigoibgemunicipio.MaximumSize = new System.Drawing.Size(140, 21);
            this.txtcodigoibgemunicipio.MinimumSize = new System.Drawing.Size(140, 21);
            this.txtcodigoibgemunicipio.Name = "txtcodigoibgemunicipio";
            this.txtcodigoibgemunicipio.Size = new System.Drawing.Size(140, 21);
            this.txtcodigoibgemunicipio.TabIndex = 21;
            // 
            // btnfecharmunicipio
            // 
            this.btnfecharmunicipio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharmunicipio.Location = new System.Drawing.Point(692, 59);
            this.btnfecharmunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.btnfecharmunicipio.Name = "btnfecharmunicipio";
            this.btnfecharmunicipio.Size = new System.Drawing.Size(73, 30);
            this.btnfecharmunicipio.TabIndex = 23;
            this.btnfecharmunicipio.Text = "Fechar";
            this.btnfecharmunicipio.UseVisualStyleBackColor = true;
            this.btnfecharmunicipio.Click += new System.EventHandler(this.btnfecharmunicipio_Click);
            // 
            // txtidmunicipio
            // 
            this.txtidmunicipio.Enabled = false;
            this.txtidmunicipio.Location = new System.Drawing.Point(11, 32);
            this.txtidmunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.txtidmunicipio.MaximumSize = new System.Drawing.Size(76, 21);
            this.txtidmunicipio.MinimumSize = new System.Drawing.Size(76, 21);
            this.txtidmunicipio.Name = "txtidmunicipio";
            this.txtidmunicipio.ReadOnly = true;
            this.txtidmunicipio.Size = new System.Drawing.Size(76, 21);
            this.txtidmunicipio.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Id";
            // 
            // btninserirmunicipio
            // 
            this.btninserirmunicipio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserirmunicipio.Location = new System.Drawing.Point(615, 59);
            this.btninserirmunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.btninserirmunicipio.Name = "btninserirmunicipio";
            this.btninserirmunicipio.Size = new System.Drawing.Size(73, 30);
            this.btninserirmunicipio.TabIndex = 27;
            this.btninserirmunicipio.Text = "Inserir";
            this.btninserirmunicipio.UseVisualStyleBackColor = true;
            this.btninserirmunicipio.Click += new System.EventHandler(this.btninserirmunicipio_Click);
            // 
            // btnalterarmunicipio
            // 
            this.btnalterarmunicipio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterarmunicipio.Location = new System.Drawing.Point(538, 59);
            this.btnalterarmunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.btnalterarmunicipio.Name = "btnalterarmunicipio";
            this.btnalterarmunicipio.Size = new System.Drawing.Size(73, 30);
            this.btnalterarmunicipio.TabIndex = 26;
            this.btnalterarmunicipio.Text = "Alterar";
            this.btnalterarmunicipio.UseVisualStyleBackColor = true;
            this.btnalterarmunicipio.Click += new System.EventHandler(this.btnalterarmunicipio_Click);
            // 
            // cbxufmunicipio
            // 
            this.cbxufmunicipio.FormattingEnabled = true;
            this.cbxufmunicipio.Items.AddRange(new object[] {
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
            this.cbxufmunicipio.Location = new System.Drawing.Point(546, 32);
            this.cbxufmunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.cbxufmunicipio.MaximumSize = new System.Drawing.Size(75, 0);
            this.cbxufmunicipio.MinimumSize = new System.Drawing.Size(75, 0);
            this.cbxufmunicipio.Name = "cbxufmunicipio";
            this.cbxufmunicipio.Size = new System.Drawing.Size(75, 21);
            this.cbxufmunicipio.TabIndex = 28;
            // 
            // btnexcluirmunicipio
            // 
            this.btnexcluirmunicipio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluirmunicipio.Location = new System.Drawing.Point(461, 59);
            this.btnexcluirmunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.btnexcluirmunicipio.Name = "btnexcluirmunicipio";
            this.btnexcluirmunicipio.Size = new System.Drawing.Size(73, 30);
            this.btnexcluirmunicipio.TabIndex = 29;
            this.btnexcluirmunicipio.Text = "Excluir";
            this.btnexcluirmunicipio.UseVisualStyleBackColor = true;
            this.btnexcluirmunicipio.Click += new System.EventHandler(this.btnexcluirmunicipio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.uf,
            this.codigoibge});
            this.dataGridView1.Location = new System.Drawing.Point(10, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(755, 569);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(755, 552);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 552);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // uf
            // 
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            // 
            // codigoibge
            // 
            this.codigoibge.HeaderText = "Código IBGE";
            this.codigoibge.Name = "codigoibge";
            this.codigoibge.ReadOnly = true;
            this.codigoibge.Width = 200;
            // 
            // cadastroMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 662);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnexcluirmunicipio);
            this.Controls.Add(this.cbxufmunicipio);
            this.Controls.Add(this.btninserirmunicipio);
            this.Controls.Add(this.btnalterarmunicipio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidmunicipio);
            this.Controls.Add(this.btnfecharmunicipio);
            this.Controls.Add(this.txtcodigoibgemunicipio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomemunicipio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cadastroMunicipio";
            this.Text = "Cadastro de município";
            this.Load += new System.EventHandler(this.cadastroMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomemunicipio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigoibgemunicipio;
        private System.Windows.Forms.Button btnfecharmunicipio;
        private System.Windows.Forms.TextBox txtidmunicipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btninserirmunicipio;
        private System.Windows.Forms.Button btnalterarmunicipio;
        private System.Windows.Forms.ComboBox cbxufmunicipio;
        private System.Windows.Forms.Button btnexcluirmunicipio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoibge;
    }
}