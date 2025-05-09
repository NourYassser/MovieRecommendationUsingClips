namespace MovieRecommendationUsingClips
{
    partial class MovieRecommenderForm
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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.recommendButton = new System.Windows.Forms.Button();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.moodComboBox = new System.Windows.Forms.ComboBox();
            this.moodLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(15, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(267, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Movie Recommender System";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.resultLabel);
            this.contentPanel.Controls.Add(this.resultTextBox);
            this.contentPanel.Controls.Add(this.recommendButton);
            this.contentPanel.Controls.Add(this.timeComboBox);
            this.contentPanel.Controls.Add(this.timeLabel);
            this.contentPanel.Controls.Add(this.moodComboBox);
            this.contentPanel.Controls.Add(this.moodLabel);
            this.contentPanel.Controls.Add(this.genreComboBox);
            this.contentPanel.Controls.Add(this.genreLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.contentPanel.Size = new System.Drawing.Size(500, 340);
            this.contentPanel.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.resultLabel.Location = new System.Drawing.Point(230, 20);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(119, 19);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Recommendation:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.resultTextBox.Location = new System.Drawing.Point(230, 45);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(220, 215);
            this.resultTextBox.TabIndex = 7;
            // 
            // recommendButton
            // 
            this.recommendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.recommendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recommendButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.recommendButton.ForeColor = System.Drawing.Color.White;
            this.recommendButton.Location = new System.Drawing.Point(10, 220);
            this.recommendButton.Name = "recommendButton";
            this.recommendButton.Size = new System.Drawing.Size(200, 40);
            this.recommendButton.TabIndex = 6;
            this.recommendButton.Text = "Get Recommendation";
            this.recommendButton.UseVisualStyleBackColor = false;
            this.recommendButton.Click += new System.EventHandler(this.recommendButton_Click);
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "short",
            "medium",
            "long"});
            this.timeComboBox.Location = new System.Drawing.Point(10, 175);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(200, 21);
            this.timeComboBox.TabIndex = 5;
            this.timeComboBox.SelectedIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeLabel.Location = new System.Drawing.Point(10, 150);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(275, 19);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "How Much Time Can You Spare For Watching?";
            // 
            // moodComboBox
            // 
            this.moodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moodComboBox.FormattingEnabled = true;
            this.moodComboBox.Items.AddRange(new object[] {
            "happy",
            "sad",
            "bored"});
            this.moodComboBox.Location = new System.Drawing.Point(10, 110);
            this.moodComboBox.Name = "moodComboBox";
            this.moodComboBox.Size = new System.Drawing.Size(200, 21);
            this.moodComboBox.TabIndex = 3;
            this.moodComboBox.SelectedIndex = 0;
            // 
            // moodLabel
            // 
            this.moodLabel.AutoSize = true;
            this.moodLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.moodLabel.Location = new System.Drawing.Point(10, 85);
            this.moodLabel.Name = "moodLabel";
            this.moodLabel.Size = new System.Drawing.Size(100, 19);
            this.moodLabel.TabIndex = 2;
            this.moodLabel.Text = "Current Mood?";
            // 
            // genreComboBox
            // 
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "action",
            "romance",
            "comedy",
            "horror",
            "scifi"});
            this.genreComboBox.Location = new System.Drawing.Point(10, 45);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(200, 21);
            this.genreComboBox.TabIndex = 1;
            this.genreComboBox.SelectedIndex = 0;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genreLabel.Location = new System.Drawing.Point(10, 20);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(196, 19);
            this.genreLabel.TabIndex = 0;
            this.genreLabel.Text = "What Type Of Movies Do You Prefer?";
            // 
            // MovieRecommenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MovieRecommenderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Recommender System";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox moodComboBox;
        private System.Windows.Forms.Label moodLabel;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button recommendButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
    }
}
