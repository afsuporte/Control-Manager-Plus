﻿namespace Control_Manager_Plus.Forms
{
    partial class frmCadDistribuicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadDistribuicao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbIncluir = new System.Windows.Forms.ToolStripButton();
            this.tbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.tbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tbVoltar = new System.Windows.Forms.ToolStripButton();
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
            this.dtgDistribuicao = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
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
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDistribuicao)).BeginInit();
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
            this.tbAtualizar.Click += new System.EventHandler(this.tbAtualizar_Click);
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
            this.tbImprimir.Click += new System.EventHandler(this.tbImprimir_Click);
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
            // 
            // rdbDesc
            // 
            this.rdbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDesc.ForeColor = System.Drawing.Color.White;
            this.rdbDesc.Location = new System.Drawing.Point(846, 12);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(65, 17);
            this.rdbDesc.TabIndex = 6;
            this.rdbDesc.Text = "Z -> A";
            this.rdbDesc.UseVisualStyleBackColor = true;
            this.rdbDesc.Click += new System.EventHandler(this.rdbDesc_CheckedChanged);
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
            "Registro",
            "Data",
            "Valor",
            "Responável"});
            this.cbxOrdenar.Location = new System.Drawing.Point(627, 10);
            this.cbxOrdenar.Name = "cbxOrdenar";
            this.cbxOrdenar.Size = new System.Drawing.Size(151, 21);
            this.cbxOrdenar.TabIndex = 1;
            this.cbxOrdenar.Click += new System.EventHandler(this.cbxOrdenar_SelectedIndexChanged);
            // 
            // cbxPesquisar
            // 
            this.cbxPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPesquisar.FormattingEnabled = true;
            this.cbxPesquisar.Items.AddRange(new object[] {
            "Todos os campos",
            "Por registro",
            "Por data",
            "Por total da Distribuição",
            "Por Responsável do registro"});
            this.cbxPesquisar.Location = new System.Drawing.Point(337, 10);
            this.cbxPesquisar.Name = "cbxPesquisar";
            this.cbxPesquisar.Size = new System.Drawing.Size(143, 21);
            this.cbxPesquisar.TabIndex = 1;
            this.cbxPesquisar.Click += new System.EventHandler(this.cbxPesquisar_SelectedIndexChanged);
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
            this.panel3.Size = new System.Drawing.Size(913, 39);
            this.panel3.TabIndex = 115;
            // 
            // rdbCresc
            // 
            this.rdbCresc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCresc.AutoSize = true;
            this.rdbCresc.Checked = true;
            this.rdbCresc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCresc.ForeColor = System.Drawing.Color.White;
            this.rdbCresc.Location = new System.Drawing.Point(780, 12);
            this.rdbCresc.Name = "rdbCresc";
            this.rdbCresc.Size = new System.Drawing.Size(65, 17);
            this.rdbCresc.TabIndex = 6;
            this.rdbCresc.TabStop = true;
            this.rdbCresc.Text = "A -> Z";
            this.rdbCresc.UseVisualStyleBackColor = true;
            this.rdbCresc.Click += new System.EventHandler(this.rdbCresc_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(305, 14);
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
            this.label8.Location = new System.Drawing.Point(564, 14);
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
            this.btnPesquisa.Location = new System.Drawing.Point(497, 8);
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
            this.txtConsulta.Size = new System.Drawing.Size(185, 22);
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
            this.splitContainer1.Panel1.Controls.Add(this.dtgDistribuicao);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
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
            // dtgDistribuicao
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgDistribuicao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgDistribuicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDistribuicao.BackgroundColor = System.Drawing.Color.White;
            this.dtgDistribuicao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgDistribuicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDistribuicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DATA,
            this.valor,
            this.Responsavel});
            this.dtgDistribuicao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgDistribuicao.Location = new System.Drawing.Point(3, 147);
            this.dtgDistribuicao.Name = "dtgDistribuicao";
            this.dtgDistribuicao.ReadOnly = true;
            this.dtgDistribuicao.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dtgDistribuicao.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgDistribuicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDistribuicao.Size = new System.Drawing.Size(912, 376);
            this.dtgDistribuicao.TabIndex = 116;
            this.dtgDistribuicao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLojas_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Dis_Id";
            dataGridViewCellStyle6.Format = "000000";
            dataGridViewCellStyle6.NullValue = null;
            this.ID.DefaultCellStyle = dataGridViewCellStyle6;
            this.ID.HeaderText = "Registro";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "Dis_DataDefinida";
            this.DATA.HeaderText = "Data";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "Dis_Total";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle7;
            this.valor.HeaderText = "Valor da Operação";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // Responsavel
            // 
            this.Responsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Responsavel.DataPropertyName = "Dis_Operador";
            this.Responsavel.FillWeight = 200F;
            this.Responsavel.HeaderText = "Responsável";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtResponsavel);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.btn01);
            this.groupBox1.Controls.Add(this.btn02);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 103);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Responsável";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Valor Total";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponsavel.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResponsavel.Enabled = false;
            this.txtResponsavel.Location = new System.Drawing.Point(192, 75);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(166, 22);
            this.txtResponsavel.TabIndex = 30;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(94, 29);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(264, 22);
            this.txtValorTotal.TabIndex = 29;
            // 
            // btn01
            // 
            this.btn01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn01.Enabled = false;
            this.btn01.Location = new System.Drawing.Point(676, 26);
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
            this.btn02.Location = new System.Drawing.Point(792, 26);
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
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(9, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(10, 74);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(176, 22);
            this.txtData.TabIndex = 28;
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Control_Manager_Plus.Relatorio.Produto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(715, 517);
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
            this.label13.Size = new System.Drawing.Size(572, 60);
            this.label13.TabIndex = 96;
            this.label13.Text = "CONTROLE DE DISTRIBUIÇÕES";
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
            // frmCadDistribuicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 628);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadDistribuicao";
            this.Text = "Controle de Distribuições";
            this.Load += new System.EventHandler(this.frmCadDistribuicao_Load);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDistribuicao)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridView dtgDistribuicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
    }
}