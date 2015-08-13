namespace Control_Manager_Plus.Forms
{
    partial class frmDistribuicaoLojas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStrip toolStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribuicaoLojas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tbVoltar = new System.Windows.Forms.ToolStripButton();
            this.DistDetalheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgLancamentos = new System.Windows.Forms.DataGridView();
            this.G_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Selecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.G_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Div = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_CodFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataSelecionada = new System.Windows.Forms.DateTimePicker();
            this.txtCodDistribuicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirLinhas = new System.Windows.Forms.Button();
            this.dtgLojas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgSoma = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSelecionarEmpresa = new System.Windows.Forms.Button();
            this.cbxFiltroEmpresa = new System.Windows.Forms.ComboBox();
            this.dtgEmpresaDetalhe = new System.Windows.Forms.DataGridView();
            this.RowdtgEmpresa_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowdtgEmpresa_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowdtgEmpresa_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowdtgEmpresa_Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowdtgEmpresa_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowdtgEmpresa_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxSelecionaProduto = new System.Windows.Forms.ComboBox();
            this.txtQtdeDisponivel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txtQtdeRestate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdePadrao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grProdutos = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabFornecedor = new System.Windows.Forms.TabPage();
            this.txtValorPadrao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSelecionaFornecedor = new System.Windows.Forms.ComboBox();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnGravarDistribuicao = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbAtencao = new System.Windows.Forms.Label();
            this.lbExluir1 = new System.Windows.Forms.Label();
            this.lbExluir2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistDetalheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLancamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLojas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoma)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresaDetalhe)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grProdutos.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabFornecedor.SuspendLayout();
            this.tabGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = System.Drawing.Color.White;
            toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSalvar,
            this.tbCancelar,
            this.tbImprimir,
            this.tbVoltar});
            toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new System.Drawing.Point(2, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new System.Drawing.Size(69, 506);
            toolStrip1.TabIndex = 94;
            toolStrip1.Text = "toolStrip1";
            // 
            // tbSalvar
            // 
            this.tbSalvar.AutoSize = false;
            this.tbSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbSalvar.Image = global::Control_Manager_Plus.Properties.Resources.floppy_unmount;
            this.tbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSalvar.Name = "tbSalvar";
            this.tbSalvar.Size = new System.Drawing.Size(68, 81);
            this.tbSalvar.Text = "Salvar";
            this.tbSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbSalvar.ToolTipText = "Clique parar incluir um registro";
            this.tbSalvar.Click += new System.EventHandler(this.tbSalvar_Click);
            // 
            // tbCancelar
            // 
            this.tbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tbCancelar.Image")));
            this.tbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCancelar.Name = "tbCancelar";
            this.tbCancelar.Size = new System.Drawing.Size(68, 83);
            this.tbCancelar.Text = "Cancelar";
            this.tbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbCancelar.ToolTipText = "Clique para alterar um registro";
            this.tbCancelar.Click += new System.EventHandler(this.tbCancelar_Click);
            // 
            // tbImprimir
            // 
            this.tbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tbImprimir.Image")));
            this.tbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbImprimir.Name = "tbImprimir";
            this.tbImprimir.Size = new System.Drawing.Size(68, 83);
            this.tbImprimir.Text = "Imprimir";
            this.tbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbImprimir.ToolTipText = "Clique para imprimir ";
            this.tbImprimir.Click += new System.EventHandler(this.tbImprimir_Click);
            // 
            // tbVoltar
            // 
            this.tbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("tbVoltar.Image")));
            this.tbVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbVoltar.Name = "tbVoltar";
            this.tbVoltar.Size = new System.Drawing.Size(68, 83);
            this.tbVoltar.Text = "Voltar";
            this.tbVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbVoltar.ToolTipText = "Retornar a tela anterior";
            // 
            // DistDetalheBindingSource
            // 
            this.DistDetalheBindingSource.DataSource = typeof(Control_Manager_Plus.Classes.DistDetalhe);
            // 
            // dtgLancamentos
            // 
            this.dtgLancamentos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgLancamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgLancamentos.BackgroundColor = System.Drawing.Color.White;
            this.dtgLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLancamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.G_ID,
            this.G_Selecao,
            this.G_Produto,
            this.G_Valor,
            this.G_Div,
            this.G_PrecoCusto,
            this.G_CodFornecedor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLancamentos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLancamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgLancamentos.Location = new System.Drawing.Point(3, 3);
            this.dtgLancamentos.MultiSelect = false;
            this.dtgLancamentos.Name = "dtgLancamentos";
            this.dtgLancamentos.RowHeadersVisible = false;
            this.dtgLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLancamentos.Size = new System.Drawing.Size(599, 414);
            this.dtgLancamentos.TabIndex = 0;
            // 
            // G_ID
            // 
            this.G_ID.Frozen = true;
            this.G_ID.HeaderText = "ID";
            this.G_ID.Name = "G_ID";
            this.G_ID.ReadOnly = true;
            this.G_ID.Visible = false;
            // 
            // G_Selecao
            // 
            this.G_Selecao.FillWeight = 20F;
            this.G_Selecao.Frozen = true;
            this.G_Selecao.HeaderText = "";
            this.G_Selecao.Name = "G_Selecao";
            this.G_Selecao.Width = 20;
            // 
            // G_Produto
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.G_Produto.DefaultCellStyle = dataGridViewCellStyle2;
            this.G_Produto.FillWeight = 150F;
            this.G_Produto.Frozen = true;
            this.G_Produto.HeaderText = "PRODUTO";
            this.G_Produto.Name = "G_Produto";
            this.G_Produto.ReadOnly = true;
            this.G_Produto.Width = 150;
            // 
            // G_Valor
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.G_Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.G_Valor.Frozen = true;
            this.G_Valor.HeaderText = "VALOR";
            this.G_Valor.Name = "G_Valor";
            this.G_Valor.ReadOnly = true;
            // 
            // G_Div
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.NullValue = ">>";
            this.G_Div.DefaultCellStyle = dataGridViewCellStyle4;
            this.G_Div.FillWeight = 20F;
            this.G_Div.Frozen = true;
            this.G_Div.HeaderText = "";
            this.G_Div.Name = "G_Div";
            this.G_Div.ReadOnly = true;
            this.G_Div.Width = 20;
            // 
            // G_PrecoCusto
            // 
            this.G_PrecoCusto.Frozen = true;
            this.G_PrecoCusto.HeaderText = "PrecoCusto";
            this.G_PrecoCusto.Name = "G_PrecoCusto";
            this.G_PrecoCusto.Visible = false;
            // 
            // G_CodFornecedor
            // 
            this.G_CodFornecedor.Frozen = true;
            this.G_CodFornecedor.HeaderText = "Cód Fornecedor";
            this.G_CodFornecedor.Name = "G_CodFornecedor";
            this.G_CodFornecedor.Visible = false;
            // 
            // dtpDataSelecionada
            // 
            this.dtpDataSelecionada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSelecionada.Location = new System.Drawing.Point(185, 21);
            this.dtpDataSelecionada.Name = "dtpDataSelecionada";
            this.dtpDataSelecionada.Size = new System.Drawing.Size(85, 21);
            this.dtpDataSelecionada.TabIndex = 1;
            // 
            // txtCodDistribuicao
            // 
            this.txtCodDistribuicao.Enabled = false;
            this.txtCodDistribuicao.Location = new System.Drawing.Point(55, 21);
            this.txtCodDistribuicao.Name = "txtCodDistribuicao";
            this.txtCodDistribuicao.Size = new System.Drawing.Size(87, 21);
            this.txtCodDistribuicao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnExcluirLinhas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodDistribuicao);
            this.groupBox1.Controls.Add(this.dtpDataSelecionada);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(416, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribuiçao";
            // 
            // btnExcluirLinhas
            // 
            this.btnExcluirLinhas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirLinhas.Location = new System.Drawing.Point(346, 10);
            this.btnExcluirLinhas.Name = "btnExcluirLinhas";
            this.btnExcluirLinhas.Size = new System.Drawing.Size(141, 40);
            this.btnExcluirLinhas.TabIndex = 11;
            this.btnExcluirLinhas.Text = "Excluir Selecionados";
            this.btnExcluirLinhas.UseVisualStyleBackColor = true;
            this.btnExcluirLinhas.Click += new System.EventHandler(this.btnExcluirLinhas_Click);
            // 
            // dtgLojas
            // 
            this.dtgLojas.AllowUserToAddRows = false;
            this.dtgLojas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgLojas.BackgroundColor = System.Drawing.Color.White;
            this.dtgLojas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgLojas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgLojas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLojas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Loja,
            this.Valor,
            this.Qtde,
            this.Total});
            this.dtgLojas.Enabled = false;
            this.dtgLojas.Location = new System.Drawing.Point(4, 161);
            this.dtgLojas.Name = "dtgLojas";
            this.dtgLojas.RowHeadersVisible = false;
            this.dtgLojas.Size = new System.Drawing.Size(406, 296);
            this.dtgLojas.TabIndex = 5;
            this.dtgLojas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLojas_CellEndEdit);
            this.dtgLojas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLojas_CellValueChanged);
            this.dtgLojas.SelectionChanged += new System.EventHandler(this.dtgLojas_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "L_Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Loja
            // 
            this.Loja.DataPropertyName = "L_Loja";
            this.Loja.FillWeight = 150F;
            this.Loja.HeaderText = "Loja";
            this.Loja.Name = "Loja";
            this.Loja.ReadOnly = true;
            this.Loja.Width = 150;
            // 
            // Valor
            // 
            dataGridViewCellStyle6.Format = "C2";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle6;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.FillWeight = 50F;
            this.Qtde.HeaderText = "Qtde.";
            this.Qtde.Name = "Qtde";
            this.Qtde.Width = 50;
            // 
            // Total
            // 
            dataGridViewCellStyle7.Format = "C2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle7;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // dtgSoma
            // 
            this.dtgSoma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgSoma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSoma.ColumnHeadersVisible = false;
            this.dtgSoma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgSoma.Location = new System.Drawing.Point(257, 463);
            this.dtgSoma.Name = "dtgSoma";
            this.dtgSoma.RowHeadersVisible = false;
            this.dtgSoma.Size = new System.Drawing.Size(153, 24);
            this.dtgSoma.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 250F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Loja";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Qtde.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(416, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 446);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgLancamentos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSelecionarEmpresa);
            this.tabPage2.Controls.Add(this.cbxFiltroEmpresa);
            this.tabPage2.Controls.Add(this.dtgEmpresaDetalhe);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(605, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empresa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSelecionarEmpresa
            // 
            this.btnSelecionarEmpresa.Location = new System.Drawing.Point(387, 21);
            this.btnSelecionarEmpresa.Name = "btnSelecionarEmpresa";
            this.btnSelecionarEmpresa.Size = new System.Drawing.Size(104, 27);
            this.btnSelecionarEmpresa.TabIndex = 7;
            this.btnSelecionarEmpresa.Text = "Selecionar";
            this.btnSelecionarEmpresa.UseVisualStyleBackColor = true;
            this.btnSelecionarEmpresa.Click += new System.EventHandler(this.btnSelecionarEmpresa_Click);
            // 
            // cbxFiltroEmpresa
            // 
            this.cbxFiltroEmpresa.FormattingEnabled = true;
            this.cbxFiltroEmpresa.Location = new System.Drawing.Point(10, 25);
            this.cbxFiltroEmpresa.Name = "cbxFiltroEmpresa";
            this.cbxFiltroEmpresa.Size = new System.Drawing.Size(371, 21);
            this.cbxFiltroEmpresa.TabIndex = 6;
            this.cbxFiltroEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxFiltroEmpresa_SelectedIndexChanged);
            // 
            // dtgEmpresaDetalhe
            // 
            this.dtgEmpresaDetalhe.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgEmpresaDetalhe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgEmpresaDetalhe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEmpresaDetalhe.BackgroundColor = System.Drawing.Color.White;
            this.dtgEmpresaDetalhe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgEmpresaDetalhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpresaDetalhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowdtgEmpresa_Id,
            this.RowdtgEmpresa_Produto,
            this.RowdtgEmpresa_Valor,
            this.RowdtgEmpresa_Qtde,
            this.RowdtgEmpresa_Total,
            this.RowdtgEmpresa_Fornecedor});
            this.dtgEmpresaDetalhe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgEmpresaDetalhe.Location = new System.Drawing.Point(6, 69);
            this.dtgEmpresaDetalhe.Name = "dtgEmpresaDetalhe";
            this.dtgEmpresaDetalhe.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dtgEmpresaDetalhe.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgEmpresaDetalhe.Size = new System.Drawing.Size(605, 348);
            this.dtgEmpresaDetalhe.TabIndex = 5;
            // 
            // RowdtgEmpresa_Id
            // 
            this.RowdtgEmpresa_Id.HeaderText = "Id";
            this.RowdtgEmpresa_Id.Name = "RowdtgEmpresa_Id";
            this.RowdtgEmpresa_Id.Visible = false;
            // 
            // RowdtgEmpresa_Produto
            // 
            this.RowdtgEmpresa_Produto.FillWeight = 200F;
            this.RowdtgEmpresa_Produto.HeaderText = "Produto";
            this.RowdtgEmpresa_Produto.Name = "RowdtgEmpresa_Produto";
            this.RowdtgEmpresa_Produto.Width = 200;
            // 
            // RowdtgEmpresa_Valor
            // 
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.RowdtgEmpresa_Valor.DefaultCellStyle = dataGridViewCellStyle10;
            this.RowdtgEmpresa_Valor.HeaderText = "Valor";
            this.RowdtgEmpresa_Valor.Name = "RowdtgEmpresa_Valor";
            // 
            // RowdtgEmpresa_Qtde
            // 
            this.RowdtgEmpresa_Qtde.FillWeight = 50F;
            this.RowdtgEmpresa_Qtde.HeaderText = "Qtde.";
            this.RowdtgEmpresa_Qtde.Name = "RowdtgEmpresa_Qtde";
            this.RowdtgEmpresa_Qtde.Width = 50;
            // 
            // RowdtgEmpresa_Total
            // 
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.RowdtgEmpresa_Total.DefaultCellStyle = dataGridViewCellStyle11;
            this.RowdtgEmpresa_Total.HeaderText = "Total";
            this.RowdtgEmpresa_Total.Name = "RowdtgEmpresa_Total";
            // 
            // RowdtgEmpresa_Fornecedor
            // 
            this.RowdtgEmpresa_Fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RowdtgEmpresa_Fornecedor.HeaderText = "Fornecedor";
            this.RowdtgEmpresa_Fornecedor.Name = "RowdtgEmpresa_Fornecedor";
            this.RowdtgEmpresa_Fornecedor.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(605, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gráfico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(605, 420);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cbxSelecionaProduto
            // 
            this.cbxSelecionaProduto.FormattingEnabled = true;
            this.cbxSelecionaProduto.Items.AddRange(new object[] {
            "Selecione"});
            this.cbxSelecionaProduto.Location = new System.Drawing.Point(75, 24);
            this.cbxSelecionaProduto.Name = "cbxSelecionaProduto";
            this.cbxSelecionaProduto.Size = new System.Drawing.Size(309, 21);
            this.cbxSelecionaProduto.TabIndex = 6;
            this.cbxSelecionaProduto.SelectedValueChanged += new System.EventHandler(this.cbxSelecionaProduto_SelectedValueChanged);
            // 
            // txtQtdeDisponivel
            // 
            this.txtQtdeDisponivel.Enabled = false;
            this.txtQtdeDisponivel.Location = new System.Drawing.Point(283, 6);
            this.txtQtdeDisponivel.Name = "txtQtdeDisponivel";
            this.txtQtdeDisponivel.Size = new System.Drawing.Size(83, 21);
            this.txtQtdeDisponivel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dísponivel";
            // 
            // btnLancar
            // 
            this.btnLancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(257, 491);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(153, 28);
            this.btnLancar.TabIndex = 8;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txtQtdeRestate
            // 
            this.txtQtdeRestate.Enabled = false;
            this.txtQtdeRestate.Location = new System.Drawing.Point(283, 32);
            this.txtQtdeRestate.Name = "txtQtdeRestate";
            this.txtQtdeRestate.Size = new System.Drawing.Size(83, 21);
            this.txtQtdeRestate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Restante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seleção";
            // 
            // txtQtdePadrao
            // 
            this.txtQtdePadrao.Enabled = false;
            this.txtQtdePadrao.Location = new System.Drawing.Point(20, 31);
            this.txtQtdePadrao.Name = "txtQtdePadrao";
            this.txtQtdePadrao.Size = new System.Drawing.Size(83, 21);
            this.txtQtdePadrao.TabIndex = 2;
            this.txtQtdePadrao.Leave += new System.EventHandler(this.txtQtdePadrao_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lançar Qtde. Padrão";
            // 
            // grProdutos
            // 
            this.grProdutos.Controls.Add(this.tabControl2);
            this.grProdutos.Controls.Add(this.cbxSelecionaProduto);
            this.grProdutos.Controls.Add(this.label6);
            this.grProdutos.Location = new System.Drawing.Point(4, 5);
            this.grProdutos.Name = "grProdutos";
            this.grProdutos.Size = new System.Drawing.Size(406, 150);
            this.grProdutos.TabIndex = 10;
            this.grProdutos.TabStop = false;
            this.grProdutos.Text = "Produto";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabFornecedor);
            this.tabControl2.Controls.Add(this.tabGeral);
            this.tabControl2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(8, 51);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(392, 94);
            this.tabControl2.TabIndex = 11;
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.txtValorPadrao);
            this.tabFornecedor.Controls.Add(this.label3);
            this.tabFornecedor.Controls.Add(this.cbxSelecionaFornecedor);
            this.tabFornecedor.Controls.Add(this.txtValorCusto);
            this.tabFornecedor.Controls.Add(this.label10);
            this.tabFornecedor.Controls.Add(this.label9);
            this.tabFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabFornecedor.Size = new System.Drawing.Size(384, 68);
            this.tabFornecedor.TabIndex = 1;
            this.tabFornecedor.Text = "Fornecedor";
            this.tabFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtValorPadrao
            // 
            this.txtValorPadrao.Enabled = false;
            this.txtValorPadrao.Location = new System.Drawing.Point(87, 42);
            this.txtValorPadrao.Name = "txtValorPadrao";
            this.txtValorPadrao.Size = new System.Drawing.Size(100, 21);
            this.txtValorPadrao.TabIndex = 8;
            this.txtValorPadrao.Leave += new System.EventHandler(this.txtValorPadrao_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço Venda";
            // 
            // cbxSelecionaFornecedor
            // 
            this.cbxSelecionaFornecedor.Enabled = false;
            this.cbxSelecionaFornecedor.FormattingEnabled = true;
            this.cbxSelecionaFornecedor.Location = new System.Drawing.Point(87, 12);
            this.cbxSelecionaFornecedor.Name = "cbxSelecionaFornecedor";
            this.cbxSelecionaFornecedor.Size = new System.Drawing.Size(291, 21);
            this.cbxSelecionaFornecedor.TabIndex = 7;
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.Enabled = false;
            this.txtValorCusto.Location = new System.Drawing.Point(276, 42);
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(100, 21);
            this.txtValorCusto.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nome / Razão";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Preço Custo";
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.txtQtdePadrao);
            this.tabGeral.Controls.Add(this.label5);
            this.tabGeral.Controls.Add(this.label4);
            this.tabGeral.Controls.Add(this.txtQtdeDisponivel);
            this.tabGeral.Controls.Add(this.txtQtdeRestate);
            this.tabGeral.Controls.Add(this.label7);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(384, 68);
            this.tabGeral.TabIndex = 0;
            this.tabGeral.Text = "Outros";
            this.tabGeral.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(199, 465);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(52, 16);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "TOTAL";
            // 
            // btnGravarDistribuicao
            // 
            this.btnGravarDistribuicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravarDistribuicao.Location = new System.Drawing.Point(823, 22);
            this.btnGravarDistribuicao.Name = "btnGravarDistribuicao";
            this.btnGravarDistribuicao.Size = new System.Drawing.Size(53, 42);
            this.btnGravarDistribuicao.TabIndex = 11;
            this.btnGravarDistribuicao.Text = "Gravar Distribuição";
            this.btnGravarDistribuicao.UseVisualStyleBackColor = true;
            this.btnGravarDistribuicao.Visible = false;
            this.btnGravarDistribuicao.Click += new System.EventHandler(this.btnGravarDistribuicao_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(764, 22);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 42);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar [Sair]";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbAtencao
            // 
            this.lbAtencao.AutoSize = true;
            this.lbAtencao.BackColor = System.Drawing.Color.Transparent;
            this.lbAtencao.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtencao.ForeColor = System.Drawing.Color.Black;
            this.lbAtencao.Location = new System.Drawing.Point(4, 15);
            this.lbAtencao.Name = "lbAtencao";
            this.lbAtencao.Size = new System.Drawing.Size(204, 60);
            this.lbAtencao.TabIndex = 109;
            this.lbAtencao.Text = "ATENÇÃO!";
            this.lbAtencao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbAtencao.Visible = false;
            // 
            // lbExluir1
            // 
            this.lbExluir1.AutoSize = true;
            this.lbExluir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExluir1.Location = new System.Drawing.Point(8, 80);
            this.lbExluir1.Name = "lbExluir1";
            this.lbExluir1.Size = new System.Drawing.Size(180, 16);
            this.lbExluir1.TabIndex = 110;
            this.lbExluir1.Text = "Esta operação é irreversível.";
            this.lbExluir1.Visible = false;
            // 
            // lbExluir2
            // 
            this.lbExluir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExluir2.Location = new System.Drawing.Point(8, 99);
            this.lbExluir2.Name = "lbExluir2";
            this.lbExluir2.Size = new System.Drawing.Size(392, 42);
            this.lbExluir2.TabIndex = 110;
            this.lbExluir2.Text = "O registro uma vez excluido não pode ser restaurado e afetará os relatórios assoc" +
    "iados.";
            this.lbExluir2.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(90, 93);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgLojas);
            this.splitContainer1.Panel1.Controls.Add(this.dtgSoma);
            this.splitContainer1.Panel1.Controls.Add(this.btnLancar);
            this.splitContainer1.Panel1.Controls.Add(this.lbTotal);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.grProdutos);
            this.splitContainer1.Panel1.Controls.Add(this.lbExluir1);
            this.splitContainer1.Panel1.Controls.Add(this.lbAtencao);
            this.splitContainer1.Panel1.Controls.Add(this.lbExluir2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(912, 523);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 111;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DistDetalheBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Control_Manager_Plus.Relatorio.DistribuicaoDetalhe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(619, 510);
            this.reportViewer1.TabIndex = 123;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.btnGerarRelatorio);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Location = new System.Drawing.Point(628, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 517);
            this.panel5.TabIndex = 122;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 39);
            this.panel4.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 36);
            this.label8.TabIndex = 96;
            this.label8.Text = "RELATÓRIO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(4, 144);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(100, 49);
            this.btnGerarRelatorio.TabIndex = 120;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 117;
            this.label11.Text = "Tipo de Relatório";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 119;
            this.label12.Text = "Definir produto";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos os produtos",
            "Produto especifico."});
            this.comboBox1.Location = new System.Drawing.Point(4, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(26, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Todos os produtos",
            "Produto especifico."});
            this.comboBox2.Location = new System.Drawing.Point(4, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(26, 21);
            this.comboBox2.TabIndex = 118;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(toolStrip1);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 604);
            this.panel1.TabIndex = 113;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnGravarDistribuicao);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(90, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 75);
            this.panel2.TabIndex = 112;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(348, 58);
            this.label13.TabIndex = 96;
            this.label13.Text = "DISTRIBUIÇÃO";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::Control_Manager_Plus.Properties.Resources.seta;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // frmDistribuicaoLojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmDistribuicaoLojas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuição de Produtos por Lojas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDistribuicaoLojas_Load);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistDetalheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLancamentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLojas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoma)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresaDetalhe)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.grProdutos.ResumeLayout(false);
            this.grProdutos.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabFornecedor.ResumeLayout(false);
            this.tabFornecedor.PerformLayout();
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLancamentos;
        private System.Windows.Forms.DateTimePicker dtpDataSelecionada;
        private System.Windows.Forms.TextBox txtCodDistribuicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgLojas;
        private System.Windows.Forms.DataGridView dtgSoma;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgEmpresaDetalhe;
        private System.Windows.Forms.ComboBox cbxFiltroEmpresa;
        private System.Windows.Forms.ComboBox cbxSelecionaProduto;
        private System.Windows.Forms.TextBox txtQtdeDisponivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txtQtdeRestate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtdePadrao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.TabPage tabFornecedor;
        private System.Windows.Forms.ComboBox cbxSelecionaFornecedor;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGravarDistribuicao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelecionarEmpresa;
        private System.Windows.Forms.TextBox txtValorPadrao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluirLinhas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbAtencao;
        private System.Windows.Forms.Label lbExluir1;
        private System.Windows.Forms.Label lbExluir2;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn G_Selecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Div;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_PrecoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_CodFornecedor;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton tbSalvar;
        private System.Windows.Forms.ToolStripButton tbCancelar;
        private System.Windows.Forms.ToolStripButton tbImprimir;
        private System.Windows.Forms.ToolStripButton tbVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DistDetalheBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Fornecedor;
    }
}