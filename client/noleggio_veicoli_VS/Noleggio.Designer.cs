
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
            this.components = new System.ComponentModel.Container();
            this.LBLinfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTNnoleggio = new System.Windows.Forms.Button();
            this.LBLtime = new System.Windows.Forms.Label();
            this.LBLprice = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "View on Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNnoleggio
            // 
            this.BTNnoleggio.Location = new System.Drawing.Point(552, 143);
            this.BTNnoleggio.Name = "BTNnoleggio";
            this.BTNnoleggio.Size = new System.Drawing.Size(132, 43);
            this.BTNnoleggio.TabIndex = 2;
            this.BTNnoleggio.Tag = "d";
            this.BTNnoleggio.Text = "Avvia il noleggio";
            this.BTNnoleggio.UseVisualStyleBackColor = true;
            this.BTNnoleggio.Click += new System.EventHandler(this.BTNnoleggio_Click);
            // 
            // LBLtime
            // 
            this.LBLtime.AutoSize = true;
            this.LBLtime.Location = new System.Drawing.Point(552, 235);
            this.LBLtime.Name = "LBLtime";
            this.LBLtime.Size = new System.Drawing.Size(64, 17);
            this.LBLtime.TabIndex = 3;
            this.LBLtime.Text = "00:00:00";
            // 
            // LBLprice
            // 
            this.LBLprice.AutoSize = true;
            this.LBLprice.Location = new System.Drawing.Point(552, 283);
            this.LBLprice.Name = "LBLprice";
            this.LBLprice.Size = new System.Drawing.Size(88, 17);
            this.LBLprice.TabIndex = 4;
            this.LBLprice.Text = "Costo: €0.00";
            // 
            // Noleggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLprice);
            this.Controls.Add(this.LBLtime);
            this.Controls.Add(this.BTNnoleggio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBLinfo);
            this.Name = "Noleggio";
            this.Text = "Noleggio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTNnoleggio;
        private System.Windows.Forms.Label LBLtime;
        private System.Windows.Forms.Label LBLprice;
    }
}