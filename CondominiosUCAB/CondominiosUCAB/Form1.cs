using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondominiosUCAB
{
    public partial class Form1 : Form
    {
        CondominiumData data;
        public Form1()
        {
            //conexion a postgres
            data = new CondominiumData();
            string message = data.Data_Connect();
            System.Console.Out.WriteLine(message);
            //conexion a postgres          
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void insertD_Click(object sender, EventArgs e)
        {
            data.insert("INSERT INTO propietario VALUES ('" + data1.Text + "','" + data2.Text + "','" + data3.Text + "');");
        }

        
        private void deleteD_Click(object sender, EventArgs e)
        {
            data.delete("DELETE FROM propietario WHERE idpropietario = " + data1.Text + ";");
        }

        private void updateD_Click(object sender, EventArgs e)
        {
            data.update("UPDATE propietario SET nombre = '" + data2.Text + "', necesidades = '" + data3.Text + "' WHERE idpropietario = " + data1.Text + ";");
        }
    }
}