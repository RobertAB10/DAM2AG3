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
    }
}
