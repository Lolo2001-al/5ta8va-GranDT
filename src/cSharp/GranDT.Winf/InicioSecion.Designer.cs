namespace GRANDT
{
    partial class InicioSecion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSecion));
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            IniciarSecion = new Button();
            confirmarPasswordBox = new RichTextBox();
            asd = new Label();
            PasswordBox = new RichTextBox();
            label2 = new Label();
            EmailBox = new RichTextBox();
            asdd = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(IniciarSecion);
            groupBox1.Controls.Add(confirmarPasswordBox);
            groupBox1.Controls.Add(asd);
            groupBox1.Controls.Add(PasswordBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(EmailBox);
            groupBox1.Controls.Add(asdd);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(479, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 384);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(64, 356);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(187, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿No tienes una cuenta?, Registrate";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // IniciarSecion
            // 
            IniciarSecion.BackColor = Color.Peru;
            IniciarSecion.FlatStyle = FlatStyle.Popup;
            IniciarSecion.ForeColor = SystemColors.ControlText;
            IniciarSecion.Location = new Point(74, 312);
            IniciarSecion.Name = "IniciarSecion";
            IniciarSecion.Size = new Size(168, 41);
            IniciarSecion.TabIndex = 7;
            IniciarSecion.Text = "Iniciar Sesion";
            IniciarSecion.UseVisualStyleBackColor = false;
            IniciarSecion.Click += IniciarSecion_Click;
            // 
            // confirmarPasswordBox
            // 
            confirmarPasswordBox.BackColor = Color.White;
            confirmarPasswordBox.BorderStyle = BorderStyle.None;
            confirmarPasswordBox.Location = new Point(6, 186);
            confirmarPasswordBox.Name = "confirmarPasswordBox";
            confirmarPasswordBox.Size = new Size(297, 21);
            confirmarPasswordBox.TabIndex = 6;
            confirmarPasswordBox.Text = "";
            // 
            // asd
            // 
            asd.AutoSize = true;
            asd.BackColor = Color.Transparent;
            asd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            asd.ForeColor = SystemColors.Control;
            asd.Location = new Point(6, 162);
            asd.Name = "asd";
            asd.Size = new Size(181, 21);
            asd.TabIndex = 5;
            asd.Text = "Confirmar Contraseña ";
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.White;
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Location = new Point(6, 114);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(297, 21);
            PasswordBox.TabIndex = 4;
            PasswordBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // EmailBox
            // 
            EmailBox.BackColor = Color.White;
            EmailBox.BorderStyle = BorderStyle.None;
            EmailBox.Location = new Point(6, 43);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(297, 21);
            EmailBox.TabIndex = 2;
            EmailBox.Text = "";
            // 
            // asdd
            // 
            asdd.AutoSize = true;
            asdd.BackColor = Color.Transparent;
            asdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            asdd.ForeColor = SystemColors.Control;
            asdd.Location = new Point(6, 19);
            asdd.Name = "asdd";
            asdd.Size = new Size(53, 21);
            asdd.TabIndex = 1;
            asdd.Text = "Email";
            asdd.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(263, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 328);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // InicioSecion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InicioSecion";
            Text = "GRAN DT";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label asdd;
        private RichTextBox EmailBox;
        private LinkLabel linkLabel1;
        private Button IniciarSecion;
        private RichTextBox confirmarPasswordBox;
        private Label asd;
        private RichTextBox PasswordBox;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
