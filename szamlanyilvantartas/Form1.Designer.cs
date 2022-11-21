namespace szamlanyilvantartas
{
    partial class Form1
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
            this.szamlak = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tulajlab = new System.Windows.Forms.Label();
            this.egyenleglab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nevtxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.delete = new System.Windows.Forms.Button();
            this.modositas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.egyenlegnum = new System.Windows.Forms.NumericUpDown();
            this.valasztas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.egyenlegnum)).BeginInit();
            this.SuspendLayout();
            // 
            // szamlak
            // 
            this.szamlak.Dock = System.Windows.Forms.DockStyle.Left;
            this.szamlak.FormattingEnabled = true;
            this.szamlak.Location = new System.Drawing.Point(0, 0);
            this.szamlak.Name = "szamlak";
            this.szamlak.Size = new System.Drawing.Size(224, 450);
            this.szamlak.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // tulajlab
            // 
            this.tulajlab.AutoSize = true;
            this.tulajlab.Location = new System.Drawing.Point(250, 75);
            this.tulajlab.Name = "tulajlab";
            this.tulajlab.Size = new System.Drawing.Size(88, 13);
            this.tulajlab.TabIndex = 2;
            this.tulajlab.Text = "Tulajdonos Neve";
            // 
            // egyenleglab
            // 
            this.egyenleglab.AutoSize = true;
            this.egyenleglab.Location = new System.Drawing.Point(250, 108);
            this.egyenleglab.Name = "egyenleglab";
            this.egyenleglab.Size = new System.Drawing.Size(51, 13);
            this.egyenleglab.TabIndex = 3;
            this.egyenleglab.Text = "Egyenleg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nyitási Dátum";
            // 
            // nevtxt
            // 
            this.nevtxt.Location = new System.Drawing.Point(345, 75);
            this.nevtxt.Name = "nevtxt";
            this.nevtxt.Size = new System.Drawing.Size(127, 20);
            this.nevtxt.TabIndex = 6;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(309, 43);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.ReadOnly = true;
            this.IDtxt.Size = new System.Drawing.Size(79, 20);
            this.IDtxt.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(345, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(248, 253);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 39);
            this.delete.TabIndex = 10;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // modositas
            // 
            this.modositas.Location = new System.Drawing.Point(420, 185);
            this.modositas.Name = "modositas";
            this.modositas.Size = new System.Drawing.Size(132, 36);
            this.modositas.TabIndex = 11;
            this.modositas.Text = "Módositás";
            this.modositas.UseVisualStyleBackColor = true;
            this.modositas.Click += new System.EventHandler(this.modositas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Új";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.szamlatarol_Click);
            // 
            // egyenlegnum
            // 
            this.egyenlegnum.Location = new System.Drawing.Point(345, 108);
            this.egyenlegnum.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.egyenlegnum.Name = "egyenlegnum";
            this.egyenlegnum.Size = new System.Drawing.Size(127, 20);
            this.egyenlegnum.TabIndex = 12;
            this.egyenlegnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valasztas
            // 
            this.valasztas.Location = new System.Drawing.Point(420, 254);
            this.valasztas.Name = "valasztas";
            this.valasztas.Size = new System.Drawing.Size(131, 37);
            this.valasztas.TabIndex = 13;
            this.valasztas.Text = "Választás";
            this.valasztas.UseVisualStyleBackColor = true;
            this.valasztas.Click += new System.EventHandler(this.valasztas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Számla Nyilvántatás";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valasztas);
            this.Controls.Add(this.egyenlegnum);
            this.Controls.Add(this.modositas);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.nevtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.egyenleglab);
            this.Controls.Add(this.tulajlab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szamlak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.egyenlegnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox szamlak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulajlab;
        private System.Windows.Forms.Label egyenleglab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nevtxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button modositas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown egyenlegnum;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button valasztas;
        private System.Windows.Forms.Label label2;
    }
}

