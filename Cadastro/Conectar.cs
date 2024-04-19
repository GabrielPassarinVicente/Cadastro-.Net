using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro;

public class Conectar
{
    private string connectionString = "Host=localhost;Username=postgres;Password=e14vg100kpm!;Database=Db_Cadastro";
    private string connectionString2 = "Host=localhost;Username=postgres;Password=e14vg100kpm!;Database=cadCategoria";
    private string connectionString3 = "Host=localhost;Username=postgres;Password=e14vg100kpm!;Database=Login";
    private string connectionString4 = "Host=localhost;Username=postgres;Password=e14vg100kpm!;Database=log";

    public NpgsqlConnection Conectando()
    {
        NpgsqlConnection conn = new NpgsqlConnection(connectionString);
        conn.Open();
        return conn;
    }
    public NpgsqlConnection Conecta()
    {
        NpgsqlConnection conn1 = new NpgsqlConnection(connectionString2);
        conn1.Open();
        return conn1;

    }
    public NpgsqlConnection Login()
    {
        NpgsqlConnection conn2 = new NpgsqlConnection(connectionString3);
        conn2.Open();
        return conn2;

    }
    public NpgsqlConnection log()
    {
        NpgsqlConnection conn3 = new NpgsqlConnection(connectionString4);
        conn3.Open();
        return conn3;
    }

    
}



