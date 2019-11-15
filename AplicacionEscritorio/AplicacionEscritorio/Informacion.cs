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
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            comboBoxIdiomes.Items.AddRange(Constants.Idiomes);
            comboBoxIdiomes.SelectedIndex = 0;
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
