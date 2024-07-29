
namespace LiveScore
{
    partial class MatchShowLive
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
            this.PBoxMatchState = new System.Windows.Forms.PictureBox();
            this.matchTime = new System.Windows.Forms.Label();
            this.matchStatus = new System.Windows.Forms.Label();
            this.leagueName = new System.Windows.Forms.Label();
            this.homeTeam = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.awayTeam = new System.Windows.Forms.Label();
            this.halfScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMatchState)).BeginInit();
            this.SuspendLayout();
            // 
            // PBoxMatchState
            // 
            this.PBoxMatchState.Location = new System.Drawing.Point(101, 3);
            this.PBoxMatchState.Margin = new System.Windows.Forms.Padding(0);
            this.PBoxMatchState.Name = "PBoxMatchState";
            this.PBoxMatchState.Size = new System.Drawing.Size(12, 12);
            this.PBoxMatchState.TabIndex = 4;
            this.PBoxMatchState.TabStop = false;
            // 
            // matchTime
            // 
            this.matchTime.AutoSize = true;
            this.matchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchTime.ForeColor = System.Drawing.Color.Gold;
            this.matchTime.Location = new System.Drawing.Point(14, 3);
            this.matchTime.Name = "matchTime";
            this.matchTime.Size = new System.Drawing.Size(59, 13);
            this.matchTime.TabIndex = 3;
            this.matchTime.Text = "matchTime";
            // 
            // matchStatus
            // 
            this.matchStatus.AutoSize = true;
            this.matchStatus.ForeColor = System.Drawing.Color.Gold;
            this.matchStatus.Location = new System.Drawing.Point(146, 3);
            this.matchStatus.Name = "matchStatus";
            this.matchStatus.Size = new System.Drawing.Size(66, 13);
            this.matchStatus.TabIndex = 3;
            this.matchStatus.Text = "matchStatus";
            // 
            // leagueName
            // 
            this.leagueName.AutoSize = true;
            this.leagueName.ForeColor = System.Drawing.Color.Green;
            this.leagueName.Location = new System.Drawing.Point(233, 3);
            this.leagueName.Name = "leagueName";
            this.leagueName.Size = new System.Drawing.Size(244, 13);
            this.leagueName.TabIndex = 3;
            this.leagueName.Text = "Show League Name: for example  Premier League";
            // 
            // homeTeam
            // 
            this.homeTeam.ForeColor = System.Drawing.Color.Ivory;
            this.homeTeam.Location = new System.Drawing.Point(555, 3);
            this.homeTeam.Name = "homeTeam";
            this.homeTeam.Size = new System.Drawing.Size(117, 13);
            this.homeTeam.TabIndex = 3;
            this.homeTeam.Text = "homeTeam";
            this.homeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.ForeColor = System.Drawing.Color.Ivory;
            this.result.Location = new System.Drawing.Point(691, 3);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 3;
            this.result.Text = "result";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // awayTeam
            // 
            this.awayTeam.AutoSize = true;
            this.awayTeam.ForeColor = System.Drawing.Color.Ivory;
            this.awayTeam.Location = new System.Drawing.Point(740, 3);
            this.awayTeam.Name = "awayTeam";
            this.awayTeam.Size = new System.Drawing.Size(131, 13);
            this.awayTeam.TabIndex = 3;
            this.awayTeam.Text = "awayTeam                        ";
            this.awayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // halfScore
            // 
            this.halfScore.AutoSize = true;
            this.halfScore.ForeColor = System.Drawing.Color.Ivory;
            this.halfScore.Location = new System.Drawing.Point(901, 3);
            this.halfScore.Name = "halfScore";
            this.halfScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.halfScore.Size = new System.Drawing.Size(52, 13);
            this.halfScore.TabIndex = 3;
            this.halfScore.Text = "halfScore";
            this.halfScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatchShowLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PBoxMatchState);
            this.Controls.Add(this.awayTeam);
            this.Controls.Add(this.halfScore);
            this.Controls.Add(this.result);
            this.Controls.Add(this.homeTeam);
            this.Controls.Add(this.leagueName);
            this.Controls.Add(this.matchStatus);
            this.Controls.Add(this.matchTime);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 0);
            this.Name = "MatchShowLive";
            this.Size = new System.Drawing.Size(988, 20);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMatchState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxMatchState;
        private System.Windows.Forms.Label matchTime;
        private System.Windows.Forms.Label matchStatus;
        private System.Windows.Forms.Label leagueName;
        private System.Windows.Forms.Label homeTeam;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label awayTeam;
        private System.Windows.Forms.Label halfScore;
    }
}
