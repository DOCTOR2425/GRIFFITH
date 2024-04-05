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
            this.Field2L = new System.Windows.Forms.Label();
            this.Field3L = new System.Windows.Forms.Label();
            this.ResetChangesB = new System.Windows.Forms.Button();
            this.Field1CB = new System.Windows.Forms.ComboBox();
            this.Field2CB = new System.Windows.Forms.ComboBox();
            this.Field3CB = new System.Windows.Forms.ComboBox();
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
            // Field2L
            // 
            this.Field2L.AutoSize = true;
            this.Field2L.Location = new System.Drawing.Point(12, 103);
            this.Field2L.Name = "Field2L";
            this.Field2L.Size = new System.Drawing.Size(51, 16);
            this.Field2L.TabIndex = 13;
            this.Field2L.Text = "Field2L";
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
            // Field1CB
            // 
            this.Field1CB.FormattingEnabled = true;
            this.Field1CB.Location = new System.Drawing.Point(15, 40);
            this.Field1CB.Name = "Field1CB";
            this.Field1CB.Size = new System.Drawing.Size(497, 24);
            this.Field1CB.TabIndex = 18;
            // 
            // Field2CB
            // 
            this.Field2CB.FormattingEnabled = true;
            this.Field2CB.Location = new System.Drawing.Point(15, 123);
            this.Field2CB.Name = "Field2CB";
            this.Field2CB.Size = new System.Drawing.Size(497, 24);
            this.Field2CB.TabIndex = 19;
            // 
            // Field3CB
            // 
            this.Field3CB.FormattingEnabled = true;
            this.Field3CB.Location = new System.Drawing.Point(15, 224);
            this.Field3CB.Name = "Field3CB";
            this.Field3CB.Size = new System.Drawing.Size(497, 24);
            this.Field3CB.TabIndex = 20;
            // 
            // ChangeElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(524, 377);
            this.Controls.Add(this.Field3CB);
            this.Controls.Add(this.Field2CB);
            this.Controls.Add(this.Field1CB);
            this.Controls.Add(this.ResetChangesB);
            this.Controls.Add(this.Field3L);
            this.Controls.Add(this.Field2L);
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
        private System.Windows.Forms.Label Field2L;
        private System.Windows.Forms.Label Field3L;
        private System.Windows.Forms.Button ResetChangesB;
        private System.Windows.Forms.ComboBox Field1CB;
        private System.Windows.Forms.ComboBox Field2CB;
        private System.Windows.Forms.ComboBox Field3CB;
    }
}