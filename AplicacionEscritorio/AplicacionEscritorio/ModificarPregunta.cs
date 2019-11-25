using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEscritorio
{
    public partial class Modificar_Pregunta : Form
    {

        List<Pregunta> preguntas = new List<Pregunta>();
        Pregunta preguntaNueva = new Pregunta();

        public Modificar_Pregunta(List<Pregunta> preguntas, Pregunta pregunta)
        {
            preguntaNueva = pregunta;
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void labelNuevaModificarPregunta_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Pregunta_Load(object sender, EventArgs e)
        {
            comboBoxNivel.Items.AddRange(Constants.Nivells);
            comboBoxTema.Items.AddRange(Constants.Temas);
            textBoxPregunta.Text = preguntaNueva.pregunta;
            pictureBoxPregunta.ImageLocation = preguntaNueva.imagen;
            comboBoxTema.SelectedItem = preguntaNueva.tema;
            comboBoxNivel.SelectedItem = preguntaNueva.nivel;
            textBoxRespuesta1.Text = preguntaNueva.respuestas[0].respuesta.ToString();
            if (preguntaNueva.respuestas[0].correcte == true)
            {
                radioButtonRespuesta1.Checked = true;
            }
            textBoxRespuesta2.Text = preguntaNueva.respuestas[1].respuesta.ToString();
            if (preguntaNueva.respuestas[1].correcte == true)
            {
                radioButtonRespuesta2.Checked = true;
            }
            textBoxRespuesta3.Text = preguntaNueva.respuestas[2].respuesta.ToString();
            if (preguntaNueva.respuestas[2].correcte == true)
            {
                radioButtonRespuesta3.Checked = true;
            }
            textBoxRespuesta4.Text = preguntaNueva.respuestas[3].respuesta.ToString();
            if (preguntaNueva.respuestas[3].correcte == true)
            {
                radioButtonRespuesta4.Checked = true;
            }



        }

        private void comboBoxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /*private void comboBoxIdiomes_SelectedIndexChanged(object sender, EventArgs e)
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

        }*/

        private void pictureBoxPregunta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPregunta.ImageLocation = openFileDialog.FileName;
                pictureBoxPregunta.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonConfirmar_Click_1(object sender, EventArgs e)
        {
            if (textBoxPregunta.Text == "" || comboBoxNivel.Text == "" || comboBoxTema.Text == "" || textBoxRespuesta1.Text == "" || textBoxRespuesta2.Text == "" || textBoxRespuesta3.Text == "" || textBoxRespuesta4.Text == "")
            {
                MessageBox.Show("Faltan campos por completar", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                preguntaNueva.pregunta = textBoxPregunta.Text;
                preguntaNueva.imagen = pictureBoxPregunta.ImageLocation;
                preguntaNueva.nivel = comboBoxNivel.Text;
                preguntaNueva.tema = comboBoxTema.Text;
                preguntaNueva.respuestas = new List<Respuesta>();

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

                    preguntaNueva.respuestas.Add(respuesta);
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

                    preguntaNueva.respuestas.Add(respuesta);
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

                    preguntaNueva.respuestas.Add(respuesta);

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

                    preguntaNueva.respuestas.Add(respuesta);

                }

                preguntas.Add(preguntaNueva);

                //LLAMAMOS A LA FUNCION DE GUARDAR

                //CERRAMOS EL FORM
                this.Close();
            }
        }
    }

}
