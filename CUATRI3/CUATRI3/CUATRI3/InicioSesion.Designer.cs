namespace ECOPLAN
{
    partial class MenuPrincipl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipl));
            iniciar = new Label();
            label2 = new Label();
            panelTxBxCE = new Panel();
            txbCorreo = new TextBox();
            panelTxBxPSW = new Panel();
            txbPSW = new TextBox();
            pws = new Label();
            btnSesion = new Button();
            Fpsw = new LinkLabel();
            NoCuenta = new LinkLabel();
            regresar = new LinkLabel();
            panel2 = new Panel();
            viewpsw = new PictureBox();
            ECOPLAN = new PictureBox();
            panelTxBxCE.SuspendLayout();
            panelTxBxPSW.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewpsw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ECOPLAN).BeginInit();
            SuspendLayout();
            // 
            // iniciar
            // 
            iniciar.Font = new Font("Roboto SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iniciar.ForeColor = Color.FromArgb(48, 63, 159);
            iniciar.Location = new Point(75, 75);
            iniciar.Name = "iniciar";
            iniciar.Size = new Size(220, 34);
            iniciar.TabIndex = 0;
            iniciar.Text = "INICIAR SESIÓN";
            iniciar.TextAlign = ContentAlignment.TopCenter;
            iniciar.Click += iniciar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(171, 133);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Correo Electrónico";
            // 
            // panelTxBxCE
            // 
            panelTxBxCE.Anchor = AnchorStyles.None;
            panelTxBxCE.BackColor = Color.FromArgb(101, 157, 242);
            panelTxBxCE.Controls.Add(txbCorreo);
            panelTxBxCE.Location = new Point(167, 154);
            panelTxBxCE.Name = "panelTxBxCE";
            panelTxBxCE.Size = new Size(629, 30);
            panelTxBxCE.TabIndex = 3;
            // 
            // txbCorreo
            // 
            txbCorreo.BackColor = Color.White;
            txbCorreo.Location = new Point(3, 2);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(624, 27);
            txbCorreo.TabIndex = 2;
            // 
            // panelTxBxPSW
            // 
            panelTxBxPSW.Anchor = AnchorStyles.None;
            panelTxBxPSW.BackColor = Color.FromArgb(101, 157, 242);
            panelTxBxPSW.Controls.Add(txbPSW);
            panelTxBxPSW.Location = new Point(167, 225);
            panelTxBxPSW.Name = "panelTxBxPSW";
            panelTxBxPSW.Size = new Size(629, 31);
            panelTxBxPSW.TabIndex = 4;
            // 
            // txbPSW
            // 
            txbPSW.BackColor = Color.White;
            txbPSW.Location = new Point(3, 2);
            txbPSW.Name = "txbPSW";
            txbPSW.PasswordChar = '•';
            txbPSW.Size = new Size(624, 27);
            txbPSW.TabIndex = 2;
            // 
            // pws
            // 
            pws.Anchor = AnchorStyles.None;
            pws.AutoSize = true;
            pws.Location = new Point(171, 205);
            pws.Name = "pws";
            pws.Size = new Size(83, 20);
            pws.TabIndex = 5;
            pws.Text = "Contraseña";
            // 
            // btnSesion
            // 
            btnSesion.Anchor = AnchorStyles.Bottom;
            btnSesion.BackColor = Color.FromArgb(48, 63, 159);
            btnSesion.FlatStyle = FlatStyle.Flat;
            btnSesion.Font = new Font("Roboto SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSesion.ForeColor = Color.White;
            btnSesion.Location = new Point(407, 290);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(147, 29);
            btnSesion.TabIndex = 6;
            btnSesion.Text = "Iniciar sesión";
            btnSesion.UseVisualStyleBackColor = false;
            btnSesion.Click += btnSesion_Click;
            // 
            // Fpsw
            // 
            Fpsw.ActiveLinkColor = Color.FromArgb(48, 91, 171);
            Fpsw.Anchor = AnchorStyles.None;
            Fpsw.AutoSize = true;
            Fpsw.LinkColor = Color.FromArgb(48, 91, 171);
            Fpsw.Location = new Point(171, 259);
            Fpsw.Name = "Fpsw";
            Fpsw.Size = new Size(178, 20);
            Fpsw.TabIndex = 8;
            Fpsw.TabStop = true;
            Fpsw.Text = "¿Olvidaste tu contraseña?";
            // 
            // NoCuenta
            // 
            NoCuenta.ActiveLinkColor = Color.FromArgb(48, 91, 171);
            NoCuenta.Anchor = AnchorStyles.None;
            NoCuenta.AutoSize = true;
            NoCuenta.LinkColor = Color.FromArgb(48, 91, 171);
            NoCuenta.Location = new Point(605, 259);
            NoCuenta.Name = "NoCuenta";
            NoCuenta.Size = new Size(189, 20);
            NoCuenta.TabIndex = 9;
            NoCuenta.TabStop = true;
            NoCuenta.Text = "¿Aún no tienes una cuenta?";
            NoCuenta.LinkClicked += NoCuenta_LinkClicked;
            // 
            // regresar
            // 
            regresar.ActiveLinkColor = Color.FromArgb(48, 91, 171);
            regresar.Anchor = AnchorStyles.None;
            regresar.AutoSize = true;
            regresar.LinkColor = Color.FromArgb(48, 91, 171);
            regresar.Location = new Point(727, 133);
            regresar.Name = "regresar";
            regresar.Size = new Size(67, 20);
            regresar.TabIndex = 10;
            regresar.TabStop = true;
            regresar.Text = "Regresar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(246, 255, 255);
            panel2.Controls.Add(viewpsw);
            panel2.Controls.Add(ECOPLAN);
            panel2.Controls.Add(regresar);
            panel2.Controls.Add(NoCuenta);
            panel2.Controls.Add(Fpsw);
            panel2.Controls.Add(btnSesion);
            panel2.Controls.Add(pws);
            panel2.Controls.Add(panelTxBxPSW);
            panel2.Controls.Add(panelTxBxCE);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(iniciar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 505);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // viewpsw
            // 
            viewpsw.BackColor = Color.Transparent;
            viewpsw.Image = (Image)resources.GetObject("viewpsw.Image");
            viewpsw.Location = new Point(743, 203);
            viewpsw.Name = "viewpsw";
            viewpsw.Size = new Size(40, 22);
            viewpsw.SizeMode = PictureBoxSizeMode.Zoom;
            viewpsw.TabIndex = 12;
            viewpsw.TabStop = false;
            viewpsw.Click += viewpsw_Click;
            // 
            // ECOPLAN
            // 
            ECOPLAN.BackColor = Color.FromArgb(48, 63, 159);
            ECOPLAN.Image = (Image)resources.GetObject("ECOPLAN.Image");
            ECOPLAN.Location = new Point(715, 56);
            ECOPLAN.Name = "ECOPLAN";
            ECOPLAN.Size = new Size(125, 62);
            ECOPLAN.SizeMode = PictureBoxSizeMode.Zoom;
            ECOPLAN.TabIndex = 11;
            ECOPLAN.TabStop = false;
            // 
            // MenuPrincipl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 505);
            Controls.Add(panel2);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(600, 400);
            Name = "MenuPrincipl";
            Text = "Iniciar sesión";
            panelTxBxCE.ResumeLayout(false);
            panelTxBxCE.PerformLayout();
            panelTxBxPSW.ResumeLayout(false);
            panelTxBxPSW.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewpsw).EndInit();
            ((System.ComponentModel.ISupportInitialize)ECOPLAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label iniciar;
        private Label label2;
        private Panel panelTxBxCE;
        private TextBox txbCorreo;
        private Panel panelTxBxPSW;
        private TextBox txbPSW;
        private Label pws;
        private Button btnSesion;
        private LinkLabel Fpsw;
        private LinkLabel NoCuenta;
        private LinkLabel regresar;
        private Panel panel2;
        private PictureBox ECOPLAN;
        private PictureBox viewpsw;
    }
}
