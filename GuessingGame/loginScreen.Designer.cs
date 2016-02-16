namespace GuessingGame
{
    partial class loginScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.numberedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Miriam", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numberLabel.Location = new System.Drawing.Point(56, 67);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(0, 11);
            this.numberLabel.TabIndex = 0;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Miriam", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.orderLabel.Location = new System.Drawing.Point(56, 144);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(0, 11);
            this.orderLabel.TabIndex = 1;
            // 
            // numberedLabel
            // 
            this.numberedLabel.AutoSize = true;
            this.numberedLabel.Font = new System.Drawing.Font("Miriam", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numberedLabel.Location = new System.Drawing.Point(56, 216);
            this.numberedLabel.Name = "numberedLabel";
            this.numberedLabel.Size = new System.Drawing.Size(0, 11);
            this.numberedLabel.TabIndex = 2;
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.numberedLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.numberLabel);
            this.Name = "loginScreen";
            this.Size = new System.Drawing.Size(300, 301);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label numberedLabel;
    }
}
