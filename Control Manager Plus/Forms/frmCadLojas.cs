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
    public partial class frmCadLojas : Form
    {
        int LojaSelecionada = 0;
        int ModoOperacao = 0;
        bool Liberado = false;

        public frmCadLojas()
        {
            InitializeComponent();
            HabilitarCampos(false);            
            cbxPesquisar.SelectedIndex = 0;
            cbxOrdenar.SelectedIndex = 1;
        }

        private void frmCadLojas_Load(object sender, EventArgs e)
        {
            CarregarLista();
            Liberado = true;

            if (dtgLojas.RowCount > 0)
            {
                Clique_dtgLojas();
            }

            
        }


        #region Botões

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (ModoOperacao)
            {
                case 1:
                    CadastrarLojas();
                    LimparDados();
                    break;
                case 2:
                    EditarLojas();
                    LimparDados();
                    break;
                default:
                    break;
            }
            ModoOperacao = 0;
            HabilitarCampos(false);
            Clique_dtgLojas();
        }

        private void btnLimparInformacoes_Click(object sender, EventArgs e)
        {

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
            DialogResult _MgsExcluir = MessageBox.Show("Deseja confirmar a exclusão da Loja?",
            "Excluir Loja?",
            MessageBoxButtons.YesNo);

            if (_MgsExcluir == DialogResult.Yes)
            {
                ExcluirLojas();
            }
            Clique_dtgLojas();
        }

        private void tbAtualizar_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void tbVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn01_Click(object sender, EventArgs e)
        {

            switch (ModoOperacao)
            {
                case 1:
                    CadastrarLojas();
                    ModoOperacao = 0;
                    LimparDados();
                    break;
                case 2:
                    EditarLojas();
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
            Clique_dtgLojas();
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

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            Lojas _Loja = new Lojas();
            BancoDados _bd = new BancoDados();

            IList<Lojas> RelProdutos = _Loja._ListarTodos(_bd.StringConexao());


            DataTable _tabela = CriarDataTables(RelProdutos);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _tabela));
            this.reportViewer1.RefreshReport();
        }

   

        #endregion


        #region Funções Diversas

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
            txtCodigo.Enabled = selecao;
            txtEmail.Enabled = selecao;
            txtNomeLoja.Enabled = selecao;
            txtResponsavel.Enabled = selecao;
            txtTelefone.Enabled = selecao;
            txtNomeLoja.Select();
        }

        void LimparDados()
        {
            txtCodigo.Clear();
            txtEmail.Clear();
            txtNomeLoja.Clear();
            txtResponsavel.Clear();
            txtTelefone.Clear();

        }

        #endregion


        #region CRUD

        void CadastrarLojas()
        {
            BancoDados bd = new BancoDados();
            Lojas loja = new Lojas();

            loja.L_Email = txtEmail.Text;
            loja.L_Loja = txtNomeLoja.Text;
            loja.L_Responsavel = txtResponsavel.Text;
            loja.L_Telefone = txtTelefone.Text;

            if (loja._Adicionar(loja, bd.StringConexao()))
            {
                MessageBox.Show("Loja Cadastrada com Sucesso!");
                CarregarLista();
            }

            else
            {
                MessageBox.Show("Erro ao Cadastrar Produtos...");
            }
        }

        void EditarLojas()
        {
            BancoDados bd = new BancoDados();
            Lojas loja = new Lojas();

            loja.L_Id = Convert.ToInt32(txtCodigo.Text);
            loja.L_Email = txtEmail.Text;
            loja.L_Loja = txtNomeLoja.Text;
            loja.L_Responsavel = txtResponsavel.Text;
            loja.L_Telefone = txtTelefone.Text;

            if (loja._Editar(loja, bd.StringConexao()))
            {
                MessageBox.Show("Loja Editada com Sucesso!");
                CarregarLista();
            }

            else
            {
                MessageBox.Show("Erro ao Editar Loja...");
            }
        }

        void ExcluirLojas()
        {
            BancoDados bd = new BancoDados();
            Lojas loja = new Lojas();
            loja.L_Id = Convert.ToInt32(txtCodigo.Text);

            if (loja._Excluir(loja.L_Id, bd.StringConexao()))
            {
                MessageBox.Show("Loja Excluída com Sucesso!");
                CarregarLista();
            }

            else
            {
                MessageBox.Show("Erro ao Excluir Loja...");
            }
        }

        #endregion


        #region Datagrid

        void CarregarLista()
        {
            try
            {
                BancoDados bd = new BancoDados();
                Lojas _loja = new Lojas();
                dtgLojas.AutoGenerateColumns = false;

                switch (cbxOrdenar.SelectedIndex)
                {

                    case 1:
                        // Código
                        if (rdbCresc.Checked)
                        {
                            dtgLojas.DataSource = _loja._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.L_Loja).ToList();
                        }
                        else
                        {
                            dtgLojas.DataSource = _loja._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.L_Loja).ToList();
                        }
                        break;
                    case 2:
                        // Loja
                        if (rdbCresc.Checked)
                        {
                            dtgLojas.DataSource = _loja._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.L_Responsavel).ToList();
                        }
                        else
                        {
                            dtgLojas.DataSource = _loja._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.L_Responsavel).ToList();
                        }
                        break;
                    default:
                        //Responsavel
                        if (rdbCresc.Checked)
                        {
                            dtgLojas.DataSource = _loja._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.L_Id).ToList();
                        }
                        else
                        {
                            dtgLojas.DataSource = _loja._PesquisarCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.L_Id).ToList();
                        }
                        break;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar a Distribuiçao...");
            }
        }

        void Clique_dtgLojas()
        {
            if (Liberado)
            {
                DataGridViewCell _celula = dtgLojas.CurrentCell;
                int _LinhadtgLojas = _celula.RowIndex;
                LojaSelecionada = Convert.ToInt32(dtgLojas.Rows[_LinhadtgLojas].Cells[0].Value);

                txtCodigo.Text = dtgLojas.Rows[_LinhadtgLojas].Cells[0].Value.ToString();
                txtNomeLoja.Text = dtgLojas.Rows[_LinhadtgLojas].Cells[1].Value.ToString();
                txtResponsavel.Text = dtgLojas.Rows[_LinhadtgLojas].Cells[2].Value.ToString();
                txtTelefone.Text = dtgLojas.Rows[_LinhadtgLojas].Cells[3].Value.ToString();
                txtEmail.Text = dtgLojas.Rows[_LinhadtgLojas].Cells[4].Value.ToString();

            }
        }

        private void dtgLojas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clique_dtgLojas();
        }

        private void cbxPesquisar_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }




        #endregion

 



    }
}
