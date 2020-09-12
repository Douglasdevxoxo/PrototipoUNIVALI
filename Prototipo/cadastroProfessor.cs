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
     public partial class cadastroProfessor : Form
    {
        public cadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnfecharprofessor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninserirprofessor_Click(object sender, EventArgs e)
        {
            
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = conexaoBD.Abrirconexao();
                        command.CommandText = "INSERT INTO `ca_professor`(`NOME`, `FORMACAO`,  `LOGRADOURO`, NUMERO, MUNICIPIO) " +
                            "VALUES ('" + txtnomeprofessor.Text + "','" + cbxformacaoprofessor.Text + "', '" + txtlogradouroprofessor.Text + "', '" + txtnumeroenderecoprofessor.Text + "', (select id from ca_municipio where nome like'" + cbxmunicipioprofessor.Text + "' and UF in ('" + cbxufprofessor.Text + "')))";


                        command.ExecuteNonQuery();
                        command.Connection.Close();
                        MessageBox.Show("Professor cadastrado com sucesso!");

                        txtnomeprofessor.Text = "";
                        cbxformacaoprofessor.Text = "";
                        cbxmunicipioprofessor.Text = "";
                        cbxufprofessor.Text = "";
                        txtlogradouroprofessor.Text = "";
                        txtnumeroenderecoprofessor.Text = "";

                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                        Console.WriteLine(ex.Message);
                    }
                }
            
        }

        private void cadastroProfessor_Load(object sender, EventArgs e)
        {
            string municipioprofessor = @"select id, nome from ca_municipio";
            cbxmunicipioprofessor.Items.Clear();
            cbxmunicipioprofessor.DataSource = conexaoBD.dql(municipioprofessor);
            cbxmunicipioprofessor.DisplayMember = "nome";
            cbxmunicipioprofessor.ValueMember = "id";
        }
    }
}
