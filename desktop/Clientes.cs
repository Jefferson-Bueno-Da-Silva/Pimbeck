using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepcao
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void moveToBack_Click(object sender, EventArgs e)
        {
            Recepcao Recepcao = new Recepcao();
            Recepcao.Show();
            this.Close();
        }
    }
}
