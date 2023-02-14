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
using System.Diagnostics;

namespace Sistema_FAT
{
    public partial class Directorio_Archivos : Form
    {
        private string filePath = @"C:\File Alocation Table";
        private bool isFile = false;
        private string currentlySelectedItemName = "";

        public Directorio_Archivos()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FilePath.Text = filePath;
            cargarArchivosDirectorio();
        }

        public void cargarArchivosDirectorio()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;

            try
            {

                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    NombreArchivo.Text = fileDetails.Name;
                    TipoArchivo.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {

                    fileAttr = File.GetAttributes(filePath);
                
                } 

                if((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); //Con este parametro nos ayudara a obtener los archivos creados.
                    DirectoryInfo[] dirs = fileList.GetDirectories(); //Con este parametro nos ayudara a obtener el directorio complento de archivos.
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        listView1.Items.Add(files[i].Name, 1);
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 0);
                    }
                }
                else
                {
                    NombreArchivo.Text = this.currentlySelectedItemName;
                }
            }

            catch (Exception e)
            {

            }

        }

        public void cargarArchivos()
        {
            atras();
            filePath = FilePath.Text;
            cargarArchivosDirectorio();
            isFile = false;
        }

        public void atras()
        {
            string path = FilePath.Text;
            if(path.LastIndexOf("/") == path.Length -1) 
            { 
                FilePath.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goAtras()
        { 
            try
            {
                atras();
                string path = FilePath.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                FilePath.Text = path;
                atras();
            }
            catch(Exception e) 
            {

            }
        }



    private void button2_Click(object sender, EventArgs e)
        {
                cargarArchivos();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if((fileAttr & FileAttributes.Directory) == FileAttributes.Directory) 
            {
                isFile = false;
                FilePath.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cargarArchivos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goAtras();
            cargarArchivos();
        }
    }
}
