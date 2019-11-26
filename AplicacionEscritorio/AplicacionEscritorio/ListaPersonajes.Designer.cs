namespace AplicacionEscritorio
{
    partial class ListaPersonajes
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
            this.comboBoxIdiomes = new System.Windows.Forms.ComboBox();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.Personaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLista = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdiomes
            // 
            this.comboBoxIdiomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdiomes.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdiomes.FormattingEnabled = true;
            this.comboBoxIdiomes.Location = new System.Drawing.Point(209, 87);
            this.comboBoxIdiomes.Name = "comboBoxIdiomes";
            this.comboBoxIdiomes.Size = new System.Drawing.Size(121, 25);
            this.comboBoxIdiomes.TabIndex = 46;
            this.comboBoxIdiomes.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomes_SelectedIndexChanged);
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.BackColor = System.Drawing.Color.Transparent;
            this.labelIdioma.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdioma.ForeColor = System.Drawing.Color.White;
            this.labelIdioma.Location = new System.Drawing.Point(21, 87);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(182, 21);
            this.labelIdioma.TabIndex = 45;
            this.labelIdioma.Text = "Idioma de los personajes";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.CausesValidation = false;
            this.buttonCancelar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(624, 472);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 37);
            this.buttonCancelar.TabIndex = 44;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.White;
            this.buttonEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(177, 472);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(138, 37);
            this.buttonEliminar.TabIndex = 43;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.White;
            this.buttonEditar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(12, 472);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(138, 37);
            this.buttonEditar.TabIndex = 42;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.AllowUserToAddRows = false;
            this.dataGridViewPersonajes.AllowUserToDeleteRows = false;
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personaje,
            this.Descripción,
            this.Imagen});
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(12, 117);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.ReadOnly = true;
            this.dataGridViewPersonajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(720, 337);
            this.dataGridViewPersonajes.TabIndex = 41;
            // 
            // Personaje
            // 
            this.Personaje.DataPropertyName = "nombre";
            this.Personaje.HeaderText = "Personaje";
            this.Personaje.Name = "Personaje";
            this.Personaje.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "imagen";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.BackColor = System.Drawing.Color.Transparent;
            this.labelLista.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLista.ForeColor = System.Drawing.Color.White;
            this.labelLista.Location = new System.Drawing.Point(242, 22);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(293, 37);
            this.labelLista.TabIndex = 40;
            this.labelLista.Text = "LISTA DE PERSONAJES";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.White;
            this.buttonGuardar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(321, 472);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(138, 37);
            this.buttonGuardar.TabIndex = 47;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ListaPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionEscritorio.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 531);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.comboBoxIdiomes);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.labelLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListaPersonajes";
            this.Text = "Lista Personajes";
            this.Load += new System.EventHandler(this.ListaPersonajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxIdiomes;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.Button buttonGuardar;
    }
}