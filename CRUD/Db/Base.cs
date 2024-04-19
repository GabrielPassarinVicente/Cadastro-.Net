using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Db;
public class Base
{
    //conexão do banco de dados 
    private string connectionString = "Host=localhost;Port=5432;Username=seu_usuario;Password=sua_senha;Database=seu_banco";

    public void IncluirPessoa()
    {
        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
        {
            con.Open();
            string query = "INSERT INTO pessoas (nome, idade) VALUES (@Nome, @Idade)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                
            }
        }
    }
}

