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
            this.SuspendLayout();
            // 
            // buttonNuevaPregunta
            // 
            this.buttonNuevaPregunta.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaPregunta.Location = new System.Drawing.Point(208, 224);
            this.buttonNuevaPregunta.Name = "buttonNuevaPregunta";
            this.buttonNuevaPregunta.Size = new System.Drawing.Size(343, 54);
            this.buttonNuevaPregunta.TabIndex = 0;
            this.buttonNuevaPregunta.Text = "NUEVA PREGUNTA";
            this.buttonNuevaPregunta.UseVisualStyleBackColor = true;
            this.buttonNuevaPregunta.Click += new System.EventHandler(this.buttonNuevaPregunta_Click);
            // 
            // buttonListaPreguntas
            // 
            this.buttonListaPreguntas.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListaPreguntas.Location = new System.Drawing.Point(208, 310);
            this.buttonListaPreguntas.Name = "buttonListaPreguntas";
            this.buttonListaPreguntas.Size = new System.Drawing.Size(343, 54);
            this.buttonListaPreguntas.TabIndex = 1;
            this.buttonListaPreguntas.Text = "LISTA DE PREGUNTAS";
            this.buttonListaPreguntas.UseVisualStyleBackColor = true;
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 531);
            this.Controls.Add(this.buttonListaPreguntas);
            this.Controls.Add(this.buttonNuevaPregunta);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PantallaInicial";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.PantallaInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevaPregunta;
        private System.Windows.Forms.Button buttonListaPreguntas;
    }
}