using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AplicacionEscritorio
{
    public partial class PantallaInicial : Form
    {
        List<Pregunta> preguntas = new List<Pregunta>();
        string rutaCatala = @"..\..\Resources\JSON\preguntesCAT.json";
        string rutaCastella = @"..\..\Resources\JSON\preguntesES.json";
        string rutaAngles = @"..\..\Resources\JSON\preguntesEN.json";

        public PantallaInicial()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void PantallaInicial_Load(object sender, EventArgs e)
        {
            comboBoxIdiomes.Items.AddRange(Constants.Idiomes);
            comboBoxIdiomes.SelectedIndex = 0;
            pictureBoxIdioma.Image = Properties.Resources.Catalana;

            //JSON
            if (System.IO.File.Exists(rutaCatala)) {
                //MessageBox.Show("El fichero existe");
                JArray jArrayPeliculas = JArray.Parse(File.ReadAllText(rutaCatala));
                preguntas = jArrayPeliculas.ToObject<List<Pregunta>>();
            }
            else {
                StreamWriter fichero = File.CreateText(rutaCatala);
                //MessageBox.Show("Fichero creado");
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
    }
}
