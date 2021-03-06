﻿using System;
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
    public partial class CadFunc : Form
    {
        public CadFunc()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO

            if ( txbNome.Text == "" || txbCPF.Text == "" || txbRg.Text == "" || txbCelular.Text == "" || txbCargo.Text == "" || txbSalario.Text == "")
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

                string comandoSQl = "INSERT INTO Funcionario VALUES ('" + txbNome.Text + "','" + txbCPF.Text + "','" + txbRg.Text + "','" + txbCelular.Text + "','" + txbCargo.Text + "','" + txbEndereco.Text + "','" + txbSalario.Text + "')";
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
            txbNome.Text = "";
            txbCPF.Text = "";
            txbRg.Text = "";
            txbCelular.Text = "";
            txbCargo.Text = "";
            txbSalario.Text = "";
            txbEndereco.Text = "";

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
            string comandoSQl = "update Funcionario set nomeFunc= '" + txbNome.Text +
            "', rgFunc= '" + txbRg.Text +
            "', celFunc= '" + txbCelular.Text +
            "', enderecoFunc= '" + txbEndereco.Text +
            "', cargoFunc= '" + txbCargo.Text +
            "', salariofunc= '" + txbSalario.Text +
            "' where cpfFunc= " + txbCPF.Text;

            SqlCommand execucaoSQl = new SqlCommand(comandoSQl, conexaoBanco);
            execucaoSQl.ExecuteNonQuery();
            conexaoBanco.Close();
           

            // fechando a conexao

            MessageBox.Show("Alteração realizada", "Empresa de Celulares");
            LimparCampos();
           
        }
        }
    }

