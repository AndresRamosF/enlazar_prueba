using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace ECOPLAN
{
    public partial class Registrare : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id =root; password = mysql; database = ECOPLAN");
        public Registrare()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            if (this.Width > 1000)
            {
                ///this.panelTxBxCE.
            }
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            /*Base de datos de ecoplan*/
            conn.Open();
            string consulta = "INSERT INTO usuarios (nombre, correo, contrasena) VALUES (@nombre, @correo, @contrasena)";
            MySqlCommand comando = new MySqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("@nombre", txbUser.Text);
            comando.Parameters.AddWithValue("@correo", txbcrro.Text);
            comando.Parameters.AddWithValue("@contrasena", tbxPSW.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Usuario registrado con éxito");
            conn.Close();
            ///Hola
            DatosBancooo db = new DatosBancooo();
            db.Show();
            this.Hide();
            db.FormClosed += (s, args) => this.Close();

        }

        private void txbCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
