using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Control_Manager_Plus.Classes;

namespace Control_Manager_Plus.FRM
{
    public partial class frmCadastroProduto : Form
    {
        int ModoOperacao = 0;
        bool Liberado = false;
        int ProdutoSelecionado = 0;

        public frmCadastroProduto()
        {
            InitializeComponent();

            ListarFornecedores();
            
            HabilitarCampos(false);
            cbxPesquisar.SelectedIndex = 0;
            cbxOrdenar.SelectedIndex = 1;
            
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarLista();
            Liberado = true;
            Clique_dtgProdutos();
        }

        #region Botões

        private void tbIncluir_Click(object sender, EventArgs e)
        {
            ModoOperacao = 1;
            HabilitarCampos(true);
            LimparDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (ModoOperacao)
            {
                case 1:
                    AdicionarProdutos();
                    LimparDados();
                    break;
                case 2:
                    EditarProdutos();
                    LimparDados();
                    break;
                default:
                    break;
            }
            ModoOperacao = 0;
            HabilitarCampos(false);
            Clique_dtgProdutos();
        }

        private void tbAlterar_Click(object sender, EventArgs e)
        {
            ModoOperacao = 2;
            HabilitarCampos(true);
        }

        private void tbExcluir_Click(object sender, EventArgs e)
        {
            DialogResult _MgsExcluir = MessageBox.Show("Deseja confirmar a exclusão do Produto?",
          "Excluir Produto?",
          MessageBoxButtons.YesNo);

            if (_MgsExcluir == DialogResult.Yes)
            {
                ExcluirProdutos();
            }
            Clique_dtgProdutos();
        }

        private void tbVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }



        #endregion

  
        #region Funções Diversas

        void ListarFornecedores()
        {
            Fornecedores _produtoes = new Fornecedores();
            BancoDados _bd = new BancoDados();

            cbxSelecionaFornecedor.DataSource = _produtoes._ListarItemListBox(_bd.StringConexao()).OrderBy(x => x.Nome).ToList();
            cbxSelecionaFornecedor.DisplayMember = "Nome";
            cbxSelecionaFornecedor.ValueMember = "Id";
        }

        void HabilitarCampos(bool selecao)
        {
            txtCodigo.Enabled = selecao;
            txtDescricao.Enabled = selecao;
            txtFornecedor.Enabled = selecao;
            txtPrecoCusto.Enabled = selecao;
            txtPrecoVenda.Enabled = selecao;
            cboUnidadeMedida.Enabled = selecao;
            // txtDescricao.Select();
        }

        void LimparDados()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtFornecedor.Clear();
            txtPrecoCusto.Clear();
            txtPrecoVenda.Clear();
            cbxSelecionaFornecedor.SelectedIndex = 0;
            cboUnidadeMedida.Text = "";
        }

        #endregion


        #region CRUD

        void AdicionarProdutos()
        {
            BancoDados bd = new BancoDados();
            Produtos prod = new Produtos();
            decimal _custo;
            decimal _venda;

            prod.P_Descricao = txtDescricao.Text;
            prod.P_Fornecedor = txtFornecedor.Text;
            Decimal.TryParse(txtPrecoCusto.Text, out _custo);
            prod.P_Pcusto = _custo;
            Decimal.TryParse(txtPrecoVenda.Text, out _venda);
            prod.P_Pvenda = _venda;
            prod.P_Unid = cboUnidadeMedida.Text;

            if (prod._Adicionar(prod, bd.StringConexao()))
            {
                MessageBox.Show("Produto Cadastrado com Sucesso!");
                CarregarLista();
            }

            else
            {
                MessageBox.Show("Erro ao Cadastrar Produtos...");
            }



        }

        void EditarProdutos()
        {
            BancoDados bd = new BancoDados();
            Produtos prod = new Produtos();
            decimal _custo;
            decimal _venda;

            prod.P_Id = Convert.ToInt32(txtCodigo.Text);
            prod.P_Descricao = txtDescricao.Text;
            prod.P_Fornecedor = txtFornecedor.Text;
            Decimal.TryParse(txtPrecoCusto.Text, out _custo);
            prod.P_Pcusto = _custo;
            Decimal.TryParse(txtPrecoVenda.Text, out _venda);
            prod.P_Pvenda = _venda;
            prod.P_Unid = cboUnidadeMedida.Text;

            if (prod._Editar(prod, bd.StringConexao()))
            {
                MessageBox.Show("Produto Cadastrado com Sucesso!");                
                CarregarLista();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar Produtos...");
            }
        }

        void ExcluirProdutos()
        {
            BancoDados bd = new BancoDados();
            Produtos prod = new Produtos();

            if (prod._Excluir(Convert.ToInt32(txtCodigo.Text), bd.StringConexao()))
            {
                MessageBox.Show("Produto Excluído com Sucesso!");
                CarregarLista();
            }
            else
            {
                MessageBox.Show("Erro ao excluir Produtos...");
            }
        }


        #endregion



        #region Datagrid

        void CarregarLista()
        {
            try
            {
                BancoDados bd = new BancoDados();
                Produtos _produto = new Produtos();
                dtgProdutos.AutoGenerateColumns = false;

                switch (cbxOrdenar.SelectedIndex)
                {
                    /*
                    Código do Produto
                    Descrição do Produto
                    Preço Venda
                    Preço Custo 
                    Tipo de Unidade
                    Fornecedor Padrão
                     */
                    case 1:
                        // Descrição do Produto
                        if (rdbCresc.Checked)
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.P_Descricao).ToList();
                        }
                        else
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.P_Descricao).ToList();
                        }
                        break;
                    case 2:
                        // Preço de Venda
                        if (rdbCresc.Checked)
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.P_Pvenda).ToList();
                        }
                        else
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.P_Pvenda).ToList();
                        }
                        break;

                    case 3:
                        // Preço de Custo
                        if (rdbCresc.Checked)
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.P_Pcusto).ToList();
                        }
                        else
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.P_Pcusto).ToList();
                        }
                        break;
                    case 4:
                        // Tipo da Unidade
                        if (rdbCresc.Checked)
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.P_Unid).ToList();
                        }
                        else
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.P_Unid).ToList();
                        }
                        break;
                    case 5:
                        // Fornecedor Padrão
                        if (rdbCresc.Checked)
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.P_Fornecedor).ToList();
                        }
                        else
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.P_Fornecedor).ToList();
                        }
                        break;
                    default:
                        //Código 
                        if (rdbCresc.Checked)
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.P_Id).ToList();
                        }
                        else
                        {
                            dtgProdutos.DataSource = _produto._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.P_Id).ToList();
                        }
                        break;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar a Distribuiçao...");
            }
        }

        void Clique_dtgProdutos()
        {
            if (Liberado)
            {
                DataGridViewCell _celula = dtgProdutos.CurrentCell;
                int _LinhadtgProdutos = _celula.RowIndex;
                ProdutoSelecionado = Convert.ToInt32(dtgProdutos.Rows[_LinhadtgProdutos].Cells[0].Value);


                txtCodigo.Text = dtgProdutos.Rows[_LinhadtgProdutos].Cells[0].Value.ToString();
                txtDescricao.Text = dtgProdutos.Rows[_LinhadtgProdutos].Cells[1].Value.ToString();
                cboUnidadeMedida.SelectedText = dtgProdutos.Rows[_LinhadtgProdutos].Cells[2].Value.ToString();
                txtPrecoCusto.Text = dtgProdutos.Rows[_LinhadtgProdutos].Cells[3].Value.ToString();
                txtPrecoVenda.Text = dtgProdutos.Rows[_LinhadtgProdutos].Cells[4].Value.ToString();
                cbxSelecionaFornecedor.SelectedText = dtgProdutos.Rows[_LinhadtgProdutos].Cells[5].Value.ToString();
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void cbxPesquisar_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void rdbCresc_CheckedChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void rdbDesc_CheckedChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clique_dtgProdutos();
        }


        #endregion

    
 


        # region Sequencia de Enter

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPrecoCusto.Focus();
        }

        private void txtPrecoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPrecoVenda.Focus();
        }

        private void txtPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cboUnidadeMedida.Focus();
        }

        private void cboUnidadeMedida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtFornecedor.Focus();
        }

        private void txtFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSalvar.Focus();
        }


        # endregion


      

    

    }
    
}
