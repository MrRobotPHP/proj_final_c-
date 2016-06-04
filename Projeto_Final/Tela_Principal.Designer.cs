namespace Projeto_Final
{
    partial class Tela_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAdm = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.txtCpfCli = new System.Windows.Forms.MaskedTextBox();
            this.txtTelCli = new System.Windows.Forms.MaskedTextBox();
            this.cbxSexoCli = new System.Windows.Forms.ComboBox();
            this.btnSalvarFotoCli = new System.Windows.Forms.Button();
            this.btnAddFotoCli = new System.Windows.Forms.Button();
            this.imgCliente = new System.Windows.Forms.PictureBox();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarCli = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.colCodCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomeCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPFCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.btnSalvarFotoPro = new System.Windows.Forms.Button();
            this.btnAddFotoPro = new System.Windows.Forms.Button();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.txtPrecoPro = new System.Windows.Forms.TextBox();
            this.txtDescPro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstPro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodPro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnVoltarProd = new System.Windows.Forms.Button();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.colCodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricaoPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.tabVendas = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnVoltarVen = new System.Windows.Forms.Button();
            this.grdVendas = new System.Windows.Forms.DataGridView();
            this.colCodVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtdeProdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            this.btnEditarVenda = new System.Windows.Forms.Button();
            this.btnCadVenda = new System.Windows.Forms.Button();
            this.tabAdm.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.tabProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.tabVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdm
            // 
            this.tabAdm.Controls.Add(this.tabClientes);
            this.tabAdm.Controls.Add(this.tabProdutos);
            this.tabAdm.Controls.Add(this.tabVendas);
            this.tabAdm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdm.Location = new System.Drawing.Point(12, 100);
            this.tabAdm.Name = "tabAdm";
            this.tabAdm.SelectedIndex = 0;
            this.tabAdm.Size = new System.Drawing.Size(959, 409);
            this.tabAdm.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.txtCpfCli);
            this.tabClientes.Controls.Add(this.txtTelCli);
            this.tabClientes.Controls.Add(this.cbxSexoCli);
            this.tabClientes.Controls.Add(this.btnSalvarFotoCli);
            this.tabClientes.Controls.Add(this.btnAddFotoCli);
            this.tabClientes.Controls.Add(this.imgCliente);
            this.tabClientes.Controls.Add(this.txtEmailCli);
            this.tabClientes.Controls.Add(this.txtNomeCli);
            this.tabClientes.Controls.Add(this.label6);
            this.tabClientes.Controls.Add(this.label5);
            this.tabClientes.Controls.Add(this.label4);
            this.tabClientes.Controls.Add(this.label3);
            this.tabClientes.Controls.Add(this.label2);
            this.tabClientes.Controls.Add(this.txtCodCli);
            this.tabClientes.Controls.Add(this.label1);
            this.tabClientes.Controls.Add(this.btnVoltarCli);
            this.tabClientes.Controls.Add(this.btnCadCliente);
            this.tabClientes.Controls.Add(this.btnExcluirCliente);
            this.tabClientes.Controls.Add(this.btnEditarCliente);
            this.tabClientes.Controls.Add(this.grdClientes);
            this.tabClientes.Location = new System.Drawing.Point(4, 26);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(951, 379);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // txtCpfCli
            // 
            this.txtCpfCli.Location = new System.Drawing.Point(733, 271);
            this.txtCpfCli.Mask = "###,###,###-##";
            this.txtCpfCli.Name = "txtCpfCli";
            this.txtCpfCli.Size = new System.Drawing.Size(108, 25);
            this.txtCpfCli.TabIndex = 8;
            // 
            // txtTelCli
            // 
            this.txtTelCli.Location = new System.Drawing.Point(734, 208);
            this.txtTelCli.Mask = "(##) ####-####";
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(107, 25);
            this.txtTelCli.TabIndex = 7;
            // 
            // cbxSexoCli
            // 
            this.cbxSexoCli.FormattingEnabled = true;
            this.cbxSexoCli.Items.AddRange(new object[] {
            "Escolha",
            "Masculino",
            "Feminino"});
            this.cbxSexoCli.Location = new System.Drawing.Point(733, 239);
            this.cbxSexoCli.Name = "cbxSexoCli";
            this.cbxSexoCli.Size = new System.Drawing.Size(86, 25);
            this.cbxSexoCli.TabIndex = 6;
            // 
            // btnSalvarFotoCli
            // 
            this.btnSalvarFotoCli.Location = new System.Drawing.Point(770, 69);
            this.btnSalvarFotoCli.Name = "btnSalvarFotoCli";
            this.btnSalvarFotoCli.Size = new System.Drawing.Size(139, 37);
            this.btnSalvarFotoCli.TabIndex = 5;
            this.btnSalvarFotoCli.Text = "Salvar foto";
            this.btnSalvarFotoCli.UseVisualStyleBackColor = true;
            this.btnSalvarFotoCli.Click += new System.EventHandler(this.btnSalvarFotoCli_Click);
            // 
            // btnAddFotoCli
            // 
            this.btnAddFotoCli.Location = new System.Drawing.Point(770, 6);
            this.btnAddFotoCli.Name = "btnAddFotoCli";
            this.btnAddFotoCli.Size = new System.Drawing.Size(139, 37);
            this.btnAddFotoCli.TabIndex = 5;
            this.btnAddFotoCli.Text = "Adicionar foto...";
            this.btnAddFotoCli.UseVisualStyleBackColor = true;
            this.btnAddFotoCli.Click += new System.EventHandler(this.btnAddFotoCli_Click);
            // 
            // imgCliente
            // 
            this.imgCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgCliente.Location = new System.Drawing.Point(656, 6);
            this.imgCliente.Name = "imgCliente";
            this.imgCliente.Size = new System.Drawing.Size(108, 100);
            this.imgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCliente.TabIndex = 4;
            this.imgCliente.TabStop = false;
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Location = new System.Drawing.Point(733, 145);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(212, 25);
            this.txtEmailCli.TabIndex = 3;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(733, 114);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(212, 25);
            this.txtNomeCli.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Enabled = false;
            this.txtCodCli.Location = new System.Drawing.Point(733, 177);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(42, 25);
            this.txtCodCli.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // btnVoltarCli
            // 
            this.btnVoltarCli.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_voltar2;
            this.btnVoltarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarCli.Location = new System.Drawing.Point(865, 298);
            this.btnVoltarCli.Name = "btnVoltarCli";
            this.btnVoltarCli.Size = new System.Drawing.Size(80, 74);
            this.btnVoltarCli.TabIndex = 1;
            this.btnVoltarCli.UseVisualStyleBackColor = true;
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_add_cliente;
            this.btnCadCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadCliente.Location = new System.Drawing.Point(6, 298);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(80, 74);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_exc_cliente;
            this.btnExcluirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirCliente.Location = new System.Drawing.Point(178, 298);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(80, 74);
            this.btnExcluirCliente.TabIndex = 1;
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_editar_cliente;
            this.btnEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarCliente.Location = new System.Drawing.Point(92, 298);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(80, 74);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // grdClientes
            // 
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodCli,
            this.ColNomeCli,
            this.colTelCli,
            this.colSexo,
            this.colEmailCli,
            this.colCPFCli});
            this.grdClientes.Location = new System.Drawing.Point(6, 6);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(644, 286);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellClick);
            // 
            // colCodCli
            // 
            this.colCodCli.HeaderText = "Código";
            this.colCodCli.Name = "colCodCli";
            // 
            // ColNomeCli
            // 
            this.ColNomeCli.HeaderText = "Nome";
            this.ColNomeCli.Name = "ColNomeCli";
            // 
            // colTelCli
            // 
            this.colTelCli.HeaderText = "Sexo";
            this.colTelCli.Name = "colTelCli";
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Telefone";
            this.colSexo.Name = "colSexo";
            // 
            // colEmailCli
            // 
            this.colEmailCli.HeaderText = "CPF";
            this.colEmailCli.Name = "colEmailCli";
            // 
            // colCPFCli
            // 
            this.colCPFCli.HeaderText = "Email";
            this.colCPFCli.Name = "colCPFCli";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.btnSalvarFotoPro);
            this.tabProdutos.Controls.Add(this.btnAddFotoPro);
            this.tabProdutos.Controls.Add(this.imgProduto);
            this.tabProdutos.Controls.Add(this.txtPrecoPro);
            this.tabProdutos.Controls.Add(this.txtDescPro);
            this.tabProdutos.Controls.Add(this.label7);
            this.tabProdutos.Controls.Add(this.label8);
            this.tabProdutos.Controls.Add(this.txtEstPro);
            this.tabProdutos.Controls.Add(this.label10);
            this.tabProdutos.Controls.Add(this.txtCodPro);
            this.tabProdutos.Controls.Add(this.label12);
            this.tabProdutos.Controls.Add(this.btnVoltarProd);
            this.tabProdutos.Controls.Add(this.grdProdutos);
            this.tabProdutos.Controls.Add(this.btnExcluirProduto);
            this.tabProdutos.Controls.Add(this.btnEditarProduto);
            this.tabProdutos.Controls.Add(this.btnCadProduto);
            this.tabProdutos.Location = new System.Drawing.Point(4, 26);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutos.Size = new System.Drawing.Size(951, 379);
            this.tabProdutos.TabIndex = 1;
            this.tabProdutos.Text = "Produtos";
            this.tabProdutos.UseVisualStyleBackColor = true;
            this.tabProdutos.Click += new System.EventHandler(this.tabProdutos_Click);
            // 
            // btnSalvarFotoPro
            // 
            this.btnSalvarFotoPro.Location = new System.Drawing.Point(456, 155);
            this.btnSalvarFotoPro.Name = "btnSalvarFotoPro";
            this.btnSalvarFotoPro.Size = new System.Drawing.Size(139, 37);
            this.btnSalvarFotoPro.TabIndex = 20;
            this.btnSalvarFotoPro.Text = "Salvar foto";
            this.btnSalvarFotoPro.UseVisualStyleBackColor = true;
            this.btnSalvarFotoPro.Click += new System.EventHandler(this.btnSalvarFotoPro_Click);
            // 
            // btnAddFotoPro
            // 
            this.btnAddFotoPro.Location = new System.Drawing.Point(456, 112);
            this.btnAddFotoPro.Name = "btnAddFotoPro";
            this.btnAddFotoPro.Size = new System.Drawing.Size(139, 37);
            this.btnAddFotoPro.TabIndex = 19;
            this.btnAddFotoPro.Text = "Adicionar foto...";
            this.btnAddFotoPro.UseVisualStyleBackColor = true;
            this.btnAddFotoPro.Click += new System.EventHandler(this.btnAddFotoPro_Click);
            // 
            // imgProduto
            // 
            this.imgProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgProduto.Location = new System.Drawing.Point(456, 6);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(108, 100);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduto.TabIndex = 18;
            this.imgProduto.TabStop = false;
            // 
            // txtPrecoPro
            // 
            this.txtPrecoPro.Location = new System.Drawing.Point(647, 68);
            this.txtPrecoPro.Name = "txtPrecoPro";
            this.txtPrecoPro.Size = new System.Drawing.Size(86, 25);
            this.txtPrecoPro.TabIndex = 12;
            // 
            // txtDescPro
            // 
            this.txtDescPro.Location = new System.Drawing.Point(647, 37);
            this.txtDescPro.Name = "txtDescPro";
            this.txtDescPro.Size = new System.Drawing.Size(298, 25);
            this.txtDescPro.TabIndex = 13;
            this.txtDescPro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Preço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(570, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descrição";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtEstPro
            // 
            this.txtEstPro.Location = new System.Drawing.Point(859, 68);
            this.txtEstPro.Name = "txtEstPro";
            this.txtEstPro.Size = new System.Drawing.Size(86, 25);
            this.txtEstPro.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(748, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estoque atual";
            // 
            // txtCodPro
            // 
            this.txtCodPro.Enabled = false;
            this.txtCodPro.Location = new System.Drawing.Point(647, 6);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(42, 25);
            this.txtCodPro.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(570, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Código";
            // 
            // btnVoltarProd
            // 
            this.btnVoltarProd.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_voltar2;
            this.btnVoltarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarProd.Location = new System.Drawing.Point(865, 298);
            this.btnVoltarProd.Name = "btnVoltarProd";
            this.btnVoltarProd.Size = new System.Drawing.Size(80, 74);
            this.btnVoltarProd.TabIndex = 2;
            this.btnVoltarProd.UseVisualStyleBackColor = true;
            // 
            // grdProdutos
            // 
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodPro,
            this.colDescricaoPro,
            this.colPrecoPro,
            this.colEstAtual});
            this.grdProdutos.Location = new System.Drawing.Point(6, 6);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.Size = new System.Drawing.Size(444, 286);
            this.grdProdutos.TabIndex = 1;
            this.grdProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellClick);
            // 
            // colCodPro
            // 
            this.colCodPro.HeaderText = "Código";
            this.colCodPro.Name = "colCodPro";
            // 
            // colDescricaoPro
            // 
            this.colDescricaoPro.HeaderText = "Descrição";
            this.colDescricaoPro.Name = "colDescricaoPro";
            // 
            // colPrecoPro
            // 
            this.colPrecoPro.HeaderText = "Preço";
            this.colPrecoPro.Name = "colPrecoPro";
            // 
            // colEstAtual
            // 
            this.colEstAtual.HeaderText = "Estoque Atual";
            this.colEstAtual.Name = "colEstAtual";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_exc_produto;
            this.btnExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirProduto.Location = new System.Drawing.Point(178, 298);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(80, 74);
            this.btnExcluirProduto.TabIndex = 5;
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_editar_produto;
            this.btnEditarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarProduto.Location = new System.Drawing.Point(92, 298);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(80, 74);
            this.btnEditarProduto.TabIndex = 5;
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_add_produto;
            this.btnCadProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadProduto.Location = new System.Drawing.Point(6, 298);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(80, 74);
            this.btnCadProduto.TabIndex = 5;
            this.btnCadProduto.UseVisualStyleBackColor = true;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // tabVendas
            // 
            this.tabVendas.Controls.Add(this.textBox3);
            this.tabVendas.Controls.Add(this.textBox5);
            this.tabVendas.Controls.Add(this.label9);
            this.tabVendas.Controls.Add(this.label11);
            this.tabVendas.Controls.Add(this.textBox9);
            this.tabVendas.Controls.Add(this.textBox10);
            this.tabVendas.Controls.Add(this.textBox7);
            this.tabVendas.Controls.Add(this.label16);
            this.tabVendas.Controls.Add(this.label15);
            this.tabVendas.Controls.Add(this.label13);
            this.tabVendas.Controls.Add(this.textBox8);
            this.tabVendas.Controls.Add(this.label14);
            this.tabVendas.Controls.Add(this.btnVoltarVen);
            this.tabVendas.Controls.Add(this.grdVendas);
            this.tabVendas.Controls.Add(this.btnExcluirVenda);
            this.tabVendas.Controls.Add(this.btnEditarVenda);
            this.tabVendas.Controls.Add(this.btnCadVenda);
            this.tabVendas.Location = new System.Drawing.Point(4, 26);
            this.tabVendas.Name = "tabVendas";
            this.tabVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendas.Size = new System.Drawing.Size(951, 379);
            this.tabVendas.TabIndex = 2;
            this.tabVendas.Text = "Vendas";
            this.tabVendas.UseVisualStyleBackColor = true;
            this.tabVendas.Click += new System.EventHandler(this.tabVendas_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(732, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 25);
            this.textBox3.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(732, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(213, 25);
            this.textBox5.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(655, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(655, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Produto";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(770, 130);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(144, 25);
            this.textBox9.TabIndex = 24;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(891, 173);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(54, 25);
            this.textBox10.TabIndex = 24;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(732, 99);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(54, 25);
            this.textBox7.TabIndex = 24;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label16.Location = new System.Drawing.Point(829, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 22);
            this.label16.TabIndex = 20;
            this.label16.Text = "Total";
            this.label16.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(655, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "Data da venda";
            this.label15.Click += new System.EventHandler(this.label13_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(655, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Qtde";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(732, 6);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(42, 25);
            this.textBox8.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(655, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "Código";
            // 
            // btnVoltarVen
            // 
            this.btnVoltarVen.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_voltar2;
            this.btnVoltarVen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarVen.Location = new System.Drawing.Point(865, 298);
            this.btnVoltarVen.Name = "btnVoltarVen";
            this.btnVoltarVen.Size = new System.Drawing.Size(80, 74);
            this.btnVoltarVen.TabIndex = 7;
            this.btnVoltarVen.UseVisualStyleBackColor = true;
            // 
            // grdVendas
            // 
            this.grdVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodVenda,
            this.colProdutoVenda,
            this.colClienteVenda,
            this.colQtdeProdVenda,
            this.colDataVenda,
            this.colTotalVenda});
            this.grdVendas.Location = new System.Drawing.Point(6, 6);
            this.grdVendas.Name = "grdVendas";
            this.grdVendas.Size = new System.Drawing.Size(643, 286);
            this.grdVendas.TabIndex = 6;
            // 
            // colCodVenda
            // 
            this.colCodVenda.HeaderText = "Código";
            this.colCodVenda.Name = "colCodVenda";
            // 
            // colProdutoVenda
            // 
            this.colProdutoVenda.HeaderText = "Produto";
            this.colProdutoVenda.Name = "colProdutoVenda";
            // 
            // colClienteVenda
            // 
            this.colClienteVenda.HeaderText = "Cliente";
            this.colClienteVenda.Name = "colClienteVenda";
            // 
            // colQtdeProdVenda
            // 
            this.colQtdeProdVenda.HeaderText = "Quantidade";
            this.colQtdeProdVenda.Name = "colQtdeProdVenda";
            // 
            // colDataVenda
            // 
            this.colDataVenda.HeaderText = "Data";
            this.colDataVenda.Name = "colDataVenda";
            // 
            // colTotalVenda
            // 
            this.colTotalVenda.HeaderText = "Total";
            this.colTotalVenda.Name = "colTotalVenda";
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_exc_venda;
            this.btnExcluirVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirVenda.Location = new System.Drawing.Point(178, 298);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(80, 74);
            this.btnExcluirVenda.TabIndex = 10;
            this.btnExcluirVenda.UseVisualStyleBackColor = true;
            // 
            // btnEditarVenda
            // 
            this.btnEditarVenda.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_editar_venda;
            this.btnEditarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarVenda.Location = new System.Drawing.Point(92, 298);
            this.btnEditarVenda.Name = "btnEditarVenda";
            this.btnEditarVenda.Size = new System.Drawing.Size(80, 74);
            this.btnEditarVenda.TabIndex = 10;
            this.btnEditarVenda.UseVisualStyleBackColor = true;
            // 
            // btnCadVenda
            // 
            this.btnCadVenda.BackgroundImage = global::Projeto_Final.Properties.Resources.icone_add_venda;
            this.btnCadVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadVenda.Location = new System.Drawing.Point(6, 298);
            this.btnCadVenda.Name = "btnCadVenda";
            this.btnCadVenda.Size = new System.Drawing.Size(80, 74);
            this.btnCadVenda.TabIndex = 10;
            this.btnCadVenda.UseVisualStyleBackColor = true;
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 521);
            this.Controls.Add(this.tabAdm);
            this.Name = "Tela_Principal";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.tabAdm.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.tabVendas.ResumeLayout(false);
            this.tabVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdm;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.TabPage tabVendas;
        private System.Windows.Forms.Button btnVoltarCli;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btnVoltarProd;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.Button btnVoltarVen;
        private System.Windows.Forms.Button btnCadVenda;
        private System.Windows.Forms.DataGridView grdVendas;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnExcluirVenda;
        private System.Windows.Forms.Button btnEditarVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricaoPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtdeProdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalVenda;
        private System.Windows.Forms.PictureBox imgCliente;
        private System.Windows.Forms.TextBox txtEmailCli;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.TextBox txtPrecoPro;
        private System.Windows.Forms.TextBox txtDescPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEstPro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodPro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddFotoCli;
        private System.Windows.Forms.Button btnAddFotoPro;
        private System.Windows.Forms.ComboBox cbxSexoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomeCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPFCli;
        private System.Windows.Forms.Button btnSalvarFotoCli;
        private System.Windows.Forms.Button btnSalvarFotoPro;
        private System.Windows.Forms.MaskedTextBox txtTelCli;
        private System.Windows.Forms.MaskedTextBox txtCpfCli;
    }
}