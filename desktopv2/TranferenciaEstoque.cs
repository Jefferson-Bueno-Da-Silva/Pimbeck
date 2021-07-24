using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class TranferenciaEstoque : Form
    {
        int X = 0;
        int Y = 0;
        public TranferenciaEstoque()
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

        private void TranferenciaEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                //salvar departamento
                this.comboBox.Items.Add("Estoque de antecipação");
                this.comboBox.Items.Add("estoque minimo");
                this.comboBox.Items.Add("estoque cozinha");
                this.comboBox.Items.Add("estoque quarto");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            var tipo = 0;

            if (comboBox.SelectedItem.ToString() == "Estoque de antecipação") tipo = 1;
            if (comboBox.SelectedItem.ToString() == "estoque minimo") tipo = 2;
            if (comboBox.SelectedItem.ToString() == "estoque cozinha") tipo = 3;
            if (comboBox.SelectedItem.ToString() == "estoque quarto") tipo = 4;

            string cmdInserir = String.Format(
                "UPDATE estoque SET id_tipo_estoque = {0} WHERE id_item_estoque = {1}",
                tipo,
                Int32.Parse(codigoTextBox.Text)
            );

            new DB().InserirRegistros(cmdInserir);

            MessageBox.Show(
                "Operação realizaca com sucesso!",
                "Sucesso!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
