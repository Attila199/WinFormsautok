namespace WinFormsautok
{
    partial class Form1_nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_nyito));
            this.AutokNyilvanTartas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_rendszam = new System.Windows.Forms.TextBox();
            this.textBox_szin = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.uj_auto = new System.Windows.Forms.Button();
            this.modositas = new System.Windows.Forms.Button();
            this.torles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // AutokNyilvanTartas
            // 
            this.AutokNyilvanTartas.Dock = System.Windows.Forms.DockStyle.Left;
            this.AutokNyilvanTartas.FormattingEnabled = true;
            this.AutokNyilvanTartas.Location = new System.Drawing.Point(0, 0);
            this.AutokNyilvanTartas.Name = "AutokNyilvanTartas";
            this.AutokNyilvanTartas.Size = new System.Drawing.Size(120, 450);
            this.AutokNyilvanTartas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.torles);
            this.groupBox1.Controls.Add(this.modositas);
            this.groupBox1.Controls.Add(this.uj_auto);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox_szin);
            this.groupBox1.Controls.Add(this.textBox_rendszam);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(120, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A kiválasztott autók adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "rendszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Évjárat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "szín";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(154, 67);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_rendszam
            // 
            this.textBox_rendszam.Location = new System.Drawing.Point(154, 113);
            this.textBox_rendszam.Name = "textBox_rendszam";
            this.textBox_rendszam.Size = new System.Drawing.Size(100, 20);
            this.textBox_rendszam.TabIndex = 5;
            // 
            // textBox_szin
            // 
            this.textBox_szin.Location = new System.Drawing.Point(154, 186);
            this.textBox_szin.Name = "textBox_szin";
            this.textBox_szin.Size = new System.Drawing.Size(100, 20);
            this.textBox_szin.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(154, 153);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // uj_auto
            // 
            this.uj_auto.Location = new System.Drawing.Point(65, 250);
            this.uj_auto.Name = "uj_auto";
            this.uj_auto.Size = new System.Drawing.Size(75, 23);
            this.uj_auto.TabIndex = 9;
            this.uj_auto.Text = "Új autó";
            this.uj_auto.UseVisualStyleBackColor = true;
            this.uj_auto.Click += new System.EventHandler(this.uj_auto_Click);
            // 
            // modositas
            // 
            this.modositas.Location = new System.Drawing.Point(203, 250);
            this.modositas.Name = "modositas";
            this.modositas.Size = new System.Drawing.Size(75, 23);
            this.modositas.TabIndex = 10;
            this.modositas.Text = "Módosítás";
            this.modositas.UseVisualStyleBackColor = true;
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(322, 250);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(75, 23);
            this.torles.TabIndex = 11;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            // 
            // Form1_nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AutokNyilvanTartas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1_nyito";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_nyito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AutokNyilvanTartas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Button modositas;
        private System.Windows.Forms.Button uj_auto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox_szin;
        private System.Windows.Forms.TextBox textBox_rendszam;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

