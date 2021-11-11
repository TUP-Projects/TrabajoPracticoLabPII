
namespace AcademikaFront.Presentacion
{
    partial class FrmCondicionAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.cboCarrera = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboSituacionHabitacional = new RJCodeAdvance.RJControls.RJComboBox();
            this.cboMateria = new RJCodeAdvance.RJControls.RJComboBox();
            this.cboCondicion = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.dtpAnioCursado = new RJCodeAdvance.RJControls.RJDatePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAnioCursado.Location = new System.Drawing.Point(384, 169);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(79, 15);
            this.lblAnioCursado.TabIndex = 162;
            this.lblAnioCursado.Text = "Año Cursado:";
            // 
            // cboCarrera
            // 
            this.cboCarrera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCarrera.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCarrera.BorderSize = 1;
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCarrera.ForeColor = System.Drawing.Color.DimGray;
            this.cboCarrera.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCarrera.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboCarrera.ListTextColor = System.Drawing.Color.DimGray;
            this.cboCarrera.Location = new System.Drawing.Point(704, 94);
            this.cboCarrera.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Padding = new System.Windows.Forms.Padding(1);
            this.cboCarrera.Size = new System.Drawing.Size(200, 30);
            this.cboCarrera.TabIndex = 160;
            this.cboCarrera.Texts = "";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurso.Location = new System.Drawing.Point(59, 169);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(41, 15);
            this.lblCurso.TabIndex = 159;
            this.lblCurso.Text = "Curso:";
            // 
            // cboSituacionHabitacional
            // 
            this.cboSituacionHabitacional.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboSituacionHabitacional.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboSituacionHabitacional.BorderSize = 1;
            this.cboSituacionHabitacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboSituacionHabitacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSituacionHabitacional.ForeColor = System.Drawing.Color.DimGray;
            this.cboSituacionHabitacional.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboSituacionHabitacional.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboSituacionHabitacional.ListTextColor = System.Drawing.Color.DimGray;
            this.cboSituacionHabitacional.Location = new System.Drawing.Point(154, 154);
            this.cboSituacionHabitacional.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboSituacionHabitacional.Name = "cboSituacionHabitacional";
            this.cboSituacionHabitacional.Padding = new System.Windows.Forms.Padding(1);
            this.cboSituacionHabitacional.Size = new System.Drawing.Size(200, 30);
            this.cboSituacionHabitacional.TabIndex = 158;
            this.cboSituacionHabitacional.Texts = "";
            // 
            // cboMateria
            // 
            this.cboMateria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboMateria.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMateria.BorderSize = 1;
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMateria.ForeColor = System.Drawing.Color.DimGray;
            this.cboMateria.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMateria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMateria.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMateria.Location = new System.Drawing.Point(411, 94);
            this.cboMateria.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Padding = new System.Windows.Forms.Padding(1);
            this.cboMateria.Size = new System.Drawing.Size(200, 30);
            this.cboMateria.TabIndex = 157;
            this.cboMateria.Texts = "";
            // 
            // cboCondicion
            // 
            this.cboCondicion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCondicion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCondicion.BorderSize = 1;
            this.cboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCondicion.ForeColor = System.Drawing.Color.DimGray;
            this.cboCondicion.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCondicion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboCondicion.ListTextColor = System.Drawing.Color.DimGray;
            this.cboCondicion.Location = new System.Drawing.Point(154, 94);
            this.cboCondicion.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCondicion.Name = "cboCondicion";
            this.cboCondicion.Padding = new System.Windows.Forms.Padding(1);
            this.cboCondicion.Size = new System.Drawing.Size(200, 30);
            this.cboCondicion.TabIndex = 156;
            this.cboCondicion.Texts = "";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCarrera.Location = new System.Drawing.Point(629, 109);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(48, 15);
            this.lblCarrera.TabIndex = 155;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMateria.Location = new System.Drawing.Point(369, 109);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 154;
            this.lblMateria.Text = "Materia:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCondicion.Location = new System.Drawing.Point(83, 109);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(65, 15);
            this.lblCondicion.TabIndex = 153;
            this.lblCondicion.Text = "Condición:";
            this.lblCondicion.Click += new System.EventHandler(this.lblCondicion_Click);
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpAnioCursado.BorderSize = 0;
            this.dtpAnioCursado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpAnioCursado.Location = new System.Drawing.Point(488, 154);
            this.dtpAnioCursado.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(200, 35);
            this.dtpAnioCursado.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpAnioCursado.TabIndex = 163;
            this.dtpAnioCursado.TextColor = System.Drawing.Color.White;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Condicion,
            this.Materia,
            this.Carrera,
            this.Curso,
            this.Anio});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(59, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(913, 207);
            this.dataGridView1.TabIndex = 164;
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Condición";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            this.Condicion.Width = 150;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 320;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 320;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 60;
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            this.Anio.Width = 60;
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(991, 248);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 51);
            this.btnSearch.TabIndex = 176;
            this.btnSearch.Tag = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnLimpiar.IconColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(991, 327);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 51);
            this.btnLimpiar.TabIndex = 175;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 180;
            this.label1.Text = "SP_CONDICIONES_ALUMNOS";
            // 
            // FrmCondicionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1154, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cboSituacionHabitacional);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.cboCondicion);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblCondicion);
            this.Name = "FrmCondicionAlumnos";
            this.Text = "Consultar Condición Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnioCursado;
        private RJCodeAdvance.RJControls.RJComboBox cboCarrera;
        private System.Windows.Forms.Label lblCurso;
        private RJCodeAdvance.RJControls.RJComboBox cboSituacionHabitacional;
        private RJCodeAdvance.RJControls.RJComboBox cboMateria;
        private RJCodeAdvance.RJControls.RJComboBox cboCondicion;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCondicion;
        private RJCodeAdvance.RJControls.RJDatePicker dtpAnioCursado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.Label label1;
    }
}