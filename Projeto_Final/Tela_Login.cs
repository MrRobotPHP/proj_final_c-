using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Final
{
    public partial class Tela_Login : Form
    {

        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;

        public Tela_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string senha = txtSenha.Text;
            string query = "SELECT * FROM usuario WHERE login = '" + user + "' and senha = '" + senha + "'";

            objCnx.Close();
            objCnx.Open();

            objCmd.Connection = objCnx;
            objCmd.CommandText = query;

            objDados = objCmd.ExecuteReader();
            
            if (!objDados.HasRows)
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
            else
            {
                Tela_Principal abrirTelaPrinc = new Tela_Principal(user, senha);

                this.Hide();
                abrirTelaPrinc.ShowDialog();
                this.Close();
                this.Dispose();
            }
        }

        private void Tela_Login_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=localhost;Database=proj_final_csharp;User=root;Pwd=root";
                objCnx.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message);
            }
        }
    }
}
