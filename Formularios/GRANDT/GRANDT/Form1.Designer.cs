namespace GRANDT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            richTextBox3 = new RichTextBox();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
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
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(richTextBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label1);
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
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(74, 312);
            button1.Name = "button1";
            button1.Size = new Size(168, 41);
            button1.TabIndex = 7;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.White;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Location = new Point(6, 186);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(297, 21);
            richTextBox3.TabIndex = 6;
            richTextBox3.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(6, 162);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.White;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(6, 114);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(297, 21);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(6, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(297, 21);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
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
            // Form1
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
            Name = "Form1";
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
        private Label label1;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private RichTextBox richTextBox3;
        private Label label3;
        private RichTextBox richTextBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
