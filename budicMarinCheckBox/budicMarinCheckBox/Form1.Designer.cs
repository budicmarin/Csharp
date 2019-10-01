namespace budicMarinCheckBox
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
            this.checkBoxDorucak = new System.Windows.Forms.CheckBox();
            this.checkBoxRucak = new System.Windows.Forms.CheckBox();
            this.checkBoxVecera = new System.Windows.Forms.CheckBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.checkSakriNarudzbu = new System.Windows.Forms.CheckBox();
            this.textBoxOdabrali = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxDorucak
            // 
            this.checkBoxDorucak.AutoSize = true;
            this.checkBoxDorucak.Location = new System.Drawing.Point(12, 106);
            this.checkBoxDorucak.Name = "checkBoxDorucak";
            this.checkBoxDorucak.Size = new System.Drawing.Size(83, 21);
            this.checkBoxDorucak.TabIndex = 0;
            this.checkBoxDorucak.Text = "Doručak";
            this.checkBoxDorucak.UseVisualStyleBackColor = true;
            this.checkBoxDorucak.CheckedChanged += new System.EventHandler(this.CheckBoxDorucak_CheckedChanged);
            // 
            // checkBoxRucak
            // 
            this.checkBoxRucak.AutoSize = true;
            this.checkBoxRucak.Location = new System.Drawing.Point(12, 133);
            this.checkBoxRucak.Name = "checkBoxRucak";
            this.checkBoxRucak.Size = new System.Drawing.Size(70, 21);
            this.checkBoxRucak.TabIndex = 1;
            this.checkBoxRucak.Text = "Ručak";
            this.checkBoxRucak.UseVisualStyleBackColor = true;
            this.checkBoxRucak.CheckedChanged += new System.EventHandler(this.CheckBoxRucak_CheckedChanged);
            // 
            // checkBoxVecera
            // 
            this.checkBoxVecera.AutoSize = true;
            this.checkBoxVecera.Location = new System.Drawing.Point(12, 160);
            this.checkBoxVecera.Name = "checkBoxVecera";
            this.checkBoxVecera.Size = new System.Drawing.Size(75, 21);
            this.checkBoxVecera.TabIndex = 2;
            this.checkBoxVecera.Text = "Večera";
            this.checkBoxVecera.UseVisualStyleBackColor = true;
            this.checkBoxVecera.CheckedChanged += new System.EventHandler(this.CheckBoxVecera_CheckedChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(365, 379);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(247, 51);
            this.btnPosalji.TabIndex = 3;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.BtnPosalji_Click);
            // 
            // checkSakriNarudzbu
            // 
            this.checkSakriNarudzbu.AutoSize = true;
            this.checkSakriNarudzbu.Location = new System.Drawing.Point(417, 352);
            this.checkSakriNarudzbu.Name = "checkSakriNarudzbu";
            this.checkSakriNarudzbu.Size = new System.Drawing.Size(126, 21);
            this.checkSakriNarudzbu.TabIndex = 4;
            this.checkSakriNarudzbu.Text = "Sakri narudžbu";
            this.checkSakriNarudzbu.UseVisualStyleBackColor = true;
            this.checkSakriNarudzbu.CheckedChanged += new System.EventHandler(this.CheckSakriNarudzbu_CheckedChanged);
            // 
            // textBoxOdabrali
            // 
            this.textBoxOdabrali.Location = new System.Drawing.Point(173, 12);
            this.textBoxOdabrali.Multiline = true;
            this.textBoxOdabrali.Name = "textBoxOdabrali";
            this.textBoxOdabrali.Size = new System.Drawing.Size(517, 334);
            this.textBoxOdabrali.TabIndex = 5;
            this.textBoxOdabrali.TextChanged += new System.EventHandler(this.TextBoxOdabraliSte_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 442);
            this.Controls.Add(this.textBoxOdabrali);
            this.Controls.Add(this.checkSakriNarudzbu);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.checkBoxVecera);
            this.Controls.Add(this.checkBoxRucak);
            this.Controls.Add(this.checkBoxDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDorucak;
        private System.Windows.Forms.CheckBox checkBoxRucak;
        private System.Windows.Forms.CheckBox checkBoxVecera;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.CheckBox checkSakriNarudzbu;
        private System.Windows.Forms.TextBox textBoxOdabrali;
    }
}

