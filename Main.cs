using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ritrama2025.Forms;

namespace Ritrama2025
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bot_despacho_Click(object sender, EventArgs e)
        {
            FrmDespacho frmdespacho = new FrmDespacho();
            frmdespacho.Show();
        }
    }
}
