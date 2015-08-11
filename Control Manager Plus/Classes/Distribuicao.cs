using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Control_Manager_Plus.Classes
{
    public class Distribuicao
    {
        #region Propriedades

        // Código Interno (Chave Primária)
        private int dis_id;
        public int Dis_Id
        {
            get { return dis_id; }
            set { dis_id = value; }
        }
        // Data definida pelo usuário
        private DateTime dis_datadefinida;
        public DateTime Dis_DataDefinida
        {
            get { return dis_datadefinida; }
            set { dis_datadefinida = value; }
        }
        // Data da gravaçao no banco de dados
        private DateTime dis_datagravacao;
        public DateTime Dis_DataGravacao
        {
            get { return dis_datagravacao; }
            set { dis_datagravacao = value; }
        }
        // Valor total da distribuição
        private decimal dis_total;
        public decimal Dis_Total
        {
            get { return dis_total; }
            set { dis_total = value; }
        }
        // Id do usuário do sistema
        private int dis_operador;
        public int Dis_Operador
        {
            get { return dis_operador; }
            set { dis_operador = value; }
        }

        #endregion


        #region Metódos
            
        public Int32 _Adicionar(Distribuicao _distribuicao, string stringConnect)
        {
            int UltimoId = 0;
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand("INSERT INTO `distribuicao` (`Dis_DataDefinida` , `Dis_DataGravacao` , `Dis_Total` , `Dis_Operador` ) VALUES (@Dis_DataDefinida, @Dis_DataGravacao, @Dis_Total, @Dis_Operador);", conexao);
       
                sql.Parameters.AddWithValue("@Dis_DataDefinida" , _distribuicao.dis_datadefinida);
                sql.Parameters.AddWithValue("@Dis_DataGravacao" , _distribuicao.dis_datagravacao);
                sql.Parameters.AddWithValue("@Dis_Total" , _distribuicao.dis_total);
                sql.Parameters.AddWithValue("@Dis_Operador" , _distribuicao.dis_operador);
  
                conexao.Open();
                sql.ExecuteScalar();

                //Código para recupear o ultimo id gerado
                sql.Parameters.Clear();
                sql.CommandText = "SELECT @@IDENTITY";
                UltimoId = Convert.ToInt32(sql.ExecuteScalar());

                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                    conexao.Dispose();
                }
                sql.Dispose();
                return UltimoId;
            }
            catch (Exception)
            {
                return UltimoId;
            }
        }

        public bool _Editar(Distribuicao _distribuicao, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);
                var sql = new MySqlCommand(" UPDATE Distribuicao SET Dis_Id = @Dis_Id , Dis_DataDefinida = @Dis_DataDefinida, Dis_DataGravacao = @Dis_DataGravacao, Dis_Total = @Dis_Total, Dis_Operador = @Dis_Operador WHERE Dis_Id = @Dis_Id ", conexao);
                sql.Parameters.AddWithValue("@Dis_Id", _distribuicao.Dis_Id);
                sql.Parameters.AddWithValue("@Dis_DataDefinida", _distribuicao.Dis_DataDefinida);
                sql.Parameters.AddWithValue("@Dis_DataGravacao", _distribuicao.Dis_DataGravacao);
                sql.Parameters.AddWithValue("@Dis_Total", _distribuicao.Dis_Total);
                sql.Parameters.AddWithValue("@Dis_Operador", _distribuicao.Dis_Operador);
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

        public bool _Excluir(int dis_id, string stringConnect)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                var sql = new MySqlCommand("DELETE FROM Distribuicao WHERE Dis_Id = @Dis_Id ", conexao);
                sql.Parameters.AddWithValue("@Dis_Id", dis_id);
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

        public IList<Distribuicao> _ListarTodos(string stringConnect)
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
                    IList<Distribuicao> ListadeDistribuicao = new ObservableCollection<Distribuicao>();
                    var sql = new MySqlCommand(" Select * from Distribuicao", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Distribuicao _distribuicao = new Distribuicao();
                        // Propriedades da Classe
                        if (MySqlDR["Dis_Id"] != DBNull.Value)
                            _distribuicao.Dis_Id = Convert.ToInt32(MySqlDR["Dis_Id"]);
                        if (MySqlDR["Dis_DataDefinida"] != DBNull.Value)
                            _distribuicao.Dis_DataDefinida = Convert.ToDateTime(MySqlDR["Dis_DataDefinida"]);
                        if (MySqlDR["Dis_DataGravacao"] != DBNull.Value)
                            _distribuicao.Dis_DataGravacao = Convert.ToDateTime(MySqlDR["Dis_DataGravacao"]);
                        if (MySqlDR["Dis_Total"] != DBNull.Value)
                            _distribuicao.Dis_Total = Convert.ToDecimal(MySqlDR["Dis_Total"]);
                        if (MySqlDR["Dis_Operador"] != DBNull.Value)
                            _distribuicao.Dis_Operador = Convert.ToInt32(MySqlDR["Dis_Operador"]);
                        // Fim das Propriedades
                        ListadeDistribuicao.Add(_distribuicao);
                    }
                    return ListadeDistribuicao;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public Distribuicao _PesquisarPorId(int _Dis_Id, string stringConnect)
        {
            Distribuicao _distribuicao = new Distribuicao();
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConnect);

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                if (conexao.State == ConnectionState.Open)
                {
                    var sql = new MySqlCommand(" Select * from Distribuicao where Dis_Id = '" + _Dis_Id.ToString() + "'", conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        // Propriedades da Classe
                        if (MySqlDR["Dis_Id"] != DBNull.Value)
                            _distribuicao.Dis_Id = Convert.ToInt32(MySqlDR["Dis_Id"]);
                        if (MySqlDR["Dis_DataDefinida"] != DBNull.Value)
                            _distribuicao.Dis_DataDefinida = Convert.ToDateTime(MySqlDR["Dis_DataDefinida"]);
                        if (MySqlDR["Dis_DataGravacao"] != DBNull.Value)
                            _distribuicao.Dis_DataGravacao = Convert.ToDateTime(MySqlDR["Dis_DataGravacao"]);
                        if (MySqlDR["Dis_Total"] != DBNull.Value)
                            _distribuicao.Dis_Total = Convert.ToDecimal(MySqlDR["Dis_Total"]);
                        if (MySqlDR["Dis_Operador"] != DBNull.Value)
                            _distribuicao.Dis_Operador = Convert.ToInt32(MySqlDR["Dis_Operador"]);
                        // Fim das Propriedades
                    }
                    return _distribuicao;
                }
                return null;
            }
            catch (Exception)
            {
                return _distribuicao;
            }

        }

        public IList<Distribuicao> _PesquisaCampos(string textopesquisa, int tipoPesquisa, string stringConnect)
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
                    IList<Distribuicao> ListadeDistribuicao = new ObservableCollection<Distribuicao>();

                    string sqlString = "";
                    /*
                    0 - TODOS OS CAMPOS
                    1 - POR REGISTRO
                    2 - POR DATA
                    3 - POR TOTAL DA DISTRIBUIÇÃO
                    4 - POR RESPONSÁVEL DO REGISTRO
                    */

                    switch (tipoPesquisa)
                    {
                        case 1:
                            sqlString = "SELECT * FROM distribuicao where Dis_id = '" + textopesquisa +"'";    
                            break;
                        case 2:
                            sqlString = "SELECT * FROM distribuicao where date_format(Dis_DataDefinida, '%d/%m/%Y') = '" + textopesquisa + "'";
                            break;
                        case 3:
                            sqlString = "SELECT * FROM distribuicao where Dis_Total Like '%" + textopesquisa + "%'";                           //
                            break;
                        case 4:
                            sqlString = "SELECT * FROM distribuicao where Dis_Operador Like '%" + textopesquisa + "%'";    
                            break;
                        default:
                            sqlString = "SELECT * FROM distribuicao where Dis_id = '" + textopesquisa + "'"
                            + "or date_format(Dis_DataDefinida, '%d/%m/%Y') = '" + textopesquisa + "'"
                            + "or Dis_Total Like '%" + textopesquisa + "%'"
                            + "or Dis_Operador Like '%" + textopesquisa + "%' ;";
                            break;
                    }


                    var sql = new MySqlCommand(sqlString, conexao);
                    MySqlDataReader MySqlDR = sql.ExecuteReader();
                    while (MySqlDR.Read())
                    {
                        Distribuicao _distribuicao = new Distribuicao();
                        // Propriedades da Classe
                        if (MySqlDR["Dis_Id"] != DBNull.Value)
                            _distribuicao.Dis_Id = Convert.ToInt32(MySqlDR["Dis_Id"]);
                        if (MySqlDR["Dis_DataDefinida"] != DBNull.Value)
                            _distribuicao.Dis_DataDefinida = Convert.ToDateTime(MySqlDR["Dis_DataDefinida"]);
                        if (MySqlDR["Dis_DataGravacao"] != DBNull.Value)
                            _distribuicao.Dis_DataGravacao = Convert.ToDateTime(MySqlDR["Dis_DataGravacao"]);
                        if (MySqlDR["Dis_Total"] != DBNull.Value)
                            _distribuicao.Dis_Total = Convert.ToDecimal(MySqlDR["Dis_Total"]);
                        if (MySqlDR["Dis_Operador"] != DBNull.Value)
                            _distribuicao.Dis_Operador = Convert.ToInt32(MySqlDR["Dis_Operador"]);
                        // Fim das Propriedades
                        ListadeDistribuicao.Add(_distribuicao);
                    }
                    return ListadeDistribuicao;
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
