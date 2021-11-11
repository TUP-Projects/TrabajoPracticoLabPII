
namespace AcademikaFront.Presentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.cboSituacionHabitacional = new RJCodeAdvance.RJControls.RJComboBox();
            this.cboIdMateria = new RJCodeAdvance.RJControls.RJComboBox();
            this.cboLegajo = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cboIdCarrera = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblIdCarrera = new System.Windows.Forms.Label();
            this.dtpAnioCursado = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cboSituacionHabitacional.Location = new System.Drawing.Point(126, 208);
            this.cboSituacionHabitacional.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboSituacionHabitacional.Name = "cboSituacionHabitacional";
            this.cboSituacionHabitacional.Padding = new System.Windows.Forms.Padding(1);
            this.cboSituacionHabitacional.Size = new System.Drawing.Size(200, 30);
            this.cboSituacionHabitacional.TabIndex = 166;
            this.cboSituacionHabitacional.Texts = "";
            // 
            // cboIdMateria
            // 
            this.cboIdMateria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboIdMateria.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboIdMateria.BorderSize = 1;
            this.cboIdMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboIdMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIdMateria.ForeColor = System.Drawing.Color.DimGray;
            this.cboIdMateria.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboIdMateria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboIdMateria.ListTextColor = System.Drawing.Color.DimGray;
            this.cboIdMateria.Location = new System.Drawing.Point(397, 148);
            this.cboIdMateria.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboIdMateria.Name = "cboIdMateria";
            this.cboIdMateria.Padding = new System.Windows.Forms.Padding(1);
            this.cboIdMateria.Size = new System.Drawing.Size(200, 30);
            this.cboIdMateria.TabIndex = 165;
            this.cboIdMateria.Texts = "";
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
            this.lblLegajo.Size = new System.Drawing.Size(45, 15);
            this.lblLegajo.TabIndex = 161;
            this.lblLegajo.Text = "Legajo:";
            // 
            // cboIdCarrera
            // 
            this.cboIdCarrera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboIdCarrera.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboIdCarrera.BorderSize = 1;
            this.cboIdCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboIdCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIdCarrera.ForeColor = System.Drawing.Color.DimGray;
            this.cboIdCarrera.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboIdCarrera.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboIdCarrera.ListTextColor = System.Drawing.Color.DimGray;
            this.cboIdCarrera.Location = new System.Drawing.Point(423, 208);
            this.cboIdCarrera.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboIdCarrera.Name = "cboIdCarrera";
            this.cboIdCarrera.Padding = new System.Windows.Forms.Padding(1);
            this.cboIdCarrera.Size = new System.Drawing.Size(200, 30);
            this.cboIdCarrera.TabIndex = 170;
            this.cboIdCarrera.Texts = "";
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
            this.Legajo,
            this.Materia,
            this.Anio,
            this.Curso,
            this.Carrera});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(55, 294);
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
            this.dataGridView1.Size = new System.Drawing.Size(845, 207);
            this.dataGridView1.TabIndex = 173;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 179;
            this.label1.Text = "SP_PROMEDIO_NOTAS";
            // 
            // FrmPromedioAlumno
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
            this.Controls.Add(this.cboIdCarrera);
            this.Controls.Add(this.lblIdCarrera);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.cboSituacionHabitacional);
            this.Controls.Add(this.cboIdMateria);
            this.Controls.Add(this.cboLegajo);
            this.Controls.Add(this.lblIdMateria);
            this.Controls.Add(this.lblLegajo);
            this.Name = "FrmPromedioAlumno";
            this.Text = "Consulta Promedio Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdCurso;
        private RJCodeAdvance.RJControls.RJComboBox cboSituacionHabitacional;
        private RJCodeAdvance.RJControls.RJComboBox cboIdMateria;
        private RJCodeAdvance.RJControls.RJComboBox cboLegajo;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.Label lblLegajo;
        private RJCodeAdvance.RJControls.RJComboBox cboIdCarrera;
        private System.Windows.Forms.Label lblIdCarrera;
        private RJCodeAdvance.RJControls.RJDatePicker dtpAnioCursado;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Label label1;
    }
}