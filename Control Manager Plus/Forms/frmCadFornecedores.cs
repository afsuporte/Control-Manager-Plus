using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Control_Manager_Plus.Classes;
using Microsoft.Reporting.WinForms;

namespace Control_Manager_Plus.Forms
{
    public partial class frmCadFornecedores : Form
    {

        bool Liberado = false;
        int FornecedorSelecionado = 0;
        int ModoOperacao = 0;

        public frmCadFornecedores()
        {
            InitializeComponent();
            HabilitarCampos(false);
            cbxPesquisar.SelectedIndex = 0;
            cbxOrdenar.SelectedIndex = 1;
        }

        private void frmCadFornecedores_Load(object sender, EventArgs e)
        {
            CarregarLista();
            Liberado = true;

            if (dtgFornecedores.RowCount > 0)
            {
                Clique_dtgFornecedores();
            }
            
        }

        #region Botões

        private void tbImprimir_Click(object sender, EventArgs e)
        {
            bool ativo = splitContainer1.Panel1Collapsed;
            splitContainer1.Panel1Collapsed = !ativo;
            splitContainer1.Panel2Collapsed = ativo;

            tbIncluir.Enabled = ativo;
            tbAlterar.Enabled = ativo;
            tbExcluir.Enabled = ativo;
            tbAtualizar.Enabled = ativo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (ModoOperacao)
            {
                case 1:
                    AdicionarFornecedor();
                    LimparDados();
                    break;
                case 2:
                    EditarFornecedor();
                    LimparDados();
                    break;
                default:
                    break;
            }
            ModoOperacao = 0;
            HabilitarCampos(false);
            Clique_dtgFornecedores();
        }

        private void tbIncluir_Click(object sender, EventArgs e)
        {
            ModoOperacao = 1;
            HabilitarCampos(true);
            LimparDados();

            btn01.Enabled = true;
            btn01.Text = "Salvar Fornecedor";
            btn02.Text = "Cancelar Inclusão";
        }

        private void tbAtualizar_Click(object sender, EventArgs e)
        {
            CarregarLista();

        }

        private void tbAlterar_Click(object sender, EventArgs e)
        {
            ModoOperacao = 2;
            HabilitarCampos(true);

            btn01.Enabled = true;
            btn01.Text = "Salvar Alteraçao";
            btn02.Text = "Cancelar Alteração";

        }

        private void tbExcluir_Click(object sender, EventArgs e)
        {
            DialogResult _MgsExcluir = MessageBox.Show("Deseja confirmar a exclusão do FOrnecedor?",
           "Excluir Fornecedor?",
           MessageBoxButtons.YesNo);

            if (_MgsExcluir == DialogResult.Yes)
            {
                ExcluirFornecedores();
            }
            Clique_dtgFornecedores();
        }

        private void btn01_Click(object sender, EventArgs e)
        {

            switch (ModoOperacao)
            {
                case 1:
                    AdicionarFornecedor();
                    ModoOperacao = 0;
                    LimparDados();
                    break;
                case 2:
                    EditarFornecedor();
                    ModoOperacao = 0;
                    LimparDados();
                    break;
                default:
                    break;
            }
            btn01.Enabled = false;
            btn01.Text = "Salvar";
            btn02.Text = "Sair";
            HabilitarCampos(false);
            Clique_dtgFornecedores();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            switch (ModoOperacao)
            {
                case 1:
                    
                    ModoOperacao = 0;
                    LimparDados();
                    break;
                case 2:
                    
                    ModoOperacao = 0;
                    LimparDados();
                    break;
                default:
                    DialogResult _MgsSair = MessageBox.Show("Deseja fechar a janela atual?",
                   "Fechar Janela?",
                   MessageBoxButtons.YesNo);

                    if (_MgsSair == DialogResult.Yes)
                    {
                        Close();
                    }
                    break;
            }
            btn01.Enabled = false;
            btn01.Text = "Salvar";
            btn02.Text = "Sair";
            HabilitarCampos(false);
            
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            Fornecedores _Fornecedor = new Fornecedores();
            BancoDados _bd = new BancoDados();

            IList<Fornecedores> RelProdutos = _Fornecedor._ListarTodos(_bd.StringConexao());


            DataTable _tabela = CriarDataTables(RelProdutos);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFornecedores", _tabela));
            this.reportViewer1.RefreshReport();
        }

        #endregion


        #region Funçoes Diversas

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


        void HabilitarCampos(bool selecao)
        {
            txtCNPJ.Enabled = selecao;
            txtContato.Enabled = selecao;
            txtEmail.Enabled = selecao;
            txtIE.Enabled = selecao;
            txtRazaoSocial.Enabled = selecao;
            txtTel.Enabled = selecao;
            txtCodigo.Enabled = selecao;

        }

        void LimparDados()
        {
            txtCNPJ.Clear();
            txtCodigo.Clear();
            txtEmail.Clear();
            txtIE.Clear();
            txtRazaoSocial.Clear();
            txtContato.Clear();
            txtTel.Clear();

        }

        #endregion


        #region CRUD

        void AdicionarFornecedor()
        {
            BancoDados bd = new BancoDados();
            Fornecedores fornecedor = new Fornecedores();

            fornecedor.E_CNPJ = txtCNPJ.Text;
            fornecedor.E_Contato = txtContato.Text;
            fornecedor.E_Email = txtEmail.Text;
            fornecedor.E_IE = txtIE.Text;
            fornecedor.E_RazaoSocial = txtRazaoSocial.Text;
            fornecedor.E_Tel = txtTel.Text;

            if (fornecedor._Adicionar(fornecedor, bd.StringConexao()))
            {
                MessageBox.Show("Fornecedor Cadastrado com Sucesso!");
                CarregarLista();
            }

            else
            {
                MessageBox.Show("Erro ao Cadastrar a Fornecedor...");
            }
        }

        void EditarFornecedor()
        {
            BancoDados bd = new BancoDados();
            Fornecedores fornecedor = new Fornecedores();

            fornecedor.E_Id = Convert.ToInt32(txtCodigo.Text);
            fornecedor.E_CNPJ = txtCNPJ.Text;
            fornecedor.E_Contato = txtContato.Text;
            fornecedor.E_Email = txtEmail.Text;
            fornecedor.E_IE = txtIE.Text;
            fornecedor.E_RazaoSocial = txtRazaoSocial.Text;
            fornecedor.E_Tel = txtTel.Text;

            if (fornecedor._Editar(fornecedor, bd.StringConexao()))
            {
                MessageBox.Show("Fornecedor Editado com Sucesso!");
                CarregarLista();
            }

            else
            {
                MessageBox.Show("Erro ao editar o Fornecedor...");
            }
        }

        void ExcluirFornecedores()
        {
            BancoDados bd = new BancoDados();
            Fornecedores fornecedor = new Fornecedores();

            if (fornecedor._Excluir(Convert.ToInt32(txtCodigo.Text), bd.StringConexao()))
            {
                MessageBox.Show("Fornecedor Excluído com Sucesso!");
                CarregarLista();
            }

            else
            {
                MessageBox.Show("Erro ao excluir o Fornecedor...");
            }
        }

        #endregion


        #region Datagrid

        void CarregarLista()
        {
            try
            {
                BancoDados bd = new BancoDados();
                Fornecedores _fornecedor = new Fornecedores();
                dtgFornecedores.AutoGenerateColumns = false;

                switch (cbxOrdenar.SelectedIndex)
                {

                    case 1:
                        // Fornecedor
                        if (rdbCresc.Checked)
                        {
                            dtgFornecedores.DataSource = _fornecedor._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.E_RazaoSocial).ToList();
                        }
                        else
                        {
                            dtgFornecedores.DataSource = _fornecedor._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.E_RazaoSocial).ToList();
                        }
                        break;
                    case 2:
                        // CNPJ
                        if (rdbCresc.Checked)
                        {
                            dtgFornecedores.DataSource = _fornecedor._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.E_CNPJ).ToList();
                        }
                        else
                        {
                            dtgFornecedores.DataSource = _fornecedor._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.E_CNPJ).ToList();
                        }
                        break;
                    default:
                        //Código 
                        if (rdbCresc.Checked)
                        {
                            dtgFornecedores.DataSource = _fornecedor._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.E_RazaoSocial).ToList();
                        }
                        else
                        {
                            dtgFornecedores.DataSource = _fornecedor._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.E_RazaoSocial).ToList();
                        }
                        break;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar a Distribuiçao...");
            }
        }

        void Clique_dtgFornecedores()
        {
            if (Liberado)
            {
                DataGridViewCell _celula = dtgFornecedores.CurrentCell;
                int _LinhadtgFornecedores = _celula.RowIndex;
                FornecedorSelecionado = Convert.ToInt32(dtgFornecedores.Rows[_LinhadtgFornecedores].Cells[0].Value);

                txtCodigo.Text = dtgFornecedores.Rows[_LinhadtgFornecedores].Cells[0].Value.ToString();
                txtRazaoSocial.Text = dtgFornecedores.Rows[_LinhadtgFornecedores].Cells[1].Value.ToString();
                txtCNPJ.Text = dtgFornecedores.Rows[_LinhadtgFornecedores].Cells[2].Value.ToString();
                txtIE.Text = dtgFornecedores.Rows[_LinhadtgFornecedores].Cells[3].Value.ToString();
                txtContato.Text = dtgFornecedores.Rows[_LinhadtgFornecedores].Cells[4].Value.ToString();
                txtContato.Text = dtgFornecedores.Rows[_LinhadtgFornecedores].Cells[5].Value.ToString();
                txtEmail.Text = dtgFornecedores.Rows[_LinhadtgFornecedores].Cells[6].Value.ToString();
            }
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void cbxPesquisar_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void dtgFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clique_dtgFornecedores();
        }

        #endregion

      

       

   











    }
}
