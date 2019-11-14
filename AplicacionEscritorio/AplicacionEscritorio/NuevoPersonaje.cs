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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPersonaje.ImageLocation = openFileDialog.FileName;
                pictureBoxPersonaje.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void NuevoPersonaje_Load(object sender, EventArgs e)
        {
            comboBoxIdiomes.Items.AddRange(Constants.Idiomes);
            comboBoxIdiomes.SelectedIndex = 0;
        }

        private string rutaIdioma(object sender, EventArgs e)
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

        private void comboBoxIdiomes_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if (textBoxNombre.Text == "" || textBoxDescripcion.Text == "")
            {
                MessageBox.Show("Faltan campos por completar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Personaje personaje = new Personaje();
                personaje.nombre = textBoxNombre.Text;
                personaje.descripcion = textBoxDescripcion.Text;
                personaje.imagen = pictureBoxPersonaje.ImageLocation;

                personajes.Add(personaje);

                string ruta = rutaIdioma(sender, e);
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
                }
            }
        }
    }
}
