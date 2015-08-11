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

namespace Control_Manager_Plus.Forms
{
    public partial class frmCadDistribuicao : Form
    {
        int _codDistribuicao = 0;
        int ModoOperacao = 0;
        bool Liberado = false;
        public frmCadDistribuicao()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void frmCadDistribuicao_Load(object sender, EventArgs e)
        {
            cbxOrdenar.SelectedIndex = 0;
            cbxPesquisar.SelectedIndex = 0;


            if (dtgDistribuicao.RowCount > 0)
            {
                Clique_dtgDistribuicao();
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
            Clique_dtgDistribuicao();
        }

        private void btnLimparInformacoes_Click(object sender, EventArgs e)
        {

        }

        private void tbIncluir_Click(object sender, EventArgs e)
        {
            //ModoOperacao = 1;
            //HabilitarCampos(true);
            //LimparDados();

            //btn01.Enabled = true;
            //btn01.Text = "Salvar Fornecedor";
            //btn02.Text = "Cancelar Inclusão";

            bool open = false;
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm is frmDistribuicaoLojas) 
                {
                    frm.WindowState = FormWindowState.Maximized;
                    frm.BringToFront(); 
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmDistribuicaoLojas(0, 1); 
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this.MdiParent; 
                frm.Show(); 
            }







        }

        private void tbAlterar_Click(object sender, EventArgs e)
        {
            //ModoOperacao = 2;
            //HabilitarCampos(true);

            //btn01.Enabled = true;
            //btn01.Text = "Salvar Alteraçao";
            //btn02.Text = "Cancelar Alteração";

            bool open = false;
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm is frmDistribuicaoLojas) 
                {
                    frm.WindowState = FormWindowState.Maximized;
                    frm.BringToFront(); 
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmDistribuicaoLojas(_codDistribuicao, 2); 
                frm.MdiParent = this.MdiParent; 
                frm.Show(); 
            }
        }

        private void tbExcluir_Click(object sender, EventArgs e)
        {
            //DialogResult _MgsExcluir = MessageBox.Show("Deseja confirmar a exclusão da Loja?",
            //"Excluir Loja?",
            //MessageBoxButtons.YesNo);

            //if (_MgsExcluir == DialogResult.Yes)
            //{
            //    ExcluirLojas();
            //}
            //Clique_dtgDistribuicao();

            bool open = false;
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm is frmDistribuicaoLojas) 
                {
                    frm.WindowState = FormWindowState.Maximized;
                    frm.BringToFront(); 
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmDistribuicaoLojas(_codDistribuicao, 3);
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this.MdiParent; 
                frm.Show(); 
            }
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
            Clique_dtgDistribuicao();
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


        #endregion


        #region Funções Diversas

        void HabilitarCampos(bool selecao)
        {
            //txtCodigo.Enabled = selecao;
            //txtEmail.Enabled = selecao;
            //txtNomeLoja.Enabled = selecao;
            //txtResponsavel.Enabled = selecao;
            //txtTelefone.Enabled = selecao;
            //txtNomeLoja.Select();
        }

        void LimparDados()
        {
            //txtCodigo.Clear();
            //txtEmail.Clear();
            //txtNomeLoja.Clear();
            //txtResponsavel.Clear();
            //txtTelefone.Clear();

        }

        #endregion


        #region CRUD

        void CadastrarLojas()
        {
            //BancoDados bd = new BancoDados();
            //Lojas loja = new Lojas();

            //loja.L_Email = txtEmail.Text;
            //loja.L_Loja = txtNomeLoja.Text;
            //loja.L_Responsavel = txtResponsavel.Text;
            //loja.L_Telefone = txtTelefone.Text;

            //if (loja._Adicionar(loja, bd.StringConexao()))
            //{
            //    MessageBox.Show("Loja Cadastrada com Sucesso!");
            //    CarregarLista();
            //}

            //else
            //{
            //    MessageBox.Show("Erro ao Cadastrar Produtos...");
            //}
        }

        void EditarLojas()
        {
            //BancoDados bd = new BancoDados();
            //Lojas loja = new Lojas();

            //loja.L_Id = Convert.ToInt32(txtCodigo.Text);
            //loja.L_Email = txtEmail.Text;
            //loja.L_Loja = txtNomeLoja.Text;
            //loja.L_Responsavel = txtResponsavel.Text;
            //loja.L_Telefone = txtTelefone.Text;

            //if (loja._Editar(loja, bd.StringConexao()))
            //{
            //    MessageBox.Show("Loja Editada com Sucesso!");
            //    CarregarLista();
            //}

            //else
            //{
            //    MessageBox.Show("Erro ao Editar Loja...");
            //}
        }

        void ExcluirLojas()
        {
            //BancoDados bd = new BancoDados();
            //Lojas loja = new Lojas();
            //loja.L_Id = Convert.ToInt32(txtCodigo.Text);

            //if (loja._Excluir(loja.L_Id, bd.StringConexao()))
            //{
            //    MessageBox.Show("Loja Excluída com Sucesso!");
            //    CarregarLista();
            //}

            //else
            //{
            //    MessageBox.Show("Erro ao Excluir Loja...");
            //}
        }

        #endregion


        #region Datagrid

     
        void CarregarLista()
        {
            try
            {
                BancoDados bd = new BancoDados();
                Distribuicao Dist = new Distribuicao();
                dtgDistribuicao.AutoGenerateColumns = false;

                switch (cbxOrdenar.SelectedIndex)
                {

                    case 1:
                        // por data
                        if (rdbCresc.Checked)
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.Dis_DataDefinida).ToList();
                        }
                        else
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.Dis_DataDefinida).ToList();
                        }
                        break;
                    case 2:
                        // por valor
                        if (rdbCresc.Checked)
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.Dis_Total).ToList();
                        }
                        else
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.Dis_Total).ToList();
                        }
                        break;
                    case 3:
                        //Operador
                        if (rdbCresc.Checked)
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.Dis_Operador).ToList();
                        }
                        else
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.Dis_Operador).ToList();
                        }
                        break;

                    default:
                        //Padrão.... por id
                        if (rdbCresc.Checked)
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderBy(x => x.Dis_Id).ToList();
                        }
                        else
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisar.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.Dis_Id).ToList();
                        }
                        break;
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar a Distribuiçao...");
            }
        }


        void Clique_dtgDistribuicao()
        {
            DataGridViewCell _celula = dtgDistribuicao.CurrentCell;
            int _ColunadtgDistribuicao = _celula.ColumnIndex;
            int _LinhadtgDistribuicao = _celula.RowIndex;

            _codDistribuicao = Convert.ToInt32(dtgDistribuicao.Rows[_LinhadtgDistribuicao].Cells[0].Value);
            txtCodigo.Text = String.Format("{0:000000}", dtgDistribuicao.Rows[_LinhadtgDistribuicao].Cells[0].Value);
            txtCodigo.Text = String.Format("{0:000000}", _codDistribuicao);
            txtData.Text = dtgDistribuicao.Rows[_LinhadtgDistribuicao].Cells[1].Value.ToString();
            txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", dtgDistribuicao.Rows[_LinhadtgDistribuicao].Cells[2].Value);// dtgDistribuicao.Rows[_LinhadtgDistribuicao].Cells[2].Value.ToString();
            txtResponsavel.Text = dtgDistribuicao.Rows[_LinhadtgDistribuicao].Cells[3].Value.ToString();
        }


        private void dtgLojas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clique_dtgDistribuicao();
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
