using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Projeto_Final
{
    public partial class Tela_Principal : Form
    {

        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Tela_Principal()
        {
            InitializeComponent();

            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.FileName = "openFileDialog1";

            this.openFileDialog1.Filter = "PNG|*.png|BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg";
            this.openFileDialog1.Title = "Escolha uma foto (formato .PNG, .BMP, .GIF, .JPG, .JPEG):";
        }

        public Tela_Principal(string user, string pass)
        {
            InitializeComponent();

            try
            {
                objCnx.ConnectionString = "Server=localhost;Database=proj_final_csharp;User=root;Pwd=root";
                objCnx.Close();
                objCnx.Open();

                string query = "SELECT * FROM usuario WHERE login = '" + user + "' AND senha = '" + pass + "' AND nivel_acesso = 1";

                objCmd.CommandText = query;
                objCmd.Connection = objCnx;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    tabAdm.TabPages.Remove(tabProdutos);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message);
            }

            objCnx.Close();
        }

        /* ===== SEM IMPORTÂNCIA ===== */

        private void tabVendas_Click(object sender, EventArgs e)
        {

        }

        private void tabProdutos_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        /* ===== INÍCIO DO PROGRAMA ===== */

        /* ============= PARTE DE CLIENTES ============== */
        public void MontaGrid()
        {
            grdClientes.Rows.Clear();
            objCnx.Close();
            objCnx.Open();

            string query = "SELECT * FROM cliente ORDER BY id";

            objCmd.CommandText = query;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (!objDados.HasRows)
            {
                MessageBox.Show("Não há dados para exibir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                while (objDados.Read())
                {
                    grdClientes.Rows.Add(objDados["id"].ToString(),
                                         objDados["nome"].ToString(),
                                         objDados["sexo"].ToString(),
                                         objDados["telefone"].ToString(),
                                         objDados["cpf"].ToString(),
                                         objDados["email"].ToString());
                }
            }
            objCnx.Close();
        }

        public void preencheCampos(string codigo)
        {
            string query = "SELECT * FROM cliente WHERE id = " + Convert.ToInt32(codigo);

            objCnx.Close();
            objCnx.Open();

            objCmd.CommandText = query;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (!objDados.HasRows)
            {
                MessageBox.Show("Não há dados para exibir!");
            }
            else
            {
                while (objDados.Read())
                {
                    txtCodCli.Enabled = false;
                    txtCodCli.Text = codigo;

                    string nome = objDados["nome"].ToString();
                    string email = objDados["email"].ToString();
                    string telefone = objDados["telefone"].ToString();
                    string sexo = objDados["sexo"].ToString();
                    string cpf = objDados["cpf"].ToString();

                    txtNomeCli.Text = nome;
                    txtEmailCli.Text = email;
                    txtTelCli.Text = telefone;
                    txtCpfCli.Text = cpf;
                    cbxSexoCli.SelectedIndex = (sexo == "Masculino") ? 1 : 2;
                }
                
                Util objFoto = new Util();

                if (objDados["foto"].ToString() != "")
                {
                    byte[] imgByte = (byte[])objDados["foto"];
                    try
                    {
                        imgCliente.Image = objFoto.RecuperaImagem(imgByte);
                    }
                    catch
                    {
                        MessageBox.Show("Imagem com problema na abertura", "Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            objDados.Close();
            objCnx.Close();
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=localhost;Database=proj_final_csharp;User=root;Pwd=root";
                objCnx.Open();

                MontaGrid();
                MontaGridProdutos();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message);
            }
        }

        public void LimparCampos()
        {
            txtNomeCli.Text = "";
            txtEmailCli.Text = "";
            txtTelCli.Text = "";
            txtCpfCli.Text = "";
            cbxSexoCli.SelectedIndex = 0;
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCli.Text;
            string email = txtEmailCli.Text;
            string cpf = txtCpfCli.Text;
            string tel = txtTelCli.Text;
            string sexo = (cbxSexoCli.SelectedIndex == 1) ? "Masculino" : "Feminino";

            string query = "INSERT INTO cliente (nome, telefone, email, sexo, cpf) VALUES ('" + nome + "', '" + tel + "', '" + email + "', '" + sexo + "', '" + cpf + "')";

            try
            {
                objCmd.Connection = objCnx;
                objCmd.CommandText = query;
                objCnx.Close();
                objCnx.Open();
                objDados = objCmd.ExecuteReader();

                if (objDados.RecordsAffected > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MontaGrid();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao realizar o cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                objCnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        private void btnAddFotoCli_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgCliente.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnSalvarFotoCli_Click(object sender, EventArgs e)
        {
            Util classUtil = new Util();
            objCnx.Close();
            objCnx.Open();

            string query = "UPDATE cliente SET foto = @foto WHERE id = '" + Convert.ToInt32(txtCodCli.Text) + "'";

            objCmd.CommandText = query;
            objCmd.Parameters.Clear();
            objCmd.Parameters.AddWithValue("@foto", classUtil.PreparaFoto(imgCliente.Image));

            objDados = objCmd.ExecuteReader();
            if (objDados.RecordsAffected > 0)
            {
                MessageBox.Show("Imagem incluída com sucesso!");
            }
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = grdClientes.CurrentRow.Cells[0].Value.ToString();
            preencheCampos(codigo);
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM cliente WHERE id = " + Convert.ToInt32(txtCodCli.Text);

            objCnx.Close();
            objCnx.Open();

            objCmd.CommandText = query;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (objDados.RecordsAffected > 0)
            {
                MessageBox.Show("Cliente excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MontaGrid();
            }
            else
            {
                MessageBox.Show("Erro na exclusão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCli.Text;
            string telefone = txtTelCli.Text;
            string email = txtEmailCli.Text;
            string cpf = txtCpfCli.Text;
            string sexo = (cbxSexoCli.SelectedIndex == 1) ? "Masculino" : "Feminino";
            int id = Convert.ToInt32(txtCodCli.Text);

            string query = "UPDATE cliente SET nome = '" + nome + "', telefone = '" + telefone + "', sexo = '" + sexo + "', email = '" + email + "', cpf = '" + cpf + "' WHERE id = " + id;

            objCnx.Close();
            objCnx.Open();

            objCmd.CommandText = query;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (objDados.RecordsAffected > 0)
            {
                MessageBox.Show("Cliente editado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MontaGrid();
            }
            else
            {
                MessageBox.Show("Falha na alteração dos dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* ============================================== */
        /* ============================================== */
        /* ============================================== */
        /* ============================================== */
        /* ============================================== */
        /* ============= PARTE DE PRODUTOS ============== */

        public void MontaGridProdutos()
        {
            grdProdutos.Rows.Clear();
            objCnx.Close();
            objCnx.Open();

            string query = "SELECT * FROM produto ORDER BY id";

            objCmd.CommandText = query;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (!objDados.HasRows)
            {
                MessageBox.Show("Não há dados para exibir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                while (objDados.Read())
                {
                    grdProdutos.Rows.Add(objDados["id"].ToString(),
                                         objDados["descricao"].ToString(),
                                         objDados["preco"].ToString(),
                                         objDados["estoque_atual"].ToString());
                }
            }
            objCnx.Close();
        }

        public void PreencheCamposProduto(string codigo)
        {
            string query = "SELECT * FROM produto WHERE id = " + Convert.ToInt32(codigo);

            objCnx.Close();
            objCnx.Open();

            objCmd.CommandText = query;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (!objDados.HasRows)
            {
                MessageBox.Show("Não há dados para exibir!");
            }
            else
            {
                while (objDados.Read())
                {
                    txtCodPro.Enabled = false;
                    txtCodPro.Text = codigo;

                    string descricao = objDados["descricao"].ToString();
                    string preco = objDados["preco"].ToString();
                    string estoque_atual = objDados["estoque_atual"].ToString();

                    txtDescPro.Text = descricao;
                    txtPrecoPro.Text = preco;
                    txtEstPro.Text = estoque_atual;
                }

                Util objFoto = new Util();

                if (objDados["imagem"].ToString() != "")
                {
                    byte[] imgByte = (byte[])objDados["imagem"];
                    try
                    {
                        imgProduto.Image = objFoto.RecuperaImagem(imgByte);
                    }
                    catch
                    {
                        MessageBox.Show("Imagem com problema na abertura", "Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            objDados.Close();
            objCnx.Close();
        }

        public void LimparCamposProduto()
        {
            txtDescPro.Text = "";
            txtPrecoPro.Text = "";
            txtEstPro.Text = "";
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            string descricao = txtDescPro.Text;
            string preco = txtPrecoPro.Text;
            string estoque_atual = txtEstPro.Text;

            string query = "INSERT INTO produto (descricao, preco, estoque_atual) VALUES ('" + descricao + "', '" + preco + "', '" + estoque_atual + "')";

            try
            {
                objCmd.Connection = objCnx;
                objCmd.CommandText = query;
                objCnx.Close();
                objCnx.Open();
                objDados = objCmd.ExecuteReader();

                if (objDados.RecordsAffected > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MontaGridProdutos();
                    LimparCamposProduto();
                }
                else
                {
                    MessageBox.Show("Falha ao realizar o cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                objCnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        private void btnAddFotoPro_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgProduto.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnSalvarFotoPro_Click(object sender, EventArgs e)
        {
            Util classUtil = new Util();
            objCnx.Close();
            objCnx.Open();

            string query = "UPDATE produto SET imagem = @foto WHERE id = '" + Convert.ToInt32(txtCodPro.Text) + "'";

            objCmd.CommandText = query;
            objCmd.Parameters.AddWithValue("@foto", classUtil.PreparaFoto(imgProduto.Image));

            objDados = objCmd.ExecuteReader();
            if (objDados.RecordsAffected > 0)
            {
                MessageBox.Show("Imagem incluída com sucesso!");
            }
        }

        private void grdProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = grdProdutos.CurrentRow.Cells[0].Value.ToString();
            PreencheCamposProduto(codigo);
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM produto WHERE id = " + Convert.ToInt32(txtCodPro.Text);

            objCnx.Close();
            objCnx.Open();

            objCmd.CommandText = query;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (objDados.RecordsAffected > 0)
            {
                MessageBox.Show("Produto excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MontaGridProdutos();
            }
            else
            {
                MessageBox.Show("Erro na exclusão", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            string descricao = txtDescPro.Text;
            string preco = txtPrecoPro.Text;
            string estoque_atual = txtEstPro.Text;

            string query = "UPDATE produto SET descricao = '" + descricao + "', preco = '" + preco + "', estoque_atual = '" + estoque_atual + "'";

            objCnx.Close();
            objCnx.Open();

            objCmd.CommandText = query;
            objCmd.Connection = objCnx;
            objDados = objCmd.ExecuteReader();

            if (objDados.RecordsAffected > 0)
            {
                MessageBox.Show("Produto editado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MontaGridProdutos();
            }
            else
            {
                MessageBox.Show("Falha na alteração dos dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
