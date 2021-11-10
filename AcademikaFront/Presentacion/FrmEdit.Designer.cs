namespace Academika.Presentacion
{
    partial class FrmEdit
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.rtbAyuda = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.Nup_Duracion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Duracion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(13, 9);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 88;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 28);
            this.txtNombre.TabIndex = 89;
            this.txtNombre.Text = "";
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.Crimson;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(232, 82);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 51);
            this.btnCancelar.TabIndex = 107;
            this.btnCancelar.Tag = "";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(232, 17);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 51);
            this.btnGuardar.TabIndex = 106;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rtbAyuda
            // 
            this.rtbAyuda.AutoSize = true;
            this.rtbAyuda.Location = new System.Drawing.Point(668, 467);
            this.rtbAyuda.Name = "rtbAyuda";
            this.rtbAyuda.Size = new System.Drawing.Size(0, 15);
            this.rtbAyuda.TabIndex = 117;
            this.rtbAyuda.Visible = false;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDuracion.Location = new System.Drawing.Point(13, 74);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(77, 20);
            this.lblDuracion.TabIndex = 125;
            this.lblDuracion.Text = "Duración";
            // 
            // Nup_Duracion
            // 
            this.Nup_Duracion.Location = new System.Drawing.Point(13, 98);
            this.Nup_Duracion.Name = "Nup_Duracion";
            this.Nup_Duracion.Size = new System.Drawing.Size(190, 23);
            this.Nup_Duracion.TabIndex = 126;
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(305, 158);
            this.Controls.Add(this.Nup_Duracion);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.rtbAyuda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Ejemplo: 1W3";
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.Nup_Duracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label rtbAyuda;
        private System.Windows.Forms.RichTextBox txtNombre;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown Nup_Duracion;
    }
}