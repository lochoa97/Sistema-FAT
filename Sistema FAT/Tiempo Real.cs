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
    public partial class Tiempo_Real : Form
    {

        string Path = @"C:\File Alocation Table";
        public Tiempo_Real()
        {
            InitializeComponent();
        }

        private void Tiempo_Real_Load(object sender, EventArgs e)
        {
            fileSystemWatcher1.Path = Path;
            GetFiles();
        }
        private void GetFiles()
        {
            string[] lst = Directory.GetFiles(Path);
            textBox1.Text = "";
            foreach (var sFile in lst)
            {
                textBox1.Text += sFile + Environment.NewLine;
            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            GetFiles();
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            GetFiles();
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            GetFiles();
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            GetFiles();
        }
    }
}
