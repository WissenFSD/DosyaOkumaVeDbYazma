namespace DosyaOkumaVeDbYazma
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
            lstDosyalar = new ListBox();
            btnGetir = new Button();
            btndb = new Button();
            SuspendLayout();
            // 
            // lstDosyalar
            // 
            lstDosyalar.FormattingEnabled = true;
            lstDosyalar.ItemHeight = 15;
            lstDosyalar.Location = new Point(12, 12);
            lstDosyalar.Name = "lstDosyalar";
            lstDosyalar.Size = new Size(388, 349);
            lstDosyalar.TabIndex = 0;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(14, 375);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(167, 23);
            btnGetir.TabIndex = 1;
            btnGetir.Text = "Dosyaları Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // btndb
            // 
            btndb.Location = new Point(234, 375);
            btndb.Name = "btndb";
            btndb.Size = new Size(166, 23);
            btndb.TabIndex = 2;
            btndb.Text = "Veri tabanına yaz";
            btndb.UseVisualStyleBackColor = true;
            btndb.Click += btndb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btndb);
            Controls.Add(btnGetir);
            Controls.Add(lstDosyalar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstDosyalar;
        private Button btnGetir;
        private Button btndb;
    }
}