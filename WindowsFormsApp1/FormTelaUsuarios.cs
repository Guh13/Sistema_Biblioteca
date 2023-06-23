using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormTelaUsuarios : Form
    {
        public FormTelaUsuarios()
        {
            InitializeComponent();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            FormEmprestimo formEmprestimo = new FormEmprestimo();
            formEmprestimo.Show();
        }

        private void btnAcervo_Click(object sender, EventArgs e)
        {
            FormAcervo formAcervo = new FormAcervo();
            formAcervo.Show();
        }

        private void btnDv_Click(object sender, EventArgs e)
        {
            FormRegistroDeDevolucoes formRegistroDeDevolucoes = new FormRegistroDeDevolucoes();
            formRegistroDeDevolucoes.Show();
        }
    }
}
