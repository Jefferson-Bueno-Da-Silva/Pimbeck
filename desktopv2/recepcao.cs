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

        // Navegação

        private void FuncionariosBtn_Click(object sender, EventArgs e) => new Funcionarios().Show();

        private void ReservasBtn_Click(object sender, EventArgs e) => new Reservas().Show();

        private void AlmoxarifadoBtn_Click(object sender, EventArgs e) => new Almoxarifado().Show();

        private void ClientesBtn_Click(object sender, EventArgs e) => new Clientes().Show();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void recepcao_Load(object sender, EventArgs e)
        {
            get();
        }

        private void get()
        {
            string cmdSeleciona = String.Format("select * from clientes order by nome_cliente");
            DataTable values = new DB().GetAll(cmdSeleciona);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView1.DataSource = values;
        }
    }
}
