namespace KararYapilari
{
    partial class Form2
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
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtGelenDeger2 = new System.Windows.Forms.TextBox();
            this.txtGelenDeger1 = new System.Windows.Forms.TextBox();
            this.btn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 314);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(160, 40);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "SATIŞ İŞLEMLERİ";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 268);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(160, 40);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "MARKET KONTROLÜ";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 222);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(160, 40);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "NOT KONTROLU";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 130);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(160, 40);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "GİRİŞ BİLGİSİ KONTROLÜ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // txtGelenDeger2
            // 
            this.txtGelenDeger2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGelenDeger2.Location = new System.Drawing.Point(12, 75);
            this.txtGelenDeger2.Multiline = true;
            this.txtGelenDeger2.Name = "txtGelenDeger2";
            this.txtGelenDeger2.Size = new System.Drawing.Size(160, 49);
            this.txtGelenDeger2.TabIndex = 2;
            // 
            // txtGelenDeger1
            // 
            this.txtGelenDeger1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGelenDeger1.Location = new System.Drawing.Point(12, 20);
            this.txtGelenDeger1.Multiline = true;
            this.txtGelenDeger1.Name = "txtGelenDeger1";
            this.txtGelenDeger1.Size = new System.Drawing.Size(160, 49);
            this.txtGelenDeger1.TabIndex = 2;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(12, 176);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(160, 40);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "GİRİŞ BİLGİSİ KONTROLÜ";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 366);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtGelenDeger1);
            this.Controls.Add(this.txtGelenDeger2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtGelenDeger2;
        private System.Windows.Forms.TextBox txtGelenDeger1;
        private System.Windows.Forms.Button btn5;
    }
}