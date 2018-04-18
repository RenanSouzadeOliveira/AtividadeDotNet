using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace etec.Recuperacao.Interface
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void lblCadCli_Click(object sender, EventArgs e)
        {
            CadCli cad = new CadCli();

            cad.MdiParent = this;

            cad.Show();
        }

        private void lblCadFunc_Click(object sender, EventArgs e)
        {
            CadFunc cad = new CadFunc();

            cad.MdiParent = this;

            cad.Show();
        }

        private void lblCadCar_Click(object sender, EventArgs e)
        {
            CadCar cad = new CadCar();

            cad.MdiParent = this;

            cad.Show();
        }

        private void lblConsu_Click(object sender, EventArgs e)
        {
            ConsultarCli cad = new ConsultarCli();

            cad.MdiParent = this;

            cad.Show();
        }

        private void ConsultarFunc_Click(object sender, EventArgs e)
        {
            ConsultFunc cad = new ConsultFunc();

            cad.MdiParent = this;

            cad.Show();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
