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
            this.ChangeValueTB = new System.Windows.Forms.TextBox();
            this.SelectItemCB = new System.Windows.Forms.ComboBox();
            this.HeaderL = new System.Windows.Forms.Label();
            this.ItemInfoL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeButton.Location = new System.Drawing.Point(84, 248);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(236, 33);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "ChangeButton";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeValueTB
            // 
            this.ChangeValueTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeValueTB.Location = new System.Drawing.Point(15, 218);
            this.ChangeValueTB.Name = "ChangeValueTB";
            this.ChangeValueTB.Size = new System.Drawing.Size(370, 22);
            this.ChangeValueTB.TabIndex = 6;
            // 
            // SelectItemCB
            // 
            this.SelectItemCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SelectItemCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SelectItemCB.FormattingEnabled = true;
            this.SelectItemCB.Location = new System.Drawing.Point(15, 53);
            this.SelectItemCB.Name = "SelectItemCB";
            this.SelectItemCB.Size = new System.Drawing.Size(370, 24);
            this.SelectItemCB.TabIndex = 7;
            this.SelectItemCB.SelectedValueChanged += new System.EventHandler(this.SelectItemCB_SelectedValueChanged);
            // 
            // HeaderL
            // 
            this.HeaderL.AutoSize = true;
            this.HeaderL.Location = new System.Drawing.Point(12, 20);
            this.HeaderL.Name = "HeaderL";
            this.HeaderL.Size = new System.Drawing.Size(60, 16);
            this.HeaderL.TabIndex = 8;
            this.HeaderL.Text = "HeaderL";
            // 
            // ItemInfoL
            // 
            this.ItemInfoL.AutoSize = true;
            this.ItemInfoL.Location = new System.Drawing.Point(12, 96);
            this.ItemInfoL.MaximumSize = new System.Drawing.Size(391, 0);
            this.ItemInfoL.Name = "ItemInfoL";
            this.ItemInfoL.Size = new System.Drawing.Size(44, 16);
            this.ItemInfoL.TabIndex = 9;
            this.ItemInfoL.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ввод нового значения";
            // 
            // ChangeElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(397, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemInfoL);
            this.Controls.Add(this.HeaderL);
            this.Controls.Add(this.SelectItemCB);
            this.Controls.Add(this.ChangeValueTB);
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
        private System.Windows.Forms.TextBox ChangeValueTB;
        private System.Windows.Forms.ComboBox SelectItemCB;
        private System.Windows.Forms.Label HeaderL;
        private System.Windows.Forms.Label ItemInfoL;
        private System.Windows.Forms.Label label1;
    }
}