namespace Control_Manager_Plus.Forms
{
    partial class frmCadDistribuicao1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadDistribuicao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.MaskedTextBox();
            this.cbxOrdenar_dtgDist = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDecrescente = new System.Windows.Forms.RadioButton();
            this.rdbCrescente = new System.Windows.Forms.RadioButton();
            this.cbxPesquisarPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLimparInformacoes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgDistribuicao = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbIncluir = new System.Windows.Forms.ToolStripButton();
            this.tbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.tbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tbVoltar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDistribuicao)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(68, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 42);
            this.btnSalvar.TabIndex = 109;
            this.btnSalvar.Text = " -  Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_Manager_Plus.Properties.Resources.find1;
            this.pictureBox1.Location = new System.Drawing.Point(825, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(253, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 26);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(6, 58);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(241, 22);
            this.txtConsulta.TabIndex = 3;
            // 
            // cbxOrdenar_dtgDist
            // 
            this.cbxOrdenar_dtgDist.FormattingEnabled = true;
            this.cbxOrdenar_dtgDist.Items.AddRange(new object[] {
            "REGISTRO",
            "DATA",
            "VALOR",
            "RESPONSÁVEL"});
            this.cbxOrdenar_dtgDist.Location = new System.Drawing.Point(392, 33);
            this.cbxOrdenar_dtgDist.Name = "cbxOrdenar_dtgDist";
            this.cbxOrdenar_dtgDist.Size = new System.Drawing.Size(140, 24);
            this.cbxOrdenar_dtgDist.TabIndex = 1;
            this.cbxOrdenar_dtgDist.SelectedIndexChanged += new System.EventHandler(this.cbxOrdenar_dtgDist_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdbDecrescente);
            this.groupBox2.Controls.Add(this.rdbCrescente);
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.txtConsulta);
            this.groupBox2.Controls.Add(this.cbxPesquisarPor);
            this.groupBox2.Controls.Add(this.cbxOrdenar_dtgDist);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(441, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 86);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procurar";
            // 
            // rdbDecrescente
            // 
            this.rdbDecrescente.AutoSize = true;
            this.rdbDecrescente.Checked = true;
            this.rdbDecrescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDecrescente.Location = new System.Drawing.Point(392, 63);
            this.rdbDecrescente.Name = "rdbDecrescente";
            this.rdbDecrescente.Size = new System.Drawing.Size(54, 17);
            this.rdbDecrescente.TabIndex = 6;
            this.rdbDecrescente.TabStop = true;
            this.rdbDecrescente.Text = "Z -> A";
            this.rdbDecrescente.UseVisualStyleBackColor = true;
            this.rdbDecrescente.CheckedChanged += new System.EventHandler(this.rdbDecrescente_CheckedChanged);
            // 
            // rdbCrescente
            // 
            this.rdbCrescente.AutoSize = true;
            this.rdbCrescente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCrescente.Location = new System.Drawing.Point(452, 63);
            this.rdbCrescente.Name = "rdbCrescente";
            this.rdbCrescente.Size = new System.Drawing.Size(54, 17);
            this.rdbCrescente.TabIndex = 6;
            this.rdbCrescente.Text = "A -> Z";
            this.rdbCrescente.UseVisualStyleBackColor = true;
            this.rdbCrescente.Click += new System.EventHandler(this.rdbCrescente_Click);
            // 
            // cbxPesquisarPor
            // 
            this.cbxPesquisarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPesquisarPor.FormattingEnabled = true;
            this.cbxPesquisarPor.Items.AddRange(new object[] {
            "TODOS OS CAMPOS",
            "POR REGISTRO",
            "POR DATA",
            "POR TOTAL DA DISTRIBUIÇÃO",
            "POR RESPONSÁVEL DO REGISTRO"});
            this.cbxPesquisarPor.Location = new System.Drawing.Point(113, 21);
            this.cbxPesquisarPor.Name = "cbxPesquisarPor";
            this.cbxPesquisarPor.Size = new System.Drawing.Size(217, 21);
            this.cbxPesquisarPor.TabIndex = 1;
            this.cbxPesquisarPor.SelectedIndexChanged += new System.EventHandler(this.cbxOrdenar_dtgDist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pesquisar por...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ordenar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Responsável";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cód. Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtResponsavel);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 194);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Loja";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Window;
            this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(121, 79);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(166, 22);
            this.txtData.TabIndex = 2;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.BackColor = System.Drawing.SystemColors.Window;
            this.txtResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResponsavel.Enabled = false;
            this.txtResponsavel.Location = new System.Drawing.Point(121, 135);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(166, 22);
            this.txtResponsavel.TabIndex = 4;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(121, 107);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(166, 22);
            this.txtValorTotal.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(121, 49);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(94, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnLimparInformacoes
            // 
            this.btnLimparInformacoes.ForeColor = System.Drawing.Color.Black;
            this.btnLimparInformacoes.Location = new System.Drawing.Point(244, 382);
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
            this.label3.Location = new System.Drawing.Point(-1, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(596, 60);
            this.label3.TabIndex = 108;
            this.label3.Text = "CONTROLE  D E  DISTRIBUIÇÕES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgDistribuicao
            // 
            this.dtgDistribuicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDistribuicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DATA,
            this.valor,
            this.Responsavel});
            this.dtgDistribuicao.Location = new System.Drawing.Point(441, 169);
            this.dtgDistribuicao.Name = "dtgDistribuicao";
            this.dtgDistribuicao.ReadOnly = true;
            this.dtgDistribuicao.RowHeadersVisible = false;
            this.dtgDistribuicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDistribuicao.Size = new System.Drawing.Size(538, 260);
            this.dtgDistribuicao.TabIndex = 107;
            this.dtgDistribuicao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLojas_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Dis_Id";
            dataGridViewCellStyle1.Format = "000000";
            dataGridViewCellStyle1.NullValue = null;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.valor.HeaderText = "Valor da Operação";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // Responsavel
            // 
            this.Responsavel.DataPropertyName = "Dis_Operador";
            this.Responsavel.FillWeight = 200F;
            this.Responsavel.HeaderText = "Responsável";
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.ReadOnly = true;
            this.Responsavel.Width = 200;
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
            this.toolStrip1.Location = new System.Drawing.Point(7, 67);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(449, 84);
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
            // frmCadDistribuicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 541);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimparInformacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgDistribuicao);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCadDistribuicao";
            this.Text = "CadastroDistribuicao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadDistribuicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDistribuicao)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox txtConsulta;
        private System.Windows.Forms.ComboBox cbxOrdenar_dtgDist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimparInformacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgDistribuicao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbIncluir;
        private System.Windows.Forms.ToolStripButton tbAlterar;
        private System.Windows.Forms.ToolStripButton tbExcluir;
        private System.Windows.Forms.ToolStripButton tbAtualizar;
        private System.Windows.Forms.ToolStripButton tbImprimir;
        private System.Windows.Forms.ToolStripButton tbVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.RadioButton rdbDecrescente;
        private System.Windows.Forms.RadioButton rdbCrescente;
        private System.Windows.Forms.ComboBox cbxPesquisarPor;
        private System.Windows.Forms.Label label2;
    }
}