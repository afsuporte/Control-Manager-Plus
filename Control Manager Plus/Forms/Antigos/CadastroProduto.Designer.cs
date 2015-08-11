namespace Control_Manager_Plus.FRM
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.btnLimparInformacoes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbIncluir = new System.Windows.Forms.ToolStripButton();
            this.tbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.tbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tbVoltar = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.rdbCresc = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.MaskedTextBox();
            this.cbxPesquisar = new System.Windows.Forms.ComboBox();
            this.cbxOrdenar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxSelecionaFornecedor = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(64, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 42);
            this.btnSalvar.TabIndex = 109;
            this.btnSalvar.Text = " -  Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fornecedor Padrão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Preço Custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço de Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxSelecionaFornecedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboUnidadeMedida);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtPrecoCusto);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtPrecoVenda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 187);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Unidade";
            // 
            // cboUnidadeMedida
            // 
            this.cboUnidadeMedida.BackColor = System.Drawing.SystemColors.Window;
            this.cboUnidadeMedida.FormattingEnabled = true;
            this.cboUnidadeMedida.Items.AddRange(new object[] {
            "UN",
            "CX",
            "KG",
            "PC",
            "LT",
            "MT"});
            this.cboUnidadeMedida.Location = new System.Drawing.Point(318, 91);
            this.cboUnidadeMedida.Name = "cboUnidadeMedida";
            this.cboUnidadeMedida.Size = new System.Drawing.Size(79, 24);
            this.cboUnidadeMedida.TabIndex = 24;
            this.cboUnidadeMedida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboUnidadeMedida_KeyDown);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(677, 33);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(259, 20);
            this.txtFornecedor.TabIndex = 1;
            this.txtFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFornecedor_KeyDown);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Location = new System.Drawing.Point(138, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecoCusto.Location = new System.Drawing.Point(138, 91);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(82, 22);
            this.txtPrecoCusto.TabIndex = 4;
            this.txtPrecoCusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoCusto_KeyDown);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(138, 59);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(259, 22);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecoVenda.Location = new System.Drawing.Point(138, 123);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(82, 22);
            this.txtPrecoVenda.TabIndex = 3;
            this.txtPrecoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyDown);
            // 
            // btnLimparInformacoes
            // 
            this.btnLimparInformacoes.ForeColor = System.Drawing.Color.Black;
            this.btnLimparInformacoes.Location = new System.Drawing.Point(267, 392);
            this.btnLimparInformacoes.Name = "btnLimparInformacoes";
            this.btnLimparInformacoes.Size = new System.Drawing.Size(130, 47);
            this.btnLimparInformacoes.TabIndex = 110;
            this.btnLimparInformacoes.Text = "Limpar Informações";
            this.btnLimparInformacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparInformacoes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(627, 60);
            this.label3.TabIndex = 108;
            this.label3.Text = "C A D A S T R O  D E  P R O D U T O S";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dtgProdutos.Location = new System.Drawing.Point(450, 189);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.ReadOnly = true;
            this.dtgProdutos.RowHeadersVisible = false;
            this.dtgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdutos.Size = new System.Drawing.Size(538, 250);
            this.dtgProdutos.TabIndex = 107;
            this.dtgProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbIncluir,
            this.tbAlterar,
            this.tbExcluir,
            this.tbAtualizar,
            this.tbImprimir,
            this.tbVoltar});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(13, 87);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(418, 84);
            this.toolStrip1.TabIndex = 106;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbIncluir
            // 
            this.tbIncluir.Image = ((System.Drawing.Image)(resources.GetObject("tbIncluir.Image")));
            this.tbIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbIncluir.Name = "tbIncluir";
            this.tbIncluir.Size = new System.Drawing.Size(68, 81);
            this.tbIncluir.Text = "Incluir";
            this.tbIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbIncluir.ToolTipText = "Clique parar incluir um registro";
            this.tbIncluir.Click += new System.EventHandler(this.tbIncluir_Click);
            // 
            // tbAlterar
            // 
            this.tbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tbAlterar.Image")));
            this.tbAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlterar.Name = "tbAlterar";
            this.tbAlterar.Size = new System.Drawing.Size(68, 81);
            this.tbAlterar.Text = "Alterar";
            this.tbAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbAlterar.ToolTipText = "Clique para alterar um registro";
            this.tbAlterar.Click += new System.EventHandler(this.tbAlterar_Click);
            // 
            // tbExcluir
            // 
            this.tbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tbExcluir.Image")));
            this.tbExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExcluir.Name = "tbExcluir";
            this.tbExcluir.Size = new System.Drawing.Size(68, 81);
            this.tbExcluir.Text = "Excluir";
            this.tbExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbExcluir.ToolTipText = "Clique para excluir um registro";
            this.tbExcluir.Click += new System.EventHandler(this.tbExcluir_Click);
            // 
            // tbAtualizar
            // 
            this.tbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tbAtualizar.Image")));
            this.tbAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAtualizar.Name = "tbAtualizar";
            this.tbAtualizar.Size = new System.Drawing.Size(68, 81);
            this.tbAtualizar.Text = "Atualizar";
            this.tbAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbAtualizar.ToolTipText = "Clique para Atualizar os registros";
            // 
            // tbImprimir
            // 
            this.tbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tbImprimir.Image")));
            this.tbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbImprimir.Name = "tbImprimir";
            this.tbImprimir.Size = new System.Drawing.Size(68, 81);
            this.tbImprimir.Text = "Imprimir";
            this.tbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbImprimir.ToolTipText = "Clique para imprimir ";
            // 
            // tbVoltar
            // 
            this.tbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("tbVoltar.Image")));
            this.tbVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbVoltar.Name = "tbVoltar";
            this.tbVoltar.Size = new System.Drawing.Size(68, 81);
            this.tbVoltar.Text = "Voltar";
            this.tbVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbVoltar.ToolTipText = "Retornar a tela anterior";
            this.tbVoltar.Click += new System.EventHandler(this.tbVoltar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdbDesc);
            this.groupBox2.Controls.Add(this.rdbCresc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnPesquisa);
            this.groupBox2.Controls.Add(this.txtConsulta);
            this.groupBox2.Controls.Add(this.cbxPesquisar);
            this.groupBox2.Controls.Add(this.cbxOrdenar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(450, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 84);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procurar";
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Location = new System.Drawing.Point(447, 60);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(60, 20);
            this.rdbDesc.TabIndex = 6;
            this.rdbDesc.Text = "Z -> A";
            this.rdbDesc.UseVisualStyleBackColor = true;
            this.rdbDesc.CheckedChanged += new System.EventHandler(this.rdbDesc_CheckedChanged);
            // 
            // rdbCresc
            // 
            this.rdbCresc.AutoSize = true;
            this.rdbCresc.Checked = true;
            this.rdbCresc.Location = new System.Drawing.Point(381, 60);
            this.rdbCresc.Name = "rdbCresc";
            this.rdbCresc.Size = new System.Drawing.Size(60, 20);
            this.rdbCresc.TabIndex = 6;
            this.rdbCresc.TabStop = true;
            this.rdbCresc.Text = "A -> Z";
            this.rdbCresc.UseVisualStyleBackColor = true;
            this.rdbCresc.CheckedChanged += new System.EventHandler(this.rdbCresc_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ordenar";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = global::Control_Manager_Plus.Properties.Resources.find;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisa.Location = new System.Drawing.Point(290, 53);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(64, 25);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(9, 55);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(275, 22);
            this.txtConsulta.TabIndex = 3;
            // 
            // cbxPesquisar
            // 
            this.cbxPesquisar.FormattingEnabled = true;
            this.cbxPesquisar.Items.AddRange(new object[] {
            "Todos os Campos",
            "Código do Produto",
            "Descrição do Produtol",
            "Preço Venda acima de...",
            "Preço Venda abaixo de...",
            "Preço Custo acima de...",
            "Preço Custo abaixo de...",
            "Tipo de Unidade",
            "Fornecedor Padrão"});
            this.cbxPesquisar.Location = new System.Drawing.Point(113, 20);
            this.cbxPesquisar.Name = "cbxPesquisar";
            this.cbxPesquisar.Size = new System.Drawing.Size(241, 24);
            this.cbxPesquisar.TabIndex = 1;
            this.cbxPesquisar.SelectedValueChanged += new System.EventHandler(this.cbxPesquisar_SelectedValueChanged);
            // 
            // cbxOrdenar
            // 
            this.cbxOrdenar.FormattingEnabled = true;
            this.cbxOrdenar.Items.AddRange(new object[] {
            "Código do Produto",
            "Descrição do Produto",
            "Preço Venda ",
            "Preço Custo",
            "Tipo de Unidade",
            "Fornecedor Padrão"});
            this.cbxOrdenar.Location = new System.Drawing.Point(381, 33);
            this.cbxOrdenar.Name = "cbxOrdenar";
            this.cbxOrdenar.Size = new System.Drawing.Size(151, 24);
            this.cbxOrdenar.TabIndex = 1;
            this.cbxOrdenar.SelectedIndexChanged += new System.EventHandler(this.cbxOrdenar_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pesquisar por...";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "P_Id";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "P_Descricao";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "P_Unid";
            this.Column5.HeaderText = "UN";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "P_Pcusto";
            this.Column3.HeaderText = "Custo R$";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "P_Pvenda";
            this.Column4.HeaderText = "Venda R$";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "P_Fornecedor";
            this.Column6.HeaderText = "Fornecedor";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // cbxSelecionaFornecedor
            // 
            this.cbxSelecionaFornecedor.FormattingEnabled = true;
            this.cbxSelecionaFornecedor.Location = new System.Drawing.Point(136, 150);
            this.cbxSelecionaFornecedor.Name = "cbxSelecionaFornecedor";
            this.cbxSelecionaFornecedor.Size = new System.Drawing.Size(261, 24);
            this.cbxSelecionaFornecedor.TabIndex = 26;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimparInformacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnLimparInformacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbIncluir;
        private System.Windows.Forms.ToolStripButton tbAlterar;
        private System.Windows.Forms.ToolStripButton tbExcluir;
        private System.Windows.Forms.ToolStripButton tbAtualizar;
        private System.Windows.Forms.ToolStripButton tbImprimir;
        private System.Windows.Forms.ToolStripButton tbVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUnidadeMedida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.RadioButton rdbCresc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.MaskedTextBox txtConsulta;
        private System.Windows.Forms.ComboBox cbxPesquisar;
        private System.Windows.Forms.ComboBox cbxOrdenar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cbxSelecionaFornecedor;
    }
}