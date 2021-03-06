namespace Academika.Presentacion
{
    partial class FrmAltaMateriaXCarreraXCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDictado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboJefe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboAdj = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboAyud = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.rtbAyuda = new System.Windows.Forms.Label();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.lblCarga = new System.Windows.Forms.Label();
            this.nudCarga = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCuatrimestre = new System.Windows.Forms.ComboBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioDictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JefedeCatedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfesorAdjunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AyudantePrimera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateriaCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblId.Location = new System.Drawing.Point(24, 21);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(266, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "Materia";
            this.lblId.Text = "Detalle Materias - Carrera - Curso";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(23, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dictado:";
            // 
            // cboDictado
            // 
            this.cboDictado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDictado.DropDownWidth = 225;
            this.cboDictado.FormattingEnabled = true;
            this.cboDictado.Items.AddRange(new object[] {
            "Cuatrimestral",
            "Anual"});
            this.cboDictado.Location = new System.Drawing.Point(108, 156);
            this.cboDictado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboDictado.Name = "cboDictado";
            this.cboDictado.Size = new System.Drawing.Size(140, 23);
            this.cboDictado.TabIndex = 3;
            this.cboDictado.SelectedIndexChanged += new System.EventHandler(this.cboDictado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(23, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Listado materias:";
            // 
            // cboCarrera
            // 
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrera.DropDownWidth = 225;
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(108, 114);
            this.cboCarrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(140, 23);
            this.cboCarrera.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(23, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carrera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(276, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Año Dictado:";
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.DropDownWidth = 140;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(386, 156);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(140, 23);
            this.cboCurso.TabIndex = 12;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(281, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Curso:";
            // 
            // cboJefe
            // 
            this.cboJefe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJefe.DropDownWidth = 225;
            this.cboJefe.FormattingEnabled = true;
            this.cboJefe.Location = new System.Drawing.Point(108, 194);
            this.cboJefe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboJefe.Name = "cboJefe";
            this.cboJefe.Size = new System.Drawing.Size(140, 23);
            this.cboJefe.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(23, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Jefe Catedra";
            // 
            // cboAdj
            // 
            this.cboAdj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdj.DropDownWidth = 225;
            this.cboAdj.FormattingEnabled = true;
            this.cboAdj.Location = new System.Drawing.Point(386, 194);
            this.cboAdj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAdj.Name = "cboAdj";
            this.cboAdj.Size = new System.Drawing.Size(140, 23);
            this.cboAdj.TabIndex = 17;
            this.cboAdj.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(276, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Profesor Adjunto:";
            // 
            // cboAyud
            // 
            this.cboAyud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAyud.DropDownWidth = 225;
            this.cboAyud.FormattingEnabled = true;
            this.cboAyud.Location = new System.Drawing.Point(670, 194);
            this.cboAyud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAyud.Name = "cboAyud";
            this.cboAyud.Size = new System.Drawing.Size(140, 23);
            this.cboAyud.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(554, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ayudante Primera:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnLimpiar.IconColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(632, 614);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 51);
            this.btnLimpiar.TabIndex = 107;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(445, 614);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 51);
            this.btnGuardar.TabIndex = 106;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.Location = new System.Drawing.Point(1093, 342);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(51, 51);
            this.btnBorrar.TabIndex = 112;
            this.btnBorrar.Tag = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(1093, 273);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 51);
            this.btnEditar.TabIndex = 111;
            this.btnEditar.Tag = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToOrderColumns = true;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultado.ColumnHeadersHeight = 30;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carrera,
            this.NombreMat,
            this.NomCurso,
            this.Dictado,
            this.AnioDictado,
            this.Cuatrimestre,
            this.Carga,
            this.JefedeCatedra,
            this.ProfesorAdjunto,
            this.AyudantePrimera,
            this.IdCarrera,
            this.IdCurso,
            this.IdMateria,
            this.IdMateriaCarrera});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultado.EnableHeadersVisualStyles = false;
            this.dgvResultado.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvResultado.Location = new System.Drawing.Point(0, 273);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultado.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvResultado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResultado.Size = new System.Drawing.Size(1092, 306);
            this.dgvResultado.TabIndex = 113;
            this.dgvResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellContentClick);
            // 
            // rtbAyuda
            // 
            this.rtbAyuda.Location = new System.Drawing.Point(0, 0);
            this.rtbAyuda.Name = "rtbAyuda";
            this.rtbAyuda.Size = new System.Drawing.Size(100, 23);
            this.rtbAyuda.TabIndex = 125;
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.DropDownWidth = 140;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboAnio.Location = new System.Drawing.Point(386, 112);
            this.cboAnio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(140, 23);
            this.cboAnio.TabIndex = 124;
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarga.Location = new System.Drawing.Point(554, 114);
            this.lblCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(83, 15);
            this.lblCarga.TabIndex = 119;
            this.lblCarga.Text = "Carga Horaria:";
            // 
            // nudCarga
            // 
            this.nudCarga.Location = new System.Drawing.Point(670, 112);
            this.nudCarga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCarga.Name = "nudCarga";
            this.nudCarga.Size = new System.Drawing.Size(120, 23);
            this.nudCarga.TabIndex = 120;
            this.nudCarga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(554, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 114;
            this.label10.Text = "Cuatrimestre";
            // 
            // cboCuatrimestre
            // 
            this.cboCuatrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuatrimestre.FormattingEnabled = true;
            this.cboCuatrimestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboCuatrimestre.Location = new System.Drawing.Point(670, 156);
            this.cboCuatrimestre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCuatrimestre.Name = "cboCuatrimestre";
            this.cboCuatrimestre.Size = new System.Drawing.Size(140, 23);
            this.cboCuatrimestre.TabIndex = 115;
            // 
            // cboMateria
            // 
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.DropDownWidth = 300;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(108, 69);
            this.cboMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(140, 23);
            this.cboMateria.TabIndex = 118;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMateria.Location = new System.Drawing.Point(23, 77);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(47, 15);
            this.lblMateria.TabIndex = 117;
            this.lblMateria.Text = "Materia";
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(276, 62);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 121;
            this.btnSearch.Tag = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton3.IconColor = System.Drawing.Color.Yellow;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(1091, 648);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(51, 51);
            this.iconButton3.TabIndex = 122;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // Carrera
            // 
            this.Carrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Carrera.DataPropertyName = "Carrera";
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Carrera.Width = 135;
            // 
            // NombreMat
            // 
            this.NombreMat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NombreMat.DataPropertyName = "NombreMat";
            this.NombreMat.HeaderText = "Materia";
            this.NombreMat.Name = "NombreMat";
            this.NombreMat.ReadOnly = true;
            this.NombreMat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreMat.Width = 135;
            // 
            // NomCurso
            // 
            this.NomCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomCurso.DataPropertyName = "NomCurso";
            this.NomCurso.HeaderText = "Curso";
            this.NomCurso.Name = "NomCurso";
            this.NomCurso.ReadOnly = true;
            this.NomCurso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomCurso.Width = 43;
            // 
            // Dictado
            // 
            this.Dictado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Dictado.DataPropertyName = "Dictado";
            this.Dictado.HeaderText = "Dictado";
            this.Dictado.Name = "Dictado";
            this.Dictado.ReadOnly = true;
            this.Dictado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dictado.Width = 60;
            // 
            // AnioDictado
            // 
            this.AnioDictado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AnioDictado.DataPropertyName = "AnioDictado";
            this.AnioDictado.HeaderText = "Año Dictado";
            this.AnioDictado.Name = "AnioDictado";
            this.AnioDictado.ReadOnly = true;
            this.AnioDictado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnioDictado.Width = 97;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cuatrimestre.DataPropertyName = "Cuatrimestre";
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.ReadOnly = true;
            this.Cuatrimestre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cuatrimestre.Width = 90;
            // 
            // Carga
            // 
            this.Carga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Carga.DataPropertyName = "Carga";
            this.Carga.HeaderText = "Carga Hs";
            this.Carga.Name = "Carga";
            this.Carga.ReadOnly = true;
            this.Carga.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Carga.Width = 75;
            // 
            // JefedeCatedra
            // 
            this.JefedeCatedra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JefedeCatedra.DataPropertyName = "JefedeCatedra";
            this.JefedeCatedra.HeaderText = "Jefe de Catedra";
            this.JefedeCatedra.Name = "JefedeCatedra";
            this.JefedeCatedra.ReadOnly = true;
            this.JefedeCatedra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.JefedeCatedra.Width = 150;
            // 
            // ProfesorAdjunto
            // 
            this.ProfesorAdjunto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProfesorAdjunto.DataPropertyName = "ProfesorAdjunto";
            this.ProfesorAdjunto.HeaderText = "Profesor Adjunto";
            this.ProfesorAdjunto.Name = "ProfesorAdjunto";
            this.ProfesorAdjunto.ReadOnly = true;
            this.ProfesorAdjunto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProfesorAdjunto.Width = 150;
            // 
            // AyudantePrimera
            // 
            this.AyudantePrimera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AyudantePrimera.DataPropertyName = "AyudantePrimera";
            this.AyudantePrimera.HeaderText = "Ayudante Primera";
            this.AyudantePrimera.Name = "AyudantePrimera";
            this.AyudantePrimera.ReadOnly = true;
            this.AyudantePrimera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AyudantePrimera.Width = 150;
            // 
            // IdCarrera
            // 
            this.IdCarrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdCarrera.DataPropertyName = "IdCarrera";
            this.IdCarrera.HeaderText = "IdCarrera";
            this.IdCarrera.Name = "IdCarrera";
            this.IdCarrera.ReadOnly = true;
            this.IdCarrera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdCarrera.Visible = false;
            // 
            // IdCurso
            // 
            this.IdCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdCurso.DataPropertyName = "IdCurso";
            this.IdCurso.HeaderText = "IdCurso";
            this.IdCurso.Name = "IdCurso";
            this.IdCurso.ReadOnly = true;
            this.IdCurso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdCurso.Visible = false;
            // 
            // IdMateria
            // 
            this.IdMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdMateria.DataPropertyName = "IdMateria";
            this.IdMateria.HeaderText = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            this.IdMateria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdMateria.Visible = false;
            // 
            // IdMateriaCarrera
            // 
            this.IdMateriaCarrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdMateriaCarrera.DataPropertyName = "IdMateriasCarrera";
            this.IdMateriaCarrera.HeaderText = "IdMateriasCarrera";
            this.IdMateriaCarrera.Name = "IdMateriaCarrera";
            this.IdMateriaCarrera.ReadOnly = true;
            this.IdMateriaCarrera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdMateriaCarrera.Visible = false;
            // 
            // FrmAltaMateriaXCarreraXCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 711);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.rtbAyuda);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.nudCarga);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cboCuatrimestre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboAyud);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboAdj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboJefe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDictado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAltaMateriaXCarreraXCurso";
            this.Text = "Alta Materia - Carrera";
            this.Load += new System.EventHandler(this.FrmAltaMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDictado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboJefe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboAdj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboAyud;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCuatrimestre;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.NumericUpDown nudCarga;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label rtbAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioDictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn JefedeCatedra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorAdjunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn AyudantePrimera;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateriaCarrera;
    }
}