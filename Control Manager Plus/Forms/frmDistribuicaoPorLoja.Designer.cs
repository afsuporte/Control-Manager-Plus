namespace Control_Manager_Plus.Forms
{
    partial class frmDistribuicaoPorLoja
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
            System.Windows.Forms.ToolStrip toolStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribuicaoPorLoja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbIncluir = new System.Windows.Forms.ToolStripButton();
            this.tbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbImprimir = new System.Windows.Forms.ToolStripButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.dtgSoma = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLojas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirLinhas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodDistribuicao = new System.Windows.Forms.TextBox();
            this.dtpDataSelecionada = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgLancamentos = new System.Windows.Forms.DataGridView();
            this.G_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Selecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.G_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Div = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_CodFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grProdutos = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabFornecedor = new System.Windows.Forms.TabPage();
            this.txtValorPadrao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSelecionaFornecedor = new System.Windows.Forms.ComboBox();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.txtQtdePadrao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdeDisponivel = new System.Windows.Forms.TextBox();
            this.txtQtdeRestate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxSelecionaProduto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGravarDistribuicao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLojas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLancamentos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresaDetalhe)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grProdutos.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabFornecedor.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tbIncluir,
            this.tbAlterar,
            this.tbExcluir,
            this.tbImprimir});
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
            // 
            // tbExcluir
            // 
            this.tbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tbExcluir.Image")));
            this.tbExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExcluir.Name = "tbExcluir";
            this.tbExcluir.Size = new System.Drawing.Size(68, 81);
            this.tbExcluir.Text = "Excluir  Linhas";
            this.tbExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbExcluir.ToolTipText = "Clique para excluir um registro";
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
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Control_Manager_Plus.Relatorio.Produto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(715, 517);
            this.reportViewer1.TabIndex = 0;
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
            this.comboBox1.Size = new System.Drawing.Size(16, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 39);
            this.panel4.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 36);
            this.label3.TabIndex = 96;
            this.label3.Text = "RELATÓRIO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(4, 144);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(100, 49);
            this.btnGerarRelatorio.TabIndex = 120;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
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
            this.panel5.Location = new System.Drawing.Point(723, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 517);
            this.panel5.TabIndex = 121;
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
            this.comboBox2.Size = new System.Drawing.Size(16, 21);
            this.comboBox2.TabIndex = 118;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(91, 93);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbTotal);
            this.splitContainer1.Panel1.Controls.Add(this.btnLancar);
            this.splitContainer1.Panel1.Controls.Add(this.dtgSoma);
            this.splitContainer1.Panel1.Controls.Add(this.dtgLojas);
            this.splitContainer1.Panel1.Controls.Add(this.btnExcluirLinhas);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.grProdutos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(918, 523);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 119;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(198, 467);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(52, 16);
            this.lbTotal.TabIndex = 17;
            this.lbTotal.Text = "TOTAL";
            // 
            // btnLancar
            // 
            this.btnLancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(256, 493);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(153, 28);
            this.btnLancar.TabIndex = 19;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
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
            this.dtgSoma.Location = new System.Drawing.Point(256, 465);
            this.dtgSoma.Name = "dtgSoma";
            this.dtgSoma.RowHeadersVisible = false;
            this.dtgSoma.Size = new System.Drawing.Size(153, 24);
            this.dtgSoma.TabIndex = 18;
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dtgLojas
            // 
            this.dtgLojas.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgLojas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLojas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgLojas.Enabled = false;
            this.dtgLojas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgLojas.Location = new System.Drawing.Point(3, 154);
            this.dtgLojas.Name = "dtgLojas";
            this.dtgLojas.RowHeadersVisible = false;
            this.dtgLojas.Size = new System.Drawing.Size(406, 305);
            this.dtgLojas.TabIndex = 16;
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
            dataGridViewCellStyle3.Format = "C2";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "C2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btnExcluirLinhas
            // 
            this.btnExcluirLinhas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirLinhas.Location = new System.Drawing.Point(712, 16);
            this.btnExcluirLinhas.Name = "btnExcluirLinhas";
            this.btnExcluirLinhas.Size = new System.Drawing.Size(91, 44);
            this.btnExcluirLinhas.TabIndex = 14;
            this.btnExcluirLinhas.Text = "Excluir Selecionados";
            this.btnExcluirLinhas.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(809, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 44);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar [Sair]";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodDistribuicao);
            this.groupBox1.Controls.Add(this.dtpDataSelecionada);
            this.groupBox1.Location = new System.Drawing.Point(415, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 54);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribuiçao";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Número";
            // 
            // txtCodDistribuicao
            // 
            this.txtCodDistribuicao.Enabled = false;
            this.txtCodDistribuicao.Location = new System.Drawing.Point(55, 21);
            this.txtCodDistribuicao.Name = "txtCodDistribuicao";
            this.txtCodDistribuicao.Size = new System.Drawing.Size(87, 20);
            this.txtCodDistribuicao.TabIndex = 2;
            // 
            // dtpDataSelecionada
            // 
            this.dtpDataSelecionada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSelecionada.Location = new System.Drawing.Point(185, 21);
            this.dtpDataSelecionada.Name = "dtpDataSelecionada";
            this.dtpDataSelecionada.Size = new System.Drawing.Size(85, 20);
            this.dtpDataSelecionada.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(415, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 444);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgLancamentos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgLancamentos
            // 
            this.dtgLancamentos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgLancamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgLancamentos.BackgroundColor = System.Drawing.Color.White;
            this.dtgLancamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLancamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.G_ID,
            this.G_Selecao,
            this.G_Produto,
            this.G_Valor,
            this.G_Div,
            this.G_PrecoCusto,
            this.G_CodFornecedor});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgLancamentos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLancamentos.Location = new System.Drawing.Point(3, 3);
            this.dtgLancamentos.MultiSelect = false;
            this.dtgLancamentos.Name = "dtgLancamentos";
            this.dtgLancamentos.RowHeadersVisible = false;
            this.dtgLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLancamentos.Size = new System.Drawing.Size(486, 412);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.G_Produto.DefaultCellStyle = dataGridViewCellStyle7;
            this.G_Produto.FillWeight = 150F;
            this.G_Produto.Frozen = true;
            this.G_Produto.HeaderText = "PRODUTO";
            this.G_Produto.Name = "G_Produto";
            this.G_Produto.ReadOnly = true;
            this.G_Produto.Width = 150;
            // 
            // G_Valor
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.G_Valor.DefaultCellStyle = dataGridViewCellStyle8;
            this.G_Valor.Frozen = true;
            this.G_Valor.HeaderText = "VALOR";
            this.G_Valor.Name = "G_Valor";
            this.G_Valor.ReadOnly = true;
            // 
            // G_Div
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.NullValue = ">>";
            this.G_Div.DefaultCellStyle = dataGridViewCellStyle9;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSelecionarEmpresa);
            this.tabPage2.Controls.Add(this.cbxFiltroEmpresa);
            this.tabPage2.Controls.Add(this.dtgEmpresaDetalhe);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 418);
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
            // 
            // cbxFiltroEmpresa
            // 
            this.cbxFiltroEmpresa.FormattingEnabled = true;
            this.cbxFiltroEmpresa.Location = new System.Drawing.Point(10, 25);
            this.cbxFiltroEmpresa.Name = "cbxFiltroEmpresa";
            this.cbxFiltroEmpresa.Size = new System.Drawing.Size(371, 21);
            this.cbxFiltroEmpresa.TabIndex = 6;
            // 
            // dtgEmpresaDetalhe
            // 
            this.dtgEmpresaDetalhe.AllowUserToAddRows = false;
            this.dtgEmpresaDetalhe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEmpresaDetalhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpresaDetalhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowdtgEmpresa_Id,
            this.RowdtgEmpresa_Produto,
            this.RowdtgEmpresa_Valor,
            this.RowdtgEmpresa_Qtde,
            this.RowdtgEmpresa_Total,
            this.RowdtgEmpresa_Fornecedor});
            this.dtgEmpresaDetalhe.Location = new System.Drawing.Point(6, 69);
            this.dtgEmpresaDetalhe.Name = "dtgEmpresaDetalhe";
            this.dtgEmpresaDetalhe.RowHeadersVisible = false;
            this.dtgEmpresaDetalhe.Size = new System.Drawing.Size(480, 346);
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
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.RowdtgEmpresa_Valor.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.RowdtgEmpresa_Total.DefaultCellStyle = dataGridViewCellStyle12;
            this.RowdtgEmpresa_Total.HeaderText = "Total";
            this.RowdtgEmpresa_Total.Name = "RowdtgEmpresa_Total";
            // 
            // RowdtgEmpresa_Fornecedor
            // 
            this.RowdtgEmpresa_Fornecedor.HeaderText = "Fornecedor";
            this.RowdtgEmpresa_Fornecedor.Name = "RowdtgEmpresa_Fornecedor";
            this.RowdtgEmpresa_Fornecedor.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(492, 418);
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
            this.chart1.Size = new System.Drawing.Size(492, 418);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // grProdutos
            // 
            this.grProdutos.Controls.Add(this.tabControl2);
            this.grProdutos.Controls.Add(this.cbxSelecionaProduto);
            this.grProdutos.Controls.Add(this.label6);
            this.grProdutos.Location = new System.Drawing.Point(3, 3);
            this.grProdutos.Name = "grProdutos";
            this.grProdutos.Size = new System.Drawing.Size(406, 150);
            this.grProdutos.TabIndex = 11;
            this.grProdutos.TabStop = false;
            this.grProdutos.Text = "Produto";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabFornecedor);
            this.tabControl2.Controls.Add(this.tabGeral);
            this.tabControl2.Location = new System.Drawing.Point(8, 51);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(392, 94);
            this.tabControl2.TabIndex = 11;
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.txtValorPadrao);
            this.tabFornecedor.Controls.Add(this.label1);
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
            this.txtValorPadrao.Size = new System.Drawing.Size(100, 20);
            this.txtValorPadrao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Preço Venda";
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
            this.txtValorCusto.Size = new System.Drawing.Size(100, 20);
            this.txtValorCusto.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
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
            // txtQtdePadrao
            // 
            this.txtQtdePadrao.Enabled = false;
            this.txtQtdePadrao.Location = new System.Drawing.Point(20, 31);
            this.txtQtdePadrao.Name = "txtQtdePadrao";
            this.txtQtdePadrao.Size = new System.Drawing.Size(83, 20);
            this.txtQtdePadrao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Restante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dísponivel";
            // 
            // txtQtdeDisponivel
            // 
            this.txtQtdeDisponivel.Enabled = false;
            this.txtQtdeDisponivel.Location = new System.Drawing.Point(283, 6);
            this.txtQtdeDisponivel.Name = "txtQtdeDisponivel";
            this.txtQtdeDisponivel.Size = new System.Drawing.Size(83, 20);
            this.txtQtdeDisponivel.TabIndex = 2;
            // 
            // txtQtdeRestate
            // 
            this.txtQtdeRestate.Enabled = false;
            this.txtQtdeRestate.Location = new System.Drawing.Point(283, 32);
            this.txtQtdeRestate.Name = "txtQtdeRestate";
            this.txtQtdeRestate.Size = new System.Drawing.Size(83, 20);
            this.txtQtdeRestate.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lançar Qtde. Padrão";
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnGravarDistribuicao);
            this.panel2.Location = new System.Drawing.Point(91, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 75);
            this.panel2.TabIndex = 117;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(326, 60);
            this.label13.TabIndex = 96;
            this.label13.Text = "DISTRIBUIÇÃO x";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGravarDistribuicao
            // 
            this.btnGravarDistribuicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravarDistribuicao.Location = new System.Drawing.Point(621, 22);
            this.btnGravarDistribuicao.Name = "btnGravarDistribuicao";
            this.btnGravarDistribuicao.Size = new System.Drawing.Size(91, 44);
            this.btnGravarDistribuicao.TabIndex = 16;
            this.btnGravarDistribuicao.Text = "Gravar Distribuição";
            this.btnGravarDistribuicao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(toolStrip1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 604);
            this.panel1.TabIndex = 118;
            // 
            // frmDistribuicaoPorLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 628);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDistribuicaoPorLoja";
            this.Text = "frmDistribuicaoPorLoja";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLojas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLancamentos)).EndInit();
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tbIncluir;
        private System.Windows.Forms.ToolStripButton tbAlterar;
        private System.Windows.Forms.ToolStripButton tbExcluir;
        private System.Windows.Forms.ToolStripButton tbImprimir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grProdutos;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabFornecedor;
        private System.Windows.Forms.TextBox txtValorPadrao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSelecionaFornecedor;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.TextBox txtQtdePadrao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtdeDisponivel;
        private System.Windows.Forms.TextBox txtQtdeRestate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxSelecionaProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgLancamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn G_Selecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Div;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_PrecoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_CodFornecedor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSelecionarEmpresa;
        private System.Windows.Forms.ComboBox cbxFiltroEmpresa;
        private System.Windows.Forms.DataGridView dtgEmpresaDetalhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowdtgEmpresa_Fornecedor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnExcluirLinhas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodDistribuicao;
        private System.Windows.Forms.DateTimePicker dtpDataSelecionada;
        private System.Windows.Forms.Button btnGravarDistribuicao;
        private System.Windows.Forms.DataGridView dtgLojas;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.DataGridView dtgSoma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}