using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    public partial class Almoxarifado : Form
    {
        int X = 0;
        int Y = 0;
        public Almoxarifado()
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

        private void button3_Click(object sender, EventArgs e) => new TranferenciaEstoque().Show();

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new OpenFileDialog();
            this.openFileDialog1.InitialDirectory = "Documentos";
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1 = new SaveFileDialog();
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.FileName = "Inventario";
            this.saveFileDialog1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new OpenFileDialog();
            this.openFileDialog1.InitialDirectory = "Documentos";
            openFileDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) => new EstoqueMinimo().Show();

        private void Almoxarifado_Load(object sender, EventArgs e)
        {
            get();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            get();
        }

        private void get()
        {
            string cmdSeleciona = String.Format("select * from estoque");
            DataTable values = new DB().GetAll(cmdSeleciona);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView1.DataSource = values;
        }
    }
}
