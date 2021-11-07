namespace Academika.Presentacion
{
    partial class FrmAltaDocentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjTextBox5 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox6 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton2.IconColor = System.Drawing.Color.Crimson;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(485, 509);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(65, 55);
            this.iconButton2.TabIndex = 104;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(276, 509);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(65, 55);
            this.iconButton1.TabIndex = 103;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreTec,
            this.Anio,
            this.Cuatrimestre});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(29, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Size = new System.Drawing.Size(807, 260);
            this.dataGridView1.TabIndex = 114;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox5.BorderRadius = 0;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox5.Location = new System.Drawing.Point(649, 82);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox5.PlaceholderText = "";
            this.rjTextBox5.Size = new System.Drawing.Size(187, 33);
            this.rjTextBox5.TabIndex = 159;
            this.rjTextBox5.Texts = "Correo electrónico";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // rjTextBox6
            // 
            this.rjTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox6.BorderRadius = 0;
            this.rjTextBox6.BorderSize = 2;
            this.rjTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox6.Location = new System.Drawing.Point(444, 82);
            this.rjTextBox6.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox6.Multiline = false;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.rjTextBox6.PasswordChar = false;
            this.rjTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox6.PlaceholderText = "";
            this.rjTextBox6.Size = new System.Drawing.Size(187, 33);
            this.rjTextBox6.TabIndex = 158;
            this.rjTextBox6.Texts = "Teléfono";
            this.rjTextBox6.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(234, 82);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(187, 33);
            this.rjTextBox2.TabIndex = 153;
            this.rjTextBox2.Texts = "Nombre";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(29, 82);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(187, 33);
            this.rjTextBox1.TabIndex = 152;
            this.rjTextBox1.Texts = "Apellido";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 139;
            this.label1.Text = "Legajo Docente N°:";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NombreTec
            // 
            this.NombreTec.HeaderText = "Nombre";
            this.NombreTec.Name = "NombreTec";
            this.NombreTec.ReadOnly = true;
            this.NombreTec.Width = 300;
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.ReadOnly = true;
            this.Cuatrimestre.Width = 160;
            // 
            // iconButton6
            // 
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(867, 288);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(65, 55);
            this.iconButton6.TabIndex = 161;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton7
            // 
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.Location = new System.Drawing.Point(867, 190);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(65, 55);
            this.iconButton7.TabIndex = 160;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton3.IconColor = System.Drawing.Color.Yellow;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(1027, 644);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(65, 55);
            this.iconButton3.TabIndex = 162;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // FrmAltaDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1104, 711);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.rjTextBox5);
            this.Controls.Add(this.rjTextBox6);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAltaDocentes";
            this.Text = "Alta Docentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox5;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox6;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox2;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}