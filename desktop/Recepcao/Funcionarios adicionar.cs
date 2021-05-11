using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepcao
{
    public partial class Funcionarios_adicionar_func : Form
    {
        public Funcionarios_adicionar_func()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FuncionariosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funcionarios func = new Funcionarios();
            func.Show();
        }

        private void RecepcaoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recepcao Recepcao = new Recepcao();
            Recepcao.Show();
        }
    }
}
