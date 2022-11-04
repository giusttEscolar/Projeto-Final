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
    public partial class FormY : Form
    {
        public FormY()
        {
            InitializeComponent();
        }

        private void FormY_Load(object sender, EventArgs e)
        {
            btn_excluir.Enabled = false;    
            btn_alterar.Enabled = false;
        }
    }
}
