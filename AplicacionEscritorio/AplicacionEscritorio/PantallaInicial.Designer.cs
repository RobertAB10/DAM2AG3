namespace AplicacionEscritorio
{
    partial class PantallaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicial));
            this.buttonNuevaPregunta = new System.Windows.Forms.Button();
            this.buttonListaPreguntas = new System.Windows.Forms.Button();
            this.buttonNuevoPersonaje = new System.Windows.Forms.Button();
            this.buttonListaPersonajes = new System.Windows.Forms.Button();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevaPregunta
            // 
            this.buttonNuevaPregunta.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaPregunta.Location = new System.Drawing.Point(47, 203);
            this.buttonNuevaPregunta.Name = "buttonNuevaPregunta";
            this.buttonNuevaPregunta.Size = new System.Drawing.Size(299, 54);
            this.buttonNuevaPregunta.TabIndex = 0;
            this.buttonNuevaPregunta.Text = "NUEVA PREGUNTA";
            this.buttonNuevaPregunta.UseVisualStyleBackColor = true;
            this.buttonNuevaPregunta.Click += new System.EventHandler(this.buttonNuevaPregunta_Click);
            // 
            // buttonListaPreguntas
            // 
            this.buttonListaPreguntas.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListaPreguntas.Location = new System.Drawing.Point(47, 303);
            this.buttonListaPreguntas.Name = "buttonListaPreguntas";
            this.buttonListaPreguntas.Size = new System.Drawing.Size(299, 54);
            this.buttonListaPreguntas.TabIndex = 1;
            this.buttonListaPreguntas.Text = "LISTA DE PREGUNTAS";
            this.buttonListaPreguntas.UseVisualStyleBackColor = true;
            this.buttonListaPreguntas.Click += new System.EventHandler(this.buttonListaPreguntas_Click);
            // 
            // buttonNuevoPersonaje
            // 
            this.buttonNuevoPersonaje.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoPersonaje.Location = new System.Drawing.Point(402, 203);
            this.buttonNuevoPersonaje.Name = "buttonNuevoPersonaje";
            this.buttonNuevoPersonaje.Size = new System.Drawing.Size(299, 54);
            this.buttonNuevoPersonaje.TabIndex = 2;
            this.buttonNuevoPersonaje.Text = "NUEVO PERSONAJE";
            this.buttonNuevoPersonaje.UseVisualStyleBackColor = true;
            this.buttonNuevoPersonaje.Click += new System.EventHandler(this.buttonNuevoPersonaje_Click);
            // 
            // buttonListaPersonajes
            // 
            this.buttonListaPersonajes.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListaPersonajes.Location = new System.Drawing.Point(402, 303);
            this.buttonListaPersonajes.Name = "buttonListaPersonajes";
            this.buttonListaPersonajes.Size = new System.Drawing.Size(299, 54);
            this.buttonListaPersonajes.TabIndex = 3;
            this.buttonListaPersonajes.Text = "LISTA PERSONAJES";
            this.buttonListaPersonajes.UseVisualStyleBackColor = true;
            this.buttonListaPersonajes.Click += new System.EventHandler(this.buttonListaPersonajes_Click);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.BackgroundImage")));
            this.pictureBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxInfo.Location = new System.Drawing.Point(684, 12);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(48, 41);
            this.pictureBoxInfo.TabIndex = 31;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.pictureBoxInfo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::AplicacionEscritorio.Properties.Resources.Logo_Blanco_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(181, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 195);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // buttonExportar
            // 
            this.buttonExportar.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.Location = new System.Drawing.Point(226, 409);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(299, 54);
            this.buttonExportar.TabIndex = 33;
            this.buttonExportar.Text = "EXPORTAR";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionEscritorio.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 531);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.buttonListaPersonajes);
            this.Controls.Add(this.buttonNuevoPersonaje);
            this.Controls.Add(this.buttonListaPreguntas);
            this.Controls.Add(this.buttonNuevaPregunta);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PantallaInicial";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.PantallaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevaPregunta;
        private System.Windows.Forms.Button buttonListaPreguntas;
        private System.Windows.Forms.Button buttonNuevoPersonaje;
        private System.Windows.Forms.Button buttonListaPersonajes;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonExportar;
    }
}