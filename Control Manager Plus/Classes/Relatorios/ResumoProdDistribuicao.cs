using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Control_Manager_Plus.Classes.Relatorios
{
    public class ResumoProdDistribuicao
    {

        /*

   SELECT *, SUM(DistD_ProdutoQtde)
   FROM distribuicaodetalhe 
   where DistD_CodDistribuicao = 1
   group by DistD_CodProduto;

   */

        #region Propriedades

        // Código Interno (Chave Primária)
        private int dre_id;
        public int Dre_Id
        {
            get { return dre_id; }
            set { dre_id = value; }
        }

        private int dre_codproduto;
        public int Dre_CodProduto
        {
            get { return dre_codproduto; }
            set { dre_codproduto = value; }
        }

        private string dre_nomeproduto;
        public string Dre_NomeProduto
        {
            get { return dre_nomeproduto; }
            set { dre_nomeproduto = value; }
        }

        private decimal dre_prodvalorunid;
        public decimal Dre_ProdValorUnid
        {
            get { return dre_prodvalorunid; }
            set { dre_prodvalorunid = value; }
        }

        private int dre_prodqtde;
        public int Dre_ProdQtde
        {
            get { return dre_prodqtde; }
            set { dre_prodqtde = value; }
        }

        private decimal dre_prodvalortotal;
        public decimal Dre_ProdValorTotal
        {
            get { return dre_prodvalortotal; }
            set { dre_prodvalortotal = value; }
        }

        private decimal dre_valordistribuidor;
        public decimal Dre_ValorDistribuidor
        {
            get { return dre_valordistribuidor; }
            set { dre_valordistribuidor = value; }
        }

        private int dre_coddistribuidor;
        public int Dre_CodDistribuidor
        {
            get { return dre_coddistribuidor; }
            set { dre_coddistribuidor = value; }
        }

        private string dre_nomeFornecedor;
        public string Dre_NomeFornecedor
        {
            get { return dre_nomeFornecedor; }
            set { dre_nomeFornecedor = value; }
        }





        #endregion


        #region Funções


        public IList<ResumoProdDistribuicao> _RelatorioPorDistribuicao(int CodDistribuicao, string stringConnect)
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
                    IList<ResumoProdDistribuicao> ListadeDistDetalhe = new ObservableCollection<ResumoProdDistribuicao>();
                    var sql = new MySqlCommand("SELECT DistD_CodProduto, DistD_NomeProduto, DistD_ProdutoValorUnid,SUM(DistD_ProdutoQtde) as DistD_ProdutoQtde, SUM(DistD_ProdutoValorTotal) as DistD_ProdutoValorTotal, SUM(DistD_FornecedorValor) as DistD_FornecedorValor, DistD_CodFornecedor, E_RazaoSocial FROM distribuicaodetalhe inner join Fornecedor on Fornecedor.E_Id = distribuicaodetalhe.DistD_CodFornecedor where DistD_CodDistribuicao = " + CodDistribuicao.ToString() + " group by DistD_CodProduto;", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    int Id = 1;
                    while (MySqlDR.Read())
                    {
                        ResumoProdDistribuicao _distdetalhe = new ResumoProdDistribuicao();
                        // Propriedades da Classe
                        _distdetalhe.Dre_Id = Id++;
                        if (MySqlDR["DistD_CodProduto"] != DBNull.Value)
                            _distdetalhe.Dre_CodProduto = Convert.ToInt32(MySqlDR["DistD_CodProduto"]);
                        if (MySqlDR["DistD_NomeProduto"] != DBNull.Value)
                            _distdetalhe.Dre_NomeProduto = MySqlDR["DistD_NomeProduto"].ToString();
                        if (MySqlDR["DistD_ProdutoValorUnid"] != DBNull.Value)
                            _distdetalhe.Dre_ProdValorUnid = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorUnid"]);
                        if (MySqlDR["DistD_ProdutoQtde"] != DBNull.Value)
                            _distdetalhe.Dre_ProdQtde = Convert.ToInt32(MySqlDR["DistD_ProdutoQtde"]);
                        if (MySqlDR["DistD_ProdutoValorTotal"] != DBNull.Value)
                            _distdetalhe.Dre_ProdValorTotal = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorTotal"]);
                        if (MySqlDR["DistD_FornecedorValor"] != DBNull.Value)
                            _distdetalhe.Dre_ValorDistribuidor = Convert.ToDecimal(MySqlDR["DistD_FornecedorValor"]);
                        if (MySqlDR["DistD_CodFornecedor"] != DBNull.Value)
                            _distdetalhe.Dre_CodDistribuidor = Convert.ToInt32(MySqlDR["DistD_CodFornecedor"]);
                        if (MySqlDR["E_RazaoSocial"] != DBNull.Value)
                            _distdetalhe.Dre_NomeFornecedor = MySqlDR["E_RazaoSocial"].ToString();

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
