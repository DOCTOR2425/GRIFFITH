namespace TestWinForms
{
    partial class AddServiceDiscount
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
            this.DescriptionLable = new System.Windows.Forms.Label();
            this.NumberLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescriptionLable
            // 
            this.DescriptionLable.AutoSize = true;
            this.DescriptionLable.Location = new System.Drawing.Point(16, 72);
            this.DescriptionLable.Name = "DescriptionLable";
            this.DescriptionLable.Size = new System.Drawing.Size(109, 16);
            this.DescriptionLable.TabIndex = 18;
            this.DescriptionLable.Text = "DescriptionLable";
            // 
            // NumberLable
            // 
            this.NumberLable.AutoSize = true;
            this.NumberLable.Location = new System.Drawing.Point(285, 9);
            this.NumberLable.Name = "NumberLable";
            this.NumberLable.Size = new System.Drawing.Size(89, 16);
            this.NumberLable.TabIndex = 17;
            this.NumberLable.Text = "NumberLable";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(13, 9);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(78, 16);
            this.NameLable.TabIndex = 16;
            this.NameLable.Text = "NameLable";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(13, 95);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(400, 300);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(288, 31);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(125, 22);
            this.NumberTextBox.TabIndex = 2;
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 31);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(250, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(111, 400);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(200, 40);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddServiceDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.DescriptionLable);
            this.Controls.Add(this.NumberLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServiceDiscount";
            this.Text = "AddServiceDiscount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLable;
        private System.Windows.Forms.Label NumberLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}