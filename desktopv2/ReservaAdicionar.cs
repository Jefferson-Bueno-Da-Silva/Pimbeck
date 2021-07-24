using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class ReservaAdicionar : Form
    {
        int X = 0;
        int Y = 0;
        public ReservaAdicionar()
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

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();

            string cmdInserir = String.Format(
                "Insert Into reservas(id_reserva, data_entrada, data_saida, id_quarto, id_cliente, id_funcionario) "+
                "values({0}, '{1}', '{2}', {3}, {4}, {5})",
                randNum.Next(),
                dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                Int32.Parse(this.quartoTextBox.Text),
                Int32.Parse(this.clienteTextBox.Text),
                Int32.Parse(this.funcionarioTextBox.Text)
            );

            new DB().InserirRegistros(cmdInserir);

            MessageBox.Show(
                 "Operação realizaca com sucesso!",
                 "Sucesso!",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
             );
            this.Close();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
