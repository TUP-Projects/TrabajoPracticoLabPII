
namespace AcademikaFront.Presentacion.Consultas
{
    partial class FrmPromedioAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.cboCurso = new RJCodeAdvance.RJControls.RJComboBox();
            this.cboMateria = new RJCodeAdvance.RJControls.RJComboBox();
            this.cboLegajo = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cboCarrera = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblIdCarrera = new System.Windows.Forms.Label();
            this.dtpAnioCursado = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.dgvPromedioAlumnos = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedioAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdCurso.Location = new System.Drawing.Point(55, 223);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(41, 15);
            this.lblIdCurso.TabIndex = 167;
            this.lblIdCurso.Text = "Curso:";
            // 
            // cboCurso
            // 
            this.cboCurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCurso.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCurso.BorderSize = 1;
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCurso.ForeColor = System.Drawing.Color.DimGray;
            this.cboCurso.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCurso.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboCurso.ListTextColor = System.Drawing.Color.DimGray;
            this.cboCurso.Location = new System.Drawing.Point(126, 208);
            this.cboCurso.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Padding = new System.Windows.Forms.Padding(1);
            this.cboCurso.Size = new System.Drawing.Size(200, 30);
            this.cboCurso.TabIndex = 166;
            this.cboCurso.Texts = "";
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
            this.cboMateria.Location = new System.Drawing.Point(397, 148);
            this.cboMateria.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Padding = new System.Windows.Forms.Padding(1);
            this.cboMateria.Size = new System.Drawing.Size(200, 30);
            this.cboMateria.TabIndex = 165;
            this.cboMateria.Texts = "";
            // 
            // cboLegajo
            // 
            this.cboLegajo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboLegajo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLegajo.BorderSize = 1;
            this.cboLegajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLegajo.ForeColor = System.Drawing.Color.DimGray;
            this.cboLegajo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLegajo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLegajo.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLegajo.Location = new System.Drawing.Point(126, 148);
            this.cboLegajo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLegajo.Name = "cboLegajo";
            this.cboLegajo.Padding = new System.Windows.Forms.Padding(1);
            this.cboLegajo.Size = new System.Drawing.Size(200, 30);
            this.cboLegajo.TabIndex = 164;
            this.cboLegajo.Texts = "";
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdMateria.Location = new System.Drawing.Point(341, 163);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(50, 15);
            this.lblIdMateria.TabIndex = 162;
            this.lblIdMateria.Text = "Materia:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLegajo.Location = new System.Drawing.Point(55, 163);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(53, 15);
            this.lblLegajo.TabIndex = 161;
            this.lblLegajo.Text = "Alumno:";
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
            this.cboCarrera.Location = new System.Drawing.Point(423, 208);
            this.cboCarrera.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Padding = new System.Windows.Forms.Padding(1);
            this.cboCarrera.Size = new System.Drawing.Size(200, 30);
            this.cboCarrera.TabIndex = 170;
            this.cboCarrera.Texts = "";
            // 
            // lblIdCarrera
            // 
            this.lblIdCarrera.AutoSize = true;
            this.lblIdCarrera.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIdCarrera.Location = new System.Drawing.Point(352, 223);
            this.lblIdCarrera.Name = "lblIdCarrera";
            this.lblIdCarrera.Size = new System.Drawing.Size(48, 15);
            this.lblIdCarrera.TabIndex = 169;
            this.lblIdCarrera.Text = "Carrera:";
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpAnioCursado.BorderSize = 0;
            this.dtpAnioCursado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpAnioCursado.Location = new System.Drawing.Point(712, 143);
            this.dtpAnioCursado.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(200, 35);
            this.dtpAnioCursado.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpAnioCursado.TabIndex = 172;
            this.dtpAnioCursado.TextColor = System.Drawing.Color.White;
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAnioCursado.Location = new System.Drawing.Point(627, 163);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(79, 15);
            this.lblAnioCursado.TabIndex = 171;
            this.lblAnioCursado.Text = "Año Cursado:";
            // 
            // dgvPromedioAlumnos
            // 
            this.dgvPromedioAlumnos.AllowUserToAddRows = false;
            this.dgvPromedioAlumnos.AllowUserToDeleteRows = false;
            this.dgvPromedioAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPromedioAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPromedioAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedioAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPromedioAlumnos.ColumnHeadersHeight = 30;
            this.dgvPromedioAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPromedioAlumnos.EnableHeadersVisualStyles = false;
            this.dgvPromedioAlumnos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPromedioAlumnos.Location = new System.Drawing.Point(55, 294);
            this.dgvPromedioAlumnos.Name = "dgvPromedioAlumnos";
            this.dgvPromedioAlumnos.ReadOnly = true;
            this.dgvPromedioAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedioAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPromedioAlumnos.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPromedioAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPromedioAlumnos.Size = new System.Drawing.Size(845, 207);
            this.dgvPromedioAlumnos.TabIndex = 173;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 80;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 320;
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            this.Anio.Width = 60;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 60;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 320;
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(931, 294);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 51);
            this.btnSearch.TabIndex = 178;
            this.btnSearch.Tag = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnLimpiar.IconColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(931, 373);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 51);
            this.btnLimpiar.TabIndex = 177;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton3.IconColor = System.Drawing.Color.Yellow;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(931, 12);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(51, 51);
            this.iconButton3.TabIndex = 180;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // FrmPromedioAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1154, 711);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvPromedioAlumnos);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.lblIdCarrera);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.cboLegajo);
            this.Controls.Add(this.lblIdMateria);
            this.Controls.Add(this.lblLegajo);
            this.Name = "FrmPromedioAlumno";
            this.Text = "Consulta Promedio Alumno";
            this.Load += new System.EventHandler(this.FrmPromedioAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedioAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdCurso;
        private RJCodeAdvance.RJControls.RJComboBox cboCurso;
        private RJCodeAdvance.RJControls.RJComboBox cboMateria;
        private RJCodeAdvance.RJControls.RJComboBox cboLegajo;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.Label lblLegajo;
        private RJCodeAdvance.RJControls.RJComboBox cboCarrera;
        private System.Windows.Forms.Label lblIdCarrera;
        private RJCodeAdvance.RJControls.RJDatePicker dtpAnioCursado;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.DataGridView dgvPromedioAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}