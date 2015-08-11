using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Control_Manager_Plus.Classes
{
    public class BancoDados
    {

        string bancoDados = "dbControlManagerPlus";
        string servidor = "127.0.0.1";
        string usuario = "root";
        string senha = "1208";
        string porta = "3306";

        public string StringConexao()
        {
            string connStr = "Database=" + bancoDados + "; Data Source=" + servidor + "; Port=" + porta + "; User Id=" + usuario + "; Password=" + senha + ";";
            return connStr;
        }

        public int TesteConexao()
        {
            DataSet conexaoDataSet = new DataSet();
            var conexao = new MySqlConnection(StringConexao());
            try
            {

                conexao.Open();
                MySqlCommand verifica = new MySqlCommand("select * from registros", conexao);
                bool resultado = verifica.ExecuteReader().HasRows;

                if (resultado == true)
                {
                    //Conexao Ok
                    conexao.Close();
                    return 2;

                }
                else
                {
                    //Tabela registro vazia!
                    conexao.Close();
                    return 1;
                }

            }

            catch
            {
                //Erro de conexão com o banco de dados                
                conexao.Close();
                return 0;
            }
        }

            public bool CriarBaseDados()
            {
                try
                {
                    string connStr = "server=" + servidor + ";user=" + usuario + ";port=" + porta + ";password=" + senha + ";";
                    using (var conn = new MySqlConnection(connStr))
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `" + bancoDados + "`;";
                        cmd.ExecuteNonQuery();
                    }



                    //Tabelas 
                    CriarTabelas_EmpresaMatriz();
                    CriarTabelas_Fornecedor();
                    CriarTabelas_Loja();
                    CriarTabelas_Produto();
                    CriarTabelas_Distribuicao();
                    CriarTabelas_DistribuicaoDetalhe();


                    return true;

                }
                catch (Exception)
                {
                    return false;
                }
            }



        #region Criar Tabelas

        public void CriarTabelas_EmpresaMatriz()
        {
            string connStr = "Database=" + bancoDados + "; Data Source=" + servidor + "; Port=" + porta + "; User Id=" + usuario + "; Password=" + senha + ";";
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `EmpresaMatriz` ("
                 + "`E_Id` INT NOT NULL AUTO_INCREMENT,"
                 + "`E_RazaoSocial` VARCHAR(50) NULL ,"
                 + "`E_CNPJ` VARCHAR(20) NULL ,"
                 + "`E_IE` VARCHAR(20) NULL ,"
                 + "`E_Endereco` VARCHAR(50) NULL ,"
                 + "`E_Complemento` VARCHAR(20) NULL ,"
                 + "`E_Estado` VARCHAR(2) NULL ,"
                 + "`E_Telefone` VARCHAR(15) NULL ,"
                 + "`E_Email` VARCHAR(50) NULL ,"
                                 + "PRIMARY KEY (`E_Id`));";
                cmd.ExecuteNonQuery();
            }
        }
        public void CriarTabelas_Fornecedor()
        {
            string connStr = "Database=" + bancoDados + "; Data Source=" + servidor + "; Port=" + porta + "; User Id=" + usuario + "; Password=" + senha + ";";
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `Fornecedor` ("
                 + "`E_Id` INT NOT NULL AUTO_INCREMENT,"
                 + "`E_RazaoSocial` VARCHAR(50) NULL ,"
                 + "`E_CNPJ` VARCHAR(20) NULL ,"
                 + "`E_IE` VARCHAR(15) NULL ,"
                 + "`E_Tel` VARCHAR(15) NULL ,"
                 + "`E_Contato` VARCHAR(10) NULL ,"
                 + "`E_Email` VARCHAR(30) NULL ,"
                                 + "PRIMARY KEY (`E_Id`));";
                cmd.ExecuteNonQuery();
            }
        }
        public void CriarTabelas_Loja()
        {
            string connStr = "Database=" + bancoDados + "; Data Source=" + servidor + "; Port=" + porta + "; User Id=" + usuario + "; Password=" + senha + ";";
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `Loja` ("
                 + "`L_Id` INT NOT NULL AUTO_INCREMENT,"
                 + "`L_Loja` VARCHAR(20) NULL ,"
                 + "`L_Responsavel` VARCHAR(10) NULL ,"
                 + "`L_Telefone` VARCHAR(15) NULL ,"
                 + "`L_Email` VARCHAR(30) NULL ,"
                                 + "PRIMARY KEY (`L_Id`));";
                cmd.ExecuteNonQuery();
            }
        }
        public void CriarTabelas_Produto()
        {
            string connStr = "Database=" + bancoDados + "; Data Source=" + servidor + "; Port=" + porta + "; User Id=" + usuario + "; Password=" + senha + ";";
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `Produto` ("
                 + "`P_Id` INT NOT NULL AUTO_INCREMENT,"
                 + "`P_Descricao` VARCHAR(30) NULL ,"
                 + "`P_Pcusto` DECIMAL(10,2) NULL ,"
                 + "`P_Pvenda` DECIMAL(10,2) NULL ,"
                 + "`P_Unid` VARCHAR(10) NULL ,"
                 + "`P_Fornecedor` VARCHAR(30) NULL ,"
                 + "PRIMARY KEY (`P_Id`));";
                cmd.ExecuteNonQuery();
            }
        }


        public void CriarTabelas_Distribuicao()
        {
            string connStr = "Database=" + bancoDados + "; Data Source=" + servidor + "; Port=" + porta + "; User Id=" + usuario + "; Password=" + senha + ";";
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `Distribuicao` ("
                 + "`Dis_Id` INT NOT NULL AUTO_INCREMENT,"
                 + "`Dis_DataDefinida` DATETIME NULL ,"
                 + "`Dis_DataGravacao` DATETIME NULL ,"
                 + "`Dis_Total` DECIMAL(10,2) NULL ,"
                 + "`Dis_Operador` INT NULL ,"
                 + "PRIMARY KEY (`Dis_Id`));";
                cmd.ExecuteNonQuery();
            }
        }

        public void CriarTabelas_DistribuicaoDetalhe()
        {
            string connStr = "Database=" + bancoDados + "; Data Source=" + servidor + "; Port=" + porta + "; User Id=" + usuario + "; Password=" + senha + ";";
            using (var conn = new MySqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `DistribuicaoDetalhe` ("
                 + "`DistD_Id` INT NOT NULL AUTO_INCREMENT,"
                 + "`DistD_CodDistribuicao` INT NULL ,"
                 + "`DistD_CodProduto` INT NULL ,"
                 + "`DistD_CodLoja` INT NULL ,"
                 + "`DistD_NomeProduto` VARCHAR(30) NULL ,"
                 + "`DistD_ProdutoValorUnid` DECIMAL(10,2) NULL ,"
                 + "`DistD_ProdutoQtde` INT NULL ,"
                 + "`DistD_ProdutoValorTotal` DECIMAL(10,2) NULL ,"
                 + "`DistD_CodFornecedor` INT NULL ,"
                 + "`DistD_FornecedorValor` DECIMAL(10,2) NULL ,"
                 + "PRIMARY KEY (`DistD_Id`));";
                cmd.ExecuteNonQuery();
            }
        }


        #endregion


    }
}
