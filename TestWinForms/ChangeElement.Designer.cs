namespace TestWinForms
{
    partial class ChangeElement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GroupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 360);
            this.panel1.TabIndex = 3;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Location = new System.Drawing.Point(25, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(324, 338);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "groupBox";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(38, 12);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(324, 22);
            this.TextBox1.TabIndex = 5;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(206, 447);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(156, 33);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "ChangeButton";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Location = new System.Drawing.Point(38, 419);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.Size = new System.Drawing.Size(324, 22);
            this.ChangeTextBox.TabIndex = 6;
            // 
            // ChangeElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 494);
            this.Controls.Add(this.ChangeTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ChangeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangeElement";
            this.Text = "ChangeElement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox ChangeTextBox;
    }
}