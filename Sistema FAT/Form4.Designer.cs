namespace Sistema_FAT
{
    partial class Directorio_Archivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directorio_Archivos));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreArchivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoArchivo = new System.Windows.Forms.Label();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(127, 36);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(338, 20);
            this.FilePath.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(46, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 229);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Archivo";
            // 
            // NombreArchivo
            // 
            this.NombreArchivo.AutoSize = true;
            this.NombreArchivo.Location = new System.Drawing.Point(242, 376);
            this.NombreArchivo.Name = "NombreArchivo";
            this.NombreArchivo.Size = new System.Drawing.Size(13, 13);
            this.NombreArchivo.TabIndex = 5;
            this.NombreArchivo.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Archivo";
            // 
            // TipoArchivo
            // 
            this.TipoArchivo.AutoSize = true;
            this.TipoArchivo.Location = new System.Drawing.Point(484, 376);
            this.TipoArchivo.Name = "TipoArchivo";
            this.TipoArchivo.Size = new System.Drawing.Size(13, 13);
            this.TipoArchivo.TabIndex = 7;
            this.TipoArchivo.Text = "--";
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "carpetaicono.png");
            this.iconList.Images.SetKeyName(1, "txticono.png");
            // 
            // Directorio_Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.TipoArchivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Directorio_Archivos";
            this.Text = "Directorio_Archivos";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TipoArchivo;
    }
}