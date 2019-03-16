using System;

namespace DungeonMaster.WinForms
{
    partial class DungeonMasterMainForm
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
            this.GenerateLandButton = new System.Windows.Forms.Button();
            this.LandLabel = new System.Windows.Forms.Label();
            this.LandPlaceholderLabel = new System.Windows.Forms.Label();
            this.CreatureLabel = new System.Windows.Forms.Label();
            this.CreaturePlaceholderLabel = new System.Windows.Forms.Label();
            this.OpenAddEnemyFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateLandButton
            // 
            this.GenerateLandButton.Location = new System.Drawing.Point(12, 12);
            this.GenerateLandButton.Name = "GenerateLandButton";
            this.GenerateLandButton.Size = new System.Drawing.Size(102, 23);
            this.GenerateLandButton.TabIndex = 0;
            this.GenerateLandButton.Text = "Generate";
            this.GenerateLandButton.UseVisualStyleBackColor = true;
            this.GenerateLandButton.Click += new System.EventHandler(this.GenerateLandButton_Click);
            // 
            // LandLabel
            // 
            this.LandLabel.AutoSize = true;
            this.LandLabel.Location = new System.Drawing.Point(137, 17);
            this.LandLabel.Name = "LandLabel";
            this.LandLabel.Size = new System.Drawing.Size(34, 13);
            this.LandLabel.TabIndex = 1;
            this.LandLabel.Text = "Land:";
            // 
            // LandPlaceholderLabel
            // 
            this.LandPlaceholderLabel.AutoSize = true;
            this.LandPlaceholderLabel.Location = new System.Drawing.Point(198, 17);
            this.LandPlaceholderLabel.Name = "LandPlaceholderLabel";
            this.LandPlaceholderLabel.Size = new System.Drawing.Size(85, 13);
            this.LandPlaceholderLabel.TabIndex = 2;
            this.LandPlaceholderLabel.Text = "land placeholder";
            // 
            // CreatureLabel
            // 
            this.CreatureLabel.AutoSize = true;
            this.CreatureLabel.Location = new System.Drawing.Point(137, 43);
            this.CreatureLabel.Name = "CreatureLabel";
            this.CreatureLabel.Size = new System.Drawing.Size(50, 13);
            this.CreatureLabel.TabIndex = 3;
            this.CreatureLabel.Text = "Creature:";
            // 
            // CreaturePlaceholderLabel
            // 
            this.CreaturePlaceholderLabel.AutoSize = true;
            this.CreaturePlaceholderLabel.Location = new System.Drawing.Point(198, 43);
            this.CreaturePlaceholderLabel.Name = "CreaturePlaceholderLabel";
            this.CreaturePlaceholderLabel.Size = new System.Drawing.Size(104, 13);
            this.CreaturePlaceholderLabel.TabIndex = 4;
            this.CreaturePlaceholderLabel.Text = "creature placeholder";
            // 
            // OpenAddEnemyFormButton
            // 
            this.OpenAddEnemyFormButton.Location = new System.Drawing.Point(338, 12);
            this.OpenAddEnemyFormButton.Name = "OpenAddEnemyFormButton";
            this.OpenAddEnemyFormButton.Size = new System.Drawing.Size(87, 54);
            this.OpenAddEnemyFormButton.TabIndex = 5;
            this.OpenAddEnemyFormButton.Text = "Add Enemy";
            this.OpenAddEnemyFormButton.UseVisualStyleBackColor = true;
            this.OpenAddEnemyFormButton.Click += new System.EventHandler(this.OpenAddEnemyFormButton_Click);
            // 
            // DungeonMasterMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 78);
            this.Controls.Add(this.OpenAddEnemyFormButton);
            this.Controls.Add(this.CreaturePlaceholderLabel);
            this.Controls.Add(this.CreatureLabel);
            this.Controls.Add(this.LandPlaceholderLabel);
            this.Controls.Add(this.LandLabel);
            this.Controls.Add(this.GenerateLandButton);
            this.Name = "DungeonMasterMainForm";
            this.Text = "Dungeon Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DungeonMasterMainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateLandButton;
        private System.Windows.Forms.Label LandLabel;
        private System.Windows.Forms.Label LandPlaceholderLabel;
        private System.Windows.Forms.Label CreatureLabel;
        private System.Windows.Forms.Label CreaturePlaceholderLabel;
        private System.Windows.Forms.Button OpenAddEnemyFormButton;
    }
}

