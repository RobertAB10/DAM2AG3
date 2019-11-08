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
        public Modificar_Pregunta()
        {
            InitializeComponent();
        }

        private void labelNuevaModificarPregunta_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Pregunta_Load(object sender, EventArgs e)
        {
            comboBoxIdiomes.Items.AddRange(Constants.Idiomes);
            comboBoxNivel.Items.AddRange(Constants.Nivells);
        }

        private void comboBoxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxIdiomes_SelectedIndexChanged(object sender, EventArgs e)
        {

            String Idioma = comboBoxIdiomes.SelectedText; 
            switch (Idioma)
            {
                case "Català":
                    pictureBoxIdioma.Image = Image.FromFile("./Resources/catala.png");
                    break;
            }
        }
    }
}
