using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sitema_PI
{
    class conexao
    {
        private MySqlConnection conn; //conexão
        private DataTable data; //gerencia tabela de dados
        private MySqlDataAdapter da; //adaptador
        private MySqlDataReader dr; //leitura de dados
        private MySqlCommandBuilder cb; // construtor de comando sql

        public static String server = "localhost";
        public static String user = "root";
        public static String password = "";
        public static String database = "sistemapidb";

        public void conectar()
        {
            if (conn != null)
            {
                conn.Close();
            }

            string connStr = String.Format("Server={0};user id={1};password={2};database={3};pooling=false", server, user, password, database);

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //usado para executar insert, update e delete
        public long ExecutarComando(string comandoSql, bool ReturnesLestInsertedId = false)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            comando.ExecuteNonQuery();

            long id = comando.LastInsertedId;
            conn.Close();

            if (ReturnesLestInsertedId == true)
            {
                return id;
            }
            else
            {
                return 0;
            }
        }

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            da.Fill(data);
            return data;
        }

        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            return dr;
        }
    }
}
