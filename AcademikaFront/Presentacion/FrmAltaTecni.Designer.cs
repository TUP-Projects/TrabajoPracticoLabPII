namespace Academika.Presentacion
{
    partial class FrmAltaTecni
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
            this.lblLegajoDocente = new System.Windows.Forms.Label();
            this.txt_NombreCarrera = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.dgvTecnicatura = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nup_Duracion = new System.Windows.Forms.NumericUpDown();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.rtbAyuda = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Duracion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLegajoDocente
            // 
            this.lblLegajoDocente.AutoSize = true;
            this.lblLegajoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLegajoDocente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLegajoDocente.Location = new System.Drawing.Point(138, 31);
            this.lblLegajoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegajoDocente.Name = "lblLegajoDocente";
            this.lblLegajoDocente.Size = new System.Drawing.Size(107, 18);
            this.lblLegajoDocente.TabIndex = 87;
            this.lblLegajoDocente.Text = "ID Tecnicatura:";
            // 
            // txt_NombreCarrera
            // 
            this.txt_NombreCarrera.Location = new System.Drawing.Point(141, 91);
            this.txt_NombreCarrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_NombreCarrera.Name = "txt_NombreCarrera";
            this.txt_NombreCarrera.Size = new System.Drawing.Size(137, 28);
            this.txt_NombreCarrera.TabIndex = 88;
            this.txt_NombreCarrera.Text = "";
            this.txt_NombreCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreCarrera_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(138, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 90;
            this.label1.Text = "Tecnicaturas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(316, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "Duración";
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(788, 227);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 51);
            this.btnEditar.TabIndex = 109;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton2.IconColor = System.Drawing.Color.Crimson;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(531, 559);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(51, 51);
            this.iconButton2.TabIndex = 107;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(310, 559);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 51);
            this.iconButton1.TabIndex = 106;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.Location = new System.Drawing.Point(788, 304);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(51, 51);
            this.btnBorrar.TabIndex = 110;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvTecnicatura
            // 
            this.dgvTecnicatura.AllowUserToAddRows = false;
            this.dgvTecnicatura.AllowUserToDeleteRows = false;
            this.dgvTecnicatura.AllowUserToOrderColumns = true;
            this.dgvTecnicatura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTecnicatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTecnicatura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTecnicatura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTecnicatura.ColumnHeadersHeight = 30;
            this.dgvTecnicatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTecnicatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreTec,
            this.Duración,
            this.Estado});
            this.dgvTecnicatura.EnableHeadersVisualStyles = false;
            this.dgvTecnicatura.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTecnicatura.Location = new System.Drawing.Point(141, 227);
            this.dgvTecnicatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTecnicatura.Name = "dgvTecnicatura";
            this.dgvTecnicatura.ReadOnly = true;
            this.dgvTecnicatura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTecnicatura.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTecnicatura.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTecnicatura.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTecnicatura.Size = new System.Drawing.Size(604, 258);
            this.dgvTecnicatura.TabIndex = 111;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_Carrera";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // NombreTec
            // 
            this.NombreTec.DataPropertyName = "NombreCarrera";
            this.NombreTec.HeaderText = "Nombre";
            this.NombreTec.Name = "NombreTec";
            this.NombreTec.ReadOnly = true;
            this.NombreTec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreTec.Width = 400;
            // 
            // Duración
            // 
            this.Duración.DataPropertyName = "Duracion";
            this.Duración.HeaderText = "Duración";
            this.Duración.Name = "Duración";
            this.Duración.ReadOnly = true;
            this.Duración.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.Visible = false;
            // 
            // Nup_Duracion
            // 
            this.Nup_Duracion.Location = new System.Drawing.Point(378, 96);
            this.Nup_Duracion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nup_Duracion.Name = "Nup_Duracion";
            this.Nup_Duracion.Size = new System.Drawing.Size(120, 23);
            this.Nup_Duracion.TabIndex = 120;
            this.Nup_Duracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton3.IconColor = System.Drawing.Color.Yellow;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(1041, 648);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(51, 51);
            this.iconButton3.TabIndex = 121;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // rtbAyuda
            // 
            this.rtbAyuda.AutoSize = true;
            this.rtbAyuda.Location = new System.Drawing.Point(1041, 612);
            this.rtbAyuda.Name = "rtbAyuda";
            this.rtbAyuda.Size = new System.Drawing.Size(0, 15);
            this.rtbAyuda.TabIndex = 122;
            this.rtbAyuda.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(807, 91);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 125;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(544, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 124;
            this.label2.Text = "Buscar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(597, 91);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 28);
            this.txtSearch.TabIndex = 123;
            this.txtSearch.Text = "";
            // 
            // FrmAltaTecni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 711);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rtbAyuda);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.Nup_Duracion);
            this.Controls.Add(this.dgvTecnicatura);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NombreCarrera);
            this.Controls.Add(this.lblLegajoDocente);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAltaTecni";
            this.Text = "Alta Carrera";
            this.Load += new System.EventHandler(this.FrmAltaTecni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnicatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Duracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajoDocente;
        private System.Windows.Forms.RichTextBox txt_NombreCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private System.Windows.Forms.NumericUpDown Nup_Duracion;
        private System.Windows.Forms.DataGridView dgvTecnicatura;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label rtbAyuda;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duración;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}