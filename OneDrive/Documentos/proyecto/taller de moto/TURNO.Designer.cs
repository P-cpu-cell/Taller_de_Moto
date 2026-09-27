namespace taller_de_moto
{
    partial class Turnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turnos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.txthora = new System.Windows.Forms.TextBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dTPfecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnerror = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_profecional = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_servicio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridturno = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridturno)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".";
            this.groupBox1.UseWaitCursor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnsalir.Location = new System.Drawing.Point(907, 13);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(55, 43);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.UseWaitCursor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "REGISTRO DE TURNOS";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.cbocliente);
            this.groupBox2.Controls.Add(this.txthora);
            this.groupBox2.Controls.Add(this.cboestado);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dTPfecha);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnerror);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbo_profecional);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbo_servicio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEliminar);
            this.groupBox2.Controls.Add(this.btnregistrar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL TURNO:";
            this.groupBox2.UseWaitCursor = true;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbocliente
            // 
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Items.AddRange(new object[] {
            "Coloración",
            "Alisado",
            "Hidratación ",
            "Capilar",
            "Botox ",
            "Capilar",
            "Uñas Esculpidas ",
            "Esmaltado Semipermanente",
            "Esmaltado Tradicional",
            "Cuidado de Manos y Pies",
            "Depilación con Cera",
            "Depilación con Hilo",
            "Maquillaje Profesional",
            "Perfilado de Cejas y Pestañas",
            "Limpieza Facial Profunda",
            "Extracción de Comedones",
            "Exfoliación Química",
            "Peeling",
            "Dermaplaning",
            "Radiofrecuencia ",
            "Anti-age",
            "Ultrasonido",
            "Electroporación",
            "Masaje Relajante",
            "Masaje Descontracturante",
            "Drenaje Linfático Manual",
            "Tratamiento Reductor",
            "Tratamiento Reafirmante"});
            this.cbocliente.Location = new System.Drawing.Point(135, 33);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(222, 28);
            this.cbocliente.TabIndex = 35;
            this.cbocliente.UseWaitCursor = true;
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(120, 173);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(137, 26);
            this.txthora.TabIndex = 34;
            this.txthora.UseWaitCursor = true;
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Items.AddRange(new object[] {
            "PROGRAMADO",
            "CANCELADO",
            "PENDIENTE"});
            this.cboestado.Location = new System.Drawing.Point(130, 203);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(222, 28);
            this.cboestado.TabIndex = 33;
            this.cboestado.UseWaitCursor = true;
            this.cboestado.SelectedIndexChanged += new System.EventHandler(this.cboestado_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Lime;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 22);
            this.label12.TabIndex = 32;
            this.label12.Text = "ESTADO:";
            this.label12.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Lime;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 22);
            this.label11.TabIndex = 31;
            this.label11.Text = "HORA:";
            this.label11.UseWaitCursor = true;
            // 
            // dTPfecha
            // 
            this.dTPfecha.Location = new System.Drawing.Point(120, 144);
            this.dTPfecha.Name = "dTPfecha";
            this.dTPfecha.Size = new System.Drawing.Size(237, 26);
            this.dTPfecha.TabIndex = 30;
            this.dTPfecha.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnerror
            // 
            this.btnerror.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnerror.BackgroundImage")));
            this.btnerror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnerror.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnerror.Location = new System.Drawing.Point(562, 20);
            this.btnerror.Name = "btnerror";
            this.btnerror.Size = new System.Drawing.Size(68, 57);
            this.btnerror.TabIndex = 8;
            this.btnerror.UseVisualStyleBackColor = true;
            this.btnerror.UseWaitCursor = true;
            this.btnerror.Click += new System.EventHandler(this.btnerror_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 22;
            this.label7.UseWaitCursor = true;
            // 
            // cbo_profecional
            // 
            this.cbo_profecional.FormattingEnabled = true;
            this.cbo_profecional.Items.AddRange(new object[] {
            "Valentina Rossi",
            "",
            "",
            "Julián Martínez",
            "",
            "",
            "Camila Benítez",
            "",
            "",
            "Lucas Espósito",
            "",
            "",
            "Sofía Fernández",
            "",
            "",
            "Matías Herrera",
            "",
            "",
            "Lucía Romero",
            "",
            "",
            "Nicolás Castro",
            "",
            "",
            "Florencia Gómez",
            "",
            "Diego Acosta"});
            this.cbo_profecional.Location = new System.Drawing.Point(169, 105);
            this.cbo_profecional.Name = "cbo_profecional";
            this.cbo_profecional.Size = new System.Drawing.Size(349, 28);
            this.cbo_profecional.TabIndex = 21;
            this.cbo_profecional.UseWaitCursor = true;
            this.cbo_profecional.SelectedIndexChanged += new System.EventHandler(this.cbo_modelo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "PROFESIONAL";
            this.label6.UseWaitCursor = true;
            // 
            // cbo_servicio
            // 
            this.cbo_servicio.FormattingEnabled = true;
            this.cbo_servicio.Items.AddRange(new object[] {
            "Coloración",
            "Alisado",
            "Hidratación ",
            "Capilar",
            "Botox ",
            "Capilar",
            "Uñas Esculpidas ",
            "Esmaltado Semipermanente",
            "Esmaltado Tradicional",
            "Cuidado de Manos y Pies",
            "Depilación con Cera",
            "Depilación con Hilo",
            "Maquillaje Profesional",
            "Perfilado de Cejas y Pestañas",
            "Limpieza Facial Profunda",
            "Extracción de Comedones",
            "Exfoliación Química",
            "Peeling",
            "Dermaplaning",
            "Radiofrecuencia ",
            "Anti-age",
            "Ultrasonido",
            "Electroporación",
            "Masaje Relajante",
            "Masaje Descontracturante",
            "Drenaje Linfático Manual",
            "Tratamiento Reductor",
            "Tratamiento Reafirmante"});
            this.cbo_servicio.Location = new System.Drawing.Point(135, 72);
            this.cbo_servicio.Name = "cbo_servicio";
            this.cbo_servicio.Size = new System.Drawing.Size(222, 28);
            this.cbo_servicio.TabIndex = 17;
            this.cbo_servicio.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "FECHA:";
            this.label5.UseWaitCursor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEliminar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.Location = new System.Drawing.Point(636, 20);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(68, 57);
            this.txtEliminar.TabIndex = 7;
            this.txtEliminar.Text = "LIMPIAR DATO";
            this.txtEliminar.UseVisualStyleBackColor = false;
            this.txtEliminar.UseWaitCursor = true;
            this.txtEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnregistrar.Location = new System.Drawing.Point(474, 20);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(73, 57);
            this.btnregistrar.TabIndex = 6;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.UseWaitCursor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "SERVICIO :";
            this.label3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE:";
            this.label1.UseWaitCursor = true;
            // 
            // datagridturno
            // 
            this.datagridturno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridturno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridturno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column6});
            this.datagridturno.Location = new System.Drawing.Point(12, 41);
            this.datagridturno.Name = "datagridturno";
            this.datagridturno.Size = new System.Drawing.Size(877, 188);
            this.datagridturno.TabIndex = 0;
            this.datagridturno.UseWaitCursor = true;
            this.datagridturno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridmotos_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.datagridturno);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(920, 259);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS INGRESADO";
            this.groupBox3.UseWaitCursor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CLIENTE";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SERVICIO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PROFESIONAL";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FECHA";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HORA";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ESTADO";
            this.Column6.Name = "Column6";
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 712);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Turnos";
            this.Text = "reguistro de Turnos";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridturno)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtEliminar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_profecional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_servicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView datagridturno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnerror;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dTPfecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.ComboBox cbocliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}