using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protótipo
{
    public partial class cadastroCurso : Form
    {
        public cadastroCurso()
        {
            InitializeComponent();
        }

        private void btnfecharcurso_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void limparCampos()
        //Cria método de limpar campos do furmulário
        {

            txtnomecurso.Clear();
            cbxgraucurso.Text = "";
            cbxcoordenadorcurso.Text = "";
            cbxpolocurso.Text = "";
            txtcargahorariacurso.Clear();
            txtcodigocurso.Clear();
        }

        private void cadastroCurso_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            limparCampos();

        }

        private void btninserircurso_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = conexaoBD.Abrirconexao();
                        command.CommandText = "INSERT INTO `ca_curso`(`NOME`, `COORDENADOR`, `POLO`, `GRAU`, CARGAHORARIA) " +
                            "VALUES ('" + txtnomecurso.Text + "','" + cbxcoordenadorcurso.Text + "', '" + cbxpolocurso.Text + "',  '" + cbxgraucurso.Text + "','" + txtcargahorariacurso.Text + "')";


                        command.ExecuteNonQuery();
                        command.Connection.Close();
                        MessageBox.Show("Curso cadastrado com sucesso!");

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

        private void atualizarGrid()
        // cria o método de Atualizar grid
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = conexaoBD.Abrirconexao();
            try
            {
                command.CommandText = "SELECT a.id, a.nome, a.grau, a.coordenador, a.cargahoraria, a.polo from ca_curso a ";

                MySqlDataReader reader = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//GRAU
                    row.Cells[3].Value = reader.GetString(3);//COORDENADOR
                    row.Cells[4].Value = reader.GetString(4);//CARGAHORARIA
                    row.Cells[5].Value = reader.GetString(5);//POLO
                    dataGridView1.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                conexaoBD.Fecharconexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //preenche os textbox e combobox com as células da linha do grid selecionada
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;


                txtcodigocurso.Text = dataGridView1.Rows[e.RowIndex].Cells["codigo"].FormattedValue.ToString();
                txtnomecurso.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                cbxgraucurso.Text = dataGridView1.Rows[e.RowIndex].Cells["grau"].FormattedValue.ToString();
                cbxcoordenadorcurso.Text = dataGridView1.Rows[e.RowIndex].Cells["coordenador"].FormattedValue.ToString();
                txtcargahorariacurso.Text = dataGridView1.Rows[e.RowIndex].Cells["cargahoraria"].FormattedValue.ToString();
                cbxpolocurso.Text = dataGridView1.Rows[e.RowIndex].Cells["polo"].FormattedValue.ToString();

            }
        }

        private void btnalterarcurso_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_curso SET NOME = '" + txtnomecurso.Text + "' , COORDENADOR = '" + cbxcoordenadorcurso.Text + "', " +
                    "POLO = '" + cbxpolocurso.Text + "', GRAU = '" + cbxgraucurso.Text + "', CARGAHORARIA = '" + txtcargahorariacurso.Text + "'  WHERE id in ('" + txtcodigocurso.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Curso alterado com sucesso!");

                limparCampos();
                atualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnexcluircurso_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "DELETE FROM ca_curso WHERE id in ('" + txtcodigocurso.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Curso excluido com sucesso!");

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

        

      
    

      
    
