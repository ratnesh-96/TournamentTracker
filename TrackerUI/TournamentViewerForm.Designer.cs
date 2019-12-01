namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.Roundlabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamoneScorelabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teamTwoScoreText = new System.Windows.Forms.TextBox();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.teamTwoScorelabel = new System.Windows.Forms.Label();
            this.versuslabel = new System.Windows.Forms.Label();
            this.scorebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Location = new System.Drawing.Point(147, 0);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(88, 30);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // Roundlabel
            // 
            this.Roundlabel.AutoSize = true;
            this.Roundlabel.Location = new System.Drawing.Point(0, 40);
            this.Roundlabel.Name = "Roundlabel";
            this.Roundlabel.Size = new System.Drawing.Size(73, 30);
            this.Roundlabel.TabIndex = 2;
            this.Roundlabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(152, 40);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(177, 38);
            this.roundDropDown.TabIndex = 3;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(152, 100);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(168, 34);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(23, 131);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(319, 94);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Location = new System.Drawing.Point(376, 131);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(129, 30);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamoneScorelabel
            // 
            this.teamoneScorelabel.AutoSize = true;
            this.teamoneScorelabel.Location = new System.Drawing.Point(376, 161);
            this.teamoneScorelabel.Name = "teamoneScorelabel";
            this.teamoneScorelabel.Size = new System.Drawing.Size(64, 30);
            this.teamoneScorelabel.TabIndex = 7;
            this.teamoneScorelabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(467, 161);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "<team one>";
            // 
            // teamTwoScoreText
            // 
            this.teamTwoScoreText.Location = new System.Drawing.Point(467, 262);
            this.teamTwoScoreText.Name = "teamTwoScoreText";
            this.teamTwoScoreText.Size = new System.Drawing.Size(100, 35);
            this.teamTwoScoreText.TabIndex = 11;
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Location = new System.Drawing.Point(377, 229);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(128, 30);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<team two>";
            // 
            // teamTwoScorelabel
            // 
            this.teamTwoScorelabel.AutoSize = true;
            this.teamTwoScorelabel.Location = new System.Drawing.Point(391, 259);
            this.teamTwoScorelabel.Name = "teamTwoScorelabel";
            this.teamTwoScorelabel.Size = new System.Drawing.Size(64, 30);
            this.teamTwoScorelabel.TabIndex = 10;
            this.teamTwoScorelabel.Text = "Score";
            // 
            // versuslabel
            // 
            this.versuslabel.AutoSize = true;
            this.versuslabel.Location = new System.Drawing.Point(391, 199);
            this.versuslabel.Name = "versuslabel";
            this.versuslabel.Size = new System.Drawing.Size(69, 30);
            this.versuslabel.TabIndex = 12;
            this.versuslabel.Text = "--VS--";
            // 
            // scorebutton
            // 
            this.scorebutton.Location = new System.Drawing.Point(627, 205);
            this.scorebutton.Name = "scorebutton";
            this.scorebutton.Size = new System.Drawing.Size(111, 35);
            this.scorebutton.TabIndex = 13;
            this.scorebutton.Text = "Score";
            this.scorebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 388);
            this.Controls.Add(this.scorebutton);
            this.Controls.Add(this.versuslabel);
            this.Controls.Add(this.teamTwoScoreText);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamTwoScorelabel);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamoneScorelabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.Roundlabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label Roundlabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamoneScorelabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teamTwoScoreText;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label teamTwoScorelabel;
        private System.Windows.Forms.Label versuslabel;
        private System.Windows.Forms.Button scorebutton;
    }
}

