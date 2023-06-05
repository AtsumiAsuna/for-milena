using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkpoint1_Click_1(object sender, EventArgs e)
        {
            header.Text = "МЦК Лужники";
            pictureToilets.Visible = false;
            pictureMedical.Visible = false;
            pictureInformation.Visible = false;
            pictureEnergyBars.Visible = true;
            pictureDrinks.Visible = true;
            Toilets.Visible = false;
            Medical.Visible = false;
            Information.Visible = false;
            EnergyBars.Visible = true;
            Drinks.Visible = true;
        }

        private void checkpoint6_Click(object sender, EventArgs e)
        {
            header.Text = "Здания РАН";
            pictureToilets.Visible = true;
            pictureMedical.Visible = false;
            pictureInformation.Visible = false;
            pictureEnergyBars.Visible = true;
            pictureDrinks.Visible = true;
            Toilets.Visible = true;
            Medical.Visible = false;
            Information.Visible = false;
            EnergyBars.Visible = true;
            Drinks.Visible = true;

        }

        private void checkpoint2_Click(object sender, EventArgs e)
        {
            header.Text = "Новодевичей монастырь";
            pictureToilets.Visible = true;
            pictureMedical.Visible = true;
            pictureInformation.Visible = true;
            pictureEnergyBars.Visible = true;
            pictureDrinks.Visible = true;
            Toilets.Visible = true;
            Medical.Visible = true;
            Information.Visible = true;
            EnergyBars.Visible = true;
            Drinks.Visible = true;
        }

        private void checkpoint3_Click(object sender, EventArgs e)
        {

            header.Text = "Метро Киевская";
            pictureToilets.Visible = true;
            pictureMedical.Visible = false;
            pictureInformation.Visible = false;
            pictureEnergyBars.Visible = true;
            pictureDrinks.Visible = true;
            Toilets.Visible = true;
            Medical.Visible = false;
            Information.Visible = false;
            EnergyBars.Visible = true;
            Drinks.Visible = true;
        }

        private void checkpoint4_Click(object sender, EventArgs e)
        {
            header.Text = "МИД";
            pictureToilets.Visible = true;
            pictureMedical.Visible = true;
            pictureInformation.Visible = false;
            pictureEnergyBars.Visible = true;
            pictureDrinks.Visible = true;
            Toilets.Visible = true;
            Medical.Visible = true;
            Information.Visible = false;
            EnergyBars.Visible = true;
            Drinks.Visible = true;
        }

        private void checkpoint5_Click(object sender, EventArgs e)
        {
            header.Text = "Парк Горького";
            pictureToilets.Visible = true;
            pictureMedical.Visible = false;
            pictureInformation.Visible = true;
            pictureEnergyBars.Visible = true;
            pictureDrinks.Visible = true;
            Toilets.Visible = true;
            Medical.Visible = false;
            Information.Visible = true;
            EnergyBars.Visible = true;
            Drinks.Visible = true;

            pictureInformation.Location = new Point(688, 459);
            Information.Location = new Point(862, 495);
        }

        private void checkpoint7_Click(object sender, EventArgs e)
        {
            header.Text = "Метро Воробевы горы";
            pictureToilets.Visible = true;
            pictureMedical.Visible = true;
            pictureInformation.Visible = true;
            pictureEnergyBars.Visible = true;
            pictureDrinks.Visible = true;
            Toilets.Visible = true;
            Medical.Visible = true;
            Information.Visible = true;
            EnergyBars.Visible = true;
            Drinks.Visible = true;


            pictureInformation.Location = new Point(688, 580);
            Information.Location = new Point(862, 611);
        }

        private void checkpoint8_Click(object sender, EventArgs e)
        {
            header.Text = "Стадион Лужники";
            pictureToilets.Visible = true;
            pictureMedical.Visible = true;
            pictureInformation.Visible = true;
            pictureEnergyBars.Visible = true;
            pictureDrinks.Visible = true;
            Toilets.Visible = true;
            Medical.Visible = true;
            Information.Visible = true;
            EnergyBars.Visible = true;
            Drinks.Visible = true;

            pictureInformation.Location = new Point(688, 580);
            Information.Location = new Point(862, 611);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            header.Text = "Начало забега\n\nПолный самбо марофон";
            pictureToilets.Visible = false;
            pictureMedical.Visible = false;
            pictureInformation.Visible = false;
            pictureEnergyBars.Visible = false;
            pictureDrinks.Visible = false;
            Toilets.Visible = false;
            Medical.Visible = false;
            Information.Visible = false;
            EnergyBars.Visible = false;
            Drinks.Visible = false;
        }

        private void start2_Click(object sender, EventArgs e)
        {
            header.Text = "Начало забега\n\nКапоера 5км веселый забег";
            pictureToilets.Visible = false;
            pictureMedical.Visible = false;
            pictureInformation.Visible = false;
            pictureEnergyBars.Visible = false;
            pictureDrinks.Visible = false;
            Toilets.Visible = false;
            Medical.Visible = false;
            Information.Visible = false;
            EnergyBars.Visible = false;
            Drinks.Visible = false;
        }

        private void start3_Click(object sender, EventArgs e)
        {
            header.Text = "Начало забега\n\nДжонго половина забега";
            pictureToilets.Visible = false;
            pictureMedical.Visible = false;
            pictureInformation.Visible = false;
            pictureEnergyBars.Visible = false;
            pictureDrinks.Visible = false;
            Toilets.Visible = false;
            Medical.Visible = false;
            Information.Visible = false;
            EnergyBars.Visible = false;
            Drinks.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
