namespace winform_trenlop
{
    partial class combobox1
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
            this.cbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbb
            // 
            this.cbb.FormattingEnabled = true;
            this.cbb.Location = new System.Drawing.Point(204, 137);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(121, 24);
            this.cbb.TabIndex = 0;
            // 
            // combobox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb);
            this.Name = "combobox1";
            this.Text = "combobox1";
            this.Load += new System.EventHandler(this.combobox1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb;
    }
}