
namespace AcademikaFront.Presentacion.Consultas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.cboCarrera = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboCurso = new RJCodeAdvance.RJControls.RJComboBox();
            this.cboMateria = new RJCodeAdvance.RJControls.RJComboBox();
            this.cboCondicion = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.dtpAnioCursado = new RJCodeAdvance.RJControls.RJDatePicker();
            this.dgvCondicionAlumnos = new System.Windows.Forms.DataGridView();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionAlumnos)).BeginInit();
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
            this.cboCarrera.Location = new System.Drawing.Point(720, 94);
            this.cboCarrera.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Padding = new System.Windows.Forms.Padding(1);
            this.cboCarrera.Size = new System.Drawing.Size(252, 44);
            this.cboCarrera.TabIndex = 160;
            this.cboCarrera.Texts = "";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurso.Location = new System.Drawing.Point(83, 167);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(41, 15);
            this.lblCurso.TabIndex = 159;
            this.lblCurso.Text = "Curso:";
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
            this.cboCurso.Location = new System.Drawing.Point(154, 154);
            this.cboCurso.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Padding = new System.Windows.Forms.Padding(1);
            this.cboCurso.Size = new System.Drawing.Size(200, 30);
            this.cboCurso.TabIndex = 158;
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
            this.cboMateria.Location = new System.Drawing.Point(425, 94);
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
            this.lblCarrera.Location = new System.Drawing.Point(666, 109);
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
            // dgvCondicionAlumnos
            // 
            this.dgvCondicionAlumnos.AllowUserToAddRows = false;
            this.dgvCondicionAlumnos.AllowUserToDeleteRows = false;
            this.dgvCondicionAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCondicionAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCondicionAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondicionAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCondicionAlumnos.ColumnHeadersHeight = 30;
            this.dgvCondicionAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCondicionAlumnos.EnableHeadersVisualStyles = false;
            this.dgvCondicionAlumnos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCondicionAlumnos.Location = new System.Drawing.Point(59, 248);
            this.dgvCondicionAlumnos.Name = "dgvCondicionAlumnos";
            this.dgvCondicionAlumnos.ReadOnly = true;
            this.dgvCondicionAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondicionAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCondicionAlumnos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCondicionAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCondicionAlumnos.Size = new System.Drawing.Size(913, 207);
            this.dgvCondicionAlumnos.TabIndex = 164;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton3.IconColor = System.Drawing.Color.Yellow;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(991, 8);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(51, 51);
            this.iconButton3.TabIndex = 182;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // FrmCondicionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1154, 711);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvCondicionAlumnos);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.cboCondicion);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblCondicion);
            this.Name = "FrmCondicionAlumnos";
            this.Text = "Consultar Condición Alumnos";
            this.Load += new System.EventHandler(this.FrmCondicionAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnioCursado;
        private RJCodeAdvance.RJControls.RJComboBox cboCarrera;
        private System.Windows.Forms.Label lblCurso;
        private RJCodeAdvance.RJControls.RJComboBox cboCurso;
        private RJCodeAdvance.RJControls.RJComboBox cboMateria;
        private RJCodeAdvance.RJControls.RJComboBox cboCondicion;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCondicion;
        private RJCodeAdvance.RJControls.RJDatePicker dtpAnioCursado;
        private System.Windows.Forms.DataGridView dgvCondicionAlumnos;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}