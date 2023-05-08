namespace ShopForms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxÜbersicht = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPreis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxKategorie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxHersteller = new System.Windows.Forms.TextBox();
            this.pbxBild = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBild)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxÜbersicht
            // 
            this.lbxÜbersicht.FormattingEnabled = true;
            this.lbxÜbersicht.Location = new System.Drawing.Point(13, 13);
            this.lbxÜbersicht.Name = "lbxÜbersicht";
            this.lbxÜbersicht.Size = new System.Drawing.Size(160, 433);
            this.lbxÜbersicht.TabIndex = 0;
            this.lbxÜbersicht.SelectedIndexChanged += new System.EventHandler(this.lbxÜbersicht_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbxBild);
            this.groupBox1.Controls.Add(this.tbxHersteller);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxKategorie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxPreis);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(179, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 425);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(50, 13);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxPreis
            // 
            this.tbxPreis.Location = new System.Drawing.Point(50, 39);
            this.tbxPreis.Name = "tbxPreis";
            this.tbxPreis.Size = new System.Drawing.Size(100, 20);
            this.tbxPreis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie:";
            // 
            // tbxKategorie
            // 
            this.tbxKategorie.Location = new System.Drawing.Point(217, 13);
            this.tbxKategorie.Name = "tbxKategorie";
            this.tbxKategorie.Size = new System.Drawing.Size(142, 20);
            this.tbxKategorie.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hersteller:";
            // 
            // tbxHersteller
            // 
            this.tbxHersteller.Location = new System.Drawing.Point(217, 39);
            this.tbxHersteller.Name = "tbxHersteller";
            this.tbxHersteller.Size = new System.Drawing.Size(142, 20);
            this.tbxHersteller.TabIndex = 7;
            // 
            // pbxBild
            // 
            this.pbxBild.Location = new System.Drawing.Point(9, 65);
            this.pbxBild.Name = "pbxBild";
            this.pbxBild.Size = new System.Drawing.Size(594, 354);
            this.pbxBild.TabIndex = 8;
            this.pbxBild.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxÜbersicht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxÜbersicht;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxBild;
        private System.Windows.Forms.TextBox tbxHersteller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxKategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPreis;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
    }
}

