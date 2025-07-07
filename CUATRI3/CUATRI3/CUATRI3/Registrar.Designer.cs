namespace ECOPLAN
{
    partial class Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            regresar = new LinkLabel();
            NoCuenta = new LinkLabel();
            panelECOPLAN = new Panel();
            pictureBox1 = new PictureBox();
            btnSesion = new Button();
            label3 = new Label();
            panelTxBxPSW = new Panel();
            txbCPSW = new TextBox();
            panelTxBxCE = new Panel();
            txbUser = new TextBox();
            Registrate = new Label();
            label1 = new Label();
            panel1 = new Panel();
            tbxPSW = new TextBox();
            usrnm = new Label();
            crro = new Label();
            panel2 = new Panel();
            txbcrro = new TextBox();
            panelECOPLAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTxBxPSW.SuspendLayout();
            panelTxBxCE.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // regresar
            // 
            regresar.ActiveLinkColor = Color.FromArgb(48, 91, 171);
            regresar.Anchor = AnchorStyles.None;
            regresar.AutoSize = true;
            regresar.Font = new Font("Roboto SemiCondensed", 9F);
            regresar.LinkColor = Color.FromArgb(48, 91, 171);
            regresar.Location = new Point(723, 117);
            regresar.Name = "regresar";
            regresar.Size = new Size(66, 18);
            regresar.TabIndex = 20;
            regresar.TabStop = true;
            regresar.Text = "Regresar";
            // 
            // NoCuenta
            // 
            NoCuenta.ActiveLinkColor = Color.FromArgb(48, 91, 171);
            NoCuenta.Anchor = AnchorStyles.None;
            NoCuenta.AutoSize = true;
            NoCuenta.Font = new Font("Roboto SemiCondensed", 9F);
            NoCuenta.LinkColor = Color.FromArgb(48, 91, 171);
            NoCuenta.Location = new Point(632, 353);
            NoCuenta.Name = "NoCuenta";
            NoCuenta.Size = new Size(157, 18);
            NoCuenta.TabIndex = 19;
            NoCuenta.TabStop = true;
            NoCuenta.Text = "¿Ya tienes una cuenta?";
            // 
            // panelECOPLAN
            // 
            panelECOPLAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelECOPLAN.BackColor = Color.FromArgb(48, 63, 159);
            panelECOPLAN.Controls.Add(pictureBox1);
            panelECOPLAN.Location = new Point(694, 23);
            panelECOPLAN.Name = "panelECOPLAN";
            panelECOPLAN.Size = new Size(202, 85);
            panelECOPLAN.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSesion
            // 
            btnSesion.Anchor = AnchorStyles.Bottom;
            btnSesion.BackColor = Color.FromArgb(48, 63, 159);
            btnSesion.FlatStyle = FlatStyle.Flat;
            btnSesion.Font = new Font("Roboto SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSesion.ForeColor = Color.White;
            btnSesion.Location = new Point(409, 390);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(147, 29);
            btnSesion.TabIndex = 16;
            btnSesion.Text = "Siguiente";
            btnSesion.UseVisualStyleBackColor = false;
            btnSesion.Click += btnSesion_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Roboto SemiCondensed", 9F);
            label3.Location = new Point(166, 294);
            label3.Name = "label3";
            label3.Size = new Size(159, 18);
            label3.TabIndex = 15;
            label3.Text = "Confirma tu contraseña";
            // 
            // panelTxBxPSW
            // 
            panelTxBxPSW.Anchor = AnchorStyles.None;
            panelTxBxPSW.BackColor = Color.FromArgb(101, 157, 242);
            panelTxBxPSW.Controls.Add(txbCPSW);
            panelTxBxPSW.Location = new Point(166, 319);
            panelTxBxPSW.Name = "panelTxBxPSW";
            panelTxBxPSW.Size = new Size(629, 31);
            panelTxBxPSW.TabIndex = 14;
            // 
            // txbCPSW
            // 
            txbCPSW.BackColor = Color.White;
            txbCPSW.Location = new Point(3, 2);
            txbCPSW.Name = "txbCPSW";
            txbCPSW.PasswordChar = '•';
            txbCPSW.Size = new Size(624, 27);
            txbCPSW.TabIndex = 2;
            // 
            // panelTxBxCE
            // 
            panelTxBxCE.Anchor = AnchorStyles.None;
            panelTxBxCE.BackColor = Color.FromArgb(101, 157, 242);
            panelTxBxCE.Controls.Add(txbUser);
            panelTxBxCE.Location = new Point(166, 152);
            panelTxBxCE.Name = "panelTxBxCE";
            panelTxBxCE.Size = new Size(629, 30);
            panelTxBxCE.TabIndex = 13;
            // 
            // txbUser
            // 
            txbUser.BackColor = Color.White;
            txbUser.Location = new Point(3, 2);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(624, 27);
            txbUser.TabIndex = 2;
            txbUser.TextChanged += txbCorreo_TextChanged;
            // 
            // Registrate
            // 
            Registrate.AutoSize = true;
            Registrate.Font = new Font("Roboto SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registrate.ForeColor = Color.FromArgb(48, 63, 159);
            Registrate.Location = new Point(112, 57);
            Registrate.Name = "Registrate";
            Registrate.Size = new Size(143, 34);
            Registrate.TabIndex = 11;
            Registrate.Text = "Regístrate";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 239);
            label1.Name = "label1";
            label1.Size = new Size(82, 18);
            label1.TabIndex = 22;
            label1.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(101, 157, 242);
            panel1.Controls.Add(tbxPSW);
            panel1.Location = new Point(166, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 31);
            panel1.TabIndex = 21;
            // 
            // tbxPSW
            // 
            tbxPSW.BackColor = Color.White;
            tbxPSW.Location = new Point(3, 2);
            tbxPSW.Name = "tbxPSW";
            tbxPSW.PasswordChar = '•';
            tbxPSW.Size = new Size(624, 27);
            tbxPSW.TabIndex = 2;
            // 
            // usrnm
            // 
            usrnm.AutoSize = true;
            usrnm.Font = new Font("Roboto SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usrnm.Location = new Point(166, 131);
            usrnm.Name = "usrnm";
            usrnm.Size = new Size(132, 18);
            usrnm.TabIndex = 23;
            usrnm.Text = "Nombre de Usuario";
            // 
            // crro
            // 
            crro.Anchor = AnchorStyles.None;
            crro.AutoSize = true;
            crro.Font = new Font("Roboto SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crro.Location = new Point(166, 185);
            crro.Name = "crro";
            crro.Size = new Size(127, 18);
            crro.TabIndex = 25;
            crro.Text = "Correo Electrónico";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(101, 157, 242);
            panel2.Controls.Add(txbcrro);
            panel2.Location = new Point(166, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(629, 31);
            panel2.TabIndex = 24;
            // 
            // txbcrro
            // 
            txbcrro.BackColor = Color.White;
            txbcrro.Location = new Point(3, 2);
            txbcrro.Name = "txbcrro";
            txbcrro.Size = new Size(624, 27);
            txbcrro.TabIndex = 2;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 255);
            ClientSize = new Size(964, 505);
            Controls.Add(crro);
            Controls.Add(panel2);
            Controls.Add(usrnm);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(regresar);
            Controls.Add(NoCuenta);
            Controls.Add(panelECOPLAN);
            Controls.Add(btnSesion);
            Controls.Add(label3);
            Controls.Add(panelTxBxPSW);
            Controls.Add(panelTxBxCE);
            Controls.Add(Registrate);
            Name = "Registrar";
            Text = "Registrar";
            Load += Registrar_Load;
            panelECOPLAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTxBxPSW.ResumeLayout(false);
            panelTxBxPSW.PerformLayout();
            panelTxBxCE.ResumeLayout(false);
            panelTxBxCE.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel regresar;
        private LinkLabel NoCuenta;
        private Panel panelECOPLAN;
        private PictureBox pictureBox1;
        private Button btnSesion;
        private Label label3;
        private Panel panelTxBxPSW;
        private TextBox txbCPSW;
        private Panel panelTxBxCE;
        private TextBox txbUser;
        private Label Registrate;
        private Label label1;
        private Panel panel1;
        private TextBox tbxPSW;
        private Label usrnm;
        private Label crro;
        private Panel panel2;
        private TextBox txbcrro;
    }
}