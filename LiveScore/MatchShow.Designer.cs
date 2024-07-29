
namespace LiveScore
{
    partial class MatchShow
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
            this.homeTeam = new System.Windows.Forms.Label();
            this.awayTeam = new System.Windows.Forms.Label();
            this.matchResult = new System.Windows.Forms.Label();
            this.HalfResult = new System.Windows.Forms.Label();
            this.PBoxMatchState = new System.Windows.Forms.PictureBox();
            this.matchStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMatchState)).BeginInit();
            this.SuspendLayout();
            // 
            // matchTime
            // 
            this.matchTime.AutoSize = true;
            this.matchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchTime.ForeColor = System.Drawing.Color.Gold;
            this.matchTime.Location = new System.Drawing.Point(4, 3);
            this.matchTime.Name = "matchTime";
            this.matchTime.Size = new System.Drawing.Size(36, 13);
            this.matchTime.TabIndex = 0;
            this.matchTime.Text = "match";
            // 
            // homeTeam
            // 
            this.homeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.homeTeam.Location = new System.Drawing.Point(144, 3);
            this.homeTeam.Name = "homeTeam";
            this.homeTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeTeam.Size = new System.Drawing.Size(100, 13);
            this.homeTeam.TabIndex = 1;
            this.homeTeam.Text = "HomeTeam";
            this.homeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // awayTeam
            // 
            this.awayTeam.AutoSize = true;
            this.awayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayTeam.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.awayTeam.Location = new System.Drawing.Point(253, 3);
            this.awayTeam.Name = "awayTeam";
            this.awayTeam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.awayTeam.Size = new System.Drawing.Size(59, 13);
            this.awayTeam.TabIndex = 1;
            this.awayTeam.Text = "awayTeam";
            // 
            // matchResult
            // 
            this.matchResult.AutoSize = true;
            this.matchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchResult.ForeColor = System.Drawing.Color.Gold;
            this.matchResult.Location = new System.Drawing.Point(388, 3);
            this.matchResult.Name = "matchResult";
            this.matchResult.Size = new System.Drawing.Size(10, 13);
            this.matchResult.TabIndex = 1;
            this.matchResult.Text = "-";
            // 
            // HalfResult
            // 
            this.HalfResult.AutoSize = true;
            this.HalfResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HalfResult.ForeColor = System.Drawing.Color.Goldenrod;
            this.HalfResult.Location = new System.Drawing.Point(445, 3);
            this.HalfResult.Name = "HalfResult";
            this.HalfResult.Size = new System.Drawing.Size(10, 13);
            this.HalfResult.TabIndex = 1;
            this.HalfResult.Text = "-";
            // 
            // PBoxMatchState
            // 
            this.PBoxMatchState.Location = new System.Drawing.Point(50, 3);
            this.PBoxMatchState.Margin = new System.Windows.Forms.Padding(0);
            this.PBoxMatchState.Name = "PBoxMatchState";
            this.PBoxMatchState.Size = new System.Drawing.Size(12, 12);
            this.PBoxMatchState.TabIndex = 2;
            this.PBoxMatchState.TabStop = false;
            // 
            // matchStatus
            // 
            this.matchStatus.AutoSize = true;
            this.matchStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.matchStatus.Location = new System.Drawing.Point(80, 3);
            this.matchStatus.Name = "matchStatus";
            this.matchStatus.Size = new System.Drawing.Size(35, 13);
            this.matchStatus.TabIndex = 3;
            this.matchStatus.Text = "label1";
            // 
            // MatchShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.matchStatus);
            this.Controls.Add(this.PBoxMatchState);
            this.Controls.Add(this.HalfResult);
            this.Controls.Add(this.matchResult);
            this.Controls.Add(this.awayTeam);
            this.Controls.Add(this.homeTeam);
            this.Controls.Add(this.matchTime);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 0);
            this.Name = "MatchShow";
            this.Size = new System.Drawing.Size(495, 20);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMatchState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchTime;
        private System.Windows.Forms.Label awayTeam;
        private System.Windows.Forms.Label matchResult;
        private System.Windows.Forms.Label HalfResult;
        private System.Windows.Forms.PictureBox PBoxMatchState;
        private System.Windows.Forms.Label homeTeam;
        private System.Windows.Forms.Label matchStatus;
    }
}
