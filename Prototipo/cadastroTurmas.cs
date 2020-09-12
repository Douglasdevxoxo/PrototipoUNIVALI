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
    public partial class cadastroTurmas : Form
    {
        public cadastroTurmas()
        {
            InitializeComponent();
        }

        private void btnfecharturma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastroTurmas_Load(object sender, EventArgs e)
        {
            string alunoturma = @"select id, nome from ca_aluno";
            cbxalunoturma.Items.Clear();
            cbxalunoturma.DataSource = conexaoBD.dql(alunoturma);
            cbxalunoturma.DisplayMember = "nome";
            cbxalunoturma.ValueMember = "id";


            string professorturma = @"select id, nome from ca_professor";
            cbxprofessorturma.Items.Clear();
            cbxprofessorturma.DataSource = conexaoBD.dql(professorturma);
            cbxprofessorturma.DisplayMember = "nome";
            cbxprofessorturma.ValueMember = "id";


            string cursoturma = @"select id, nome from ca_curso";
            cbxcursoturma.Items.Clear();
            cbxcursoturma.DataSource = conexaoBD.dql(cursoturma);
            cbxcursoturma.DisplayMember = "nome";
            cbxcursoturma.ValueMember = "id";
        }
    }
}
