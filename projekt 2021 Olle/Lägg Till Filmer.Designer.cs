
namespace projekt_2021_Olle
{
    partial class Lägg_Till_Filmer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Txtb_Namn = new System.Windows.Forms.TextBox();
            this.Txtb_Genrer = new System.Windows.Forms.TextBox();
            this.Txtb_Poster = new System.Windows.Forms.TextBox();
            this.Txtb_Sal = new System.Windows.Forms.TextBox();
            this.Txtb_pop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Btn_SaveFilm = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Txtb_Namn
            // 
            this.Txtb_Namn.Location = new System.Drawing.Point(83, 60);
            this.Txtb_Namn.Name = "Txtb_Namn";
            this.Txtb_Namn.Size = new System.Drawing.Size(100, 20);
            this.Txtb_Namn.TabIndex = 0;
            // 
            // Txtb_Genrer
            // 
            this.Txtb_Genrer.Location = new System.Drawing.Point(83, 105);
            this.Txtb_Genrer.Name = "Txtb_Genrer";
            this.Txtb_Genrer.Size = new System.Drawing.Size(100, 20);
            this.Txtb_Genrer.TabIndex = 1;
            // 
            // Txtb_Poster
            // 
            this.Txtb_Poster.Location = new System.Drawing.Point(83, 150);
            this.Txtb_Poster.Name = "Txtb_Poster";
            this.Txtb_Poster.Size = new System.Drawing.Size(100, 20);
            this.Txtb_Poster.TabIndex = 2;
            // 
            // Txtb_Sal
            // 
            this.Txtb_Sal.Location = new System.Drawing.Point(254, 105);
            this.Txtb_Sal.Name = "Txtb_Sal";
            this.Txtb_Sal.Size = new System.Drawing.Size(100, 20);
            this.Txtb_Sal.TabIndex = 5;
            // 
            // Txtb_pop
            // 
            this.Txtb_pop.Location = new System.Drawing.Point(254, 60);
            this.Txtb_pop.Name = "Txtb_pop";
            this.Txtb_pop.Size = new System.Drawing.Size(100, 20);
            this.Txtb_pop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genrer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bild";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "popularitet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_SaveFilm
            // 
            this.Btn_SaveFilm.Location = new System.Drawing.Point(270, 150);
            this.Btn_SaveFilm.Name = "Btn_SaveFilm";
            this.Btn_SaveFilm.Size = new System.Drawing.Size(75, 20);
            this.Btn_SaveFilm.TabIndex = 13;
            this.Btn_SaveFilm.Text = "Save";
            this.Btn_SaveFilm.UseVisualStyleBackColor = true;
            this.Btn_SaveFilm.Click += new System.EventHandler(this.Btn_SaveFilm_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Location = new System.Drawing.Point(713, 12);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_exit.TabIndex = 14;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Lägg_Till_Filmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_SaveFilm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtb_Sal);
            this.Controls.Add(this.Txtb_pop);
            this.Controls.Add(this.Txtb_Poster);
            this.Controls.Add(this.Txtb_Genrer);
            this.Controls.Add(this.Txtb_Namn);
            this.Name = "Lägg_Till_Filmer";
            this.Text = "Lägg_Till_Filmer";
            this.Load += new System.EventHandler(this.Lägg_Till_Filmer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Txtb_Namn;
        private System.Windows.Forms.TextBox Txtb_Genrer;
        private System.Windows.Forms.TextBox Txtb_Poster;
        private System.Windows.Forms.TextBox Txtb_Sal;
        private System.Windows.Forms.TextBox Txtb_pop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Btn_SaveFilm;
        private System.Windows.Forms.Button Btn_exit;
    }
}