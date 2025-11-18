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
            NombreF = new Label();
            label1 = new Label();
            label2 = new Label();
            TipoComboBox = new ComboBox();
            Atualizar = new Button();
            Futbolista = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)FutbolistasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // Fichar
            // 
            Fichar.BackColor = Color.Transparent;
            Fichar.BackgroundImageLayout = ImageLayout.None;
            Fichar.FlatStyle = FlatStyle.Popup;
            Fichar.Location = new Point(66, 362);
            Fichar.Name = "Fichar";
            Fichar.Size = new Size(133, 26);
            Fichar.TabIndex = 0;
            Fichar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(-5, 413);
            button2.Name = "button2";
            button2.Size = new Size(178, 25);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FutbolistasDataGridView
            // 
            FutbolistasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FutbolistasDataGridView.Location = new Point(295, 77);
            FutbolistasDataGridView.Name = "FutbolistasDataGridView";
            FutbolistasDataGridView.Size = new Size(340, 311);
            FutbolistasDataGridView.TabIndex = 2;
            // 
            // NombreF
            // 
            NombreF.AutoSize = true;
            NombreF.Location = new Point(108, 212);
            NombreF.Name = "NombreF";
            NombreF.Size = new Size(14, 15);
            NombreF.TabIndex = 4;
            NombreF.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 237);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 5;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 266);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 6;
            label2.Text = "X";
            // 
            // TipoComboBox
            // 
            TipoComboBox.FormattingEnabled = true;
            TipoComboBox.Location = new Point(92, 59);
            TipoComboBox.Name = "TipoComboBox";
            TipoComboBox.Size = new Size(81, 23);
            TipoComboBox.TabIndex = 7;
            TipoComboBox.SelectedIndexChanged += TipoComboBox_SelectedIndexChanged;
            // 
            // Atualizar
            // 
            Atualizar.Location = new Point(98, 103);
            Atualizar.Name = "Atualizar";
            Atualizar.Size = new Size(75, 23);
            Atualizar.TabIndex = 8;
            Atualizar.Text = "Actualizar";
            Atualizar.UseVisualStyleBackColor = true;
            Atualizar.Click += Atualizar_Click;
            // 
            // Futbolista
            // 
            Futbolista.FormattingEnabled = true;
            Futbolista.Location = new Point(98, 174);
            Futbolista.Name = "Futbolista";
            Futbolista.Size = new Size(81, 23);
            Futbolista.TabIndex = 9;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Futbolista);
            Controls.Add(Atualizar);
            Controls.Add(TipoComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NombreF);
            Controls.Add(FutbolistasDataGridView);
            Controls.Add(button2);
            Controls.Add(Fichar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "GRAN DT";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)FutbolistasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Fichar;
        private Button button2;
        private DataGridView FutbolistasDataGridView;
        private Label NombreF;
        private Label label1;
        private Label label2;
        private ComboBox TipoComboBox;
        private Button Atualizar;
        private ComboBox Futbolista;
    }
}