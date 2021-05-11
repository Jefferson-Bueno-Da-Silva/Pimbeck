using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimbeck
{
    public partial class Login : Form
    {
        bool mouseDown;
        private Point offset;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(name.Text == "")
            {
                name.Text = "Email";
            }
            name.ForeColor = Color.DarkGray;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Email")
            {
                name.Text = null;
            }
            name.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Senha";
                this.pass.UseSystemPasswordChar = false;
            }
            pass.ForeColor = Color.DarkGray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Senha")
            {
                pass.Text = null;
                this.pass.UseSystemPasswordChar = true;
            }
            pass.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
