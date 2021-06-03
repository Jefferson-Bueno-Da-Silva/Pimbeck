using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace desktopv2
{
    class TopPage : Form
    {
        public void CloseClick() => Application.Exit();
        public void MinimizeClick(Form from) => from.WindowState = FormWindowState.Minimized;
    }
}
