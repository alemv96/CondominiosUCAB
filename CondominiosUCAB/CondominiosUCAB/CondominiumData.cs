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
        private string query, serverInfo;
        private bool openClose;
        private DataSet data;
        private NpgsqlConnection con = new NpgsqlConnection();

        public CondominiumData()
        {
            this.query = "";
            this.serverInfo = "Server=localhost;" + "Port=5432;" + "User iD=postgres;" + "Password=b0cp653e#;" + "DATABASE=ProyectoEdificios;";
            this.data = new DataSet();
            this.con = new NpgsqlConnection();
            this.openClose = false;
        }

        public DataSet get_Data(){return data;}

        public string Data_Connect()
        {
            try
            {
                con.ConnectionString = serverInfo;
                con.Open();
                openClose = true;
                //query = "SELECT * FROM propietarios"; //hacer mejor en la bases de datos
                // NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, con);
                // add.Fill(data);
                con.Close();
                openClose = false;
                //query = "";

                return "si se logro conexion";
            }
            catch
            {
                if (openClose) con.Close();
                openClose = false;
                return "no se logro conexion";
                
            }       
        }

        public void insert(string query)
        {
            try {
                con.Open();
                openClose = true;
                NpgsqlCommand command = new NpgsqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();            
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine("Error Insert: " + e.Message);
                if (openClose) con.Close();
                openClose = false;
            }
        }

        public void delete(string query)
        {
            try
            {
                con.Open();
                openClose = true;
                NpgsqlCommand command = new NpgsqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine("Error Delete: " + e.Message);
                if (openClose) con.Close();
                openClose = false;
            }
        }

        public void update(string query)
        {
            try
            {
                con.Open();
                openClose = true;
                NpgsqlCommand command = new NpgsqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine("Error Update: " + e.Message);
                if (openClose) con.Close();
                openClose = false;
            }
        }

        public void consult(string query)
        {
            try
            {
                con.Open();
                openClose = true;
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, con);
                adapter.Fill(data);
                con.Close();
            }
            catch (Exception e)
            {
                System.Console.Out.WriteLine("Error Update: " + e.Message);
                if (openClose) con.Close();
                openClose = false;
            }
        }
    }
}
