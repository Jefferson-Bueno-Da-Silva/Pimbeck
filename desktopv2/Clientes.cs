using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class Clientes : Form
    {
        int X = 0;
        int Y = 0;
        public Clientes()
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

        private void get()
        {
            string cmdSeleciona = String.Format("select * from clientes order by nome_cliente");
            DataTable values = new DB().GetAll(cmdSeleciona);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView1.DataSource = values;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            get();
        }

        private void AddEmployee_Click(object sender, EventArgs e) => new ClientesAdicionar().Show();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            get();
        }
    }
}
