using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Banka banka;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banka = new Banka("Petr Jirák", 5800, "68420/69" );
            labelJmeno.Text = banka.jmeno;
            labelCisloUctu.Text = banka.cisloUctu.ToString();
            labelAktualni.Text = banka.aktualniZustatek.ToString();

            groupBox2.Visible = false;
            buttonZmena2.Visible = false;
        }

        private void buttonVlozit_Click(object sender, EventArgs e)
        {
            float vklad = float.Parse(textBoxHodnota.Text);
            banka.Vklad(vklad);
            labelAktualni.Text = banka.aktualniZustatek.ToString();
        }

        private void buttonVybrat_Click(object sender, EventArgs e)
        {
            float vyber = float.Parse(textBoxHodnota.Text);
            banka.Vyber(vyber);
            labelAktualni.Text = banka.aktualniZustatek.ToString();
        }

        private void buttonZmena_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            buttonZmena.Visible = false;
            buttonZmena2.Visible = true;
        }

        private void buttonZmenaTyden_Click(object sender, EventArgs e)
        {
            int navyseni = int.Parse(textBoxTydenniLimit.Text);
            banka.Navyseni(navyseni);
        }

        private void buttonZmena2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            buttonZmena.Visible = true;
            buttonZmena2.Visible = false;
        }

        private void buttonVypis_Click(object sender, EventArgs e)
        {
            banka.Vypis();
        }

        private void buttonPlatit_Click(object sender, EventArgs e)
        {
            float platba = float.Parse(textBoxPlatba.Text);
            string cisloUctu = textBoxPlatbaCisloUctu.Text;
            banka.Platba(platba,cisloUctu);
            labelAktualni.Text = banka.aktualniZustatek.ToString();
        }

        private void buttonZmenaPlatba_Click(object sender, EventArgs e)
        {
            int navyseni = int.Parse(textBoxPlatebniLimit.Text);
            banka.NavyseniPlatby(navyseni);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                banka.kontokorent = true;
            }
            if (checkBox1.Checked == false)
            {
                banka.kontokorent = false;
            }
        }
    }
}
