
namespace vizsgautvonalterv
{
    partial class Form_Gepjarmu
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
            this.dataGridView1_Gepjarmu = new System.Windows.Forms.DataGridView();
            this.button1_Ujjarmu = new System.Windows.Forms.Button();
            this.button2_Adatokfrissites = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Gepjarmu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gépjármű útvonal nyilvántartó program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A nyilvántartásban szereplő gépjármű adatai:";
            // 
            // dataGridView1_Gepjarmu
            // 
            this.dataGridView1_Gepjarmu.AllowUserToAddRows = false;
            this.dataGridView1_Gepjarmu.AllowUserToDeleteRows = false;
            this.dataGridView1_Gepjarmu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Gepjarmu.Location = new System.Drawing.Point(59, 139);
            this.dataGridView1_Gepjarmu.Name = "dataGridView1_Gepjarmu";
            this.dataGridView1_Gepjarmu.ReadOnly = true;
            this.dataGridView1_Gepjarmu.RowHeadersWidth = 51;
            this.dataGridView1_Gepjarmu.RowTemplate.Height = 24;
            this.dataGridView1_Gepjarmu.Size = new System.Drawing.Size(705, 221);
            this.dataGridView1_Gepjarmu.TabIndex = 2;
            this.dataGridView1_Gepjarmu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Gepjarmu_CellContentClick);
            // 
            // button1_Ujjarmu
            // 
            this.button1_Ujjarmu.Location = new System.Drawing.Point(59, 398);
            this.button1_Ujjarmu.Name = "button1_Ujjarmu";
            this.button1_Ujjarmu.Size = new System.Drawing.Size(258, 23);
            this.button1_Ujjarmu.TabIndex = 3;
            this.button1_Ujjarmu.Text = "Új jármű felvétele";
            this.button1_Ujjarmu.UseVisualStyleBackColor = true;
            this.button1_Ujjarmu.Click += new System.EventHandler(this.button1_Ujjarmu_Click);
            // 
            // button2_Adatokfrissites
            // 
            this.button2_Adatokfrissites.Location = new System.Drawing.Point(516, 397);
            this.button2_Adatokfrissites.Name = "button2_Adatokfrissites";
            this.button2_Adatokfrissites.Size = new System.Drawing.Size(237, 23);
            this.button2_Adatokfrissites.TabIndex = 4;
            this.button2_Adatokfrissites.Text = "Adatok frissítése";
            this.button2_Adatokfrissites.UseVisualStyleBackColor = true;
            this.button2_Adatokfrissites.Click += new System.EventHandler(this.button2_Adatokfrissites_Click);
            // 
            // Form_Gepjarmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Adatokfrissites);
            this.Controls.Add(this.button1_Ujjarmu);
            this.Controls.Add(this.dataGridView1_Gepjarmu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Gepjarmu";
            this.Text = "Gépjármű";
            this.Load += new System.EventHandler(this.Form_Gepjarmu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Gepjarmu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_Gepjarmu;
        private System.Windows.Forms.Button button1_Ujjarmu;
        private System.Windows.Forms.Button button2_Adatokfrissites;
    }
}

