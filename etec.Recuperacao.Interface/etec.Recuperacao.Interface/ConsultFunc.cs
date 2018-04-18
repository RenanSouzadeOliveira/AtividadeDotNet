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
    public partial class ConsultFunc : Form
    {
        public ConsultFunc()
        {
            InitializeComponent();
        }

        private void ConsultFunc_Load(object sender, EventArgs e)
        {
            // Iniciando Conexao 
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=SistemaEstacionamento;Data Source=LAB-08-05;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQl = "select * from Funcionario";

            // adaptando os dados de SQL para c#

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQl, conexaoBanco);
            DataSet datasetCli = new DataSet();
            adaptador.Fill(datasetCli);

            dtFunc.DataSource = datasetCli;

             dtFunc.DataMember = datasetCli.Tables[0].TableName;


            conexaoBanco.Close();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            CadFunc telaCadastroCli = new CadFunc();
            telaCadastroCli.Show();
        }

        
        }
    }

