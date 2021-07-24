using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class Form1 : Form
    {
        int X = 0;
        int Y = 0;
        public Form1()
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

        private void moveToBack_Click(object sender, EventArgs e) => this.Close();

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            int user;
            if (this.isUser.Enabled)
            {
                user = 1;
            }
            else
            {
                user = 0;
            }


            Random randNum = new Random();


            new DB().InserirRegistros(
                "funcionarios",
                "id_funcionario, nome_funcionario, sobrenome_funcionario, cpf_funcionario, rg_funcionario, system_user",
                randNum.Next(),
                this.NomeTextBox.Text,
                this.SobrenomeTextBox.Text,
                this.CPFTextBox.Text,
                this.RGTextBox.Text,
                user
            );

            MessageBox.Show(
                "Operação realizaca com sucesso!",
                "Sucesso!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            this.Close();
        }
    }
}
