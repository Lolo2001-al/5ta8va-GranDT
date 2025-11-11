namespace GRANDT
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(878, 535);
            button2.Name = "button2";
            button2.Size = new Size(210, 37);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(892, 153);
            button1.Name = "button1";
            button1.Size = new Size(161, 30);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(878, 201);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 6;
            label3.Text = "Presupuesto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(650, 458);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 7;
            label1.Text = "Equipo:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1088, 584);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "GRAN DT";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Label label1;
    }
}