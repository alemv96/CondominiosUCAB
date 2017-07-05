using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using Npgsql;
using NpgsqlTypes;
using System.Data;*/

namespace CondominiosUCAB
{
    static class Program{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            CondominiumData data = new CondominiumData();
            string message = data.Data_Connect();
            //conexion a postgres
        }
    }
}
