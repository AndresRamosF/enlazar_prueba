using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUATRI3
{
    public partial class MiCuenta : Form
    {
        public MiCuenta()
        {
            InitializeComponent();
            customizeDesign();
            customizeDesign2();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void customizeDesign()
        {
            PanelMediaSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (PanelMediaSubmenu.Visible == true)
                PanelMediaSubmenu.Visible = false;
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //SUBMENU2
        private void customizeDesign2()
        {
            PanelMediaSubmenu2.Visible = false;
        }
        private void hideSubmenu2()
        {
            if (PanelMediaSubmenu2.Visible == true)
                PanelMediaSubmenu2.Visible = false;
        }
        private void showSubmenu2(Panel submenu2)
        {
            if (submenu2.Visible == false)
            {
                hideSubmenu();
                submenu2.Visible = true;
            }
            else
            {
                submenu2.Visible = false;
            }
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            MiCuenta micuenta = new MiCuenta();
            micuenta.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            MisAhorros misahorros = new MisAhorros();
            misahorros.Show();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            CrearAhorro crearahorro = new CrearAhorro();
            crearahorro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarIE ingresarie = new IngresarIE();
            ingresarie.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MisAhorros misahorros = new MisAhorros();
            misahorros.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelMediaSubmenu);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelMediaSubmenu2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearAhorro crearahorro = new CrearAhorro();
            crearahorro.Show();
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            CrearAhorro crearahorro = new CrearAhorro();
            crearahorro.Show();
        }
    }
}
