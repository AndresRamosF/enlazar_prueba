using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOPLAN
{
    public partial class MenuP : Form
    {

        public MenuP()
        {
            InitializeComponent();
        }

        private void panelFill_Paint(object sender, PaintEventArgs e)
        {
            int ancho = this.Width;
            int alto = this.Height;
            if (this.WindowState == FormWindowState.Maximized)
            {
                
                this.Peconomiza.Size = new Size(
                (int)(ancho * 0.722),   // 40% del ancho de la ventana
                (int)(alto * 0.305)     // 20% del alto de la ventana
                );
                this.panel1.Size = new Size(
                (int)(ancho * 0.720),   // 40% del ancho de la ventana
                (int)(alto * 0.300)     // 20% del alto de la ventana
                );
                panel1.Left = (Peconomiza.Width - panel1.Width) / 2;
                panel1.Top = (Peconomiza.Height - panel1.Height) / 2;
                Peconomiza.Left = (panelFill.Width - Peconomiza.Width) / 2;
                



            }
            else if (this.Width < 1000)
            {
                this.Peconomiza.Size = new Size(
                (int)(ancho * 0.906),   
                (int)(alto * 0.192)     
                );

                this.panel1.Size = new Size(
                    (int)(ancho * 0.901),   
                    (int)(alto * 0.188)     
                );
                Peconomiza.Left = (panelFill.Width - Peconomiza.Width) / 2;
            }
        }
    }
}
