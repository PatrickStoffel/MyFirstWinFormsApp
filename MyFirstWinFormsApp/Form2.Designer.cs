namespace MyFirstWinFormsApp
{
    partial class frmButtons
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
            this.cmdPositionRel = new System.Windows.Forms.Button();
            this.cmdPositionAbs = new System.Windows.Forms.Button();
            this.cmdSizeRel = new System.Windows.Forms.Button();
            this.cmdSizeAbs = new System.Windows.Forms.Button();
            this.cmdTest = new System.Windows.Forms.Button();
            this.cmdEnd = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.cmdView = new System.Windows.Forms.Button();
            this.cmdColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPositionRel
            // 
            this.cmdPositionRel.Location = new System.Drawing.Point(12, 12);
            this.cmdPositionRel.Name = "cmdPositionRel";
            this.cmdPositionRel.Size = new System.Drawing.Size(75, 23);
            this.cmdPositionRel.TabIndex = 0;
            this.cmdPositionRel.Text = "Position Rel";
            this.cmdPositionRel.UseVisualStyleBackColor = true;
            this.cmdPositionRel.Click += new System.EventHandler(this.cmdPositionRel_Click);
            // 
            // cmdPositionAbs
            // 
            this.cmdPositionAbs.Location = new System.Drawing.Point(110, 12);
            this.cmdPositionAbs.Name = "cmdPositionAbs";
            this.cmdPositionAbs.Size = new System.Drawing.Size(75, 23);
            this.cmdPositionAbs.TabIndex = 1;
            this.cmdPositionAbs.Text = "Position Abs";
            this.cmdPositionAbs.UseVisualStyleBackColor = true;
            this.cmdPositionAbs.Click += new System.EventHandler(this.cmdPositionAbs_Click);
            // 
            // cmdSizeRel
            // 
            this.cmdSizeRel.Location = new System.Drawing.Point(12, 41);
            this.cmdSizeRel.Name = "cmdSizeRel";
            this.cmdSizeRel.Size = new System.Drawing.Size(75, 23);
            this.cmdSizeRel.TabIndex = 2;
            this.cmdSizeRel.Text = "Grösse Rel";
            this.cmdSizeRel.UseVisualStyleBackColor = true;
            this.cmdSizeRel.Click += new System.EventHandler(this.cmdSizeRel_Click);
            // 
            // cmdSizeAbs
            // 
            this.cmdSizeAbs.Location = new System.Drawing.Point(110, 41);
            this.cmdSizeAbs.Name = "cmdSizeAbs";
            this.cmdSizeAbs.Size = new System.Drawing.Size(75, 23);
            this.cmdSizeAbs.TabIndex = 3;
            this.cmdSizeAbs.Text = "Grösse Abs";
            this.cmdSizeAbs.UseVisualStyleBackColor = true;
            this.cmdSizeAbs.Click += new System.EventHandler(this.cmdSizeAbs_Click);
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(12, 96);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(75, 23);
            this.cmdTest.TabIndex = 4;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            // 
            // cmdEnd
            // 
            this.cmdEnd.Location = new System.Drawing.Point(424, 305);
            this.cmdEnd.Name = "cmdEnd";
            this.cmdEnd.Size = new System.Drawing.Size(75, 23);
            this.cmdEnd.TabIndex = 5;
            this.cmdEnd.Text = "ENDE";
            this.cmdEnd.UseVisualStyleBackColor = true;
            this.cmdEnd.Click += new System.EventHandler(this.cmdEnd_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(271, 125);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.lblAnzeige.TabIndex = 6;
            this.lblAnzeige.Text = "(leer)";
            // 
            // cmdView
            // 
            this.cmdView.Location = new System.Drawing.Point(274, 41);
            this.cmdView.Name = "cmdView";
            this.cmdView.Size = new System.Drawing.Size(75, 23);
            this.cmdView.TabIndex = 7;
            this.cmdView.Text = "Anzeige";
            this.cmdView.UseVisualStyleBackColor = true;
            this.cmdView.Click += new System.EventHandler(this.cmdView_Click);
            // 
            // cmdColor
            // 
            this.cmdColor.Location = new System.Drawing.Point(274, 202);
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.Size = new System.Drawing.Size(75, 23);
            this.cmdColor.TabIndex = 8;
            this.cmdColor.Text = "Farbe";
            this.cmdColor.UseVisualStyleBackColor = true;
            this.cmdColor.Click += new System.EventHandler(this.cmdColor_Click);
            // 
            // frmButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 340);
            this.Controls.Add(this.cmdColor);
            this.Controls.Add(this.cmdView);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdEnd);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.cmdSizeAbs);
            this.Controls.Add(this.cmdSizeRel);
            this.Controls.Add(this.cmdPositionAbs);
            this.Controls.Add(this.cmdPositionRel);
            this.Name = "frmButtons";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPositionRel;
        private System.Windows.Forms.Button cmdPositionAbs;
        private System.Windows.Forms.Button cmdSizeRel;
        private System.Windows.Forms.Button cmdSizeAbs;
        private System.Windows.Forms.Button cmdTest;
        private System.Windows.Forms.Button cmdEnd;
        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.Button cmdView;
        private System.Windows.Forms.Button cmdColor;
    }
}