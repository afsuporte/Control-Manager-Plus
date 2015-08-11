using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Control_Manager_Plus.Classes
{
    public class DistDetalhe
    {
        #region Propriedades
        // Código Interno (Chave Primária)
        private int distd_id;
        public int DistD_Id
        {
            get { return distd_id; }
            set { distd_id = value; }
        }
        // Código de identificação da Distribuicao
        private int distd_coddistribuicao;
        public int DistD_CodDistribuicao
        {
            get { return distd_coddistribuicao; }
            set { distd_coddistribuicao = value; }
        }
        // Código de identificação do Produto
        private int distd_codproduto;
        public int DistD_CodProduto
        {
            get { return distd_codproduto; }
            set { distd_codproduto = value; }
        }
        // Código de identificação da Loja
        private int distd_codloja;
        public int DistD_CodLoja
        {
            get { return distd_codloja; }
            set { distd_codloja = value; }
        }
        // String contendo o nome do produto
        private string distd_nomeproduto;
        public string DistD_NomeProduto
        {
            get { return distd_nomeproduto; }
            set { distd_nomeproduto = value; }
        }
        // Valor do Produto
        private decimal distd_produtovalorunid;
        public decimal DistD_ProdutoValorUnid
        {
            get { return distd_produtovalorunid; }
            set { distd_produtovalorunid = value; }
        }
        // Quantidade do Produto
        private int distd_produtoqtde;
        public int DistD_ProdutoQtde
        {
            get { return distd_produtoqtde; }
            set { distd_produtoqtde = value; }
        }
        // Valor total do produto
        private decimal distd_produtovalortotal;
        public decimal DistD_ProdutoValorTotal
        {
            get { return distd_produtovalortotal; }
            set { distd_produtovalortotal = value; }
        }
        // Código de identificação do Fornecedor
        private int distd_codfornecedor;
        public int DistD_CodFornecedor
        {
            get { return distd_codfornecedor; }
            set { distd_codfornecedor = value; }
        }
        // Valor Total do Fornecedor
        private decimal distd_fornecedorvalor;
        public decimal DistD_FornecedorValor
        {
            get { return distd_fornecedorvalor; }
            set { distd_fornecedorvalor = value; }
        }

        #endregion



       #region Metódos
            
        public bool _Adicionar(DistDetalhe _distribuicaodetalhe, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand("INSERT INTO `DistribuicaoDetalhe` (`DistD_CodDistribuicao` , `DistD_CodProduto` , `DistD_CodLoja` , `DistD_NomeProduto` , `DistD_ProdutoValorUnid` , `DistD_ProdutoQtde` , `DistD_ProdutoValorTotal` , `DistD_CodFornecedor` , `DistD_FornecedorValor` ) VALUES (@DistD_CodDistribuicao, @DistD_CodProduto, @DistD_CodLoja, @DistD_NomeProduto, @DistD_ProdutoValorUnid, @DistD_ProdutoQtde, @DistD_ProdutoValorTotal, @DistD_CodFornecedor, @DistD_FornecedorValor);", conexao);
       
                sql.Parameters.AddWithValue("@DistD_CodDistribuicao" , _distribuicaodetalhe.distd_coddistribuicao);
                sql.Parameters.AddWithValue("@DistD_CodProduto" , _distribuicaodetalhe.distd_codproduto);
                sql.Parameters.AddWithValue("@DistD_CodLoja" , _distribuicaodetalhe.distd_codloja);
                sql.Parameters.AddWithValue("@DistD_NomeProduto" , _distribuicaodetalhe.distd_nomeproduto);
                sql.Parameters.AddWithValue("@DistD_ProdutoValorUnid" , _distribuicaodetalhe.distd_produtovalorunid);
                sql.Parameters.AddWithValue("@DistD_ProdutoQtde" , _distribuicaodetalhe.distd_produtoqtde);
                sql.Parameters.AddWithValue("@DistD_ProdutoValorTotal" , _distribuicaodetalhe.distd_produtovalortotal);
                sql.Parameters.AddWithValue("@DistD_CodFornecedor" , _distribuicaodetalhe.distd_codfornecedor);
                sql.Parameters.AddWithValue("@DistD_FornecedorValor" , _distribuicaodetalhe.distd_fornecedorvalor);
  
                conexao.Open();
                sql.ExecuteScalar();
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
                sql.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool _Editar(DistDetalhe _distribuicaodetalhe, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand(" UPDATE DistribuicaoDetalhe SET DistD_Id = @DistD_Id , DistD_CodDistribuicao = @DistD_CodDistribuicao, DistD_CodProduto = @DistD_CodProduto, DistD_CodLoja = @DistD_CodLoja, DistD_NomeProduto = @DistD_NomeProduto, DistD_ProdutoValorUnid = @DistD_ProdutoValorUnid, DistD_ProdutoQtde = @DistD_ProdutoQtde, DistD_ProdutoValorTotal = @DistD_ProdutoValorTotal, DistD_CodFornecedor = @DistD_CodFornecedor, DistD_FornecedorValor = @DistD_FornecedorValor WHERE DistD_Id = @DistD_Id ", conexao);
                sql.Parameters.AddWithValue("@DistD_Id", _distribuicaodetalhe.DistD_Id);
                sql.Parameters.AddWithValue("@DistD_CodDistribuicao", _distribuicaodetalhe.DistD_CodDistribuicao);
                sql.Parameters.AddWithValue("@DistD_CodProduto", _distribuicaodetalhe.DistD_CodProduto);
                sql.Parameters.AddWithValue("@DistD_CodLoja", _distribuicaodetalhe.DistD_CodLoja);
                sql.Parameters.AddWithValue("@DistD_NomeProduto", _distribuicaodetalhe.DistD_NomeProduto);
                sql.Parameters.AddWithValue("@DistD_ProdutoValorUnid", _distribuicaodetalhe.DistD_ProdutoValorUnid);
                sql.Parameters.AddWithValue("@DistD_ProdutoQtde", _distribuicaodetalhe.DistD_ProdutoQtde);
                sql.Parameters.AddWithValue("@DistD_ProdutoValorTotal", _distribuicaodetalhe.DistD_ProdutoValorTotal);
                sql.Parameters.AddWithValue("@DistD_CodFornecedor", _distribuicaodetalhe.DistD_CodFornecedor);
                sql.Parameters.AddWithValue("@DistD_FornecedorValor", _distribuicaodetalhe.DistD_FornecedorValor);
                conexao.Open();
                sql.ExecuteNonQuery();
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
                sql.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool _Excluir(int distd_id, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                var sql = new MySqlCommand("DELETE FROM DistribuicaoDetalhe WHERE DistD_Id = @DistD_Id ", conexao);
                sql.Parameters.AddWithValue("@DistD_Id", distd_id);
                conexao.Open();
                sql.ExecuteNonQuery();
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
                sql.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IList<DistDetalhe> _ListarTodos(string stringConnect)
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
                    IList<DistDetalhe> ListadeDistDetalhe = new ObservableCollection<DistDetalhe>();
                    var sql = new MySqlCommand(" Select * from DistribuicaoDetalhe", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        DistDetalhe _distdetalhe = new DistDetalhe();
                        // Propriedades da Classe
                        if (MySqlDR["DistD_Id"] != DBNull.Value)
                            _distdetalhe.DistD_Id = Convert.ToInt32(MySqlDR["DistD_Id"]);
                        if (MySqlDR["DistD_CodDistribuicao"] != DBNull.Value)
                            _distdetalhe.DistD_CodDistribuicao = Convert.ToInt32(MySqlDR["DistD_CodDistribuicao"]);
                        if (MySqlDR["DistD_CodProduto"] != DBNull.Value)
                            _distdetalhe.DistD_CodProduto = Convert.ToInt32(MySqlDR["DistD_CodProduto"]);
                        if (MySqlDR["DistD_CodLoja"] != DBNull.Value)
                            _distdetalhe.DistD_CodLoja = Convert.ToInt32(MySqlDR["DistD_CodLoja"]);
                        if (MySqlDR["DistD_NomeProduto"] != DBNull.Value)
                            _distdetalhe.DistD_NomeProduto = MySqlDR["DistD_NomeProduto"].ToString();
                        if (MySqlDR["DistD_ProdutoValorUnid"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoValorUnid = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorUnid"]);
                        if (MySqlDR["DistD_ProdutoQtde"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoQtde = Convert.ToInt32(MySqlDR["DistD_ProdutoQtde"]);
                        if (MySqlDR["DistD_ProdutoValorTotal"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoValorTotal = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorTotal"]);
                        if (MySqlDR["DistD_CodFornecedor"] != DBNull.Value)
                            _distdetalhe.DistD_CodFornecedor = Convert.ToInt32(MySqlDR["DistD_CodFornecedor"]);
                        if (MySqlDR["DistD_FornecedorValor"] != DBNull.Value)
                            _distdetalhe.DistD_FornecedorValor = Convert.ToDecimal(MySqlDR["DistD_FornecedorValor"]);
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

        public IList<DistDetalhe> _ListarDistribuicao(int _DistD_Id, string stringConnect)
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
                    IList<DistDetalhe> ListadeDistDetalhe = new ObservableCollection<DistDetalhe>();
                    var sql = new MySqlCommand(" Select * from DistribuicaoDetalhe where DistD_CodDistribuicao = '" + _DistD_Id.ToString() + "' order by DistD_CodProduto;", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        DistDetalhe _distdetalhe = new DistDetalhe();
                        // Propriedades da Classe
                        if (MySqlDR["DistD_Id"] != DBNull.Value)
                            _distdetalhe.DistD_Id = Convert.ToInt32(MySqlDR["DistD_Id"]);
                        if (MySqlDR["DistD_CodDistribuicao"] != DBNull.Value)
                            _distdetalhe.DistD_CodDistribuicao = Convert.ToInt32(MySqlDR["DistD_CodDistribuicao"]);
                        if (MySqlDR["DistD_CodProduto"] != DBNull.Value)
                            _distdetalhe.DistD_CodProduto = Convert.ToInt32(MySqlDR["DistD_CodProduto"]);
                        if (MySqlDR["DistD_CodLoja"] != DBNull.Value)
                            _distdetalhe.DistD_CodLoja = Convert.ToInt32(MySqlDR["DistD_CodLoja"]);
                        if (MySqlDR["DistD_NomeProduto"] != DBNull.Value)
                            _distdetalhe.DistD_NomeProduto = MySqlDR["DistD_NomeProduto"].ToString();
                        if (MySqlDR["DistD_ProdutoValorUnid"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoValorUnid = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorUnid"]);
                        if (MySqlDR["DistD_ProdutoQtde"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoQtde = Convert.ToInt32(MySqlDR["DistD_ProdutoQtde"]);
                        if (MySqlDR["DistD_ProdutoValorTotal"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoValorTotal = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorTotal"]);
                        if (MySqlDR["DistD_CodFornecedor"] != DBNull.Value)
                            _distdetalhe.DistD_CodFornecedor = Convert.ToInt32(MySqlDR["DistD_CodFornecedor"]);
                        if (MySqlDR["DistD_FornecedorValor"] != DBNull.Value)
                            _distdetalhe.DistD_FornecedorValor = Convert.ToDecimal(MySqlDR["DistD_FornecedorValor"]);
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

        public DistDetalhe _PesquisarPorId(int _DistD_Id, string stringConnect)
        {
            DistDetalhe _distdetalhe = new DistDetalhe();
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                if (conexao.State == ConnectionState.Open)
                {
                    var sql = new MySqlCommand(" Select * from DistribuicaoDetalhe where DistD_Id = '" + _DistD_Id.ToString() + "'", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        // Propriedades da Classe
                        if (MySqlDR["DistD_Id"] != DBNull.Value)
                            _distdetalhe.DistD_Id = Convert.ToInt32(MySqlDR["DistD_Id"]);
                        if (MySqlDR["DistD_CodDistribuicao"] != DBNull.Value)
                            _distdetalhe.DistD_CodDistribuicao = Convert.ToInt32(MySqlDR["DistD_CodDistribuicao"]);
                        if (MySqlDR["DistD_CodProduto"] != DBNull.Value)
                            _distdetalhe.DistD_CodProduto = Convert.ToInt32(MySqlDR["DistD_CodProduto"]);
                        if (MySqlDR["DistD_CodLoja"] != DBNull.Value)
                            _distdetalhe.DistD_CodLoja = Convert.ToInt32(MySqlDR["DistD_CodLoja"]);
                        if (MySqlDR["DistD_NomeProduto"] != DBNull.Value)
                            _distdetalhe.DistD_NomeProduto = MySqlDR["DistD_NomeProduto"].ToString();
                        if (MySqlDR["DistD_ProdutoValorUnid"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoValorUnid = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorUnid"]);
                        if (MySqlDR["DistD_ProdutoQtde"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoQtde = Convert.ToInt32(MySqlDR["DistD_ProdutoQtde"]);
                        if (MySqlDR["DistD_ProdutoValorTotal"] != DBNull.Value)
                            _distdetalhe.DistD_ProdutoValorTotal = Convert.ToDecimal(MySqlDR["DistD_ProdutoValorTotal"]);
                        if (MySqlDR["DistD_CodFornecedor"] != DBNull.Value)
                            _distdetalhe.DistD_CodFornecedor = Convert.ToInt32(MySqlDR["DistD_CodFornecedor"]);
                        if (MySqlDR["DistD_FornecedorValor"] != DBNull.Value)
                            _distdetalhe.DistD_FornecedorValor = Convert.ToDecimal(MySqlDR["DistD_FornecedorValor"]);
                        // Fim das Propriedades
                    }
                    return _distdetalhe;
                }
                return null;
            }
            catch (Exception)
            {
                return _distdetalhe;
            }

        }

        #endregion


    }
}
