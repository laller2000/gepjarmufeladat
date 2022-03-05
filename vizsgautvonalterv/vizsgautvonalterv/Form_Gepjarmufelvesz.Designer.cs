
namespace vizsgautvonalterv
{
    partial class Form_Gepjarmufelvesz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1_Rogzit = new System.Windows.Forms.Button();
            this.textBox1_Rendszam = new System.Windows.Forms.TextBox();
            this.textBox2_Marka = new System.Windows.Forms.TextBox();
            this.textBox3_Tipus = new System.Windows.Forms.TextBox();
            this.textBox4_Tulajdonos = new System.Windows.Forms.TextBox();
            this.textBox5_Fogyasztas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Márka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Típus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tulajdonos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fogyasztás:";
            // 
            // button1_Rogzit
            // 
            this.button1_Rogzit.Location = new System.Drawing.Point(384, 383);
            this.button1_Rogzit.Name = "button1_Rogzit";
            this.button1_Rogzit.Size = new System.Drawing.Size(108, 54);
            this.button1_Rogzit.TabIndex = 5;
            this.button1_Rogzit.Text = "Rögzít";
            this.button1_Rogzit.UseVisualStyleBackColor = true;
            this.button1_Rogzit.Click += new System.EventHandler(this.button1_Rogzit_Click);
            // 
            // textBox1_Rendszam
            // 
            this.textBox1_Rendszam.Location = new System.Drawing.Point(307, 55);
            this.textBox1_Rendszam.Name = "textBox1_Rendszam";
            this.textBox1_Rendszam.Size = new System.Drawing.Size(266, 22);
            this.textBox1_Rendszam.TabIndex = 6;
            // 
            // textBox2_Marka
            // 
            this.textBox2_Marka.Location = new System.Drawing.Point(307, 130);
            this.textBox2_Marka.Name = "textBox2_Marka";
            this.textBox2_Marka.Size = new System.Drawing.Size(266, 22);
            this.textBox2_Marka.TabIndex = 7;
            // 
            // textBox3_Tipus
            // 
            this.textBox3_Tipus.Location = new System.Drawing.Point(307, 212);
            this.textBox3_Tipus.Name = "textBox3_Tipus";
            this.textBox3_Tipus.Size = new System.Drawing.Size(266, 22);
            this.textBox3_Tipus.TabIndex = 8;
            // 
            // textBox4_Tulajdonos
            // 
            this.textBox4_Tulajdonos.Location = new System.Drawing.Point(307, 282);
            this.textBox4_Tulajdonos.Name = "textBox4_Tulajdonos";
            this.textBox4_Tulajdonos.Size = new System.Drawing.Size(266, 22);
            this.textBox4_Tulajdonos.TabIndex = 9;
            // 
            // textBox5_Fogyasztas
            // 
            this.textBox5_Fogyasztas.Location = new System.Drawing.Point(307, 339);
            this.textBox5_Fogyasztas.Name = "textBox5_Fogyasztas";
            this.textBox5_Fogyasztas.Size = new System.Drawing.Size(266, 22);
            this.textBox5_Fogyasztas.TabIndex = 10;
            // 
            // Form_Gepjarmufelvesz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.textBox5_Fogyasztas);
            this.Controls.Add(this.textBox4_Tulajdonos);
            this.Controls.Add(this.textBox3_Tipus);
            this.Controls.Add(this.textBox2_Marka);
            this.Controls.Add(this.textBox1_Rendszam);
            this.Controls.Add(this.button1_Rogzit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Gepjarmufelvesz";
            this.Text = "Form_Gepjarmufelvesz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1_Rogzit;
        private System.Windows.Forms.TextBox textBox1_Rendszam;
        private System.Windows.Forms.TextBox textBox2_Marka;
        private System.Windows.Forms.TextBox textBox3_Tipus;
        private System.Windows.Forms.TextBox textBox4_Tulajdonos;
        private System.Windows.Forms.TextBox textBox5_Fogyasztas;
    }
}