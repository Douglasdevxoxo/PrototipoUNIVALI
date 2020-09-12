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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroAluno abrirCadastroAluno = new cadastroAluno();
            abrirCadastroAluno.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroProfessor abrircadastroProfessor = new cadastroProfessor();
            abrircadastroProfessor.ShowDialog();
        }

        private void municípioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroMunicipio abrircadastroMunicipio = new cadastroMunicipio();
            abrircadastroMunicipio.ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroCurso abrircadastroCurso = new cadastroCurso();
            abrircadastroCurso.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void alunosMatriculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioAlunosMatriculados abrirrelatorioAlunosMatriculados = new relatorioAlunosMatriculados();
            abrirrelatorioAlunosMatriculados.ShowDialog();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            relatorioCurso abrirrelatorioCurso = new relatorioCurso();
            abrirrelatorioCurso.ShowDialog();
            
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioProfessor abrirrelatorioProfessor = new relatorioProfessor();
            abrirrelatorioProfessor.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioTurmas abrirrelatorioTurmas = new relatorioTurmas();
            abrirrelatorioTurmas.ShowDialog();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroTurmas abrirrelatorioTurmas = new cadastroTurmas();
            abrirrelatorioTurmas.ShowDialog();
        }
    }
}
