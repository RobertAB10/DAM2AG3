namespace AplicacionEscritorio
{
    partial class NuevoPersonaje
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
            this.labelNuevaPregunta = new System.Windows.Forms.Label();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.pictureBoxIdioma = new System.Windows.Forms.PictureBox();
            this.comboBoxIdiomes = new System.Windows.Forms.ComboBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPersonaje
            // 
            this.pictureBoxPersonaje.Location = new System.Drawing.Point(12, 121);
            this.pictureBoxPersonaje.Name = "pictureBoxPersonaje";
            this.pictureBoxPersonaje.Size = new System.Drawing.Size(329, 398);
            this.pictureBoxPersonaje.TabIndex = 0;
            this.pictureBoxPersonaje.TabStop = false;
            this.pictureBoxPersonaje.Click += new System.EventHandler(this.pictureBoxPersonaje_Click);
            // 
            // labelNuevaPregunta
            // 
            this.labelNuevaPregunta.AutoSize = true;
            this.labelNuevaPregunta.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaPregunta.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaPregunta.ForeColor = System.Drawing.Color.White;
            this.labelNuevaPregunta.Location = new System.Drawing.Point(281, 59);
            this.labelNuevaPregunta.Name = "labelNuevaPregunta";
            this.labelNuevaPregunta.Size = new System.Drawing.Size(261, 37);
            this.labelNuevaPregunta.TabIndex = 1;
            this.labelNuevaPregunta.Text = "NUEVO PERSONAJE";
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.BackColor = System.Drawing.Color.Transparent;
            this.labelPregunta.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPregunta.ForeColor = System.Drawing.Color.White;
            this.labelPregunta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPregunta.Location = new System.Drawing.Point(372, 121);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(68, 21);
            this.labelPregunta.TabIndex = 2;
            this.labelPregunta.Text = "Nombre";
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
            this.textBoxDescripcion.Size = new System.Drawing.Size(356, 135);
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
            // NuevoPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionEscritorio.Properties.Resources.Fondopantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 531);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.pictureBoxIdioma);
            this.Controls.Add(this.comboBoxIdiomes);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.labelNuevaPregunta);
            this.Controls.Add(this.pictureBoxPersonaje);
            this.Name = "NuevoPersonaje";
            this.Text = "Nuevo Personaje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NuevoPersonaje_FormClosing);
            this.Load += new System.EventHandler(this.NuevoPersonaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPersonaje;
        private System.Windows.Forms.Label labelNuevaPregunta;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.PictureBox pictureBoxIdioma;
        private System.Windows.Forms.ComboBox comboBoxIdiomes;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}