﻿
namespace Bodega
{
    partial class Reportes
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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> ded203d ("reporte")
            this.TxAdmin = new System.Windows.Forms.Label();
            this.TxFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CBTipoUnidad = new System.Windows.Forms.ComboBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtMin = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.PAdmin = new System.Windows.Forms.PictureBox();
            this.BtIngresos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtReporte = new System.Windows.Forms.Button();
            this.BtCon = new System.Windows.Forms.Button();
            this.BtEgresos = new System.Windows.Forms.Button();
            this.BtCajaC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            this.timer1 = new System.Windows.Forms.Timer(this.components);
=======
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
>>>>>>> ded203d ("reporte")
            ((System.ComponentModel.ISupportInitialize)(this.PAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxAdmin
            // 
            this.TxAdmin.AutoSize = true;
            this.TxAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.TxAdmin.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxAdmin.Location = new System.Drawing.Point(172, 70);
            this.TxAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxAdmin.Name = "TxAdmin";
            this.TxAdmin.Size = new System.Drawing.Size(140, 41);
            this.TxAdmin.TabIndex = 20;
            this.TxAdmin.Text = "Admin";
            // 
            // TxFecha
            // 
            this.TxFecha.AutoSize = true;
            this.TxFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.TxFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxFecha.Location = new System.Drawing.Point(180, 111);
            this.TxFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxFecha.Name = "TxFecha";
            this.TxFecha.Size = new System.Drawing.Size(137, 20);
            this.TxFecha.TabIndex = 21;
            this.TxFecha.Text = "dd/mm/aaaa";
            this.TxFecha.Click += new System.EventHandler(this.TxFecha_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 137);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 34);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(581, 137);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(203, 34);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(960, 382);
            this.dataGridView1.TabIndex = 47;
            // 
            // CBTipoUnidad
            // 
            this.CBTipoUnidad.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipoUnidad.Items.AddRange(new object[] {
            "EGRESOS",
            "INGRESOS",
            "CAJA CHICA"});
            this.CBTipoUnidad.Location = new System.Drawing.Point(842, 137);
            this.CBTipoUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.CBTipoUnidad.Name = "CBTipoUnidad";
            this.CBTipoUnidad.Size = new System.Drawing.Size(411, 34);
            this.CBTipoUnidad.TabIndex = 49;
            // 
            // btnPdf
            // 
            this.btnPdf.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPdf.Image = global::Bodega.Properties.Resources.Grupo_81;
            this.btnPdf.Location = new System.Drawing.Point(1007, 579);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(259, 83);
            this.btnPdf.TabIndex = 48;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::Bodega.Properties.Resources.Grupo_71;
            this.button2.Location = new System.Drawing.Point(717, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 83);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtMin
            // 
            this.BtMin.BackgroundImage = global::Bodega.Properties.Resources.Rectángulo_8;
            this.BtMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMin.Location = new System.Drawing.Point(1536, 15);
            this.BtMin.Margin = new System.Windows.Forms.Padding(4);
            this.BtMin.Name = "BtMin";
            this.BtMin.Size = new System.Drawing.Size(85, 17);
            this.BtMin.TabIndex = 27;
            this.BtMin.UseVisualStyleBackColor = true;
            this.BtMin.Click += new System.EventHandler(this.BtMin_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.BackgroundImage = global::Bodega.Properties.Resources.Rectángulo_7;
            this.BtSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSalir.Location = new System.Drawing.Point(1629, 15);
            this.BtSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(85, 17);
            this.BtSalir.TabIndex = 26;
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // PAdmin
            // 
            this.PAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.PAdmin.BackgroundImage = global::Bodega.Properties.Resources.user_shape_icon_icons_com_73346;
            this.PAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PAdmin.Location = new System.Drawing.Point(44, 36);
            this.PAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.PAdmin.Name = "PAdmin";
            this.PAdmin.Size = new System.Drawing.Size(113, 107);
            this.PAdmin.TabIndex = 25;
            this.PAdmin.TabStop = false;
            // 
            // BtIngresos
            // 
            this.BtIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.BtIngresos.BackgroundImage = global::Bodega.Properties.Resources.Grupo_2;
            this.BtIngresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtIngresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtIngresos.FlatAppearance.BorderSize = 0;
            this.BtIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtIngresos.Location = new System.Drawing.Point(0, 169);
            this.BtIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.BtIngresos.Name = "BtIngresos";
            this.BtIngresos.Size = new System.Drawing.Size(320, 86);
            this.BtIngresos.TabIndex = 24;
            this.BtIngresos.UseVisualStyleBackColor = false;
            this.BtIngresos.Click += new System.EventHandler(this.BtIngresos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Bodega.Properties.Resources.Trazado_1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(351, 70);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1367, 784);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.button1.BackgroundImage = global::Bodega.Properties.Resources.arrow_entrance_exit_internet_log_out_security_icon_127059;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(171, 660);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 119);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtReporte
            // 
            this.BtReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.BtReporte.BackgroundImage = global::Bodega.Properties.Resources.Grupo_191;
            this.BtReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtReporte.FlatAppearance.BorderSize = 0;
            this.BtReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtReporte.Location = new System.Drawing.Point(1, 513);
            this.BtReporte.Margin = new System.Windows.Forms.Padding(4);
            this.BtReporte.Name = "BtReporte";
            this.BtReporte.Size = new System.Drawing.Size(351, 86);
            this.BtReporte.TabIndex = 18;
            this.BtReporte.UseVisualStyleBackColor = false;
            this.BtReporte.Click += new System.EventHandler(this.BtReporte_Click);
            // 
            // BtCon
            // 
            this.BtCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.BtCon.BackgroundImage = global::Bodega.Properties.Resources.Grupo_19;
            this.BtCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCon.FlatAppearance.BorderSize = 0;
            this.BtCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCon.Location = new System.Drawing.Point(1, 427);
            this.BtCon.Margin = new System.Windows.Forms.Padding(4);
            this.BtCon.Name = "BtCon";
            this.BtCon.Size = new System.Drawing.Size(320, 86);
            this.BtCon.TabIndex = 17;
            this.BtCon.UseVisualStyleBackColor = false;
            this.BtCon.Click += new System.EventHandler(this.BtCon_Click);
            // 
            // BtEgresos
            // 
            this.BtEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.BtEgresos.BackgroundImage = global::Bodega.Properties.Resources.Grupo_18;
            this.BtEgresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEgresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEgresos.FlatAppearance.BorderSize = 0;
            this.BtEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEgresos.Location = new System.Drawing.Point(0, 341);
            this.BtEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.BtEgresos.Name = "BtEgresos";
            this.BtEgresos.Size = new System.Drawing.Size(320, 86);
            this.BtEgresos.TabIndex = 16;
            this.BtEgresos.UseVisualStyleBackColor = false;
            this.BtEgresos.Click += new System.EventHandler(this.BtEgresos_Click);
            // 
            // BtCajaC
            // 
            this.BtCajaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(2)))));
            this.BtCajaC.BackgroundImage = global::Bodega.Properties.Resources.Grupo_17;
            this.BtCajaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtCajaC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtCajaC.FlatAppearance.BorderSize = 0;
            this.BtCajaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCajaC.Location = new System.Drawing.Point(1, 255);
            this.BtCajaC.Margin = new System.Windows.Forms.Padding(4);
            this.BtCajaC.Name = "BtCajaC";
            this.BtCajaC.Size = new System.Drawing.Size(320, 86);
            this.BtCajaC.TabIndex = 15;
            this.BtCajaC.UseVisualStyleBackColor = false;
            this.BtCajaC.Click += new System.EventHandler(this.BtCajaC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Bodega.Properties.Resources.Rectángulo_22;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 857);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(37)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1733, 886);
=======
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.CBTipoUnidad);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
>>>>>>> ded203d ("reporte")
            this.Controls.Add(this.BtMin);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.PAdmin);
            this.Controls.Add(this.BtIngresos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TxFecha);
            this.Controls.Add(this.TxAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtReporte);
            this.Controls.Add(this.BtCon);
            this.Controls.Add(this.BtEgresos);
            this.Controls.Add(this.BtCajaC);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.Reportes_Load);
=======
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
>>>>>>> ded203d ("reporte")
            ((System.ComponentModel.ISupportInitialize)(this.PAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtEgresos;
        private System.Windows.Forms.Button BtCon;
        private System.Windows.Forms.Button BtCajaC;
        private System.Windows.Forms.Button BtReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TxAdmin;
        private System.Windows.Forms.Label TxFecha;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtIngresos;
        private System.Windows.Forms.PictureBox PAdmin;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtMin;
<<<<<<< HEAD
        private System.Windows.Forms.Timer timer1;
=======
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.ComboBox CBTipoUnidad;
>>>>>>> ded203d ("reporte")
    }
}
