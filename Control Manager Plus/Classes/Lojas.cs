using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Control_Manager_Plus.Classes
{
    class Lojas
    {
        #region Propriedades
        // Código Interno (Chave Primária)
        private int l_id;
        public int L_Id
        {
            get { return l_id; }
            set { l_id = value; }
        }
        private string l_loja;
        public string L_Loja
        {
            get { return l_loja; }
            set { l_loja = value; }
        }
        private string l_responsavel;
        public string L_Responsavel
        {
            get { return l_responsavel; }
            set { l_responsavel = value; }
        }
        private string l_telefone;
        public string L_Telefone
        {
            get { return l_telefone; }
            set { l_telefone = value; }
        }
        private string l_email;
        public string L_Email
        {
            get { return l_email; }
            set { l_email = value; }
        }
        #endregion

        #region Metodos

        public bool _Adicionar(Lojas _loja, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand("INSERT INTO `Loja` (`L_Loja` , `L_Responsavel` , `L_Telefone` , `L_Email` ) VALUES (@L_Loja, @L_Responsavel, @L_Telefone, @L_Email);", conexao);

                sql.Parameters.AddWithValue("@L_Loja", _loja.l_loja);
                sql.Parameters.AddWithValue("@L_Responsavel", _loja.l_responsavel);
                sql.Parameters.AddWithValue("@L_Telefone", _loja.l_telefone);
                sql.Parameters.AddWithValue("@L_Email", _loja.l_email);

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
        public bool _Editar(Lojas _loja, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand(" UPDATE Loja SET L_Id = @L_Id , L_Loja = @L_Loja, L_Responsavel = @L_Responsavel, L_Telefone = @L_Telefone, L_Email = @L_Email WHERE L_Id = @L_Id ", conexao);
                sql.Parameters.AddWithValue("@L_Id", _loja.L_Id);
                sql.Parameters.AddWithValue("@L_Loja", _loja.L_Loja);
                sql.Parameters.AddWithValue("@L_Responsavel", _loja.L_Responsavel);
                sql.Parameters.AddWithValue("@L_Telefone", _loja.L_Telefone);
                sql.Parameters.AddWithValue("@L_Email", _loja.L_Email);
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
        public bool _Excluir(int l_id, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                var sql = new MySqlCommand("DELETE FROM Loja WHERE L_Id = @L_Id ", conexao);
                sql.Parameters.AddWithValue("@L_Id", l_id);
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
        public IList<Lojas> _ListarTodos(string stringConnect)
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
                    IList<Lojas> ListadeLojas = new ObservableCollection<Lojas>();
                    var sql = new MySqlCommand(" Select * from Loja", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Lojas _lojas = new Lojas();
                        // Propriedades da Classe
                        if (MySqlDR["L_Id"] != DBNull.Value)
                            _lojas.L_Id = Convert.ToInt32(MySqlDR["L_Id"]);
                        if (MySqlDR["L_Loja"] != DBNull.Value)
                            _lojas.L_Loja = MySqlDR["L_Loja"].ToString();
                        if (MySqlDR["L_Responsavel"] != DBNull.Value)
                            _lojas.L_Responsavel = MySqlDR["L_Responsavel"].ToString();
                        if (MySqlDR["L_Telefone"] != DBNull.Value)
                            _lojas.L_Telefone = MySqlDR["L_Telefone"].ToString();
                        if (MySqlDR["L_Email"] != DBNull.Value)
                            _lojas.L_Email = MySqlDR["L_Email"].ToString();
                        // Fim das Propriedades
                        ListadeLojas.Add(_lojas);
                    }
                    return ListadeLojas;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
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

                    lista.Add(new Control_Manager_Plus.Classes.Lista.ComboLista { Nome = " Selecione a Loja...", id = 0 });


                    var sql = new MySqlCommand(" Select * from Loja", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Lojas _lojas = new Lojas();
                        // Propriedades da Classe
                        if (MySqlDR["L_Id"] != DBNull.Value)
                            _lojas.L_Id = Convert.ToInt32(MySqlDR["L_Id"]);
                        if (MySqlDR["L_Loja"] != DBNull.Value)
                            _lojas.L_Loja = MySqlDR["L_Loja"].ToString();

                        lista.Add(new Control_Manager_Plus.Classes.Lista.ComboLista { Nome = _lojas.l_loja, id = _lojas.l_id });
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

        public IList<Lojas> _PesquisarCampos(string textopesquisa, int tipoPesquisa, string stringConnect)
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
                    IList<Lojas> ListadeLojas = new ObservableCollection<Lojas>();

                    string sqlString = "";
                    /*

                    0 - Todos os Campos
                    1 - Código da Loja
                    2 - Nome da Loja
                    3 - Responsável

                    */
                    switch (tipoPesquisa)
                    {
                        case 1:
                            sqlString = "Select * from Loja where L_Id = " + textopesquisa + "'";
                            break;
                        case 2:
                            sqlString = "Select * from Loja where L_Loja Like '%" + textopesquisa + "%'";
                            break;
                        case 3:
                            sqlString = "Select * from Loja where L_Responsavel Like  '%" + textopesquisa + "%'";                           //
                            break;

                        default:
                            sqlString = "Select * from Loja where L_Id = '" + textopesquisa + "' "
                            + "or L_Loja Like '%" + textopesquisa + "%' "
                            + "or L_Responsavel Like   '%" + textopesquisa + "%' ";
                            break;
                    }

                    var sql = new MySqlCommand(sqlString, conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Lojas _lojas = new Lojas();
                        // Propriedades da Classe
                        if (MySqlDR["L_Id"] != DBNull.Value)
                            _lojas.L_Id = Convert.ToInt32(MySqlDR["L_Id"]);
                        if (MySqlDR["L_Loja"] != DBNull.Value)
                            _lojas.L_Loja = MySqlDR["L_Loja"].ToString();
                        if (MySqlDR["L_Responsavel"] != DBNull.Value)
                            _lojas.L_Responsavel = MySqlDR["L_Responsavel"].ToString();
                        if (MySqlDR["L_Telefone"] != DBNull.Value)
                            _lojas.L_Telefone = MySqlDR["L_Telefone"].ToString();
                        if (MySqlDR["L_Email"] != DBNull.Value)
                            _lojas.L_Email = MySqlDR["L_Email"].ToString();
                        // Fim das Propriedades
                        ListadeLojas.Add(_lojas);
                    }
                    return ListadeLojas;
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
