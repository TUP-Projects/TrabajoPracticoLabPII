namespace Academika.Presentacion
{
    partial class FrmAltaMateria
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
            this.txtNombreMateria = new System.Windows.Forms.RichTextBox();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_Guardar = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbAyuda = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLegajoDocente
            // 
            this.lblLegajoDocente.AutoSize = true;
            this.lblLegajoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLegajoDocente.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLegajoDocente.Location = new System.Drawing.Point(126, 33);
            this.lblLegajoDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegajoDocente.Name = "lblLegajoDocente";
            this.lblLegajoDocente.Size = new System.Drawing.Size(92, 20);
            this.lblLegajoDocente.TabIndex = 88;
            this.lblLegajoDocente.Text = "ID Materia:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(214, 75);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(190, 28);
            this.txtNombreMateria.TabIndex = 89;
            this.txtNombreMateria.Text = "";
            this.txtNombreMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMateria_KeyPress);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AllowUserToOrderColumns = true;
            this.dgvMaterias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterias.ColumnHeadersHeight = 30;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Materia,
            this.Estado});
            this.dgvMaterias.EnableHeadersVisualStyles = false;
            this.dgvMaterias.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMaterias.Location = new System.Drawing.Point(131, 178);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaterias.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMaterias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaterias.Size = new System.Drawing.Size(544, 258);
            this.dgvMaterias.TabIndex = 90;
            this.dgvMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellContentClick);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton2.IconColor = System.Drawing.Color.Crimson;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(413, 467);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(51, 51);
            this.iconButton2.TabIndex = 107;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Guardar.IconColor = System.Drawing.Color.ForestGreen;
            this.btn_Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Guardar.Location = new System.Drawing.Point(233, 467);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(51, 51);
            this.btn_Guardar.TabIndex = 106;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.Location = new System.Drawing.Point(739, 283);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(51, 51);
            this.btnBorrar.TabIndex = 114;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(739, 178);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 51);
            this.btnEditar.TabIndex = 113;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(149, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 115;
            this.label3.Text = "Materia";
            // 
            // rtbAyuda
            // 
            this.rtbAyuda.AutoSize = true;
            this.rtbAyuda.ForeColor = System.Drawing.Color.Transparent;
            this.rtbAyuda.Location = new System.Drawing.Point(668, 467);
            this.rtbAyuda.Name = "rtbAyuda";
            this.rtbAyuda.Size = new System.Drawing.Size(0, 15);
            this.rtbAyuda.TabIndex = 118;
            this.rtbAyuda.Visible = false;
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
            this.iconButton3.TabIndex = 119;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(494, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 121;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(547, 75);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 28);
            this.txtSearch.TabIndex = 120;
            this.txtSearch.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(760, 73);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 122;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "Id_Materia";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            this.ID.Width = 45;
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Materia.DataPropertyName = "NombreMateria";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Materia.Width = 400;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.Visible = false;
            this.Estado.Width = 140;
            // 
            // FrmAltaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 711);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.rtbAyuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.lblLegajoDocente);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAltaMateria";
            this.Tag = "Ejemplo: 1W3";
            this.Text = "Alta Materia";
            this.Load += new System.EventHandler(this.FrmAltaMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajoDocente;
        private System.Windows.Forms.RichTextBox txtNombreMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btn_Guardar;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rtbAyuda;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}