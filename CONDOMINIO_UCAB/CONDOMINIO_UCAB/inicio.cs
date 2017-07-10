using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONDOMINIO_UCAB
{
    public partial class inicio : Form
    {
        string direccion = Path.Combine(Application.StartupPath, "");
        string direccionimagenes;
        public inicio()
        {
            direccionimagenes = direccion.Replace("bin\\Debug", "Resources\\");
            InitializeComponent();
            this.CenterToScreen();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            responsive();
        }
        public void responsive() {
            //ajustes de imagenes
            icono.BackgroundImageLayout = ImageLayout.Stretch;
            icono2.BackgroundImageLayout = ImageLayout.Stretch;
            icono3.BackgroundImageLayout = ImageLayout.Stretch;
            icono4.BackgroundImageLayout = ImageLayout.Stretch;
            icono5.BackgroundImageLayout = ImageLayout.Stretch;
            icono6.BackgroundImageLayout = ImageLayout.Stretch;
            /////
            int X = this.Size.Width;
            int Y = this.Size.Height;
            /// ajuste de tamanos
            menu.Size = new Size(menu.Size.Width, Y - 86);
            linea_menu.Size = new Size(1, Y - 86);
            barra_superior.Size = new Size(X, barra_superior.Size.Height);
            panel_detalles.Size = new Size(menu.Size.Width, Y - 86);
            linea_detalles.Size = new Size(1, Y - 86);
            tabla.Size = new Size(X - 587, Y - 300);

            int num = tabla.ColumnCount;
            int j = 0;
            while (j < num) {
                tabla.Columns[j].Width = ((tabla.Size.Width - 45) / num);
                j++;
            }
            //ajustes de posiciones
            panel_detalles.Location = new Point(X-217,panel_detalles.Location.Y);
            linea_detalles.Location = new Point(X - 220, linea_detalles.Location.Y);


        }
        private void edificio_MouseEnter(object sender, EventArgs e)
        {
            edificio.ForeColor = System.Drawing.Color.FromArgb(50,181,214);
            icono.BackgroundImage = new Bitmap(direccionimagenes + "edificio_azul.png");
        }

        private void edificio_MouseLeave(object sender, EventArgs e)
        {
            edificio.ForeColor = System.Drawing.Color.FromArgb(128,128,128);
            icono.BackgroundImage = new Bitmap(direccionimagenes + "edificio_gris.png");
        }

        private void apartamento_MouseEnter(object sender, EventArgs e)
        {
            apartamento.ForeColor = System.Drawing.Color.FromArgb(50, 181, 214);
            icono2.BackgroundImage = new Bitmap(direccionimagenes + "llave_azul.png");
        }

        private void apartamento_MouseLeave(object sender, EventArgs e)
        {
            apartamento.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            icono2.BackgroundImage = new Bitmap(direccionimagenes + "llave_gris.png");
        }

        private void propietario_MouseEnter(object sender, EventArgs e)
        {
            propietario.ForeColor = System.Drawing.Color.FromArgb(50, 181, 214);
            icono3.BackgroundImage = new Bitmap(direccionimagenes + "propietario_azul.png");
        }

        private void propietario_MouseLeave(object sender, EventArgs e)
        {
            propietario.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            icono3.BackgroundImage = new Bitmap(direccionimagenes + "propietario_gris.png");
        }

        private void junta_MouseEnter(object sender, EventArgs e)
        {
            junta.ForeColor = System.Drawing.Color.FromArgb(50, 181, 214);
            icono4.BackgroundImage = new Bitmap(direccionimagenes + "junta_azul.png");
        }

        private void junta_MouseLeave(object sender, EventArgs e)
        {
            junta.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            icono4.BackgroundImage = new Bitmap(direccionimagenes + "junta_gris.png");
        }

        private void gasto_MouseEnter(object sender, EventArgs e)
        {
          gasto.ForeColor = System.Drawing.Color.FromArgb(50, 181, 214);
            icono5.BackgroundImage = new Bitmap(direccionimagenes + "gastos_azul.png");
        }

        private void gasto_MouseLeave(object sender, EventArgs e)
        {
           gasto.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            icono5.BackgroundImage = new Bitmap(direccionimagenes + "gastos_gris.png");
        }

        private void aviso_MouseEnter(object sender, EventArgs e)
        {
           aviso.ForeColor = System.Drawing.Color.FromArgb(50, 181, 214);
            icono6.BackgroundImage = new Bitmap(direccionimagenes + "recibos_azul.png");
        }

        private void aviso_MouseLeave(object sender, EventArgs e)
        {
           aviso.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            icono6.BackgroundImage = new Bitmap(direccionimagenes + "recibos_gris.png");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            responsive();
        }
    }
}
