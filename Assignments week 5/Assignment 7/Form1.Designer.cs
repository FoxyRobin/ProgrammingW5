namespace Assignment_7
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
            this.ThrowsLbl = new System.Windows.Forms.Label();
            this.ThrowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThrowsLbl
            // 
            this.ThrowsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ThrowsLbl.Location = new System.Drawing.Point(40, 41);
            this.ThrowsLbl.Name = "ThrowsLbl";
            this.ThrowsLbl.Size = new System.Drawing.Size(301, 146);
            this.ThrowsLbl.TabIndex = 0;
            this.ThrowsLbl.Text = "Click to generate..";
            // 
            // ThrowBtn
            // 
            this.ThrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ThrowBtn.Location = new System.Drawing.Point(115, 174);
            this.ThrowBtn.Name = "ThrowBtn";
            this.ThrowBtn.Size = new System.Drawing.Size(161, 48);
            this.ThrowBtn.TabIndex = 1;
            this.ThrowBtn.Text = "&Throw";
            this.ThrowBtn.UseVisualStyleBackColor = true;
            this.ThrowBtn.Click += new System.EventHandler(this.ThrowBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 246);
            this.Controls.Add(this.ThrowBtn);
            this.Controls.Add(this.ThrowsLbl);
            this.Name = "Form1";
            this.Text = "Arrays assignment 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ThrowsLbl;
        private System.Windows.Forms.Button ThrowBtn;
    }
}

