﻿namespace Control_Manager_Plus.Forms
{
    partial class frmCadFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFornecedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbIncluir = new System.Windows.Forms.ToolStripButton();
            this.tbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.tbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tbVoltar = new System.Windows.Forms.ToolStripButton();
            this.FornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxOrdenar = new System.Windows.Forms.ComboBox();
            this.cbxPesquisar = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbCresc = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.MaskedTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgFornecedores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFornecedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.tbAtualizar,
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
            // tbIncluir
            // 
            this.tbIncluir.Image = ((System.Drawing.Image)(resources.GetObject("tbIncluir.Image")));
            this.tbIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbIncluir.Name = "tbIncluir";
            this.tbIncluir.Size = new System.Drawing.Size(68, 83);
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
            this.tbAlterar.Size = new System.Drawing.Size(68, 83);
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
            this.tbExcluir.Size = new System.Drawing.Size(68, 83);
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
            this.tbAtualizar.Size = new System.Drawing.Size(68, 83);
            this.tbAtualizar.Text = "Atualizar";
            this.tbAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbAtualizar.ToolTipText = "Clique para Atualizar os registros";
            this.tbAtualizar.Click += new System.EventHandler(this.tbAtualizar_Click);
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
            // FornecedoresBindingSource
            // 
            this.FornecedoresBindingSource.DataSource = typeof(Control_Manager_Plus.Classes.Fornecedores);
            // 
            // rdbDesc
            // 
            this.rdbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDesc.ForeColor = System.Drawing.Color.White;
            this.rdbDesc.Location = new System.Drawing.Point(840, 12);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(65, 17);
            this.rdbDesc.TabIndex = 6;
            this.rdbDesc.Text = "Z -> A";
            this.rdbDesc.UseVisualStyleBackColor = true;
            this.rdbDesc.CheckedChanged += new System.EventHandler(this.rdbDesc_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pesquisar por...";
            // 
            // cbxOrdenar
            // 
            this.cbxOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOrdenar.FormattingEnabled = true;
            this.cbxOrdenar.Items.AddRange(new object[] {
            "Código do Fornecedor",
            "Nome / Razão Social",
            "CPF / CNPJ"});
            this.cbxOrdenar.Location = new System.Drawing.Point(621, 10);
            this.cbxOrdenar.Name = "cbxOrdenar";
            this.cbxOrdenar.Size = new System.Drawing.Size(151, 21);
            this.cbxOrdenar.TabIndex = 1;
            this.cbxOrdenar.SelectedIndexChanged += new System.EventHandler(this.cbxOrdenar_SelectedIndexChanged);
            // 
            // cbxPesquisar
            // 
            this.cbxPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPesquisar.FormattingEnabled = true;
            this.cbxPesquisar.Items.AddRange(new object[] {
            "Todos os Campos",
            "Código do Fornecedor",
            "Nome / Razão Social",
            "CPF / CNPJ",
            "Inscrição Estadual",
            "Telefone",
            "Contato",
            "E-mail"});
            this.cbxPesquisar.Location = new System.Drawing.Point(331, 10);
            this.cbxPesquisar.Name = "cbxPesquisar";
            this.cbxPesquisar.Size = new System.Drawing.Size(143, 21);
            this.cbxPesquisar.TabIndex = 1;
            this.cbxPesquisar.SelectedValueChanged += new System.EventHandler(this.cbxPesquisar_SelectedValueChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.rdbDesc);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.rdbCresc);
            this.panel3.Controls.Add(this.cbxOrdenar);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbxPesquisar);
            this.panel3.Controls.Add(this.btnPesquisa);
            this.panel3.Controls.Add(this.txtConsulta);
            this.panel3.Location = new System.Drawing.Point(2, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(907, 39);
            this.panel3.TabIndex = 115;
            // 
            // rdbCresc
            // 
            this.rdbCresc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCresc.AutoSize = true;
            this.rdbCresc.Checked = true;
            this.rdbCresc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCresc.ForeColor = System.Drawing.Color.White;
            this.rdbCresc.Location = new System.Drawing.Point(774, 12);
            this.rdbCresc.Name = "rdbCresc";
            this.rdbCresc.Size = new System.Drawing.Size(65, 17);
            this.rdbCresc.TabIndex = 6;
            this.rdbCresc.TabStop = true;
            this.rdbCresc.Text = "A -> Z";
            this.rdbCresc.UseVisualStyleBackColor = true;
            this.rdbCresc.CheckedChanged += new System.EventHandler(this.rdbCresc_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(299, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "em";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(558, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ordenar";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisa.BackgroundImage = global::Control_Manager_Plus.Properties.Resources.find;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisa.Location = new System.Drawing.Point(491, 8);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(64, 25);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(114, 9);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(179, 22);
            this.txtConsulta.TabIndex = 3;
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
            this.splitContainer1.Panel1.Controls.Add(this.dtgFornecedores);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(912, 523);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 119;
            // 
            // dtgFornecedores
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgFornecedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFornecedores.BackgroundColor = System.Drawing.Color.White;
            this.dtgFornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column7,
            this.Column8});
            this.dtgFornecedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgFornecedores.Location = new System.Drawing.Point(2, 147);
            this.dtgFornecedores.Name = "dtgFornecedores";
            this.dtgFornecedores.ReadOnly = true;
            this.dtgFornecedores.RowHeadersVisible = false;
            this.dtgFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFornecedores.Size = new System.Drawing.Size(907, 376);
            this.dtgFornecedores.TabIndex = 116;
            this.dtgFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFornecedores_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "E_Id";
            dataGridViewCellStyle2.NullValue = "000000";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "E_RazaoSocial";
            this.dataGridViewTextBoxColumn2.FillWeight = 220F;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Razão Social";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "E_CNPJ";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "E_IE";
            this.dataGridViewTextBoxColumn4.FillWeight = 80F;
            this.dataGridViewTextBoxColumn4.HeaderText = "IE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "E_Tel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "E_Contato";
            this.Column7.FillWeight = 120F;
            this.Column7.HeaderText = "Contato";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "E_Email";
            this.Column8.HeaderText = "E-mail";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtContato);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Controls.Add(this.txtCNPJ);
            this.groupBox1.Controls.Add(this.btn01);
            this.groupBox1.Controls.Add(this.btn02);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtIE);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 103);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(412, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 22);
            this.txtEmail.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 119;
            this.label4.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "CNPJ";
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContato.Location = new System.Drawing.Point(252, 74);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(154, 22);
            this.txtContato.TabIndex = 118;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(249, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 117;
            this.label14.Text = "Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Razão Social";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel.Location = new System.Drawing.Point(120, 74);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(126, 22);
            this.txtTel.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Insc. Estadual";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazaoSocial.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(94, 30);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(376, 22);
            this.txtRazaoSocial.TabIndex = 29;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCNPJ.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCNPJ.Location = new System.Drawing.Point(476, 30);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(154, 22);
            this.txtCNPJ.TabIndex = 28;
            // 
            // btn01
            // 
            this.btn01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn01.Enabled = false;
            this.btn01.Location = new System.Drawing.Point(670, 26);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(110, 59);
            this.btn01.TabIndex = 27;
            this.btn01.Text = "Salvar";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn02.Location = new System.Drawing.Point(786, 26);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(110, 59);
            this.btn02.TabIndex = 27;
            this.btn02.Text = "Sair";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCodigo.Location = new System.Drawing.Point(9, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtIE
            // 
            this.txtIE.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtIE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIE.Location = new System.Drawing.Point(10, 74);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(104, 22);
            this.txtIE.TabIndex = 32;
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
            this.panel5.Location = new System.Drawing.Point(724, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 520);
            this.panel5.TabIndex = 121;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 39);
            this.panel4.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 36);
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
            this.comboBox1.Size = new System.Drawing.Size(16, 21);
            this.comboBox1.TabIndex = 2;
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
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FornecedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Control_Manager_Plus.Relatorio.Fornecedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(715, 940);
            this.reportViewer1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(577, 60);
            this.label13.TabIndex = 96;
            this.label13.Text = "CADASTRO DE FORNECEDORES";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(91, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 75);
            this.panel2.TabIndex = 117;
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
            // frmCadFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 628);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadFornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.frmCadFornecedores_Load);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFornecedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxOrdenar;
        private System.Windows.Forms.ComboBox cbxPesquisar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbCresc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.MaskedTextBox txtConsulta;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripButton tbIncluir;
        private System.Windows.Forms.ToolStripButton tbAlterar;
        private System.Windows.Forms.ToolStripButton tbExcluir;
        private System.Windows.Forms.ToolStripButton tbAtualizar;
        private System.Windows.Forms.ToolStripButton tbImprimir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton tbVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgFornecedores;
        private System.Windows.Forms.BindingSource FornecedoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}