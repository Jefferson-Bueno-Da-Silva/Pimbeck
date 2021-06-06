using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class Financeiro : Form
    {
        
        public Financeiro()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(panel17_MouseDown);
            this.MouseMove += new MouseEventHandler(panel17_MouseMove);
        }

        int X = 0;
        int Y = 0;

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

        private void ContasReceber_Click(object sender, EventArgs e) => new ContasReceber().Show();

        private void button1_Click(object sender, EventArgs e) => new ContasPagar().Show();

        private void button2_Click(object sender, EventArgs e) => new Boleto().Show();

        private void button5_Click(object sender, EventArgs e) => new DRE().Show();

        private void button4_Click(object sender, EventArgs e) => new FluxoCaixa().Show();

        private void button3_Click(object sender, EventArgs e) => new IntegraçãoBancaria().Show();
    }
}
