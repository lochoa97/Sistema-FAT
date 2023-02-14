
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FAT
{
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
        }

       
            private void AbrirFormHija(object formHija)
        {
            if(this.Panel_Contenido.Controls.Count> 0)
                this.Panel_Contenido.Controls.RemoveAt(0);
            Form fh =formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenido.Controls.Add(fh);
            this.Panel_Contenido.Tag = fh;
            fh.Show();
        }
        private void btn_OS_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ConfiguracionOS());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ventanaOS = new ConfiguracionOS();
            ventanaOS.Show();
        }

        private void Panel_Contenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
