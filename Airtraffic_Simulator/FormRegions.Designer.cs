namespace Airtraffic_Simulator
{
    partial class FormRegions
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
            this.btnEurope = new System.Windows.Forms.Button();
            this.btnAustralia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEurope
            // 
            this.btnEurope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEurope.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEurope.Location = new System.Drawing.Point(174, 116);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(94, 41);
            this.btnEurope.TabIndex = 0;
            this.btnEurope.Text = "Europe";
            this.btnEurope.UseVisualStyleBackColor = false;
            this.btnEurope.Click += new System.EventHandler(this.btnEurope_Click);
            // 
            // btnAustralia
            // 
            this.btnAustralia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAustralia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAustralia.Location = new System.Drawing.Point(174, 168);
            this.btnAustralia.Name = "btnAustralia";
            this.btnAustralia.Size = new System.Drawing.Size(94, 41);
            this.btnAustralia.TabIndex = 1;
            this.btnAustralia.Text = "Australia";
            this.btnAustralia.UseVisualStyleBackColor = false;
            this.btnAustralia.Click += new System.EventHandler(this.btnAustralia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please, select the region you would like to load:";
            // 
            // FormRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAustralia);
            this.Controls.Add(this.btnEurope);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegions";
            this.Text = "Regions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.Button btnAustralia;
        private System.Windows.Forms.Label label1;
    }
}