
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
            StreamReader mostrar = new StreamReader(@"C:\Users\lochoa\Desktop\LuisOchoa\ceutec\SistemaFAT\Sistema FAT\BD\OS.txt");
            lblData.Text = mostrar.ReadToEnd();
            lblData.Visible = true;
            lblso.Visible = true;
            lblram.Visible = true;
            lbldisk.Visible = true;
            imgGeneral.Visible = true;
            imgram.Visible = true;
            imgdisk.Visible = true;
            mostrar.Close();
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
            StreamReader mostrar = new StreamReader(@"C:\Users\lochoa\Desktop\LuisOchoa\ceutec\SistemaFAT\Sistema FAT\BD\OS.txt");

            var Data = mostrar.ReadToEnd();

            if(Data == "")
            {
                Form ventanaOS = new ConfiguracionOS();
                ventanaOS.Show();
            }
            else
            {
                MessageBox.Show("Ya existe un sistema operativo configurado!");
            }
            mostrar.Close();
            
        }

        private void Panel_Contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OArchivos_Click(object sender, EventArgs e)
        {
            Form form4 = new Directorio_Archivos();
            form4.Show();
        }

        private void btnFormatear_Click(object sender, EventArgs e)
        {
            StreamWriter mostrar = new StreamWriter(@"C:\Users\lochoa\Desktop\LuisOchoa\ceutec\SistemaFAT\Sistema FAT\BD\OS.txt");
            mostrar.Dispose();
            mostrar.Close();

            MessageBox.Show("Maquina virtual formateada con exito.");

        }
    }
}
