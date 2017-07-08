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
    public partial class Menu : Form
    {
        public Menu()
        { 
            //conexion a postgres  
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 propietario = new Form1();
            propietario.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
