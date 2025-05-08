using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProjetoIntegrador.conn
{
    internal class ConexaoBanco
    {
        // String de conexão com o banco de dados
        public string caminho = "SERVER=localhost; UID=root; PASSWORD=; DATABASE=SEHD";
        MySqlConnection conexao = null;

        // Método para INSERT, UPDATE ou DELETE
        public void ManipulaDados(string Query_DB)
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(Query_DB, conexao);
                comando.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        // Método para SELECT — retorna os dados em DataTable
        public DataTable CarregaDados(string consulta)
        {
            conexao = new MySqlConnection(caminho);
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);
            return resultado;
        }
    }
}