using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void moveToBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "adicionar",
                "add",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Editar",
                "Edit",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Imprimir Relatório",
                "Print",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Gerar planilha exel",
                "Planilha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            );
        }
    }
}
