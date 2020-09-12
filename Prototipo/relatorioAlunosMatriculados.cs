using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Protótipo

{
    public partial class relatorioAlunosMatriculados : Form
    {
        public relatorioAlunosMatriculados()
        {
            InitializeComponent();
        }

        private void atualizarGrid()
        // cria o método de Atualizar grid
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = conexaoBD.Abrirconexao();
            try
            {
                command.CommandText = "SELECT a.id, a.nome, b.nome,  c.nome, a.uf, a.logradouro, a.numero from ca_aluno a inner join ca_curso b on b.id = a.curso inner join ca_municipio c on c.id = a.municipio           ";
         
                MySqlDataReader reader = command.ExecuteReader();

                gridrelatorioalunosmatriculados.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)gridrelatorioalunosmatriculados.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID MAATRICULA
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//CURSO
                    row.Cells[3].Value = reader.GetString(3);//MUNICIPIO
                    row.Cells[4].Value = reader.GetString(4);//UF
                    row.Cells[5].Value = reader.GetString(5);//LOGRADOURO
                    row.Cells[6].Value = reader.GetString(6);//NUMERO
                    gridrelatorioalunosmatriculados.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                conexaoBD.Fecharconexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }

        }


        private void relatorioAlunosMatriculados_Load(object sender, EventArgs e)
        {
                        atualizarGrid();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

            

        

    
