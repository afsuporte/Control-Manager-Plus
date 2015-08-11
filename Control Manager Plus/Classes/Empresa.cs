using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;


namespace Control_Manager_Plus.Classes
{
    class Empresa
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
        private string e_endereco;
        public string E_Endereco
        {
            get { return e_endereco; }
            set { e_endereco = value; }
        }
        private string e_complemento;
        public string E_Complemento
        {
            get { return e_complemento; }
            set { e_complemento = value; }
        }
        private string e_estado;
        public string E_Estado
        {
            get { return e_estado; }
            set { e_estado = value; }
        }
        private string e_telefone;
        public string E_Telefone
        {
            get { return e_telefone; }
            set { e_telefone = value; }
        }
        private string e_email;
        public string E_Email
        {
            get { return e_email; }
            set { e_email = value; }
        }
        #endregion

        #region Metodos 

        public bool _Adicionar(Empresa _empresamatriz, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand("INSERT INTO `EmpresaMatriz` (`E_RazaoSocial` , `E_CNPJ` , `E_IE` , `E_Endereco` , `E_Complemento` , `E_Estado` , `E_Telefone` , `E_Email` ) VALUES (@E_RazaoSocial, @E_CNPJ, @E_IE, @E_Endereco, @E_Complemento, @E_Estado, @E_Telefone, @E_Email);", conexao);

                sql.Parameters.AddWithValue("@E_RazaoSocial", _empresamatriz.e_razaosocial);
                sql.Parameters.AddWithValue("@E_CNPJ", _empresamatriz.e_cnpj);
                sql.Parameters.AddWithValue("@E_IE", _empresamatriz.e_ie);
                sql.Parameters.AddWithValue("@E_Endereco", _empresamatriz.e_endereco);
                sql.Parameters.AddWithValue("@E_Complemento", _empresamatriz.e_complemento);
                sql.Parameters.AddWithValue("@E_Estado", _empresamatriz.e_estado);
                sql.Parameters.AddWithValue("@E_Telefone", _empresamatriz.e_telefone);
                sql.Parameters.AddWithValue("@E_Email", _empresamatriz.e_email);

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
        public bool _Editar(Empresa _empresamatriz, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand(" UPDATE EmpresaMatriz SET E_Id = @E_Id , E_RazaoSocial = @E_RazaoSocial, E_CNPJ = @E_CNPJ, E_IE = @E_IE, E_Endereco = @E_Endereco, E_Complemento = @E_Complemento, E_Estado = @E_Estado, E_Telefone = @E_Telefone, E_Email = @E_Email WHERE E_Id = @E_Id ", conexao);
                sql.Parameters.AddWithValue("@E_Id", _empresamatriz.E_Id);
                sql.Parameters.AddWithValue("@E_RazaoSocial", _empresamatriz.E_RazaoSocial);
                sql.Parameters.AddWithValue("@E_CNPJ", _empresamatriz.E_CNPJ);
                sql.Parameters.AddWithValue("@E_IE", _empresamatriz.E_IE);
                sql.Parameters.AddWithValue("@E_Endereco", _empresamatriz.E_Endereco);
                sql.Parameters.AddWithValue("@E_Complemento", _empresamatriz.E_Complemento);
                sql.Parameters.AddWithValue("@E_Estado", _empresamatriz.E_Estado);
                sql.Parameters.AddWithValue("@E_Telefone", _empresamatriz.E_Telefone);
                sql.Parameters.AddWithValue("@E_Email", _empresamatriz.E_Email);
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

                var sql = new MySqlCommand("DELETE FROM EmpresaMatriz WHERE E_Id = @E_Id ", conexao);
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
        public IList<Empresa> _ListarTodos(string stringConnect)
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
                    IList<Empresa> ListadeEmpresa = new ObservableCollection<Empresa>();
                    var sql = new MySqlCommand(" Select * from EmpresaMatriz", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Empresa _empresa = new Empresa();
                        // Propriedades da Classe
                        if (MySqlDR["E_Id"] != DBNull.Value)
                            _empresa.E_Id = Convert.ToInt32(MySqlDR["E_Id"]);
                        if (MySqlDR["E_RazaoSocial"] != DBNull.Value)
                            _empresa.E_RazaoSocial = MySqlDR["E_RazaoSocial"].ToString();
                        if (MySqlDR["E_CNPJ"] != DBNull.Value)
                            _empresa.E_CNPJ = MySqlDR["E_CNPJ"].ToString();
                        if (MySqlDR["E_IE"] != DBNull.Value)
                            _empresa.E_IE = MySqlDR["E_IE"].ToString();
                        if (MySqlDR["E_Endereco"] != DBNull.Value)
                            _empresa.E_Endereco = MySqlDR["E_Endereco"].ToString();
                        if (MySqlDR["E_Complemento"] != DBNull.Value)
                            _empresa.E_Complemento = MySqlDR["E_Complemento"].ToString();
                        if (MySqlDR["E_Estado"] != DBNull.Value)
                            _empresa.E_Estado = MySqlDR["E_Estado"].ToString();
                        if (MySqlDR["E_Telefone"] != DBNull.Value)
                            _empresa.E_Telefone = MySqlDR["E_Telefone"].ToString();
                        if (MySqlDR["E_Email"] != DBNull.Value)
                            _empresa.E_Email = MySqlDR["E_Email"].ToString();
                        // Fim das Propriedades
                        ListadeEmpresa.Add(_empresa);
                    }
                    return ListadeEmpresa;
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
