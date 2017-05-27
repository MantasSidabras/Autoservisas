namespace AutoDatabase
{
    partial class DiscountWindow
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.discountPictureBox = new System.Windows.Forms.PictureBox();
            this.discountTextLabel = new System.Windows.Forms.Label();
            this.discountCodeLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.expirationDateTextLabel = new System.Windows.Forms.Label();
            this.discountExpirationDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.discountPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(114, 206);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(250, 46);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "AmazingTitle";
            // 
            // discountPictureBox
            // 
            this.discountPictureBox.Location = new System.Drawing.Point(122, 3);
            this.discountPictureBox.Name = "discountPictureBox";
            this.discountPictureBox.Size = new System.Drawing.Size(580, 200);
            this.discountPictureBox.TabIndex = 1;
            this.discountPictureBox.TabStop = false;
            // 
            // discountTextLabel
            // 
            this.discountTextLabel.AutoSize = true;
            this.discountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextLabel.Location = new System.Drawing.Point(118, 271);
            this.discountTextLabel.Name = "discountTextLabel";
            this.discountTextLabel.Size = new System.Drawing.Size(128, 20);
            this.discountTextLabel.TabIndex = 2;
            this.discountTextLabel.Text = "nuolaidos kodas:";
            // 
            // discountCodeLabel
            // 
            this.discountCodeLabel.AutoSize = true;
            this.discountCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountCodeLabel.Location = new System.Drawing.Point(277, 261);
            this.discountCodeLabel.Name = "discountCodeLabel";
            this.discountCodeLabel.Size = new System.Drawing.Size(210, 31);
            this.discountCodeLabel.TabIndex = 3;
            this.discountCodeLabel.Text = "amzing discount";
            // 
            // discountTextBox
            // 
            this.discountTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.discountTextBox.Location = new System.Drawing.Point(122, 354);
            this.discountTextBox.Multiline = true;
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.ReadOnly = true;
            this.discountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.discountTextBox.ShortcutsEnabled = false;
            this.discountTextBox.Size = new System.Drawing.Size(580, 195);
            this.discountTextBox.TabIndex = 4;
            this.discountTextBox.TabStop = false;
            // 
            // expirationDateTextLabel
            // 
            this.expirationDateTextLabel.AutoSize = true;
            this.expirationDateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDateTextLabel.Location = new System.Drawing.Point(119, 313);
            this.expirationDateTextLabel.Name = "expirationDateTextLabel";
            this.expirationDateTextLabel.Size = new System.Drawing.Size(76, 20);
            this.expirationDateTextLabel.TabIndex = 6;
            this.expirationDateTextLabel.Text = "galioja iki:";
            // 
            // discountExpirationDateLabel
            // 
            this.discountExpirationDateLabel.AutoSize = true;
            this.discountExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountExpirationDateLabel.Location = new System.Drawing.Point(279, 310);
            this.discountExpirationDateLabel.Name = "discountExpirationDateLabel";
            this.discountExpirationDateLabel.Size = new System.Drawing.Size(122, 24);
            this.discountExpirationDateLabel.TabIndex = 7;
            this.discountExpirationDateLabel.Text = "amazing date";
            // 
            // DiscountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.discountExpirationDateLabel);
            this.Controls.Add(this.expirationDateTextLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.discountCodeLabel);
            this.Controls.Add(this.discountTextLabel);
            this.Controls.Add(this.discountPictureBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "DiscountWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "discountPictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.discountPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox discountPictureBox;
        private System.Windows.Forms.Label discountTextLabel;
        private System.Windows.Forms.Label discountCodeLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label expirationDateTextLabel;
        protected System.Windows.Forms.Label discountExpirationDateLabel;
    }
}