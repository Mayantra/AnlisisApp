
namespace Bodega
{
    partial class ConsultaEdicion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxAdmin = new System.Windows.Forms.Label();
            this.TxFecha = new System.Windows.Forms.Label();
            this.cbxTablas = new System.Windows.Forms.ComboBox();
            this.Tablas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnObtener = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtMostrar = new System.Windows.Forms.Button();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // cbxTablas
            // 
            this.cbxTablas.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTablas.FormattingEnabled = true;
            this.cbxTablas.Items.AddRange(new object[] {
            "Registros",
            "Caja chica",
            "Egresos",
            "Taller",
            "Area",
            "Tipo de unidades",
            "Historial ingreso",
            "Historial caja chica"});
            this.cbxTablas.Location = new System.Drawing.Point(383, 126);
            this.cbxTablas.Name = "cbxTablas";
            this.cbxTablas.Size = new System.Drawing.Size(989, 53);
            this.cbxTablas.TabIndex = 29;
            // 
            // Tablas
            // 
            this.Tablas.AutoSize = true;
            this.Tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.Tablas.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tablas.Location = new System.Drawing.Point(377, 89);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(119, 34);
            this.Tablas.TabIndex = 30;
            this.Tablas.Text = "Tablas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(383, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 458);
            this.dataGridView1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(702, 792);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 34);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(866, 792);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 40);
            this.txtNombre.TabIndex = 55;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(866, 743);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(288, 40);
            this.txtID.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 743);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 34);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(584, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 40);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 34);
            this.label3.TabIndex = 60;
            this.label3.Text = "Ver desde: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(921, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 34);
            this.label4.TabIndex = 61;
            this.label4.Text = "hasta:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1048, 203);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(323, 40);
            this.dateTimePicker2.TabIndex = 62;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.btnVer.BackgroundImage = global::Bodega.Properties.Resources.btver;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(1391, 190);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(306, 58);
            this.btnVer.TabIndex = 63;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.btnObtener.BackgroundImage = global::Bodega.Properties.Resources.btobt;
            this.btnObtener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObtener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObtener.FlatAppearance.BorderSize = 0;
            this.btnObtener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtener.Location = new System.Drawing.Point(383, 720);
            this.btnObtener.Margin = new System.Windows.Forms.Padding(4);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(306, 86);
            this.btnObtener.TabIndex = 58;
            this.btnObtener.UseVisualStyleBackColor = false;
            this.btnObtener.Click += new System.EventHandler(this.btnOptener_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.btnRegistrar.BackgroundImage = global::Bodega.Properties.Resources.btrregi;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegistrar.Location = new System.Drawing.Point(1391, 785);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(306, 58);
            this.btnRegistrar.TabIndex = 53;
            this.btnRegistrar.Text = "+";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.btnEditar.BackgroundImage = global::Bodega.Properties.Resources.Grupo_16;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(1391, 720);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(306, 58);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BtMostrar
            // 
            this.BtMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.BtMostrar.BackgroundImage = global::Bodega.Properties.Resources.Grupo_14;
            this.BtMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtMostrar.FlatAppearance.BorderSize = 0;
            this.BtMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMostrar.Location = new System.Drawing.Point(1391, 123);
            this.BtMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtMostrar.Name = "BtMostrar";
            this.BtMostrar.Size = new System.Drawing.Size(306, 58);
            this.BtMostrar.TabIndex = 50;
            this.BtMostrar.UseVisualStyleBackColor = false;
            this.BtMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
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
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click_1);
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
            this.BtReporte.Size = new System.Drawing.Size(320, 86);
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
            this.BtCon.Size = new System.Drawing.Size(351, 86);
            this.BtCon.TabIndex = 17;
            this.BtCon.UseVisualStyleBackColor = false;
            this.BtCon.Click += new System.EventHandler(this.BtCon_Click_1);
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
            this.BtEgresos.Click += new System.EventHandler(this.BtEgresos_Click_1);
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
            this.BtCajaC.Click += new System.EventHandler(this.BtCajaC_Click_1);
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
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.button2.BackgroundImage = global::Bodega.Properties.Resources.Grupo_16;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(385, 786);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 58);
            this.button2.TabIndex = 64;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ConsultaEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1733, 886);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtMostrar);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.cbxTablas);
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
            this.Name = "ConsultaEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultaEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cbxTablas;
        private System.Windows.Forms.Label Tablas;
        private System.Windows.Forms.Button BtMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}
