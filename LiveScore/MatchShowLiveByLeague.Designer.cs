
namespace LiveScore
{
    partial class MatchShowLiveByLeague
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.matchTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matchStatus = new System.Windows.Forms.Label();
            this.homeTeam = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.awayTeam = new System.Windows.Forms.Label();
            this.halfTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // matchTime
            // 
            this.matchTime.AutoSize = true;
            this.matchTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.matchTime.Location = new System.Drawing.Point(22, 3);
            this.matchTime.Name = "matchTime";
            this.matchTime.Size = new System.Drawing.Size(59, 13);
            this.matchTime.TabIndex = 0;
            this.matchTime.Text = "matchTime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(163, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "live";
            // 
            // matchStatus
            // 
            this.matchStatus.AutoSize = true;
            this.matchStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.matchStatus.Location = new System.Drawing.Point(227, 3);
            this.matchStatus.Name = "matchStatus";
            this.matchStatus.Size = new System.Drawing.Size(66, 13);
            this.matchStatus.TabIndex = 3;
            this.matchStatus.Text = "matchStatus";
            // 
            // homeTeam
            // 
            this.homeTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeTeam.AutoSize = true;
            this.homeTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeTeam.Location = new System.Drawing.Point(433, 3);
            this.homeTeam.Name = "homeTeam";
            this.homeTeam.Size = new System.Drawing.Size(123, 13);
            this.homeTeam.TabIndex = 4;
            this.homeTeam.Text = "                   homeTeam  ";
            this.homeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.result.Location = new System.Drawing.Point(610, 3);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 5;
            this.result.Text = "result";
            // 
            // awayTeam
            // 
            this.awayTeam.AutoSize = true;
            this.awayTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.awayTeam.Location = new System.Drawing.Point(715, 3);
            this.awayTeam.Name = "awayTeam";
            this.awayTeam.Size = new System.Drawing.Size(128, 13);
            this.awayTeam.TabIndex = 6;
            this.awayTeam.Text = "awayTeam                       ";
            // 
            // halfTime
            // 
            this.halfTime.AutoSize = true;
            this.halfTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.halfTime.Location = new System.Drawing.Point(892, 3);
            this.halfTime.Name = "halfTime";
            this.halfTime.Size = new System.Drawing.Size(47, 13);
            this.halfTime.TabIndex = 7;
            this.halfTime.Text = "halfTime";
            // 
            // MatchShowLiveByLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.halfTime);
            this.Controls.Add(this.awayTeam);
            this.Controls.Add(this.result);
            this.Controls.Add(this.homeTeam);
            this.Controls.Add(this.matchStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.matchTime);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 0);
            this.Name = "MatchShowLiveByLeague";
            this.Size = new System.Drawing.Size(988, 20);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label matchStatus;
        private System.Windows.Forms.Label homeTeam;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label awayTeam;
        private System.Windows.Forms.Label halfTime;
    }
}
