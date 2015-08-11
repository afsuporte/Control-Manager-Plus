using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Control_Manager_Plus.Classes.Relatorios
{
    public class RelatorioDetalheDistribuicao
    {
        #region Propriedades

        // Código Interno (Chave Primária)
        private int rdd_id;
        public int RDD_Id
        {
            get { return rdd_id; }
            set { rdd_id = value; }
        }
        // Código da Distribuição
        private int rdd_coddistribuicao;
        public int RDD_CodDistribuicao
        {
            get { return rdd_coddistribuicao; }
            set { rdd_coddistribuicao = value; }
        }
        // Loja - Nome
        private string rdd_lojanome;
        public string RDD_LojaNome
        {
            get { return rdd_lojanome; }
            set { rdd_lojanome = value; }
        }
        // Loja - Codigo
        private int rdd_lojacod;
        public int RDD_LojaCod
        {
            get { return rdd_lojacod; }
            set { rdd_lojacod = value; }
        }
        // Loja - Responsavel
        private string rdd_lojaresponsavel;
        public string RDD_LojaResponsavel
        {
            get { return rdd_lojaresponsavel; }
            set { rdd_lojaresponsavel = value; }
        }
        // Produto- Código
        private int rdd_prodcodigo;
        public int RDD_ProdCodigo
        {
            get { return rdd_prodcodigo; }
            set { rdd_prodcodigo = value; }
        }
        // Produto- Nome
        private string rdd_prodnome;
        public string RDD_ProdNome
        {
            get { return rdd_prodnome; }
            set { rdd_prodnome = value; }
        }
        // Produto- Valor unitário
        private decimal rdd_prodvalorunid;
        public decimal RDD_ProdValorUnid
        {
            get { return rdd_prodvalorunid; }
            set { rdd_prodvalorunid = value; }
        }
        // Produto- Qtde
        private int rdd_prodqtde;
        public int RDD_ProdQtde
        {
            get { return rdd_prodqtde; }
            set { rdd_prodqtde = value; }
        }
        // Produto- Valor Total
        private decimal rdd_prodvalortotal;
        public decimal RDD_ProdValorTotal
        {
            get { return rdd_prodvalortotal; }
            set { rdd_prodvalortotal = value; }
        }
        // Fornecedor - Código
        private int rdd_fornecedorcod;
        public int RDD_FornecedorCod
        {
            get { return rdd_fornecedorcod; }
            set { rdd_fornecedorcod = value; }
        }
        // Fornecedor - Nome
        private string rdd_fornecedornome;
        public string RDD_FornecedorNome
        {
            get { return rdd_fornecedornome; }
            set { rdd_fornecedornome = value; }
        }
        // Fornecedor - Valor
        private decimal rdd_fornecedorvalor;
        public decimal RDD_FornecedorValor
        {
            get { return rdd_fornecedorvalor; }
            set { rdd_fornecedorvalor = value; }
        }
        #endregion


        #region Funções


        public IList<RelatorioDetalheDistribuicao> _ListarDetalheDistribuicao(int CodDistribuicao,string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                if (conexao.State == ConnectionState.Open)
                {
                    IList<RelatorioDetalheDistribuicao> ListadeDistDetalhe = new ObservableCollection<RelatorioDetalheDistribuicao>();
                    string _sqltxt =  " select DistD_CodDistribuicao,"
                                    + " DistD_CodProduto, DistD_NomeProduto, DistD_ProdutoValorUnid, DistD_ProdutoQtde, DistD_ProdutoValorTotal,"
                                    + " L_id, L_Loja, L_Responsavel,"
                                    + " E_Id, E_RazaoSocial, DistD_FornecedorValor"
                                    + " from distribuicaodetalhe "
                                    + " inner join Loja on Loja.L_Id = distribuicaodetalhe.DistD_CodLoja"
                                    + " inner join Fornecedor on Fornecedor.E_Id = distribuicaodetalhe.DistD_CodFornecedor"
                                    + " where DistD_CodDistribuicao = " + CodDistribuicao + " ;";

                    int Cont = 1;
                    var sql = new MySqlCommand(_sqltxt, conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        RelatorioDetalheDistribuicao _distdetalhe = new RelatorioDetalheDistribuicao();
                        // Propriedades da Classe

                            _distdetalhe.RDD_Id = Cont++;

                        if (MySqlDR["DistD_CodDistribuicao"] != DBNull.Value)
                            _distdetalhe.RDD_CodDistribuicao = Convert.ToInt32(MySqlDR["DistD_CodDistribuicao"]);

                        //LOJA
                        if (MySqlDR["L_Id"] != DBNull.Value)
                            _distdetalhe.RDD_LojaCod = Convert.ToInt32(MySqlDR["L_Id"]);


                        if (MySqlDR["L_Loja"] != DBNull.Value)
                            _distdetalhe.RDD_LojaNome = MySqlDR["L_Loja"].ToString();

                        if (MySqlDR["L_Responsavel"] != DBNull.Value)
                            _distdetalhe.RDD_LojaResponsavel = MySqlDR["L_Responsavel"].ToString();


                        //PRODUTO
                        if (MySqlDR["DistD_CodProduto"] != DBNull.Value)
                            _distdetalhe.RDD_ProdCodigo = Convert.ToInt32(MySqlDR["DistD_CodProduto"]);
                        if (MySqlDR["DistD_NomeProduto"] != DBNull.Value)
                            _distdetalhe.RDD_ProdNome = MySqlDR["DistD_NomeProduto"].ToString();
                        if (MySqlDR["DistD_ProdutoValorUnid"] != DBNull.Value)
                            _distdetalhe.RDD_ProdValorUnid = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorUnid"]);
                        if (MySqlDR["DistD_ProdutoQtde"] != DBNull.Value)
                            _distdetalhe.RDD_ProdQtde = Convert.ToInt32(MySqlDR["DistD_ProdutoQtde"]);
                        if (MySqlDR["DistD_ProdutoValorTotal"] != DBNull.Value)
                            _distdetalhe.RDD_ProdValorTotal = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorTotal"]);

                        //FORNECEDORES
                        if (MySqlDR["E_id"] != DBNull.Value)
                            _distdetalhe.RDD_FornecedorCod = Convert.ToInt32(MySqlDR["E_id"]);


                        if (MySqlDR["E_RazaoSocial"] != DBNull.Value)
                            _distdetalhe.RDD_FornecedorNome = MySqlDR["E_RazaoSocial"].ToString();
                        if (MySqlDR["DistD_FornecedorValor"] != DBNull.Value)
                            _distdetalhe.RDD_FornecedorValor = Convert.ToDecimal(MySqlDR["DistD_FornecedorValor"]);
                        
                        
                        
                        
                        
                        // Fim das Propriedades
                        ListadeDistDetalhe.Add(_distdetalhe);
                    }
                    return ListadeDistDetalhe;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }



        #endregion


    }
}
