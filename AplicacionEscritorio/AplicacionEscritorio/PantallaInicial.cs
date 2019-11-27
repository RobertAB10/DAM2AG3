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
        //Lista
        List<Pregunta> preguntas = new List<Pregunta>();        


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

                // Serializa a JSON la lista de planetas 
                // guarda en el directorio "contingut del joc\planetas\planetas"


                //Especifica la ruta de destino del fichero
                string PreRutaCat = ruta + @"\mNACTEC\preguntas\preguntesCAT.json";
                string PreRutaES = ruta + @"\mNACTEC\preguntas\preguntesES.json";
                string PreRutaEN = ruta + @"\mNACTEC\preguntas\preguntesEN.json";
                string PerRutaCat = ruta + @"\mNACTEC\personajes\personatgesCAT.json";
                string PerRutaES = ruta + @"\mNACTEC\personajes\personatgesES.json";
                string PerRutaEN = ruta + @"\mNACTEC\personajes\personatgesEN.json";


                //Selecciona todo el texto de los ficheros JSON
                string readtextPreCat = File.ReadAllText(@"..\..\Resources\JSON\preguntesCAT.json");
                string readtextPreES = File.ReadAllText(@"..\..\Resources\JSON\preguntesES.json");
                string readtextPreEN = File.ReadAllText(@"..\..\Resources\JSON\preguntesEN.json");
                string readtextPerCat = File.ReadAllText(@"..\..\Resources\JSON\personatgesCAT.json");
                string readtextPerES = File.ReadAllText(@"..\..\Resources\JSON\personatgesES.json");
                string readtextPerEN = File.ReadAllText(@"..\..\Resources\JSON\personatgesEN.json");

                //Copia los JSON a los nuevos ficheros.
                File.WriteAllText(PreRutaCat, readtextPreCat);
                File.WriteAllText(PreRutaES, readtextPreES);
                File.WriteAllText(PreRutaEN, readtextPreEN);
                File.WriteAllText(PerRutaCat, readtextPerCat);
                File.WriteAllText(PerRutaES, readtextPerES);
                File.WriteAllText(PerRutaEN, readtextPerEN);

                DirectoryInfo dir = new DirectoryInfo(@"..\..\Resources\JSON\imagenes\");
                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found:");

                }
                DirectoryInfo[] dirs = dir.GetDirectories();
                Directory.CreateDirectory(ruta + @"\mNACTEC\imagenes");
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(ruta + @"\mNACTEC\imagenes", file.Name);
                    file.CopyTo(temppath, false);
                }





                //Newtonsoft.Json.JsonConvert.SerializeObject(planetas));


                // Serializa a JSON la lista de personajes
                // guarda en el directorio "contingut del joc\personajes"
                //File.WriteAllText(ruta + @"\contingut del joc\personatges\personatges.JSON",
                //    Newtonsoft.Json.JsonConvert.SerializeObject(listaPersonajes));


                // Copia las imagenes a la carpeta de imagenes y las renombra
                //File.Copy(@"..\..\Resources\JSON\preguntesCAT.json", ruta + @"\mNACTEC\preguntas\preguntesCAT.json");

                //System.IO.File.Copy(Personaje.rutaImagen1,
                //        ruta + @"\Contingut del Joc\personatges\imatges\imagen1.png", true);
                //System.IO.File.Copy(Personaje.rutaImagen2,
                //        ruta + @"\Contingut del Joc\personatges\imatges\imagen2.png", true);
                //System.IO.File.Copy(Personaje.rutaImagen3,
                //        ruta + @"\Contingut del Joc\personatges\imatges\imagen3.png", true);


                // Pregunta si esta seguro que- desea cerrar
                var respuesta = MessageBox.Show(
                    "Archivos generados correctamente\n¿Quieres ir al directorio? ",
                    "Hecho",
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
