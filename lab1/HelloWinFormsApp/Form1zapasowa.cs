using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            labelKamunikat1.Text = "Witaj " + textBoxImie.Text + " " + textBoxNazwisko.Text;

            int wiek = Convert.ToInt32(textBoxWiek.Text);
            if (wiek < 67)
            {
                labelKomunikat2.Text = string.Format("do emerytury zostalo ci {0} lat", 67 - wiek);
            }
            else
            {
                labelKomunikat2.Text = "jestes emerytem!";
            }
        }
    }
}
