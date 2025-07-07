namespace ECOPLAN
{
    partial class DatosBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosBanco));
            regresar = new LinkLabel();
            panelECOPLAN = new Panel();
            pictureBox1 = new PictureBox();
            panelTxBxCE = new Panel();
            txbCorreo = new TextBox();
            Nombres = new Label();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            bancos = new ComboBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            textBox4 = new TextBox();
            btnSesion = new Button();
            panelECOPLAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTxBxCE.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // regresar
            // 
            regresar.ActiveLinkColor = Color.FromArgb(48, 91, 171);
            regresar.Anchor = AnchorStyles.None;
            regresar.AutoSize = true;
            regresar.LinkColor = Color.FromArgb(48, 91, 171);
            regresar.Location = new Point(722, 124);
            regresar.Name = "regresar";
            regresar.Size = new Size(67, 20);
            regresar.TabIndex = 17;
            regresar.TabStop = true;
            regresar.Text = "Regresar";
            // 
            // panelECOPLAN
            // 
            panelECOPLAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelECOPLAN.BackColor = Color.FromArgb(48, 63, 159);
            panelECOPLAN.Controls.Add(pictureBox1);
            panelECOPLAN.Location = new Point(693, 23);
            panelECOPLAN.Name = "panelECOPLAN";
            panelECOPLAN.Size = new Size(202, 85);
            panelECOPLAN.TabIndex = 16;
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
            // panelTxBxCE
            // 
            panelTxBxCE.Anchor = AnchorStyles.None;
            panelTxBxCE.BackColor = Color.FromArgb(101, 157, 242);
            panelTxBxCE.Controls.Add(txbCorreo);
            panelTxBxCE.Location = new Point(162, 145);
            panelTxBxCE.Name = "panelTxBxCE";
            panelTxBxCE.Size = new Size(629, 30);
            panelTxBxCE.TabIndex = 13;
            // 
            // txbCorreo
            // 
            txbCorreo.BackColor = Color.White;
            txbCorreo.Location = new Point(3, 2);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(624, 27);
            txbCorreo.TabIndex = 2;
            // 
            // Nombres
            // 
            Nombres.Anchor = AnchorStyles.None;
            Nombres.AutoSize = true;
            Nombres.Location = new Point(166, 124);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(132, 20);
            Nombres.TabIndex = 12;
            Nombres.Text = "Nombre completo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(48, 63, 159);
            label1.Location = new Point(70, 58);
            label1.Name = "label1";
            label1.Size = new Size(220, 34);
            label1.TabIndex = 11;
            label1.Text = "Datos Bancarios";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(166, 260);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 21;
            label4.Text = "Banco";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(101, 157, 242);
            panel1.Controls.Add(bancos);
            panel1.Location = new Point(162, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 31);
            panel1.TabIndex = 20;
            // 
            // bancos
            // 
            bancos.FormattingEnabled = true;
            bancos.Items.AddRange(new object[] { "BBVA México", "Citibanamex", "Santander México", "Banorte", "HSBC México", "Scotiabank México", "Inbursa", "Banco Azteca", "Bancoppel", "Banco del Bienestar", "Klar ", "Nu México", "Stori", "Banregio ", "Consubanco " });
            bancos.Location = new Point(2, 1);
            bancos.Name = "bancos";
            bancos.Size = new Size(625, 28);
            bancos.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(101, 157, 242);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(162, 213);
            panel2.Name = "panel2";
            panel2.Size = new Size(629, 30);
            panel2.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(624, 27);
            textBox2.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(166, 192);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 18;
            label5.Text = "Número de teléfono";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(166, 324);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 25;
            label6.Text = "Ingresos mensuales";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(101, 157, 242);
            panel4.Controls.Add(textBox4);
            panel4.Location = new Point(161, 347);
            panel4.Name = "panel4";
            panel4.Size = new Size(629, 31);
            panel4.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(624, 27);
            textBox4.TabIndex = 2;
            // 
            // btnSesion
            // 
            btnSesion.Anchor = AnchorStyles.Bottom;
            btnSesion.BackColor = Color.FromArgb(48, 63, 159);
            btnSesion.FlatStyle = FlatStyle.Flat;
            btnSesion.Font = new Font("Roboto SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSesion.ForeColor = Color.White;
            btnSesion.Location = new Point(409, 400);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(147, 29);
            btnSesion.TabIndex = 26;
            btnSesion.Text = "Resgistrarme";
            btnSesion.UseVisualStyleBackColor = false;
            // 
            // DatosBanco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 255, 255);
            ClientSize = new Size(964, 505);
            Controls.Add(btnSesion);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(regresar);
            Controls.Add(panelECOPLAN);
            Controls.Add(panelTxBxCE);
            Controls.Add(Nombres);
            Controls.Add(label1);
            Name = "DatosBanco";
            Text = "DatosBanco";
            Load += DatosBanco_Load;
            panelECOPLAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTxBxCE.ResumeLayout(false);
            panelTxBxCE.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel regresar;
        private Panel panelECOPLAN;
        private PictureBox pictureBox1;
        private Panel panelTxBxCE;
        private TextBox txbCorreo;
        private Label Nombres;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private TextBox textBox4;
        private ComboBox bancos;
        private Button btnSesion;
    }
}