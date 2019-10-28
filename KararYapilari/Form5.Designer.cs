namespace KararYapilari
{
    partial class Form5
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
            this.btnOrnek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGelenDeger
            // 
            this.txtGelenDeger.Location = new System.Drawing.Point(13, 13);
            this.txtGelenDeger.Name = "txtGelenDeger";
            this.txtGelenDeger.Size = new System.Drawing.Size(146, 20);
            this.txtGelenDeger.TabIndex = 0;
            // 
            // btnOrnek
            // 
            this.btnOrnek.Location = new System.Drawing.Point(13, 40);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(146, 38);
            this.btnOrnek.TabIndex = 1;
            this.btnOrnek.Text = "Örnek";
            this.btnOrnek.UseVisualStyleBackColor = true;
            this.btnOrnek.Click += new System.EventHandler(this.BtnOrnek_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 98);
            this.Controls.Add(this.btnOrnek);
            this.Controls.Add(this.txtGelenDeger);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGelenDeger;
        private System.Windows.Forms.Button btnOrnek;
    }
}