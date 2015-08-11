using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Control_Manager_Plus.Classes
{
    class Fornecedores
    {

        #region Propriedades
        // Código Interno (Chave Primária)
        private int e_id;
        public int E_Id
        {
            get { return e_id; }
            set { e_id = value; }
        }
        private string e_razaosocial;
        public string E_RazaoSocial
        {
            get { return e_razaosocial; }
            set { e_razaosocial = value; }
        }
        private string e_cnpj;
        public string E_CNPJ
        {
            get { return e_cnpj; }
            set { e_cnpj = value; }
        }
        private string e_ie;
        public string E_IE
        {
            get { return e_ie; }
            set { e_ie = value; }
        }
        private string e_tel;
        public string E_Tel
        {
            get { return e_tel; }
            set { e_tel = value; }
        }
        private string e_contato;
        public string E_Contato
        {
            get { return e_contato; }
            set { e_contato = value; }
        }
        private string e_email;
        public string E_Email
        {
            get { return e_email; }
            set { e_email = value; }
        }
        #endregion

        #region Metodos

        public bool _Adicionar(Fornecedores _fornecedor, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand("INSERT INTO `Fornecedor` (`E_RazaoSocial` , `E_CNPJ` , `E_IE` , `E_Tel` , `E_Contato` , `E_Email` ) VALUES (@E_RazaoSocial, @E_CNPJ, @E_IE, @E_Tel, @E_Contato, @E_Email);", conexao);

                sql.Parameters.AddWithValue("@E_RazaoSocial", _fornecedor.e_razaosocial);
                sql.Parameters.AddWithValue("@E_CNPJ", _fornecedor.e_cnpj);
                sql.Parameters.AddWithValue("@E_IE", _fornecedor.e_ie);
                sql.Parameters.AddWithValue("@E_Tel", _fornecedor.e_tel);
                sql.Parameters.AddWithValue("@E_Contato", _fornecedor.e_contato);
                sql.Parameters.AddWithValue("@E_Email", _fornecedor.e_email);

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
  
        public bool _Editar(Fornecedores _fornecedor, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand(" UPDATE Fornecedor SET E_Id = @E_Id , E_RazaoSocial = @E_RazaoSocial, E_CNPJ = @E_CNPJ, E_IE = @E_IE, E_Tel = @E_Tel, E_Contato = @E_Contato, E_Email = @E_Email WHERE E_Id = @E_Id ", conexao);
                sql.Parameters.AddWithValue("@E_Id", _fornecedor.E_Id);
                sql.Parameters.AddWithValue("@E_RazaoSocial", _fornecedor.E_RazaoSocial);
                sql.Parameters.AddWithValue("@E_CNPJ", _fornecedor.E_CNPJ);
                sql.Parameters.AddWithValue("@E_IE", _fornecedor.E_IE);
                sql.Parameters.AddWithValue("@E_Tel", _fornecedor.E_Tel);
                sql.Parameters.AddWithValue("@E_Contato", _fornecedor.E_Contato);
                sql.Parameters.AddWithValue("@E_Email", _fornecedor.E_Email);
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
        
        public bool _Excluir(int e_id, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                var sql = new MySqlCommand("DELETE FROM Fornecedor WHERE E_Id = @E_Id ", conexao);
                sql.Parameters.AddWithValue("@E_Id", e_id);
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
        
        public IList<Fornecedores> _ListarTodos(string stringConnect)
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
                    IList<Fornecedores> ListadeFornecedores = new ObservableCollection<Fornecedores>();
                    var sql = new MySqlCommand(" Select * from Fornecedor", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Fornecedores _fornecedores = new Fornecedores();
                        // Propriedades da Classe
                        if (MySqlDR["E_Id"] != DBNull.Value)
                            _fornecedores.E_Id = Convert.ToInt32(MySqlDR["E_Id"]);
                        if (MySqlDR["E_RazaoSocial"] != DBNull.Value)
                            _fornecedores.E_RazaoSocial = MySqlDR["E_RazaoSocial"].ToString();
                        if (MySqlDR["E_CNPJ"] != DBNull.Value)
                            _fornecedores.E_CNPJ = MySqlDR["E_CNPJ"].ToString();
                        if (MySqlDR["E_IE"] != DBNull.Value)
                            _fornecedores.E_IE = MySqlDR["E_IE"].ToString();
                        if (MySqlDR["E_Tel"] != DBNull.Value)
                            _fornecedores.E_Tel = MySqlDR["E_Tel"].ToString();
                        if (MySqlDR["E_Contato"] != DBNull.Value)
                            _fornecedores.E_Contato = MySqlDR["E_Contato"].ToString();
                        if (MySqlDR["E_Email"] != DBNull.Value)
                            _fornecedores.E_Email = MySqlDR["E_Email"].ToString();
                        // Fim das Propriedades
                        ListadeFornecedores.Add(_fornecedores);
                    }
                    return ListadeFornecedores;
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
                    var lista = new List<Control_Manager_Plus.Classes.Lista.ComboLista>();
                    lista.Add(new Control_Manager_Plus.Classes.Lista.ComboLista { Nome = " Selecione o fornecedor...", id = 0 });

                    var sql = new MySqlCommand(" Select * from Fornecedor", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Fornecedores _fornecedores = new Fornecedores();
                        if (MySqlDR["E_Id"] != DBNull.Value)
                            _fornecedores.E_Id = Convert.ToInt32(MySqlDR["E_Id"]);
                        if (MySqlDR["E_RazaoSocial"] != DBNull.Value)
                            _fornecedores.E_RazaoSocial = MySqlDR["E_RazaoSocial"].ToString();

                        lista.Add(new Control_Manager_Plus.Classes.Lista.ComboLista { Nome = _fornecedores.E_RazaoSocial, id = _fornecedores.E_Id });
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

        public IList<Fornecedores> _PesquisarCampos(string textopesquisa, int tipoPesquisa, string stringConnect)
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
                    IList<Fornecedores> ListadeFornecedores = new ObservableCollection<Fornecedores>();

                    string sqlString = "";
                    /*
                    0 - Todos os Campos
                    1 - Código do Fornecedor
                    2 - Nome / Razão Social
                    3 - CPF / CNPJ
                    4 - Inscrição Estadual
                    5 - Telefone
                    6 - Contato
                    7 - E-mail
                    */
                    switch (tipoPesquisa)
                    {
                        case 1:
                            sqlString = "Select * from Fornecedor where E_Id = " + textopesquisa + "'";
                            break;
                        case 2:
                            sqlString = "Select * from Fornecedor where E_RazaoSocial Like '%" + textopesquisa + "%'";
                            break;
                        case 3:
                            sqlString = "Select * from Fornecedor where E_CNPJ Like  '%" + textopesquisa + "%'";                           //
                            break;
                        case 4:
                            sqlString = "Select * from Fornecedor where E_IE Like  '%" + textopesquisa + "%'";                           //
                            break;
                        case 5:
                            sqlString = "Select * from Fornecedor where E_Tel Like  '%" + textopesquisa + "%'";                           //
                            break;
                        case 6:
                            sqlString = "Select * from Fornecedor where E_Contato Like  '%" + textopesquisa + "%'";                           //
                            break;
                        case 7:
                            sqlString = "Select * from Fornecedor where E_Email Like  '%" + textopesquisa + "%'";                           //
                            break;
                        default:
                            sqlString = "Select * from Fornecedor where E_Id = '" + textopesquisa + "' "
                            + "or E_RazaoSocial Like '%" + textopesquisa + "%' "
                            + "or E_CNPJ Like   '%" + textopesquisa + "%' "
                            + "or E_IE Like   '%" + textopesquisa + "%' "
                            + "or E_Tel Like   '%" + textopesquisa + "%' "
                            + "or E_Contato Like   '%" + textopesquisa + "%' "
                            + "or E_Contato Like   '%" + textopesquisa + "%' ";                        
                            break;
                    }
                    var sql = new MySqlCommand(sqlString, conexao);                    
                    //var sql = new MySqlCommand(" Select * from Fornecedor", conexao);

                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Fornecedores _fornecedores = new Fornecedores();
                        // Propriedades da Classe
                        if (MySqlDR["E_Id"] != DBNull.Value)
                            _fornecedores.E_Id = Convert.ToInt32(MySqlDR["E_Id"]);
                        if (MySqlDR["E_RazaoSocial"] != DBNull.Value)
                            _fornecedores.E_RazaoSocial = MySqlDR["E_RazaoSocial"].ToString();
                        if (MySqlDR["E_CNPJ"] != DBNull.Value)
                            _fornecedores.E_CNPJ = MySqlDR["E_CNPJ"].ToString();
                        if (MySqlDR["E_IE"] != DBNull.Value)
                            _fornecedores.E_IE = MySqlDR["E_IE"].ToString();
                        if (MySqlDR["E_Tel"] != DBNull.Value)
                            _fornecedores.E_Tel = MySqlDR["E_Tel"].ToString();
                        if (MySqlDR["E_Contato"] != DBNull.Value)
                            _fornecedores.E_Contato = MySqlDR["E_Contato"].ToString();
                        if (MySqlDR["E_Email"] != DBNull.Value)
                            _fornecedores.E_Email = MySqlDR["E_Email"].ToString();
                        // Fim das Propriedades
                        ListadeFornecedores.Add(_fornecedores);
                    }
                    return ListadeFornecedores;
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
