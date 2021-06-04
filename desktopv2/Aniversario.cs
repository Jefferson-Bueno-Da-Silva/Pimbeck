using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class Aniversario : Form
    {
        int X = 0;
        int Y = 0;
        int atv = 0;
        public Aniversario()
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

        private void moveToBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (atv != 0) 
            {
                this.button4.Text = "Desativar";
                this.richTextBox1.Enabled = false;
                atv = 0;
            }
            else
            {
                this.button4.Text = "Ativar";
                this.richTextBox1.Enabled = true;
                atv = 1;
            }
            
        }
    }
}
