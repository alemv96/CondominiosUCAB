using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace CondominiosUCAB
{
    class CondominiumData
    {
        public CondominiumData() { }

        public string Data_Connect()
        {
            string serverInfo = "Server=localhost;" + "Port=5432;" + "User iD=postgres;" + "Password=1234;" + "DATABASE=ProyectoEdificios;";
            DataSet datos = new DataSet();
            NpgsqlConnection con = new NpgsqlConnection();


            try
            {
                con.ConnectionString = serverInfo;
                con.Open();
                return "si se logro conexion";

            }
            catch
            {
              return "no se logro conexion";
            }
        }

    }
}
