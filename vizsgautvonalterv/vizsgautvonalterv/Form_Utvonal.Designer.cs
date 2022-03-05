
namespace vizsgautvonalterv
{
    partial class Form_Utvonal
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
            this.dataGridView1_Utvonal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_Osszeskm = new System.Windows.Forms.TextBox();
            this.textBox2_Osszesfogyasztas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Utvonal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A kiválasztott gépjármű útvonalai, megtett kilóméter és fogyasztás adatai\r\n";
            // 
            // dataGridView1_Utvonal
            // 
            this.dataGridView1_Utvonal.AllowUserToAddRows = false;
            this.dataGridView1_Utvonal.AllowUserToDeleteRows = false;
            this.dataGridView1_Utvonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Utvonal.Location = new System.Drawing.Point(48, 102);
            this.dataGridView1_Utvonal.Name = "dataGridView1_Utvonal";
            this.dataGridView1_Utvonal.ReadOnly = true;
            this.dataGridView1_Utvonal.RowHeadersWidth = 51;
            this.dataGridView1_Utvonal.RowTemplate.Height = 24;
            this.dataGridView1_Utvonal.Size = new System.Drawing.Size(711, 234);
            this.dataGridView1_Utvonal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Összesen megtett út hossza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Összes fogyasztás:";
            // 
            // textBox1_Osszeskm
            // 
            this.textBox1_Osszeskm.Location = new System.Drawing.Point(455, 365);
            this.textBox1_Osszeskm.Name = "textBox1_Osszeskm";
            this.textBox1_Osszeskm.Size = new System.Drawing.Size(143, 22);
            this.textBox1_Osszeskm.TabIndex = 4;
            // 
            // textBox2_Osszesfogyasztas
            // 
            this.textBox2_Osszesfogyasztas.Location = new System.Drawing.Point(455, 416);
            this.textBox2_Osszesfogyasztas.Name = "textBox2_Osszesfogyasztas";
            this.textBox2_Osszesfogyasztas.Size = new System.Drawing.Size(143, 22);
            this.textBox2_Osszesfogyasztas.TabIndex = 5;
            // 
            // Form_Utvonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.textBox2_Osszesfogyasztas);
            this.Controls.Add(this.textBox1_Osszeskm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_Utvonal);
            this.Controls.Add(this.label1);
            this.Name = "Form_Utvonal";
            this.Text = "Form_Utvonal";
            this.Load += new System.EventHandler(this.Form_Utvonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Utvonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1_Utvonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_Osszeskm;
        private System.Windows.Forms.TextBox textBox2_Osszesfogyasztas;
    }
}