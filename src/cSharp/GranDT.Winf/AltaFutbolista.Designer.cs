namespace GRANDT
{
    partial class AltaFutbolista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaFutbolista));
            Fichar = new Button();
            button2 = new Button();
            FutbolistasDataGridView = new DataGridView();
            TipoComboBox = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)FutbolistasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // Fichar
            // 
            Fichar.BackColor = Color.Transparent;
            Fichar.BackgroundImageLayout = ImageLayout.None;
            Fichar.FlatStyle = FlatStyle.Popup;
            Fichar.Location = new Point(334, 393);
            Fichar.Name = "Fichar";
            Fichar.Size = new Size(133, 26);
            Fichar.TabIndex = 0;
            Fichar.UseVisualStyleBackColor = false;
            Fichar.Click += Fichar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(-5, 427);
            button2.Name = "button2";
            button2.Size = new Size(178, 25);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FutbolistasDataGridView
            // 
            FutbolistasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FutbolistasDataGridView.Location = new Point(12, 69);
            FutbolistasDataGridView.Name = "FutbolistasDataGridView";
            FutbolistasDataGridView.Size = new Size(776, 318);
            FutbolistasDataGridView.TabIndex = 2;
            // 
            // TipoComboBox
            // 
            TipoComboBox.FormattingEnabled = true;
            TipoComboBox.Location = new Point(92, 40);
            TipoComboBox.Name = "TipoComboBox";
            TipoComboBox.Size = new Size(81, 23);
            TipoComboBox.TabIndex = 7;
            TipoComboBox.SelectedIndexChanged += TipoComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(626, 427);
            button1.Name = "button1";
            button1.Size = new Size(178, 25);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AltaFutbolista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(TipoComboBox);
            Controls.Add(FutbolistasDataGridView);
            Controls.Add(button2);
            Controls.Add(Fichar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AltaFutbolista";
            Text = "GRAN DT";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)FutbolistasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Fichar;
        private Button button2;
        private DataGridView FutbolistasDataGridView;
        private ComboBox TipoComboBox;
        private Button button1;
    }
}