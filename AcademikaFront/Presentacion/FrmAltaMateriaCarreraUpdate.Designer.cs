namespace Academika.Presentacion
{
    partial class FrmAltaMateriaXCarreraUpdate

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
            this.label2 = new System.Windows.Forms.Label();
            this.cboDictado = new System.Windows.Forms.ComboBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCuatrimestre = new System.Windows.Forms.ComboBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCarga = new System.Windows.Forms.Label();
            this.nudCarga = new System.Windows.Forms.NumericUpDown();
            this.IdMateriasCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbAyuda = new System.Windows.Forms.Label();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarga)).BeginInit();
            this.SuspendLayout();
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
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnLimpiar.IconColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(432, 280);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 51);
            this.btnLimpiar.TabIndex = 107;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnEditar.IconColor = System.Drawing.Color.Green;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(325, 280);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 51);
            this.btnEditar.TabIndex = 111;
            this.btnEditar.Tag = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(276, 164);
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
            this.cboCuatrimestre.Location = new System.Drawing.Point(386, 159);
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
            // IdMateriasCarrera
            // 
            this.IdMateriasCarrera.DataPropertyName = "IdMateriasCarrera";
            this.IdMateriasCarrera.HeaderText = "IdMateriasCarrera";
            this.IdMateriasCarrera.Name = "IdMateriasCarrera";
            this.IdMateriasCarrera.Visible = false;
            // 
            // rtbAyuda
            // 
            this.rtbAyuda.AutoSize = true;
            this.rtbAyuda.Location = new System.Drawing.Point(1104, 25);
            this.rtbAyuda.Name = "rtbAyuda";
            this.rtbAyuda.Size = new System.Drawing.Size(0, 15);
            this.rtbAyuda.TabIndex = 123;
            this.rtbAyuda.Visible = false;
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboAnio.Location = new System.Drawing.Point(386, 112);
            this.cboAnio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(140, 23);
            this.cboAnio.TabIndex = 124;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblId.Location = new System.Drawing.Point(23, 19);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(165, 20);
            this.lblId.TabIndex = 125;
            this.lblId.Text = "ID Materia - Carrera:";
            // 
            // FrmAltaMateriaXCarreraUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 400);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.rtbAyuda);
            this.Controls.Add(this.nudCarga);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cboCuatrimestre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDictado);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAltaMateriaXCarreraUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualiza Materia - Carrera ";
            this.Load += new System.EventHandler(this.FrmAltaMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDictado;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCuatrimestre;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.NumericUpDown nudCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateriasCarrera;
        private System.Windows.Forms.Label rtbAyuda;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Label lblId;
    }
}