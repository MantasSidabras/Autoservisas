namespace AutoDatabase
{
    partial class CreateDiscountWindow
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
            this.discountNameTextLabel = new System.Windows.Forms.Label();
            this.discountPerentageTextLabel = new System.Windows.Forms.Label();
            this.discountNameTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.discountExpirationTextLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.addDiscountPictureButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.discountDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.discountDescriptionLabel = new System.Windows.Forms.Label();
            this.saveDiscountButton = new System.Windows.Forms.Button();
            this.fileExplorer = new System.Windows.Forms.OpenFileDialog();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // discountNameTextLabel
            // 
            this.discountNameTextLabel.AutoSize = true;
            this.discountNameTextLabel.Location = new System.Drawing.Point(12, 30);
            this.discountNameTextLabel.Name = "discountNameTextLabel";
            this.discountNameTextLabel.Size = new System.Drawing.Size(116, 13);
            this.discountNameTextLabel.TabIndex = 0;
            this.discountNameTextLabel.Text = "Nuolaidos pavadinimas";
            // 
            // discountPerentageTextLabel
            // 
            this.discountPerentageTextLabel.AutoSize = true;
            this.discountPerentageTextLabel.Location = new System.Drawing.Point(12, 70);
            this.discountPerentageTextLabel.Name = "discountPerentageTextLabel";
            this.discountPerentageTextLabel.Size = new System.Drawing.Size(89, 13);
            this.discountPerentageTextLabel.TabIndex = 1;
            this.discountPerentageTextLabel.Text = "nuolaidosDydis %";
            // 
            // discountNameTextBox
            // 
            this.discountNameTextBox.Location = new System.Drawing.Point(171, 27);
            this.discountNameTextBox.Name = "discountNameTextBox";
            this.discountNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.discountNameTextBox.TabIndex = 2;
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Location = new System.Drawing.Point(171, 67);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(48, 20);
            this.discountPercentageTextBox.TabIndex = 3;
            // 
            // discountExpirationTextLabel
            // 
            this.discountExpirationTextLabel.AutoSize = true;
            this.discountExpirationTextLabel.Location = new System.Drawing.Point(12, 114);
            this.discountExpirationTextLabel.Name = "discountExpirationTextLabel";
            this.discountExpirationTextLabel.Size = new System.Drawing.Size(55, 13);
            this.discountExpirationTextLabel.TabIndex = 4;
            this.discountExpirationTextLabel.Text = "Galioja iki:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(171, 111);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(48, 20);
            this.yearTextBox.TabIndex = 5;
            this.yearTextBox.Text = "yyyy";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(225, 111);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(33, 20);
            this.monthTextBox.TabIndex = 6;
            this.monthTextBox.Text = "MM";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(264, 111);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(33, 20);
            this.dayTextBox.TabIndex = 7;
            this.dayTextBox.Text = "dd";
            // 
            // addDiscountPictureButton
            // 
            this.addDiscountPictureButton.Location = new System.Drawing.Point(12, 144);
            this.addDiscountPictureButton.Name = "addDiscountPictureButton";
            this.addDiscountPictureButton.Size = new System.Drawing.Size(127, 23);
            this.addDiscountPictureButton.TabIndex = 8;
            this.addDiscountPictureButton.Text = "Pridėti paveiksliuką";
            this.addDiscountPictureButton.UseVisualStyleBackColor = true;
            this.addDiscountPictureButton.Click += new System.EventHandler(this.addDiscountPictureButton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(168, 149);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(41, 13);
            this.filePathLabel.TabIndex = 9;
            this.filePathLabel.Text = "(tusčia)";
            // 
            // discountDescriptionTextBox
            // 
            this.discountDescriptionTextBox.Location = new System.Drawing.Point(15, 208);
            this.discountDescriptionTextBox.Multiline = true;
            this.discountDescriptionTextBox.Name = "discountDescriptionTextBox";
            this.discountDescriptionTextBox.Size = new System.Drawing.Size(417, 147);
            this.discountDescriptionTextBox.TabIndex = 10;
            // 
            // discountDescriptionLabel
            // 
            this.discountDescriptionLabel.AutoSize = true;
            this.discountDescriptionLabel.Location = new System.Drawing.Point(12, 192);
            this.discountDescriptionLabel.Name = "discountDescriptionLabel";
            this.discountDescriptionLabel.Size = new System.Drawing.Size(96, 13);
            this.discountDescriptionLabel.TabIndex = 11;
            this.discountDescriptionLabel.Text = "nuolados aparašas";
            // 
            // saveDiscountButton
            // 
            this.saveDiscountButton.Location = new System.Drawing.Point(15, 376);
            this.saveDiscountButton.Name = "saveDiscountButton";
            this.saveDiscountButton.Size = new System.Drawing.Size(124, 23);
            this.saveDiscountButton.TabIndex = 12;
            this.saveDiscountButton.Text = "Išsaugoti";
            this.saveDiscountButton.UseVisualStyleBackColor = true;
            this.saveDiscountButton.Click += new System.EventHandler(this.saveDiscountButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(330, 67);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(93, 20);
            this.codeTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kodas";
            // 
            // CreateDiscountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.saveDiscountButton);
            this.Controls.Add(this.discountDescriptionLabel);
            this.Controls.Add(this.discountDescriptionTextBox);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.addDiscountPictureButton);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.discountExpirationTextLabel);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.discountNameTextBox);
            this.Controls.Add(this.discountPerentageTextLabel);
            this.Controls.Add(this.discountNameTextLabel);
            this.Name = "CreateDiscountWindow";
            this.Text = "CreateDiscountWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label discountNameTextLabel;
        private System.Windows.Forms.Label discountPerentageTextLabel;
        private System.Windows.Forms.TextBox discountNameTextBox;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private System.Windows.Forms.Label discountExpirationTextLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Button addDiscountPictureButton;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.TextBox discountDescriptionTextBox;
        private System.Windows.Forms.Label discountDescriptionLabel;
        private System.Windows.Forms.Button saveDiscountButton;
        private System.Windows.Forms.OpenFileDialog fileExplorer;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label1;
    }
}