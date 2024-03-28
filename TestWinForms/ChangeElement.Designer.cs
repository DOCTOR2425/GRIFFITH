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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.Field1L = new System.Windows.Forms.Label();
            this.Field1TB = new System.Windows.Forms.TextBox();
            this.Field2TB = new System.Windows.Forms.TextBox();
            this.Field2L = new System.Windows.Forms.Label();
            this.Field3TB = new System.Windows.Forms.TextBox();
            this.Field3L = new System.Windows.Forms.Label();
            this.ResetChangesB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeButton.Location = new System.Drawing.Point(325, 332);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(187, 33);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "ChangeButton";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Field1L
            // 
            this.Field1L.AutoSize = true;
            this.Field1L.Location = new System.Drawing.Point(12, 20);
            this.Field1L.Name = "Field1L";
            this.Field1L.Size = new System.Drawing.Size(51, 16);
            this.Field1L.TabIndex = 8;
            this.Field1L.Text = "Field1L";
            // 
            // Field1TB
            // 
            this.Field1TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Field1TB.Location = new System.Drawing.Point(15, 50);
            this.Field1TB.Name = "Field1TB";
            this.Field1TB.Size = new System.Drawing.Size(497, 22);
            this.Field1TB.TabIndex = 12;
            // 
            // Field2TB
            // 
            this.Field2TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Field2TB.Location = new System.Drawing.Point(15, 133);
            this.Field2TB.Name = "Field2TB";
            this.Field2TB.Size = new System.Drawing.Size(497, 22);
            this.Field2TB.TabIndex = 14;
            // 
            // Field2L
            // 
            this.Field2L.AutoSize = true;
            this.Field2L.Location = new System.Drawing.Point(12, 103);
            this.Field2L.Name = "Field2L";
            this.Field2L.Size = new System.Drawing.Size(51, 16);
            this.Field2L.TabIndex = 13;
            this.Field2L.Text = "Field2L";
            // 
            // Field3TB
            // 
            this.Field3TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Field3TB.Location = new System.Drawing.Point(15, 234);
            this.Field3TB.Name = "Field3TB";
            this.Field3TB.Size = new System.Drawing.Size(497, 22);
            this.Field3TB.TabIndex = 16;
            // 
            // Field3L
            // 
            this.Field3L.AutoSize = true;
            this.Field3L.Location = new System.Drawing.Point(12, 204);
            this.Field3L.Name = "Field3L";
            this.Field3L.Size = new System.Drawing.Size(51, 16);
            this.Field3L.TabIndex = 15;
            this.Field3L.Text = "Field3L";
            // 
            // ResetChangesB
            // 
            this.ResetChangesB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetChangesB.Location = new System.Drawing.Point(15, 332);
            this.ResetChangesB.Name = "ResetChangesB";
            this.ResetChangesB.Size = new System.Drawing.Size(187, 33);
            this.ResetChangesB.TabIndex = 17;
            this.ResetChangesB.Text = "Отменить изменения";
            this.ResetChangesB.UseVisualStyleBackColor = true;
            this.ResetChangesB.Click += new System.EventHandler(this.ResetChangesB_Click);
            // 
            // ChangeElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(524, 377);
            this.Controls.Add(this.ResetChangesB);
            this.Controls.Add(this.Field3TB);
            this.Controls.Add(this.Field3L);
            this.Controls.Add(this.Field2TB);
            this.Controls.Add(this.Field2L);
            this.Controls.Add(this.Field1TB);
            this.Controls.Add(this.Field1L);
            this.Controls.Add(this.ChangeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeElement";
            this.Text = "ChangeElement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label Field1L;
        private System.Windows.Forms.TextBox Field1TB;
        private System.Windows.Forms.TextBox Field2TB;
        private System.Windows.Forms.Label Field2L;
        private System.Windows.Forms.TextBox Field3TB;
        private System.Windows.Forms.Label Field3L;
        private System.Windows.Forms.Button ResetChangesB;
    }
}