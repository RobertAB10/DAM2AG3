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

        private void pictureBoxPregunta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPregunta.ImageLocation = openFileDialog.FileName;
                pictureBoxPregunta.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
