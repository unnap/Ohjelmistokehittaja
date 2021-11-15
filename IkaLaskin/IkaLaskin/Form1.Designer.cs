namespace IkaLaskin
{
    partial class BDayLaskinFM
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
            this.bdayDT = new System.Windows.Forms.DateTimePicker();
            this.vuodetLB = new System.Windows.Forms.Label();
            this.kuukaudetLB = new System.Windows.Forms.Label();
            this.paivatLB = new System.Windows.Forms.Label();
            this.tunnitLB = new System.Windows.Forms.Label();
            this.minuutitLB = new System.Windows.Forms.Label();
            this.sekunnitLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bdayDT
            // 
            this.bdayDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayDT.Location = new System.Drawing.Point(41, 31);
            this.bdayDT.Name = "bdayDT";
            this.bdayDT.Size = new System.Drawing.Size(200, 26);
            this.bdayDT.TabIndex = 0;
            // 
            // vuodetLB
            // 
            this.vuodetLB.AutoSize = true;
            this.vuodetLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vuodetLB.Location = new System.Drawing.Point(39, 74);
            this.vuodetLB.Name = "vuodetLB";
            this.vuodetLB.Size = new System.Drawing.Size(57, 20);
            this.vuodetLB.TabIndex = 1;
            this.vuodetLB.Text = "vuodet";
            this.vuodetLB.Visible = false;
            // 
            // kuukaudetLB
            // 
            this.kuukaudetLB.AutoSize = true;
            this.kuukaudetLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuukaudetLB.Location = new System.Drawing.Point(207, 74);
            this.kuukaudetLB.Name = "kuukaudetLB";
            this.kuukaudetLB.Size = new System.Drawing.Size(25, 20);
            this.kuukaudetLB.TabIndex = 2;
            this.kuukaudetLB.Text = "kk";
            this.kuukaudetLB.Visible = false;
            // 
            // paivatLB
            // 
            this.paivatLB.AutoSize = true;
            this.paivatLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivatLB.Location = new System.Drawing.Point(39, 94);
            this.paivatLB.Name = "paivatLB";
            this.paivatLB.Size = new System.Drawing.Size(51, 20);
            this.paivatLB.TabIndex = 3;
            this.paivatLB.Text = "päivät";
            this.paivatLB.Visible = false;
            // 
            // tunnitLB
            // 
            this.tunnitLB.AutoSize = true;
            this.tunnitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunnitLB.Location = new System.Drawing.Point(207, 94);
            this.tunnitLB.Name = "tunnitLB";
            this.tunnitLB.Size = new System.Drawing.Size(49, 20);
            this.tunnitLB.TabIndex = 4;
            this.tunnitLB.Text = "tunnit";
            this.tunnitLB.Visible = false;
            // 
            // minuutitLB
            // 
            this.minuutitLB.AutoSize = true;
            this.minuutitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuutitLB.Location = new System.Drawing.Point(39, 114);
            this.minuutitLB.Name = "minuutitLB";
            this.minuutitLB.Size = new System.Drawing.Size(34, 20);
            this.minuutitLB.TabIndex = 5;
            this.minuutitLB.Text = "min";
            this.minuutitLB.Visible = false;
            // 
            // sekunnitLB
            // 
            this.sekunnitLB.AutoSize = true;
            this.sekunnitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekunnitLB.Location = new System.Drawing.Point(207, 114);
            this.sekunnitLB.Name = "sekunnitLB";
            this.sekunnitLB.Size = new System.Drawing.Size(17, 20);
            this.sekunnitLB.TabIndex = 6;
            this.sekunnitLB.Text = "s";
            this.sekunnitLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeBT.Location = new System.Drawing.Point(263, 31);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(77, 26);
            this.LaskeBT.TabIndex = 7;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // BDayLaskinFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 226);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.sekunnitLB);
            this.Controls.Add(this.minuutitLB);
            this.Controls.Add(this.tunnitLB);
            this.Controls.Add(this.paivatLB);
            this.Controls.Add(this.kuukaudetLB);
            this.Controls.Add(this.vuodetLB);
            this.Controls.Add(this.bdayDT);
            this.Name = "BDayLaskinFM";
            this.Text = "Synttäri Laskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker bdayDT;
        private System.Windows.Forms.Label vuodetLB;
        private System.Windows.Forms.Label kuukaudetLB;
        private System.Windows.Forms.Label paivatLB;
        private System.Windows.Forms.Label tunnitLB;
        private System.Windows.Forms.Label minuutitLB;
        private System.Windows.Forms.Label sekunnitLB;
        private System.Windows.Forms.Button LaskeBT;
    }
}

