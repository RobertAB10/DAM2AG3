namespace AplicacionEscritorio
{
    partial class Informacion
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
            this.labelNuevaPregunta = new System.Windows.Forms.Label();
            this.pictureBoxIdioma = new System.Windows.Forms.PictureBox();
            this.comboBoxIdiomes = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNuevaPregunta
            // 
            this.labelNuevaPregunta.AutoSize = true;
            this.labelNuevaPregunta.BackColor = System.Drawing.Color.Transparent;
            this.labelNuevaPregunta.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaPregunta.ForeColor = System.Drawing.Color.White;
            this.labelNuevaPregunta.Location = new System.Drawing.Point(173, 9);
            this.labelNuevaPregunta.Name = "labelNuevaPregunta";
            this.labelNuevaPregunta.Size = new System.Drawing.Size(206, 37);
            this.labelNuevaPregunta.TabIndex = 2;
            this.labelNuevaPregunta.Text = "INFORMACIÓN";
            // 
            // pictureBoxIdioma
            // 
            this.pictureBoxIdioma.Location = new System.Drawing.Point(12, 64);
            this.pictureBoxIdioma.Name = "pictureBoxIdioma";
            this.pictureBoxIdioma.Size = new System.Drawing.Size(45, 37);
            this.pictureBoxIdioma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIdioma.TabIndex = 43;
            this.pictureBoxIdioma.TabStop = false;
            // 
            // comboBoxIdiomes
            // 
            this.comboBoxIdiomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdiomes.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdiomes.FormattingEnabled = true;
            this.comboBoxIdiomes.Location = new System.Drawing.Point(63, 72);
            this.comboBoxIdiomes.Name = "comboBoxIdiomes";
            this.comboBoxIdiomes.Size = new System.Drawing.Size(121, 25);
            this.comboBoxIdiomes.TabIndex = 42;
            this.comboBoxIdiomes.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomes_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.richTextBox1.Location = new System.Drawing.Point(12, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(301, 47);
            this.richTextBox1.TabIndex = 45;
            this.richTextBox1.Text = "El idioma seleccionado al crear un nuevo elemento nos indica en que archivo de id" +
    "ioma guardaremos, no el idioma de la aplicación";
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionEscritorio.Properties.Resources.Fondopantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 367);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBoxIdioma);
            this.Controls.Add(this.comboBoxIdiomes);
            this.Controls.Add(this.labelNuevaPregunta);
            this.Name = "Informacion";
            this.Text = "Informacion";
            this.Load += new System.EventHandler(this.Informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdioma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNuevaPregunta;
        private System.Windows.Forms.PictureBox pictureBoxIdioma;
        private System.Windows.Forms.ComboBox comboBoxIdiomes;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}