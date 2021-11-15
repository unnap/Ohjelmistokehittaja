namespace tokaGraafinen
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.PainikeBT = new System.Windows.Forms.Button();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.OhjetekstiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.Location = new System.Drawing.Point(86, 116);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(57, 21);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "label1";
            this.OtsikkoLB.Visible = false;
            // 
            // PainikeBT
            // 
            this.PainikeBT.Location = new System.Drawing.Point(80, 76);
            this.PainikeBT.Name = "PainikeBT";
            this.PainikeBT.Size = new System.Drawing.Size(112, 23);
            this.PainikeBT.TabIndex = 1;
            this.PainikeBT.Text = "Vaihda teksti";
            this.PainikeBT.UseVisualStyleBackColor = true;
            this.PainikeBT.Click += new System.EventHandler(this.PainikeBT_Click);
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(80, 40);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(100, 20);
            this.TekstiTB.TabIndex = 2;
            // 
            // OhjetekstiLB
            // 
            this.OhjetekstiLB.AutoSize = true;
            this.OhjetekstiLB.Location = new System.Drawing.Point(77, 24);
            this.OhjetekstiLB.Name = "OhjetekstiLB";
            this.OhjetekstiLB.Size = new System.Drawing.Size(66, 13);
            this.OhjetekstiLB.TabIndex = 3;
            this.OhjetekstiLB.Text = "Kirjoita jotain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 238);
            this.Controls.Add(this.OhjetekstiLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.PainikeBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button PainikeBT;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label OhjetekstiLB;
    }
}

