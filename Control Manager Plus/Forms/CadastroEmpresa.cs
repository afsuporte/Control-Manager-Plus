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
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
            CarregarLista();
            Desabilitarcampos();
            
        }

        
        void CadastrarEmpresa()
        {
            BancoDados bd = new BancoDados();
            Empresa empresa = new Empresa();

            empresa.E_CNPJ = txtCNPJ.Text;
            empresa.E_Complemento = txtComplemento.Text;
            empresa.E_Email = txtEmail.Text;
            empresa.E_Endereco = txtEnd.Text;
            empresa.E_Estado = txtUF.Text;
            //empresa.E_Id = Convert.ToInt32(txtCodigo.Text);
            empresa.E_IE = txtIE.Text;
            empresa.E_RazaoSocial = txtRazaoSocial.Text;
            empresa.E_Telefone = txtTel.Text;

            if (empresa._Adicionar(empresa, bd.StringConexao()))
            {
                MessageBox.Show("Empresa Cadastrada com Sucesso!");
                LimparDados();
                CarregarLista();
            }

            else
            {
                MessageBox.Show("Erro ao Cadastrar a Empresa...");
            }

        }

        public void CarregarLista()
        {
            try
            {
                Empresa empresa = new Empresa();
                BancoDados bd = new BancoDados();
                dtgEmpresa.AutoGenerateColumns = false;
                dtgEmpresa.DataSource = empresa._ListarTodos(bd.StringConexao()).OrderBy(x => x.E_RazaoSocial).ToList();


            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Listar a Empresa...");
            }

        }

        void HabilitarCampos()
        {
            txtCNPJ.Enabled = true;
            txtCodigo.Enabled = true;
            txtComplemento.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtUF.Enabled = true;
            txtIE.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtTel.Enabled = true;
        }

        void Desabilitarcampos()
        {
            txtCNPJ.Enabled = false;
            txtCodigo.Enabled = false;
            txtComplemento.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtUF.Enabled = false;
            txtIE.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtTel.Enabled = false;

        }
        
        void LimparDados()
        {
            txtCNPJ.Clear();
            txtCodigo.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtEnd.Clear();
            txtUF.Clear();
            txtIE.Clear();
            txtRazaoSocial.Clear();
            txtTel.Clear();


        }

        #region Sequencia de ENTER


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarEmpresa();
        }

        private void btnLimparInformacoes_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void tbVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbIncluir_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtRazaoSocial.Select();
        }

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCNPJ.Focus();
        }

        private void txtIE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEnd.Focus();
        }

        private void txtCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtIE.Focus();
        }

        private void txtEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtComplemento.Focus();

        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtUF.Focus();
        }

        private void txtUF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTel.Focus();
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEmail.Focus();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSalvar.Focus();

        }

# endregion

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        

    }
}
