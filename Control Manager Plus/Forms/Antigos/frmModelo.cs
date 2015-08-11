using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Manager_Plus.Forms.Produto
{
    public partial class frmModelo : Form
    {
        public frmModelo()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void tbImprimir_Click(object sender, EventArgs e)
        {
            bool ativo = splitContainer1.Panel1Collapsed;

            

            splitContainer1.Panel1Collapsed = !ativo;
            splitContainer1.Panel2Collapsed = ativo;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
