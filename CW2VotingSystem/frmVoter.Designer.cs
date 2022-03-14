namespace CW2VotingSystem
{
    partial class frmVoter
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
            this.cboVote = new System.Windows.Forms.ComboBox();
            this.textVoteDescription = new System.Windows.Forms.RichTextBox();
            this.cboVoteOption = new System.Windows.Forms.ComboBox();
            this.textVoteOptionDescription = new System.Windows.Forms.RichTextBox();
            this.btnVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboVote
            // 
            this.cboVote.DisplayMember = "name";
            this.cboVote.FormattingEnabled = true;
            this.cboVote.Location = new System.Drawing.Point(12, 12);
            this.cboVote.Name = "cboVote";
            this.cboVote.Size = new System.Drawing.Size(169, 23);
            this.cboVote.TabIndex = 0;
            this.cboVote.ValueMember = "name";
            this.cboVote.SelectedIndexChanged += new System.EventHandler(this.cboVote_SelectedIndexChanged);
            // 
            // textVoteDescription
            // 
            this.textVoteDescription.Enabled = false;
            this.textVoteDescription.Location = new System.Drawing.Point(12, 41);
            this.textVoteDescription.Name = "textVoteDescription";
            this.textVoteDescription.Size = new System.Drawing.Size(169, 96);
            this.textVoteDescription.TabIndex = 1;
            this.textVoteDescription.Text = "";
            // 
            // cboVoteOption
            // 
            this.cboVoteOption.DisplayMember = "name";
            this.cboVoteOption.FormattingEnabled = true;
            this.cboVoteOption.Location = new System.Drawing.Point(12, 143);
            this.cboVoteOption.Name = "cboVoteOption";
            this.cboVoteOption.Size = new System.Drawing.Size(169, 23);
            this.cboVoteOption.TabIndex = 2;
            this.cboVoteOption.ValueMember = "name";
            this.cboVoteOption.SelectedIndexChanged += new System.EventHandler(this.cboVoteOption_SelectedIndexChanged);
            // 
            // textVoteOptionDescription
            // 
            this.textVoteOptionDescription.Enabled = false;
            this.textVoteOptionDescription.Location = new System.Drawing.Point(12, 172);
            this.textVoteOptionDescription.Name = "textVoteOptionDescription";
            this.textVoteOptionDescription.Size = new System.Drawing.Size(169, 57);
            this.textVoteOptionDescription.TabIndex = 3;
            this.textVoteOptionDescription.Text = "";
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(12, 235);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(169, 23);
            this.btnVote.TabIndex = 4;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // frmVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 271);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.textVoteOptionDescription);
            this.Controls.Add(this.cboVoteOption);
            this.Controls.Add(this.textVoteDescription);
            this.Controls.Add(this.cboVote);
            this.Name = "frmVoter";
            this.Text = "frmVoter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVote;
        private System.Windows.Forms.RichTextBox textVoteDescription;
        private System.Windows.Forms.ComboBox cboVoteOption;
        private System.Windows.Forms.RichTextBox textVoteOptionDescription;
        private System.Windows.Forms.Button btnVote;
    }
}