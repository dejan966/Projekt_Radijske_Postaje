
namespace Radijske_Postaje
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
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Reg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Urejanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urejanje radijskih postaj v Sloveniji";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(465, 90);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(116, 29);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Prijava";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Location = new System.Drawing.Point(313, 90);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(116, 30);
            this.Btn_Reg.TabIndex = 4;
            this.Btn_Reg.Text = "Registracija";
            this.Btn_Reg.UseVisualStyleBackColor = true;
            this.Btn_Reg.Click += new System.EventHandler(this.Btn_Reg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Odjava";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(350, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "lebel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Srednja šola\\4.letnik\\Mušič\\na daljvo\\Mini projekt\\slika.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(45, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Urejanje
            // 
            this.Btn_Urejanje.Location = new System.Drawing.Point(583, 416);
            this.Btn_Urejanje.Name = "Btn_Urejanje";
            this.Btn_Urejanje.Size = new System.Drawing.Size(95, 32);
            this.Btn_Urejanje.TabIndex = 8;
            this.Btn_Urejanje.Text = "Urejanje";
            this.Btn_Urejanje.UseVisualStyleBackColor = true;
            this.Btn_Urejanje.Click += new System.EventHandler(this.Btn_Urejanje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 460);
            this.Controls.Add(this.Btn_Urejanje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Reg);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Začetna stran";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Reg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Urejanje;
    }
}

