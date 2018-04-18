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
    public partial class CadCar : Form
    {
        public CadCar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO

            if ( txbCpf.Text == "" || txbPlaca.Text == "" || txbChaci.Text == "" || txbAno.Text == "" || txbModelo.Text == "" || txbMarca.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Sistema de Estacionamento");
            }
            else
            {
                // Salvar informações no banco

                // iniciando a conexao
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=SistemaEstacionamento;Data Source=LAB-08-05;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQl = "INSERT INTO Carros VALUES ('" + txbCpf.Text + "','" + txbPlaca.Text + "','" + txbChaci.Text + "','" + txbAno.Text + "','" + txbModelo.Text + "','" + txbMarca.Text + "')";
                //('" + txtNome.Text + "', '" + txtCargo.Text + "', '" + txtSalario.Text + "', '" + txtRg.Text + "', '" + txtCPF.Text + "', '" + txtTelefone.Text + "', '" + txtData.Text + "')";

                SqlCommand execucaoSQl = new SqlCommand(comandoSQl, conexaoBanco);
                execucaoSQl.ExecuteNonQuery();

                conexaoBanco.Close();

                // fechando a conexao

                MessageBox.Show("Cadastro realizado", "Empresa de Celulares");
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txbCpf.Text = "";
            txbPlaca.Text = "";
            txbChaci.Text = "";
            txbAno.Text = "";
            txbModelo.Text = "";
            txbMarca.Text = "";

        }

        private void btnLimparCli_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // iniciando a conexao
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=SistemaEstacionamento;Data Source=LAB-08-05;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();


            //instrução sql responsável por alterar um registro do banco (CRUD - Update) 
            string comandoSQl = "update Carros set chaciCarro= '" + txbChaci.Text +
            "', placaCarro= '" + txbPlaca.Text +
            "', anoCarro= '" + txbAno.Text +
            "', modeloCarro= '" + txbModelo.Text +
            "', marcaCarro= '" + txbMarca.Text +
            "' where cpfCliente= " + txbCpf.Text;

            SqlCommand execucaoSQl = new SqlCommand(comandoSQl, conexaoBanco);
            execucaoSQl.ExecuteNonQuery();
            conexaoBanco.Close();


            // fechando a conexao

            MessageBox.Show("Alteração realizada", "Empresa de Celulares");
            LimparCampos();
           
        }
        }
    }
