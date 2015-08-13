using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Control_Manager_Plus.Forms;
using Control_Manager_Plus.Classes;


namespace Control_Manager_Plus
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
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

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }






        
        #region Botões da Barra de Ferramentas

        private void toolStrip_Lojas_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadLojas)
                {
                    frm.WindowState = FormWindowState.Maximized;
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmCadLojas();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void toolStrip_Produtos_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadProdutos)
                {
                    frm.WindowState = FormWindowState.Maximized;
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmCadProdutos();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void toolStrip_Distribuicao_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadDistribuicao)
                {
                    frm.WindowState = FormWindowState.Maximized;
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmCadDistribuicao();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void toolStrip_Fornecedores_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmCadFornecedores)
                {
                    frm.WindowState = FormWindowState.Maximized;
                    frm.BringToFront();
                    open = true;
                }
            }
            if (!open)
            {
                Form frm = new frmCadFornecedores();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void toolStrip_Financeiro_Click(object sender, EventArgs e)
        {
            Form frm = new frmDistribuicaoPorLoja();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void toolStrip_Relatorios_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_Manutencao_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_Sair_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja Fechar o Sistema?",
              "Sair do Sistema?",
              MessageBoxButtons.YesNo);

            if (Sair == DialogResult.Yes)

                Application.Exit();  
        }

        #endregion

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void vendasPorFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relatorio de Vendas por Fornecedor");
        }

        private void vendasPorLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relatorio de Vendas por Lojas");
        }

       

    }
}
