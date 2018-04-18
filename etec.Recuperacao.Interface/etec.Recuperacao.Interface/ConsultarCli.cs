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
    public partial class ConsultarCli : Form
    {
        public ConsultarCli()
        {
            InitializeComponent();
        }

        private void ConsultarCli_Load(object sender, EventArgs e)
        {
            // Iniciando Conexao 
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=SistemaEstacionamento;Data Source=LAB-08-05;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQl = "select c.idCliente as IdCliente,c.nomeCliente as nomeCliente,c.cpfCliente as cpfClientetbCliente,v.cpfCliente as cpfClientetbCarro,v.idCarro as idCarro,v.chaciCarro as chaciCarro,v.placaCarro as placaCarro,v.anoCarro as anoCarro,v.modeloCarro as modeloCarro,v.marcaCarro as marcaCarro from Clientes c left join Carros v on c.cpfCliente = v.cpfCliente";

            // adaptando os dados de SQL para c#

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQl, conexaoBanco);
            DataSet datasetCli = new DataSet();
            adaptador.Fill(datasetCli);

            dtCli.DataSource = datasetCli;

            dtCli.DataMember = datasetCli.Tables[0].TableName;


            conexaoBanco.Close();
        }

        private void dtCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            CadCli telaCadastroCli = new CadCli();
            telaCadastroCli.Show();

        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            CadCar telaCadastroCli = new CadCar();
            telaCadastroCli.Show();
        }

    }
}
