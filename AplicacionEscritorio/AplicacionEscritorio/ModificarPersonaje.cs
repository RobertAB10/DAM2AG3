using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    public partial class ModificarPersonaje : Form
    {

        List<Personaje> personajes = new List<Personaje>();
        Personaje personajeNuevo = new Personaje();

        public ModificarPersonaje(List<Personaje> personajes, Personaje personaje)
        {
            personajeNuevo = personaje;
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void pictureBoxPersonaje_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPersonaje.ImageLocation = openFileDialog.FileName;
                pictureBoxPersonaje.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void ModificarPersonaje_Load(object sender, EventArgs e)
        {
            pictureBoxPersonaje.ImageLocation = personajeNuevo.imagen;
            textBoxNombre.Text = personajeNuevo.nombre;
            textBoxDescripcion.Text = personajeNuevo.descripcion;
        }


     
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxDescripcion.Text == "")
            {
                MessageBox.Show("Faltan campos por completar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                /* Personaje personaje = new Personaje();
                 personaje.nombre = textBoxNombre.Text;
                 personaje.descripcion = textBoxDescripcion.Text;
                 personaje.imagen = pictureBoxPersonaje.ImageLocation;

                 personajes.Add(personaje);*/
               
                personajeNuevo.nombre = textBoxNombre.Text;
                personajeNuevo.descripcion = textBoxDescripcion.Text;
                personajeNuevo.imagen = pictureBoxPersonaje.ImageLocation;
                personajes.Add(personajeNuevo);
                //CERRAMOS EL FORM
                this.Close();
            }
        }

    }
}
