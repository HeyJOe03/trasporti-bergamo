
namespace noleggio_veicoli_VS
{
    partial class veicoli_disponibili
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BrowserMap = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.veicoliCHECK = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1032, 410);
            this.webBrowser1.TabIndex = 1;
            // 
            // BrowserMap
            // 
            this.BrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserMap.Location = new System.Drawing.Point(0, 0);
            this.BrowserMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.BrowserMap.Name = "BrowserMap";
            this.BrowserMap.Size = new System.Drawing.Size(1032, 410);
            this.BrowserMap.TabIndex = 2;
            this.BrowserMap.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // veicoliCHECK
            // 
            this.veicoliCHECK.FormattingEnabled = true;
            this.veicoliCHECK.Items.AddRange(new object[] {
            "auto elettrica",
            "monopattino elettrico",
            "motorino elettrico",
            "bici",
            "e-bike"});
            this.veicoliCHECK.Location = new System.Drawing.Point(32, 31);
            this.veicoliCHECK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.veicoliCHECK.Name = "veicoliCHECK";
            this.veicoliCHECK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.veicoliCHECK.Size = new System.Drawing.Size(197, 89);
            this.veicoliCHECK.TabIndex = 7;
            this.veicoliCHECK.SelectedIndexChanged += new System.EventHandler(this.veicoliCHECK_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(305, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(620, 308);
            this.listBox1.TabIndex = 9;
            // 
            // veicoli_disponibili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 410);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.veicoliCHECK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BrowserMap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "veicoli_disponibili";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser BrowserMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox veicoliCHECK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

