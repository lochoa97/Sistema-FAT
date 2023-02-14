namespace Sistema_FAT
{
    partial class Pantalla_Principal
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
            this.Panel_Lateral = new System.Windows.Forms.Panel();
            this.Margen = new System.Windows.Forms.Panel();
            this.Panel_Contenido = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_OArchivos = new System.Windows.Forms.Button();
            this.btn_Disco = new System.Windows.Forms.Button();
            this.btn_OS = new System.Windows.Forms.Button();
            this.Panel_Lateral.SuspendLayout();
            this.Panel_Contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Lateral
            // 
            this.Panel_Lateral.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Panel_Lateral.Controls.Add(this.btn_OS);
            this.Panel_Lateral.Controls.Add(this.Margen);
            this.Panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Lateral.Location = new System.Drawing.Point(0, 0);
            this.Panel_Lateral.Name = "Panel_Lateral";
            this.Panel_Lateral.Size = new System.Drawing.Size(255, 749);
            this.Panel_Lateral.TabIndex = 0;
            // 
            // Margen
            // 
            this.Margen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Margen.Location = new System.Drawing.Point(0, 0);
            this.Margen.Name = "Margen";
            this.Margen.Size = new System.Drawing.Size(255, 59);
            this.Margen.TabIndex = 0;
            // 
            // Panel_Contenido
            // 
            this.Panel_Contenido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel_Contenido.Controls.Add(this.label10);
            this.Panel_Contenido.Controls.Add(this.label9);
            this.Panel_Contenido.Controls.Add(this.label8);
            this.Panel_Contenido.Controls.Add(this.label7);
            this.Panel_Contenido.Controls.Add(this.label6);
            this.Panel_Contenido.Controls.Add(this.label5);
            this.Panel_Contenido.Controls.Add(this.label4);
            this.Panel_Contenido.Controls.Add(this.label3);
            this.Panel_Contenido.Controls.Add(this.label2);
            this.Panel_Contenido.Controls.Add(this.label1);
            this.Panel_Contenido.Controls.Add(this.btn_Salir);
            this.Panel_Contenido.Controls.Add(this.button1);
            this.Panel_Contenido.Controls.Add(this.btn_OArchivos);
            this.Panel_Contenido.Controls.Add(this.btn_Disco);
            this.Panel_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenido.Location = new System.Drawing.Point(255, 0);
            this.Panel_Contenido.Name = "Panel_Contenido";
            this.Panel_Contenido.Size = new System.Drawing.Size(1115, 749);
            this.Panel_Contenido.TabIndex = 1;
            this.Panel_Contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Contenido_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Salir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Archivos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Operacion con";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Disco Local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Configuracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Del OS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Configuracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Para el uso del control  del File System con los parametros de FAT.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Esta plataforma es un simulador de maquina virtual para hacer demostraciones de l" +
    "os diferentes sistemas operativos ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "¡ Bienvenido a Virtual OS Grupo 4 !";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Image = global::Sistema_FAT.Properties.Resources.cerrar2;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Salir.Location = new System.Drawing.Point(251, 28);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(65, 0);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Sistema_FAT.Properties.Resources.configuraciones2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(22, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 60);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_OArchivos
            // 
            this.btn_OArchivos.BackColor = System.Drawing.Color.White;
            this.btn_OArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OArchivos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_OArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OArchivos.Image = global::Sistema_FAT.Properties.Resources.carpeta2;
            this.btn_OArchivos.Location = new System.Drawing.Point(176, 28);
            this.btn_OArchivos.Name = "btn_OArchivos";
            this.btn_OArchivos.Size = new System.Drawing.Size(65, 60);
            this.btn_OArchivos.TabIndex = 3;
            this.btn_OArchivos.UseVisualStyleBackColor = false;
            // 
            // btn_Disco
            // 
            this.btn_Disco.BackColor = System.Drawing.Color.White;
            this.btn_Disco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Disco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Disco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Disco.Image = global::Sistema_FAT.Properties.Resources.disco_duro2;
            this.btn_Disco.Location = new System.Drawing.Point(97, 28);
            this.btn_Disco.Name = "btn_Disco";
            this.btn_Disco.Size = new System.Drawing.Size(65, 60);
            this.btn_Disco.TabIndex = 2;
            this.btn_Disco.UseVisualStyleBackColor = false;
            // 
            // btn_OS
            // 
            this.btn_OS.BackColor = System.Drawing.Color.White;
            this.btn_OS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OS.Location = new System.Drawing.Point(31, 81);
            this.btn_OS.Name = "btn_OS";
            this.btn_OS.Size = new System.Drawing.Size(196, 51);
            this.btn_OS.TabIndex = 1;
            this.btn_OS.Text = "Configuracion del OS";
            this.btn_OS.UseVisualStyleBackColor = false;
            this.btn_OS.Click += new System.EventHandler(this.btn_OS_Click);
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Panel_Contenido);
            this.Controls.Add(this.Panel_Lateral);
            this.Name = "Pantalla_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla_Principal";
            this.Panel_Lateral.ResumeLayout(false);
            this.Panel_Contenido.ResumeLayout(false);
            this.Panel_Contenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Lateral;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_OArchivos;
        private System.Windows.Forms.Button btn_Disco;
        private System.Windows.Forms.Panel Margen;
        private System.Windows.Forms.Panel Panel_Contenido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_OS;
    }
}