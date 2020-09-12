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
    public partial class cadastroMunicipio : Form
    {
        public cadastroMunicipio()
        {
            InitializeComponent();
        }

        private void btnfecharmunicipio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparCampos()
        //Cria método de limpar campos do furmulário
        {

            txtnomemunicipio.Clear();
            cbxufmunicipio.Text = "";
            txtcodigoibgemunicipio.Clear();
            txtidmunicipio.Clear();

        }

        private void cadastroMunicipio_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            limparCampos();
        }


        private void atualizarGrid()
        // cria o método de Atualizar grid
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = conexaoBD.Abrirconexao();
            try
            {
                command.CommandText = "SELECT id,nome, uf, codigoibge FROM ca_municipio";

                MySqlDataReader reader = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID 
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//UF
                    row.Cells[3].Value = reader.GetString(3);//CODIGOIBGE
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

        private void btninserirmunicipio_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "INSERT INTO `ca_municipio`(`NOME`, `UF`, CODIGOIBGE) " +
                        "VALUES ('" + txtnomemunicipio.Text + "','" + cbxufmunicipio.Text + "', '" + txtcodigoibgemunicipio.Text + "')";


                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Município cadastrado com sucesso!");

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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //preenche os textbox e combobox com as células da linha do grid selecionada
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;


                txtidmunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txtnomemunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                cbxufmunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["uf"].FormattedValue.ToString();
                txtcodigoibgemunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["codigoibge"].FormattedValue.ToString();


                
            }

        }

        private void btnalterarmunicipio_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_municipio SET NOME = '" + txtnomemunicipio.Text + "', UF = '" + cbxufmunicipio.Text + "', CODIGOIBGE = '" + txtcodigoibgemunicipio.Text + "'   " +
                    "WHERE id in ('" + txtidmunicipio.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Município alterado com sucesso!");

                limparCampos();

                atualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnexcluirmunicipio_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "DELETE FROM ca_municipio WHERE id in ('" + txtidmunicipio.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Município excluido com sucesso!");

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