namespace Refactoring
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNominal = new System.Windows.Forms.TextBox();
            this.hasilKonversi = new System.Windows.Forms.ListBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            // 
            // inputNominal
            // 
            this.inputNominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputNominal.Location = new System.Drawing.Point(108, 30);
            this.inputNominal.Name = "inputNominal";
            this.inputNominal.Size = new System.Drawing.Size(177, 26);
            this.inputNominal.TabIndex = 2;
            // 
            // hasilKonversi
            // 
            this.hasilKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hasilKonversi.FormattingEnabled = true;
            this.hasilKonversi.ItemHeight = 20;
            this.hasilKonversi.Location = new System.Drawing.Point(108, 85);
            this.hasilKonversi.Name = "hasilKonversi";
            this.hasilKonversi.Size = new System.Drawing.Size(379, 144);
            this.hasilKonversi.TabIndex = 3;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKonversi.Location = new System.Drawing.Point(319, 28);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(75, 30);
            this.btnKonversi.TabIndex = 4;
            this.btnKonversi.Text = "Cek Terbilang";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.hasilKonversi);
            this.Controls.Add(this.inputNominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNominal;
        private System.Windows.Forms.ListBox hasilKonversi;
        private System.Windows.Forms.Button btnKonversi;
    }
}

