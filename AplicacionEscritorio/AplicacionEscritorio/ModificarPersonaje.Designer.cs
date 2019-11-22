namespace AplicacionEscritorio
{
    partial class ModificarPersonaje
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
            this.pictureBoxPersonaje = new System.Windows.Forms.PictureBox();
            this.labelModificarPersonaje = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.pictureBoxIdioma = new System.Windows.Forms.PictureBox();
            this.comboBoxIdiomes = new System.Windows.Forms.ComboBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPersonaje
            // 
            this.pictureBoxPersonaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPersonaje.Location = new System.Drawing.Point(12, 121);
            this.pictureBoxPersonaje.Name = "pictureBoxPersonaje";
            this.pictureBoxPersonaje.Size = new System.Drawing.Size(329, 350);
            this.pictureBoxPersonaje.TabIndex = 0;
            this.pictureBoxPersonaje.TabStop = false;
            this.pictureBoxPersonaje.Click += new System.EventHandler(this.pictureBoxPersonaje_Click);
            // 
            // labelModificarPersonaje
            // 
            this.labelModificarPersonaje.AutoSize = true;
            this.labelModificarPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.labelModificarPersonaje.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarPersonaje.ForeColor = System.Drawing.Color.White;
            this.labelModificarPersonaje.Location = new System.Drawing.Point(240, 9);
            this.labelModificarPersonaje.Name = "labelModificarPersonaje";
            this.labelModificarPersonaje.Size = new System.Drawing.Size(316, 37);
            this.labelModificarPersonaje.TabIndex = 1;
            this.labelModificarPersonaje.Text = "MODIFICAR PERSONAJE";
            this.labelModificarPersonaje.Click += new System.EventHandler(this.labelNuevaPregunta_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelNombre.Location = new System.Drawing.Point(372, 121);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 21);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(376, 156);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(356, 25);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labelDescripcion.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDescripcion.Location = new System.Drawing.Point(372, 219);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(91, 21);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // pictureBoxIdioma
            // 
            this.pictureBoxIdioma.Location = new System.Drawing.Point(560, 14);
            this.pictureBoxIdioma.Name = "pictureBoxIdioma";
            this.pictureBoxIdioma.Size = new System.Drawing.Size(45, 37);
            this.pictureBoxIdioma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIdioma.TabIndex = 41;
            this.pictureBoxIdioma.TabStop = false;
            // 
            // comboBoxIdiomes
            // 
            this.comboBoxIdiomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdiomes.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdiomes.FormattingEnabled = true;
            this.comboBoxIdiomes.Location = new System.Drawing.Point(611, 22);
            this.comboBoxIdiomes.Name = "comboBoxIdiomes";
            this.comboBoxIdiomes.Size = new System.Drawing.Size(121, 25);
            this.comboBoxIdiomes.TabIndex = 40;
            this.comboBoxIdiomes.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomes_SelectedIndexChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(376, 252);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(356, 219);
            this.textBoxDescripcion.TabIndex = 42;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.White;
            this.buttonConfirmar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(458, 482);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(138, 37);
            this.buttonConfirmar.TabIndex = 43;
            this.buttonConfirmar.Text = "CONFIRMAR";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.CausesValidation = false;
            this.buttonCancelar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(624, 482);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 37);
            this.buttonCancelar.TabIndex = 44;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.BackColor = System.Drawing.Color.Transparent;
            this.labelImagen.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagen.ForeColor = System.Drawing.Color.White;
            this.labelImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelImagen.Location = new System.Drawing.Point(85, 88);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(159, 21);
            this.labelImagen.TabIndex = 45;
            this.labelImagen.Text = "Imagen del personaje";
            // 
            // ModificarPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionEscritorio.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 531);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.pictureBoxIdioma);
            this.Controls.Add(this.comboBoxIdiomes);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelModificarPersonaje);
            this.Controls.Add(this.pictureBoxPersonaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarPersonaje";
            this.Text = "Nuevo Personaje";
            this.Load += new System.EventHandler(this.ModificarPersonaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPersonaje;
        private System.Windows.Forms.Label labelModificarPersonaje;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.PictureBox pictureBoxIdioma;
        private System.Windows.Forms.ComboBox comboBoxIdiomes;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelImagen;
    }
}