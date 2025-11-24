namespace GRANDT
{
    partial class SeleccionarPlantilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarPlantilla));
            button1 = new Button();
            CrearPlantilla = new Button();
            PlantillaComboBox = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(-3, 381);
            button1.Name = "button1";
            button1.Size = new Size(164, 48);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CrearPlantilla
            // 
            CrearPlantilla.BackColor = Color.Transparent;
            CrearPlantilla.FlatStyle = FlatStyle.Popup;
            CrearPlantilla.Location = new Point(-3, 98);
            CrearPlantilla.Name = "CrearPlantilla";
            CrearPlantilla.Size = new Size(198, 45);
            CrearPlantilla.TabIndex = 2;
            CrearPlantilla.UseVisualStyleBackColor = false;
            CrearPlantilla.Click += button3_Click;
            // 
            // PlantillaComboBox
            // 
            PlantillaComboBox.FormattingEnabled = true;
            PlantillaComboBox.Location = new Point(330, 134);
            PlantillaComboBox.Name = "PlantillaComboBox";
            PlantillaComboBox.Size = new Size(121, 23);
            PlantillaComboBox.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(330, 176);
            button2.Name = "button2";
            button2.Size = new Size(121, 28);
            button2.TabIndex = 4;
            button2.Text = "SELECCIONAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // SeleccionarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(PlantillaComboBox);
            Controls.Add(CrearPlantilla);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SeleccionarPlantilla";
            Text = "GRAN DT";
            Load += SeleccionarPlantilla_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button Seleccionarplantilla;
        private Button CrearPlantilla;
        private ComboBox PlantillaComboBox;
        private Button button2;
    }
}