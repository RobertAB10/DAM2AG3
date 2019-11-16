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
    public partial class ListaPersonajes : Form
    {

        List<Personaje> personajes = new List<Personaje>();

        public ListaPersonajes()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void ListaPersonajes_Load(object sender, EventArgs e)
        {
            comboBoxIdiomes.Items.AddRange(Constants.Idiomes);
        }

        private void refrescar()
        {
            dataGridViewPersonajes.DataSource = null;
            dataGridViewPersonajes.DataSource = personajes;
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
                MessageBox.Show("No existe fichero con personajes del idioma seleccionado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewPersonajes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow personaje in dataGridViewPersonajes.SelectedRows)
                {
                    personajes.Remove((Personaje)personaje.DataBoundItem);
                }
                refrescar();
                guardarFichero();
                
            }
            else
            {
                MessageBox.Show("Error, ningún personaje seleccionado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
