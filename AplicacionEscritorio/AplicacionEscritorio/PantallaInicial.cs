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
    }
}
