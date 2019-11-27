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
using System.Diagnostics;

namespace AplicacionEscritorio
{
    public partial class PantallaInicial : Form
    {
        
        public PantallaInicial()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void PantallaInicial_Load(object sender, EventArgs e)
        {

        }

        private void buttonNuevaPregunta_Click(object sender, EventArgs e)
        {
            NuevaPregunta nuevaPregunta = new NuevaPregunta();
            nuevaPregunta.ShowDialog();
        }

        private void buttonListaPreguntas_Click(object sender, EventArgs e)
        {
            ListaPreguntas listaPreguntas = new ListaPreguntas();
            listaPreguntas.ShowDialog();
        }

        private void buttonNuevoPersonaje_Click(object sender, EventArgs e)
        {
            NuevoPersonaje nuevoPersonaje = new NuevoPersonaje();
            nuevoPersonaje.ShowDialog();
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            Informacion informacion = new Informacion();
            informacion.Show();
        }

        private void buttonListaPersonajes_Click(object sender, EventArgs e)
        {
            ListaPersonajes listaPersonajes = new ListaPersonajes();
            listaPersonajes.ShowDialog();
        }

        private void pictureBoxEspana_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            // Instancia objeto de la clase FolderBroseDialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // Descripción del cuadro de dialogo
            fbd.Description = "Selecciona donde guardar los ficheros";

            // Guarda la ruta seleccionada por el usuario
            String ruta = "";

            // Cuando el usuario pulse ok
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // Ruta sera la ruta seleccionada
                ruta = fbd.SelectedPath;


                // Crea los directorios y subdirectorios
                //Directory.CreateDirectory(ruta + @"\contingut del joc\planetas");
                //Directory.CreateDirectory(ruta + @"\Contingut del Joc\personatges\imatges");

                Directory.CreateDirectory(ruta + @"\mNACTEC\personajes");
                Directory.CreateDirectory(ruta + @"\mNACTEC\preguntas");
                Directory.CreateDirectory(ruta + @"\mNACTEC\imagenes");

                // Serializa a JSON la lista de planetas 
                // guarda en el directorio "contingut del joc\planetas\planetas"
                File.WriteAllText(ruta + @"\mNACTEC\personajes\personajesCAT.json", @"..\..\Resources\JSON\preguntesCAT.json");

                //Newtonsoft.Json.JsonConvert.SerializeObject(planetas));


                // Serializa a JSON la lista de personajes
                // guarda en el directorio "contingut del joc\personajes"
                //File.WriteAllText(ruta + @"\contingut del joc\personatges\personatges.JSON",
                //    Newtonsoft.Json.JsonConvert.SerializeObject(listaPersonajes));


                // Copia las imagenes a la carpeta de imagenes y las renombra
                File.Copy(@"..\..\Resources\JSON\preguntesCAT.json", ruta + @"\mNACTEC\preguntas\preguntesCAT.json");

                //System.IO.File.Copy(Personaje.rutaImagen1,
                //        ruta + @"\Contingut del Joc\personatges\imatges\imagen1.png", true);
                //System.IO.File.Copy(Personaje.rutaImagen2,
                //        ruta + @"\Contingut del Joc\personatges\imatges\imagen2.png", true);
                //System.IO.File.Copy(Personaje.rutaImagen3,
                //        ruta + @"\Contingut del Joc\personatges\imatges\imagen3.png", true);


                // Pregunta si esta seguro que- desea cerrar
                var respuesta = MessageBox.Show(
                    "Arxius generats correctament\nVols anar al directori? ",
                    "Fet",
                    MessageBoxButtons.YesNo, MessageBoxIcon.None);

                // Si es así, abre la carpeta que contiene los archivos
                if (respuesta == DialogResult.Yes)
                {
                    // Objtiene el directorio actual
                    String directorio = Directory.GetCurrentDirectory();

                    Process.Start(fbd.SelectedPath);
                }

            }
        }
    }
}
