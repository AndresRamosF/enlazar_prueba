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
    public partial class IngresarIE : Form
    {
        public IngresarIE()
        {
            InitializeComponent();
            customizeDesign();
            customizeDesign2();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelMediaSubmenu);
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            showSubmenu2(PanelMediaSubmenu2);
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelMediaSubmenu);
        }


        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            showSubmenu2(PanelMediaSubmenu2);
        }
    }
}
