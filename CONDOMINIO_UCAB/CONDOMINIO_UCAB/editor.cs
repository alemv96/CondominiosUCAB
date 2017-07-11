using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONDOMINIO_UCAB
{
    public partial class editor : Form
    {
        public editor()
        {
            InitializeComponent();
        }
        public editor(int modo, int entidad) {
            InitializeComponent();
            if (modo == 1)  { //si modo es 1 se coloca en el titulo de la ventana que se va a agregar un objeto a la  entidad X
               barra_superior.Text = "Agregar nuevo ";
            }
            if (modo == 2) {   // si modo es 2 se coloca en el titulo de la ventana que se va a modificar un objeto de la entidad X
              barra_superior.Text = "Modificar ";
            }
            if (entidad == 1) {
                barra_superior.Text += "edificio"; // aqui se coloca que entidad se esta modificando o agregando
                crearbloque("RIF", 1);   // el primer valor corresponde al titulo que llevara el campo a rellenar
                crearbloque("lugar", 2); // el segundo valor corresponde a si sera un textbox o un combo lo que se utilizara
                crearbloque("otra paja", 1); // 1 si es texbox, 2 si es cambobox
                crearbloque("mas paja", 1);
                crearbloque("mas paja x 2", 1);
            
            }

        }
        private void crearbloque(string vtitulo, int relleno) {
            Panel panel = new Panel(); // se crean los objetos graficos y se le asignan caracteristicas graficas
            Label titulo = new Label();
            TextBox cajadetexto = new TextBox();
            ComboBox combo = new ComboBox();
            panel.Size = new Size(636, 87);

            cajadetexto.Visible = false;
            combo.Visible = false;
            titulo.AutoSize = true;
            titulo.Font = new Font("Roboto", 15f);
            titulo.ForeColor = System.Drawing.Color.FromArgb(158,158,158);
            titulo.Text = vtitulo;
            panel.Controls.Add(titulo);
            titulo.Location = new Point(12, 14);
            

            panel_principal.Controls.Add(panel);

            if (relleno == 1) { // si se escogio texbox
                cajadetexto.Visible = true;
                cajadetexto.Size = new Size(565, 20);
                panel.Controls.Add(cajadetexto);
                cajadetexto.Location = new Point(48, 50);
            }
            if (relleno == 2) { // si se escogio combo box
                combo.Visible = true;
                combo.Size = new Size(565, 20);
                panel.Controls.Add(combo);
                combo.Location = new Point(48, 50);
                combo.Visible = true;
            }

        
        
        }
        private void editor_Load(object sender, EventArgs e)
        {

        }
    }
}
