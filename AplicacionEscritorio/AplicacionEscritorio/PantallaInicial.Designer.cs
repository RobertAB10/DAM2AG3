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
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonImagenIdioma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.Gray;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.Location = new System.Drawing.Point(230, 96);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(328, 93);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "INICIAR";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Gray;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(266, 221);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(250, 90);
            this.buttonSalir.TabIndex = 1;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CASTELLANO",
            "CATALÀ",
            "ENGLISH"});
            this.comboBox1.Location = new System.Drawing.Point(332, 382);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // buttonImagenIdioma
            // 
            this.buttonImagenIdioma.BackColor = System.Drawing.Color.Transparent;
            this.buttonImagenIdioma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImagenIdioma.BackgroundImage")));
            this.buttonImagenIdioma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonImagenIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImagenIdioma.Location = new System.Drawing.Point(230, 359);
            this.buttonImagenIdioma.Name = "buttonImagenIdioma";
            this.buttonImagenIdioma.Size = new System.Drawing.Size(96, 65);
            this.buttonImagenIdioma.TabIndex = 4;
            this.buttonImagenIdioma.UseVisualStyleBackColor = false;
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionEscritorio.Properties.Resources.Universo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 460);
            this.Controls.Add(this.buttonImagenIdioma);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIniciar);
            this.Name = "PantallaInicial";
            this.Text = "PantallaInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonImagenIdioma;
    }
}