using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace Bar.Models
{
    public class BarRepository
    {
        private const string conectaDados = "DataBase=bar;Data Source=localhost;User id=root";

        public void TestaConexao()
        {
           MySqlConnection conexao = new MySqlConnection(conectaDados) ;
           conexao.Open();
           Console.WriteLine("conectou.");
           conexao.Close();
        }
        //
        public void InserirCliente(Bar cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();
            string query = "INSERT INTO pedidos (nomeClientePublic, loginClientePublic, senhaClientePublic, telefoneClientePublic) VALUES (@nomeClientePublic,@loginClientePublic, @senhaClientePublic, @telefoneClientePublic)";
            MySqlCommand comando  = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@nomeClientePublic", cliente.nomeClientePublic);
            comando.Parameters.AddWithValue("@loginClientePublic", cliente.loginClientePublic);
            comando.Parameters.AddWithValue("@senhaClientePublic", cliente.senhaClientePublic);
            comando.Parameters.AddWithValue("@telefonePublic", cliente.telefonePublic);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}