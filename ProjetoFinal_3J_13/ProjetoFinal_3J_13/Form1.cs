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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            FormX X = new FormX();
            X.Show();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            FormY Y = new FormY();
            Y.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Deseja Finalizar o Sistema?");
            MessageBox.Show("Sistema Produzido por Giustt", "Sistema Finalizado");

            Application.Exit();
        }
    }
}
 