namespace DungeonMaster.WinForms
{
    partial class AddEnemyForm
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
            this.EnemyNameLabel = new System.Windows.Forms.Label();
            this.EnemyNameTextBox = new System.Windows.Forms.TextBox();
            this.AddAndCloseButton = new System.Windows.Forms.Button();
            this.LandsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // EnemyNameLabel
            // 
            this.EnemyNameLabel.AutoSize = true;
            this.EnemyNameLabel.Location = new System.Drawing.Point(12, 9);
            this.EnemyNameLabel.Name = "EnemyNameLabel";
            this.EnemyNameLabel.Size = new System.Drawing.Size(71, 13);
            this.EnemyNameLabel.TabIndex = 0;
            this.EnemyNameLabel.Text = "Enemy name:";
            // 
            // EnemyNameTextBox
            // 
            this.EnemyNameTextBox.Location = new System.Drawing.Point(89, 6);
            this.EnemyNameTextBox.Name = "EnemyNameTextBox";
            this.EnemyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnemyNameTextBox.TabIndex = 1;
            // 
            // AddAndCloseButton
            // 
            this.AddAndCloseButton.Location = new System.Drawing.Point(90, 177);
            this.AddAndCloseButton.Name = "AddAndCloseButton";
            this.AddAndCloseButton.Size = new System.Drawing.Size(100, 23);
            this.AddAndCloseButton.TabIndex = 2;
            this.AddAndCloseButton.Text = "Add and Close";
            this.AddAndCloseButton.UseVisualStyleBackColor = true;
            this.AddAndCloseButton.Click += new System.EventHandler(this.AddAndCloseButton_Click);
            // 
            // LandsCheckedListBox
            // 
            this.LandsCheckedListBox.FormattingEnabled = true;
            this.LandsCheckedListBox.Location = new System.Drawing.Point(15, 32);
            this.LandsCheckedListBox.Name = "LandsCheckedListBox";
            this.LandsCheckedListBox.Size = new System.Drawing.Size(175, 139);
            this.LandsCheckedListBox.TabIndex = 3;
            // 
            // AddEnemyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 210);
            this.Controls.Add(this.EnemyNameTextBox);
            this.Controls.Add(this.LandsCheckedListBox);
            this.Controls.Add(this.EnemyNameLabel);
            this.Controls.Add(this.AddAndCloseButton);
            this.Name = "AddEnemyForm";
            this.Text = "AddEnemyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnemyNameLabel;
        private System.Windows.Forms.TextBox EnemyNameTextBox;
        private System.Windows.Forms.Button AddAndCloseButton;
        private System.Windows.Forms.CheckedListBox LandsCheckedListBox;
    }
}