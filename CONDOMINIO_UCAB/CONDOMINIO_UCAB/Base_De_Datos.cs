using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Reflection;
using System.Data.Odbc;
using Npgsql;
using NpgsqlTypes;

namespace CONDOMINIO_UCAB
{
    class Base_De_Datos
    {
        string parametros = "Server=localhost;" + "Port=5432;" + "User iD=postgres;" + "Password=21130175;" + "DATABASE=ProyectoEdificios;";
        DataSet datos = new DataSet();
        NpgsqlConnection con = new NpgsqlConnection();
        public string conectar()
        {

            try
            {
                con.ConnectionString = parametros;
                con.Open();
                return "si pudo";
            }
            catch
            {
                return "0";
            }

        }
    }
}
