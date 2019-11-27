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
    public partial class NuevoPersonaje : Form
    {

        List<Personaje> personajes = new List<Personaje>();

        public NuevoPersonaje()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void pictureBoxPersonaje_Click(object sender, EventArgs e)
        {
            string rutaImagenes = @"..\..\Resources\JSON\imagenes\";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pictureBoxPregunta.ImageLocation = openFileDialog.FileName;
                //pictureBoxPregunta.BackgroundImageLayout = ImageLayout.Stretch;
                if (pictureBoxPersonaje.ImageLocation == null)
                {
                    if (openFileDialog.FileName.EndsWith(".png"))
                    {
                        rutaImagenes += "imagen" + DateTime.Now.Ticks.ToString() + ".png";
                    }
                    else if (openFileDialog.FileName.EndsWith(".jpg"))
                    {
                        rutaImagenes += "imagen" + DateTime.Now.Ticks.ToString() + ".jpg";
                    }
                    else if (openFileDialog.FileName.EndsWith(".jpeg"))
                    {
                        rutaImagenes += "imagen" + DateTime.Now.Ticks.ToString() + ".jpeg";
                    }
                          

                    File.Copy(openFileDialog.FileName, rutaImagenes);
                    pictureBoxPersonaje.ImageLocation = rutaImagenes;

                }

                else {
                    File.Delete(pictureBoxPersonaje.ImageLocation);

                    if (openFileDialog.FileName.EndsWith(".png"))
                    {
                        rutaImagenes += "imagen" + DateTime.Now.Ticks.ToString() + ".png";
                    }
                    else if (openFileDialog.FileName.EndsWith(".jpg"))
                    {
                        rutaImagenes += "imagen" + DateTime.Now.Ticks.ToString() + ".jpg";
                    }
                    else if (openFileDialog.FileName.EndsWith(".jpeg"))
                    {
                        rutaImagenes += "imagen" + DateTime.Now.Ticks.ToString() + ".jpeg";
                    }
                    File.Copy(openFileDialog.FileName, rutaImagenes);
                    pictureBoxPersonaje.ImageLocation = rutaImagenes;

                }
                // rutaDefinitiva = rutaImagenes.Substring(16);
            }
        }

        private void NuevoPersonaje_Load(object sender, EventArgs e)
        {
            comboBoxIdiomes.Items.AddRange(Constants.Idiomes);

        }

        private void guardarFichero()
        {
            string ruta = rutaIdioma();
            JArray jArrayPersonajes = (JArray)JToken.FromObject(personajes);

            StreamWriter fichero = File.CreateText(ruta);
            JsonTextWriter jsonwriter = new JsonTextWriter(fichero);

            jArrayPersonajes.WriteTo(jsonwriter);

            jsonwriter.Close();

            MessageBox.Show("Guardado correcamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private string rutaIdioma()
        {
            string ruta = "";
            String Idioma = comboBoxIdiomes.Text;
            switch (Idioma)
            {
                case "Català":
                    ruta = @"..\..\Resources\JSON\personatgesCAT.json";
                    break;

                case "Castellano":
                    ruta = @"..\..\Resources\JSON\personatgesES.json";
                    break;

                case "English":
                    ruta = @"..\..\Resources\JSON\personatgesEN.json";
                    break;
            }
            return ruta;
        }

        private void comprobarFichero(String ruta)
        {
            //VACIAMOS LA LISTA
            personajes.Clear();

            if (System.IO.File.Exists(ruta))
            {
                //MessageBox.Show("El fichero existe");
                JArray jArrayPersonajes = JArray.Parse(File.ReadAllText(ruta));
                personajes = jArrayPersonajes.ToObject<List<Personaje>>();
            }
            else
            {
                //MessageBox.Show("Fichero creado");
                StreamWriter fichero = File.CreateText(ruta);
                fichero.Close();
            }

        }

        private void comboBoxIdiomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ruta = rutaIdioma();

            String Idioma = comboBoxIdiomes.Text;

            switch (Idioma)
            {
                case "Català":
                    pictureBoxIdioma.Image = Properties.Resources.Catalana;
                    pictureBoxIdioma.Refresh();
                    pictureBoxIdioma.Visible = true;

                    break;

                case "Castellano":
                    pictureBoxIdioma.Image = Properties.Resources.Espana;
                    pictureBoxIdioma.Refresh();
                    pictureBoxIdioma.Visible = true;

                    break;

                case "English":
                    pictureBoxIdioma.Image = Properties.Resources.English;
                    pictureBoxIdioma.Refresh();
                    pictureBoxIdioma.Visible = true;

                    break;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxDescripcion.Text == "" || comboBoxIdiomes.SelectedIndex < 0)
            {
                MessageBox.Show("Faltan campos por completar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string ruta = rutaIdioma();
                comprobarFichero(ruta);

                Personaje personaje = new Personaje();
                personaje.nombre = textBoxNombre.Text;
                personaje.descripcion = textBoxDescripcion.Text;
                personaje.imagen = pictureBoxPersonaje.ImageLocation;

                personajes.Add(personaje);

                //LLAMAMOS A LA FUNCION DE GUARDAR
                guardarFichero();

                //CERRAMOS EL FORM
                this.Close();
            }
        }

    }
}
