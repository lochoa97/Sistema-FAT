using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_FAT
{
    public partial class ConfiguracionOS : Form
    {
        public ConfiguracionOS()
        {
            InitializeComponent();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter registrar = new StreamWriter(@"C:\Users\lochoa\Desktop\LuisOchoa\ceutec\SistemaFAT\Sistema FAT\BD\OS.txt", true);
            try{
                registrar.WriteLine("Nombre: "+textBox1.Text);
                registrar.WriteLine("Tipo: " + textBox2.Text);
                registrar.WriteLine("Version: " + comboBox1.Text);
                registrar.WriteLine("\n");

                MessageBox.Show("Información del sistema operativo guardada con exito!");


                //Abrir el siguiete formulario
                Form formulario2 = new Form2();
                formulario2.Show();
                this.Close();
            }
            catch
            { MessageBox.Show("ERROR");
            }
                registrar.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
