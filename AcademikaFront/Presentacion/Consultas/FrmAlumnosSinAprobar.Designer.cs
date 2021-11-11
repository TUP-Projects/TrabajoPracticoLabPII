
namespace AcademikaFront.Presentacion.Consultas
{
    partial class FrmAlumnosSinAprobar
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
            this.dgvAlumnosSinAprobar = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpAnioCursado = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosSinAprobar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnosSinAprobar
            // 
            this.dgvAlumnosSinAprobar.AllowUserToAddRows = false;
            this.dgvAlumnosSinAprobar.AllowUserToDeleteRows = false;
            this.dgvAlumnosSinAprobar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvAlumnosSinAprobar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnosSinAprobar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnosSinAprobar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnosSinAprobar.ColumnHeadersHeight = 30;
            this.dgvAlumnosSinAprobar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlumnosSinAprobar.EnableHeadersVisualStyles = false;
            this.dgvAlumnosSinAprobar.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAlumnosSinAprobar.Location = new System.Drawing.Point(77, 217);
            this.dgvAlumnosSinAprobar.Name = "dgvAlumnosSinAprobar";
            this.dgvAlumnosSinAprobar.ReadOnly = true;
            this.dgvAlumnosSinAprobar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnosSinAprobar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnosSinAprobar.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAlumnosSinAprobar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnosSinAprobar.Size = new System.Drawing.Size(784, 349);
            this.dgvAlumnosSinAprobar.TabIndex = 174;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 80;
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.Name = "Alumno";
            this.Alumno.ReadOnly = true;
            this.Alumno.Width = 320;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 320;
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            this.Anio.Width = 60;
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpAnioCursado.BorderSize = 0;
            this.dtpAnioCursado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpAnioCursado.Location = new System.Drawing.Point(177, 105);
            this.dtpAnioCursado.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(200, 35);
            this.dtpAnioCursado.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpAnioCursado.TabIndex = 182;
            this.dtpAnioCursado.TextColor = System.Drawing.Color.White;
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAnioCursado.Location = new System.Drawing.Point(78, 118);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(93, 15);
            this.lblAnioCursado.TabIndex = 181;
            this.lblAnioCursado.Text = "Año Inscripción:";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(413, 93);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 51);
            this.iconButton1.TabIndex = 180;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnLimpiar.IconColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(472, 93);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 51);
            this.btnLimpiar.TabIndex = 183;
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
            this.iconButton3.Location = new System.Drawing.Point(810, 12);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(51, 51);
            this.iconButton3.TabIndex = 184;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // FrmAlumnosSinAprobar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1154, 711);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dgvAlumnosSinAprobar);
            this.Name = "FrmAlumnosSinAprobar";
            this.Text = "Alumnos sin aprobar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosSinAprobar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAlumnosSinAprobar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private RJCodeAdvance.RJControls.RJDatePicker dtpAnioCursado;
        private System.Windows.Forms.Label lblAnioCursado;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}