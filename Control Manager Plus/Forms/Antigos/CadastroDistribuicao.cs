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
    public partial class frmCadDistribuicao1 : Form
    {
        int _codDistribuicao = 0;
       
        
        public frmCadDistribuicao1()
        {
            InitializeComponent();
            CarregarGrid();
        }



        void CarregarGrid()
        {
            try
            {
                BancoDados bd = new BancoDados();
                Distribuicao Dist = new Distribuicao();
                dtgDistribuicao.AutoGenerateColumns = false;

                switch (cbxOrdenar_dtgDist.SelectedIndex)
                {

                    case 1:
                        // por data
                        if (rdbCrescente.Checked)
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text,cbxPesquisarPor.SelectedIndex, bd.StringConexao()).OrderBy(x => x.Dis_DataDefinida).ToList();
                        }
                        else
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisarPor.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.Dis_DataDefinida).ToList();
                        }   
                        break;
                    case 2:
                        // por valor
                        if (rdbCrescente.Checked)
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisarPor.SelectedIndex, bd.StringConexao()).OrderBy(x => x.Dis_Total).ToList();
                        }
                        else
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisarPor.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.Dis_Total).ToList();
                        }   
                        break;
                    case 3:
                        //Operador
                        if (rdbCrescente.Checked)
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisarPor.SelectedIndex, bd.StringConexao()).OrderBy(x => x.Dis_Operador).ToList();
                        }
                        else
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisarPor.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.Dis_Operador).ToList();
                        }   
                        break;

                    default:
                        //Padrão.... por id
                        if (rdbCrescente.Checked)
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisarPor.SelectedIndex, bd.StringConexao()).OrderBy(x => x.Dis_Id).ToList();
                        }
                        else
                        {
                            dtgDistribuicao.DataSource = Dist._PesquisaCampos(txtConsulta.Text, cbxPesquisarPor.SelectedIndex, bd.StringConexao()).OrderByDescending(x => x.Dis_Id).ToList();
                        }                        
                        break;
                }  

                


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar a Distribuiçao...");
            }
        }

        private void dtgLojas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clique_dtgDistribuicao();
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

        private void tbIncluir_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm is frmDistribuicaoLojas) //mudar apenas o  FrmProdutoSelecionar o frm não alterar
                {
                    frm.BringToFront(); //aqui não altere nada
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmDistribuicaoLojas(0, 1); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
                frm.MdiParent = this.MdiParent; //aqui não altere nada
                frm.Show(); //aqui não altere nada
            }
        }

        private void frmCadDistribuicao_Load(object sender, EventArgs e)
        {
            cbxOrdenar_dtgDist.SelectedIndex = 0;       
            cbxPesquisarPor.SelectedIndex = 0;
            
            
            if (dtgDistribuicao.RowCount > 0)
            {
                Clique_dtgDistribuicao();              
            }

            
            
        }

        private void cbxOrdenar_dtgDist_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void rdbCrescente_Click(object sender, EventArgs e)
        {
            CarregarGrid(); 
        }

        private void rdbDecrescente_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid(); 
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid(); 
        }

        public void ExibirNovaDistribuicao()
        {
            cbxOrdenar_dtgDist.SelectedIndex = 0;
            cbxPesquisarPor.SelectedIndex = 0;
            CarregarGrid(); 
        }

        private void tbAlterar_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm is frmDistribuicaoLojas) //mudar apenas o  FrmProdutoSelecionar o frm não alterar
                {
                    frm.BringToFront(); //aqui não altere nada
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmDistribuicaoLojas(_codDistribuicao, 2); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
                frm.MdiParent = this.MdiParent; //aqui não altere nada
                frm.Show(); //aqui não altere nada
            }
        }

        private void tbExcluir_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm is frmDistribuicaoLojas) //mudar apenas o  FrmProdutoSelecionar o frm não alterar
                {
                    frm.BringToFront(); //aqui não altere nada
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmDistribuicaoLojas(_codDistribuicao, 3); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
                frm.MdiParent = this.MdiParent; //aqui não altere nada
                frm.Show(); //aqui não altere nada
            }
        }

        private void tbAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
