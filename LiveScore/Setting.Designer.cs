
namespace LiveScore
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.chkListCountry = new System.Windows.Forms.CheckedListBox();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            this.BtnDeselectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(216, 256);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(297, 256);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancella";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // chkListCountry
            // 
            this.chkListCountry.FormattingEnabled = true;
            this.chkListCountry.Location = new System.Drawing.Point(12, 19);
            this.chkListCountry.Name = "chkListCountry";
            this.chkListCountry.Size = new System.Drawing.Size(360, 199);
            this.chkListCountry.TabIndex = 2;
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.Location = new System.Drawing.Point(21, 224);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(108, 23);
            this.BtnSelectAll.TabIndex = 3;
            this.BtnSelectAll.Text = "Seleziona tutto";
            this.BtnSelectAll.UseVisualStyleBackColor = true;
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // BtnDeselectAll
            // 
            this.BtnDeselectAll.Location = new System.Drawing.Point(144, 224);
            this.BtnDeselectAll.Name = "BtnDeselectAll";
            this.BtnDeselectAll.Size = new System.Drawing.Size(104, 23);
            this.BtnDeselectAll.TabIndex = 3;
            this.BtnDeselectAll.Text = "Deseleziona tutto";
            this.BtnDeselectAll.UseVisualStyleBackColor = true;
            this.BtnDeselectAll.Click += new System.EventHandler(this.BtnDeselectAll_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.BtnDeselectAll);
            this.Controls.Add(this.BtnSelectAll);
            this.Controls.Add(this.chkListCountry);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filtro Campionati";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckedListBox chkListCountry;
        private System.Windows.Forms.Button BtnSelectAll;
        private System.Windows.Forms.Button BtnDeselectAll;
    }
}