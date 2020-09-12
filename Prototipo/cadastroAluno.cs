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
    public partial class cadastroAluno : Form
    {
        
        public cadastroAluno()
        {
            InitializeComponent();
        }

        private void btnfecharaluno_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void limparCampos()
        //Cria método de limpar campos do furmulário
        {

            txtnomealuno.Clear();
            cbxcursoaluno.Text = "";
            cbxmunicipioaluno.Text = "";
            txtlogradouroaluno.Text = "";
            cbxufaluno.Text = "";
            txtmatriculaaluno.Clear();
            txtnumeroenderecoaluno.Clear();
            
        }

        private void btninseriraluno_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "INSERT INTO `ca_aluno`(`NOME`, CURSO, `UF`, MUNICIPIO, `LOGRADOURO`, NUMERO) " +
                    "VALUES ('" + txtnomealuno.Text + "',(select id from ca_curso where nome like'" + cbxcursoaluno.Text + "'),'" + cbxufaluno.Text + "', (select id from ca_municipio where nome like'" + cbxmunicipioaluno.Text + "' and UF in ('" + cbxufaluno.Text + "')),'" + txtlogradouroaluno.Text + "', '" + txtnumeroenderecoaluno.Text + "')";

                
                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Aluno cadastrado com sucesso!");

                limparCampos();

                atualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }

        }

        private void cadastroAluno_Load(object sender, EventArgs e)
        {
            
            atualizarGrid();
            limparCampos();

            string municipioaluno = @"select id, nome from ca_municipio";
            cbxmunicipioaluno.Items.Clear();
            cbxmunicipioaluno.DataSource = conexaoBD.dql(municipioaluno);
            cbxmunicipioaluno.DisplayMember = "nome";
            cbxmunicipioaluno.ValueMember = "id";

            string cursooaluno = @"select id, nome from ca_curso";
            cbxcursoaluno.Items.Clear();
            cbxcursoaluno.DataSource = conexaoBD.dql(cursooaluno);
            cbxcursoaluno.DisplayMember = "nome";
            cbxcursoaluno.ValueMember = "id";
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

        
        private void gridrelatorioalunosmatriculados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //preenche os textbox e combobox com as células da linha do grid selecionada
            if (gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                gridrelatorioalunosmatriculados.CurrentRow.Selected = true;


                txtmatriculaaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["matricula"].FormattedValue.ToString();
                txtnomealuno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                cbxcursoaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["curso"].FormattedValue.ToString();
                cbxmunicipioaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["municipio"].FormattedValue.ToString();
                cbxufaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["UF"].FormattedValue.ToString();
                txtlogradouroaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["logradouro"].FormattedValue.ToString();
                txtnumeroenderecoaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["numero"].FormattedValue.ToString();

            }

        }

        private void btnalteraraluno_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_aluno SET NOME = '" + txtnomealuno.Text + "' , CURSO = (select id from ca_curso where nome like'" + cbxcursoaluno.Text + "'), " +
                    "UF = '" + cbxufaluno.Text + "', MUNICIPIO = (select id from ca_municipio where nome like'" + cbxmunicipioaluno.Text + "' and UF in ('" + cbxufaluno.Text + "')) , " +
                    "LOGRADOURO = '" + txtlogradouroaluno.Text + "', NUMERO = '" + txtnumeroenderecoaluno.Text + "' WHERE id in ('" + txtmatriculaaluno.Text + "')";
            
                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Aluno alterado com sucesso!");

                limparCampos();

                atualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {


            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "DELETE FROM ca_aluno WHERE id in ('" + txtmatriculaaluno.Text + "')"; 

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Aluno excluido com sucesso!");

                limparCampos();

                atualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }

        }
    }           
              
 }

