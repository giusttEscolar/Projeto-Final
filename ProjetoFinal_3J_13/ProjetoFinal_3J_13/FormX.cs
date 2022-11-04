using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_3J_13
{
    public partial class FormX : Form
    {
        public FormX()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormX_Load(object sender, EventArgs e)
        {
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
        }
    }
}
