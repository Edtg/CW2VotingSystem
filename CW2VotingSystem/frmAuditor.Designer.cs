namespace CW2VotingSystem
{
    partial class frmAuditor
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
            this.btnWinningOption = new System.Windows.Forms.Button();
            this.btnAllVotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboVote
            // 
            this.cboVote.DisplayMember = "name";
            this.cboVote.FormattingEnabled = true;
            this.cboVote.Location = new System.Drawing.Point(12, 12);
            this.cboVote.Name = "cboVote";
            this.cboVote.Size = new System.Drawing.Size(193, 23);
            this.cboVote.TabIndex = 0;
            this.cboVote.ValueMember = "name";
            // 
            // btnWinningOption
            // 
            this.btnWinningOption.Location = new System.Drawing.Point(12, 41);
            this.btnWinningOption.Name = "btnWinningOption";
            this.btnWinningOption.Size = new System.Drawing.Size(193, 23);
            this.btnWinningOption.TabIndex = 1;
            this.btnWinningOption.Text = "View Winning Option";
            this.btnWinningOption.UseVisualStyleBackColor = true;
            this.btnWinningOption.Click += new System.EventHandler(this.btnWinningOption_Click);
            // 
            // btnAllVotes
            // 
            this.btnAllVotes.Location = new System.Drawing.Point(12, 70);
            this.btnAllVotes.Name = "btnAllVotes";
            this.btnAllVotes.Size = new System.Drawing.Size(190, 23);
            this.btnAllVotes.TabIndex = 2;
            this.btnAllVotes.Text = "View Count For All Options";
            this.btnAllVotes.UseVisualStyleBackColor = true;
            this.btnAllVotes.Click += new System.EventHandler(this.btnAllVotes_Click);
            // 
            // frmAuditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 102);
            this.Controls.Add(this.btnAllVotes);
            this.Controls.Add(this.btnWinningOption);
            this.Controls.Add(this.cboVote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAuditor";
            this.Text = "frmAuditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVote;
        private System.Windows.Forms.Button btnWinningOption;
        private System.Windows.Forms.Button btnAllVotes;
    }
}