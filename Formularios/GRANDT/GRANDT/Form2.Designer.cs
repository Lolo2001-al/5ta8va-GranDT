namespace GRANDT
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            richTextBox6 = new RichTextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            richTextBox5 = new RichTextBox();
            label5 = new Label();
            richTextBox4 = new RichTextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            richTextBox3 = new RichTextBox();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(richTextBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(richTextBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(richTextBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(richTextBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(479, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 384);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // richTextBox6
            // 
            richTextBox6.BackColor = Color.White;
            richTextBox6.BorderStyle = BorderStyle.None;
            richTextBox6.Location = new Point(5, 249);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(297, 21);
            richTextBox6.TabIndex = 16;
            richTextBox6.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(6, 231);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 15;
            label7.Text = "Repetir contraseña";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.WindowText;
            dateTimePicker1.Location = new Point(7, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 23);
            dateTimePicker1.TabIndex = 14;
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
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.White;
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Location = new Point(167, 37);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(135, 21);
            richTextBox5.TabIndex = 12;
            richTextBox5.Text = "";
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
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.White;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Location = new Point(6, 37);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(135, 21);
            richTextBox4.TabIndex = 10;
            richTextBox4.Text = "";
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
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(74, 312);
            button1.Name = "button1";
            button1.Size = new Size(168, 41);
            button1.TabIndex = 7;
            button1.Text = "Registrate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.White;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(7, 165);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(297, 21);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(6, 105);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(7, 123);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(297, 21);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 147);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "GRAN DT";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private RichTextBox richTextBox3;
        private Label label3;
        private RichTextBox richTextBox2;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label1;
        private RichTextBox richTextBox4;
        private Label label4;
        private RichTextBox richTextBox5;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private RichTextBox richTextBox6;
        private Label label7;
    }
}