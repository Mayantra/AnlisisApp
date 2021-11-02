
namespace Bodega
{
    partial class Egresos
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
            this.TxAdmin = new System.Windows.Forms.Label();
            this.TxFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CTaller = new System.Windows.Forms.ComboBox();
            this.tallerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNTECAPDataSet1 = new Bodega.INTECAPDataSet1();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CArea = new System.Windows.Forms.ComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.CArticulo = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RcObservaciones = new System.Windows.Forms.RichTextBox();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.BtRegistrar = new System.Windows.Forms.Button();
            this.BtAgregar = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTablas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBTablas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tallerTableAdapter = new Bodega.INTECAPDataSet1TableAdapters.tallerTableAdapter();
            this.areaTableAdapter = new Bodega.INTECAPDataSet1TableAdapters.areaTableAdapter();
            this.FEgreso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tallerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTECAPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablas)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha";
            // 
            // CTaller
            // 
            this.CTaller.DataSource = this.tallerBindingSource;
            this.CTaller.DisplayMember = "nombre";
            this.CTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTaller.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTaller.FormattingEnabled = true;
            this.CTaller.IntegralHeight = false;
            this.CTaller.Location = new System.Drawing.Point(524, 178);
            this.CTaller.Margin = new System.Windows.Forms.Padding(4);
            this.CTaller.Name = "CTaller";
            this.CTaller.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CTaller.Size = new System.Drawing.Size(446, 40);
            this.CTaller.TabIndex = 30;
            this.CTaller.ValueMember = "id";
            this.CTaller.SelectedIndexChanged += new System.EventHandler(this.CTaller_SelectedIndexChanged);
            // 
            // tallerBindingSource
            // 
            this.tallerBindingSource.DataMember = "taller";
            this.tallerBindingSource.DataSource = this.iNTECAPDataSet1;
            // 
            // iNTECAPDataSet1
            // 
            this.iNTECAPDataSet1.DataSetName = "INTECAPDataSet1";
            this.iNTECAPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtReceptor
            // 
            this.txtReceptor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReceptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReceptor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReceptor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptor.Location = new System.Drawing.Point(1219, 104);
            this.txtReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReceptor.Size = new System.Drawing.Size(467, 32);
            this.txtReceptor.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1039, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Receptor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "Taller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1107, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "Area";
            // 
            // CArea
            // 
            this.CArea.DataSource = this.areaBindingSource;
            this.CArea.DisplayMember = "nombre";
            this.CArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CArea.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CArea.FormattingEnabled = true;
            this.CArea.IntegralHeight = false;
            this.CArea.Location = new System.Drawing.Point(1219, 178);
            this.CArea.Margin = new System.Windows.Forms.Padding(4);
            this.CArea.Name = "CArea";
            this.CArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CArea.Size = new System.Drawing.Size(465, 40);
            this.CArea.TabIndex = 39;
            this.CArea.ValueMember = "id";
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "area";
            this.areaBindingSource.DataSource = this.iNTECAPDataSet1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(133, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "Artículo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CArticulo
            // 
            this.CArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CArticulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CArticulo.FormattingEnabled = true;
            this.CArticulo.IntegralHeight = false;
            this.CArticulo.Location = new System.Drawing.Point(524, 321);
            this.CArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.CArticulo.Name = "CArticulo";
            this.CArticulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CArticulo.Size = new System.Drawing.Size(446, 40);
            this.CArticulo.TabIndex = 41;
            this.CArticulo.SelectedIndexChanged += new System.EventHandler(this.CNombre_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1219, 255);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(268, 41);
            this.textBox2.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1043, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(149, 32);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 427);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(237, 32);
            this.label7.TabIndex = 44;
            this.label7.Text = "Observaciones";
            // 
            // RcObservaciones
            // 
            this.RcObservaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RcObservaciones.Location = new System.Drawing.Point(628, 394);
            this.RcObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.RcObservaciones.Name = "RcObservaciones";
            this.RcObservaciones.Size = new System.Drawing.Size(616, 94);
            this.RcObservaciones.TabIndex = 45;
            this.RcObservaciones.Text = "";
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.BtLimpiar.BackgroundImage = global::Bodega.Properties.Resources.Grupo_91;
            this.BtLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLimpiar.FlatAppearance.BorderSize = 0;
            this.BtLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLimpiar.Location = new System.Drawing.Point(1408, 604);
            this.BtLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(277, 78);
            this.BtLimpiar.TabIndex = 48;
            this.BtLimpiar.UseVisualStyleBackColor = false;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.BtRegistrar.BackgroundImage = global::Bodega.Properties.Resources.Grupo_8;
            this.BtRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRegistrar.FlatAppearance.BorderSize = 0;
            this.BtRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRegistrar.Location = new System.Drawing.Point(1408, 702);
            this.BtRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Size = new System.Drawing.Size(277, 78);
            this.BtRegistrar.TabIndex = 47;
            this.BtRegistrar.UseVisualStyleBackColor = false;
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // BtAgregar
            // 
            this.BtAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.BtAgregar.BackgroundImage = global::Bodega.Properties.Resources.Grupo_7;
            this.BtAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAgregar.FlatAppearance.BorderSize = 0;
            this.BtAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAgregar.Location = new System.Drawing.Point(1408, 507);
            this.BtAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(277, 78);
            this.BtAgregar.TabIndex = 46;
            this.BtAgregar.UseVisualStyleBackColor = false;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
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
            this.BtEgresos.Size = new System.Drawing.Size(351, 86);
            this.BtEgresos.TabIndex = 16;
            this.BtEgresos.UseVisualStyleBackColor = false;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewTablas);
            this.panel1.Location = new System.Drawing.Point(366, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 334);
            this.panel1.TabIndex = 49;
            // 
            // dataGridViewTablas
            // 
            this.dataGridViewTablas.AllowUserToAddRows = false;
            this.dataGridViewTablas.AllowUserToDeleteRows = false;
            this.dataGridViewTablas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Receptor,
            this.Taller,
            this.Area,
            this.Tabla,
            this.Articulo,
            this.Observaciones,
            this.Cantidad1});
            this.dataGridViewTablas.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTablas.Name = "dataGridViewTablas";
            this.dataGridViewTablas.ReadOnly = true;
            this.dataGridViewTablas.RowHeadersWidth = 51;
            this.dataGridViewTablas.RowTemplate.Height = 24;
            this.dataGridViewTablas.Size = new System.Drawing.Size(1023, 328);
            this.dataGridViewTablas.TabIndex = 0;
            this.dataGridViewTablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTablas_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // Receptor
            // 
            this.Receptor.HeaderText = "Receptor";
            this.Receptor.MinimumWidth = 6;
            this.Receptor.Name = "Receptor";
            this.Receptor.ReadOnly = true;
            this.Receptor.Width = 125;
            // 
            // Taller
            // 
            this.Taller.HeaderText = "Taller";
            this.Taller.MinimumWidth = 6;
            this.Taller.Name = "Taller";
            this.Taller.ReadOnly = true;
            this.Taller.Width = 125;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 125;
            // 
            // Tabla
            // 
            this.Tabla.HeaderText = "Tabla";
            this.Tabla.MinimumWidth = 6;
            this.Tabla.Name = "Tabla";
            this.Tabla.ReadOnly = true;
            this.Tabla.Width = 125;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.MinimumWidth = 6;
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 125;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 125;
            // 
            // Cantidad1
            // 
            this.Cantidad1.HeaderText = "Cantidad";
            this.Cantidad1.MinimumWidth = 6;
            this.Cantidad1.Name = "Cantidad1";
            this.Cantidad1.ReadOnly = true;
            this.Cantidad1.Width = 125;
            // 
            // CBTablas
            // 
            this.CBTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTablas.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTablas.FormattingEnabled = true;
            this.CBTablas.Items.AddRange(new object[] {
            "Caja_Chica",
            "Ingresos"});
            this.CBTablas.Location = new System.Drawing.Point(524, 252);
            this.CBTablas.Name = "CBTablas";
            this.CBTablas.Size = new System.Drawing.Size(446, 40);
            this.CBTablas.TabIndex = 50;
            this.CBTablas.SelectedIndexChanged += new System.EventHandler(this.CBTablas_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(97, 32);
            this.label8.TabIndex = 51;
            this.label8.Text = "Tabla";
            // 
            // tallerTableAdapter
            // 
            this.tallerTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // FEgreso
            // 
            this.FEgreso.CalendarFont = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEgreso.CustomFormat = "yyyy-MM-dd";
            this.FEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FEgreso.Location = new System.Drawing.Point(524, 104);
            this.FEgreso.Name = "FEgreso";
            this.FEgreso.Size = new System.Drawing.Size(208, 38);
            this.FEgreso.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(160)))));
            this.label9.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1043, 333);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(168, 32);
            this.label9.TabIndex = 54;
            this.label9.Text = "Existencia";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtExistencia
            // 
            this.txtExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistencia.Enabled = false;
            this.txtExistencia.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Location = new System.Drawing.Point(1219, 324);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtExistencia.Multiline = true;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtExistencia.Size = new System.Drawing.Size(268, 41);
            this.txtExistencia.TabIndex = 53;
            this.txtExistencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1733, 886);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.FEgreso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBTablas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtRegistrar);
            this.Controls.Add(this.BtAgregar);
            this.Controls.Add(this.RcObservaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceptor);
            this.Controls.Add(this.CTaller);
            this.Controls.Add(this.label1);
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
            this.Name = "Egresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Egresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNTECAPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablas)).EndInit();
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
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CTaller;
        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox CArea;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CArticulo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RcObservaciones;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Button BtRegistrar;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBTablas;
        private System.Windows.Forms.DataGridView dataGridViewTablas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad1;
        private INTECAPDataSet1 iNTECAPDataSet1;
        private System.Windows.Forms.BindingSource tallerBindingSource;
        private INTECAPDataSet1TableAdapters.tallerTableAdapter tallerTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private INTECAPDataSet1TableAdapters.areaTableAdapter areaTableAdapter;
        private System.Windows.Forms.DateTimePicker FEgreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Timer timer1;
    }
}
