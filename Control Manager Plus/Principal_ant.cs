using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Control_Manager_Plus.Classes;

using Control_Manager_Plus.FRM;
using Control_Manager_Plus.Forms;





namespace Control_Manager_Plus
{
    public partial class frmPrincipal1 : Form
    {
        public frmPrincipal1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
                bool open = false;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCadastroLojas) //mudar apenas o  FrmProdutoSelecionar o frm não alterar
                    {
                        frm.BringToFront(); //aqui não altere nada
                        open = true;
                    }
                }
                if (!open)
                {
                    Form frm = new frmCadastroLojas(); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
                    frm.MdiParent = this; //aqui não altere nada
                    frm.Show(); //aqui não altere nada
                }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadastroFornecedores) //mudar apenas o  FrmProdutoSelecionar o frm não alterar
                {
                    frm.BringToFront(); //aqui não altere nada
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmCadastroFornecedores(); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
                frm.MdiParent = this; //aqui não altere nada
                frm.Show(); //aqui não altere nada
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadastroProduto) //mudar apenas o  FrmProdutoSelecionar o frm não alterar
                {
                    frm.BringToFront(); //aqui não altere nada
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmCadastroProduto(); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
                frm.MdiParent = this; //aqui não altere nada
                frm.Show(); //aqui não altere nada
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            VerificarConexao();

        }

        void VerificarConexao()
        {
            // Teste de conexão com a Base de Dados
            BancoDados Bdados = new BancoDados();

            if (Bdados.CriarBaseDados())
            {
                // MessageBox.Show("Banco de Dados Ok");
            }
            else
            {
                MessageBox.Show("Erro no Banco de Dados");
            }

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            DialogResult Sair = MessageBox.Show("Deseja Fechar o Sistema?",
               "Sair do Sistema?",
               MessageBoxButtons.YesNo);

            if (Sair == DialogResult.Yes)

                Application.Exit();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEmpresa Empresa = new frmCadEmpresa();
            Empresa.MdiParent = this;
            Empresa.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadDistribuicao) //mudar apenas o  FrmProdutoSelecionar o frm não alterar
                {
                    frm.BringToFront(); //aqui não altere nada
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmCadDistribuicao(); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
                frm.MdiParent = this; //aqui não altere nada
                frm.Show(); //aqui não altere nada
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form frm = new Forms.Produto.frmModelo(); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
            frm.MdiParent = this; //aqui não altere nada
            frm.Show(); //aqui não altere nada
        }

        private void lojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    //menuStripPrincipal

        //    Form frm = new frmCadastroLojas(); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
        //    frm.MdiParent = this; //aqui não altere nada
        //    frm.Show(); //aqui não altere nada
        //}

        //private void toolStripButton5_Click(object sender, EventArgs e)
        //{
        //    Form frm = new Relatorio.frmProdutos(); //mudar apenas o  FrmProdutoSelecionar o Form e o frm não alterar
        //    frm.MdiParent = this; //aqui não altere nada
        //    frm.Show(); //aqui não altere nada
        }

    }
}
