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
    public partial class NuevaPregunta : Form
    {
        List<Pregunta> preguntas = new List<Pregunta>();
       
        public NuevaPregunta()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void NuevaPregunta_Load(object sender, EventArgs e)
        {
            comboBoxIdiomes.Items.AddRange(Constants.Idiomes);
            comboBoxNivel.Items.AddRange(Constants.Nivells);
        }

        private string rutaIdioma(object sender, EventArgs e)
        {
            string ruta = "";
            String Idioma = comboBoxIdiomes.Text;
            switch (Idioma)
            {
                case "Català":
                    ruta = @"..\..\Resources\JSON\preguntesCAT.json";
                    break;

                case "Castellano":
                    ruta = @"..\..\Resources\JSON\preguntesES.json";
                    break;

                case "English":
                    ruta = @"..\..\Resources\JSON\preguntesEN.json";
                    break;
            }
            return ruta;
        }

        private void pictureBoxPregunta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPregunta.ImageLocation = openFileDialog.FileName;
                pictureBoxPregunta.BackgroundImageLayout = ImageLayout.Stretch;
            }
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

        private void buttonCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirma_Click(object sender, EventArgs e)
        {
            if (textBoxPregunta.Text == "" || comboBoxNivel.Text == "" || comboBoxTema.Text == "") {
                MessageBox.Show("Faltan campos por completar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Pregunta pregunta = new Pregunta();
                pregunta.pregunta = textBoxPregunta.Text;
                pregunta.imagen = pictureBoxPregunta.ImageLocation;
                pregunta.nivell = comboBoxNivel.Text;
                pregunta.respuestas = new List<Respuesta>();

                //Por acabar
                //

                //Cargamos el JSON del idioma
                string ruta = rutaIdioma(sender, e);
                if (System.IO.File.Exists(ruta))
                {
                    //MessageBox.Show("El fichero existe");
                    JArray jArrayPeliculas = JArray.Parse(File.ReadAllText(ruta));
                    preguntas = jArrayPeliculas.ToObject<List<Pregunta>>();
                }
                else
                {
                    //MessageBox.Show("Fichero creado");
                    StreamWriter fichero = File.CreateText(ruta);
                }
            }

        }

        private void NuevaPregunta_FormClosing(object sender, FormClosingEventArgs e)
        {
            //guardarFichero();
        }
    }
}