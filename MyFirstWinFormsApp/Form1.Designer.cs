namespace MyFirstWinFormsApp
{
    partial class frmHallo
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
            this.cmdHallo = new System.Windows.Forms.Button();
            this.cmdEnde = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdHallo
            // 
            this.cmdHallo.Location = new System.Drawing.Point(16, 50);
            this.cmdHallo.Name = "cmdHallo";
            this.cmdHallo.Size = new System.Drawing.Size(75, 23);
            this.cmdHallo.TabIndex = 0;
            this.cmdHallo.Text = "Hallo";
            this.cmdHallo.UseVisualStyleBackColor = true;
            this.cmdHallo.Click += new System.EventHandler(this.cmdHallo_Click);
            // 
            // cmdEnde
            // 
            this.cmdEnde.Location = new System.Drawing.Point(16, 89);
            this.cmdEnde.Name = "cmdEnde";
            this.cmdEnde.Size = new System.Drawing.Size(75, 23);
            this.cmdEnde.TabIndex = 1;
            this.cmdEnde.Text = "ENDE";
            this.cmdEnde.UseVisualStyleBackColor = true;
            this.cmdEnde.Click += new System.EventHandler(this.cmdEnde_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnzeige.Location = new System.Drawing.Point(37, 19);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(32, 15);
            this.lblAnzeige.TabIndex = 2;
            this.lblAnzeige.Text = "(leer)";
            // 
            // frmHallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdEnde);
            this.Controls.Add(this.cmdHallo);
            this.Name = "frmHallo";
            this.Text = "Hallo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdHallo;
        private System.Windows.Forms.Button cmdEnde;
        private System.Windows.Forms.Label lblAnzeige;
    }
}

