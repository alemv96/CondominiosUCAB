using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONDOMINIO_UCAB
{
    public partial class letrero : Form
    {
        public letrero()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          
           this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           Thread hilo = new Thread(apagador);
           hilo.Start();
          
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void inicio_Resize(object sender, EventArgs e)
        {
         icono.Location = new Point((this.Size.Width / 2) - (icono.Size.Width / 2) - 30, (this.Size.Height / 2) - (icono.Size.Height / 2) - 50);
         texto.Location = new Point(icono.Location.X, icono.Location.Y + 490);
        }
        private void apagador() { 
              Thread.Sleep(2500);
              CheckForIllegalCrossThreadCalls = false;
              inicio f = new inicio();
              Base_De_Datos bases = new Base_De_Datos();
              if (bases.conectar() == "0")
              {
                  MessageBox.Show("Error: No se pudo conectar con la base de datos");

              }
              else { 
               this.Visible = false;
              f.ShowDialog();
              }
             
            this.Close();

        }
    }
}
