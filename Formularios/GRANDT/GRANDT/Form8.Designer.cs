namespace GRANDT
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(770, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "PLANTILLA 1";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(722, 446);
            button2.Name = "button2";
            button2.Size = new Size(203, 55);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(-5, 446);
            button1.Name = "button1";
            button1.Size = new Size(206, 55);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(722, 90);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 4;
            label2.Text = "Presupuesto:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(722, 190);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 5;
            label3.Text = "Equipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(722, 142);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Nombre:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(789, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(123, 23);
            comboBox1.TabIndex = 7;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(798, 143);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(114, 23);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(819, 90);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "$ 65.000.000";
            label5.Click += label5_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 513);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form8";
            Text = "GRAN DT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Label label5;
    }
}