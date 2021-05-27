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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void H1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void RecepcaoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recepcao Recepcao = new Recepcao();
            Recepcao.Show();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Funcionarios_adicionar_func Funcionarios_adicionar_func = new Funcionarios_adicionar_func();
            Funcionarios_adicionar_func.Show();
        }

        private void moveToBack_Click(object sender, EventArgs e)
        {
            Recepcao Recepcao = new Recepcao();
            Recepcao.Show();
            this.Close();
        }
    }
}
