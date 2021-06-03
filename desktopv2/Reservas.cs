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
        int X = 0;
        int Y = 0;
        public Reservas()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(panel17_MouseDown);
            this.MouseMove += new MouseEventHandler(panel17_MouseMove);
        }

        private void moveToBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) => new ReservaAdicionar().Show();

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

        private void panel17_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
