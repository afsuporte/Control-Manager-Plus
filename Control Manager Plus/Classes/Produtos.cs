using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;


namespace Control_Manager_Plus.Classes
{
    class Produtos
    {
        #region Propriedades

        // Código Interno (Chave Primária)
        private int p_id;
        public int P_Id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        private string p_descricao;
        public string P_Descricao
        {
            get { return p_descricao; }
            set { p_descricao = value; }
        }
        private decimal p_pcusto;
        public decimal P_Pcusto
        {
            get { return p_pcusto; }
            set { p_pcusto = value; }
        }
        private decimal p_pvenda;
        public decimal P_Pvenda
        {
            get { return p_pvenda; }
            set { p_pvenda = value; }
        }
        private string p_unid;
        public string P_Unid
        {
            get { return p_unid; }
            set { p_unid = value; }
        }
        private string p_fornecedor;
        public string P_Fornecedor
        {
            get { return p_fornecedor; }
            set { p_fornecedor = value; }
        }
        #endregion


        #region

        public bool _Adicionar(Produtos _produto, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand("INSERT INTO `Produto` (`P_Descricao` , `P_Pcusto` , `P_Pvenda` , `P_Unid` , `P_Fornecedor` ) VALUES (@P_Descricao, @P_Pcusto, @P_Pvenda, @P_Unid, @P_Fornecedor);", conexao);

                sql.Parameters.AddWithValue("@P_Descricao", _produto.p_descricao);
                sql.Parameters.AddWithValue("@P_Pcusto", _produto.p_pcusto);
                sql.Parameters.AddWithValue("@P_Pvenda", _produto.p_pvenda);
                sql.Parameters.AddWithValue("@P_Unid", _produto.p_unid);
                sql.Parameters.AddWithValue("@P_Fornecedor", _produto.p_fornecedor);

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

        public bool _Editar(Produtos _produto, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand(" UPDATE Produto SET P_Id = @P_Id , P_Descricao = @P_Descricao, P_Pcusto = @P_Pcusto, P_Pvenda = @P_Pvenda, P_Unid = @P_Unid, P_Fornecedor = @P_Fornecedor WHERE P_Id = @P_Id ", conexao);
                sql.Parameters.AddWithValue("@P_Id", _produto.P_Id);
                sql.Parameters.AddWithValue("@P_Descricao", _produto.P_Descricao);
                sql.Parameters.AddWithValue("@P_Pcusto", _produto.P_Pcusto);
                sql.Parameters.AddWithValue("@P_Pvenda", _produto.P_Pvenda);
                sql.Parameters.AddWithValue("@P_Unid", _produto.P_Unid);
                sql.Parameters.AddWithValue("@P_Fornecedor", _produto.P_Fornecedor);
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

        public bool _Excluir(int p_id, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                var sql = new MySqlCommand("DELETE FROM Produto WHERE P_Id = @P_Id ", conexao);
                sql.Parameters.AddWithValue("@P_Id", p_id);
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

        public IList<Produtos> _ListarTodos(string stringConnect)
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
                    IList<Produtos> ListadeProdutos = new ObservableCollection<Produtos>();
                    var sql = new MySqlCommand(" Select * from Produto", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Produtos _produtos = new Produtos();
                        // Propriedades da Classe
                        if (MySqlDR["P_Id"] != DBNull.Value)
                            _produtos.P_Id = Convert.ToInt32(MySqlDR["P_Id"]);
                        if (MySqlDR["P_Descricao"] != DBNull.Value)
                            _produtos.P_Descricao = MySqlDR["P_Descricao"].ToString();
                        if (MySqlDR["P_Pcusto"] != DBNull.Value)
                            _produtos.P_Pcusto = Convert.ToDecimal(MySqlDR["P_Pcusto"]);
                        if (MySqlDR["P_Pvenda"] != DBNull.Value)
                            _produtos.P_Pvenda = Convert.ToDecimal(MySqlDR["P_Pvenda"]);
                        if (MySqlDR["P_Unid"] != DBNull.Value)
                            _produtos.P_Unid = MySqlDR["P_Unid"].ToString();
                        if (MySqlDR["P_Fornecedor"] != DBNull.Value)
                            _produtos.P_Fornecedor = MySqlDR["P_Fornecedor"].ToString();
                        // Fim das Propriedades
                        ListadeProdutos.Add(_produtos);
                    }
                    return ListadeProdutos;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }
  
        public Produtos _PesquisarPorId(string stringConnect, int CodProduto)
        {
            Produtos _produtos = new Produtos();
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                if (conexao.State == ConnectionState.Open)
                {
                   
                    var sql = new MySqlCommand(" Select * from Produto where P_Id = '" + CodProduto.ToString() + "';", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        
                        // Propriedades da Classe
                        if (MySqlDR["P_Id"] != DBNull.Value)
                            _produtos.P_Id = Convert.ToInt32(MySqlDR["P_Id"]);
                        if (MySqlDR["P_Descricao"] != DBNull.Value)
                            _produtos.P_Descricao = MySqlDR["P_Descricao"].ToString();
                        if (MySqlDR["P_Pcusto"] != DBNull.Value)
                            _produtos.P_Pcusto = Convert.ToDecimal(MySqlDR["P_Pcusto"]);
                        if (MySqlDR["P_Pvenda"] != DBNull.Value)
                            _produtos.P_Pvenda = Convert.ToDecimal(MySqlDR["P_Pvenda"]);
                        if (MySqlDR["P_Unid"] != DBNull.Value)
                            _produtos.P_Unid = MySqlDR["P_Unid"].ToString();
                        if (MySqlDR["P_Fornecedor"] != DBNull.Value)
                            _produtos.P_Fornecedor = MySqlDR["P_Fornecedor"].ToString();
                        // Fim das Propriedades
                       
                    }
                    return _produtos;
                }
                return null;
            }
            catch (Exception)
            {
                return _produtos; 
            }

        }

        public IList<Control_Manager_Plus.Classes.Lista.ComboLista> _ListarItemListBox(string stringConnect)
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
                   // IList<Produtos> ListadeProdutos = new ObservableCollection<Produtos>();

                    var lista = new List<Control_Manager_Plus.Classes.Lista.ComboLista>();

                    lista.Add(new Control_Manager_Plus.Classes.Lista.ComboLista { Nome = " Selecione o produto...", id = 0 });
                 

                    var sql = new MySqlCommand(" Select * from Produto", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Produtos _produtos = new Produtos();
                        // Propriedades da Classe
                        if (MySqlDR["P_Id"] != DBNull.Value)
                            _produtos.P_Id = Convert.ToInt32(MySqlDR["P_Id"]);
                        if (MySqlDR["P_Descricao"] != DBNull.Value)
                            _produtos.P_Descricao = MySqlDR["P_Descricao"].ToString();

                        lista.Add(new Control_Manager_Plus.Classes.Lista.ComboLista { Nome = _produtos.P_Descricao, id = _produtos.P_Id });
                    }
                    return lista;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }


        public IList<Produtos> _PesquisarCampos(string textopesquisa, int tipoPesquisa, string stringConnect)
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
                    IList<Produtos> ListadeProdutos = new ObservableCollection<Produtos>();

                    //var sql = new MySqlCommand(" Select * from Produto", conexao);
                    string sqlString = "";
                    /*
                0 - Todos os Campos
                1 - Código do Produto
                2 - Descrição do Produtol
                3 - Preço Venda acima de...
                4 - Preço Venda abaixo de...
                5 - Preço Custo acima de...
                6 - Preço Custo abaixo de...
                7 - Tipo de Unidade
                8 - Fornecedor Padrão
                    */
                    switch (tipoPesquisa)
                    {
                        case 1:
                            sqlString = "Select * from Produto where P_Id = " + textopesquisa + "'";
                            break;
                        case 2:
                            sqlString = "Select * from Produto where P_Descricao Like '%" + textopesquisa + "%'";
                            break;
                        case 3:
                            sqlString = "Select * from Produto where P_Pvenda > '" + textopesquisa + "'";                              //
                            break;
                        case 4:
                            sqlString = "Select * from Produto where P_Pvenda <'" + textopesquisa + "'";                               //
                            break;
                        case 5:
                            sqlString = "Select * from Produto where P_Pcusto >  '" + textopesquisa + "'";                           //
                            break;
                        case 6:
                            sqlString = "Select * from Produto where P_Pcusto <  '" + textopesquisa + "'";                           //
                            break;
                        case 7:
                            sqlString = "Select * from Produto where P_Unid Like  '%" + textopesquisa + "%'";                           //
                            break;
                        case 8:
                            sqlString = "Select * from Produto where P_Fornecedor Like  '%" + textopesquisa + "%'";                           //
                            break;
                        default:
                            sqlString = "Select * from Produto where P_Id = '" + textopesquisa + "' "
                            + "or P_Descricao Like '%" + textopesquisa + "%' "
                            + "or P_Unid Like   '%" + textopesquisa + "%' "
                            + "or P_Fornecedor Like   '%" + textopesquisa + "%' ";
                            break;
                    }
                    var sql = new MySqlCommand(sqlString, conexao);      
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Produtos _produtos = new Produtos();
                        // Propriedades da Classe
                        if (MySqlDR["P_Id"] != DBNull.Value)
                            _produtos.P_Id = Convert.ToInt32(MySqlDR["P_Id"]);
                        if (MySqlDR["P_Descricao"] != DBNull.Value)
                            _produtos.P_Descricao = MySqlDR["P_Descricao"].ToString();
                        if (MySqlDR["P_Pcusto"] != DBNull.Value)
                            _produtos.P_Pcusto = Convert.ToDecimal(MySqlDR["P_Pcusto"]);
                        if (MySqlDR["P_Pvenda"] != DBNull.Value)
                            _produtos.P_Pvenda = Convert.ToDecimal(MySqlDR["P_Pvenda"]);
                        if (MySqlDR["P_Unid"] != DBNull.Value)
                            _produtos.P_Unid = MySqlDR["P_Unid"].ToString();
                        if (MySqlDR["P_Fornecedor"] != DBNull.Value)
                            _produtos.P_Fornecedor = MySqlDR["P_Fornecedor"].ToString();
                        // Fim das Propriedades
                        ListadeProdutos.Add(_produtos);
                    }
                    return ListadeProdutos;
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
