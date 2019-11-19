namespace AplicacionEscritorio
{
    partial class ListaPreguntas
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
            this.labelLista = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.dataGridViewPreguntas = new System.Windows.Forms.DataGridView();
            this.Personaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxIdiomes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.BackColor = System.Drawing.Color.Transparent;
            this.labelLista.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLista.ForeColor = System.Drawing.Color.White;
            this.labelLista.Location = new System.Drawing.Point(242, 19);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(285, 37);
            this.labelLista.TabIndex = 26;
            this.labelLista.Text = "LISTA DE PREGUNTAS";
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.White;
            this.buttonEditar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(12, 469);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(138, 37);
            this.buttonEditar.TabIndex = 32;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.White;
            this.buttonEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(177, 469);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(138, 37);
            this.buttonEliminar.TabIndex = 33;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.CausesValidation = false;
            this.buttonCancelar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(624, 469);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 37);
            this.buttonCancelar.TabIndex = 34;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.BackColor = System.Drawing.Color.Transparent;
            this.labelIdioma.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdioma.ForeColor = System.Drawing.Color.White;
            this.labelIdioma.Location = new System.Drawing.Point(21, 84);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(176, 21);
            this.labelIdioma.TabIndex = 36;
            this.labelIdioma.Text = "Idioma de las preguntas";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.BackColor = System.Drawing.Color.Transparent;
            this.labelNivel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivel.ForeColor = System.Drawing.Color.White;
            this.labelNivel.Location = new System.Drawing.Point(389, 84);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(164, 21);
            this.labelNivel.TabIndex = 38;
            this.labelNivel.Text = "Nivel de las preguntas";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.BackColor = System.Drawing.Color.White;
            this.comboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Location = new System.Drawing.Point(559, 80);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(121, 25);
            this.comboBoxNivel.TabIndex = 39;
            // 
            // dataGridViewPreguntas
            // 
            this.dataGridViewPreguntas.AllowUserToAddRows = false;
            this.dataGridViewPreguntas.AllowUserToDeleteRows = false;
            this.dataGridViewPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personaje,
            this.Nivel,
            this.Tema,
            this.Imagen});
            this.dataGridViewPreguntas.Location = new System.Drawing.Point(12, 111);
            this.dataGridViewPreguntas.Name = "dataGridViewPreguntas";
            this.dataGridViewPreguntas.ReadOnly = true;
            this.dataGridViewPreguntas.Size = new System.Drawing.Size(720, 337);
            this.dataGridViewPreguntas.TabIndex = 42;
            // 
            // Personaje
            // 
            this.Personaje.DataPropertyName = "pregunta";
            this.Personaje.HeaderText = "Pregunta";
            this.Personaje.Name = "Personaje";
            this.Personaje.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.DataPropertyName = "nivel";
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // Tema
            // 
            this.Tema.DataPropertyName = "tema";
            this.Tema.HeaderText = "Tema";
            this.Tema.Name = "Tema";
            this.Tema.ReadOnly = true;
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "imagen";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            // 
            // comboBoxIdiomes
            // 
            this.comboBoxIdiomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdiomes.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdiomes.FormattingEnabled = true;
            this.comboBoxIdiomes.Location = new System.Drawing.Point(203, 80);
            this.comboBoxIdiomes.Name = "comboBoxIdiomes";
            this.comboBoxIdiomes.Size = new System.Drawing.Size(121, 25);
            this.comboBoxIdiomes.TabIndex = 43;
            this.comboBoxIdiomes.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomes_SelectedIndexChanged_1);
            // 
            // ListaPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionEscritorio.Properties.Resources.Fondopantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 531);
            this.Controls.Add(this.comboBoxIdiomes);
            this.Controls.Add(this.dataGridViewPreguntas);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.labelNivel);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelLista);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListaPreguntas";
            this.Text = "ListaPreguntas";
            this.Load += new System.EventHandler(this.ListaPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.DataGridView dataGridViewPreguntas;
        private System.Windows.Forms.ComboBox comboBoxIdiomes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
    }
}