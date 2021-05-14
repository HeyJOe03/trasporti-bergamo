
namespace noleggio_veicoli_VS
{
    partial class Noleggio
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
            this.LBLinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLinfo
            // 
            this.LBLinfo.AutoSize = true;
            this.LBLinfo.Location = new System.Drawing.Point(48, 38);
            this.LBLinfo.Name = "LBLinfo";
            this.LBLinfo.Size = new System.Drawing.Size(0, 17);
            this.LBLinfo.TabIndex = 0;
            // 
            // Noleggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLinfo);
            this.Name = "Noleggio";
            this.Text = "Noleggio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLinfo;
    }
}