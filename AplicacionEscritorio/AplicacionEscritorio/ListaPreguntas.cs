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
    public partial class ListaPreguntas : Form
    {

        List<Pregunta> preguntas = new List<Pregunta>();

        public ListaPreguntas()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void ListaPreguntas_Load(object sender, EventArgs e)
        {
            comboBoxIdiomes.Items.AddRange(Constants.Idiomes);
        }

        private void refrescar()
        {
            dataGridViewPreguntas.DataSource = null;
            dataGridViewPreguntas.DataSource = preguntas;
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
                MessageBox.Show("No existe fichero con preguntas del idioma seleccionado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxIdiomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ruta = rutaIdioma();

            String Idioma = comboBoxIdiomes.Text;

            switch (Idioma)
            {
                case "Català":
                    comprobarFichero(ruta);
                    refrescar();
                    break;

                case "Castellano":
                    comprobarFichero(ruta);
                    refrescar();
                    break;

                case "English":
                    comprobarFichero(ruta);
                    refrescar();
                    break;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxIdiomes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String ruta = rutaIdioma();

            String Idioma = comboBoxIdiomes.Text;

            switch (Idioma)
            {
                case "Català":
                    comprobarFichero(ruta);
                    refrescar();
                    break;

                case "Castellano":
                    comprobarFichero(ruta);
                    refrescar();
                    break;

                case "English":
                    comprobarFichero(ruta);
                    refrescar();
                    break;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPreguntas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow pregunta in dataGridViewPreguntas.SelectedRows)
                {
                    preguntas.Remove((Pregunta)pregunta.DataBoundItem);
                }
                refrescar();
                guardarFichero();

            }
            else
            {
                MessageBox.Show("Error, ninguna pregunta seleccionada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPreguntas.SelectedRows.Count > 0)
            {
                Pregunta pregunta = (Pregunta)dataGridViewPreguntas.SelectedRows[0].DataBoundItem;

                preguntas.Remove(pregunta);

                Modificar_Pregunta modificar_Pregunta = new Modificar_Pregunta(preguntas, pregunta);
                modificar_Pregunta.ShowDialog();
                preguntas.Add(pregunta);
                refrescar();

            }
            else
            {
                MessageBox.Show("Error, ninguna pregunta seleccionada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            guardarFichero();
        }

        private void dataGridViewPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
