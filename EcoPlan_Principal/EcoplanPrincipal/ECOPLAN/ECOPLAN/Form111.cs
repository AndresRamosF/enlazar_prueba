using System.Drawing;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ECOPLAN
{
    public partial class MenuPrincipl : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id =root; password = mysql; database = ECOPLAN");
        bool contraseñaVisible = false;
        private void MenuPrincipl_Resize(object sender, EventArgs e)
        {

        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txbCorreo.Text) || string.IsNullOrWhiteSpace(txbPSW.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                conn.Close();
                return;
            }

            string correo = txbCorreo.Text.Trim();
            string contraseña = txbPSW.Text;

            // Consulta segura con parámetros
            string consulta = "SELECT COUNT(*) FROM usuarios WHERE correo = @correo AND contrasena = @contrasena";
            MySqlCommand comando = new MySqlCommand(consulta, conn);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@contrasena", contraseña);

            // Ejecutar y validar
            int count = Convert.ToInt32(comando.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Aquí puedes abrir el siguiente formulario
                DatosBancooo menu = new DatosBancooo();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos");
            }

            conn.Close();

            DatosBancooo datosbanco = new DatosBancooo();
            datosbanco.Show();
            this.Hide();
            datosbanco.FormClosed += (s, args) => this.Close();
        }

        private Point _logoInicial;
        public MenuPrincipl()
        {
            InitializeComponent();
            hola();
        }

        private void NoCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrare registrar = new Registrare();
            registrar.Show();
            this.Hide();
            registrar.FormClosed += (s, args) => this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (this.Width > 1000)
            {
                this.iniciar.Location = new Point(350, 250);
                this.iniciar.Size = new Size(300, 194);
                this.iniciar.Font = new Font("Roboto SemiBold", 22, FontStyle.Bold);
                this.ECOPLAN.Location = new Point(1400, 60);
                this.ECOPLAN.Size = new Size(375, 186);
                /*tbx y otros */
                this.panelTxBxCE.Location = new Point(560, 410);
                this.panelTxBxCE.Size = new Size(800, 30);
                this.txbCorreo.Size = new Size(794, 30);
                this.panelTxBxPSW.Size = new Size(800, 30);
                this.panelTxBxPSW.Location = new Point(560, 470);
                ///Labels
                this.txbPSW.Size = new Size(794, 30);
                this.pws.Location = new Point(560, 445);
                this.label2.Location = new Point(560, 380);
                this.regresar.Location = new Point(1280, 380);
                this.viewpsw.Location = new Point(1300, 445);
            }
            else
            {
                ///Logo y letras de iniciar sesión
                this.iniciar.Location = new Point(75, 75);
                this.iniciar.Size = new Size(220, 34);
                this.iniciar.Font = new Font("Roboto SemiBold", 16, FontStyle.Bold);
                this.ECOPLAN.Location = new Point(715, 56);
                this.ECOPLAN.Size = new Size(125, 62);
                ///texbox y labels de inicio de sesión
                this.panelTxBxCE.Location = new Point(167, 154);
                this.panelTxBxCE.Size = new Size(629, 30);
                this.txbPSW.Size = new Size(624, 30);
                this.txbCorreo.Size = new Size(624, 27);
                this.label2.Location = new Point(171, 133);
                this.pws.Location = new Point(171, 205);
                this.regresar.Location = new Point(727, 133);
                this.panelTxBxPSW.Size = new Size(629, 30);
                this.panelTxBxPSW.Location = new Point(167, 225);
                this.viewpsw.Location = new Point(743, 203);
            }

        }
        private void hola()
        {


        }

        private void iniciar_Click(object sender, EventArgs e)
        {

        }

        private void viewpsw_Click(object sender, EventArgs e)
        {
            contraseñaVisible = !contraseñaVisible;

            if (contraseñaVisible)
            {
                // Mostrar contraseña
                txbPSW.PasswordChar = '\0';  // sin ocultar
                viewpsw.Image = Image.FromFile("C:\\Users\\cadac\\Downloads\\eye.png");
                // cambia a imagen de ojo abierto
            }
            else
            {
                // Ocultar contraseña
                txbPSW.PasswordChar = '•';
                viewpsw.Image = Image.FromFile("\\Users\\cadac\\Downloads\\eye-off.png"); // cambia a imagen de ojo cerrado
            }

        }

    }
}
