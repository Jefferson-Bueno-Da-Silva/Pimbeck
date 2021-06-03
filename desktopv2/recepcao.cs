using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class recepcao : Form
    {
        int X = 0;
        int Y = 0;
        TopPage page = new TopPage();

        public recepcao()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(panel17_MouseDown);
            this.MouseMove += new MouseEventHandler(panel17_MouseMove);
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

        private void close_Click(object sender, EventArgs e) => page.CloseClick();

        private void minimize_Click(object sender, EventArgs e) => page.MinimizeClick(this);

        private void FuncionariosBtn_Click(object sender, EventArgs e) => new Funcionarios().Show();

        private void ClientesBtn_Click(object sender, EventArgs e) => new Clientes().Show();
    }
}
