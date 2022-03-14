namespace CW2VotingSystem
{
    partial class frmAdministrator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddVote = new System.Windows.Forms.Button();
            this.editVoteDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editVoteName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddOption = new System.Windows.Forms.Button();
            this.editOptionDescription = new System.Windows.Forms.RichTextBox();
            this.cboVote = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editOptionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateEndDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateStartDate);
            this.groupBox1.Controls.Add(this.btnAddVote);
            this.groupBox1.Controls.Add(this.editVoteDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.editVoteName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Vote";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "End Date:";
            // 
            // dateEndDate
            // 
            this.dateEndDate.Location = new System.Drawing.Point(6, 227);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.Size = new System.Drawing.Size(204, 23);
            this.dateEndDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Start Date:";
            // 
            // dateStartDate
            // 
            this.dateStartDate.Location = new System.Drawing.Point(6, 183);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(204, 23);
            this.dateStartDate.TabIndex = 5;
            // 
            // btnAddVote
            // 
            this.btnAddVote.Location = new System.Drawing.Point(6, 256);
            this.btnAddVote.Name = "btnAddVote";
            this.btnAddVote.Size = new System.Drawing.Size(204, 23);
            this.btnAddVote.TabIndex = 2;
            this.btnAddVote.Text = "Add Vote";
            this.btnAddVote.UseVisualStyleBackColor = true;
            this.btnAddVote.Click += new System.EventHandler(this.btnAddVote_Click);
            // 
            // editVoteDescription
            // 
            this.editVoteDescription.Location = new System.Drawing.Point(6, 81);
            this.editVoteDescription.Name = "editVoteDescription";
            this.editVoteDescription.Size = new System.Drawing.Size(204, 81);
            this.editVoteDescription.TabIndex = 2;
            this.editVoteDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // editVoteName
            // 
            this.editVoteName.Location = new System.Drawing.Point(6, 37);
            this.editVoteName.Name = "editVoteName";
            this.editVoteName.Size = new System.Drawing.Size(204, 23);
            this.editVoteName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddOption);
            this.groupBox2.Controls.Add(this.editOptionDescription);
            this.groupBox2.Controls.Add(this.cboVote);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.editOptionName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(244, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Vote Option";
            // 
            // btnAddOption
            // 
            this.btnAddOption.Location = new System.Drawing.Point(6, 256);
            this.btnAddOption.Name = "btnAddOption";
            this.btnAddOption.Size = new System.Drawing.Size(260, 23);
            this.btnAddOption.TabIndex = 3;
            this.btnAddOption.Text = "Add Option";
            this.btnAddOption.UseVisualStyleBackColor = true;
            this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
            // 
            // editOptionDescription
            // 
            this.editOptionDescription.Location = new System.Drawing.Point(6, 110);
            this.editOptionDescription.Name = "editOptionDescription";
            this.editOptionDescription.Size = new System.Drawing.Size(260, 140);
            this.editOptionDescription.TabIndex = 5;
            this.editOptionDescription.Text = "";
            // 
            // cboVote
            // 
            this.cboVote.DisplayMember = "name";
            this.cboVote.FormattingEnabled = true;
            this.cboVote.Location = new System.Drawing.Point(6, 22);
            this.cboVote.Name = "cboVote";
            this.cboVote.Size = new System.Drawing.Size(260, 23);
            this.cboVote.TabIndex = 0;
            this.cboVote.ValueMember = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // editOptionName
            // 
            this.editOptionName.Location = new System.Drawing.Point(6, 66);
            this.editOptionName.Name = "editOptionName";
            this.editOptionName.Size = new System.Drawing.Size(260, 23);
            this.editOptionName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // frmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdministrator";
            this.Text = "frmAdministrator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox editVoteDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editVoteName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboVote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editOptionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox editOptionDescription;
        private System.Windows.Forms.Button btnAddVote;
        private System.Windows.Forms.Button btnAddOption;
        private System.Windows.Forms.DateTimePicker dateEndDate;
        private System.Windows.Forms.DateTimePicker dateStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}