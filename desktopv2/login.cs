using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class login : Form
    {
        int X = 0;
        int Y = 0;
        TopPage page = new TopPage();
        public login()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Login__MouseDown);
            this.MouseMove += new MouseEventHandler(Login_MouseMove);
        }

        private void Login__MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void Close_Click(object sender, EventArgs e) => page.CloseClick();

        private void minimize_Click(object sender, EventArgs e) => page.MinimizeClick(this);

        private void Entrar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.name.Text))
            {
                MessageBox.Show("Você PRECISA colocar um email válido!");
                return;
            }
            
            if(String.IsNullOrEmpty(this.pass.Text))
            {
                MessageBox.Show("Você PRECISA colocar uma senha válida!");
                return;
            }

            AuthModel auth = new AuthModel();
            Boolean isValid = auth.ValidateUser(this.name.Text, this.pass.Text);
            if (isValid)
            {
                recepcao recep = new recepcao();
                recep.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha INCORRETOS");
            }
        }
    }
}
