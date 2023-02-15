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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_FAT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter registrar = new StreamWriter(@"C:\Users\lochoa\Desktop\LuisOchoa\ceutec\SistemaFAT\Sistema FAT\BD\OS.txt", true);
            try
            {
                registrar.WriteLine("Memoria Ram: " + txt_Memoria.Text);
                registrar.WriteLine("Virtualizacion: " + comboBox2.Text);
                registrar.WriteLine("\n");
                registrar.WriteLine("\n");

                MessageBox.Show("Información de tarjeta RAM guardada con exito!");

                this.Close();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            registrar.Close();

            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form ventana3 = new Form2();
            ventana3.Show();
            this.Hide();
        }
    }
    
}
