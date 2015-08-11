using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Control_Manager_Plus.Classes;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Reporting.WinForms;

namespace Control_Manager_Plus.Forms
{
    public partial class frmDistribuicaoLojas : Form
    {

        Produtos _produtos = new Produtos();
        Distribuicao _distribuicao = new Distribuicao();
        bool liberar = false;
        int _LinhadtgLoja = 0;
        int _ColunadtgLoja = 0;
        int _QtdePadrao = 0;
        int _QtdeTotal = 0;
        decimal _VlrTotal = 0;
        int SelecaoEmpresa_dtgEmpresaDetalhe = 0;
        int _CodDistribuicao;
        int _ModoOperacao; 
        /*  1 - Adição
            2 - Ediçãp
            3 - Exclusão 
        */ 

        public frmDistribuicaoLojas(int CodDistribuicao, int ModoOperacao)
        {
            InitializeComponent();


            CarregarGridLojas();
            InserirColuna_dtgLancamentos();
            ListarClientes();
            ListarFornecedores();
            ListarLojas();
            cbxSelecionaProduto.SelectedValue = 0;
            _ModoOperacao = ModoOperacao;
            _CodDistribuicao = CodDistribuicao;

            //if (CodDistribuicao > 0)
            //{

            //}
            //else
            //{
                
            //}

            switch (ModoOperacao)
            {
                case 2:

                    txtCodDistribuicao.Text = String.Format("{0:000000}", CodDistribuicao);
                    BancoDados _bd = new BancoDados();
                    _distribuicao = _distribuicao._PesquisarPorId(CodDistribuicao,_bd.StringConexao());
                    dtpDataSelecionada.Text = _distribuicao.Dis_DataDefinida.ToString();
                    dtpDataSelecionada.Enabled = false;
                    PreencherModoEditar();
                    break;
                case 3:
                    dtgLojas.Visible = false;
                    grProdutos.Visible = false;
                    btnExcluirLinhas.Visible = false;
                    lbTotal.Visible = false;
                    dtgSoma.Visible = false;
                    btnLancar.Visible = false;
                    lbAtencao.Visible = true;
                    lbExluir1.Visible = true;
                    lbExluir2.Visible = true;
                    btnGravarDistribuicao.Text = "Excluir Distribuição";

                    txtCodDistribuicao.Text = String.Format("{0:000000}", CodDistribuicao);
                    BancoDados _bd2 = new BancoDados();
                    _distribuicao = _distribuicao._PesquisarPorId(CodDistribuicao,_bd2.StringConexao());
                    dtpDataSelecionada.Text = _distribuicao.Dis_DataDefinida.ToString();
                    dtpDataSelecionada.Enabled = false;
                    PreencherModoEditar();
                    break;
                default:
                    txtCodDistribuicao.Text = "NS";
                    break;
            }

           
            
        }
        private void frmDistribuicaoLojas_Load(object sender, EventArgs e)
        {
            liberar = true;
           
        }

        public void CarregarGridLojas()
        {
            try
            {
                Lojas empresa = new Lojas();
                BancoDados bd = new BancoDados();
                dtgLojas.AutoGenerateColumns = false;
                dtgLojas.DataSource = false;

                dtgLojas.DataSource = empresa._ListarTodos(bd.StringConexao()).OrderBy(x => x.L_Loja).ToList();


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar a Empresa...");
            }

        }

        void ListarClientes()
        {
            Produtos _produto = new Produtos();
            BancoDados _bd = new BancoDados();

            cbxSelecionaProduto.DataSource = _produto._ListarItemListBox(_bd.StringConexao()).OrderBy(x => x.Nome).ToList();
            cbxSelecionaProduto.DisplayMember = "Nome";
            cbxSelecionaProduto.ValueMember = "Id";
        }
        void ListarLojas()
        {
            Lojas _loja = new Lojas();
            BancoDados _bd = new BancoDados();

            cbxFiltroEmpresa.DataSource = _loja._ListarItemListBox(_bd.StringConexao()).OrderBy(x => x.Nome).ToList();
            cbxFiltroEmpresa.DisplayMember = "Nome";
            cbxFiltroEmpresa.ValueMember = "Id";
        }
        void ListarFornecedores()
        {
            Fornecedores _Fornecedores = new Fornecedores();
            BancoDados _bd = new BancoDados();

            cbxSelecionaFornecedor.DataSource = _Fornecedores._ListarItemListBox(_bd.StringConexao()).OrderBy(x => x.Nome).ToList();
            cbxSelecionaFornecedor.DisplayMember = "Nome";
            cbxSelecionaFornecedor.ValueMember = "Id";
        }

        private void cbxSelecionaProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (liberar)
            {
                int prod = 0;
                Int32.TryParse(cbxSelecionaProduto.SelectedValue.ToString(), out prod);

                if (prod > 0)
                {
                    SelecionarProduto(prod);
                    txtQtdePadrao.Enabled = true;
                    txtQtdeDisponivel.Enabled = true;
                    cbxSelecionaFornecedor.Enabled = true;
                    //CarregarGridLojas();

                   
                }
                
            }
          
        }


        void SelecionarProduto(int CodProduto)
        {

            Produtos _prod = new Produtos();
            BancoDados _bd = new BancoDados();
            _produtos = _prod._PesquisarPorId(_bd.StringConexao(), CodProduto);

           txtValorPadrao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", _produtos.P_Pvenda);
           txtValorCusto.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", _produtos.P_Pcusto);
           txtValorPadrao.Enabled = true;
           txtValorCusto.Enabled = true;
           cbxSelecionaFornecedor.Enabled = true;

            
            ValorPadraoDatagrid_dtgLojas();

        }


        void ValorPadraoDatagrid_dtgLojas()
        {
            int t_Linhas = 0;
            t_Linhas = dtgLojas.RowCount -1;

            for (int i = 0; i <= t_Linhas; i++)
            {
                dtgLojas.Rows[i].Cells[2].Value = txtValorPadrao.Text;
                dtgLojas.Rows[i].Cells[3].Value = 0;
                dtgLojas.Rows[i].Cells[4].Value = 0;
            }

            dtgSoma.Rows[0].Cells[1].Value = 0;
            dtgSoma.Rows[0].Cells[2].Value = 0;

            dtgLojas.Enabled = true;
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            int selecao = Convert.ToInt32(cbxSelecionaProduto.SelectedValue);
            if (selecao > 0)
            {
                int idFornecedor = Convert.ToInt32(cbxSelecionaFornecedor.SelectedValue);
                if (idFornecedor > 0)
                {
                    if (lancar_dtgLancamentos())
                    {
                        cbxSelecionaProduto.SelectedValue = 0;

                        txtQtdePadrao.Enabled = false; ;
                        txtQtdePadrao.Text = "";
                        txtQtdeDisponivel.Enabled = false;
                        txtQtdeDisponivel.Text = "";
                        txtValorPadrao.Text = "";
                        txtValorPadrao.Enabled = false;
                        txtValorCusto.Text = "";
                        txtValorCusto.Enabled = false;
                        cbxSelecionaFornecedor.SelectedValue = 0;
                        cbxSelecionaFornecedor.Enabled = false;

                        Limpar_dgtLojas();
                        PreencherGrafico();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o Fornecedor.");
                }
            }

            
        }

        private void dtgLojas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

          

        }

        private void dtgLojas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int Qtde = 0;

            if (Int32.TryParse(dtgLojas.Rows[_LinhadtgLoja].Cells[3].Value.ToString(), out Qtde))
            {
                if (Qtde <= 0)
                {
                    dtgLojas.Rows[_LinhadtgLoja].Cells[3].Value = 0;
                }
            }
            else
            {
                dtgLojas.Rows[_LinhadtgLoja].Cells[3].Value = 0;
            }
        }


        void CalcularLInha_dtgLoja()
        {
            int t_Linhas = 0;
            decimal soma = 0;
            decimal QtdeTotal = 0;
            decimal QtdeDisponivel = 0;

            t_Linhas = dtgLojas.RowCount - 1;

            for (int i = 0; i <= t_Linhas; i++)
            {   

                decimal valorUnd = 0;
                decimal subtotal = 0;

                string valorUndTxt = dtgLojas.Rows[i].Cells[2].Value.ToString();
                valorUndTxt = valorUndTxt.Replace("R$", "");
                decimal.TryParse(valorUndTxt, out valorUnd);

                decimal Qtde = 0;
                decimal.TryParse(dtgLojas.Rows[i].Cells[3].Value.ToString(), out Qtde);
                QtdeTotal += Qtde;

                subtotal = valorUnd * Qtde;
                dtgLojas.Rows[i].Cells[4].Value = subtotal;
                soma += subtotal;               
            }

            dtgSoma.Rows[0].Cells[2].Value = soma;
            dtgSoma.Rows[0].Cells[1].Value = QtdeTotal;
            _QtdeTotal = Convert.ToInt32(QtdeTotal);
            _VlrTotal = soma;

            if (Decimal.TryParse(txtQtdeDisponivel.Text, out QtdeDisponivel))
            {
                if (QtdeDisponivel > 0)
                {
                   //ok
                }
                else
                {
                    txtQtdeDisponivel.Text = "0";
                }
            }
            else
            {
                txtQtdeDisponivel.Text = "0";
            }
            txtQtdeRestate.Text = (QtdeDisponivel - QtdeTotal).ToString();
        }

        private void dtgLojas_SelectionChanged(object sender, EventArgs e)
        {
            if (liberar)
            {
                DataGridViewCell _celula = dtgLojas.CurrentCell;
                _ColunadtgLoja = _celula.ColumnIndex;
                _LinhadtgLoja = _celula.RowIndex;

                CalcularLInha_dtgLoja();
            }
        }

        private void txtValorPadrao_Leave(object sender, EventArgs e)
        {
            decimal valorUnd = 0;

            string valorUndTxt = txtValorPadrao.Text;
            valorUndTxt = valorUndTxt.Replace("R$", "");
            decimal.TryParse(valorUndTxt, out valorUnd);

            if (valorUnd != _produtos.P_Pvenda && valorUnd > 0)
            {
                txtValorPadrao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valorUnd);
                ValorPadraoDatagrid_dtgLojas();
            }
            else
            {
                MessageBox.Show("Valor Inválido");
            }
        }



        void InserirColuna_dtgLancamentos()
        {
            Lojas _lojas = new Lojas();
            BancoDados _bd = new BancoDados();
            IList<Lojas> ListadeLojas = _lojas._ListarTodos(_bd.StringConexao());

            foreach (Lojas l in ListadeLojas)
            {
                dtgLancamentos.Columns.Add("L" + l.L_Id.ToString(), l.L_Loja);
            }
            dtgLancamentos.Columns.Add("TQTDETOTAL", "QTDE. TOTAL");
            dtgLancamentos.Columns.Add("TPRODUTO", "TOTAL DO PRODUTO");
            //dtgLancamentos.Columns.Add("TCODFORNECEDOR", "CÓDIGO DO FORNECEDOR");    
            dtgLancamentos.Columns.Add("FORNECEDOR", "FORNECEDOR");
            dtgLancamentos.Columns.Add("TFORNECEDOR", "TOTAL DO FORNECEDOR");            
        }


        private void txtQtdePadrao_Leave(object sender, EventArgs e)
        {
            int Qtde_PadraoNova = 0;

            Int32.TryParse(txtQtdePadrao.Text, out Qtde_PadraoNova);

            if (Qtde_PadraoNova != _QtdePadrao)
            {
                _QtdePadrao = Qtde_PadraoNova;

                for (int i = 0; i <= (dtgLojas.RowCount -1); i++)
                {
                    dtgLojas.Rows[i].Cells[3].Value = _QtdePadrao;
                }

                CalcularLInha_dtgLoja();
            }
        }



        bool lancar_dtgLancamentos()
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgLancamentos);
                
                int prod = 0;
                Int32.TryParse(cbxSelecionaProduto.SelectedValue.ToString(), out prod);

                row.Cells[dtgLancamentos.Columns[0].Index].Value = prod;
                row.Cells[dtgLancamentos.Columns[2].Index].Value = cbxSelecionaProduto.Text;
                row.Cells[dtgLancamentos.Columns[3].Index].Value = txtValorPadrao.Text;

                row.Cells[dtgLancamentos.Columns[5].Index].Value = txtValorCusto.Text;
                row.Cells[dtgLancamentos.Columns[6].Index].Value = cbxSelecionaFornecedor.SelectedValue.ToString();

                int t_Linhas = 0;
                t_Linhas = dtgLojas.RowCount - 1;

                for (int i = 0; i <= t_Linhas; i++)
                {
                    string Coluna = "L" + dtgLojas.Rows[i].Cells[0].Value.ToString();
                    row.Cells[dtgLancamentos.Columns[Coluna].Index].Value = dtgLojas.Rows[i].Cells[3].Value;
                }

                row.Cells[dtgLancamentos.Columns["TQTDETOTAL"].Index].Value = _QtdeTotal;
                row.Cells[dtgLancamentos.Columns["TPRODUTO"].Index].Value = _VlrTotal;
                row.Cells[dtgLancamentos.Columns["FORNECEDOR"].Index].Value = cbxSelecionaFornecedor.Text;

                dtgLancamentos.Rows.Add(row);

                return true;
            }
            catch (Exception)
            {
                return true;
            }




            
        }

        void lancar_dtgEmpresaDetalhe()
        {
            dtgEmpresaDetalhe.Rows.Clear();

            int t_Linhas = 0;
            t_Linhas = dtgLancamentos.RowCount - 1;

            for (int i = 0; i <= t_Linhas; i++) // buscar nas linhas 
            {
                string Coluna = "L" + SelecaoEmpresa_dtgEmpresaDetalhe.ToString();
                int QtdeProduto = 0;

                Int32.TryParse(dtgLancamentos.Rows[i].Cells[Coluna].Value.ToString(), out QtdeProduto);

                if (QtdeProduto > 0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtgEmpresaDetalhe);

                    row.Cells[dtgEmpresaDetalhe.Columns["RowdtgEmpresa_Produto"].Index].Value = dtgLancamentos.Rows[i].Cells[2].Value;
                    row.Cells[dtgEmpresaDetalhe.Columns["RowdtgEmpresa_Valor"].Index].Value = dtgLancamentos.Rows[i].Cells[3].Value;
                    row.Cells[dtgEmpresaDetalhe.Columns["RowdtgEmpresa_Qtde"].Index].Value = dtgLancamentos.Rows[i].Cells[Coluna].Value;

                    decimal valorUnd = 0;
                    string valorUndTxt = dtgLancamentos.Rows[i].Cells[2].Value.ToString();
                    valorUndTxt = valorUndTxt.Replace("R$", "");
                    decimal.TryParse(valorUndTxt, out valorUnd);

                    decimal Qtde = 0;
                    decimal.TryParse(dtgLancamentos.Rows[i].Cells[Coluna].Value.ToString(), out Qtde);
                    
                    decimal subtotal = 0;
                    subtotal = valorUnd * Qtde;

                    row.Cells[dtgEmpresaDetalhe.Columns["RowdtgEmpresa_Total"].Index].Value = subtotal;
                    dtgEmpresaDetalhe.Rows.Add(row);

                }
            }
        }

        private void btnSelecionarEmpresa_Click(object sender, EventArgs e)
        {
            if (cbxFiltroEmpresa.Enabled == true)
            {
                if (SelecaoEmpresa_dtgEmpresaDetalhe > 0)
                {
                    lancar_dtgEmpresaDetalhe();
                    btnSelecionarEmpresa.Text = "Alterar";
                    cbxFiltroEmpresa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Selecione primeiro uma empresa.");
                }
            }
            else
            {
                btnSelecionarEmpresa.Text = "Selecionar";
                cbxFiltroEmpresa.Enabled = true;
            }


        }

        private void cbxFiltroEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liberar)
            {
                Int32.TryParse(cbxFiltroEmpresa.SelectedValue.ToString(), out SelecaoEmpresa_dtgEmpresaDetalhe);
            }
        }

        void Limpar_dgtLojas()
        {
            int t_Linhas = 0;
            t_Linhas = dtgLojas.RowCount - 1;

            for (int i = 0; i <= t_Linhas; i++)
            {
                dtgLojas.Rows[i].Cells[2].Value = "";
                dtgLojas.Rows[i].Cells[3].Value = "";
                dtgLojas.Rows[i].Cells[4].Value = "";
            }
            dtgSoma.Rows[0].Cells[1].Value = "";
            dtgSoma.Rows[0].Cells[2].Value = "";

            dtgLojas.Enabled = false;
        }

        void Excluir_dtgLancamentos()
        {
            foreach (DataGridViewRow dr in dtgLancamentos.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    dtgLancamentos.Rows.RemoveAt(dr.Index);
                }
            }

            PreencherGrafico();
         }

        private void btnExcluirLinhas_Click(object sender, EventArgs e)
        {
            Excluir_dtgLancamentos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravarDistribuicao_Click(object sender, EventArgs e)
        {
           

            switch (_ModoOperacao)
            {
                case 2:
                    if (EditarRegistros())
                    {
                        MessageBox.Show("Distribuição Editada com sucesso!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("erro ao editar");
                    }

                    break;
                case 3:
                    if (ExcluirRegistro())
                    {
                        MessageBox.Show("Distribuição Excluída com sucesso!");
                        Close();
                    }
                    break;
                default:
                    if (Gravar_distribuicao())
                    {
                        Close();
                    }
                    break;
            }
            
           
        }

        bool Gravar_distribuicao()
        {
            try
            {
                Distribuicao _distribuicao = new Distribuicao();
                BancoDados _bd = new BancoDados();

                decimal somatorio = 0;
                foreach (DataGridViewRow dr in dtgLancamentos.Rows)
                {
                    decimal valor = 0;
                    Decimal.TryParse(dr.Cells["TPRODUTO"].Value.ToString(), out valor);
                    somatorio += valor;
                }

                _distribuicao.Dis_DataDefinida = DateTime.Now;
                _distribuicao.Dis_DataGravacao = DateTime.Now;
                _distribuicao.Dis_Operador = 0;
                _distribuicao.Dis_Total = somatorio;



                int ultimoId = _distribuicao._Adicionar(_distribuicao, _bd.StringConexao());

                //MessageBox.Show(ultimoId .ToString());

                if (ultimoId > 0)
                {
                    foreach (DataGridViewRow lj in dtgLojas.Rows)
                    {
                        int CodLoja = 0;
                        Int32.TryParse(lj.Cells[0].Value.ToString(), out CodLoja);

                        foreach (DataGridViewRow dr in dtgLancamentos.Rows)
                        {
                            string Coluna = "L" + CodLoja;
                            int QtdeProduto = 0;
                            Int32.TryParse(dr.Cells[Coluna].Value.ToString(), out QtdeProduto);

                            if (QtdeProduto > 0)
                            {
                                DistDetalhe _detalhe = new DistDetalhe();

                                _detalhe.DistD_CodDistribuicao = ultimoId;
                                _detalhe.DistD_CodLoja = Convert.ToInt32(lj.Cells[0].Value.ToString());
                                //Produto
                                _detalhe.DistD_CodProduto = Convert.ToInt32(dr.Cells[0].Value.ToString());
                                _detalhe.DistD_NomeProduto = dr.Cells[2].Value.ToString();

                                //Valor Untitário
                                decimal _vlrUnd = 0;
                                string valorUndTxt = dr.Cells[3].Value.ToString();
                                valorUndTxt = valorUndTxt.Replace("R$", "");
                                decimal.TryParse(valorUndTxt, out _vlrUnd);
                                _detalhe.DistD_ProdutoValorUnid = _vlrUnd;

                                //Quantidade
                                int _qtde = 0;
                                Int32.TryParse(dr.Cells[Coluna].Value.ToString(), out  _qtde);
                                _detalhe.DistD_ProdutoQtde = _qtde;

                                //Valor Total
                                _detalhe.DistD_ProdutoValorTotal = _vlrUnd * Convert.ToDecimal(_qtde);

                                //Fornecedor
                                _detalhe.DistD_CodFornecedor = Convert.ToInt32(dr.Cells[6].Value.ToString());
                                decimal _vlrCusto = 0;
                                string valorCustoTxt = dr.Cells[5].Value.ToString();
                                valorCustoTxt = valorCustoTxt.Replace("R$", "");
                                decimal.TryParse(valorCustoTxt, out _vlrCusto);
                                _detalhe.DistD_FornecedorValor = _vlrCusto * Convert.ToDecimal(_qtde);

                                _detalhe._Adicionar(_detalhe, _bd.StringConexao());
                            }
                        }
                    }
                }               
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        void PreencherGrafico()
        {
            this.chart1.Series.Clear();
            int S = 1;

            foreach (DataGridViewRow dr in dtgLancamentos.Rows)
            {

                string NomeSerie = String.Format("{0:00}", S) + " - " +  dr.Cells[2].Value.ToString();

                Series series = this.chart1.Series.Add(NomeSerie);
                series.IsValueShownAsLabel = true;
                S++;

                foreach (DataGridViewRow lj in dtgLojas.Rows)
                {
                    int CodLoja = 0;
                    Int32.TryParse(lj.Cells[0].Value.ToString(), out CodLoja);

                    string Coluna = "L" + CodLoja;
                    int QtdeProduto = 0;
                    Int32.TryParse(dr.Cells[Coluna].Value.ToString(), out QtdeProduto);

                    if (QtdeProduto > 0)
                    {
                        series.Points.AddXY(lj.Cells[1].Value.ToString(), QtdeProduto);
                    }
                }
            }
        }
       
        void PreencherModoEditar()
        {
            DistDetalhe _detalhes = new DistDetalhe();
            BancoDados _bd = new BancoDados();
            IList<DistDetalhe> ListaDetalhe = _detalhes._ListarDistribuicao(_CodDistribuicao, _bd.StringConexao());

            int codprod = 0;
            int Linha = 0;
            int UltimoProd = 0;

            foreach (var item in ListaDetalhe)
            {
                if (codprod != item.DistD_CodProduto)
                {

                    codprod = item.DistD_CodProduto;

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtgLancamentos);

                    row.Cells[dtgLancamentos.Columns[0].Index].Value = item.DistD_CodProduto;
                    row.Cells[dtgLancamentos.Columns[2].Index].Value = item.DistD_NomeProduto; //cbxSelecionaProduto.Text;
                    row.Cells[dtgLancamentos.Columns[3].Index].Value = item.DistD_ProdutoValorUnid;//txtValorPadrao.Text;

                    row.Cells[dtgLancamentos.Columns[5].Index].Value = item.DistD_FornecedorValor;//txtValorCusto.Text;
                    row.Cells[dtgLancamentos.Columns[6].Index].Value = item.DistD_CodFornecedor; // cbxSelecionaFornecedor.SelectedValue.ToString();


                    int t_Linhas = 0;
                    t_Linhas = dtgLojas.RowCount - 1;

                    for (int i = 0; i <= t_Linhas; i++)
                    {
                        string Coluna = "L" + dtgLojas.Rows[i].Cells[0].Value.ToString();
                        row.Cells[dtgLancamentos.Columns[Coluna].Index].Value = 0;
                    }
                    
                    
                    string coluna = "L" + item.DistD_CodLoja.ToString();
                    row.Cells[dtgLancamentos.Columns[coluna].Index].Value = item.DistD_ProdutoQtde;//dtgLojas.Rows[i].Cells[3].Value;




                    //row.Cells[dtgLancamentos.Columns["TQTDETOTAL"].Index].Value = _QtdeTotal;
                    //row.Cells[dtgLancamentos.Columns["TPRODUTO"].Index].Value = _VlrTotal;
                    //row.Cells[dtgLancamentos.Columns["FORNECEDOR"].Index].Value = cbxSelecionaFornecedor.Text;

                    dtgLancamentos.Rows.Add(row);
                    UltimoProd = item.DistD_CodProduto;



                }
                else
                {
                    if (item.DistD_CodProduto != UltimoProd)
                    {

                        Linha++;

                    }
                    string coluna = "L" + item.DistD_CodLoja.ToString();
                    //dtgLancamentos.Columns[coluna].c Index].Value = item.DistD_ProdutoQtde;
                    dtgLancamentos.Rows[Linha].Cells[coluna].Value = item.DistD_ProdutoQtde;
                    UltimoProd = item.DistD_CodProduto;
                }
                
            }
            PreencherGrafico();



        }

        bool ExcluirRegistro()
        {
            try
            {
                Distribuicao dt = new Distribuicao();
                DistDetalhe _detalhes = new DistDetalhe();
                BancoDados _bd = new BancoDados();
                IList<DistDetalhe> ListaDetalhe = _detalhes._ListarDistribuicao(_CodDistribuicao, _bd.StringConexao());

                _distribuicao._Excluir(_distribuicao.Dis_Id, _bd.StringConexao());

                foreach (var item in ListaDetalhe)
                {
                    _detalhes._Excluir(  item.DistD_Id, _bd.StringConexao());
                }
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        bool EditarRegistros()
        {
            try
            {
                Distribuicao dt = new Distribuicao();
                DistDetalhe _detalhes = new DistDetalhe();
                BancoDados _bd = new BancoDados();
                IList<DistDetalhe> ListaDetalhe = _detalhes._ListarDistribuicao(_CodDistribuicao, _bd.StringConexao());
                //Distribuicao _distribuicao = new Distribuicao();
                //BancoDados _bd = new BancoDados();

                decimal somatorio = 0;
                foreach (DataGridViewRow dr in dtgLancamentos.Rows)
                {
                    decimal valor = 0;
                    string ss = dr.Cells["TPRODUTO"].Value.ToString();

                    //Decimal.TryParse(dr.Cells["TPRODUTO"].Value.ToString(), out valor);
                    somatorio += valor;
                }

                _distribuicao.Dis_Id = _CodDistribuicao;
                //_distribuicao.Dis_DataDefinida = DateTime.Now;
                //_distribuicao.Dis_DataGravacao = DateTime.Now;
                _distribuicao.Dis_Operador = 0;
                _distribuicao.Dis_Total = somatorio;


                MessageBox.Show("Test 1");


                if (_distribuicao._Editar(_distribuicao, _bd.StringConexao()))
                {


                    MessageBox.Show("Test 2");

                    // Excluir detalhes antigos
                    foreach (var item in ListaDetalhe)
                    {
                        _detalhes._Excluir(item.DistD_Id, _bd.StringConexao());
                    }



                    foreach (DataGridViewRow lj in dtgLojas.Rows)
                    {
                        int CodLoja = 0;
                        Int32.TryParse(lj.Cells[0].Value.ToString(), out CodLoja);

                        foreach (DataGridViewRow dr in dtgLancamentos.Rows)
                        {
                            string Coluna = "L" + CodLoja;
                            int QtdeProduto = 0;
                            Int32.TryParse(dr.Cells[Coluna].Value.ToString(), out QtdeProduto);

                            if (QtdeProduto > 0)
                            {
                                DistDetalhe _detalhe = new DistDetalhe();

                                _detalhe.DistD_CodDistribuicao = _CodDistribuicao;
                                _detalhe.DistD_CodLoja = Convert.ToInt32(lj.Cells[0].Value.ToString());
                                //Produto
                                _detalhe.DistD_CodProduto = Convert.ToInt32(dr.Cells[0].Value.ToString());
                                _detalhe.DistD_NomeProduto = dr.Cells[2].Value.ToString();

                                //Valor Untitário
                                decimal _vlrUnd = 0;
                                string valorUndTxt = dr.Cells[3].Value.ToString();
                                valorUndTxt = valorUndTxt.Replace("R$", "");
                                decimal.TryParse(valorUndTxt, out _vlrUnd);
                                _detalhe.DistD_ProdutoValorUnid = _vlrUnd;

                                //Quantidade
                                int _qtde = 0;
                                Int32.TryParse(dr.Cells[Coluna].Value.ToString(), out  _qtde);
                                _detalhe.DistD_ProdutoQtde = _qtde;

                                //Valor Total
                                _detalhe.DistD_ProdutoValorTotal = _vlrUnd * Convert.ToDecimal(_qtde);

                                //Fornecedor
                                _detalhe.DistD_CodFornecedor = Convert.ToInt32(dr.Cells[6].Value.ToString());
                                decimal _vlrCusto = 0;
                                string valorCustoTxt = dr.Cells[5].Value.ToString();
                                valorCustoTxt = valorCustoTxt.Replace("R$", "");
                                decimal.TryParse(valorCustoTxt, out _vlrCusto);
                                _detalhe.DistD_FornecedorValor = _vlrCusto * Convert.ToDecimal(_qtde);

                                _detalhe._Adicionar(_detalhe, _bd.StringConexao());
                            }
                        }
                    }
                }






                return true;
            }
            catch (Exception)
            {

                return false;
            }   

        }

        private void tbImprimir_Click(object sender, EventArgs e)
        {
            bool ativo = splitContainer1.Panel1Collapsed;



            splitContainer1.Panel1Collapsed = !ativo;
            splitContainer1.Panel2Collapsed = ativo;
        }



        #region Funçoes diversas

        void GerarRelatorio()
        {
            BancoDados _bd = new BancoDados();
            Classes.Relatorios.ResumoProdDistribuicao _resumo = new Classes.Relatorios.ResumoProdDistribuicao();
            Classes.Relatorios.RelatorioDetalheDistribuicao _detalhe = new Classes.Relatorios.RelatorioDetalheDistribuicao();

            IList<Classes.Relatorios.ResumoProdDistribuicao> RelProdutos = _resumo._RelatorioPorDistribuicao(_CodDistribuicao, _bd.StringConexao());
            DataTable _tabela1 = CriarDataTables(RelProdutos);

            IList<Classes.Relatorios.RelatorioDetalheDistribuicao> Detalhe = _detalhe._ListarDetalheDistribuicao(_CodDistribuicao, _bd.StringConexao());
            DataTable _tabela2 = CriarDataTables(Detalhe);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetResumoProdDistribuicao", _tabela1));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelatorioDetalheDistribuicao", _tabela2));

            Microsoft.Reporting.WinForms.ReportParameter[] p =
            new Microsoft.Reporting.WinForms.ReportParameter[3];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Codigo", String.Format("{0:000000}", _CodDistribuicao));
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("DataDistribuicao", String.Format("{0:dd/MM/yyyy}", _distribuicao.Dis_DataDefinida)  );
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("ValorTotal", string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", _distribuicao.Dis_Total));

            reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();

        }


        public DataTable CriarDataTables<T>(IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prp = props[i];
                table.Columns.Add(prp.Name, prp.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        #endregion


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

       
            


    }
}
