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
    public partial class relatorioProfessor : Form
    {
        public relatorioProfessor()
        {
            InitializeComponent();
        }

        private void btnfecharrelatorioprofessores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
