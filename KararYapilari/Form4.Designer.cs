namespace KararYapilari
{
    partial class Form4
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
            this.txtGelenDeger = new System.Windows.Forms.TextBox();
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.txtGelenDeger2 = new System.Windows.Forms.TextBox();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGelenDeger
            // 
            this.txtGelenDeger.Location = new System.Drawing.Point(13, 13);
            this.txtGelenDeger.Name = "txtGelenDeger";
            this.txtGelenDeger.Size = new System.Drawing.Size(155, 20);
            this.txtGelenDeger.TabIndex = 0;
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(13, 65);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(155, 33);
            this.btnOrnek1.TabIndex = 2;
            this.btnOrnek1.Text = "Örnek 1";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.BtnOrnek1_Click);
            // 
            // txtGelenDeger2
            // 
            this.txtGelenDeger2.Location = new System.Drawing.Point(12, 39);
            this.txtGelenDeger2.Name = "txtGelenDeger2";
            this.txtGelenDeger2.Size = new System.Drawing.Size(155, 20);
            this.txtGelenDeger2.TabIndex = 1;
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(13, 104);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(155, 33);
            this.btnOrnek2.TabIndex = 3;
            this.btnOrnek2.Text = "Örnek 2";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.BtnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Location = new System.Drawing.Point(13, 143);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(155, 33);
            this.btnOrnek3.TabIndex = 3;
            this.btnOrnek3.Text = "Örnek 3";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.BtnOrnek3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 254);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Controls.Add(this.txtGelenDeger2);
            this.Controls.Add(this.txtGelenDeger);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGelenDeger;
        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.TextBox txtGelenDeger2;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
    }
}