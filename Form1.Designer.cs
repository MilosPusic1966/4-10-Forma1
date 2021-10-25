
namespace _4_10_Forma1
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_ocena = new System.Windows.Forms.TextBox();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_ocena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(216, 59);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(82, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(172, 66);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(216, 103);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(100, 20);
            this.txt_ime.TabIndex = 2;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(216, 144);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(100, 20);
            this.txt_prezime.TabIndex = 3;
            // 
            // txt_ocena
            // 
            this.txt_ocena.Location = new System.Drawing.Point(216, 188);
            this.txt_ocena.Name = "txt_ocena";
            this.txt_ocena.Size = new System.Drawing.Size(100, 20);
            this.txt_ocena.TabIndex = 4;
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(166, 110);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(24, 13);
            this.lbl_ime.TabIndex = 5;
            this.lbl_ime.Text = "Ime";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Location = new System.Drawing.Point(155, 151);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(44, 13);
            this.lbl_prezime.TabIndex = 6;
            this.lbl_prezime.Text = "Prezime";
            // 
            // lbl_ocena
            // 
            this.lbl_ocena.AutoSize = true;
            this.lbl_ocena.Location = new System.Drawing.Point(155, 195);
            this.lbl_ocena.Name = "lbl_ocena";
            this.lbl_ocena.Size = new System.Drawing.Size(39, 13);
            this.lbl_ocena.TabIndex = 7;
            this.lbl_ocena.Text = "Ocena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ocena);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.txt_ocena);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_ocena;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_ocena;
    }
}

