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
            comboBoxTema.Items.AddRange(Constants.Temas);
        }

        private string rutaIdioma()
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

        private void comprobarFichero(String ruta)
        {
            //VACIAMOS LA LISTA
            preguntas.Clear();

            if (System.IO.File.Exists(ruta))
            {
                //MessageBox.Show("El fichero existe");
                JArray jArrayPreguntas = JArray.Parse(File.ReadAllText(ruta));
                preguntas = jArrayPreguntas.ToObject<List<Pregunta>>();
            }
            else
            {
                //MessageBox.Show("Fichero creado");
                StreamWriter fichero = File.CreateText(ruta);
                fichero.Close();
            }

        }


        private void guardarFichero()
        {
            string ruta = rutaIdioma();
            JArray jArrayPreguntas = (JArray)JToken.FromObject(preguntas);

            StreamWriter fichero = File.CreateText(ruta);
            JsonTextWriter jsonwriter = new JsonTextWriter(fichero);

            jArrayPreguntas.WriteTo(jsonwriter);

            jsonwriter.Close();

            MessageBox.Show("Guardado correcamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

            if (textBoxPregunta.Text == "" || comboBoxNivel.Text == "" || comboBoxTema.Text == "" || comboBoxIdiomes.SelectedIndex < 0)
            {
                MessageBox.Show("Faltan campos por completar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                String ruta = rutaIdioma();
                comprobarFichero(ruta);

                Pregunta pregunta = new Pregunta();
                pregunta.pregunta = textBoxPregunta.Text;
                pregunta.imagen = pictureBoxPregunta.ImageLocation;
                pregunta.nivel = comboBoxNivel.Text;
                pregunta.tema = comboBoxTema.Text;
                pregunta.respuestas = new List<Respuesta>();

                //PREGUNTAR A FRANCISCO
                if (textBoxRespuesta1.Text != "")
                {
                    Respuesta respuesta = new Respuesta();
                    respuesta.respuesta = textBoxRespuesta1.Text;
                    if (radioButtonRespuesta1.Checked == true)
                    {
                        respuesta.correcte = true;
                    }
                    else
                    {
                        respuesta.correcte = false;
                    }

                    pregunta.respuestas.Add(respuesta);
                }

                if (textBoxRespuesta2.Text != "")
                {
                    Respuesta respuesta = new Respuesta();
                    respuesta.respuesta = textBoxRespuesta2.Text;
                    if (radioButtonRespuesta2.Checked == true)
                    {
                        respuesta.correcte = true;
                    }
                    else
                    {
                        respuesta.correcte = false;
                    }

                    pregunta.respuestas.Add(respuesta);
                }

                if (textBoxRespuesta3.Text != "")
                {
                    Respuesta respuesta = new Respuesta();
                    respuesta.respuesta = textBoxRespuesta3.Text;
                    if (radioButtonRespuesta3.Checked == true)
                    {
                        respuesta.correcte = true;
                    }
                    else
                    {
                        respuesta.correcte = false;
                    }

                    pregunta.respuestas.Add(respuesta);

                }

                if (textBoxRespuesta4.Text != "")
                {
                    Respuesta respuesta = new Respuesta();
                    respuesta.respuesta = textBoxRespuesta4.Text;
                    if (radioButtonRespuesta4.Checked == true)
                    {
                        respuesta.correcte = true;
                    }
                    else
                    {
                        respuesta.correcte = false;
                    }

                    pregunta.respuestas.Add(respuesta);

                }

                preguntas.Add(pregunta);

                //LLAMAMOS A LA FUNCION DE GUARDAR
                guardarFichero();
                //CERRAMOS EL FORM
                this.Close();

            }

        }

    }
}