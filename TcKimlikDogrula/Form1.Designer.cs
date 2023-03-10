namespace TcKimlikDogrula
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
            this.TcTextBox = new System.Windows.Forms.TextBox();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.YilTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SorguButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TcTextBox
            // 
            this.TcTextBox.Location = new System.Drawing.Point(114, 51);
            this.TcTextBox.Name = "TcTextBox";
            this.TcTextBox.Size = new System.Drawing.Size(180, 20);
            this.TcTextBox.TabIndex = 0;
            // 
            // AdTextBox
            // 
            this.AdTextBox.Location = new System.Drawing.Point(114, 77);
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(180, 20);
            this.AdTextBox.TabIndex = 1;
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Location = new System.Drawing.Point(114, 103);
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(180, 20);
            this.SoyadTextBox.TabIndex = 2;
            // 
            // YilTextBox
            // 
            this.YilTextBox.Location = new System.Drawing.Point(114, 129);
            this.YilTextBox.Name = "YilTextBox";
            this.YilTextBox.Size = new System.Drawing.Size(180, 20);
            this.YilTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOĞUM YILI";
            // 
            // SorguButton
            // 
            this.SorguButton.Location = new System.Drawing.Point(143, 170);
            this.SorguButton.Name = "SorguButton";
            this.SorguButton.Size = new System.Drawing.Size(112, 23);
            this.SorguButton.TabIndex = 8;
            this.SorguButton.Text = "Kontrol Et";
            this.SorguButton.UseVisualStyleBackColor = true;
            this.SorguButton.Click += new System.EventHandler(this.SorguButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 272);
            this.Controls.Add(this.SorguButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YilTextBox);
            this.Controls.Add(this.SoyadTextBox);
            this.Controls.Add(this.AdTextBox);
            this.Controls.Add(this.TcTextBox);
            this.Name = "Form1";
            this.Text = "Tc Kimlik Doğrulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TcTextBox;
        private System.Windows.Forms.TextBox AdTextBox;
        private System.Windows.Forms.TextBox SoyadTextBox;
        private System.Windows.Forms.TextBox YilTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SorguButton;
    }
}

