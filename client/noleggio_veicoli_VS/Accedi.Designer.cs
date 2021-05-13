
namespace noleggio_veicoli_VS
{
    partial class Accedi
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
            this.lblCF = new System.Windows.Forms.Label();
            this.LBLdocumento = new System.Windows.Forms.Label();
            this.TXBCF = new System.Windows.Forms.TextBox();
            this.TXBdocumento = new System.Windows.Forms.TextBox();
            this.CalendarNascita = new System.Windows.Forms.MonthCalendar();
            this.RBaccedi = new System.Windows.Forms.RadioButton();
            this.RBregistrati = new System.Windows.Forms.RadioButton();
            this.BTNinvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCF
            // 
            this.lblCF.AutoSize = true;
            this.lblCF.Location = new System.Drawing.Point(52, 79);
            this.lblCF.Name = "lblCF";
            this.lblCF.Size = new System.Drawing.Size(99, 17);
            this.lblCF.TabIndex = 0;
            this.lblCF.Text = "Codice Fiscale";
            // 
            // LBLdocumento
            // 
            this.LBLdocumento.AutoSize = true;
            this.LBLdocumento.Location = new System.Drawing.Point(52, 158);
            this.LBLdocumento.Name = "LBLdocumento";
            this.LBLdocumento.Size = new System.Drawing.Size(80, 17);
            this.LBLdocumento.TabIndex = 1;
            this.LBLdocumento.Text = "Documento";
            // 
            // TXBCF
            // 
            this.TXBCF.Location = new System.Drawing.Point(55, 109);
            this.TXBCF.Name = "TXBCF";
            this.TXBCF.Size = new System.Drawing.Size(306, 22);
            this.TXBCF.TabIndex = 2;
            // 
            // TXBdocumento
            // 
            this.TXBdocumento.Location = new System.Drawing.Point(55, 194);
            this.TXBdocumento.Name = "TXBdocumento";
            this.TXBdocumento.Size = new System.Drawing.Size(306, 22);
            this.TXBdocumento.TabIndex = 3;
            // 
            // CalendarNascita
            // 
            this.CalendarNascita.Location = new System.Drawing.Point(55, 234);
            this.CalendarNascita.Name = "CalendarNascita";
            this.CalendarNascita.TabIndex = 4;
            // 
            // RBaccedi
            // 
            this.RBaccedi.AutoSize = true;
            this.RBaccedi.Checked = true;
            this.RBaccedi.Location = new System.Drawing.Point(438, 130);
            this.RBaccedi.Name = "RBaccedi";
            this.RBaccedi.Size = new System.Drawing.Size(70, 21);
            this.RBaccedi.TabIndex = 5;
            this.RBaccedi.TabStop = true;
            this.RBaccedi.Text = "accedi";
            this.RBaccedi.UseVisualStyleBackColor = true;
            this.RBaccedi.CheckedChanged += new System.EventHandler(this.RBaccedi_CheckedChanged);
            // 
            // RBregistrati
            // 
            this.RBregistrati.AutoSize = true;
            this.RBregistrati.Location = new System.Drawing.Point(438, 174);
            this.RBregistrati.Name = "RBregistrati";
            this.RBregistrati.Size = new System.Drawing.Size(84, 21);
            this.RBregistrati.TabIndex = 6;
            this.RBregistrati.Text = "registrati";
            this.RBregistrati.UseVisualStyleBackColor = true;
            this.RBregistrati.CheckedChanged += new System.EventHandler(this.RBregistrati_CheckedChanged);
            // 
            // BTNinvia
            // 
            this.BTNinvia.Location = new System.Drawing.Point(369, 299);
            this.BTNinvia.Name = "BTNinvia";
            this.BTNinvia.Size = new System.Drawing.Size(153, 68);
            this.BTNinvia.TabIndex = 7;
            this.BTNinvia.Text = "INVIA";
            this.BTNinvia.UseVisualStyleBackColor = true;
            // 
            // Accedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 512);
            this.Controls.Add(this.BTNinvia);
            this.Controls.Add(this.RBregistrati);
            this.Controls.Add(this.RBaccedi);
            this.Controls.Add(this.CalendarNascita);
            this.Controls.Add(this.TXBdocumento);
            this.Controls.Add(this.TXBCF);
            this.Controls.Add(this.LBLdocumento);
            this.Controls.Add(this.lblCF);
            this.Name = "Accedi";
            this.Text = "Accedi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCF;
        private System.Windows.Forms.Label LBLdocumento;
        private System.Windows.Forms.TextBox TXBCF;
        private System.Windows.Forms.TextBox TXBdocumento;
        private System.Windows.Forms.MonthCalendar CalendarNascita;
        private System.Windows.Forms.RadioButton RBaccedi;
        private System.Windows.Forms.RadioButton RBregistrati;
        private System.Windows.Forms.Button BTNinvia;
    }
}