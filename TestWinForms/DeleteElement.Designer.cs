namespace TestWinForms
{
    partial class DeleteElement
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ItemInfoL = new System.Windows.Forms.Label();
            this.HeaderL = new System.Windows.Forms.Label();
            this.SelectItemCB = new System.Windows.Forms.ComboBox();
            this.ItemInfo2L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(105, 231);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(175, 33);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ItemInfoL
            // 
            this.ItemInfoL.AutoSize = true;
            this.ItemInfoL.Location = new System.Drawing.Point(9, 91);
            this.ItemInfoL.MaximumSize = new System.Drawing.Size(391, 0);
            this.ItemInfoL.Name = "ItemInfoL";
            this.ItemInfoL.Size = new System.Drawing.Size(44, 16);
            this.ItemInfoL.TabIndex = 15;
            this.ItemInfoL.Text = "label2";
            // 
            // HeaderL
            // 
            this.HeaderL.AutoSize = true;
            this.HeaderL.Location = new System.Drawing.Point(9, 15);
            this.HeaderL.Name = "HeaderL";
            this.HeaderL.Size = new System.Drawing.Size(60, 16);
            this.HeaderL.TabIndex = 14;
            this.HeaderL.Text = "HeaderL";
            // 
            // SelectItemCB
            // 
            this.SelectItemCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SelectItemCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SelectItemCB.FormattingEnabled = true;
            this.SelectItemCB.Location = new System.Drawing.Point(12, 48);
            this.SelectItemCB.Name = "SelectItemCB";
            this.SelectItemCB.Size = new System.Drawing.Size(370, 24);
            this.SelectItemCB.TabIndex = 13;
            this.SelectItemCB.SelectedValueChanged += new System.EventHandler(this.SelectItemCB_SelectedValueChanged);
            // 
            // ItemInfo2L
            // 
            this.ItemInfo2L.AutoSize = true;
            this.ItemInfo2L.Location = new System.Drawing.Point(9, 132);
            this.ItemInfo2L.MaximumSize = new System.Drawing.Size(391, 0);
            this.ItemInfo2L.Name = "ItemInfo2L";
            this.ItemInfo2L.Size = new System.Drawing.Size(44, 16);
            this.ItemInfo2L.TabIndex = 16;
            this.ItemInfo2L.Text = "label3";
            // 
            // DeleteElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(404, 276);
            this.Controls.Add(this.ItemInfo2L);
            this.Controls.Add(this.ItemInfoL);
            this.Controls.Add(this.HeaderL);
            this.Controls.Add(this.SelectItemCB);
            this.Controls.Add(this.DeleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteElement";
            this.Text = "DeleteElement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label ItemInfoL;
        private System.Windows.Forms.Label HeaderL;
        private System.Windows.Forms.ComboBox SelectItemCB;
        private System.Windows.Forms.Label ItemInfo2L;
    }
}