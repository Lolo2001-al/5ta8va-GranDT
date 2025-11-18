namespace GRANDT
{
    partial class Reguistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reguistro));
            groupBox1 = new GroupBox();
            label6 = new Label();
            ApellidoBox = new RichTextBox();
            label5 = new Label();
            this.NombreBox = new RichTextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            ReguistrarseButton = new Button();
            richTextBox3 = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            EmailBox = new RichTextBox();
            NacimientoBox = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(NacimientoBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(ApellidoBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(this.NombreBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(ReguistrarseButton);
            groupBox1.Controls.Add(richTextBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(EmailBox);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(479, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 384);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(7, 61);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 13;
            label6.Text = "Fecha de nacimiento";
            // 
            // ApellidoBox
            // 
            ApellidoBox.BackColor = Color.White;
            ApellidoBox.BorderStyle = BorderStyle.None;
            ApellidoBox.Location = new Point(167, 37);
            ApellidoBox.Name = "ApellidoBox";
            ApellidoBox.Size = new Size(135, 21);
            ApellidoBox.TabIndex = 12;
            ApellidoBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(167, 19);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 11;
            label5.Text = "Apellido";
            label5.Click += label5_Click;
            // 
            // NombreBox
            // 
            this.NombreBox.BackColor = Color.White;
            this.NombreBox.BorderStyle = BorderStyle.None;
            this.NombreBox.Location = new Point(6, 37);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new Size(135, 21);
            this.NombreBox.TabIndex = 10;
            this.NombreBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 9;
            label4.Text = "Nombre";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(64, 356);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(199, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ya tenés una cuenta?, Inicia sesion";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ReguistrarseButton
            // 
            ReguistrarseButton.BackColor = Color.Peru;
            ReguistrarseButton.BackgroundImageLayout = ImageLayout.None;
            ReguistrarseButton.FlatStyle = FlatStyle.Popup;
            ReguistrarseButton.Location = new Point(74, 312);
            ReguistrarseButton.Name = "ReguistrarseButton";
            ReguistrarseButton.Size = new Size(168, 41);
            ReguistrarseButton.TabIndex = 7;
            ReguistrarseButton.Text = "Registrate";
            ReguistrarseButton.UseVisualStyleBackColor = false;
            ReguistrarseButton.Click += button1_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.White;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Location = new Point(5, 207);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(297, 21);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(6, 189);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(6, 133);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // EmailBox
            // 
            EmailBox.BackColor = Color.White;
            EmailBox.BorderStyle = BorderStyle.None;
            EmailBox.Location = new Point(7, 151);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(297, 21);
            EmailBox.TabIndex = 2;
            EmailBox.Text = "";
            // 
            // NacimientoBox
            // 
            NacimientoBox.Location = new Point(7, 79);
            NacimientoBox.Mask = "0000-00-00";
            NacimientoBox.Name = "NacimientoBox";
            NacimientoBox.Size = new Size(121, 23);
            NacimientoBox.TabIndex = 14;
            NacimientoBox.ValidatingType = typeof(DateTime);
            // 
            // Reguistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Reguistro";
            Text = "GRAN DT";
            Load += Reguistro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Button ReguistrarseButton;
        private RichTextBox richTextBox3;
        private Label label3;
        private RichTextBox ApellidoBox;
        private Label label2;
        private RichTextBox EmailBox;
        private Label label1;
        private RichTextBox richTextBox4;
        private Label label4;
        private RichTextBox richTextBox5;
        private Label label5;
        private Label label6;
        private MaskedTextBox NacimientoBox;
    }
}