namespace usr_sap1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grdCuartoExcel = new System.Windows.Forms.DataGridView();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buscarUsuarioURM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarPlataforma = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buscarFilial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buscarUnidadOrg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buscarDni = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buscarNombre = new System.Windows.Forms.TextBox();
            this.buscarUnidadN = new System.Windows.Forms.TextBox();
            this.buscarCorreo = new System.Windows.Forms.TextBox();
            this.buscarCargo = new System.Windows.Forms.TextBox();
            this.buscarUsuarioRCS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barrita = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.txtUnidadO = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.txtUsuarioRCS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtUsuarioURM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdCuartoExcel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCuartoExcel
            // 
            this.grdCuartoExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCuartoExcel.Location = new System.Drawing.Point(12, 292);
            this.grdCuartoExcel.Name = "grdCuartoExcel";
            this.grdCuartoExcel.ReadOnly = true;
            this.grdCuartoExcel.RowHeadersVisible = false;
            this.grdCuartoExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCuartoExcel.Size = new System.Drawing.Size(1332, 371);
            this.grdCuartoExcel.TabIndex = 7;
            this.grdCuartoExcel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCuartoExcel_CellContentClick);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(882, 253);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(114, 20);
            this.txtCargo.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(498, 253);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(107, 20);
            this.txtCorreo.TabIndex = 12;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(746, 253);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(129, 20);
            this.txtUnidad.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(611, 253);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.txtRuta);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 78);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A R C H I V O S";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1109, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProcesar.Location = new System.Drawing.Point(703, 32);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(161, 24);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(16, 34);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(514, 20);
            this.txtRuta.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelect.Location = new System.Drawing.Point(536, 32);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(161, 24);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Seleccionar carpeta";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.buscarUsuarioURM);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buscarPlataforma);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.buscarFilial);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.buscarUnidadOrg);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.buscarDni);
            this.groupBox3.Controls.Add(this.btnExportar);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buscarNombre);
            this.groupBox3.Controls.Add(this.buscarUnidadN);
            this.groupBox3.Controls.Add(this.buscarCorreo);
            this.groupBox3.Controls.Add(this.buscarCargo);
            this.groupBox3.Controls.Add(this.buscarUsuarioRCS);
            this.groupBox3.Location = new System.Drawing.Point(10, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1929, 130);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "B U S Q U E D A ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(244, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "UsuarioURM";
            // 
            // buscarUsuarioURM
            // 
            this.buscarUsuarioURM.Location = new System.Drawing.Point(247, 50);
            this.buscarUsuarioURM.Name = "buscarUsuarioURM";
            this.buscarUsuarioURM.Size = new System.Drawing.Size(129, 20);
            this.buscarUsuarioURM.TabIndex = 40;
            this.buscarUsuarioURM.TextChanged += new System.EventHandler(this.buscarUsuarioURM_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(117, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Plataforma";
            // 
            // buscarPlataforma
            // 
            this.buscarPlataforma.Location = new System.Drawing.Point(112, 50);
            this.buscarPlataforma.Name = "buscarPlataforma";
            this.buscarPlataforma.Size = new System.Drawing.Size(129, 20);
            this.buscarPlataforma.TabIndex = 38;
            this.buscarPlataforma.TextChanged += new System.EventHandler(this.buscarPlataforma_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(1126, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Filial";
            // 
            // buscarFilial
            // 
            this.buscarFilial.Location = new System.Drawing.Point(1129, 50);
            this.buscarFilial.Name = "buscarFilial";
            this.buscarFilial.Size = new System.Drawing.Size(129, 20);
            this.buscarFilial.TabIndex = 36;
            this.buscarFilial.TextChanged += new System.EventHandler(this.buscarFilial_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(733, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Unidad Negocio";
            // 
            // buscarUnidadOrg
            // 
            this.buscarUnidadOrg.Location = new System.Drawing.Point(993, 50);
            this.buscarUnidadOrg.Name = "buscarUnidadOrg";
            this.buscarUnidadOrg.Size = new System.Drawing.Size(129, 20);
            this.buscarUnidadOrg.TabIndex = 34;
            this.buscarUnidadOrg.TextChanged += new System.EventHandler(this.buscarUnidadOrg_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(379, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "DNI";
            // 
            // buscarDni
            // 
            this.buscarDni.Location = new System.Drawing.Point(382, 50);
            this.buscarDni.Name = "buscarDni";
            this.buscarDni.Size = new System.Drawing.Size(100, 20);
            this.buscarDni.TabIndex = 32;
            this.buscarDni.TextChanged += new System.EventHandler(this.buscarDni_TextChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExportar.Location = new System.Drawing.Point(219, 85);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(737, 27);
            this.btnExportar.TabIndex = 31;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(4, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Usuario RCS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(486, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(602, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(990, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Unidad org.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(869, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cargo";
            // 
            // buscarNombre
            // 
            this.buscarNombre.Location = new System.Drawing.Point(601, 50);
            this.buscarNombre.Name = "buscarNombre";
            this.buscarNombre.Size = new System.Drawing.Size(129, 20);
            this.buscarNombre.TabIndex = 24;
            this.buscarNombre.TextChanged += new System.EventHandler(this.buscarNombre_TextChanged);
            // 
            // buscarUnidadN
            // 
            this.buscarUnidadN.Location = new System.Drawing.Point(736, 50);
            this.buscarUnidadN.Name = "buscarUnidadN";
            this.buscarUnidadN.Size = new System.Drawing.Size(129, 20);
            this.buscarUnidadN.TabIndex = 23;
            this.buscarUnidadN.TextChanged += new System.EventHandler(this.buscarUnidadN_TextChanged);
            // 
            // buscarCorreo
            // 
            this.buscarCorreo.Location = new System.Drawing.Point(489, 50);
            this.buscarCorreo.Name = "buscarCorreo";
            this.buscarCorreo.Size = new System.Drawing.Size(107, 20);
            this.buscarCorreo.TabIndex = 22;
            this.buscarCorreo.TextChanged += new System.EventHandler(this.buscarCorreo_TextChanged);
            // 
            // buscarCargo
            // 
            this.buscarCargo.Location = new System.Drawing.Point(872, 50);
            this.buscarCargo.Name = "buscarCargo";
            this.buscarCargo.Size = new System.Drawing.Size(114, 20);
            this.buscarCargo.TabIndex = 21;
            this.buscarCargo.TextChanged += new System.EventHandler(this.buscarCargo_TextChanged);
            // 
            // buscarUsuarioRCS
            // 
            this.buscarUsuarioRCS.Location = new System.Drawing.Point(7, 50);
            this.buscarUsuarioRCS.Name = "buscarUsuarioRCS";
            this.buscarUsuarioRCS.Size = new System.Drawing.Size(100, 20);
            this.buscarUsuarioRCS.TabIndex = 20;
            this.buscarUsuarioRCS.TextChanged += new System.EventHandler(this.buscarUsuarioRCS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(881, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(611, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(495, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Correo";
            // 
            // barrita
            // 
            this.barrita.Location = new System.Drawing.Point(12, 669);
            this.barrita.Name = "barrita";
            this.barrita.Size = new System.Drawing.Size(1332, 23);
            this.barrita.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(388, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(391, 253);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(1136, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "Filial";
            // 
            // txtFilial
            // 
            this.txtFilial.Location = new System.Drawing.Point(1139, 253);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.ReadOnly = true;
            this.txtFilial.Size = new System.Drawing.Size(129, 20);
            this.txtFilial.TabIndex = 40;
            // 
            // txtUnidadO
            // 
            this.txtUnidadO.Location = new System.Drawing.Point(1003, 253);
            this.txtUnidadO.Name = "txtUnidadO";
            this.txtUnidadO.ReadOnly = true;
            this.txtUnidadO.Size = new System.Drawing.Size(129, 20);
            this.txtUnidadO.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(1001, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Unidad org.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(744, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "Unidad Negocio";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(127, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 41;
            this.label18.Text = "Plataforma";
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Location = new System.Drawing.Point(125, 253);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.ReadOnly = true;
            this.txtPlataforma.Size = new System.Drawing.Size(129, 20);
            this.txtPlataforma.TabIndex = 40;
            // 
            // txtUsuarioRCS
            // 
            this.txtUsuarioRCS.Location = new System.Drawing.Point(19, 253);
            this.txtUsuarioRCS.Name = "txtUsuarioRCS";
            this.txtUsuarioRCS.ReadOnly = true;
            this.txtUsuarioRCS.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioRCS.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(16, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Usuario RCS";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(254, 233);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "UsuarioURM";
            // 
            // txtUsuarioURM
            // 
            this.txtUsuarioURM.Location = new System.Drawing.Point(257, 253);
            this.txtUsuarioURM.Name = "txtUsuarioURM";
            this.txtUsuarioURM.ReadOnly = true;
            this.txtUsuarioURM.Size = new System.Drawing.Size(129, 20);
            this.txtUsuarioURM.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtUsuarioURM);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.txtFilial);
            this.Controls.Add(this.txtUnidadO);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.barrita);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtUsuarioRCS);
            this.Controls.Add(this.grdCuartoExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUDO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCuartoExcel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdCuartoExcel;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox buscarNombre;
        private System.Windows.Forms.TextBox buscarUnidadN;
        private System.Windows.Forms.TextBox buscarCorreo;
        private System.Windows.Forms.TextBox buscarCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar barrita;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox buscarDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox buscarFilial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox buscarUnidadOrg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFilial;
        private System.Windows.Forms.TextBox txtUnidadO;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buscarPlataforma;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox buscarUsuarioRCS;
        private System.Windows.Forms.TextBox txtUsuarioRCS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox buscarUsuarioURM;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtUsuarioURM;
    }
}

